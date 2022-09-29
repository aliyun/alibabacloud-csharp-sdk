// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OpenSearch20171225.Models;

namespace AlibabaCloud.SDK.OpenSearch20171225
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("opensearch", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public BindESUserAnalyzerResponse BindESUserAnalyzer(string appGroupIdentity, string esInstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BindESUserAnalyzerWithOptions(appGroupIdentity, esInstanceId, headers, runtime);
        }

        public async Task<BindESUserAnalyzerResponse> BindESUserAnalyzerAsync(string appGroupIdentity, string esInstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BindESUserAnalyzerWithOptionsAsync(appGroupIdentity, esInstanceId, headers, runtime);
        }

        public BindESUserAnalyzerResponse BindESUserAnalyzerWithOptions(string appGroupIdentity, string esInstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindESUserAnalyzer",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/es/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(esInstanceId) + "/actions/bind-analyzer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindESUserAnalyzerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindESUserAnalyzerResponse> BindESUserAnalyzerWithOptionsAsync(string appGroupIdentity, string esInstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindESUserAnalyzer",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/es/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(esInstanceId) + "/actions/bind-analyzer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindESUserAnalyzerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindEsInstanceResponse BindEsInstance(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BindEsInstanceWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<BindEsInstanceResponse> BindEsInstanceAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BindEsInstanceWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public BindEsInstanceResponse BindEsInstanceWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindEsInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/actions/bind-es-instance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindEsInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindEsInstanceResponse> BindEsInstanceWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindEsInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/actions/bind-es-instance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindEsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CompileSortScriptResponse CompileSortScript(string appGroupIdentity, string scriptName, string appVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CompileSortScriptWithOptions(appGroupIdentity, scriptName, appVersionId, headers, runtime);
        }

        public async Task<CompileSortScriptResponse> CompileSortScriptAsync(string appGroupIdentity, string scriptName, string appVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CompileSortScriptWithOptionsAsync(appGroupIdentity, scriptName, appVersionId, headers, runtime);
        }

        public CompileSortScriptResponse CompileSortScriptWithOptions(string appGroupIdentity, string scriptName, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompileSortScript",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName) + "/actions/compiling",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompileSortScriptResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CompileSortScriptResponse> CompileSortScriptWithOptionsAsync(string appGroupIdentity, string scriptName, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompileSortScript",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName) + "/actions/compiling",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompileSortScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateABTestExperimentResponse CreateABTestExperiment(string appGroupIdentity, string sceneId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateABTestExperimentWithOptions(appGroupIdentity, sceneId, groupId, headers, runtime);
        }

        public async Task<CreateABTestExperimentResponse> CreateABTestExperimentAsync(string appGroupIdentity, string sceneId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateABTestExperimentWithOptionsAsync(appGroupIdentity, sceneId, groupId, headers, runtime);
        }

        public CreateABTestExperimentResponse CreateABTestExperimentWithOptions(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateABTestExperiment",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateABTestExperimentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateABTestExperimentResponse> CreateABTestExperimentWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateABTestExperiment",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateABTestExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateABTestGroupResponse CreateABTestGroup(string appGroupIdentity, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateABTestGroupWithOptions(appGroupIdentity, sceneId, headers, runtime);
        }

        public async Task<CreateABTestGroupResponse> CreateABTestGroupAsync(string appGroupIdentity, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateABTestGroupWithOptionsAsync(appGroupIdentity, sceneId, headers, runtime);
        }

        public CreateABTestGroupResponse CreateABTestGroupWithOptions(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateABTestGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateABTestGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateABTestGroupResponse> CreateABTestGroupWithOptionsAsync(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateABTestGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateABTestGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateABTestSceneResponse CreateABTestScene(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateABTestSceneWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<CreateABTestSceneResponse> CreateABTestSceneAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateABTestSceneWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public CreateABTestSceneResponse CreateABTestSceneWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateABTestScene",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateABTestSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateABTestSceneResponse> CreateABTestSceneWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateABTestScene",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateABTestSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAppResponse CreateApp(string appGroupIdentity, CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAppWithOptions(appGroupIdentity, request, headers, runtime);
        }

        public async Task<CreateAppResponse> CreateAppAsync(string appGroupIdentity, CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAppWithOptionsAsync(appGroupIdentity, request, headers, runtime);
        }

        public CreateAppResponse CreateAppWithOptions(string appGroupIdentity, CreateAppRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAppResponse> CreateAppWithOptionsAsync(string appGroupIdentity, CreateAppRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAppGroupResponse CreateAppGroup()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAppGroupWithOptions(headers, runtime);
        }

        public async Task<CreateAppGroupResponse> CreateAppGroupAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAppGroupWithOptionsAsync(headers, runtime);
        }

        public CreateAppGroupResponse CreateAppGroupWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAppGroupResponse> CreateAppGroupWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDataCollectionResponse CreateDataCollection(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDataCollectionWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<CreateDataCollectionResponse> CreateDataCollectionAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDataCollectionWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public CreateDataCollectionResponse CreateDataCollectionWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataCollection",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/data-collections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataCollectionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDataCollectionResponse> CreateDataCollectionWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataCollection",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/data-collections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataCollectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFirstRankResponse CreateFirstRank(string appGroupIdentity, string appId, CreateFirstRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFirstRankWithOptions(appGroupIdentity, appId, request, headers, runtime);
        }

        public async Task<CreateFirstRankResponse> CreateFirstRankAsync(string appGroupIdentity, string appId, CreateFirstRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFirstRankWithOptionsAsync(appGroupIdentity, appId, request, headers, runtime);
        }

        public CreateFirstRankResponse CreateFirstRankWithOptions(string appGroupIdentity, string appId, CreateFirstRankRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFirstRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/first-ranks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFirstRankResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFirstRankResponse> CreateFirstRankWithOptionsAsync(string appGroupIdentity, string appId, CreateFirstRankRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFirstRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/first-ranks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFirstRankResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFunctionInstanceResponse CreateFunctionInstance(string appGroupIdentity, string functionName, CreateFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFunctionInstanceWithOptions(appGroupIdentity, functionName, request, headers, runtime);
        }

        public async Task<CreateFunctionInstanceResponse> CreateFunctionInstanceAsync(string appGroupIdentity, string functionName, CreateFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFunctionInstanceWithOptionsAsync(appGroupIdentity, functionName, request, headers, runtime);
        }

        public CreateFunctionInstanceResponse CreateFunctionInstanceWithOptions(string appGroupIdentity, string functionName, CreateFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParameters))
            {
                body["createParameters"] = request.CreateParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cron))
            {
                body["cron"] = request.Cron;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                body["functionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageParameters))
            {
                body["usageParameters"] = request.UsageParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunctionInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFunctionInstanceResponse> CreateFunctionInstanceWithOptionsAsync(string appGroupIdentity, string functionName, CreateFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParameters))
            {
                body["createParameters"] = request.CreateParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cron))
            {
                body["cron"] = request.Cron;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                body["functionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                body["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageParameters))
            {
                body["usageParameters"] = request.UsageParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunctionInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFunctionTaskResponse CreateFunctionTask(string appGroupIdentity, string functionName, string instanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFunctionTaskWithOptions(appGroupIdentity, functionName, instanceName, headers, runtime);
        }

        public async Task<CreateFunctionTaskResponse> CreateFunctionTaskAsync(string appGroupIdentity, string functionName, string instanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFunctionTaskWithOptionsAsync(appGroupIdentity, functionName, instanceName, headers, runtime);
        }

        public CreateFunctionTaskResponse CreateFunctionTaskWithOptions(string appGroupIdentity, string functionName, string instanceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunctionTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFunctionTaskResponse> CreateFunctionTaskWithOptionsAsync(string appGroupIdentity, string functionName, string instanceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFunctionTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFunctionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateInterventionDictionaryResponse CreateInterventionDictionary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInterventionDictionaryWithOptions(headers, runtime);
        }

        public async Task<CreateInterventionDictionaryResponse> CreateInterventionDictionaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInterventionDictionaryWithOptionsAsync(headers, runtime);
        }

        public CreateInterventionDictionaryResponse CreateInterventionDictionaryWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInterventionDictionary",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInterventionDictionaryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateInterventionDictionaryResponse> CreateInterventionDictionaryWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInterventionDictionary",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInterventionDictionaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateModelResponse CreateModel(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModelWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<CreateModelResponse> CreateModelAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModelWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public CreateModelResponse CreateModelWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModel",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateModelResponse> CreateModelWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModel",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateQueryProcessorResponse CreateQueryProcessor(string appGroupIdentity, string appId, CreateQueryProcessorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateQueryProcessorWithOptions(appGroupIdentity, appId, request, headers, runtime);
        }

        public async Task<CreateQueryProcessorResponse> CreateQueryProcessorAsync(string appGroupIdentity, string appId, CreateQueryProcessorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateQueryProcessorWithOptionsAsync(appGroupIdentity, appId, request, headers, runtime);
        }

        public CreateQueryProcessorResponse CreateQueryProcessorWithOptions(string appGroupIdentity, string appId, CreateQueryProcessorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQueryProcessor",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/query-processors",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQueryProcessorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateQueryProcessorResponse> CreateQueryProcessorWithOptionsAsync(string appGroupIdentity, string appId, CreateQueryProcessorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQueryProcessor",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/query-processors",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQueryProcessorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateScheduledTaskResponse CreateScheduledTask(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateScheduledTaskWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<CreateScheduledTaskResponse> CreateScheduledTaskAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateScheduledTaskWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public CreateScheduledTaskResponse CreateScheduledTaskWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scheduled-tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateScheduledTaskResponse> CreateScheduledTaskWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scheduled-tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSearchStrategyResponse CreateSearchStrategy(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSearchStrategyWithOptions(appGroupIdentity, appId, headers, runtime);
        }

        public async Task<CreateSearchStrategyResponse> CreateSearchStrategyAsync(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSearchStrategyWithOptionsAsync(appGroupIdentity, appId, headers, runtime);
        }

        public CreateSearchStrategyResponse CreateSearchStrategyWithOptions(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSearchStrategy",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/search-strategies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSearchStrategyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSearchStrategyResponse> CreateSearchStrategyWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSearchStrategy",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/search-strategies",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSearchStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSecondRankResponse CreateSecondRank(string appGroupIdentity, string appId, CreateSecondRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSecondRankWithOptions(appGroupIdentity, appId, request, headers, runtime);
        }

        public async Task<CreateSecondRankResponse> CreateSecondRankAsync(string appGroupIdentity, string appId, CreateSecondRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSecondRankWithOptionsAsync(appGroupIdentity, appId, request, headers, runtime);
        }

        public CreateSecondRankResponse CreateSecondRankWithOptions(string appGroupIdentity, string appId, CreateSecondRankRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecondRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/second-ranks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecondRankResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSecondRankResponse> CreateSecondRankWithOptionsAsync(string appGroupIdentity, string appId, CreateSecondRankRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecondRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/second-ranks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecondRankResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSortScriptResponse CreateSortScript(string appGroupIdentity, string appVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSortScriptWithOptions(appGroupIdentity, appVersionId, headers, runtime);
        }

        public async Task<CreateSortScriptResponse> CreateSortScriptAsync(string appGroupIdentity, string appVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSortScriptWithOptionsAsync(appGroupIdentity, appVersionId, headers, runtime);
        }

        public CreateSortScriptResponse CreateSortScriptWithOptions(string appGroupIdentity, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSortScript",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSortScriptResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSortScriptResponse> CreateSortScriptWithOptionsAsync(string appGroupIdentity, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSortScript",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSortScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateUserAnalyzerResponse CreateUserAnalyzer()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateUserAnalyzerWithOptions(headers, runtime);
        }

        public async Task<CreateUserAnalyzerResponse> CreateUserAnalyzerAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateUserAnalyzerWithOptionsAsync(headers, runtime);
        }

        public CreateUserAnalyzerResponse CreateUserAnalyzerWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserAnalyzer",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/user-analyzers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserAnalyzerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateUserAnalyzerResponse> CreateUserAnalyzerWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserAnalyzer",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/user-analyzers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserAnalyzerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteABTestExperimentResponse DeleteABTestExperiment(string appGroupIdentity, string sceneId, string groupId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteABTestExperimentWithOptions(appGroupIdentity, sceneId, groupId, experimentId, headers, runtime);
        }

        public async Task<DeleteABTestExperimentResponse> DeleteABTestExperimentAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteABTestExperimentWithOptionsAsync(appGroupIdentity, sceneId, groupId, experimentId, headers, runtime);
        }

        public DeleteABTestExperimentResponse DeleteABTestExperimentWithOptions(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteABTestExperiment",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteABTestExperimentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteABTestExperimentResponse> DeleteABTestExperimentWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteABTestExperiment",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteABTestExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteABTestGroupResponse DeleteABTestGroup(string appGroupIdentity, string sceneId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteABTestGroupWithOptions(appGroupIdentity, sceneId, groupId, headers, runtime);
        }

        public async Task<DeleteABTestGroupResponse> DeleteABTestGroupAsync(string appGroupIdentity, string sceneId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteABTestGroupWithOptionsAsync(appGroupIdentity, sceneId, groupId, headers, runtime);
        }

        public DeleteABTestGroupResponse DeleteABTestGroupWithOptions(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteABTestGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteABTestGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteABTestGroupResponse> DeleteABTestGroupWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteABTestGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteABTestGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteABTestSceneResponse DeleteABTestScene(string appGroupIdentity, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteABTestSceneWithOptions(appGroupIdentity, sceneId, headers, runtime);
        }

        public async Task<DeleteABTestSceneResponse> DeleteABTestSceneAsync(string appGroupIdentity, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteABTestSceneWithOptionsAsync(appGroupIdentity, sceneId, headers, runtime);
        }

        public DeleteABTestSceneResponse DeleteABTestSceneWithOptions(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteABTestScene",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteABTestSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteABTestSceneResponse> DeleteABTestSceneWithOptionsAsync(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteABTestScene",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteABTestSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFunctionInstanceResponse DeleteFunctionInstance(string appGroupIdentity, string functionName, string instanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFunctionInstanceWithOptions(appGroupIdentity, functionName, instanceName, headers, runtime);
        }

        public async Task<DeleteFunctionInstanceResponse> DeleteFunctionInstanceAsync(string appGroupIdentity, string functionName, string instanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFunctionInstanceWithOptionsAsync(appGroupIdentity, functionName, instanceName, headers, runtime);
        }

        public DeleteFunctionInstanceResponse DeleteFunctionInstanceWithOptions(string appGroupIdentity, string functionName, string instanceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunctionInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFunctionInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFunctionInstanceResponse> DeleteFunctionInstanceWithOptionsAsync(string appGroupIdentity, string functionName, string instanceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunctionInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFunctionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFunctionTaskResponse DeleteFunctionTask(string appGroupIdentity, string functionName, string instanceName, string generation)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFunctionTaskWithOptions(appGroupIdentity, functionName, instanceName, generation, headers, runtime);
        }

        public async Task<DeleteFunctionTaskResponse> DeleteFunctionTaskAsync(string appGroupIdentity, string functionName, string instanceName, string generation)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFunctionTaskWithOptionsAsync(appGroupIdentity, functionName, instanceName, generation, headers, runtime);
        }

        public DeleteFunctionTaskResponse DeleteFunctionTaskWithOptions(string appGroupIdentity, string functionName, string instanceName, string generation, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunctionTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(generation),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFunctionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFunctionTaskResponse> DeleteFunctionTaskWithOptionsAsync(string appGroupIdentity, string functionName, string instanceName, string generation, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFunctionTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(generation),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFunctionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteModelResponse DeleteModel(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteModelWithOptions(appGroupIdentity, modelName, headers, runtime);
        }

        public async Task<DeleteModelResponse> DeleteModelAsync(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteModelWithOptionsAsync(appGroupIdentity, modelName, headers, runtime);
        }

        public DeleteModelResponse DeleteModelWithOptions(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModel",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteModelResponse> DeleteModelWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModel",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteSortScriptResponse DeleteSortScript(string appGroupIdentity, string scriptName, string appVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSortScriptWithOptions(appGroupIdentity, scriptName, appVersionId, headers, runtime);
        }

        public async Task<DeleteSortScriptResponse> DeleteSortScriptAsync(string appGroupIdentity, string scriptName, string appVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSortScriptWithOptionsAsync(appGroupIdentity, scriptName, appVersionId, headers, runtime);
        }

        public DeleteSortScriptResponse DeleteSortScriptWithOptions(string appGroupIdentity, string scriptName, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSortScript",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSortScriptResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSortScriptResponse> DeleteSortScriptWithOptionsAsync(string appGroupIdentity, string scriptName, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSortScript",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSortScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteSortScriptFileResponse DeleteSortScriptFile(string appGroupIdentity, string appVersionId, string scriptName, string fileName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSortScriptFileWithOptions(appGroupIdentity, appVersionId, scriptName, fileName, headers, runtime);
        }

        public async Task<DeleteSortScriptFileResponse> DeleteSortScriptFileAsync(string appGroupIdentity, string appVersionId, string scriptName, string fileName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSortScriptFileWithOptionsAsync(appGroupIdentity, appVersionId, scriptName, fileName, headers, runtime);
        }

        public DeleteSortScriptFileResponse DeleteSortScriptFileWithOptions(string appGroupIdentity, string appVersionId, string scriptName, string fileName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSortScriptFile",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName) + "/files/src/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSortScriptFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSortScriptFileResponse> DeleteSortScriptFileWithOptionsAsync(string appGroupIdentity, string appVersionId, string scriptName, string fileName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSortScriptFile",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName) + "/files/src/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSortScriptFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeABTestExperimentResponse DescribeABTestExperiment(string appGroupIdentity, string sceneId, string groupId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeABTestExperimentWithOptions(appGroupIdentity, sceneId, groupId, experimentId, headers, runtime);
        }

        public async Task<DescribeABTestExperimentResponse> DescribeABTestExperimentAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeABTestExperimentWithOptionsAsync(appGroupIdentity, sceneId, groupId, experimentId, headers, runtime);
        }

        public DescribeABTestExperimentResponse DescribeABTestExperimentWithOptions(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeABTestExperiment",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeABTestExperimentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeABTestExperimentResponse> DescribeABTestExperimentWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeABTestExperiment",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeABTestExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeABTestGroupResponse DescribeABTestGroup(string appGroupIdentity, string sceneId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeABTestGroupWithOptions(appGroupIdentity, sceneId, groupId, headers, runtime);
        }

        public async Task<DescribeABTestGroupResponse> DescribeABTestGroupAsync(string appGroupIdentity, string sceneId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeABTestGroupWithOptionsAsync(appGroupIdentity, sceneId, groupId, headers, runtime);
        }

        public DescribeABTestGroupResponse DescribeABTestGroupWithOptions(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeABTestGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeABTestGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeABTestGroupResponse> DescribeABTestGroupWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeABTestGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeABTestGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeABTestSceneResponse DescribeABTestScene(string appGroupIdentity, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeABTestSceneWithOptions(appGroupIdentity, sceneId, headers, runtime);
        }

        public async Task<DescribeABTestSceneResponse> DescribeABTestSceneAsync(string appGroupIdentity, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeABTestSceneWithOptionsAsync(appGroupIdentity, sceneId, headers, runtime);
        }

        public DescribeABTestSceneResponse DescribeABTestSceneWithOptions(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeABTestScene",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeABTestSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeABTestSceneResponse> DescribeABTestSceneWithOptionsAsync(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeABTestScene",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeABTestSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAppResponse DescribeApp(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppWithOptions(appGroupIdentity, appId, headers, runtime);
        }

        public async Task<DescribeAppResponse> DescribeAppAsync(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppWithOptionsAsync(appGroupIdentity, appId, headers, runtime);
        }

        public DescribeAppResponse DescribeAppWithOptions(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApp",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAppResponse> DescribeAppWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApp",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAppGroupResponse DescribeAppGroup(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppGroupWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<DescribeAppGroupResponse> DescribeAppGroupAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppGroupWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public DescribeAppGroupResponse DescribeAppGroupWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAppGroupResponse> DescribeAppGroupWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAppGroupDataReportResponse DescribeAppGroupDataReport(string appGroupIdentity, DescribeAppGroupDataReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppGroupDataReportWithOptions(appGroupIdentity, request, headers, runtime);
        }

        public async Task<DescribeAppGroupDataReportResponse> DescribeAppGroupDataReportAsync(string appGroupIdentity, DescribeAppGroupDataReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppGroupDataReportWithOptionsAsync(appGroupIdentity, request, headers, runtime);
        }

        public DescribeAppGroupDataReportResponse DescribeAppGroupDataReportWithOptions(string appGroupIdentity, DescribeAppGroupDataReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppGroupDataReport",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/data-report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppGroupDataReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAppGroupDataReportResponse> DescribeAppGroupDataReportWithOptionsAsync(string appGroupIdentity, DescribeAppGroupDataReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppGroupDataReport",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/data-report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppGroupDataReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAppGroupStatisticsResponse DescribeAppGroupStatistics(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppGroupStatisticsWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<DescribeAppGroupStatisticsResponse> DescribeAppGroupStatisticsAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppGroupStatisticsWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public DescribeAppGroupStatisticsResponse DescribeAppGroupStatisticsWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppGroupStatistics",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppGroupStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAppGroupStatisticsResponse> DescribeAppGroupStatisticsWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppGroupStatistics",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppGroupStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAppStatisticsResponse DescribeAppStatistics(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppStatisticsWithOptions(appGroupIdentity, appId, headers, runtime);
        }

        public async Task<DescribeAppStatisticsResponse> DescribeAppStatisticsAsync(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppStatisticsWithOptionsAsync(appGroupIdentity, appId, headers, runtime);
        }

        public DescribeAppStatisticsResponse DescribeAppStatisticsWithOptions(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppStatistics",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAppStatisticsResponse> DescribeAppStatisticsWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppStatistics",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAppsResponse DescribeApps(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppsWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<DescribeAppsResponse> DescribeAppsAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppsWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public DescribeAppsResponse DescribeAppsWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApps",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAppsResponse> DescribeAppsWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApps",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDataCollctionResponse DescribeDataCollction(string appGroupIdentity, string dataCollectionIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeDataCollctionWithOptions(appGroupIdentity, dataCollectionIdentity, headers, runtime);
        }

        public async Task<DescribeDataCollctionResponse> DescribeDataCollctionAsync(string appGroupIdentity, string dataCollectionIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeDataCollctionWithOptionsAsync(appGroupIdentity, dataCollectionIdentity, headers, runtime);
        }

        public DescribeDataCollctionResponse DescribeDataCollctionWithOptions(string appGroupIdentity, string dataCollectionIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataCollction",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/data-collections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataCollectionIdentity),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataCollctionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDataCollctionResponse> DescribeDataCollctionWithOptionsAsync(string appGroupIdentity, string dataCollectionIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataCollction",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/data-collections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataCollectionIdentity),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataCollctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFirstRankResponse DescribeFirstRank(string appGroupIdentity, string appId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeFirstRankWithOptions(appGroupIdentity, appId, name, headers, runtime);
        }

        public async Task<DescribeFirstRankResponse> DescribeFirstRankAsync(string appGroupIdentity, string appId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeFirstRankWithOptionsAsync(appGroupIdentity, appId, name, headers, runtime);
        }

        public DescribeFirstRankResponse DescribeFirstRankWithOptions(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFirstRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/first-ranks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFirstRankResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFirstRankResponse> DescribeFirstRankWithOptionsAsync(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFirstRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/first-ranks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFirstRankResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInterventionDictionaryResponse DescribeInterventionDictionary(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInterventionDictionaryWithOptions(name, headers, runtime);
        }

        public async Task<DescribeInterventionDictionaryResponse> DescribeInterventionDictionaryAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInterventionDictionaryWithOptionsAsync(name, headers, runtime);
        }

        public DescribeInterventionDictionaryResponse DescribeInterventionDictionaryWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInterventionDictionary",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInterventionDictionaryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInterventionDictionaryResponse> DescribeInterventionDictionaryWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInterventionDictionary",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInterventionDictionaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeModelResponse DescribeModel(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeModelWithOptions(appGroupIdentity, modelName, headers, runtime);
        }

        public async Task<DescribeModelResponse> DescribeModelAsync(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeModelWithOptionsAsync(appGroupIdentity, modelName, headers, runtime);
        }

        public DescribeModelResponse DescribeModelWithOptions(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeModel",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeModelResponse> DescribeModelWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeModel",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeQueryProcessorResponse DescribeQueryProcessor(string appGroupIdentity, string appId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeQueryProcessorWithOptions(appGroupIdentity, appId, name, headers, runtime);
        }

        public async Task<DescribeQueryProcessorResponse> DescribeQueryProcessorAsync(string appGroupIdentity, string appId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeQueryProcessorWithOptionsAsync(appGroupIdentity, appId, name, headers, runtime);
        }

        public DescribeQueryProcessorResponse DescribeQueryProcessorWithOptions(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQueryProcessor",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/query-processors/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQueryProcessorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeQueryProcessorResponse> DescribeQueryProcessorWithOptionsAsync(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQueryProcessor",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/query-processors/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQueryProcessorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRegionResponse DescribeRegion()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionWithOptions(headers, runtime);
        }

        public async Task<DescribeRegionResponse> DescribeRegionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionWithOptionsAsync(headers, runtime);
        }

        public DescribeRegionResponse DescribeRegionWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegion",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/region",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionResponse> DescribeRegionWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegion",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/region",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(headers, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(headers, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeScheduledTaskResponse DescribeScheduledTask(string appGroupIdentity, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeScheduledTaskWithOptions(appGroupIdentity, taskId, headers, runtime);
        }

        public async Task<DescribeScheduledTaskResponse> DescribeScheduledTaskAsync(string appGroupIdentity, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeScheduledTaskWithOptionsAsync(appGroupIdentity, taskId, headers, runtime);
        }

        public DescribeScheduledTaskResponse DescribeScheduledTaskWithOptions(string appGroupIdentity, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScheduledTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scheduled-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScheduledTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeScheduledTaskResponse> DescribeScheduledTaskWithOptionsAsync(string appGroupIdentity, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScheduledTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scheduled-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScheduledTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSecondRankResponse DescribeSecondRank(string appGroupIdentity, string appId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSecondRankWithOptions(appGroupIdentity, appId, name, headers, runtime);
        }

        public async Task<DescribeSecondRankResponse> DescribeSecondRankAsync(string appGroupIdentity, string appId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSecondRankWithOptionsAsync(appGroupIdentity, appId, name, headers, runtime);
        }

        public DescribeSecondRankResponse DescribeSecondRankWithOptions(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecondRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/second-ranks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecondRankResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSecondRankResponse> DescribeSecondRankWithOptionsAsync(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecondRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/second-ranks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecondRankResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSlowQueryStatusResponse DescribeSlowQueryStatus(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSlowQueryStatusWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<DescribeSlowQueryStatusResponse> DescribeSlowQueryStatusAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSlowQueryStatusWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public DescribeSlowQueryStatusResponse DescribeSlowQueryStatusWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowQueryStatus",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/optimizers/slow-query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowQueryStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSlowQueryStatusResponse> DescribeSlowQueryStatusWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlowQueryStatus",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/optimizers/slow-query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlowQueryStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUserAnalyzerResponse DescribeUserAnalyzer(string name, DescribeUserAnalyzerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUserAnalyzerWithOptions(name, request, headers, runtime);
        }

        public async Task<DescribeUserAnalyzerResponse> DescribeUserAnalyzerAsync(string name, DescribeUserAnalyzerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUserAnalyzerWithOptionsAsync(name, request, headers, runtime);
        }

        public DescribeUserAnalyzerResponse DescribeUserAnalyzerWithOptions(string name, DescribeUserAnalyzerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.With))
            {
                query["with"] = request.With;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserAnalyzer",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/user-analyzers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserAnalyzerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUserAnalyzerResponse> DescribeUserAnalyzerWithOptionsAsync(string name, DescribeUserAnalyzerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.With))
            {
                query["with"] = request.With;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserAnalyzer",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/user-analyzers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserAnalyzerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableSlowQueryResponse DisableSlowQuery(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableSlowQueryWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<DisableSlowQueryResponse> DisableSlowQueryAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableSlowQueryWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public DisableSlowQueryResponse DisableSlowQueryWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSlowQuery",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/optimizers/slow-query/actions/disable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSlowQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableSlowQueryResponse> DisableSlowQueryWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableSlowQuery",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/optimizers/slow-query/actions/disable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableSlowQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableSlowQueryResponse EnableSlowQuery(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableSlowQueryWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<EnableSlowQueryResponse> EnableSlowQueryAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableSlowQueryWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public EnableSlowQueryResponse EnableSlowQueryWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSlowQuery",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/optimizers/slow-query/actions/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSlowQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableSlowQueryResponse> EnableSlowQueryWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSlowQuery",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/optimizers/slow-query/actions/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSlowQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateMergedTableResponse GenerateMergedTable(GenerateMergedTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateMergedTableWithOptions(request, headers, runtime);
        }

        public async Task<GenerateMergedTableResponse> GenerateMergedTableAsync(GenerateMergedTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateMergedTableWithOptionsAsync(request, headers, runtime);
        }

        public GenerateMergedTableResponse GenerateMergedTableWithOptions(GenerateMergedTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                query["spec"] = request.Spec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateMergedTable",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/assist/schema/actions/merge",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateMergedTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateMergedTableResponse> GenerateMergedTableWithOptionsAsync(GenerateMergedTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Spec))
            {
                query["spec"] = request.Spec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateMergedTable",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/assist/schema/actions/merge",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateMergedTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDomainResponse GetDomain(string domainName, GetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDomainWithOptions(domainName, request, headers, runtime);
        }

        public async Task<GetDomainResponse> GetDomainAsync(string domainName, GetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDomainWithOptionsAsync(domainName, request, headers, runtime);
        }

        public GetDomainResponse GetDomainWithOptions(string domainName, GetDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppGroupIdentity))
            {
                query["appGroupIdentity"] = request.AppGroupIdentity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomain",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDomainResponse> GetDomainWithOptionsAsync(string domainName, GetDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppGroupIdentity))
            {
                query["appGroupIdentity"] = request.AppGroupIdentity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomain",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(domainName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFunctionCurrentVersionResponse GetFunctionCurrentVersion(string functionName, GetFunctionCurrentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFunctionCurrentVersionWithOptions(functionName, request, headers, runtime);
        }

        public async Task<GetFunctionCurrentVersionResponse> GetFunctionCurrentVersionAsync(string functionName, GetFunctionCurrentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFunctionCurrentVersionWithOptionsAsync(functionName, request, headers, runtime);
        }

        public GetFunctionCurrentVersionResponse GetFunctionCurrentVersionWithOptions(string functionName, GetFunctionCurrentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                query["functionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionCurrentVersion",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/current-version",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionCurrentVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFunctionCurrentVersionResponse> GetFunctionCurrentVersionWithOptionsAsync(string functionName, GetFunctionCurrentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                query["functionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionCurrentVersion",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/current-version",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionCurrentVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFunctionDefaultInstanceResponse GetFunctionDefaultInstance(string appGroupIdentity, string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFunctionDefaultInstanceWithOptions(appGroupIdentity, functionName, headers, runtime);
        }

        public async Task<GetFunctionDefaultInstanceResponse> GetFunctionDefaultInstanceAsync(string appGroupIdentity, string functionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFunctionDefaultInstanceWithOptionsAsync(appGroupIdentity, functionName, headers, runtime);
        }

        public GetFunctionDefaultInstanceResponse GetFunctionDefaultInstanceWithOptions(string appGroupIdentity, string functionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionDefaultInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/default-instance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionDefaultInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFunctionDefaultInstanceResponse> GetFunctionDefaultInstanceWithOptionsAsync(string appGroupIdentity, string functionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionDefaultInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/default-instance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionDefaultInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFunctionInstanceResponse GetFunctionInstance(string appGroupIdentity, string functionName, string instanceName, GetFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFunctionInstanceWithOptions(appGroupIdentity, functionName, instanceName, request, headers, runtime);
        }

        public async Task<GetFunctionInstanceResponse> GetFunctionInstanceAsync(string appGroupIdentity, string functionName, string instanceName, GetFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFunctionInstanceWithOptionsAsync(appGroupIdentity, functionName, instanceName, request, headers, runtime);
        }

        public GetFunctionInstanceResponse GetFunctionInstanceWithOptions(string appGroupIdentity, string functionName, string instanceName, GetFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                query["output"] = request.Output;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFunctionInstanceResponse> GetFunctionInstanceWithOptionsAsync(string appGroupIdentity, string functionName, string instanceName, GetFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                query["output"] = request.Output;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFunctionTaskResponse GetFunctionTask(string appGroupIdentity, string functionName, string instanceName, string generation)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFunctionTaskWithOptions(appGroupIdentity, functionName, instanceName, generation, headers, runtime);
        }

        public async Task<GetFunctionTaskResponse> GetFunctionTaskAsync(string appGroupIdentity, string functionName, string instanceName, string generation)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFunctionTaskWithOptionsAsync(appGroupIdentity, functionName, instanceName, generation, headers, runtime);
        }

        public GetFunctionTaskResponse GetFunctionTaskWithOptions(string appGroupIdentity, string functionName, string instanceName, string generation, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(generation),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFunctionTaskResponse> GetFunctionTaskWithOptionsAsync(string appGroupIdentity, string functionName, string instanceName, string generation, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(generation),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFunctionVersionResponse GetFunctionVersion(string functionName, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFunctionVersionWithOptions(functionName, versionId, headers, runtime);
        }

        public async Task<GetFunctionVersionResponse> GetFunctionVersionAsync(string functionName, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFunctionVersionWithOptionsAsync(functionName, versionId, headers, runtime);
        }

        public GetFunctionVersionResponse GetFunctionVersionWithOptions(string functionName, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionVersion",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFunctionVersionResponse> GetFunctionVersionWithOptionsAsync(string functionName, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFunctionVersion",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFunctionVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetModelProgressResponse GetModelProgress(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelProgressWithOptions(appGroupIdentity, modelName, headers, runtime);
        }

        public async Task<GetModelProgressResponse> GetModelProgressAsync(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelProgressWithOptionsAsync(appGroupIdentity, modelName, headers, runtime);
        }

        public GetModelProgressResponse GetModelProgressWithOptions(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelProgress",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName) + "/progress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelProgressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetModelProgressResponse> GetModelProgressWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelProgress",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName) + "/progress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetModelReportResponse GetModelReport(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelReportWithOptions(appGroupIdentity, modelName, headers, runtime);
        }

        public async Task<GetModelReportResponse> GetModelReportAsync(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelReportWithOptionsAsync(appGroupIdentity, modelName, headers, runtime);
        }

        public GetModelReportResponse GetModelReportWithOptions(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelReport",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName) + "/report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetModelReportResponse> GetModelReportWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelReport",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName) + "/report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetScriptFileNamesResponse GetScriptFileNames(string appGroupIdentity, string appVersionId, string scriptName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetScriptFileNamesWithOptions(appGroupIdentity, appVersionId, scriptName, headers, runtime);
        }

        public async Task<GetScriptFileNamesResponse> GetScriptFileNamesAsync(string appGroupIdentity, string appVersionId, string scriptName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetScriptFileNamesWithOptionsAsync(appGroupIdentity, appVersionId, scriptName, headers, runtime);
        }

        public GetScriptFileNamesResponse GetScriptFileNamesWithOptions(string appGroupIdentity, string appVersionId, string scriptName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScriptFileNames",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName) + "/file-names",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScriptFileNamesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetScriptFileNamesResponse> GetScriptFileNamesWithOptionsAsync(string appGroupIdentity, string appVersionId, string scriptName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScriptFileNames",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName) + "/file-names",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScriptFileNamesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSearchStrategyResponse GetSearchStrategy(string appGroupIdentity, string appId, string strategyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSearchStrategyWithOptions(appGroupIdentity, appId, strategyName, headers, runtime);
        }

        public async Task<GetSearchStrategyResponse> GetSearchStrategyAsync(string appGroupIdentity, string appId, string strategyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSearchStrategyWithOptionsAsync(appGroupIdentity, appId, strategyName, headers, runtime);
        }

        public GetSearchStrategyResponse GetSearchStrategyWithOptions(string appGroupIdentity, string appId, string strategyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSearchStrategy",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/search-strategies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(strategyName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSearchStrategyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSearchStrategyResponse> GetSearchStrategyWithOptionsAsync(string appGroupIdentity, string appId, string strategyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSearchStrategy",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/search-strategies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(strategyName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSearchStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSortScriptResponse GetSortScript(string appGroupIdentity, string scriptName, string appVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSortScriptWithOptions(appGroupIdentity, scriptName, appVersionId, headers, runtime);
        }

        public async Task<GetSortScriptResponse> GetSortScriptAsync(string appGroupIdentity, string scriptName, string appVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSortScriptWithOptionsAsync(appGroupIdentity, scriptName, appVersionId, headers, runtime);
        }

        public GetSortScriptResponse GetSortScriptWithOptions(string appGroupIdentity, string scriptName, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSortScript",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSortScriptResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSortScriptResponse> GetSortScriptWithOptionsAsync(string appGroupIdentity, string scriptName, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSortScript",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSortScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSortScriptFileResponse GetSortScriptFile(string appGroupIdentity, string scriptName, string appVersionId, string fileName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSortScriptFileWithOptions(appGroupIdentity, scriptName, appVersionId, fileName, headers, runtime);
        }

        public async Task<GetSortScriptFileResponse> GetSortScriptFileAsync(string appGroupIdentity, string scriptName, string appVersionId, string fileName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSortScriptFileWithOptionsAsync(appGroupIdentity, scriptName, appVersionId, fileName, headers, runtime);
        }

        public GetSortScriptFileResponse GetSortScriptFileWithOptions(string appGroupIdentity, string scriptName, string appVersionId, string fileName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSortScriptFile",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName) + "/files/src/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSortScriptFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSortScriptFileResponse> GetSortScriptFileWithOptionsAsync(string appGroupIdentity, string scriptName, string appVersionId, string fileName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSortScriptFile",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName) + "/files/src/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSortScriptFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetValidationErrorResponse GetValidationError(string appGroupIdentity, GetValidationErrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetValidationErrorWithOptions(appGroupIdentity, request, headers, runtime);
        }

        public async Task<GetValidationErrorResponse> GetValidationErrorAsync(string appGroupIdentity, GetValidationErrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetValidationErrorWithOptionsAsync(appGroupIdentity, request, headers, runtime);
        }

        public GetValidationErrorResponse GetValidationErrorWithOptions(string appGroupIdentity, GetValidationErrorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                query["errorCode"] = request.ErrorCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetValidationError",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/data/validation-error",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetValidationErrorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetValidationErrorResponse> GetValidationErrorWithOptionsAsync(string appGroupIdentity, GetValidationErrorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                query["errorCode"] = request.ErrorCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetValidationError",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/data/validation-error",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetValidationErrorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetValidationReportResponse GetValidationReport(string appGroupIdentity, GetValidationReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetValidationReportWithOptions(appGroupIdentity, request, headers, runtime);
        }

        public async Task<GetValidationReportResponse> GetValidationReportAsync(string appGroupIdentity, GetValidationReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetValidationReportWithOptionsAsync(appGroupIdentity, request, headers, runtime);
        }

        public GetValidationReportResponse GetValidationReportWithOptions(string appGroupIdentity, GetValidationReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetValidationReport",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/data/validation-report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetValidationReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetValidationReportResponse> GetValidationReportWithOptionsAsync(string appGroupIdentity, GetValidationReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetValidationReport",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/data/validation-report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetValidationReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListABTestExperimentsResponse ListABTestExperiments(string appGroupIdentity, string sceneId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListABTestExperimentsWithOptions(appGroupIdentity, sceneId, groupId, headers, runtime);
        }

        public async Task<ListABTestExperimentsResponse> ListABTestExperimentsAsync(string appGroupIdentity, string sceneId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListABTestExperimentsWithOptionsAsync(appGroupIdentity, sceneId, groupId, headers, runtime);
        }

        public ListABTestExperimentsResponse ListABTestExperimentsWithOptions(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListABTestExperiments",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABTestExperimentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListABTestExperimentsResponse> ListABTestExperimentsWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListABTestExperiments",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABTestExperimentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListABTestFixedFlowDividersResponse ListABTestFixedFlowDividers(string appGroupIdentity, string sceneId, string groupId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListABTestFixedFlowDividersWithOptions(appGroupIdentity, sceneId, groupId, experimentId, headers, runtime);
        }

        public async Task<ListABTestFixedFlowDividersResponse> ListABTestFixedFlowDividersAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListABTestFixedFlowDividersWithOptionsAsync(appGroupIdentity, sceneId, groupId, experimentId, headers, runtime);
        }

        public ListABTestFixedFlowDividersResponse ListABTestFixedFlowDividersWithOptions(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListABTestFixedFlowDividers",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId) + "/fixed-flow-dividers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABTestFixedFlowDividersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListABTestFixedFlowDividersResponse> ListABTestFixedFlowDividersWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListABTestFixedFlowDividers",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId) + "/fixed-flow-dividers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABTestFixedFlowDividersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListABTestGroupsResponse ListABTestGroups(string appGroupIdentity, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListABTestGroupsWithOptions(appGroupIdentity, sceneId, headers, runtime);
        }

        public async Task<ListABTestGroupsResponse> ListABTestGroupsAsync(string appGroupIdentity, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListABTestGroupsWithOptionsAsync(appGroupIdentity, sceneId, headers, runtime);
        }

        public ListABTestGroupsResponse ListABTestGroupsWithOptions(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListABTestGroups",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABTestGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListABTestGroupsResponse> ListABTestGroupsWithOptionsAsync(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListABTestGroups",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABTestGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListABTestMetricsResponse ListABTestMetrics(string appGroupIdentity, string sceneId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListABTestMetricsWithOptions(appGroupIdentity, sceneId, groupId, headers, runtime);
        }

        public async Task<ListABTestMetricsResponse> ListABTestMetricsAsync(string appGroupIdentity, string sceneId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListABTestMetricsWithOptionsAsync(appGroupIdentity, sceneId, groupId, headers, runtime);
        }

        public ListABTestMetricsResponse ListABTestMetricsWithOptions(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListABTestMetrics",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABTestMetricsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListABTestMetricsResponse> ListABTestMetricsWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListABTestMetrics",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABTestMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListABTestScenesResponse ListABTestScenes(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListABTestScenesWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<ListABTestScenesResponse> ListABTestScenesAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListABTestScenesWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public ListABTestScenesResponse ListABTestScenesWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListABTestScenes",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABTestScenesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListABTestScenesResponse> ListABTestScenesWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListABTestScenes",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABTestScenesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAppGroupErrorsResponse ListAppGroupErrors(string appGroupIdentity, ListAppGroupErrorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppGroupErrorsWithOptions(appGroupIdentity, request, headers, runtime);
        }

        public async Task<ListAppGroupErrorsResponse> ListAppGroupErrorsAsync(string appGroupIdentity, ListAppGroupErrorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppGroupErrorsWithOptionsAsync(appGroupIdentity, request, headers, runtime);
        }

        public ListAppGroupErrorsResponse ListAppGroupErrorsWithOptions(string appGroupIdentity, ListAppGroupErrorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTime))
            {
                query["stopTime"] = request.StopTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppGroupErrors",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/errors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppGroupErrorsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAppGroupErrorsResponse> ListAppGroupErrorsWithOptionsAsync(string appGroupIdentity, ListAppGroupErrorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTime))
            {
                query["stopTime"] = request.StopTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppGroupErrors",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/errors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppGroupErrorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAppGroupMetricsResponse ListAppGroupMetrics(string appGroupIdentity, ListAppGroupMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppGroupMetricsWithOptions(appGroupIdentity, request, headers, runtime);
        }

        public async Task<ListAppGroupMetricsResponse> ListAppGroupMetricsAsync(string appGroupIdentity, ListAppGroupMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppGroupMetricsWithOptionsAsync(appGroupIdentity, request, headers, runtime);
        }

        public ListAppGroupMetricsResponse ListAppGroupMetricsWithOptions(string appGroupIdentity, ListAppGroupMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Indexes))
            {
                query["indexes"] = request.Indexes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["metricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppGroupMetrics",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppGroupMetricsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAppGroupMetricsResponse> ListAppGroupMetricsWithOptionsAsync(string appGroupIdentity, ListAppGroupMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Indexes))
            {
                query["indexes"] = request.Indexes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["metricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppGroupMetrics",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppGroupMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAppGroupsResponse ListAppGroups(ListAppGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppGroupsWithOptions(request, headers, runtime);
        }

        public async Task<ListAppGroupsResponse> ListAppGroupsAsync(ListAppGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppGroupsWithOptionsAsync(request, headers, runtime);
        }

        public ListAppGroupsResponse ListAppGroupsWithOptions(ListAppGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["sortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppGroups",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAppGroupsResponse> ListAppGroupsWithOptionsAsync(ListAppGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["sortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppGroups",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAppsResponse ListApps(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppsWithOptions(request, headers, runtime);
        }

        public async Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppsWithOptionsAsync(request, headers, runtime);
        }

        public ListAppsResponse ListAppsWithOptions(ListAppsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApps",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/apps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ListAppsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAppsResponse> ListAppsWithOptionsAsync(ListAppsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApps",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/apps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ListAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDataCollectionsResponse ListDataCollections(string appGroupIdentity, ListDataCollectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataCollectionsWithOptions(appGroupIdentity, request, headers, runtime);
        }

        public async Task<ListDataCollectionsResponse> ListDataCollectionsAsync(string appGroupIdentity, ListDataCollectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataCollectionsWithOptionsAsync(appGroupIdentity, request, headers, runtime);
        }

        public ListDataCollectionsResponse ListDataCollectionsWithOptions(string appGroupIdentity, ListDataCollectionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCollections",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/data-collections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCollectionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDataCollectionsResponse> ListDataCollectionsWithOptionsAsync(string appGroupIdentity, ListDataCollectionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataCollections",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/data-collections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataCollectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDataSourceTableFieldsResponse ListDataSourceTableFields(string dataSourceType, ListDataSourceTableFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSourceTableFieldsWithOptions(dataSourceType, request, headers, runtime);
        }

        public async Task<ListDataSourceTableFieldsResponse> ListDataSourceTableFieldsAsync(string dataSourceType, ListDataSourceTableFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSourceTableFieldsWithOptionsAsync(dataSourceType, request, headers, runtime);
        }

        public ListDataSourceTableFieldsResponse ListDataSourceTableFieldsWithOptions(string dataSourceType, ListDataSourceTableFieldsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceTableFields",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/assist/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceType) + "/fields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceTableFieldsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDataSourceTableFieldsResponse> ListDataSourceTableFieldsWithOptionsAsync(string dataSourceType, ListDataSourceTableFieldsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceTableFields",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/assist/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceType) + "/fields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceTableFieldsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDataSourceTablesResponse ListDataSourceTables(string dataSourceType, ListDataSourceTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSourceTablesWithOptions(dataSourceType, request, headers, runtime);
        }

        public async Task<ListDataSourceTablesResponse> ListDataSourceTablesAsync(string dataSourceType, ListDataSourceTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSourceTablesWithOptionsAsync(dataSourceType, request, headers, runtime);
        }

        public ListDataSourceTablesResponse ListDataSourceTablesWithOptions(string dataSourceType, ListDataSourceTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceTables",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/assist/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceType) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceTablesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDataSourceTablesResponse> ListDataSourceTablesWithOptionsAsync(string dataSourceType, ListDataSourceTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSourceTables",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/assist/data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceType) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDeployedAlgorithmModelsResponse ListDeployedAlgorithmModels(string appGroupIdentity, ListDeployedAlgorithmModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDeployedAlgorithmModelsWithOptions(appGroupIdentity, request, headers, runtime);
        }

        public async Task<ListDeployedAlgorithmModelsResponse> ListDeployedAlgorithmModelsAsync(string appGroupIdentity, ListDeployedAlgorithmModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDeployedAlgorithmModelsWithOptionsAsync(appGroupIdentity, request, headers, runtime);
        }

        public ListDeployedAlgorithmModelsResponse ListDeployedAlgorithmModelsWithOptions(string appGroupIdentity, ListDeployedAlgorithmModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmType))
            {
                query["algorithmType"] = request.AlgorithmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InServiceOnly))
            {
                query["inServiceOnly"] = request.InServiceOnly;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeployedAlgorithmModels",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/deployed-algorithm-models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeployedAlgorithmModelsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDeployedAlgorithmModelsResponse> ListDeployedAlgorithmModelsWithOptionsAsync(string appGroupIdentity, ListDeployedAlgorithmModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmType))
            {
                query["algorithmType"] = request.AlgorithmType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InServiceOnly))
            {
                query["inServiceOnly"] = request.InServiceOnly;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeployedAlgorithmModels",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/deployed-algorithm-models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeployedAlgorithmModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFirstRanksResponse ListFirstRanks(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFirstRanksWithOptions(appGroupIdentity, appId, headers, runtime);
        }

        public async Task<ListFirstRanksResponse> ListFirstRanksAsync(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFirstRanksWithOptionsAsync(appGroupIdentity, appId, headers, runtime);
        }

        public ListFirstRanksResponse ListFirstRanksWithOptions(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFirstRanks",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/first-ranks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFirstRanksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFirstRanksResponse> ListFirstRanksWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFirstRanks",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/first-ranks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFirstRanksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFunctionInstancesResponse ListFunctionInstances(string appGroupIdentity, string functionName, ListFunctionInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFunctionInstancesWithOptions(appGroupIdentity, functionName, request, headers, runtime);
        }

        public async Task<ListFunctionInstancesResponse> ListFunctionInstancesAsync(string appGroupIdentity, string functionName, ListFunctionInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFunctionInstancesWithOptionsAsync(appGroupIdentity, functionName, request, headers, runtime);
        }

        public ListFunctionInstancesResponse ListFunctionInstancesWithOptions(string appGroupIdentity, string functionName, ListFunctionInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                query["functionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                query["output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionInstances",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFunctionInstancesResponse> ListFunctionInstancesWithOptionsAsync(string appGroupIdentity, string functionName, ListFunctionInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionType))
            {
                query["functionType"] = request.FunctionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["modelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                query["output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionInstances",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFunctionTasksResponse ListFunctionTasks(string appGroupIdentity, string functionName, string instanceName, ListFunctionTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFunctionTasksWithOptions(appGroupIdentity, functionName, instanceName, request, headers, runtime);
        }

        public async Task<ListFunctionTasksResponse> ListFunctionTasksAsync(string appGroupIdentity, string functionName, string instanceName, ListFunctionTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFunctionTasksWithOptionsAsync(appGroupIdentity, functionName, instanceName, request, headers, runtime);
        }

        public ListFunctionTasksResponse ListFunctionTasksWithOptions(string appGroupIdentity, string functionName, string instanceName, ListFunctionTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionTasks",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFunctionTasksResponse> ListFunctionTasksWithOptionsAsync(string appGroupIdentity, string functionName, string instanceName, ListFunctionTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctionTasks",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListInterventionDictionariesResponse ListInterventionDictionaries(ListInterventionDictionariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInterventionDictionariesWithOptions(request, headers, runtime);
        }

        public async Task<ListInterventionDictionariesResponse> ListInterventionDictionariesAsync(ListInterventionDictionariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInterventionDictionariesWithOptionsAsync(request, headers, runtime);
        }

        public ListInterventionDictionariesResponse ListInterventionDictionariesWithOptions(ListInterventionDictionariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterventionDictionaries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterventionDictionariesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListInterventionDictionariesResponse> ListInterventionDictionariesWithOptionsAsync(ListInterventionDictionariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterventionDictionaries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterventionDictionariesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListInterventionDictionaryEntriesResponse ListInterventionDictionaryEntries(string name, ListInterventionDictionaryEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInterventionDictionaryEntriesWithOptions(name, request, headers, runtime);
        }

        public async Task<ListInterventionDictionaryEntriesResponse> ListInterventionDictionaryEntriesAsync(string name, ListInterventionDictionaryEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInterventionDictionaryEntriesWithOptionsAsync(name, request, headers, runtime);
        }

        public ListInterventionDictionaryEntriesResponse ListInterventionDictionaryEntriesWithOptions(string name, ListInterventionDictionaryEntriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                query["word"] = request.Word;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterventionDictionaryEntries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/entries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterventionDictionaryEntriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListInterventionDictionaryEntriesResponse> ListInterventionDictionaryEntriesWithOptionsAsync(string name, ListInterventionDictionaryEntriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                query["word"] = request.Word;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterventionDictionaryEntries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/entries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterventionDictionaryEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListInterventionDictionaryNerResultsResponse ListInterventionDictionaryNerResults(string name, ListInterventionDictionaryNerResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInterventionDictionaryNerResultsWithOptions(name, request, headers, runtime);
        }

        public async Task<ListInterventionDictionaryNerResultsResponse> ListInterventionDictionaryNerResultsAsync(string name, ListInterventionDictionaryNerResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInterventionDictionaryNerResultsWithOptionsAsync(name, request, headers, runtime);
        }

        public ListInterventionDictionaryNerResultsResponse ListInterventionDictionaryNerResultsWithOptions(string name, ListInterventionDictionaryNerResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterventionDictionaryNerResults",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/ner-results",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterventionDictionaryNerResultsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListInterventionDictionaryNerResultsResponse> ListInterventionDictionaryNerResultsWithOptionsAsync(string name, ListInterventionDictionaryNerResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterventionDictionaryNerResults",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/ner-results",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterventionDictionaryNerResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListInterventionDictionaryRelatedEntitiesResponse ListInterventionDictionaryRelatedEntities(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInterventionDictionaryRelatedEntitiesWithOptions(name, headers, runtime);
        }

        public async Task<ListInterventionDictionaryRelatedEntitiesResponse> ListInterventionDictionaryRelatedEntitiesAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInterventionDictionaryRelatedEntitiesWithOptionsAsync(name, headers, runtime);
        }

        public ListInterventionDictionaryRelatedEntitiesResponse ListInterventionDictionaryRelatedEntitiesWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterventionDictionaryRelatedEntities",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/related",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterventionDictionaryRelatedEntitiesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListInterventionDictionaryRelatedEntitiesResponse> ListInterventionDictionaryRelatedEntitiesWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInterventionDictionaryRelatedEntities",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/related",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInterventionDictionaryRelatedEntitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListModelsResponse ListModels(string appGroupIdentity, ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelsWithOptions(appGroupIdentity, request, headers, runtime);
        }

        public async Task<ListModelsResponse> ListModelsAsync(string appGroupIdentity, ListModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelsWithOptionsAsync(appGroupIdentity, request, headers, runtime);
        }

        public ListModelsResponse ListModelsWithOptions(string appGroupIdentity, ListModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModels",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListModelsResponse> ListModelsWithOptionsAsync(string appGroupIdentity, ListModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModels",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProceedingsResponse ListProceedings(string appGroupIdentity, ListProceedingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProceedingsWithOptions(appGroupIdentity, request, headers, runtime);
        }

        public async Task<ListProceedingsResponse> ListProceedingsAsync(string appGroupIdentity, ListProceedingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProceedingsWithOptionsAsync(appGroupIdentity, request, headers, runtime);
        }

        public ListProceedingsResponse ListProceedingsWithOptions(string appGroupIdentity, ListProceedingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterFinished))
            {
                query["filterFinished"] = request.FilterFinished;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProceedings",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/proceedings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProceedingsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProceedingsResponse> ListProceedingsWithOptionsAsync(string appGroupIdentity, ListProceedingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterFinished))
            {
                query["filterFinished"] = request.FilterFinished;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProceedings",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/proceedings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProceedingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListQueryProcessorAnalyzerResultsResponse ListQueryProcessorAnalyzerResults(string appGroupIdentity, string appId, string name, ListQueryProcessorAnalyzerResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListQueryProcessorAnalyzerResultsWithOptions(appGroupIdentity, appId, name, request, headers, runtime);
        }

        public async Task<ListQueryProcessorAnalyzerResultsResponse> ListQueryProcessorAnalyzerResultsAsync(string appGroupIdentity, string appId, string name, ListQueryProcessorAnalyzerResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListQueryProcessorAnalyzerResultsWithOptionsAsync(appGroupIdentity, appId, name, request, headers, runtime);
        }

        public ListQueryProcessorAnalyzerResultsResponse ListQueryProcessorAnalyzerResultsWithOptions(string appGroupIdentity, string appId, string name, ListQueryProcessorAnalyzerResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueryProcessorAnalyzerResults",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/query-processors/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/analyze",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueryProcessorAnalyzerResultsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListQueryProcessorAnalyzerResultsResponse> ListQueryProcessorAnalyzerResultsWithOptionsAsync(string appGroupIdentity, string appId, string name, ListQueryProcessorAnalyzerResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueryProcessorAnalyzerResults",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/query-processors/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/analyze",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueryProcessorAnalyzerResultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListQueryProcessorNersResponse ListQueryProcessorNers(ListQueryProcessorNersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListQueryProcessorNersWithOptions(request, headers, runtime);
        }

        public async Task<ListQueryProcessorNersResponse> ListQueryProcessorNersAsync(ListQueryProcessorNersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListQueryProcessorNersWithOptionsAsync(request, headers, runtime);
        }

        public ListQueryProcessorNersResponse ListQueryProcessorNersWithOptions(ListQueryProcessorNersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueryProcessorNers",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/query-processor/ner/default-priorities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueryProcessorNersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListQueryProcessorNersResponse> ListQueryProcessorNersWithOptionsAsync(ListQueryProcessorNersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueryProcessorNers",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/query-processor/ner/default-priorities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueryProcessorNersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListQueryProcessorsResponse ListQueryProcessors(string appGroupIdentity, string appId, ListQueryProcessorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListQueryProcessorsWithOptions(appGroupIdentity, appId, request, headers, runtime);
        }

        public async Task<ListQueryProcessorsResponse> ListQueryProcessorsAsync(string appGroupIdentity, string appId, ListQueryProcessorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListQueryProcessorsWithOptionsAsync(appGroupIdentity, appId, request, headers, runtime);
        }

        public ListQueryProcessorsResponse ListQueryProcessorsWithOptions(string appGroupIdentity, string appId, ListQueryProcessorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsActive))
            {
                query["isActive"] = request.IsActive;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueryProcessors",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/query-processors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueryProcessorsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListQueryProcessorsResponse> ListQueryProcessorsWithOptionsAsync(string appGroupIdentity, string appId, ListQueryProcessorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsActive))
            {
                query["isActive"] = request.IsActive;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueryProcessors",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/query-processors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueryProcessorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListQuotaReviewTasksResponse ListQuotaReviewTasks(string appGroupIdentity, ListQuotaReviewTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListQuotaReviewTasksWithOptions(appGroupIdentity, request, headers, runtime);
        }

        public async Task<ListQuotaReviewTasksResponse> ListQuotaReviewTasksAsync(string appGroupIdentity, ListQuotaReviewTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListQuotaReviewTasksWithOptionsAsync(appGroupIdentity, request, headers, runtime);
        }

        public ListQuotaReviewTasksResponse ListQuotaReviewTasksWithOptions(string appGroupIdentity, ListQuotaReviewTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotaReviewTasks",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/quota-review-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaReviewTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListQuotaReviewTasksResponse> ListQuotaReviewTasksWithOptionsAsync(string appGroupIdentity, ListQuotaReviewTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotaReviewTasks",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/quota-review-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotaReviewTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRamRolesResponse ListRamRoles()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRamRolesWithOptions(headers, runtime);
        }

        public async Task<ListRamRolesResponse> ListRamRolesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRamRolesWithOptionsAsync(headers, runtime);
        }

        public ListRamRolesResponse ListRamRolesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRamRoles",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/assist/ram/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRamRolesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRamRolesResponse> ListRamRolesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRamRoles",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/assist/ram/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRamRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListScheduledTasksResponse ListScheduledTasks(string appGroupIdentity, ListScheduledTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListScheduledTasksWithOptions(appGroupIdentity, request, headers, runtime);
        }

        public async Task<ListScheduledTasksResponse> ListScheduledTasksAsync(string appGroupIdentity, ListScheduledTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListScheduledTasksWithOptionsAsync(appGroupIdentity, request, headers, runtime);
        }

        public ListScheduledTasksResponse ListScheduledTasksWithOptions(string appGroupIdentity, ListScheduledTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledTasks",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scheduled-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListScheduledTasksResponse> ListScheduledTasksWithOptionsAsync(string appGroupIdentity, ListScheduledTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledTasks",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scheduled-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSearchStrategiesResponse ListSearchStrategies(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSearchStrategiesWithOptions(appGroupIdentity, appId, headers, runtime);
        }

        public async Task<ListSearchStrategiesResponse> ListSearchStrategiesAsync(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSearchStrategiesWithOptionsAsync(appGroupIdentity, appId, headers, runtime);
        }

        public ListSearchStrategiesResponse ListSearchStrategiesWithOptions(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSearchStrategies",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/search-strategies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSearchStrategiesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSearchStrategiesResponse> ListSearchStrategiesWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSearchStrategies",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/search-strategies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSearchStrategiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSecondRanksResponse ListSecondRanks(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSecondRanksWithOptions(appGroupIdentity, appId, headers, runtime);
        }

        public async Task<ListSecondRanksResponse> ListSecondRanksAsync(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSecondRanksWithOptionsAsync(appGroupIdentity, appId, headers, runtime);
        }

        public ListSecondRanksResponse ListSecondRanksWithOptions(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecondRanks",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/second-ranks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecondRanksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSecondRanksResponse> ListSecondRanksWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecondRanks",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/second-ranks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecondRanksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSlowQueryCategoriesResponse ListSlowQueryCategories(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSlowQueryCategoriesWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<ListSlowQueryCategoriesResponse> ListSlowQueryCategoriesAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSlowQueryCategoriesWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public ListSlowQueryCategoriesResponse ListSlowQueryCategoriesWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSlowQueryCategories",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/optimizers/slow-query/categories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSlowQueryCategoriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSlowQueryCategoriesResponse> ListSlowQueryCategoriesWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSlowQueryCategories",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/optimizers/slow-query/categories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSlowQueryCategoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSlowQueryQueriesResponse ListSlowQueryQueries(string appGroupIdentity, string categoryIndex)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSlowQueryQueriesWithOptions(appGroupIdentity, categoryIndex, headers, runtime);
        }

        public async Task<ListSlowQueryQueriesResponse> ListSlowQueryQueriesAsync(string appGroupIdentity, string categoryIndex)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSlowQueryQueriesWithOptionsAsync(appGroupIdentity, categoryIndex, headers, runtime);
        }

        public ListSlowQueryQueriesResponse ListSlowQueryQueriesWithOptions(string appGroupIdentity, string categoryIndex, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSlowQueryQueries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/optimizers/slow-query/categories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(categoryIndex) + "/queries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSlowQueryQueriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSlowQueryQueriesResponse> ListSlowQueryQueriesWithOptionsAsync(string appGroupIdentity, string categoryIndex, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSlowQueryQueries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/optimizers/slow-query/categories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(categoryIndex) + "/queries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSlowQueryQueriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSortExpressionsResponse ListSortExpressions(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSortExpressionsWithOptions(appGroupIdentity, appId, headers, runtime);
        }

        public async Task<ListSortExpressionsResponse> ListSortExpressionsAsync(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSortExpressionsWithOptionsAsync(appGroupIdentity, appId, headers, runtime);
        }

        public ListSortExpressionsResponse ListSortExpressionsWithOptions(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSortExpressions",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/sort-expressions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSortExpressionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSortExpressionsResponse> ListSortExpressionsWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSortExpressions",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/sort-expressions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSortExpressionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSortScriptsResponse ListSortScripts(string appGroupIdentity, string appVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSortScriptsWithOptions(appGroupIdentity, appVersionId, headers, runtime);
        }

        public async Task<ListSortScriptsResponse> ListSortScriptsAsync(string appGroupIdentity, string appVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSortScriptsWithOptionsAsync(appGroupIdentity, appVersionId, headers, runtime);
        }

        public ListSortScriptsResponse ListSortScriptsWithOptions(string appGroupIdentity, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSortScripts",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSortScriptsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSortScriptsResponse> ListSortScriptsWithOptionsAsync(string appGroupIdentity, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSortScripts",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSortScriptsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListStatisticLogsResponse ListStatisticLogs(string appGroupIdentity, string moduleName, ListStatisticLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListStatisticLogsWithOptions(appGroupIdentity, moduleName, request, headers, runtime);
        }

        public async Task<ListStatisticLogsResponse> ListStatisticLogsAsync(string appGroupIdentity, string moduleName, ListStatisticLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListStatisticLogsWithOptionsAsync(appGroupIdentity, moduleName, request, headers, runtime);
        }

        public ListStatisticLogsResponse ListStatisticLogsWithOptions(string appGroupIdentity, string moduleName, ListStatisticLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Columns))
            {
                query["columns"] = request.Columns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Distinct))
            {
                query["distinct"] = request.Distinct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["sortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTime))
            {
                query["stopTime"] = request.StopTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStatisticLogs",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/statistic-logs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStatisticLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListStatisticLogsResponse> ListStatisticLogsWithOptionsAsync(string appGroupIdentity, string moduleName, ListStatisticLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Columns))
            {
                query["columns"] = request.Columns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Distinct))
            {
                query["distinct"] = request.Distinct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["sortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTime))
            {
                query["stopTime"] = request.StopTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStatisticLogs",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/statistic-logs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStatisticLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListStatisticReportResponse ListStatisticReport(string appGroupIdentity, string moduleName, ListStatisticReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListStatisticReportWithOptions(appGroupIdentity, moduleName, request, headers, runtime);
        }

        public async Task<ListStatisticReportResponse> ListStatisticReportAsync(string appGroupIdentity, string moduleName, ListStatisticReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListStatisticReportWithOptionsAsync(appGroupIdentity, moduleName, request, headers, runtime);
        }

        public ListStatisticReportResponse ListStatisticReportWithOptions(string appGroupIdentity, string moduleName, ListStatisticReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Columns))
            {
                query["columns"] = request.Columns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStatisticReport",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/statistic-report/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStatisticReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListStatisticReportResponse> ListStatisticReportWithOptionsAsync(string appGroupIdentity, string moduleName, ListStatisticReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Columns))
            {
                query["columns"] = request.Columns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStatisticReport",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/statistic-report/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStatisticReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/resource-tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/resource-tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUserAnalyzerEntriesResponse ListUserAnalyzerEntries(string name, ListUserAnalyzerEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserAnalyzerEntriesWithOptions(name, request, headers, runtime);
        }

        public async Task<ListUserAnalyzerEntriesResponse> ListUserAnalyzerEntriesAsync(string name, ListUserAnalyzerEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserAnalyzerEntriesWithOptionsAsync(name, request, headers, runtime);
        }

        public ListUserAnalyzerEntriesResponse ListUserAnalyzerEntriesWithOptions(string name, ListUserAnalyzerEntriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                query["word"] = request.Word;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserAnalyzerEntries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/user-analyzers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/entries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserAnalyzerEntriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUserAnalyzerEntriesResponse> ListUserAnalyzerEntriesWithOptionsAsync(string name, ListUserAnalyzerEntriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                query["word"] = request.Word;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserAnalyzerEntries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/user-analyzers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/entries",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserAnalyzerEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUserAnalyzersResponse ListUserAnalyzers(ListUserAnalyzersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserAnalyzersWithOptions(request, headers, runtime);
        }

        public async Task<ListUserAnalyzersResponse> ListUserAnalyzersAsync(ListUserAnalyzersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserAnalyzersWithOptionsAsync(request, headers, runtime);
        }

        public ListUserAnalyzersResponse ListUserAnalyzersWithOptions(ListUserAnalyzersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserAnalyzers",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/user-analyzers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserAnalyzersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUserAnalyzersResponse> ListUserAnalyzersWithOptionsAsync(ListUserAnalyzersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserAnalyzers",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/user-analyzers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserAnalyzersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyAppGroupResponse ModifyAppGroup(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyAppGroupWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<ModifyAppGroupResponse> ModifyAppGroupAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyAppGroupWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public ModifyAppGroupResponse ModifyAppGroupWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyAppGroupResponse> ModifyAppGroupWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyAppGroupQuotaResponse ModifyAppGroupQuota(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyAppGroupQuotaWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<ModifyAppGroupQuotaResponse> ModifyAppGroupQuotaAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyAppGroupQuotaWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public ModifyAppGroupQuotaResponse ModifyAppGroupQuotaWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppGroupQuota",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/quota",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppGroupQuotaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyAppGroupQuotaResponse> ModifyAppGroupQuotaWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppGroupQuota",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/quota",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppGroupQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyFirstRankResponse ModifyFirstRank(string appGroupIdentity, string appId, string name, ModifyFirstRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyFirstRankWithOptions(appGroupIdentity, appId, name, request, headers, runtime);
        }

        public async Task<ModifyFirstRankResponse> ModifyFirstRankAsync(string appGroupIdentity, string appId, string name, ModifyFirstRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyFirstRankWithOptionsAsync(appGroupIdentity, appId, name, request, headers, runtime);
        }

        public ModifyFirstRankResponse ModifyFirstRankWithOptions(string appGroupIdentity, string appId, string name, ModifyFirstRankRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFirstRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/first-ranks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFirstRankResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyFirstRankResponse> ModifyFirstRankWithOptionsAsync(string appGroupIdentity, string appId, string name, ModifyFirstRankRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFirstRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/first-ranks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFirstRankResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyModelResponse ModifyModel(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyModelWithOptions(appGroupIdentity, modelName, headers, runtime);
        }

        public async Task<ModifyModelResponse> ModifyModelAsync(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyModelWithOptionsAsync(appGroupIdentity, modelName, headers, runtime);
        }

        public ModifyModelResponse ModifyModelWithOptions(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyModel",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyModelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyModelResponse> ModifyModelWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyModel",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyQueryProcessorResponse ModifyQueryProcessor(string appGroupIdentity, string appId, string name, ModifyQueryProcessorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyQueryProcessorWithOptions(appGroupIdentity, appId, name, request, headers, runtime);
        }

        public async Task<ModifyQueryProcessorResponse> ModifyQueryProcessorAsync(string appGroupIdentity, string appId, string name, ModifyQueryProcessorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyQueryProcessorWithOptionsAsync(appGroupIdentity, appId, name, request, headers, runtime);
        }

        public ModifyQueryProcessorResponse ModifyQueryProcessorWithOptions(string appGroupIdentity, string appId, string name, ModifyQueryProcessorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyQueryProcessor",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/query-processors/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyQueryProcessorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyQueryProcessorResponse> ModifyQueryProcessorWithOptionsAsync(string appGroupIdentity, string appId, string name, ModifyQueryProcessorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyQueryProcessor",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/query-processors/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyQueryProcessorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyScheduledTaskResponse ModifyScheduledTask(string appGroupIdentity, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyScheduledTaskWithOptions(appGroupIdentity, taskId, headers, runtime);
        }

        public async Task<ModifyScheduledTaskResponse> ModifyScheduledTaskAsync(string appGroupIdentity, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyScheduledTaskWithOptionsAsync(appGroupIdentity, taskId, headers, runtime);
        }

        public ModifyScheduledTaskResponse ModifyScheduledTaskWithOptions(string appGroupIdentity, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScheduledTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scheduled-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScheduledTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyScheduledTaskResponse> ModifyScheduledTaskWithOptionsAsync(string appGroupIdentity, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScheduledTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scheduled-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScheduledTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifySecondRankResponse ModifySecondRank(string appGroupIdentity, string appId, string name, ModifySecondRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifySecondRankWithOptions(appGroupIdentity, appId, name, request, headers, runtime);
        }

        public async Task<ModifySecondRankResponse> ModifySecondRankAsync(string appGroupIdentity, string appId, string name, ModifySecondRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifySecondRankWithOptionsAsync(appGroupIdentity, appId, name, request, headers, runtime);
        }

        public ModifySecondRankResponse ModifySecondRankWithOptions(string appGroupIdentity, string appId, string name, ModifySecondRankRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecondRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/second-ranks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecondRankResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifySecondRankResponse> ModifySecondRankWithOptionsAsync(string appGroupIdentity, string appId, string name, ModifySecondRankRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecondRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/second-ranks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecondRankResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PreviewModelResponse PreviewModel(string appGroupIdentity, string modelName, PreviewModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PreviewModelWithOptions(appGroupIdentity, modelName, request, headers, runtime);
        }

        public async Task<PreviewModelResponse> PreviewModelAsync(string appGroupIdentity, string modelName, PreviewModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PreviewModelWithOptionsAsync(appGroupIdentity, modelName, request, headers, runtime);
        }

        public PreviewModelResponse PreviewModelWithOptions(string appGroupIdentity, string modelName, PreviewModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewModel",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName) + "/actions/preview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewModelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PreviewModelResponse> PreviewModelWithOptionsAsync(string appGroupIdentity, string modelName, PreviewModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewModel",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName) + "/actions/preview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushInterventionDictionaryEntriesResponse PushInterventionDictionaryEntries(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushInterventionDictionaryEntriesWithOptions(name, headers, runtime);
        }

        public async Task<PushInterventionDictionaryEntriesResponse> PushInterventionDictionaryEntriesAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushInterventionDictionaryEntriesWithOptionsAsync(name, headers, runtime);
        }

        public PushInterventionDictionaryEntriesResponse PushInterventionDictionaryEntriesWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushInterventionDictionaryEntries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/entries/actions/bulk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushInterventionDictionaryEntriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushInterventionDictionaryEntriesResponse> PushInterventionDictionaryEntriesWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushInterventionDictionaryEntries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/entries/actions/bulk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushInterventionDictionaryEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushUserAnalyzerEntriesResponse PushUserAnalyzerEntries(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushUserAnalyzerEntriesWithOptions(name, headers, runtime);
        }

        public async Task<PushUserAnalyzerEntriesResponse> PushUserAnalyzerEntriesAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushUserAnalyzerEntriesWithOptionsAsync(name, headers, runtime);
        }

        public PushUserAnalyzerEntriesResponse PushUserAnalyzerEntriesWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushUserAnalyzerEntries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/user-analyzers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/entries/actions/bulk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushUserAnalyzerEntriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushUserAnalyzerEntriesResponse> PushUserAnalyzerEntriesWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushUserAnalyzerEntries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/user-analyzers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/entries/actions/bulk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushUserAnalyzerEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RankPreviewQueryResponse RankPreviewQuery(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RankPreviewQueryWithOptions(appGroupIdentity, modelName, headers, runtime);
        }

        public async Task<RankPreviewQueryResponse> RankPreviewQueryAsync(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RankPreviewQueryWithOptionsAsync(appGroupIdentity, modelName, headers, runtime);
        }

        public RankPreviewQueryResponse RankPreviewQueryWithOptions(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RankPreviewQuery",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName) + "/actions/query-rank",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RankPreviewQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RankPreviewQueryResponse> RankPreviewQueryWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RankPreviewQuery",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName) + "/actions/query-rank",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RankPreviewQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseSortScriptResponse ReleaseSortScript(string appGroupIdentity, string scriptName, string appVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReleaseSortScriptWithOptions(appGroupIdentity, scriptName, appVersionId, headers, runtime);
        }

        public async Task<ReleaseSortScriptResponse> ReleaseSortScriptAsync(string appGroupIdentity, string scriptName, string appVersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReleaseSortScriptWithOptionsAsync(appGroupIdentity, scriptName, appVersionId, headers, runtime);
        }

        public ReleaseSortScriptResponse ReleaseSortScriptWithOptions(string appGroupIdentity, string scriptName, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseSortScript",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName) + "/actions/release",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseSortScriptResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseSortScriptResponse> ReleaseSortScriptWithOptionsAsync(string appGroupIdentity, string scriptName, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseSortScript",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName) + "/actions/release",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseSortScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveAppResponse RemoveApp(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveAppWithOptions(appGroupIdentity, appId, headers, runtime);
        }

        public async Task<RemoveAppResponse> RemoveAppAsync(string appGroupIdentity, string appId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveAppWithOptionsAsync(appGroupIdentity, appId, headers, runtime);
        }

        public RemoveAppResponse RemoveAppWithOptions(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveApp",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAppResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveAppResponse> RemoveAppWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveApp",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveAppGroupResponse RemoveAppGroup(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveAppGroupWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<RemoveAppGroupResponse> RemoveAppGroupAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveAppGroupWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public RemoveAppGroupResponse RemoveAppGroupWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveAppGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAppGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveAppGroupResponse> RemoveAppGroupWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveAppGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAppGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveDataCollectionResponse RemoveDataCollection(string appGroupIdentity, string dataCollectionIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveDataCollectionWithOptions(appGroupIdentity, dataCollectionIdentity, headers, runtime);
        }

        public async Task<RemoveDataCollectionResponse> RemoveDataCollectionAsync(string appGroupIdentity, string dataCollectionIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveDataCollectionWithOptionsAsync(appGroupIdentity, dataCollectionIdentity, headers, runtime);
        }

        public RemoveDataCollectionResponse RemoveDataCollectionWithOptions(string appGroupIdentity, string dataCollectionIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveDataCollection",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/data-collections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataCollectionIdentity),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDataCollectionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveDataCollectionResponse> RemoveDataCollectionWithOptionsAsync(string appGroupIdentity, string dataCollectionIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveDataCollection",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/data-collections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataCollectionIdentity),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDataCollectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveFirstRankResponse RemoveFirstRank(string appGroupIdentity, string appId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveFirstRankWithOptions(appGroupIdentity, appId, name, headers, runtime);
        }

        public async Task<RemoveFirstRankResponse> RemoveFirstRankAsync(string appGroupIdentity, string appId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveFirstRankWithOptionsAsync(appGroupIdentity, appId, name, headers, runtime);
        }

        public RemoveFirstRankResponse RemoveFirstRankWithOptions(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveFirstRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/first-ranks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveFirstRankResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveFirstRankResponse> RemoveFirstRankWithOptionsAsync(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveFirstRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/first-ranks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveFirstRankResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveInterventionDictionaryResponse RemoveInterventionDictionary(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveInterventionDictionaryWithOptions(name, headers, runtime);
        }

        public async Task<RemoveInterventionDictionaryResponse> RemoveInterventionDictionaryAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveInterventionDictionaryWithOptionsAsync(name, headers, runtime);
        }

        public RemoveInterventionDictionaryResponse RemoveInterventionDictionaryWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveInterventionDictionary",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveInterventionDictionaryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveInterventionDictionaryResponse> RemoveInterventionDictionaryWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveInterventionDictionary",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/intervention-dictionaries/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveInterventionDictionaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveQueryProcessorResponse RemoveQueryProcessor(string appGroupIdentity, string appId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveQueryProcessorWithOptions(appGroupIdentity, appId, name, headers, runtime);
        }

        public async Task<RemoveQueryProcessorResponse> RemoveQueryProcessorAsync(string appGroupIdentity, string appId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveQueryProcessorWithOptionsAsync(appGroupIdentity, appId, name, headers, runtime);
        }

        public RemoveQueryProcessorResponse RemoveQueryProcessorWithOptions(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveQueryProcessor",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/query-processors/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveQueryProcessorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveQueryProcessorResponse> RemoveQueryProcessorWithOptionsAsync(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveQueryProcessor",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/query-processors/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveQueryProcessorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveScheduledTaskResponse RemoveScheduledTask(string appGroupIdentity, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveScheduledTaskWithOptions(appGroupIdentity, taskId, headers, runtime);
        }

        public async Task<RemoveScheduledTaskResponse> RemoveScheduledTaskAsync(string appGroupIdentity, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveScheduledTaskWithOptionsAsync(appGroupIdentity, taskId, headers, runtime);
        }

        public RemoveScheduledTaskResponse RemoveScheduledTaskWithOptions(string appGroupIdentity, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveScheduledTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scheduled-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveScheduledTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveScheduledTaskResponse> RemoveScheduledTaskWithOptionsAsync(string appGroupIdentity, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveScheduledTask",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scheduled-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveScheduledTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveSearchStrategyResponse RemoveSearchStrategy(string appGroupIdentity, string appId, string strategyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveSearchStrategyWithOptions(appGroupIdentity, appId, strategyName, headers, runtime);
        }

        public async Task<RemoveSearchStrategyResponse> RemoveSearchStrategyAsync(string appGroupIdentity, string appId, string strategyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveSearchStrategyWithOptionsAsync(appGroupIdentity, appId, strategyName, headers, runtime);
        }

        public RemoveSearchStrategyResponse RemoveSearchStrategyWithOptions(string appGroupIdentity, string appId, string strategyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSearchStrategy",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/search-strategies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(strategyName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSearchStrategyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveSearchStrategyResponse> RemoveSearchStrategyWithOptionsAsync(string appGroupIdentity, string appId, string strategyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSearchStrategy",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/search-strategies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(strategyName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSearchStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveSecondRankResponse RemoveSecondRank(string appGroupIdentity, string appId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveSecondRankWithOptions(appGroupIdentity, appId, name, headers, runtime);
        }

        public async Task<RemoveSecondRankResponse> RemoveSecondRankAsync(string appGroupIdentity, string appId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveSecondRankWithOptionsAsync(appGroupIdentity, appId, name, headers, runtime);
        }

        public RemoveSecondRankResponse RemoveSecondRankWithOptions(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSecondRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/second-ranks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSecondRankResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveSecondRankResponse> RemoveSecondRankWithOptionsAsync(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSecondRank",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/second-ranks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSecondRankResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveUserAnalyzerResponse RemoveUserAnalyzer(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveUserAnalyzerWithOptions(name, headers, runtime);
        }

        public async Task<RemoveUserAnalyzerResponse> RemoveUserAnalyzerAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveUserAnalyzerWithOptionsAsync(name, headers, runtime);
        }

        public RemoveUserAnalyzerResponse RemoveUserAnalyzerWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUserAnalyzer",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/user-analyzers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserAnalyzerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveUserAnalyzerResponse> RemoveUserAnalyzerWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUserAnalyzer",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/user-analyzers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserAnalyzerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RenewAppGroupResponse RenewAppGroup(string appGroupIdentity, RenewAppGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenewAppGroupWithOptions(appGroupIdentity, request, headers, runtime);
        }

        public async Task<RenewAppGroupResponse> RenewAppGroupAsync(string appGroupIdentity, RenewAppGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenewAppGroupWithOptionsAsync(appGroupIdentity, request, headers, runtime);
        }

        public RenewAppGroupResponse RenewAppGroupWithOptions(string appGroupIdentity, RenewAppGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewAppGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/actions/renew",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewAppGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RenewAppGroupResponse> RenewAppGroupWithOptionsAsync(string appGroupIdentity, RenewAppGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewAppGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/actions/renew",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewAppGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReplaceAppGroupCommodityCodeResponse ReplaceAppGroupCommodityCode(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReplaceAppGroupCommodityCodeWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<ReplaceAppGroupCommodityCodeResponse> ReplaceAppGroupCommodityCodeAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReplaceAppGroupCommodityCodeWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public ReplaceAppGroupCommodityCodeResponse ReplaceAppGroupCommodityCodeWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceAppGroupCommodityCode",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/actions/to-instance-typed",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceAppGroupCommodityCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReplaceAppGroupCommodityCodeResponse> ReplaceAppGroupCommodityCodeWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceAppGroupCommodityCode",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/actions/to-instance-typed",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceAppGroupCommodityCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSortScriptFileResponse SaveSortScriptFile(string appGroupIdentity, string scriptName, string appVersionId, string fileName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SaveSortScriptFileWithOptions(appGroupIdentity, scriptName, appVersionId, fileName, headers, runtime);
        }

        public async Task<SaveSortScriptFileResponse> SaveSortScriptFileAsync(string appGroupIdentity, string scriptName, string appVersionId, string fileName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SaveSortScriptFileWithOptionsAsync(appGroupIdentity, scriptName, appVersionId, fileName, headers, runtime);
        }

        public SaveSortScriptFileResponse SaveSortScriptFileWithOptions(string appGroupIdentity, string scriptName, string appVersionId, string fileName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSortScriptFile",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName) + "/files/src/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSortScriptFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSortScriptFileResponse> SaveSortScriptFileWithOptionsAsync(string appGroupIdentity, string scriptName, string appVersionId, string fileName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSortScriptFile",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName) + "/files/src/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSortScriptFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartSlowQueryAnalyzerResponse StartSlowQueryAnalyzer(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartSlowQueryAnalyzerWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<StartSlowQueryAnalyzerResponse> StartSlowQueryAnalyzerAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartSlowQueryAnalyzerWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public StartSlowQueryAnalyzerResponse StartSlowQueryAnalyzerWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSlowQueryAnalyzer",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/optimizers/slow-query/actions/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSlowQueryAnalyzerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartSlowQueryAnalyzerResponse> StartSlowQueryAnalyzerWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSlowQueryAnalyzer",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/optimizers/slow-query/actions/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSlowQueryAnalyzerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/resource-tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/resource-tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TrainModelResponse TrainModel(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TrainModelWithOptions(appGroupIdentity, modelName, headers, runtime);
        }

        public async Task<TrainModelResponse> TrainModelAsync(string appGroupIdentity, string modelName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TrainModelWithOptionsAsync(appGroupIdentity, modelName, headers, runtime);
        }

        public TrainModelResponse TrainModelWithOptions(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainModel",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName) + "/actions/train",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainModelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TrainModelResponse> TrainModelWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrainModel",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/algorithm/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(modelName) + "/actions/train",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrainModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnbindESUserAnalyzerResponse UnbindESUserAnalyzer(string appGroupIdentity, string esInstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnbindESUserAnalyzerWithOptions(appGroupIdentity, esInstanceId, headers, runtime);
        }

        public async Task<UnbindESUserAnalyzerResponse> UnbindESUserAnalyzerAsync(string appGroupIdentity, string esInstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnbindESUserAnalyzerWithOptionsAsync(appGroupIdentity, esInstanceId, headers, runtime);
        }

        public UnbindESUserAnalyzerResponse UnbindESUserAnalyzerWithOptions(string appGroupIdentity, string esInstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindESUserAnalyzer",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/es/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(esInstanceId) + "/actions/unbind-analyzer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindESUserAnalyzerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnbindESUserAnalyzerResponse> UnbindESUserAnalyzerWithOptionsAsync(string appGroupIdentity, string esInstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindESUserAnalyzer",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/es/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(esInstanceId) + "/actions/unbind-analyzer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindESUserAnalyzerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnbindEsInstanceResponse UnbindEsInstance(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnbindEsInstanceWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<UnbindEsInstanceResponse> UnbindEsInstanceAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnbindEsInstanceWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public UnbindEsInstanceResponse UnbindEsInstanceWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindEsInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/actions/unbind-es-instance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindEsInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnbindEsInstanceResponse> UnbindEsInstanceWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindEsInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/actions/unbind-es-instance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindEsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKey))
            {
                request.TagKeyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKey, "tagKey", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyShrink))
            {
                query["tagKey"] = request.TagKeyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/resource-tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKey))
            {
                request.TagKeyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKey, "tagKey", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeyShrink))
            {
                query["tagKey"] = request.TagKeyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/resource-tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateABTestExperimentResponse UpdateABTestExperiment(string appGroupIdentity, string sceneId, string groupId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateABTestExperimentWithOptions(appGroupIdentity, sceneId, groupId, experimentId, headers, runtime);
        }

        public async Task<UpdateABTestExperimentResponse> UpdateABTestExperimentAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateABTestExperimentWithOptionsAsync(appGroupIdentity, sceneId, groupId, experimentId, headers, runtime);
        }

        public UpdateABTestExperimentResponse UpdateABTestExperimentWithOptions(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateABTestExperiment",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateABTestExperimentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateABTestExperimentResponse> UpdateABTestExperimentWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateABTestExperiment",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateABTestExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateABTestFixedFlowDividersResponse UpdateABTestFixedFlowDividers(string appGroupIdentity, string sceneId, string groupId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateABTestFixedFlowDividersWithOptions(appGroupIdentity, sceneId, groupId, experimentId, headers, runtime);
        }

        public async Task<UpdateABTestFixedFlowDividersResponse> UpdateABTestFixedFlowDividersAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateABTestFixedFlowDividersWithOptionsAsync(appGroupIdentity, sceneId, groupId, experimentId, headers, runtime);
        }

        public UpdateABTestFixedFlowDividersResponse UpdateABTestFixedFlowDividersWithOptions(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateABTestFixedFlowDividers",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId) + "/fixed-flow-dividers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateABTestFixedFlowDividersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateABTestFixedFlowDividersResponse> UpdateABTestFixedFlowDividersWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateABTestFixedFlowDividers",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId) + "/fixed-flow-dividers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateABTestFixedFlowDividersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateABTestGroupResponse UpdateABTestGroup(string appGroupIdentity, string sceneId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateABTestGroupWithOptions(appGroupIdentity, sceneId, groupId, headers, runtime);
        }

        public async Task<UpdateABTestGroupResponse> UpdateABTestGroupAsync(string appGroupIdentity, string sceneId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateABTestGroupWithOptionsAsync(appGroupIdentity, sceneId, groupId, headers, runtime);
        }

        public UpdateABTestGroupResponse UpdateABTestGroupWithOptions(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateABTestGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateABTestGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateABTestGroupResponse> UpdateABTestGroupWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateABTestGroup",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateABTestGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateABTestSceneResponse UpdateABTestScene(string appGroupIdentity, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateABTestSceneWithOptions(appGroupIdentity, sceneId, headers, runtime);
        }

        public async Task<UpdateABTestSceneResponse> UpdateABTestSceneAsync(string appGroupIdentity, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateABTestSceneWithOptionsAsync(appGroupIdentity, sceneId, headers, runtime);
        }

        public UpdateABTestSceneResponse UpdateABTestSceneWithOptions(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateABTestScene",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateABTestSceneResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateABTestSceneResponse> UpdateABTestSceneWithOptionsAsync(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateABTestScene",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateABTestSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFetchFieldsResponse UpdateFetchFields(string appGroupIdentity, string appId, UpdateFetchFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFetchFieldsWithOptions(appGroupIdentity, appId, request, headers, runtime);
        }

        public async Task<UpdateFetchFieldsResponse> UpdateFetchFieldsAsync(string appGroupIdentity, string appId, UpdateFetchFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFetchFieldsWithOptionsAsync(appGroupIdentity, appId, request, headers, runtime);
        }

        public UpdateFetchFieldsResponse UpdateFetchFieldsWithOptions(string appGroupIdentity, string appId, UpdateFetchFieldsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFetchFields",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/fetch-fields",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFetchFieldsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFetchFieldsResponse> UpdateFetchFieldsWithOptionsAsync(string appGroupIdentity, string appId, UpdateFetchFieldsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFetchFields",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/fetch-fields",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFetchFieldsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFunctionDefaultInstanceResponse UpdateFunctionDefaultInstance(string appGroupIdentity, string functionName, UpdateFunctionDefaultInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFunctionDefaultInstanceWithOptions(appGroupIdentity, functionName, request, headers, runtime);
        }

        public async Task<UpdateFunctionDefaultInstanceResponse> UpdateFunctionDefaultInstanceAsync(string appGroupIdentity, string functionName, UpdateFunctionDefaultInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFunctionDefaultInstanceWithOptionsAsync(appGroupIdentity, functionName, request, headers, runtime);
        }

        public UpdateFunctionDefaultInstanceResponse UpdateFunctionDefaultInstanceWithOptions(string appGroupIdentity, string functionName, UpdateFunctionDefaultInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFunctionDefaultInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/default-instance",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFunctionDefaultInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFunctionDefaultInstanceResponse> UpdateFunctionDefaultInstanceWithOptionsAsync(string appGroupIdentity, string functionName, UpdateFunctionDefaultInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFunctionDefaultInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/default-instance",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFunctionDefaultInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFunctionInstanceResponse UpdateFunctionInstance(string appGroupIdentity, string functionName, string instanceName, UpdateFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFunctionInstanceWithOptions(appGroupIdentity, functionName, instanceName, request, headers, runtime);
        }

        public async Task<UpdateFunctionInstanceResponse> UpdateFunctionInstanceAsync(string appGroupIdentity, string functionName, string instanceName, UpdateFunctionInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFunctionInstanceWithOptionsAsync(appGroupIdentity, functionName, instanceName, request, headers, runtime);
        }

        public UpdateFunctionInstanceResponse UpdateFunctionInstanceWithOptions(string appGroupIdentity, string functionName, string instanceName, UpdateFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParameters))
            {
                body["createParameters"] = request.CreateParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cron))
            {
                body["cron"] = request.Cron;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageParameters))
            {
                body["usageParameters"] = request.UsageParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFunctionInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFunctionInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFunctionInstanceResponse> UpdateFunctionInstanceWithOptionsAsync(string appGroupIdentity, string functionName, string instanceName, UpdateFunctionInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParameters))
            {
                body["createParameters"] = request.CreateParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cron))
            {
                body["cron"] = request.Cron;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageParameters))
            {
                body["usageParameters"] = request.UsageParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFunctionInstance",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/functions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(functionName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFunctionInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateSearchStrategyResponse UpdateSearchStrategy(string appGroupIdentity, string appId, string strategyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSearchStrategyWithOptions(appGroupIdentity, appId, strategyName, headers, runtime);
        }

        public async Task<UpdateSearchStrategyResponse> UpdateSearchStrategyAsync(string appGroupIdentity, string appId, string strategyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSearchStrategyWithOptionsAsync(appGroupIdentity, appId, strategyName, headers, runtime);
        }

        public UpdateSearchStrategyResponse UpdateSearchStrategyWithOptions(string appGroupIdentity, string appId, string strategyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSearchStrategy",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/search-strategies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(strategyName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSearchStrategyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateSearchStrategyResponse> UpdateSearchStrategyWithOptionsAsync(string appGroupIdentity, string appId, string strategyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSearchStrategy",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/search-strategies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(strategyName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSearchStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateSortScriptResponse UpdateSortScript(string appGroupIdentity, string appVersionId, string scriptName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSortScriptWithOptions(appGroupIdentity, appVersionId, scriptName, headers, runtime);
        }

        public async Task<UpdateSortScriptResponse> UpdateSortScriptAsync(string appGroupIdentity, string appVersionId, string scriptName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSortScriptWithOptionsAsync(appGroupIdentity, appVersionId, scriptName, headers, runtime);
        }

        public UpdateSortScriptResponse UpdateSortScriptWithOptions(string appGroupIdentity, string appVersionId, string scriptName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSortScript",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSortScriptResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateSortScriptResponse> UpdateSortScriptWithOptionsAsync(string appGroupIdentity, string appVersionId, string scriptName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSortScript",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appVersionId) + "/sort-scripts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scriptName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSortScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateSummariesResponse UpdateSummaries(string appGroupIdentity, string appId, UpdateSummariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSummariesWithOptions(appGroupIdentity, appId, request, headers, runtime);
        }

        public async Task<UpdateSummariesResponse> UpdateSummariesAsync(string appGroupIdentity, string appId, UpdateSummariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSummariesWithOptionsAsync(appGroupIdentity, appId, request, headers, runtime);
        }

        public UpdateSummariesResponse UpdateSummariesWithOptions(string appGroupIdentity, string appId, UpdateSummariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSummaries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/summaries",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSummariesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateSummariesResponse> UpdateSummariesWithOptionsAsync(string appGroupIdentity, string appId, UpdateSummariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSummaries",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/app-groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appGroupIdentity) + "/apps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(appId) + "/summaries",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSummariesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ValidateDataSourcesResponse ValidateDataSources()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ValidateDataSourcesWithOptions(headers, runtime);
        }

        public async Task<ValidateDataSourcesResponse> ValidateDataSourcesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ValidateDataSourcesWithOptionsAsync(headers, runtime);
        }

        public ValidateDataSourcesResponse ValidateDataSourcesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateDataSources",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/assist/data-sources/validations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateDataSourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ValidateDataSourcesResponse> ValidateDataSourcesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateDataSources",
                Version = "2017-12-25",
                Protocol = "HTTPS",
                Pathname = "/v4/openapi/assist/data-sources/validations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateDataSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

    }
}
