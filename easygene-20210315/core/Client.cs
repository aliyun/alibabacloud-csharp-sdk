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

        /**
         * @summary 暂停任务
         *
         * @param request AbortRunRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AbortRunResponse
         */
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

        /**
         * @summary 暂停任务
         *
         * @param request AbortRunRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AbortRunResponse
         */
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

        /**
         * @summary 暂停任务
         *
         * @param request AbortRunRequest
         * @return AbortRunResponse
         */
        public AbortRunResponse AbortRun(AbortRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AbortRunWithOptions(request, runtime);
        }

        /**
         * @summary 暂停任务
         *
         * @param request AbortRunRequest
         * @return AbortRunResponse
         */
        public async Task<AbortRunResponse> AbortRunAsync(AbortRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AbortRunWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 取消投递
         *
         * @param request AbortSubmissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AbortSubmissionResponse
         */
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

        /**
         * @summary 取消投递
         *
         * @param request AbortSubmissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AbortSubmissionResponse
         */
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

        /**
         * @summary 取消投递
         *
         * @param request AbortSubmissionRequest
         * @return AbortSubmissionResponse
         */
        public AbortSubmissionResponse AbortSubmission(AbortSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AbortSubmissionWithOptions(request, runtime);
        }

        /**
         * @summary 取消投递
         *
         * @param request AbortSubmissionRequest
         * @return AbortSubmissionResponse
         */
        public async Task<AbortSubmissionResponse> AbortSubmissionAsync(AbortSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AbortSubmissionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 拷贝公共数据集的数据表格
         *
         * @param request CopyPublicEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyPublicEntityResponse
         */
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

        /**
         * @summary 拷贝公共数据集的数据表格
         *
         * @param request CopyPublicEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyPublicEntityResponse
         */
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

        /**
         * @summary 拷贝公共数据集的数据表格
         *
         * @param request CopyPublicEntityRequest
         * @return CopyPublicEntityResponse
         */
        public CopyPublicEntityResponse CopyPublicEntity(CopyPublicEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyPublicEntityWithOptions(request, runtime);
        }

        /**
         * @summary 拷贝公共数据集的数据表格
         *
         * @param request CopyPublicEntityRequest
         * @return CopyPublicEntityResponse
         */
        public async Task<CopyPublicEntityResponse> CopyPublicEntityAsync(CopyPublicEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyPublicEntityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建应用
         *
         * @param tmpReq CreateAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppResponse
         */
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

        /**
         * @summary 创建应用
         *
         * @param tmpReq CreateAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppResponse
         */
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

        /**
         * @summary 创建应用
         *
         * @param request CreateAppRequest
         * @return CreateAppResponse
         */
        public CreateAppResponse CreateApp(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppWithOptions(request, runtime);
        }

        /**
         * @summary 创建应用
         *
         * @param request CreateAppRequest
         * @return CreateAppResponse
         */
        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建数据表格
         *
         * @param tmpReq CreateEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEntityResponse
         */
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

        /**
         * @summary 创建数据表格
         *
         * @param tmpReq CreateEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEntityResponse
         */
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

        /**
         * @summary 创建数据表格
         *
         * @param request CreateEntityRequest
         * @return CreateEntityResponse
         */
        public CreateEntityResponse CreateEntity(CreateEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEntityWithOptions(request, runtime);
        }

        /**
         * @summary 创建数据表格
         *
         * @param request CreateEntityRequest
         * @return CreateEntityResponse
         */
        public async Task<CreateEntityResponse> CreateEntityAsync(CreateEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEntityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建任务
         *
         * @param tmpReq CreateRunRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRunResponse
         */
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

        /**
         * @summary 创建任务
         *
         * @param tmpReq CreateRunRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRunResponse
         */
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

        /**
         * @summary 创建任务
         *
         * @param request CreateRunRequest
         * @return CreateRunResponse
         */
        public CreateRunResponse CreateRun(CreateRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRunWithOptions(request, runtime);
        }

        /**
         * @summary 创建任务
         *
         * @param request CreateRunRequest
         * @return CreateRunResponse
         */
        public async Task<CreateRunResponse> CreateRunAsync(CreateRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRunWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建提交
         *
         * @param tmpReq CreateSubmissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSubmissionResponse
         */
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

        /**
         * @summary 创建提交
         *
         * @param tmpReq CreateSubmissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSubmissionResponse
         */
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

        /**
         * @summary 创建提交
         *
         * @param request CreateSubmissionRequest
         * @return CreateSubmissionResponse
         */
        public CreateSubmissionResponse CreateSubmission(CreateSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubmissionWithOptions(request, runtime);
        }

        /**
         * @summary 创建提交
         *
         * @param request CreateSubmissionRequest
         * @return CreateSubmissionResponse
         */
        public async Task<CreateSubmissionResponse> CreateSubmissionAsync(CreateSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubmissionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建应用模板
         *
         * @param tmpReq CreateTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTemplateResponse
         */
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

        /**
         * @summary 创建应用模板
         *
         * @param tmpReq CreateTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTemplateResponse
         */
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

        /**
         * @summary 创建应用模板
         *
         * @param request CreateTemplateRequest
         * @return CreateTemplateResponse
         */
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 创建应用模板
         *
         * @param request CreateTemplateRequest
         * @return CreateTemplateResponse
         */
        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建工作空间
         *
         * @param request CreateWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWorkspaceResponse
         */
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

        /**
         * @summary 创建工作空间
         *
         * @param request CreateWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWorkspaceResponse
         */
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

        /**
         * @summary 创建工作空间
         *
         * @param request CreateWorkspaceRequest
         * @return CreateWorkspaceResponse
         */
        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWorkspaceWithOptions(request, runtime);
        }

        /**
         * @summary 创建工作空间
         *
         * @param request CreateWorkspaceRequest
         * @return CreateWorkspaceResponse
         */
        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWorkspaceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除应用
         *
         * @param request DeleteAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppResponse
         */
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

        /**
         * @summary 删除应用
         *
         * @param request DeleteAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppResponse
         */
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

        /**
         * @summary 删除应用
         *
         * @param request DeleteAppRequest
         * @return DeleteAppResponse
         */
        public DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppWithOptions(request, runtime);
        }

        /**
         * @summary 删除应用
         *
         * @param request DeleteAppRequest
         * @return DeleteAppResponse
         */
        public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除实体表格
         *
         * @param request DeleteEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEntityResponse
         */
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

        /**
         * @summary 删除实体表格
         *
         * @param request DeleteEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEntityResponse
         */
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

        /**
         * @summary 删除实体表格
         *
         * @param request DeleteEntityRequest
         * @return DeleteEntityResponse
         */
        public DeleteEntityResponse DeleteEntity(DeleteEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEntityWithOptions(request, runtime);
        }

        /**
         * @summary 删除实体表格
         *
         * @param request DeleteEntityRequest
         * @return DeleteEntityResponse
         */
        public async Task<DeleteEntityResponse> DeleteEntityAsync(DeleteEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEntityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除数据表格的条目
         *
         * @param tmpReq DeleteEntityItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEntityItemsResponse
         */
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

        /**
         * @summary 删除数据表格的条目
         *
         * @param tmpReq DeleteEntityItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEntityItemsResponse
         */
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

        /**
         * @summary 删除数据表格的条目
         *
         * @param request DeleteEntityItemsRequest
         * @return DeleteEntityItemsResponse
         */
        public DeleteEntityItemsResponse DeleteEntityItems(DeleteEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEntityItemsWithOptions(request, runtime);
        }

        /**
         * @summary 删除数据表格的条目
         *
         * @param request DeleteEntityItemsRequest
         * @return DeleteEntityItemsResponse
         */
        public async Task<DeleteEntityItemsResponse> DeleteEntityItemsAsync(DeleteEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEntityItemsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除任务
         *
         * @param request DeleteRunRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRunResponse
         */
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

        /**
         * @summary 删除任务
         *
         * @param request DeleteRunRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRunResponse
         */
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

        /**
         * @summary 删除任务
         *
         * @param request DeleteRunRequest
         * @return DeleteRunResponse
         */
        public DeleteRunResponse DeleteRun(DeleteRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRunWithOptions(request, runtime);
        }

        /**
         * @summary 删除任务
         *
         * @param request DeleteRunRequest
         * @return DeleteRunResponse
         */
        public async Task<DeleteRunResponse> DeleteRunAsync(DeleteRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRunWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除投递
         *
         * @param request DeleteSubmissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSubmissionResponse
         */
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

        /**
         * @summary 删除投递
         *
         * @param request DeleteSubmissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSubmissionResponse
         */
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

        /**
         * @summary 删除投递
         *
         * @param request DeleteSubmissionRequest
         * @return DeleteSubmissionResponse
         */
        public DeleteSubmissionResponse DeleteSubmission(DeleteSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSubmissionWithOptions(request, runtime);
        }

        /**
         * @summary 删除投递
         *
         * @param request DeleteSubmissionRequest
         * @return DeleteSubmissionResponse
         */
        public async Task<DeleteSubmissionResponse> DeleteSubmissionAsync(DeleteSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSubmissionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除应用模板
         *
         * @param request DeleteTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTemplateResponse
         */
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

        /**
         * @summary 删除应用模板
         *
         * @param request DeleteTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTemplateResponse
         */
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

        /**
         * @summary 删除应用模板
         *
         * @param request DeleteTemplateRequest
         * @return DeleteTemplateResponse
         */
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 删除应用模板
         *
         * @param request DeleteTemplateRequest
         * @return DeleteTemplateResponse
         */
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除工作空间
         *
         * @param request DeleteWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWorkspaceResponse
         */
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

        /**
         * @summary 删除工作空间
         *
         * @param request DeleteWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWorkspaceResponse
         */
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

        /**
         * @summary 删除工作空间
         *
         * @param request DeleteWorkspaceRequest
         * @return DeleteWorkspaceResponse
         */
        public DeleteWorkspaceResponse DeleteWorkspace(DeleteWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWorkspaceWithOptions(request, runtime);
        }

        /**
         * @summary 删除工作空间
         *
         * @param request DeleteWorkspaceRequest
         * @return DeleteWorkspaceResponse
         */
        public async Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(DeleteWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWorkspaceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 下载数据表格
         *
         * @param tmpReq DownloadEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DownloadEntityResponse
         */
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

        /**
         * @summary 下载数据表格
         *
         * @param tmpReq DownloadEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DownloadEntityResponse
         */
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

        /**
         * @summary 下载数据表格
         *
         * @param request DownloadEntityRequest
         * @return DownloadEntityResponse
         */
        public DownloadEntityResponse DownloadEntity(DownloadEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadEntityWithOptions(request, runtime);
        }

        /**
         * @summary 下载数据表格
         *
         * @param request DownloadEntityRequest
         * @return DownloadEntityResponse
         */
        public async Task<DownloadEntityResponse> DownloadEntityAsync(DownloadEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadEntityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询应用详情
         *
         * @param request GetAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppResponse
         */
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

        /**
         * @summary 查询应用详情
         *
         * @param request GetAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppResponse
         */
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

        /**
         * @summary 查询应用详情
         *
         * @param request GetAppRequest
         * @return GetAppResponse
         */
        public GetAppResponse GetApp(GetAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppWithOptions(request, runtime);
        }

        /**
         * @summary 查询应用详情
         *
         * @param request GetAppRequest
         * @return GetAppResponse
         */
        public async Task<GetAppResponse> GetAppAsync(GetAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询数据表格信息
         *
         * @param request GetEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEntityResponse
         */
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

        /**
         * @summary 查询数据表格信息
         *
         * @param request GetEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEntityResponse
         */
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

        /**
         * @summary 查询数据表格信息
         *
         * @param request GetEntityRequest
         * @return GetEntityResponse
         */
        public GetEntityResponse GetEntity(GetEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEntityWithOptions(request, runtime);
        }

        /**
         * @summary 查询数据表格信息
         *
         * @param request GetEntityRequest
         * @return GetEntityResponse
         */
        public async Task<GetEntityResponse> GetEntityAsync(GetEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEntityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询平台公共应用详情
         *
         * @param tmpReq GetGlobalAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGlobalAppResponse
         */
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

        /**
         * @summary 查询平台公共应用详情
         *
         * @param tmpReq GetGlobalAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGlobalAppResponse
         */
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

        /**
         * @summary 查询平台公共应用详情
         *
         * @param request GetGlobalAppRequest
         * @return GetGlobalAppResponse
         */
        public GetGlobalAppResponse GetGlobalApp(GetGlobalAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGlobalAppWithOptions(request, runtime);
        }

        /**
         * @summary 查询平台公共应用详情
         *
         * @param request GetGlobalAppRequest
         * @return GetGlobalAppResponse
         */
        public async Task<GetGlobalAppResponse> GetGlobalAppAsync(GetGlobalAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGlobalAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询平台公共数据集详情
         *
         * @param tmpReq GetPublicDatasetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublicDatasetResponse
         */
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

        /**
         * @summary 查询平台公共数据集详情
         *
         * @param tmpReq GetPublicDatasetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublicDatasetResponse
         */
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

        /**
         * @summary 查询平台公共数据集详情
         *
         * @param request GetPublicDatasetRequest
         * @return GetPublicDatasetResponse
         */
        public GetPublicDatasetResponse GetPublicDataset(GetPublicDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPublicDatasetWithOptions(request, runtime);
        }

        /**
         * @summary 查询平台公共数据集详情
         *
         * @param request GetPublicDatasetRequest
         * @return GetPublicDatasetResponse
         */
        public async Task<GetPublicDatasetResponse> GetPublicDatasetAsync(GetPublicDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPublicDatasetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询平台公共数据集特定的实体定义
         *
         * @param request GetPublicDatasetEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublicDatasetEntityResponse
         */
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

        /**
         * @summary 查询平台公共数据集特定的实体定义
         *
         * @param request GetPublicDatasetEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublicDatasetEntityResponse
         */
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

        /**
         * @summary 查询平台公共数据集特定的实体定义
         *
         * @param request GetPublicDatasetEntityRequest
         * @return GetPublicDatasetEntityResponse
         */
        public GetPublicDatasetEntityResponse GetPublicDatasetEntity(GetPublicDatasetEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPublicDatasetEntityWithOptions(request, runtime);
        }

        /**
         * @summary 查询平台公共数据集特定的实体定义
         *
         * @param request GetPublicDatasetEntityRequest
         * @return GetPublicDatasetEntityResponse
         */
        public async Task<GetPublicDatasetEntityResponse> GetPublicDatasetEntityAsync(GetPublicDatasetEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPublicDatasetEntityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取任务详情
         *
         * @param request GetRunRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRunResponse
         */
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

        /**
         * @summary 获取任务详情
         *
         * @param request GetRunRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRunResponse
         */
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

        /**
         * @summary 获取任务详情
         *
         * @param request GetRunRequest
         * @return GetRunResponse
         */
        public GetRunResponse GetRun(GetRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRunWithOptions(request, runtime);
        }

        /**
         * @summary 获取任务详情
         *
         * @param request GetRunRequest
         * @return GetRunResponse
         */
        public async Task<GetRunResponse> GetRunAsync(GetRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRunWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取投递详情
         *
         * @param request GetSubmissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubmissionResponse
         */
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

        /**
         * @summary 获取投递详情
         *
         * @param request GetSubmissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubmissionResponse
         */
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

        /**
         * @summary 获取投递详情
         *
         * @param request GetSubmissionRequest
         * @return GetSubmissionResponse
         */
        public GetSubmissionResponse GetSubmission(GetSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubmissionWithOptions(request, runtime);
        }

        /**
         * @summary 获取投递详情
         *
         * @param request GetSubmissionRequest
         * @return GetSubmissionResponse
         */
        public async Task<GetSubmissionResponse> GetSubmissionAsync(GetSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubmissionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询应用模板的详情
         *
         * @param request GetTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateResponse
         */
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

        /**
         * @summary 查询应用模板的详情
         *
         * @param request GetTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateResponse
         */
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

        /**
         * @summary 查询应用模板的详情
         *
         * @param request GetTemplateRequest
         * @return GetTemplateResponse
         */
        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 查询应用模板的详情
         *
         * @param request GetTemplateRequest
         * @return GetTemplateResponse
         */
        public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询工作空间详情
         *
         * @param request GetWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkspaceResponse
         */
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

        /**
         * @summary 查询工作空间详情
         *
         * @param request GetWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkspaceResponse
         */
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

        /**
         * @summary 查询工作空间详情
         *
         * @param request GetWorkspaceRequest
         * @return GetWorkspaceResponse
         */
        public GetWorkspaceResponse GetWorkspace(GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkspaceWithOptions(request, runtime);
        }

        /**
         * @summary 查询工作空间详情
         *
         * @param request GetWorkspaceRequest
         * @return GetWorkspaceResponse
         */
        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(GetWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkspaceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导入应用。
         *
         * @param request ImportAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportAppResponse
         */
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

        /**
         * @summary 导入应用。
         *
         * @param request ImportAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportAppResponse
         */
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

        /**
         * @summary 导入应用。
         *
         * @param request ImportAppRequest
         * @return ImportAppResponse
         */
        public ImportAppResponse ImportApp(ImportAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportAppWithOptions(request, runtime);
        }

        /**
         * @summary 导入应用。
         *
         * @param request ImportAppRequest
         * @return ImportAppResponse
         */
        public async Task<ImportAppResponse> ImportAppAsync(ImportAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 安装平台公共应用到工作空间中。
         *
         * @param request InstallGlobalAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallGlobalAppResponse
         */
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

        /**
         * @summary 安装平台公共应用到工作空间中。
         *
         * @param request InstallGlobalAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallGlobalAppResponse
         */
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

        /**
         * @summary 安装平台公共应用到工作空间中。
         *
         * @param request InstallGlobalAppRequest
         * @return InstallGlobalAppResponse
         */
        public InstallGlobalAppResponse InstallGlobalApp(InstallGlobalAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallGlobalAppWithOptions(request, runtime);
        }

        /**
         * @summary 安装平台公共应用到工作空间中。
         *
         * @param request InstallGlobalAppRequest
         * @return InstallGlobalAppResponse
         */
        public async Task<InstallGlobalAppResponse> InstallGlobalAppAsync(InstallGlobalAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallGlobalAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出应用
         *
         * @param request ListAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppsResponse
         */
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

        /**
         * @summary 列出应用
         *
         * @param request ListAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppsResponse
         */
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

        /**
         * @summary 列出应用
         *
         * @param request ListAppsRequest
         * @return ListAppsResponse
         */
        public ListAppsResponse ListApps(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppsWithOptions(request, runtime);
        }

        /**
         * @summary 列出应用
         *
         * @param request ListAppsRequest
         * @return ListAppsResponse
         */
        public async Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取平台第三方软件列表
         *
         * @param request ListAuthorizedSoftwareRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAuthorizedSoftwareResponse
         */
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

        /**
         * @summary 获取平台第三方软件列表
         *
         * @param request ListAuthorizedSoftwareRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAuthorizedSoftwareResponse
         */
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

        /**
         * @summary 获取平台第三方软件列表
         *
         * @param request ListAuthorizedSoftwareRequest
         * @return ListAuthorizedSoftwareResponse
         */
        public ListAuthorizedSoftwareResponse ListAuthorizedSoftware(ListAuthorizedSoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthorizedSoftwareWithOptions(request, runtime);
        }

        /**
         * @summary 获取平台第三方软件列表
         *
         * @param request ListAuthorizedSoftwareRequest
         * @return ListAuthorizedSoftwareResponse
         */
        public async Task<ListAuthorizedSoftwareResponse> ListAuthorizedSoftwareAsync(ListAuthorizedSoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthorizedSoftwareWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取平台公共容器镜像列表
         *
         * @param request ListContainerImagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListContainerImagesResponse
         */
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

        /**
         * @summary 获取平台公共容器镜像列表
         *
         * @param request ListContainerImagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListContainerImagesResponse
         */
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

        /**
         * @summary 获取平台公共容器镜像列表
         *
         * @param request ListContainerImagesRequest
         * @return ListContainerImagesResponse
         */
        public ListContainerImagesResponse ListContainerImages(ListContainerImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContainerImagesWithOptions(request, runtime);
        }

        /**
         * @summary 获取平台公共容器镜像列表
         *
         * @param request ListContainerImagesRequest
         * @return ListContainerImagesResponse
         */
        public async Task<ListContainerImagesResponse> ListContainerImagesAsync(ListContainerImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContainerImagesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出数据实体列表
         *
         * @param request ListEntitiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEntitiesResponse
         */
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

        /**
         * @summary 列出数据实体列表
         *
         * @param request ListEntitiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEntitiesResponse
         */
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

        /**
         * @summary 列出数据实体列表
         *
         * @param request ListEntitiesRequest
         * @return ListEntitiesResponse
         */
        public ListEntitiesResponse ListEntities(ListEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEntitiesWithOptions(request, runtime);
        }

        /**
         * @summary 列出数据实体列表
         *
         * @param request ListEntitiesRequest
         * @return ListEntitiesResponse
         */
        public async Task<ListEntitiesResponse> ListEntitiesAsync(ListEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEntitiesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出数据表格的条目
         *
         * @param request ListEntityItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEntityItemsResponse
         */
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

        /**
         * @summary 列出数据表格的条目
         *
         * @param request ListEntityItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEntityItemsResponse
         */
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

        /**
         * @summary 列出数据表格的条目
         *
         * @param request ListEntityItemsRequest
         * @return ListEntityItemsResponse
         */
        public ListEntityItemsResponse ListEntityItems(ListEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEntityItemsWithOptions(request, runtime);
        }

        /**
         * @summary 列出数据表格的条目
         *
         * @param request ListEntityItemsRequest
         * @return ListEntityItemsResponse
         */
        public async Task<ListEntityItemsResponse> ListEntityItemsAsync(ListEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEntityItemsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取平台公共应用列表
         *
         * @param request ListGlobalAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGlobalAppsResponse
         */
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

        /**
         * @summary 获取平台公共应用列表
         *
         * @param request ListGlobalAppsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGlobalAppsResponse
         */
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

        /**
         * @summary 获取平台公共应用列表
         *
         * @param request ListGlobalAppsRequest
         * @return ListGlobalAppsResponse
         */
        public ListGlobalAppsResponse ListGlobalApps(ListGlobalAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGlobalAppsWithOptions(request, runtime);
        }

        /**
         * @summary 获取平台公共应用列表
         *
         * @param request ListGlobalAppsRequest
         * @return ListGlobalAppsResponse
         */
        public async Task<ListGlobalAppsResponse> ListGlobalAppsAsync(ListGlobalAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGlobalAppsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取平台公共数据集列表
         *
         * @param request ListPublicDatasetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublicDatasetResponse
         */
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

        /**
         * @summary 获取平台公共数据集列表
         *
         * @param request ListPublicDatasetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublicDatasetResponse
         */
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

        /**
         * @summary 获取平台公共数据集列表
         *
         * @param request ListPublicDatasetRequest
         * @return ListPublicDatasetResponse
         */
        public ListPublicDatasetResponse ListPublicDataset(ListPublicDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublicDatasetWithOptions(request, runtime);
        }

        /**
         * @summary 获取平台公共数据集列表
         *
         * @param request ListPublicDatasetRequest
         * @return ListPublicDatasetResponse
         */
        public async Task<ListPublicDatasetResponse> ListPublicDatasetAsync(ListPublicDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublicDatasetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询平台公共数据集包含的实体列表
         *
         * @param request ListPublicDatasetEntitiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublicDatasetEntitiesResponse
         */
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

        /**
         * @summary 查询平台公共数据集包含的实体列表
         *
         * @param request ListPublicDatasetEntitiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublicDatasetEntitiesResponse
         */
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

        /**
         * @summary 查询平台公共数据集包含的实体列表
         *
         * @param request ListPublicDatasetEntitiesRequest
         * @return ListPublicDatasetEntitiesResponse
         */
        public ListPublicDatasetEntitiesResponse ListPublicDatasetEntities(ListPublicDatasetEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublicDatasetEntitiesWithOptions(request, runtime);
        }

        /**
         * @summary 查询平台公共数据集包含的实体列表
         *
         * @param request ListPublicDatasetEntitiesRequest
         * @return ListPublicDatasetEntitiesResponse
         */
        public async Task<ListPublicDatasetEntitiesResponse> ListPublicDatasetEntitiesAsync(ListPublicDatasetEntitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublicDatasetEntitiesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询平台公共数据集特定的实体表格数据
         *
         * @param request ListPublicDatasetEntityItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublicDatasetEntityItemsResponse
         */
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

        /**
         * @summary 查询平台公共数据集特定的实体表格数据
         *
         * @param request ListPublicDatasetEntityItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublicDatasetEntityItemsResponse
         */
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

        /**
         * @summary 查询平台公共数据集特定的实体表格数据
         *
         * @param request ListPublicDatasetEntityItemsRequest
         * @return ListPublicDatasetEntityItemsResponse
         */
        public ListPublicDatasetEntityItemsResponse ListPublicDatasetEntityItems(ListPublicDatasetEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublicDatasetEntityItemsWithOptions(request, runtime);
        }

        /**
         * @summary 查询平台公共数据集特定的实体表格数据
         *
         * @param request ListPublicDatasetEntityItemsRequest
         * @return ListPublicDatasetEntityItemsResponse
         */
        public async Task<ListPublicDatasetEntityItemsResponse> ListPublicDatasetEntityItemsAsync(ListPublicDatasetEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublicDatasetEntityItemsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出所有公共数据集标签
         *
         * @param request ListPublicDatasetTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublicDatasetTagsResponse
         */
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

        /**
         * @summary 列出所有公共数据集标签
         *
         * @param request ListPublicDatasetTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublicDatasetTagsResponse
         */
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

        /**
         * @summary 列出所有公共数据集标签
         *
         * @param request ListPublicDatasetTagsRequest
         * @return ListPublicDatasetTagsResponse
         */
        public ListPublicDatasetTagsResponse ListPublicDatasetTags(ListPublicDatasetTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublicDatasetTagsWithOptions(request, runtime);
        }

        /**
         * @summary 列出所有公共数据集标签
         *
         * @param request ListPublicDatasetTagsRequest
         * @return ListPublicDatasetTagsResponse
         */
        public async Task<ListPublicDatasetTagsResponse> ListPublicDatasetTagsAsync(ListPublicDatasetTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublicDatasetTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询基因分析平台产品的可用地域。
         *
         * @param request ListRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegionsResponse
         */
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

        /**
         * @summary 查询基因分析平台产品的可用地域。
         *
         * @param request ListRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegionsResponse
         */
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

        /**
         * @summary 查询基因分析平台产品的可用地域。
         *
         * @return ListRegionsResponse
         */
        public ListRegionsResponse ListRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(runtime);
        }

        /**
         * @summary 查询基因分析平台产品的可用地域。
         *
         * @return ListRegionsResponse
         */
        public async Task<ListRegionsResponse> ListRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(runtime);
        }

        /**
         * @summary 列出任务
         *
         * @param request ListRunsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRunsResponse
         */
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

        /**
         * @summary 列出任务
         *
         * @param request ListRunsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRunsResponse
         */
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

        /**
         * @summary 列出任务
         *
         * @param request ListRunsRequest
         * @return ListRunsResponse
         */
        public ListRunsResponse ListRuns(ListRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRunsWithOptions(request, runtime);
        }

        /**
         * @summary 列出任务
         *
         * @param request ListRunsRequest
         * @return ListRunsResponse
         */
        public async Task<ListRunsResponse> ListRunsAsync(ListRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRunsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出投递
         *
         * @param request ListSubmissionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubmissionsResponse
         */
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

        /**
         * @summary 列出投递
         *
         * @param request ListSubmissionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubmissionsResponse
         */
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

        /**
         * @summary 列出投递
         *
         * @param request ListSubmissionsRequest
         * @return ListSubmissionsResponse
         */
        public ListSubmissionsResponse ListSubmissions(ListSubmissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSubmissionsWithOptions(request, runtime);
        }

        /**
         * @summary 列出投递
         *
         * @param request ListSubmissionsRequest
         * @return ListSubmissionsResponse
         */
        public async Task<ListSubmissionsResponse> ListSubmissionsAsync(ListSubmissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSubmissionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出应用模板
         *
         * @param request ListTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTemplatesResponse
         */
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

        /**
         * @summary 列出应用模板
         *
         * @param request ListTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTemplatesResponse
         */
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

        /**
         * @summary 列出应用模板
         *
         * @param request ListTemplatesRequest
         * @return ListTemplatesResponse
         */
        public ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary 列出应用模板
         *
         * @param request ListTemplatesRequest
         * @return ListTemplatesResponse
         */
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 最近任务列表
         *
         * @param request ListUserActiveRunsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserActiveRunsResponse
         */
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

        /**
         * @summary 最近任务列表
         *
         * @param request ListUserActiveRunsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserActiveRunsResponse
         */
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

        /**
         * @summary 最近任务列表
         *
         * @param request ListUserActiveRunsRequest
         * @return ListUserActiveRunsResponse
         */
        public ListUserActiveRunsResponse ListUserActiveRuns(ListUserActiveRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserActiveRunsWithOptions(request, runtime);
        }

        /**
         * @summary 最近任务列表
         *
         * @param request ListUserActiveRunsRequest
         * @return ListUserActiveRunsResponse
         */
        public async Task<ListUserActiveRunsResponse> ListUserActiveRunsAsync(ListUserActiveRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserActiveRunsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出工作空间
         *
         * @param request ListWorkspacesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkspacesResponse
         */
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

        /**
         * @summary 列出工作空间
         *
         * @param request ListWorkspacesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWorkspacesResponse
         */
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

        /**
         * @summary 列出工作空间
         *
         * @param request ListWorkspacesRequest
         * @return ListWorkspacesResponse
         */
        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkspacesWithOptions(request, runtime);
        }

        /**
         * @summary 列出工作空间
         *
         * @param request ListWorkspacesRequest
         * @return ListWorkspacesResponse
         */
        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkspacesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 恢复投递
         *
         * @param request ResumeSubmissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeSubmissionResponse
         */
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

        /**
         * @summary 恢复投递
         *
         * @param request ResumeSubmissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeSubmissionResponse
         */
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

        /**
         * @summary 恢复投递
         *
         * @param request ResumeSubmissionRequest
         * @return ResumeSubmissionResponse
         */
        public ResumeSubmissionResponse ResumeSubmission(ResumeSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeSubmissionWithOptions(request, runtime);
        }

        /**
         * @summary 恢复投递
         *
         * @param request ResumeSubmissionRequest
         * @return ResumeSubmissionResponse
         */
        public async Task<ResumeSubmissionResponse> ResumeSubmissionAsync(ResumeSubmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeSubmissionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用版本打标
         *
         * @param request TagAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagAppResponse
         */
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

        /**
         * @summary 应用版本打标
         *
         * @param request TagAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagAppResponse
         */
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

        /**
         * @summary 应用版本打标
         *
         * @param request TagAppRequest
         * @return TagAppResponse
         */
        public TagAppResponse TagApp(TagAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagAppWithOptions(request, runtime);
        }

        /**
         * @summary 应用版本打标
         *
         * @param request TagAppRequest
         * @return TagAppResponse
         */
        public async Task<TagAppResponse> TagAppAsync(TagAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagAppWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI UpdateEntity is deprecated, please use EasyGene::2021-03-15::UpdateEntityItems instead.
         *
         * @summary 修改数据表格
         *
         * @param tmpReq UpdateEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEntityResponse
         */
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

        /**
         * @deprecated OpenAPI UpdateEntity is deprecated, please use EasyGene::2021-03-15::UpdateEntityItems instead.
         *
         * @summary 修改数据表格
         *
         * @param tmpReq UpdateEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEntityResponse
         */
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

        /**
         * @deprecated OpenAPI UpdateEntity is deprecated, please use EasyGene::2021-03-15::UpdateEntityItems instead.
         *
         * @summary 修改数据表格
         *
         * @param request UpdateEntityRequest
         * @return UpdateEntityResponse
         */
        // Deprecated
        public UpdateEntityResponse UpdateEntity(UpdateEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEntityWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI UpdateEntity is deprecated, please use EasyGene::2021-03-15::UpdateEntityItems instead.
         *
         * @summary 修改数据表格
         *
         * @param request UpdateEntityRequest
         * @return UpdateEntityResponse
         */
        // Deprecated
        public async Task<UpdateEntityResponse> UpdateEntityAsync(UpdateEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEntityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改表格数据
         *
         * @param tmpReq UpdateEntityItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEntityItemsResponse
         */
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

        /**
         * @summary 修改表格数据
         *
         * @param tmpReq UpdateEntityItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEntityItemsResponse
         */
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

        /**
         * @summary 修改表格数据
         *
         * @param request UpdateEntityItemsRequest
         * @return UpdateEntityItemsResponse
         */
        public UpdateEntityItemsResponse UpdateEntityItems(UpdateEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEntityItemsWithOptions(request, runtime);
        }

        /**
         * @summary 修改表格数据
         *
         * @param request UpdateEntityItemsRequest
         * @return UpdateEntityItemsResponse
         */
        public async Task<UpdateEntityItemsResponse> UpdateEntityItemsAsync(UpdateEntityItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEntityItemsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改应用模板
         *
         * @param tmpReq UpdateTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTemplateResponse
         */
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

        /**
         * @summary 修改应用模板
         *
         * @param tmpReq UpdateTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTemplateResponse
         */
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

        /**
         * @summary 修改应用模板
         *
         * @param request UpdateTemplateRequest
         * @return UpdateTemplateResponse
         */
        public UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 修改应用模板
         *
         * @param request UpdateTemplateRequest
         * @return UpdateTemplateResponse
         */
        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改工作空间
         *
         * @param request UpdateWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkspaceResponse
         */
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

        /**
         * @summary 修改工作空间
         *
         * @param request UpdateWorkspaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkspaceResponse
         */
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

        /**
         * @summary 修改工作空间
         *
         * @param request UpdateWorkspaceRequest
         * @return UpdateWorkspaceResponse
         */
        public UpdateWorkspaceResponse UpdateWorkspace(UpdateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWorkspaceWithOptions(request, runtime);
        }

        /**
         * @summary 修改工作空间
         *
         * @param request UpdateWorkspaceRequest
         * @return UpdateWorkspaceResponse
         */
        public async Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(UpdateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWorkspaceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 上传数据表格
         *
         * @param request UploadEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadEntityResponse
         */
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

        /**
         * @summary 上传数据表格
         *
         * @param request UploadEntityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadEntityResponse
         */
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

        /**
         * @summary 上传数据表格
         *
         * @param request UploadEntityRequest
         * @return UploadEntityResponse
         */
        public UploadEntityResponse UploadEntity(UploadEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadEntityWithOptions(request, runtime);
        }

        /**
         * @summary 上传数据表格
         *
         * @param request UploadEntityRequest
         * @return UploadEntityResponse
         */
        public async Task<UploadEntityResponse> UploadEntityAsync(UploadEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadEntityWithOptionsAsync(request, runtime);
        }

    }
}
