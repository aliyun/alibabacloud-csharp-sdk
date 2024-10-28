// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.EasyGene20210315.Models;

namespace AlibabaCloud.SDK.EasyGene20210315
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("easygene", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>暂停任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbortRunResponse
        /// </returns>
        public AbortRunResponse AbortRunWithOptions(AbortRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortRun",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbortRunResponse
        /// </returns>
        public async Task<AbortRunResponse> AbortRunWithOptionsAsync(AbortRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortRun",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortRunRequest
        /// </param>
        /// 
        /// <returns>
        /// AbortRunResponse
        /// </returns>
        public AbortRunResponse AbortRun(AbortRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AbortRunWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortRunRequest
        /// </param>
        /// 
        /// <returns>
        /// AbortRunResponse
        /// </returns>
        public async Task<AbortRunResponse> AbortRunAsync(AbortRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AbortRunWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortSubmissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbortSubmissionResponse
        /// </returns>
        public AbortSubmissionResponse AbortSubmissionWithOptions(AbortSubmissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmissionId))
            {
                query["SubmissionId"] = request.SubmissionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortSubmission",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortSubmissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortSubmissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbortSubmissionResponse
        /// </returns>
        public async Task<AbortSubmissionResponse> AbortSubmissionWithOptionsAsync(AbortSubmissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmissionId))
            {
                query["SubmissionId"] = request.SubmissionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortSubmission",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortSubmissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortSubmissionRequest
        /// </param>
        /// 
        /// <returns>
        /// AbortSubmissionResponse
        /// </returns>
        public AbortSubmissionResponse AbortSubmission(AbortSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AbortSubmissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortSubmissionRequest
        /// </param>
        /// 
        /// <returns>
        /// AbortSubmissionResponse
        /// </returns>
        public async Task<AbortSubmissionResponse> AbortSubmissionAsync(AbortSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AbortSubmissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拷贝公共数据集的数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyPublicEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyPublicEntityResponse
        /// </returns>
        public CopyPublicEntityResponse CopyPublicEntityWithOptions(CopyPublicEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dataset))
            {
                query["Dataset"] = request.Dataset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyPublicEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyPublicEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拷贝公共数据集的数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyPublicEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyPublicEntityResponse
        /// </returns>
        public async Task<CopyPublicEntityResponse> CopyPublicEntityWithOptionsAsync(CopyPublicEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dataset))
            {
                query["Dataset"] = request.Dataset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyPublicEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyPublicEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拷贝公共数据集的数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyPublicEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyPublicEntityResponse
        /// </returns>
        public CopyPublicEntityResponse CopyPublicEntity(CopyPublicEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyPublicEntityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拷贝公共数据集的数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyPublicEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyPublicEntityResponse
        /// </returns>
        public async Task<CopyPublicEntityResponse> CopyPublicEntityAsync(CopyPublicEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyPublicEntityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppResponse
        /// </returns>
        public CreateAppResponse CreateAppWithOptions(CreateAppRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppShrinkRequest request = new CreateAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Configs))
            {
                request.ConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Configs, "Configs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Dependencies))
            {
                request.DependenciesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Dependencies, "Dependencies", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageVersion))
            {
                query["LanguageVersion"] = request.LanguageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionComment))
            {
                query["RevisionComment"] = request.RevisionComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionTag))
            {
                query["RevisionTag"] = request.RevisionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsShrink))
            {
                body["Configs"] = request.ConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DependenciesShrink))
            {
                body["Dependencies"] = request.DependenciesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Documentation))
            {
                body["Documentation"] = request.Documentation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppResponse
        /// </returns>
        public async Task<CreateAppResponse> CreateAppWithOptionsAsync(CreateAppRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppShrinkRequest request = new CreateAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Configs))
            {
                request.ConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Configs, "Configs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Dependencies))
            {
                request.DependenciesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Dependencies, "Dependencies", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageVersion))
            {
                query["LanguageVersion"] = request.LanguageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionComment))
            {
                query["RevisionComment"] = request.RevisionComment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionTag))
            {
                query["RevisionTag"] = request.RevisionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigsShrink))
            {
                body["Configs"] = request.ConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DependenciesShrink))
            {
                body["Dependencies"] = request.DependenciesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Documentation))
            {
                body["Documentation"] = request.Documentation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppResponse
        /// </returns>
        public CreateAppResponse CreateApp(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppResponse
        /// </returns>
        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表格</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEntityResponse
        /// </returns>
        public CreateEntityResponse CreateEntityWithOptions(CreateEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEntityShrinkRequest request = new CreateEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityItems))
            {
                request.EntityItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityItems, "EntityItems", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityItemsShrink))
            {
                body["EntityItems"] = request.EntityItemsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表格</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEntityResponse
        /// </returns>
        public async Task<CreateEntityResponse> CreateEntityWithOptionsAsync(CreateEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEntityShrinkRequest request = new CreateEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityItems))
            {
                request.EntityItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityItems, "EntityItems", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityItemsShrink))
            {
                body["EntityItems"] = request.EntityItemsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEntityResponse
        /// </returns>
        public CreateEntityResponse CreateEntity(CreateEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEntityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEntityResponse
        /// </returns>
        public async Task<CreateEntityResponse> CreateEntityAsync(CreateEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEntityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRunResponse
        /// </returns>
        public CreateRunResponse CreateRunWithOptions(CreateRunRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRunShrinkRequest request = new CreateRunShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecuteOptions))
            {
                request.ExecuteOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecuteOptions, "ExecuteOptions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppRevision))
            {
                query["AppRevision"] = request.AppRevision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRuntime))
            {
                query["DefaultRuntime"] = request.DefaultRuntime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteDirectory))
            {
                query["ExecuteDirectory"] = request.ExecuteDirectory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteOptionsShrink))
            {
                query["ExecuteOptions"] = request.ExecuteOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Inputs))
            {
                query["Inputs"] = request.Inputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFolder))
            {
                query["OutputFolder"] = request.OutputFolder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionTag))
            {
                query["RevisionTag"] = request.RevisionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunName))
            {
                query["RunName"] = request.RunName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRun",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRunResponse
        /// </returns>
        public async Task<CreateRunResponse> CreateRunWithOptionsAsync(CreateRunRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRunShrinkRequest request = new CreateRunShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExecuteOptions))
            {
                request.ExecuteOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExecuteOptions, "ExecuteOptions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppRevision))
            {
                query["AppRevision"] = request.AppRevision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRuntime))
            {
                query["DefaultRuntime"] = request.DefaultRuntime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteDirectory))
            {
                query["ExecuteDirectory"] = request.ExecuteDirectory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteOptionsShrink))
            {
                query["ExecuteOptions"] = request.ExecuteOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Inputs))
            {
                query["Inputs"] = request.Inputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFolder))
            {
                query["OutputFolder"] = request.OutputFolder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionTag))
            {
                query["RevisionTag"] = request.RevisionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunName))
            {
                query["RunName"] = request.RunName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRun",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRunRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRunResponse
        /// </returns>
        public CreateRunResponse CreateRun(CreateRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRunWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRunRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRunResponse
        /// </returns>
        public async Task<CreateRunResponse> CreateRunAsync(CreateRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRunWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建提交</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSubmissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSubmissionResponse
        /// </returns>
        public CreateSubmissionResponse CreateSubmissionWithOptions(CreateSubmissionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSubmissionShrinkRequest request = new CreateSubmissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityNames))
            {
                request.EntityNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityNames, "EntityNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRuntime))
            {
                query["DefaultRuntime"] = request.DefaultRuntime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityNamesShrink))
            {
                query["EntityNames"] = request.EntityNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteDirectory))
            {
                query["ExecuteDirectory"] = request.ExecuteDirectory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteOptions))
            {
                query["ExecuteOptions"] = request.ExecuteOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Inputs))
            {
                query["Inputs"] = request.Inputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFolder))
            {
                query["OutputFolder"] = request.OutputFolder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Outputs))
            {
                query["Outputs"] = request.Outputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Revision))
            {
                query["Revision"] = request.Revision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionTag))
            {
                query["RevisionTag"] = request.RevisionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubmission",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubmissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建提交</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSubmissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSubmissionResponse
        /// </returns>
        public async Task<CreateSubmissionResponse> CreateSubmissionWithOptionsAsync(CreateSubmissionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSubmissionShrinkRequest request = new CreateSubmissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityNames))
            {
                request.EntityNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityNames, "EntityNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRuntime))
            {
                query["DefaultRuntime"] = request.DefaultRuntime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityNamesShrink))
            {
                query["EntityNames"] = request.EntityNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteDirectory))
            {
                query["ExecuteDirectory"] = request.ExecuteDirectory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteOptions))
            {
                query["ExecuteOptions"] = request.ExecuteOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Inputs))
            {
                query["Inputs"] = request.Inputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFolder))
            {
                query["OutputFolder"] = request.OutputFolder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Outputs))
            {
                query["Outputs"] = request.Outputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Revision))
            {
                query["Revision"] = request.Revision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionTag))
            {
                query["RevisionTag"] = request.RevisionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubmission",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubmissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建提交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSubmissionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSubmissionResponse
        /// </returns>
        public CreateSubmissionResponse CreateSubmission(CreateSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubmissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建提交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSubmissionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSubmissionResponse
        /// </returns>
        public async Task<CreateSubmissionResponse> CreateSubmissionAsync(CreateSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubmissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public CreateTemplateResponse CreateTemplateWithOptions(CreateTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTemplateShrinkRequest request = new CreateTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputsExpression))
            {
                request.InputsExpressionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputsExpression, "InputsExpression", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutputsExpression))
            {
                request.OutputsExpressionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutputsExpression, "OutputsExpression", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppRevision))
            {
                query["AppRevision"] = request.AppRevision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionTag))
            {
                query["RevisionTag"] = request.RevisionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootEntity))
            {
                query["RootEntity"] = request.RootEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputsExpressionShrink))
            {
                body["InputsExpression"] = request.InputsExpressionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputsExpressionShrink))
            {
                body["OutputsExpression"] = request.OutputsExpressionShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public async Task<CreateTemplateResponse> CreateTemplateWithOptionsAsync(CreateTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTemplateShrinkRequest request = new CreateTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputsExpression))
            {
                request.InputsExpressionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputsExpression, "InputsExpression", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutputsExpression))
            {
                request.OutputsExpressionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutputsExpression, "OutputsExpression", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppRevision))
            {
                query["AppRevision"] = request.AppRevision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionTag))
            {
                query["RevisionTag"] = request.RevisionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootEntity))
            {
                query["RootEntity"] = request.RootEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputsExpressionShrink))
            {
                body["InputsExpression"] = request.InputsExpressionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputsExpressionShrink))
            {
                body["OutputsExpression"] = request.OutputsExpressionShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTemplateResponse
        /// </returns>
        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspaceWithOptions(CreateWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobLifecycle))
            {
                query["JobLifecycle"] = request.JobLifecycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                query["Storage"] = request.Storage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceWithOptionsAsync(CreateWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobLifecycle))
            {
                query["JobLifecycle"] = request.JobLifecycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                query["Storage"] = request.Storage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppResponse
        /// </returns>
        public DeleteAppResponse DeleteAppWithOptions(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Revision))
            {
                query["Revision"] = request.Revision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppResponse
        /// </returns>
        public async Task<DeleteAppResponse> DeleteAppWithOptionsAsync(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Revision))
            {
                query["Revision"] = request.Revision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppResponse
        /// </returns>
        public DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppResponse
        /// </returns>
        public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实体表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityResponse
        /// </returns>
        public DeleteEntityResponse DeleteEntityWithOptions(DeleteEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实体表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityResponse
        /// </returns>
        public async Task<DeleteEntityResponse> DeleteEntityWithOptionsAsync(DeleteEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实体表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityResponse
        /// </returns>
        public DeleteEntityResponse DeleteEntity(DeleteEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEntityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实体表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityResponse
        /// </returns>
        public async Task<DeleteEntityResponse> DeleteEntityAsync(DeleteEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEntityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表格的条目</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteEntityItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityItemsResponse
        /// </returns>
        public DeleteEntityItemsResponse DeleteEntityItemsWithOptions(DeleteEntityItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteEntityItemsShrinkRequest request = new DeleteEntityItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityNames))
            {
                request.EntityNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityNames, "EntityNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityNamesShrink))
            {
                query["EntityNames"] = request.EntityNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEntityItems",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEntityItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表格的条目</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteEntityItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityItemsResponse
        /// </returns>
        public async Task<DeleteEntityItemsResponse> DeleteEntityItemsWithOptionsAsync(DeleteEntityItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteEntityItemsShrinkRequest request = new DeleteEntityItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityNames))
            {
                request.EntityNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityNames, "EntityNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityNamesShrink))
            {
                query["EntityNames"] = request.EntityNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEntityItems",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEntityItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表格的条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEntityItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityItemsResponse
        /// </returns>
        public DeleteEntityItemsResponse DeleteEntityItems(DeleteEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEntityItemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表格的条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEntityItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEntityItemsResponse
        /// </returns>
        public async Task<DeleteEntityItemsResponse> DeleteEntityItemsAsync(DeleteEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEntityItemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRunResponse
        /// </returns>
        public DeleteRunResponse DeleteRunWithOptions(DeleteRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRun",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRunResponse
        /// </returns>
        public async Task<DeleteRunResponse> DeleteRunWithOptionsAsync(DeleteRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRun",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRunRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRunResponse
        /// </returns>
        public DeleteRunResponse DeleteRun(DeleteRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRunWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRunRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRunResponse
        /// </returns>
        public async Task<DeleteRunResponse> DeleteRunAsync(DeleteRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRunWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSubmissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubmissionResponse
        /// </returns>
        public DeleteSubmissionResponse DeleteSubmissionWithOptions(DeleteSubmissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmissionId))
            {
                query["SubmissionId"] = request.SubmissionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubmission",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubmissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSubmissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubmissionResponse
        /// </returns>
        public async Task<DeleteSubmissionResponse> DeleteSubmissionWithOptionsAsync(DeleteSubmissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmissionId))
            {
                query["SubmissionId"] = request.SubmissionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubmission",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubmissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSubmissionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubmissionResponse
        /// </returns>
        public DeleteSubmissionResponse DeleteSubmission(DeleteSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSubmissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSubmissionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubmissionResponse
        /// </returns>
        public async Task<DeleteSubmissionResponse> DeleteSubmissionAsync(DeleteSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSubmissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public DeleteTemplateResponse DeleteTemplateWithOptions(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplateResponse
        /// </returns>
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspaceWithOptions(DeleteWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceWithOptionsAsync(DeleteWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWorkspace",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public DeleteWorkspaceResponse DeleteWorkspace(DeleteWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWorkspaceResponse
        /// </returns>
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(DeleteWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载数据表格</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DownloadEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DownloadEntityResponse
        /// </returns>
        public DownloadEntityResponse DownloadEntityWithOptions(DownloadEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DownloadEntityShrinkRequest request = new DownloadEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityNames))
            {
                request.EntityNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityNames, "EntityNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityNamesShrink))
            {
                query["EntityNames"] = request.EntityNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载数据表格</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DownloadEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DownloadEntityResponse
        /// </returns>
        public async Task<DownloadEntityResponse> DownloadEntityWithOptionsAsync(DownloadEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DownloadEntityShrinkRequest request = new DownloadEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityNames))
            {
                request.EntityNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityNames, "EntityNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityNamesShrink))
            {
                query["EntityNames"] = request.EntityNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DownloadEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DownloadEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DownloadEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// DownloadEntityResponse
        /// </returns>
        public DownloadEntityResponse DownloadEntity(DownloadEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadEntityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DownloadEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// DownloadEntityResponse
        /// </returns>
        public async Task<DownloadEntityResponse> DownloadEntityAsync(DownloadEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadEntityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppResponse
        /// </returns>
        public GetAppResponse GetAppWithOptions(GetAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Revision))
            {
                query["Revision"] = request.Revision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionTag))
            {
                query["RevisionTag"] = request.RevisionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppResponse
        /// </returns>
        public async Task<GetAppResponse> GetAppWithOptionsAsync(GetAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Revision))
            {
                query["Revision"] = request.Revision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionTag))
            {
                query["RevisionTag"] = request.RevisionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppResponse
        /// </returns>
        public GetAppResponse GetApp(GetAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppResponse
        /// </returns>
        public async Task<GetAppResponse> GetAppAsync(GetAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据表格信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEntityResponse
        /// </returns>
        public GetEntityResponse GetEntityWithOptions(GetEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据表格信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEntityResponse
        /// </returns>
        public async Task<GetEntityResponse> GetEntityWithOptionsAsync(GetEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据表格信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEntityResponse
        /// </returns>
        public GetEntityResponse GetEntity(GetEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEntityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询数据表格信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEntityResponse
        /// </returns>
        public async Task<GetEntityResponse> GetEntityAsync(GetEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEntityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共应用详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetGlobalAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGlobalAppResponse
        /// </returns>
        public GetGlobalAppResponse GetGlobalAppWithOptions(GetGlobalAppRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetGlobalAppShrinkRequest request = new GetGlobalAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Attributes))
            {
                request.AttributesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Attributes, "Attributes", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGlobalApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGlobalAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共应用详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetGlobalAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGlobalAppResponse
        /// </returns>
        public async Task<GetGlobalAppResponse> GetGlobalAppWithOptionsAsync(GetGlobalAppRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetGlobalAppShrinkRequest request = new GetGlobalAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Attributes))
            {
                request.AttributesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Attributes, "Attributes", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGlobalApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGlobalAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共应用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGlobalAppRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGlobalAppResponse
        /// </returns>
        public GetGlobalAppResponse GetGlobalApp(GetGlobalAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGlobalAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共应用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGlobalAppRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGlobalAppResponse
        /// </returns>
        public async Task<GetGlobalAppResponse> GetGlobalAppAsync(GetGlobalAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGlobalAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetPublicDatasetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPublicDatasetResponse
        /// </returns>
        public GetPublicDatasetResponse GetPublicDatasetWithOptions(GetPublicDatasetRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPublicDatasetShrinkRequest request = new GetPublicDatasetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Attributes))
            {
                request.AttributesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Attributes, "Attributes", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublicDataset",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublicDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetPublicDatasetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPublicDatasetResponse
        /// </returns>
        public async Task<GetPublicDatasetResponse> GetPublicDatasetWithOptionsAsync(GetPublicDatasetRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPublicDatasetShrinkRequest request = new GetPublicDatasetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Attributes))
            {
                request.AttributesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Attributes, "Attributes", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublicDataset",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublicDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublicDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPublicDatasetResponse
        /// </returns>
        public GetPublicDatasetResponse GetPublicDataset(GetPublicDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPublicDatasetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublicDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPublicDatasetResponse
        /// </returns>
        public async Task<GetPublicDatasetResponse> GetPublicDatasetAsync(GetPublicDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPublicDatasetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集特定的实体定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublicDatasetEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPublicDatasetEntityResponse
        /// </returns>
        public GetPublicDatasetEntityResponse GetPublicDatasetEntityWithOptions(GetPublicDatasetEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublicDatasetEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublicDatasetEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集特定的实体定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublicDatasetEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPublicDatasetEntityResponse
        /// </returns>
        public async Task<GetPublicDatasetEntityResponse> GetPublicDatasetEntityWithOptionsAsync(GetPublicDatasetEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublicDatasetEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublicDatasetEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集特定的实体定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublicDatasetEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPublicDatasetEntityResponse
        /// </returns>
        public GetPublicDatasetEntityResponse GetPublicDatasetEntity(GetPublicDatasetEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPublicDatasetEntityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集特定的实体定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPublicDatasetEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPublicDatasetEntityResponse
        /// </returns>
        public async Task<GetPublicDatasetEntityResponse> GetPublicDatasetEntityAsync(GetPublicDatasetEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPublicDatasetEntityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunResponse
        /// </returns>
        public GetRunResponse GetRunWithOptions(GetRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRun",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunResponse
        /// </returns>
        public async Task<GetRunResponse> GetRunWithOptionsAsync(GetRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRun",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunResponse
        /// </returns>
        public GetRunResponse GetRun(GetRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRunWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunResponse
        /// </returns>
        public async Task<GetRunResponse> GetRunAsync(GetRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRunWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取投递详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubmissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubmissionResponse
        /// </returns>
        public GetSubmissionResponse GetSubmissionWithOptions(GetSubmissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubmission",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubmissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取投递详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubmissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubmissionResponse
        /// </returns>
        public async Task<GetSubmissionResponse> GetSubmissionWithOptionsAsync(GetSubmissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubmission",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubmissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取投递详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubmissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubmissionResponse
        /// </returns>
        public GetSubmissionResponse GetSubmission(GetSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubmissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取投递详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubmissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubmissionResponse
        /// </returns>
        public async Task<GetSubmissionResponse> GetSubmissionAsync(GetSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubmissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用模板的详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplateWithOptions(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用模板的详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用模板的详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用模板的详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询工作空间详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspaceWithOptions(GetWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询工作空间详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(GetWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询工作空间详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public GetWorkspaceResponse GetWorkspace(GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询工作空间详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWorkspaceResponse
        /// </returns>
        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入应用。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportAppResponse
        /// </returns>
        public ImportAppResponse ImportAppWithOptions(ImportAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入应用。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportAppResponse
        /// </returns>
        public async Task<ImportAppResponse> ImportAppWithOptionsAsync(ImportAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入应用。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportAppRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportAppResponse
        /// </returns>
        public ImportAppResponse ImportApp(ImportAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入应用。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportAppRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportAppResponse
        /// </returns>
        public async Task<ImportAppResponse> ImportAppAsync(ImportAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装平台公共应用到工作空间中。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallGlobalAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallGlobalAppResponse
        /// </returns>
        public InstallGlobalAppResponse InstallGlobalAppWithOptions(InstallGlobalAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstalledAppName))
            {
                query["InstalledAppName"] = request.InstalledAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallGlobalApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallGlobalAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装平台公共应用到工作空间中。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallGlobalAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallGlobalAppResponse
        /// </returns>
        public async Task<InstallGlobalAppResponse> InstallGlobalAppWithOptionsAsync(InstallGlobalAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstalledAppName))
            {
                query["InstalledAppName"] = request.InstalledAppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallGlobalApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallGlobalAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装平台公共应用到工作空间中。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallGlobalAppRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallGlobalAppResponse
        /// </returns>
        public InstallGlobalAppResponse InstallGlobalApp(InstallGlobalAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallGlobalAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装平台公共应用到工作空间中。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallGlobalAppRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallGlobalAppResponse
        /// </returns>
        public async Task<InstallGlobalAppResponse> InstallGlobalAppAsync(InstallGlobalAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallGlobalAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppsResponse
        /// </returns>
        public ListAppsResponse ListAppsWithOptions(ListAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsReversed))
            {
                query["IsReversed"] = request.IsReversed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelector))
            {
                query["LabelSelector"] = request.LabelSelector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApps",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppsResponse
        /// </returns>
        public async Task<ListAppsResponse> ListAppsWithOptionsAsync(ListAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsReversed))
            {
                query["IsReversed"] = request.IsReversed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelector))
            {
                query["LabelSelector"] = request.LabelSelector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApps",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppsResponse
        /// </returns>
        public ListAppsResponse ListApps(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppsResponse
        /// </returns>
        public async Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台第三方软件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizedSoftwareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedSoftwareResponse
        /// </returns>
        public ListAuthorizedSoftwareResponse ListAuthorizedSoftwareWithOptions(ListAuthorizedSoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedSoftware",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedSoftwareResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台第三方软件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizedSoftwareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedSoftwareResponse
        /// </returns>
        public async Task<ListAuthorizedSoftwareResponse> ListAuthorizedSoftwareWithOptionsAsync(ListAuthorizedSoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizedSoftware",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizedSoftwareResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台第三方软件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizedSoftwareRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedSoftwareResponse
        /// </returns>
        public ListAuthorizedSoftwareResponse ListAuthorizedSoftware(ListAuthorizedSoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthorizedSoftwareWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台第三方软件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizedSoftwareRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizedSoftwareResponse
        /// </returns>
        public async Task<ListAuthorizedSoftwareResponse> ListAuthorizedSoftwareAsync(ListAuthorizedSoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthorizedSoftwareWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台公共容器镜像列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContainerImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContainerImagesResponse
        /// </returns>
        public ListContainerImagesResponse ListContainerImagesWithOptions(ListContainerImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContainerImages",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContainerImagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台公共容器镜像列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContainerImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContainerImagesResponse
        /// </returns>
        public async Task<ListContainerImagesResponse> ListContainerImagesWithOptionsAsync(ListContainerImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContainerImages",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContainerImagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台公共容器镜像列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContainerImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContainerImagesResponse
        /// </returns>
        public ListContainerImagesResponse ListContainerImages(ListContainerImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContainerImagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台公共容器镜像列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListContainerImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContainerImagesResponse
        /// </returns>
        public async Task<ListContainerImagesResponse> ListContainerImagesAsync(ListContainerImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContainerImagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出数据实体列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEntitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEntitiesResponse
        /// </returns>
        public ListEntitiesResponse ListEntitiesWithOptions(ListEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEntities",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEntitiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出数据实体列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEntitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEntitiesResponse
        /// </returns>
        public async Task<ListEntitiesResponse> ListEntitiesWithOptionsAsync(ListEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEntities",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEntitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出数据实体列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEntitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEntitiesResponse
        /// </returns>
        public ListEntitiesResponse ListEntities(ListEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEntitiesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出数据实体列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEntitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEntitiesResponse
        /// </returns>
        public async Task<ListEntitiesResponse> ListEntitiesAsync(ListEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEntitiesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出数据表格的条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEntityItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEntityItemsResponse
        /// </returns>
        public ListEntityItemsResponse ListEntityItemsWithOptions(ListEntityItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsReversed))
            {
                query["IsReversed"] = request.IsReversed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEntityItems",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEntityItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出数据表格的条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEntityItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEntityItemsResponse
        /// </returns>
        public async Task<ListEntityItemsResponse> ListEntityItemsWithOptionsAsync(ListEntityItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsReversed))
            {
                query["IsReversed"] = request.IsReversed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEntityItems",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEntityItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出数据表格的条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEntityItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEntityItemsResponse
        /// </returns>
        public ListEntityItemsResponse ListEntityItems(ListEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEntityItemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出数据表格的条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEntityItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEntityItemsResponse
        /// </returns>
        public async Task<ListEntityItemsResponse> ListEntityItemsAsync(ListEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEntityItemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台公共应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGlobalAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGlobalAppsResponse
        /// </returns>
        public ListGlobalAppsResponse ListGlobalAppsWithOptions(ListGlobalAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGlobalApps",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGlobalAppsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台公共应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGlobalAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGlobalAppsResponse
        /// </returns>
        public async Task<ListGlobalAppsResponse> ListGlobalAppsWithOptionsAsync(ListGlobalAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGlobalApps",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGlobalAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台公共应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGlobalAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGlobalAppsResponse
        /// </returns>
        public ListGlobalAppsResponse ListGlobalApps(ListGlobalAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGlobalAppsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台公共应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGlobalAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGlobalAppsResponse
        /// </returns>
        public async Task<ListGlobalAppsResponse> ListGlobalAppsAsync(ListGlobalAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGlobalAppsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台公共数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetResponse
        /// </returns>
        public ListPublicDatasetResponse ListPublicDatasetWithOptions(ListPublicDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublicDataset",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublicDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台公共数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetResponse
        /// </returns>
        public async Task<ListPublicDatasetResponse> ListPublicDatasetWithOptionsAsync(ListPublicDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublicDataset",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublicDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台公共数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetResponse
        /// </returns>
        public ListPublicDatasetResponse ListPublicDataset(ListPublicDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublicDatasetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取平台公共数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetResponse
        /// </returns>
        public async Task<ListPublicDatasetResponse> ListPublicDatasetAsync(ListPublicDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublicDatasetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集包含的实体列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetEntitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetEntitiesResponse
        /// </returns>
        public ListPublicDatasetEntitiesResponse ListPublicDatasetEntitiesWithOptions(ListPublicDatasetEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublicDatasetEntities",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublicDatasetEntitiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集包含的实体列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetEntitiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetEntitiesResponse
        /// </returns>
        public async Task<ListPublicDatasetEntitiesResponse> ListPublicDatasetEntitiesWithOptionsAsync(ListPublicDatasetEntitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublicDatasetEntities",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublicDatasetEntitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集包含的实体列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetEntitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetEntitiesResponse
        /// </returns>
        public ListPublicDatasetEntitiesResponse ListPublicDatasetEntities(ListPublicDatasetEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublicDatasetEntitiesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集包含的实体列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetEntitiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetEntitiesResponse
        /// </returns>
        public async Task<ListPublicDatasetEntitiesResponse> ListPublicDatasetEntitiesAsync(ListPublicDatasetEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublicDatasetEntitiesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集特定的实体表格数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetEntityItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetEntityItemsResponse
        /// </returns>
        public ListPublicDatasetEntityItemsResponse ListPublicDatasetEntityItemsWithOptions(ListPublicDatasetEntityItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublicDatasetEntityItems",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublicDatasetEntityItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集特定的实体表格数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetEntityItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetEntityItemsResponse
        /// </returns>
        public async Task<ListPublicDatasetEntityItemsResponse> ListPublicDatasetEntityItemsWithOptionsAsync(ListPublicDatasetEntityItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublicDatasetEntityItems",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublicDatasetEntityItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集特定的实体表格数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetEntityItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetEntityItemsResponse
        /// </returns>
        public ListPublicDatasetEntityItemsResponse ListPublicDatasetEntityItems(ListPublicDatasetEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublicDatasetEntityItemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询平台公共数据集特定的实体表格数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetEntityItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetEntityItemsResponse
        /// </returns>
        public async Task<ListPublicDatasetEntityItemsResponse> ListPublicDatasetEntityItemsAsync(ListPublicDatasetEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublicDatasetEntityItemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出所有公共数据集标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetTagsResponse
        /// </returns>
        public ListPublicDatasetTagsResponse ListPublicDatasetTagsWithOptions(ListPublicDatasetTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublicDatasetTags",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublicDatasetTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出所有公共数据集标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetTagsResponse
        /// </returns>
        public async Task<ListPublicDatasetTagsResponse> ListPublicDatasetTagsWithOptionsAsync(ListPublicDatasetTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublicDatasetTags",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublicDatasetTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出所有公共数据集标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetTagsResponse
        /// </returns>
        public ListPublicDatasetTagsResponse ListPublicDatasetTags(ListPublicDatasetTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublicDatasetTagsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出所有公共数据集标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublicDatasetTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublicDatasetTagsResponse
        /// </returns>
        public async Task<ListPublicDatasetTagsResponse> ListPublicDatasetTagsAsync(ListPublicDatasetTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublicDatasetTagsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询基因分析平台产品的可用地域。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询基因分析平台产品的可用地域。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询基因分析平台产品的可用地域。</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询基因分析平台产品的可用地域。</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRunsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRunsResponse
        /// </returns>
        public ListRunsResponse ListRunsWithOptions(ListRunsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRuns",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRunsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRunsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRunsResponse
        /// </returns>
        public async Task<ListRunsResponse> ListRunsWithOptionsAsync(ListRunsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRuns",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRunsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRunsResponse
        /// </returns>
        public ListRunsResponse ListRuns(ListRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRunsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRunsResponse
        /// </returns>
        public async Task<ListRunsResponse> ListRunsAsync(ListRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRunsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubmissionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubmissionsResponse
        /// </returns>
        public ListSubmissionsResponse ListSubmissionsWithOptions(ListSubmissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubmissions",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubmissionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubmissionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubmissionsResponse
        /// </returns>
        public async Task<ListSubmissionsResponse> ListSubmissionsWithOptionsAsync(ListSubmissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubmissions",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubmissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubmissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubmissionsResponse
        /// </returns>
        public ListSubmissionsResponse ListSubmissions(ListSubmissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSubmissionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubmissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubmissionsResponse
        /// </returns>
        public async Task<ListSubmissionsResponse> ListSubmissionsAsync(ListSubmissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSubmissionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出应用模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsReversed))
            {
                query["IsReversed"] = request.IsReversed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelector))
            {
                query["LabelSelector"] = request.LabelSelector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出应用模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsReversed))
            {
                query["IsReversed"] = request.IsReversed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelector))
            {
                query["LabelSelector"] = request.LabelSelector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出应用模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出应用模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>最近任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserActiveRunsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserActiveRunsResponse
        /// </returns>
        public ListUserActiveRunsResponse ListUserActiveRunsWithOptions(ListUserActiveRunsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserActiveRuns",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserActiveRunsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>最近任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserActiveRunsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserActiveRunsResponse
        /// </returns>
        public async Task<ListUserActiveRunsResponse> ListUserActiveRunsWithOptionsAsync(ListUserActiveRunsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserActiveRuns",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserActiveRunsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>最近任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserActiveRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserActiveRunsResponse
        /// </returns>
        public ListUserActiveRunsResponse ListUserActiveRuns(ListUserActiveRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserActiveRunsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>最近任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserActiveRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserActiveRunsResponse
        /// </returns>
        public async Task<ListUserActiveRunsResponse> ListUserActiveRunsAsync(ListUserActiveRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserActiveRunsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspacesWithOptions(ListWorkspacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesWithOptionsAsync(ListWorkspacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkspacesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkspacesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeSubmissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeSubmissionResponse
        /// </returns>
        public ResumeSubmissionResponse ResumeSubmissionWithOptions(ResumeSubmissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmissionId))
            {
                query["SubmissionId"] = request.SubmissionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeSubmission",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeSubmissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeSubmissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeSubmissionResponse
        /// </returns>
        public async Task<ResumeSubmissionResponse> ResumeSubmissionWithOptionsAsync(ResumeSubmissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmissionId))
            {
                query["SubmissionId"] = request.SubmissionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeSubmission",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeSubmissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeSubmissionRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeSubmissionResponse
        /// </returns>
        public ResumeSubmissionResponse ResumeSubmission(ResumeSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeSubmissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复投递</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeSubmissionRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeSubmissionResponse
        /// </returns>
        public async Task<ResumeSubmissionResponse> ResumeSubmissionAsync(ResumeSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeSubmissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用版本打标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagAppResponse
        /// </returns>
        public TagAppResponse TagAppWithOptions(TagAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppRevision))
            {
                query["AppRevision"] = request.AppRevision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionTag))
            {
                query["RevisionTag"] = request.RevisionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用版本打标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagAppResponse
        /// </returns>
        public async Task<TagAppResponse> TagAppWithOptionsAsync(TagAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppRevision))
            {
                query["AppRevision"] = request.AppRevision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionTag))
            {
                query["RevisionTag"] = request.RevisionTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagApp",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用版本打标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagAppRequest
        /// </param>
        /// 
        /// <returns>
        /// TagAppResponse
        /// </returns>
        public TagAppResponse TagApp(TagAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用版本打标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagAppRequest
        /// </param>
        /// 
        /// <returns>
        /// TagAppResponse
        /// </returns>
        public async Task<TagAppResponse> TagAppAsync(TagAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateEntity is deprecated, please use EasyGene::2021-03-15::UpdateEntityItems instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据表格</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEntityResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateEntity is deprecated, please use EasyGene::2021-03-15::UpdateEntityItems instead.\n")]
        // Deprecated
        public UpdateEntityResponse UpdateEntityWithOptions(UpdateEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEntityShrinkRequest request = new UpdateEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityItems))
            {
                request.EntityItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityItems, "EntityItems", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityItemsShrink))
            {
                body["EntityItems"] = request.EntityItemsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateEntity is deprecated, please use EasyGene::2021-03-15::UpdateEntityItems instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据表格</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEntityResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateEntity is deprecated, please use EasyGene::2021-03-15::UpdateEntityItems instead.\n")]
        // Deprecated
        public async Task<UpdateEntityResponse> UpdateEntityWithOptionsAsync(UpdateEntityRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEntityShrinkRequest request = new UpdateEntityShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityItems))
            {
                request.EntityItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityItems, "EntityItems", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityItemsShrink))
            {
                body["EntityItems"] = request.EntityItemsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateEntity is deprecated, please use EasyGene::2021-03-15::UpdateEntityItems instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEntityResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateEntity is deprecated, please use EasyGene::2021-03-15::UpdateEntityItems instead.\n")]
        // Deprecated
        public UpdateEntityResponse UpdateEntity(UpdateEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEntityWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateEntity is deprecated, please use EasyGene::2021-03-15::UpdateEntityItems instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEntityResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateEntity is deprecated, please use EasyGene::2021-03-15::UpdateEntityItems instead.\n")]
        // Deprecated
        public async Task<UpdateEntityResponse> UpdateEntityAsync(UpdateEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEntityWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改表格数据</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateEntityItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEntityItemsResponse
        /// </returns>
        public UpdateEntityItemsResponse UpdateEntityItemsWithOptions(UpdateEntityItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEntityItemsShrinkRequest request = new UpdateEntityItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityItems))
            {
                request.EntityItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityItems, "EntityItems", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityItemsShrink))
            {
                body["EntityItems"] = request.EntityItemsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEntityItems",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEntityItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改表格数据</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateEntityItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEntityItemsResponse
        /// </returns>
        public async Task<UpdateEntityItemsResponse> UpdateEntityItemsWithOptionsAsync(UpdateEntityItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEntityItemsShrinkRequest request = new UpdateEntityItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EntityItems))
            {
                request.EntityItemsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EntityItems, "EntityItems", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityType))
            {
                query["EntityType"] = request.EntityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityItemsShrink))
            {
                body["EntityItems"] = request.EntityItemsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEntityItems",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEntityItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改表格数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEntityItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEntityItemsResponse
        /// </returns>
        public UpdateEntityItemsResponse UpdateEntityItems(UpdateEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEntityItemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改表格数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEntityItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEntityItemsResponse
        /// </returns>
        public async Task<UpdateEntityItemsResponse> UpdateEntityItemsAsync(UpdateEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEntityItemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public UpdateTemplateResponse UpdateTemplateWithOptions(UpdateTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTemplateShrinkRequest request = new UpdateTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputsExpression))
            {
                request.InputsExpressionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputsExpression, "InputsExpression", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutputsExpression))
            {
                request.OutputsExpressionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutputsExpression, "OutputsExpression", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootEntity))
            {
                query["RootEntity"] = request.RootEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputsExpressionShrink))
            {
                body["InputsExpression"] = request.InputsExpressionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputsExpressionShrink))
            {
                body["OutputsExpression"] = request.OutputsExpressionShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用模板</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(UpdateTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTemplateShrinkRequest request = new UpdateTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputsExpression))
            {
                request.InputsExpressionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputsExpression, "InputsExpression", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutputsExpression))
            {
                request.OutputsExpressionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutputsExpression, "OutputsExpression", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootEntity))
            {
                query["RootEntity"] = request.RootEntity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputsExpressionShrink))
            {
                body["InputsExpression"] = request.InputsExpressionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputsExpressionShrink))
            {
                body["OutputsExpression"] = request.OutputsExpressionShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改应用模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTemplateResponse
        /// </returns>
        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public UpdateWorkspaceResponse UpdateWorkspaceWithOptions(UpdateWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobLifecycle))
            {
                query["JobLifecycle"] = request.JobLifecycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspace",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public async Task<UpdateWorkspaceResponse> UpdateWorkspaceWithOptionsAsync(UpdateWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobLifecycle))
            {
                query["JobLifecycle"] = request.JobLifecycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkspace",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public UpdateWorkspaceResponse UpdateWorkspace(UpdateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改工作空间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWorkspaceResponse
        /// </returns>
        public async Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(UpdateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadEntityResponse
        /// </returns>
        public UploadEntityResponse UploadEntityWithOptions(UploadEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityCSVFile))
            {
                query["EntityCSVFile"] = request.EntityCSVFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadEntityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadEntityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadEntityResponse
        /// </returns>
        public async Task<UploadEntityResponse> UploadEntityWithOptionsAsync(UploadEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityCSVFile))
            {
                query["EntityCSVFile"] = request.EntityCSVFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workspace))
            {
                query["Workspace"] = request.Workspace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadEntity",
                Version = "2021-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadEntityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadEntityResponse
        /// </returns>
        public UploadEntityResponse UploadEntity(UploadEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadEntityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传数据表格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadEntityRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadEntityResponse
        /// </returns>
        public async Task<UploadEntityResponse> UploadEntityAsync(UploadEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadEntityWithOptionsAsync(request, runtime);
        }

    }
}
