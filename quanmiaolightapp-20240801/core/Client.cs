// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("quanmiaolightapp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 营销信息抽取服务
         *
         * @param tmpReq RunMarketingInformationExtractRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunMarketingInformationExtractResponse
         */
        public RunMarketingInformationExtractResponse RunMarketingInformationExtractWithOptions(string workspaceId, RunMarketingInformationExtractRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunMarketingInformationExtractShrinkRequest request = new RunMarketingInformationExtractShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMaterials))
            {
                request.SourceMaterialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMaterials, "sourceMaterials", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractType))
            {
                body["extractType"] = request.ExtractType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMaterialsShrink))
            {
                body["sourceMaterials"] = request.SourceMaterialsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMarketingInformationExtract",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runMarketingInformationExtract",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMarketingInformationExtractResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 营销信息抽取服务
         *
         * @param tmpReq RunMarketingInformationExtractRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunMarketingInformationExtractResponse
         */
        public async Task<RunMarketingInformationExtractResponse> RunMarketingInformationExtractWithOptionsAsync(string workspaceId, RunMarketingInformationExtractRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunMarketingInformationExtractShrinkRequest request = new RunMarketingInformationExtractShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMaterials))
            {
                request.SourceMaterialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMaterials, "sourceMaterials", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractType))
            {
                body["extractType"] = request.ExtractType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMaterialsShrink))
            {
                body["sourceMaterials"] = request.SourceMaterialsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMarketingInformationExtract",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runMarketingInformationExtract",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMarketingInformationExtractResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 营销信息抽取服务
         *
         * @param request RunMarketingInformationExtractRequest
         * @return RunMarketingInformationExtractResponse
         */
        public RunMarketingInformationExtractResponse RunMarketingInformationExtract(string workspaceId, RunMarketingInformationExtractRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunMarketingInformationExtractWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 营销信息抽取服务
         *
         * @param request RunMarketingInformationExtractRequest
         * @return RunMarketingInformationExtractResponse
         */
        public async Task<RunMarketingInformationExtractResponse> RunMarketingInformationExtractAsync(string workspaceId, RunMarketingInformationExtractRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunMarketingInformationExtractWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 营销文案写作服务
         *
         * @param request RunMarketingInformationWritingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunMarketingInformationWritingResponse
         */
        public RunMarketingInformationWritingResponse RunMarketingInformationWritingWithOptions(string workspaceId, RunMarketingInformationWritingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMaterial))
            {
                body["sourceMaterial"] = request.SourceMaterial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingType))
            {
                body["writingType"] = request.WritingType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMarketingInformationWriting",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runMarketingInformationWriting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMarketingInformationWritingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 营销文案写作服务
         *
         * @param request RunMarketingInformationWritingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunMarketingInformationWritingResponse
         */
        public async Task<RunMarketingInformationWritingResponse> RunMarketingInformationWritingWithOptionsAsync(string workspaceId, RunMarketingInformationWritingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomPrompt))
            {
                body["customPrompt"] = request.CustomPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMaterial))
            {
                body["sourceMaterial"] = request.SourceMaterial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingType))
            {
                body["writingType"] = request.WritingType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunMarketingInformationWriting",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runMarketingInformationWriting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunMarketingInformationWritingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 营销文案写作服务
         *
         * @param request RunMarketingInformationWritingRequest
         * @return RunMarketingInformationWritingResponse
         */
        public RunMarketingInformationWritingResponse RunMarketingInformationWriting(string workspaceId, RunMarketingInformationWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunMarketingInformationWritingWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 营销文案写作服务
         *
         * @param request RunMarketingInformationWritingRequest
         * @return RunMarketingInformationWritingResponse
         */
        public async Task<RunMarketingInformationWritingResponse> RunMarketingInformationWritingAsync(string workspaceId, RunMarketingInformationWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunMarketingInformationWritingWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 剧本续写
         *
         * @param request RunScriptContinueRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunScriptContinueResponse
         */
        public RunScriptContinueResponse RunScriptContinueWithOptions(string workspaceId, RunScriptContinueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptSummary))
            {
                body["scriptSummary"] = request.ScriptSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptTypeKeyword))
            {
                body["scriptTypeKeyword"] = request.ScriptTypeKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvidedContent))
            {
                body["userProvidedContent"] = request.UserProvidedContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScriptContinue",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runScriptContinue",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScriptContinueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 剧本续写
         *
         * @param request RunScriptContinueRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunScriptContinueResponse
         */
        public async Task<RunScriptContinueResponse> RunScriptContinueWithOptionsAsync(string workspaceId, RunScriptContinueRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptSummary))
            {
                body["scriptSummary"] = request.ScriptSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptTypeKeyword))
            {
                body["scriptTypeKeyword"] = request.ScriptTypeKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProvidedContent))
            {
                body["userProvidedContent"] = request.UserProvidedContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScriptContinue",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runScriptContinue",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScriptContinueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 剧本续写
         *
         * @param request RunScriptContinueRequest
         * @return RunScriptContinueResponse
         */
        public RunScriptContinueResponse RunScriptContinue(string workspaceId, RunScriptContinueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunScriptContinueWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 剧本续写
         *
         * @param request RunScriptContinueRequest
         * @return RunScriptContinueResponse
         */
        public async Task<RunScriptContinueResponse> RunScriptContinueAsync(string workspaceId, RunScriptContinueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunScriptContinueWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 剧本策划
         *
         * @param request RunScriptPlanningRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunScriptPlanningResponse
         */
        public RunScriptPlanningResponse RunScriptPlanningWithOptions(string workspaceId, RunScriptPlanningRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalNote))
            {
                body["additionalNote"] = request.AdditionalNote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueInScene))
            {
                body["dialogueInScene"] = request.DialogueInScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlotConflict))
            {
                body["plotConflict"] = request.PlotConflict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptName))
            {
                body["scriptName"] = request.ScriptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptShotCount))
            {
                body["scriptShotCount"] = request.ScriptShotCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptSummary))
            {
                body["scriptSummary"] = request.ScriptSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptTypeKeyword))
            {
                body["scriptTypeKeyword"] = request.ScriptTypeKeyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScriptPlanning",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runScriptPlanning",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScriptPlanningResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 剧本策划
         *
         * @param request RunScriptPlanningRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunScriptPlanningResponse
         */
        public async Task<RunScriptPlanningResponse> RunScriptPlanningWithOptionsAsync(string workspaceId, RunScriptPlanningRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalNote))
            {
                body["additionalNote"] = request.AdditionalNote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogueInScene))
            {
                body["dialogueInScene"] = request.DialogueInScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlotConflict))
            {
                body["plotConflict"] = request.PlotConflict;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptName))
            {
                body["scriptName"] = request.ScriptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptShotCount))
            {
                body["scriptShotCount"] = request.ScriptShotCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptSummary))
            {
                body["scriptSummary"] = request.ScriptSummary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptTypeKeyword))
            {
                body["scriptTypeKeyword"] = request.ScriptTypeKeyword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunScriptPlanning",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runScriptPlanning",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunScriptPlanningResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 剧本策划
         *
         * @param request RunScriptPlanningRequest
         * @return RunScriptPlanningResponse
         */
        public RunScriptPlanningResponse RunScriptPlanning(string workspaceId, RunScriptPlanningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunScriptPlanningWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 剧本策划
         *
         * @param request RunScriptPlanningRequest
         * @return RunScriptPlanningResponse
         */
        public async Task<RunScriptPlanningResponse> RunScriptPlanningAsync(string workspaceId, RunScriptPlanningRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunScriptPlanningWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 文体学习和写作推理服务
         *
         * @param tmpReq RunStyleWritingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunStyleWritingResponse
         */
        public RunStyleWritingResponse RunStyleWritingWithOptions(string workspaceId, RunStyleWritingRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunStyleWritingShrinkRequest request = new RunStyleWritingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LearningSamples))
            {
                request.LearningSamplesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LearningSamples, "learningSamples", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceMaterials))
            {
                request.ReferenceMaterialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceMaterials, "referenceMaterials", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LearningSamplesShrink))
            {
                body["learningSamples"] = request.LearningSamplesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceMaterialsShrink))
            {
                body["referenceMaterials"] = request.ReferenceMaterialsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleFeature))
            {
                body["styleFeature"] = request.StyleFeature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingTheme))
            {
                body["writingTheme"] = request.WritingTheme;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunStyleWriting",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runStyleWriting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunStyleWritingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文体学习和写作推理服务
         *
         * @param tmpReq RunStyleWritingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunStyleWritingResponse
         */
        public async Task<RunStyleWritingResponse> RunStyleWritingWithOptionsAsync(string workspaceId, RunStyleWritingRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunStyleWritingShrinkRequest request = new RunStyleWritingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LearningSamples))
            {
                request.LearningSamplesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LearningSamples, "learningSamples", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceMaterials))
            {
                request.ReferenceMaterialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceMaterials, "referenceMaterials", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LearningSamplesShrink))
            {
                body["learningSamples"] = request.LearningSamplesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceMaterialsShrink))
            {
                body["referenceMaterials"] = request.ReferenceMaterialsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StyleFeature))
            {
                body["styleFeature"] = request.StyleFeature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WritingTheme))
            {
                body["writingTheme"] = request.WritingTheme;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunStyleWriting",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runStyleWriting",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunStyleWritingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文体学习和写作推理服务
         *
         * @param request RunStyleWritingRequest
         * @return RunStyleWritingResponse
         */
        public RunStyleWritingResponse RunStyleWriting(string workspaceId, RunStyleWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunStyleWritingWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 文体学习和写作推理服务
         *
         * @param request RunStyleWritingRequest
         * @return RunStyleWritingResponse
         */
        public async Task<RunStyleWritingResponse> RunStyleWritingAsync(string workspaceId, RunStyleWritingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunStyleWritingWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 轻应用-视频理解
         *
         * @param tmpReq RunVideoAnalysisRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunVideoAnalysisResponse
         */
        public RunVideoAnalysisResponse RunVideoAnalysisWithOptions(string workspaceId, RunVideoAnalysisRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunVideoAnalysisShrinkRequest request = new RunVideoAnalysisShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GenerateOptions))
            {
                request.GenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GenerateOptions, "generateOptions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateOptionsShrink))
            {
                body["generateOptions"] = request.GenerateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplate))
            {
                body["modelCustomPromptTemplate"] = request.ModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplateId))
            {
                body["modelCustomPromptTemplateId"] = request.ModelCustomPromptTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalSessionId))
            {
                body["originalSessionId"] = request.OriginalSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModelCustomPromptTemplate))
            {
                body["videoModelCustomPromptTemplate"] = request.VideoModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModelId))
            {
                body["videoModelId"] = request.VideoModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrl))
            {
                body["videoUrl"] = request.VideoUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunVideoAnalysis",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runVideoAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunVideoAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 轻应用-视频理解
         *
         * @param tmpReq RunVideoAnalysisRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunVideoAnalysisResponse
         */
        public async Task<RunVideoAnalysisResponse> RunVideoAnalysisWithOptionsAsync(string workspaceId, RunVideoAnalysisRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunVideoAnalysisShrinkRequest request = new RunVideoAnalysisShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GenerateOptions))
            {
                request.GenerateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GenerateOptions, "generateOptions", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateOptionsShrink))
            {
                body["generateOptions"] = request.GenerateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplate))
            {
                body["modelCustomPromptTemplate"] = request.ModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCustomPromptTemplateId))
            {
                body["modelCustomPromptTemplateId"] = request.ModelCustomPromptTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalSessionId))
            {
                body["originalSessionId"] = request.OriginalSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModelCustomPromptTemplate))
            {
                body["videoModelCustomPromptTemplate"] = request.VideoModelCustomPromptTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoModelId))
            {
                body["videoModelId"] = request.VideoModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrl))
            {
                body["videoUrl"] = request.VideoUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunVideoAnalysis",
                Version = "2024-08-01",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/quanmiao/lightapp/runVideoAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunVideoAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 轻应用-视频理解
         *
         * @param request RunVideoAnalysisRequest
         * @return RunVideoAnalysisResponse
         */
        public RunVideoAnalysisResponse RunVideoAnalysis(string workspaceId, RunVideoAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunVideoAnalysisWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 轻应用-视频理解
         *
         * @param request RunVideoAnalysisRequest
         * @return RunVideoAnalysisResponse
         */
        public async Task<RunVideoAnalysisResponse> RunVideoAnalysisAsync(string workspaceId, RunVideoAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunVideoAnalysisWithOptionsAsync(workspaceId, request, headers, runtime);
        }

    }
}
