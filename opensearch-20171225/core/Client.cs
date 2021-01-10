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
            return TeaModel.ToObject<CompileSortScriptResponse>(DoROARequest("CompileSortScript", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}/actions/compiling", "json", req, runtime));
        }

        public async Task<CompileSortScriptResponse> CompileSortScriptWithOptionsAsync(string appGroupIdentity, string scriptName, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CompileSortScriptResponse>(await DoROARequestAsync("CompileSortScript", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}/actions/compiling", "json", req, runtime));
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
            return TeaModel.ToObject<CreateABTestExperimentResponse>(DoROARequest("CreateABTestExperiment", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments", "json", req, runtime));
        }

        public async Task<CreateABTestExperimentResponse> CreateABTestExperimentWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateABTestExperimentResponse>(await DoROARequestAsync("CreateABTestExperiment", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments", "json", req, runtime));
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
            return TeaModel.ToObject<CreateABTestGroupResponse>(DoROARequest("CreateABTestGroup", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups", "json", req, runtime));
        }

        public async Task<CreateABTestGroupResponse> CreateABTestGroupWithOptionsAsync(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateABTestGroupResponse>(await DoROARequestAsync("CreateABTestGroup", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups", "json", req, runtime));
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
            return TeaModel.ToObject<CreateABTestSceneResponse>(DoROARequest("CreateABTestScene", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes", "json", req, runtime));
        }

        public async Task<CreateABTestSceneResponse> CreateABTestSceneWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateABTestSceneResponse>(await DoROARequestAsync("CreateABTestScene", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes", "json", req, runtime));
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
            return TeaModel.ToObject<CreateAppResponse>(DoROARequest("CreateApp", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps", "json", req, runtime));
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
            return TeaModel.ToObject<CreateAppResponse>(await DoROARequestAsync("CreateApp", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps", "json", req, runtime));
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
            return TeaModel.ToObject<CreateAppGroupResponse>(DoROARequest("CreateAppGroup", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups", "json", req, runtime));
        }

        public async Task<CreateAppGroupResponse> CreateAppGroupWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateAppGroupResponse>(await DoROARequestAsync("CreateAppGroup", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups", "json", req, runtime));
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
            return TeaModel.ToObject<CreateDataCollectionResponse>(DoROARequest("CreateDataCollection", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/data-collections", "json", req, runtime));
        }

        public async Task<CreateDataCollectionResponse> CreateDataCollectionWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateDataCollectionResponse>(await DoROARequestAsync("CreateDataCollection", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/data-collections", "json", req, runtime));
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
            return TeaModel.ToObject<CreateFirstRankResponse>(DoROARequest("CreateFirstRank", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/first-ranks", "json", req, runtime));
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
            return TeaModel.ToObject<CreateFirstRankResponse>(await DoROARequestAsync("CreateFirstRank", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/first-ranks", "json", req, runtime));
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
            return TeaModel.ToObject<CreateInterventionDictionaryResponse>(DoROARequest("CreateInterventionDictionary", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/intervention-dictionaries", "json", req, runtime));
        }

        public async Task<CreateInterventionDictionaryResponse> CreateInterventionDictionaryWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateInterventionDictionaryResponse>(await DoROARequestAsync("CreateInterventionDictionary", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/intervention-dictionaries", "json", req, runtime));
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
            return TeaModel.ToObject<CreateModelResponse>(DoROARequest("CreateModel", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models", "json", req, runtime));
        }

        public async Task<CreateModelResponse> CreateModelWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateModelResponse>(await DoROARequestAsync("CreateModel", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models", "json", req, runtime));
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
            return TeaModel.ToObject<CreateQueryProcessorResponse>(DoROARequest("CreateQueryProcessor", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/query-processors", "json", req, runtime));
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
            return TeaModel.ToObject<CreateQueryProcessorResponse>(await DoROARequestAsync("CreateQueryProcessor", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/query-processors", "json", req, runtime));
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
            return TeaModel.ToObject<CreateScheduledTaskResponse>(DoROARequest("CreateScheduledTask", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scheduled-tasks", "json", req, runtime));
        }

        public async Task<CreateScheduledTaskResponse> CreateScheduledTaskWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateScheduledTaskResponse>(await DoROARequestAsync("CreateScheduledTask", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scheduled-tasks", "json", req, runtime));
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
            return TeaModel.ToObject<CreateSecondRankResponse>(DoROARequest("CreateSecondRank", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/second-ranks", "json", req, runtime));
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
            return TeaModel.ToObject<CreateSecondRankResponse>(await DoROARequestAsync("CreateSecondRank", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/second-ranks", "json", req, runtime));
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
            return TeaModel.ToObject<CreateSortScriptResponse>(DoROARequest("CreateSortScript", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts", "json", req, runtime));
        }

        public async Task<CreateSortScriptResponse> CreateSortScriptWithOptionsAsync(string appGroupIdentity, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateSortScriptResponse>(await DoROARequestAsync("CreateSortScript", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts", "json", req, runtime));
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
            return TeaModel.ToObject<CreateUserAnalyzerResponse>(DoROARequest("CreateUserAnalyzer", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/user-analyzers", "json", req, runtime));
        }

        public async Task<CreateUserAnalyzerResponse> CreateUserAnalyzerWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateUserAnalyzerResponse>(await DoROARequestAsync("CreateUserAnalyzer", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/user-analyzers", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteABTestExperimentResponse>(DoROARequest("DeleteABTestExperiment", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments/{experimentId}", "json", req, runtime));
        }

        public async Task<DeleteABTestExperimentResponse> DeleteABTestExperimentWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteABTestExperimentResponse>(await DoROARequestAsync("DeleteABTestExperiment", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments/{experimentId}", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteABTestGroupResponse>(DoROARequest("DeleteABTestGroup", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}", "json", req, runtime));
        }

        public async Task<DeleteABTestGroupResponse> DeleteABTestGroupWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteABTestGroupResponse>(await DoROARequestAsync("DeleteABTestGroup", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteABTestSceneResponse>(DoROARequest("DeleteABTestScene", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}", "json", req, runtime));
        }

        public async Task<DeleteABTestSceneResponse> DeleteABTestSceneWithOptionsAsync(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteABTestSceneResponse>(await DoROARequestAsync("DeleteABTestScene", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteModelResponse>(DoROARequest("DeleteModel", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}", "json", req, runtime));
        }

        public async Task<DeleteModelResponse> DeleteModelWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteModelResponse>(await DoROARequestAsync("DeleteModel", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteSortScriptResponse>(DoROARequest("DeleteSortScript", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}", "json", req, runtime));
        }

        public async Task<DeleteSortScriptResponse> DeleteSortScriptWithOptionsAsync(string appGroupIdentity, string scriptName, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteSortScriptResponse>(await DoROARequestAsync("DeleteSortScript", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteSortScriptFileResponse>(DoROARequest("DeleteSortScriptFile", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}/files/src/{fileName}", "json", req, runtime));
        }

        public async Task<DeleteSortScriptFileResponse> DeleteSortScriptFileWithOptionsAsync(string appGroupIdentity, string appVersionId, string scriptName, string fileName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteSortScriptFileResponse>(await DoROARequestAsync("DeleteSortScriptFile", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}/files/src/{fileName}", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeABTestExperimentResponse>(DoROARequest("DescribeABTestExperiment", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments/{experimentId}", "json", req, runtime));
        }

        public async Task<DescribeABTestExperimentResponse> DescribeABTestExperimentWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeABTestExperimentResponse>(await DoROARequestAsync("DescribeABTestExperiment", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments/{experimentId}", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeABTestGroupResponse>(DoROARequest("DescribeABTestGroup", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}", "json", req, runtime));
        }

        public async Task<DescribeABTestGroupResponse> DescribeABTestGroupWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeABTestGroupResponse>(await DoROARequestAsync("DescribeABTestGroup", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeABTestSceneResponse>(DoROARequest("DescribeABTestScene", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}", "json", req, runtime));
        }

        public async Task<DescribeABTestSceneResponse> DescribeABTestSceneWithOptionsAsync(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeABTestSceneResponse>(await DoROARequestAsync("DescribeABTestScene", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeAppResponse>(DoROARequest("DescribeApp", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}", "json", req, runtime));
        }

        public async Task<DescribeAppResponse> DescribeAppWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeAppResponse>(await DoROARequestAsync("DescribeApp", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeAppGroupResponse>(DoROARequest("DescribeAppGroup", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity, "json", req, runtime));
        }

        public async Task<DescribeAppGroupResponse> DescribeAppGroupWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeAppGroupResponse>(await DoROARequestAsync("DescribeAppGroup", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity, "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppGroupDataReportResponse>(DoROARequest("DescribeAppGroupDataReport", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/data-report", "json", req, runtime));
        }

        public async Task<DescribeAppGroupDataReportResponse> DescribeAppGroupDataReportWithOptionsAsync(string appGroupIdentity, DescribeAppGroupDataReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppGroupDataReportResponse>(await DoROARequestAsync("DescribeAppGroupDataReport", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/data-report", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeAppsResponse>(DoROARequest("DescribeApps", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps", "json", req, runtime));
        }

        public async Task<DescribeAppsResponse> DescribeAppsWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeAppsResponse>(await DoROARequestAsync("DescribeApps", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeAppStatisticsResponse>(DoROARequest("DescribeAppStatistics", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/statistics", "json", req, runtime));
        }

        public async Task<DescribeAppStatisticsResponse> DescribeAppStatisticsWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeAppStatisticsResponse>(await DoROARequestAsync("DescribeAppStatistics", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/statistics", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeDataCollctionResponse>(DoROARequest("DescribeDataCollction", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/data-collections/{dataCollectionIdentity}", "json", req, runtime));
        }

        public async Task<DescribeDataCollctionResponse> DescribeDataCollctionWithOptionsAsync(string appGroupIdentity, string dataCollectionIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeDataCollctionResponse>(await DoROARequestAsync("DescribeDataCollction", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/data-collections/{dataCollectionIdentity}", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeFirstRankResponse>(DoROARequest("DescribeFirstRank", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/first-ranks/{name}", "json", req, runtime));
        }

        public async Task<DescribeFirstRankResponse> DescribeFirstRankWithOptionsAsync(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeFirstRankResponse>(await DoROARequestAsync("DescribeFirstRank", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/first-ranks/{name}", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeInterventionDictionaryResponse>(DoROARequest("DescribeInterventionDictionary", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/intervention-dictionaries/" + name, "json", req, runtime));
        }

        public async Task<DescribeInterventionDictionaryResponse> DescribeInterventionDictionaryWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeInterventionDictionaryResponse>(await DoROARequestAsync("DescribeInterventionDictionary", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/intervention-dictionaries/" + name, "json", req, runtime));
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
            return TeaModel.ToObject<DescribeModelResponse>(DoROARequest("DescribeModel", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}", "json", req, runtime));
        }

        public async Task<DescribeModelResponse> DescribeModelWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeModelResponse>(await DoROARequestAsync("DescribeModel", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeQueryProcessorResponse>(DoROARequest("DescribeQueryProcessor", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/query-processors/{name}", "json", req, runtime));
        }

        public async Task<DescribeQueryProcessorResponse> DescribeQueryProcessorWithOptionsAsync(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeQueryProcessorResponse>(await DoROARequestAsync("DescribeQueryProcessor", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/query-processors/{name}", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeRegionResponse>(DoROARequest("DescribeRegion", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/region", "json", req, runtime));
        }

        public async Task<DescribeRegionResponse> DescribeRegionWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeRegionResponse>(await DoROARequestAsync("DescribeRegion", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/region", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeRegionsResponse>(DoROARequest("DescribeRegions", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/regions", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoROARequestAsync("DescribeRegions", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/regions", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeScheduledTaskResponse>(DoROARequest("DescribeScheduledTask", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scheduled-tasks/{taskId}", "json", req, runtime));
        }

        public async Task<DescribeScheduledTaskResponse> DescribeScheduledTaskWithOptionsAsync(string appGroupIdentity, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeScheduledTaskResponse>(await DoROARequestAsync("DescribeScheduledTask", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scheduled-tasks/{taskId}", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeSecondRankResponse>(DoROARequest("DescribeSecondRank", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/second-ranks/{name}", "json", req, runtime));
        }

        public async Task<DescribeSecondRankResponse> DescribeSecondRankWithOptionsAsync(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeSecondRankResponse>(await DoROARequestAsync("DescribeSecondRank", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/second-ranks/{name}", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeSlowQueryStatusResponse>(DoROARequest("DescribeSlowQueryStatus", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/optimizers/slow-query", "json", req, runtime));
        }

        public async Task<DescribeSlowQueryStatusResponse> DescribeSlowQueryStatusWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeSlowQueryStatusResponse>(await DoROARequestAsync("DescribeSlowQueryStatus", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/optimizers/slow-query", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeUserAnalyzerResponse>(DoROARequest("DescribeUserAnalyzer", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/user-analyzers/" + name, "json", req, runtime));
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
            return TeaModel.ToObject<DescribeUserAnalyzerResponse>(await DoROARequestAsync("DescribeUserAnalyzer", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/user-analyzers/" + name, "json", req, runtime));
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
            return TeaModel.ToObject<DisableSlowQueryResponse>(DoROARequest("DisableSlowQuery", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/optimizers/slow-query/actions/disable", "json", req, runtime));
        }

        public async Task<DisableSlowQueryResponse> DisableSlowQueryWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DisableSlowQueryResponse>(await DoROARequestAsync("DisableSlowQuery", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/optimizers/slow-query/actions/disable", "json", req, runtime));
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
            return TeaModel.ToObject<EnableSlowQueryResponse>(DoROARequest("EnableSlowQuery", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/optimizers/slow-query/actions/enable", "json", req, runtime));
        }

        public async Task<EnableSlowQueryResponse> EnableSlowQueryWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<EnableSlowQueryResponse>(await DoROARequestAsync("EnableSlowQuery", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/optimizers/slow-query/actions/enable", "json", req, runtime));
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
            return TeaModel.ToObject<GetModelProgressResponse>(DoROARequest("GetModelProgress", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}/progress", "json", req, runtime));
        }

        public async Task<GetModelProgressResponse> GetModelProgressWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetModelProgressResponse>(await DoROARequestAsync("GetModelProgress", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}/progress", "json", req, runtime));
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
            return TeaModel.ToObject<GetModelReportResponse>(DoROARequest("GetModelReport", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}/report", "json", req, runtime));
        }

        public async Task<GetModelReportResponse> GetModelReportWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetModelReportResponse>(await DoROARequestAsync("GetModelReport", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}/report", "json", req, runtime));
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
            return TeaModel.ToObject<GetScriptFileNamesResponse>(DoROARequest("GetScriptFileNames", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}/file-names", "json", req, runtime));
        }

        public async Task<GetScriptFileNamesResponse> GetScriptFileNamesWithOptionsAsync(string appGroupIdentity, string appVersionId, string scriptName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetScriptFileNamesResponse>(await DoROARequestAsync("GetScriptFileNames", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}/file-names", "json", req, runtime));
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
            return TeaModel.ToObject<GetSortScriptResponse>(DoROARequest("GetSortScript", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}", "json", req, runtime));
        }

        public async Task<GetSortScriptResponse> GetSortScriptWithOptionsAsync(string appGroupIdentity, string scriptName, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetSortScriptResponse>(await DoROARequestAsync("GetSortScript", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}", "json", req, runtime));
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
            return TeaModel.ToObject<GetSortScriptFileResponse>(DoROARequest("GetSortScriptFile", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}/files/src/{fileName}", "json", req, runtime));
        }

        public async Task<GetSortScriptFileResponse> GetSortScriptFileWithOptionsAsync(string appGroupIdentity, string scriptName, string appVersionId, string fileName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetSortScriptFileResponse>(await DoROARequestAsync("GetSortScriptFile", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}/files/src/{fileName}", "json", req, runtime));
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
            return TeaModel.ToObject<GetValidationErrorResponse>(DoROARequest("GetValidationError", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/data/validation-error", "json", req, runtime));
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
            return TeaModel.ToObject<GetValidationErrorResponse>(await DoROARequestAsync("GetValidationError", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/data/validation-error", "json", req, runtime));
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
            return TeaModel.ToObject<GetValidationReportResponse>(DoROARequest("GetValidationReport", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/data/validation-report", "json", req, runtime));
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
            return TeaModel.ToObject<GetValidationReportResponse>(await DoROARequestAsync("GetValidationReport", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/data/validation-report", "json", req, runtime));
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
            return TeaModel.ToObject<ListABTestExperimentsResponse>(DoROARequest("ListABTestExperiments", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments", "json", req, runtime));
        }

        public async Task<ListABTestExperimentsResponse> ListABTestExperimentsWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListABTestExperimentsResponse>(await DoROARequestAsync("ListABTestExperiments", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments", "json", req, runtime));
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
            return TeaModel.ToObject<ListABTestFixedFlowDividersResponse>(DoROARequest("ListABTestFixedFlowDividers", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments/{experimentId}/fixed-flow-dividers", "json", req, runtime));
        }

        public async Task<ListABTestFixedFlowDividersResponse> ListABTestFixedFlowDividersWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListABTestFixedFlowDividersResponse>(await DoROARequestAsync("ListABTestFixedFlowDividers", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments/{experimentId}/fixed-flow-dividers", "json", req, runtime));
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
            return TeaModel.ToObject<ListABTestGroupsResponse>(DoROARequest("ListABTestGroups", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups", "json", req, runtime));
        }

        public async Task<ListABTestGroupsResponse> ListABTestGroupsWithOptionsAsync(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListABTestGroupsResponse>(await DoROARequestAsync("ListABTestGroups", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups", "json", req, runtime));
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
            return TeaModel.ToObject<ListABTestMetricsResponse>(DoROARequest("ListABTestMetrics", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/metrics", "json", req, runtime));
        }

        public async Task<ListABTestMetricsResponse> ListABTestMetricsWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListABTestMetricsResponse>(await DoROARequestAsync("ListABTestMetrics", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/metrics", "json", req, runtime));
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
            return TeaModel.ToObject<ListABTestScenesResponse>(DoROARequest("ListABTestScenes", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes", "json", req, runtime));
        }

        public async Task<ListABTestScenesResponse> ListABTestScenesWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListABTestScenesResponse>(await DoROARequestAsync("ListABTestScenes", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTime))
            {
                query["stopTime"] = request.StopTime;
            }
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
            return TeaModel.ToObject<ListAppGroupErrorsResponse>(DoROARequest("ListAppGroupErrors", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/errors", "json", req, runtime));
        }

        public async Task<ListAppGroupErrorsResponse> ListAppGroupErrorsWithOptionsAsync(string appGroupIdentity, ListAppGroupErrorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTime))
            {
                query["stopTime"] = request.StopTime;
            }
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
            return TeaModel.ToObject<ListAppGroupErrorsResponse>(await DoROARequestAsync("ListAppGroupErrors", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/errors", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["metricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Indexes))
            {
                query["indexes"] = request.Indexes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAppGroupMetricsResponse>(DoROARequest("ListAppGroupMetrics", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/metrics", "json", req, runtime));
        }

        public async Task<ListAppGroupMetricsResponse> ListAppGroupMetricsWithOptionsAsync(string appGroupIdentity, ListAppGroupMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["metricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Indexes))
            {
                query["indexes"] = request.Indexes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAppGroupMetricsResponse>(await DoROARequestAsync("ListAppGroupMetrics", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/metrics", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["sortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAppGroupsResponse>(DoROARequest("ListAppGroups", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups", "json", req, runtime));
        }

        public async Task<ListAppGroupsResponse> ListAppGroupsWithOptionsAsync(ListAppGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["sortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAppGroupsResponse>(await DoROARequestAsync("ListAppGroups", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups", "json", req, runtime));
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
            return TeaModel.ToObject<ListAppsResponse>(DoROARequest("ListApps", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/apps", "none", req, runtime));
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
            return TeaModel.ToObject<ListAppsResponse>(await DoROARequestAsync("ListApps", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/apps", "none", req, runtime));
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
            return TeaModel.ToObject<ListDataCollectionsResponse>(DoROARequest("ListDataCollections", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/data-collections", "json", req, runtime));
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
            return TeaModel.ToObject<ListDataCollectionsResponse>(await DoROARequestAsync("ListDataCollections", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/data-collections", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InServiceOnly))
            {
                query["inServiceOnly"] = request.InServiceOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmType))
            {
                query["algorithmType"] = request.AlgorithmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDeployedAlgorithmModelsResponse>(DoROARequest("ListDeployedAlgorithmModels", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/deployed-algorithm-models", "json", req, runtime));
        }

        public async Task<ListDeployedAlgorithmModelsResponse> ListDeployedAlgorithmModelsWithOptionsAsync(string appGroupIdentity, ListDeployedAlgorithmModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InServiceOnly))
            {
                query["inServiceOnly"] = request.InServiceOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmType))
            {
                query["algorithmType"] = request.AlgorithmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDeployedAlgorithmModelsResponse>(await DoROARequestAsync("ListDeployedAlgorithmModels", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/deployed-algorithm-models", "json", req, runtime));
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
            return TeaModel.ToObject<ListFirstRanksResponse>(DoROARequest("ListFirstRanks", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/first-ranks", "json", req, runtime));
        }

        public async Task<ListFirstRanksResponse> ListFirstRanksWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListFirstRanksResponse>(await DoROARequestAsync("ListFirstRanks", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/first-ranks", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
            return TeaModel.ToObject<ListInterventionDictionariesResponse>(DoROARequest("ListInterventionDictionaries", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/intervention-dictionaries", "json", req, runtime));
        }

        public async Task<ListInterventionDictionariesResponse> ListInterventionDictionariesWithOptionsAsync(ListInterventionDictionariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
            return TeaModel.ToObject<ListInterventionDictionariesResponse>(await DoROARequestAsync("ListInterventionDictionaries", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/intervention-dictionaries", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                query["word"] = request.Word;
            }
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
            return TeaModel.ToObject<ListInterventionDictionaryEntriesResponse>(DoROARequest("ListInterventionDictionaryEntries", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/intervention-dictionaries/" + name + "/entries", "json", req, runtime));
        }

        public async Task<ListInterventionDictionaryEntriesResponse> ListInterventionDictionaryEntriesWithOptionsAsync(string name, ListInterventionDictionaryEntriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                query["word"] = request.Word;
            }
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
            return TeaModel.ToObject<ListInterventionDictionaryEntriesResponse>(await DoROARequestAsync("ListInterventionDictionaryEntries", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/intervention-dictionaries/" + name + "/entries", "json", req, runtime));
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
            return TeaModel.ToObject<ListInterventionDictionaryNerResultsResponse>(DoROARequest("ListInterventionDictionaryNerResults", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/intervention-dictionaries/" + name + "/ner-results", "json", req, runtime));
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
            return TeaModel.ToObject<ListInterventionDictionaryNerResultsResponse>(await DoROARequestAsync("ListInterventionDictionaryNerResults", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/intervention-dictionaries/" + name + "/ner-results", "json", req, runtime));
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
            return TeaModel.ToObject<ListInterventionDictionaryRelatedEntitiesResponse>(DoROARequest("ListInterventionDictionaryRelatedEntities", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/intervention-dictionaries/" + name + "/related", "json", req, runtime));
        }

        public async Task<ListInterventionDictionaryRelatedEntitiesResponse> ListInterventionDictionaryRelatedEntitiesWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListInterventionDictionaryRelatedEntitiesResponse>(await DoROARequestAsync("ListInterventionDictionaryRelatedEntities", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/intervention-dictionaries/" + name + "/related", "json", req, runtime));
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
            return TeaModel.ToObject<ListModelsResponse>(DoROARequest("ListModels", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models", "json", req, runtime));
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
            return TeaModel.ToObject<ListModelsResponse>(await DoROARequestAsync("ListModels", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models", "json", req, runtime));
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
            return TeaModel.ToObject<ListQueryProcessorNersResponse>(DoROARequest("ListQueryProcessorNers", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/query-processor/ner/default-priorities", "json", req, runtime));
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
            return TeaModel.ToObject<ListQueryProcessorNersResponse>(await DoROARequestAsync("ListQueryProcessorNers", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/query-processor/ner/default-priorities", "json", req, runtime));
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
            return TeaModel.ToObject<ListQueryProcessorsResponse>(DoROARequest("ListQueryProcessors", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/query-processors", "json", req, runtime));
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
            return TeaModel.ToObject<ListQueryProcessorsResponse>(await DoROARequestAsync("ListQueryProcessors", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/query-processors", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
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
            return TeaModel.ToObject<ListScheduledTasksResponse>(DoROARequest("ListScheduledTasks", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scheduled-tasks", "json", req, runtime));
        }

        public async Task<ListScheduledTasksResponse> ListScheduledTasksWithOptionsAsync(string appGroupIdentity, ListScheduledTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
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
            return TeaModel.ToObject<ListScheduledTasksResponse>(await DoROARequestAsync("ListScheduledTasks", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scheduled-tasks", "json", req, runtime));
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
            return TeaModel.ToObject<ListSecondRanksResponse>(DoROARequest("ListSecondRanks", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/second-ranks", "json", req, runtime));
        }

        public async Task<ListSecondRanksResponse> ListSecondRanksWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListSecondRanksResponse>(await DoROARequestAsync("ListSecondRanks", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/second-ranks", "json", req, runtime));
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
            return TeaModel.ToObject<ListSlowQueryCategoriesResponse>(DoROARequest("ListSlowQueryCategories", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/optimizers/slow-query/categories", "json", req, runtime));
        }

        public async Task<ListSlowQueryCategoriesResponse> ListSlowQueryCategoriesWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListSlowQueryCategoriesResponse>(await DoROARequestAsync("ListSlowQueryCategories", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/optimizers/slow-query/categories", "json", req, runtime));
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
            return TeaModel.ToObject<ListSlowQueryQueriesResponse>(DoROARequest("ListSlowQueryQueries", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/optimizers/slow-query/categories/{categoryIndex}/queries", "json", req, runtime));
        }

        public async Task<ListSlowQueryQueriesResponse> ListSlowQueryQueriesWithOptionsAsync(string appGroupIdentity, string categoryIndex, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListSlowQueryQueriesResponse>(await DoROARequestAsync("ListSlowQueryQueries", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/optimizers/slow-query/categories/{categoryIndex}/queries", "json", req, runtime));
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
            return TeaModel.ToObject<ListSortExpressionsResponse>(DoROARequest("ListSortExpressions", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/sort-expressions", "json", req, runtime));
        }

        public async Task<ListSortExpressionsResponse> ListSortExpressionsWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListSortExpressionsResponse>(await DoROARequestAsync("ListSortExpressions", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/sort-expressions", "json", req, runtime));
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
            return TeaModel.ToObject<ListSortScriptsResponse>(DoROARequest("ListSortScripts", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts", "json", req, runtime));
        }

        public async Task<ListSortScriptsResponse> ListSortScriptsWithOptionsAsync(string appGroupIdentity, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListSortScriptsResponse>(await DoROARequestAsync("ListSortScripts", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTime))
            {
                query["stopTime"] = request.StopTime;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Distinct))
            {
                query["distinct"] = request.Distinct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Columns))
            {
                query["columns"] = request.Columns;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListStatisticLogsResponse>(DoROARequest("ListStatisticLogs", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/statistic-logs/{moduleName}", "json", req, runtime));
        }

        public async Task<ListStatisticLogsResponse> ListStatisticLogsWithOptionsAsync(string appGroupIdentity, string moduleName, ListStatisticLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTime))
            {
                query["stopTime"] = request.StopTime;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Distinct))
            {
                query["distinct"] = request.Distinct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Columns))
            {
                query["columns"] = request.Columns;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListStatisticLogsResponse>(await DoROARequestAsync("ListStatisticLogs", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/statistic-logs/{moduleName}", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Columns))
            {
                query["columns"] = request.Columns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListStatisticReportResponse>(DoROARequest("ListStatisticReport", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/statistic-report/{moduleName}", "json", req, runtime));
        }

        public async Task<ListStatisticReportResponse> ListStatisticReportWithOptionsAsync(string appGroupIdentity, string moduleName, ListStatisticReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Columns))
            {
                query["columns"] = request.Columns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListStatisticReportResponse>(await DoROARequestAsync("ListStatisticReport", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/statistic-report/{moduleName}", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                query["word"] = request.Word;
            }
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
            return TeaModel.ToObject<ListUserAnalyzerEntriesResponse>(DoROARequest("ListUserAnalyzerEntries", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/user-analyzers/" + name + "/entries", "json", req, runtime));
        }

        public async Task<ListUserAnalyzerEntriesResponse> ListUserAnalyzerEntriesWithOptionsAsync(string name, ListUserAnalyzerEntriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                query["word"] = request.Word;
            }
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
            return TeaModel.ToObject<ListUserAnalyzerEntriesResponse>(await DoROARequestAsync("ListUserAnalyzerEntries", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/user-analyzers/" + name + "/entries", "json", req, runtime));
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
            return TeaModel.ToObject<ListUserAnalyzersResponse>(DoROARequest("ListUserAnalyzers", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/user-analyzers", "json", req, runtime));
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
            return TeaModel.ToObject<ListUserAnalyzersResponse>(await DoROARequestAsync("ListUserAnalyzers", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/user-analyzers", "json", req, runtime));
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
            return TeaModel.ToObject<ModifyAppGroupResponse>(DoROARequest("ModifyAppGroup", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity, "json", req, runtime));
        }

        public async Task<ModifyAppGroupResponse> ModifyAppGroupWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyAppGroupResponse>(await DoROARequestAsync("ModifyAppGroup", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity, "json", req, runtime));
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
            return TeaModel.ToObject<ModifyAppGroupQuotaResponse>(DoROARequest("ModifyAppGroupQuota", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/quota", "json", req, runtime));
        }

        public async Task<ModifyAppGroupQuotaResponse> ModifyAppGroupQuotaWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyAppGroupQuotaResponse>(await DoROARequestAsync("ModifyAppGroupQuota", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/quota", "json", req, runtime));
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
            return TeaModel.ToObject<ModifyFirstRankResponse>(DoROARequest("ModifyFirstRank", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/first-ranks/{name}", "json", req, runtime));
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
            return TeaModel.ToObject<ModifyFirstRankResponse>(await DoROARequestAsync("ModifyFirstRank", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/first-ranks/{name}", "json", req, runtime));
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
            return TeaModel.ToObject<ModifyModelResponse>(DoROARequest("ModifyModel", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}", "json", req, runtime));
        }

        public async Task<ModifyModelResponse> ModifyModelWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyModelResponse>(await DoROARequestAsync("ModifyModel", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}", "json", req, runtime));
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
            return TeaModel.ToObject<ModifyQueryProcessorResponse>(DoROARequest("ModifyQueryProcessor", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/query-processors/{name}", "json", req, runtime));
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
            return TeaModel.ToObject<ModifyQueryProcessorResponse>(await DoROARequestAsync("ModifyQueryProcessor", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/query-processors/{name}", "json", req, runtime));
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
            return TeaModel.ToObject<ModifyScheduledTaskResponse>(DoROARequest("ModifyScheduledTask", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scheduled-tasks/{taskId}", "json", req, runtime));
        }

        public async Task<ModifyScheduledTaskResponse> ModifyScheduledTaskWithOptionsAsync(string appGroupIdentity, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyScheduledTaskResponse>(await DoROARequestAsync("ModifyScheduledTask", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scheduled-tasks/{taskId}", "json", req, runtime));
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
            return TeaModel.ToObject<ModifySecondRankResponse>(DoROARequest("ModifySecondRank", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/second-ranks/{name}", "json", req, runtime));
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
            return TeaModel.ToObject<ModifySecondRankResponse>(await DoROARequestAsync("ModifySecondRank", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/second-ranks/{name}", "json", req, runtime));
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
            return TeaModel.ToObject<PreviewModelResponse>(DoROARequest("PreviewModel", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}/actions/preview", "json", req, runtime));
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
            return TeaModel.ToObject<PreviewModelResponse>(await DoROARequestAsync("PreviewModel", "2017-12-25", "HTTPS", "GET", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}/actions/preview", "json", req, runtime));
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
            return TeaModel.ToObject<PushInterventionDictionaryEntriesResponse>(DoROARequest("PushInterventionDictionaryEntries", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/intervention-dictionaries/" + name + "/entries/actions/bulk", "json", req, runtime));
        }

        public async Task<PushInterventionDictionaryEntriesResponse> PushInterventionDictionaryEntriesWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PushInterventionDictionaryEntriesResponse>(await DoROARequestAsync("PushInterventionDictionaryEntries", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/intervention-dictionaries/" + name + "/entries/actions/bulk", "json", req, runtime));
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
            return TeaModel.ToObject<PushUserAnalyzerEntriesResponse>(DoROARequest("PushUserAnalyzerEntries", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/user-analyzers/" + name + "/entries/actions/bulk", "json", req, runtime));
        }

        public async Task<PushUserAnalyzerEntriesResponse> PushUserAnalyzerEntriesWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PushUserAnalyzerEntriesResponse>(await DoROARequestAsync("PushUserAnalyzerEntries", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/user-analyzers/" + name + "/entries/actions/bulk", "json", req, runtime));
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
            return TeaModel.ToObject<RankPreviewQueryResponse>(DoROARequest("RankPreviewQuery", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}/actions/query-rank", "json", req, runtime));
        }

        public async Task<RankPreviewQueryResponse> RankPreviewQueryWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RankPreviewQueryResponse>(await DoROARequestAsync("RankPreviewQuery", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}/actions/query-rank", "json", req, runtime));
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
            return TeaModel.ToObject<ReleaseSortScriptResponse>(DoROARequest("ReleaseSortScript", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}/actions/release", "json", req, runtime));
        }

        public async Task<ReleaseSortScriptResponse> ReleaseSortScriptWithOptionsAsync(string appGroupIdentity, string scriptName, string appVersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ReleaseSortScriptResponse>(await DoROARequestAsync("ReleaseSortScript", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}/actions/release", "json", req, runtime));
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
            return TeaModel.ToObject<RemoveAppResponse>(DoROARequest("RemoveApp", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}", "json", req, runtime));
        }

        public async Task<RemoveAppResponse> RemoveAppWithOptionsAsync(string appGroupIdentity, string appId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RemoveAppResponse>(await DoROARequestAsync("RemoveApp", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}", "json", req, runtime));
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
            return TeaModel.ToObject<RemoveAppGroupResponse>(DoROARequest("RemoveAppGroup", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity, "json", req, runtime));
        }

        public async Task<RemoveAppGroupResponse> RemoveAppGroupWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RemoveAppGroupResponse>(await DoROARequestAsync("RemoveAppGroup", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity, "json", req, runtime));
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
            return TeaModel.ToObject<RemoveDataCollectionResponse>(DoROARequest("RemoveDataCollection", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/data-collections/{dataCollectionIdentity}", "json", req, runtime));
        }

        public async Task<RemoveDataCollectionResponse> RemoveDataCollectionWithOptionsAsync(string appGroupIdentity, string dataCollectionIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RemoveDataCollectionResponse>(await DoROARequestAsync("RemoveDataCollection", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/data-collections/{dataCollectionIdentity}", "json", req, runtime));
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
            return TeaModel.ToObject<RemoveFirstRankResponse>(DoROARequest("RemoveFirstRank", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/first-ranks/{name}", "json", req, runtime));
        }

        public async Task<RemoveFirstRankResponse> RemoveFirstRankWithOptionsAsync(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RemoveFirstRankResponse>(await DoROARequestAsync("RemoveFirstRank", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/first-ranks/{name}", "json", req, runtime));
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
            return TeaModel.ToObject<RemoveInterventionDictionaryResponse>(DoROARequest("RemoveInterventionDictionary", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/intervention-dictionaries/" + name, "json", req, runtime));
        }

        public async Task<RemoveInterventionDictionaryResponse> RemoveInterventionDictionaryWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RemoveInterventionDictionaryResponse>(await DoROARequestAsync("RemoveInterventionDictionary", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/intervention-dictionaries/" + name, "json", req, runtime));
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
            return TeaModel.ToObject<RemoveQueryProcessorResponse>(DoROARequest("RemoveQueryProcessor", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/query-processors/{name}", "json", req, runtime));
        }

        public async Task<RemoveQueryProcessorResponse> RemoveQueryProcessorWithOptionsAsync(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RemoveQueryProcessorResponse>(await DoROARequestAsync("RemoveQueryProcessor", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/query-processors/{name}", "json", req, runtime));
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
            return TeaModel.ToObject<RemoveScheduledTaskResponse>(DoROARequest("RemoveScheduledTask", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scheduled-tasks/{taskId}", "json", req, runtime));
        }

        public async Task<RemoveScheduledTaskResponse> RemoveScheduledTaskWithOptionsAsync(string appGroupIdentity, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RemoveScheduledTaskResponse>(await DoROARequestAsync("RemoveScheduledTask", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scheduled-tasks/{taskId}", "json", req, runtime));
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
            return TeaModel.ToObject<RemoveSecondRankResponse>(DoROARequest("RemoveSecondRank", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/second-ranks/{name}", "json", req, runtime));
        }

        public async Task<RemoveSecondRankResponse> RemoveSecondRankWithOptionsAsync(string appGroupIdentity, string appId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RemoveSecondRankResponse>(await DoROARequestAsync("RemoveSecondRank", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/second-ranks/{name}", "json", req, runtime));
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
            return TeaModel.ToObject<RemoveUserAnalyzerResponse>(DoROARequest("RemoveUserAnalyzer", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/user-analyzers/" + name, "json", req, runtime));
        }

        public async Task<RemoveUserAnalyzerResponse> RemoveUserAnalyzerWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RemoveUserAnalyzerResponse>(await DoROARequestAsync("RemoveUserAnalyzer", "2017-12-25", "HTTPS", "DELETE", "AK", "/v4/openapi/user-analyzers/" + name, "json", req, runtime));
        }

        public RenewAppGroupResponse RenewAppGroup(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenewAppGroupWithOptions(appGroupIdentity, headers, runtime);
        }

        public async Task<RenewAppGroupResponse> RenewAppGroupAsync(string appGroupIdentity)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenewAppGroupWithOptionsAsync(appGroupIdentity, headers, runtime);
        }

        public RenewAppGroupResponse RenewAppGroupWithOptions(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RenewAppGroupResponse>(DoROARequest("RenewAppGroup", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/actions/renew", "json", req, runtime));
        }

        public async Task<RenewAppGroupResponse> RenewAppGroupWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RenewAppGroupResponse>(await DoROARequestAsync("RenewAppGroup", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/actions/renew", "json", req, runtime));
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
            return TeaModel.ToObject<ReplaceAppGroupCommodityCodeResponse>(DoROARequest("ReplaceAppGroupCommodityCode", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/actions/to-instance-typed", "json", req, runtime));
        }

        public async Task<ReplaceAppGroupCommodityCodeResponse> ReplaceAppGroupCommodityCodeWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ReplaceAppGroupCommodityCodeResponse>(await DoROARequestAsync("ReplaceAppGroupCommodityCode", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/actions/to-instance-typed", "json", req, runtime));
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
            return TeaModel.ToObject<SaveSortScriptFileResponse>(DoROARequest("SaveSortScriptFile", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}/files/src/{fileName}", "json", req, runtime));
        }

        public async Task<SaveSortScriptFileResponse> SaveSortScriptFileWithOptionsAsync(string appGroupIdentity, string scriptName, string appVersionId, string fileName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<SaveSortScriptFileResponse>(await DoROARequestAsync("SaveSortScriptFile", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appVersionId}/sort-scripts/{scriptName}/files/src/{fileName}", "json", req, runtime));
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
            return TeaModel.ToObject<StartSlowQueryAnalyzerResponse>(DoROARequest("StartSlowQueryAnalyzer", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/optimizers/slow-query/actions/run", "json", req, runtime));
        }

        public async Task<StartSlowQueryAnalyzerResponse> StartSlowQueryAnalyzerWithOptionsAsync(string appGroupIdentity, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<StartSlowQueryAnalyzerResponse>(await DoROARequestAsync("StartSlowQueryAnalyzer", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/optimizers/slow-query/actions/run", "json", req, runtime));
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
            return TeaModel.ToObject<TrainModelResponse>(DoROARequest("TrainModel", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}/actions/train", "json", req, runtime));
        }

        public async Task<TrainModelResponse> TrainModelWithOptionsAsync(string appGroupIdentity, string modelName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<TrainModelResponse>(await DoROARequestAsync("TrainModel", "2017-12-25", "HTTPS", "POST", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/algorithm/models/{modelName}/actions/train", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateABTestExperimentResponse>(DoROARequest("UpdateABTestExperiment", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments/{experimentId}", "json", req, runtime));
        }

        public async Task<UpdateABTestExperimentResponse> UpdateABTestExperimentWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<UpdateABTestExperimentResponse>(await DoROARequestAsync("UpdateABTestExperiment", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments/{experimentId}", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateABTestFixedFlowDividersResponse>(DoROARequest("UpdateABTestFixedFlowDividers", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments/{experimentId}/fixed-flow-dividers", "json", req, runtime));
        }

        public async Task<UpdateABTestFixedFlowDividersResponse> UpdateABTestFixedFlowDividersWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<UpdateABTestFixedFlowDividersResponse>(await DoROARequestAsync("UpdateABTestFixedFlowDividers", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}/experiments/{experimentId}/fixed-flow-dividers", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateABTestGroupResponse>(DoROARequest("UpdateABTestGroup", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}", "json", req, runtime));
        }

        public async Task<UpdateABTestGroupResponse> UpdateABTestGroupWithOptionsAsync(string appGroupIdentity, string sceneId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<UpdateABTestGroupResponse>(await DoROARequestAsync("UpdateABTestGroup", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}/groups/{groupId}", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateABTestSceneResponse>(DoROARequest("UpdateABTestScene", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}", "json", req, runtime));
        }

        public async Task<UpdateABTestSceneResponse> UpdateABTestSceneWithOptionsAsync(string appGroupIdentity, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<UpdateABTestSceneResponse>(await DoROARequestAsync("UpdateABTestScene", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/scenes/{sceneId}", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateFetchFieldsResponse>(DoROARequest("UpdateFetchFields", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/fetch-fields", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateFetchFieldsResponse>(await DoROARequestAsync("UpdateFetchFields", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/fetch-fields", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateSummariesResponse>(DoROARequest("UpdateSummaries", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/summaries", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateSummariesResponse>(await DoROARequestAsync("UpdateSummaries", "2017-12-25", "HTTPS", "PUT", "AK", "/v4/openapi/app-groups/" + appGroupIdentity + "/apps/{appId}/summaries", "json", req, runtime));
        }

    }
}
