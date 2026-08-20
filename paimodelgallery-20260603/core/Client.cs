// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.PAIModelGallery20260603.Models;

namespace AlibabaCloud.SDK.PAIModelGallery20260603
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-shenzhen", "paimodelgallery.cn-shenzhen.aliyuncs.com"},
                {"cn-wulanchabu", "paimodelgallery.cn-wulanchabu.aliyuncs.com"},
                {"cn-beijing", "paimodelgallery.cn-beijing.aliyuncs.com"},
                {"ap-northeast-2", "paimodelgallery.ap-northeast-2.aliyuncs.com"},
                {"ap-northeast-1", "paimodelgallery.ap-northeast-1.aliyuncs.com"},
                {"cn-shanghai", "paimodelgallery.cn-shanghai.aliyuncs.com"},
                {"cn-guangzhou", "paimodelgallery.cn-guangzhou.aliyuncs.com"},
                {"cn-hongkong", "paimodelgallery.cn-hongkong.aliyuncs.com"},
                {"ap-southeast-1", "paimodelgallery.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "paimodelgallery.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "paimodelgallery.ap-southeast-5.aliyuncs.com"},
                {"cn-hangzhou", "paimodelgallery.cn-hangzhou.aliyuncs.com"},
                {"us-west-1", "paimodelgallery.us-west-1.aliyuncs.com"},
                {"us-east-1", "paimodelgallery.us-east-1.aliyuncs.com"},
                {"eu-central-1", "paimodelgallery.eu-central-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("paimodelgallery", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>获取模型部署方案匹配资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelDeploymentResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelDeploymentResourcesResponse
        /// </returns>
        public GetModelDeploymentResourcesResponse GetModelDeploymentResourcesWithOptions(string ModelId, GetModelDeploymentResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizKey))
            {
                query["BizKey"] = request.BizKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                query["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileId))
            {
                query["ProfileId"] = request.ProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelDeploymentResources",
                Version = "2026-06-03",
                Protocol = "HTTPS",
                Pathname = "/api/v2/modelgallery/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/deployment-resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelDeploymentResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模型部署方案匹配资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelDeploymentResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelDeploymentResourcesResponse
        /// </returns>
        public async Task<GetModelDeploymentResourcesResponse> GetModelDeploymentResourcesWithOptionsAsync(string ModelId, GetModelDeploymentResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizKey))
            {
                query["BizKey"] = request.BizKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                query["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileId))
            {
                query["ProfileId"] = request.ProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelDeploymentResources",
                Version = "2026-06-03",
                Protocol = "HTTPS",
                Pathname = "/api/v2/modelgallery/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/deployment-resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelDeploymentResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模型部署方案匹配资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelDeploymentResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelDeploymentResourcesResponse
        /// </returns>
        public GetModelDeploymentResourcesResponse GetModelDeploymentResources(string ModelId, GetModelDeploymentResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelDeploymentResourcesWithOptions(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模型部署方案匹配资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelDeploymentResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelDeploymentResourcesResponse
        /// </returns>
        public async Task<GetModelDeploymentResourcesResponse> GetModelDeploymentResourcesAsync(string ModelId, GetModelDeploymentResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelDeploymentResourcesWithOptionsAsync(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成模型部署配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelDeploymentSpecRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelDeploymentSpecResponse
        /// </returns>
        public GetModelDeploymentSpecResponse GetModelDeploymentSpecWithOptions(string ModelId, GetModelDeploymentSpecRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizKey))
            {
                query["BizKey"] = request.BizKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                query["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileId))
            {
                query["ProfileId"] = request.ProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSelections))
            {
                query["ResourceSelections"] = request.ResourceSelections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelDeploymentSpec",
                Version = "2026-06-03",
                Protocol = "HTTPS",
                Pathname = "/api/v2/modelgallery/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/deployment-spec",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelDeploymentSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成模型部署配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelDeploymentSpecRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelDeploymentSpecResponse
        /// </returns>
        public async Task<GetModelDeploymentSpecResponse> GetModelDeploymentSpecWithOptionsAsync(string ModelId, GetModelDeploymentSpecRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizKey))
            {
                query["BizKey"] = request.BizKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                query["ModelVersion"] = request.ModelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProfileId))
            {
                query["ProfileId"] = request.ProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceSelections))
            {
                query["ResourceSelections"] = request.ResourceSelections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModelDeploymentSpec",
                Version = "2026-06-03",
                Protocol = "HTTPS",
                Pathname = "/api/v2/modelgallery/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/deployment-spec",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelDeploymentSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成模型部署配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelDeploymentSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelDeploymentSpecResponse
        /// </returns>
        public GetModelDeploymentSpecResponse GetModelDeploymentSpec(string ModelId, GetModelDeploymentSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModelDeploymentSpecWithOptions(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成模型部署配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetModelDeploymentSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelDeploymentSpecResponse
        /// </returns>
        public async Task<GetModelDeploymentSpecResponse> GetModelDeploymentSpecAsync(string ModelId, GetModelDeploymentSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModelDeploymentSpecWithOptionsAsync(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模型部署方案列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelDeploymentProfilesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelDeploymentProfilesResponse
        /// </returns>
        public ListModelDeploymentProfilesResponse ListModelDeploymentProfilesWithOptions(string ModelId, ListModelDeploymentProfilesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizKey))
            {
                query["BizKey"] = request.BizKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                query["ModelVersion"] = request.ModelVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelDeploymentProfiles",
                Version = "2026-06-03",
                Protocol = "HTTPS",
                Pathname = "/api/v2/modelgallery/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/deployment-profiles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelDeploymentProfilesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模型部署方案列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelDeploymentProfilesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelDeploymentProfilesResponse
        /// </returns>
        public async Task<ListModelDeploymentProfilesResponse> ListModelDeploymentProfilesWithOptionsAsync(string ModelId, ListModelDeploymentProfilesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizKey))
            {
                query["BizKey"] = request.BizKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelVersion))
            {
                query["ModelVersion"] = request.ModelVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelDeploymentProfiles",
                Version = "2026-06-03",
                Protocol = "HTTPS",
                Pathname = "/api/v2/modelgallery/models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ModelId) + "/deployment-profiles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelDeploymentProfilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模型部署方案列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelDeploymentProfilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelDeploymentProfilesResponse
        /// </returns>
        public ListModelDeploymentProfilesResponse ListModelDeploymentProfiles(string ModelId, ListModelDeploymentProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelDeploymentProfilesWithOptions(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模型部署方案列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelDeploymentProfilesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelDeploymentProfilesResponse
        /// </returns>
        public async Task<ListModelDeploymentProfilesResponse> ListModelDeploymentProfilesAsync(string ModelId, ListModelDeploymentProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelDeploymentProfilesWithOptionsAsync(ModelId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取ModelGallery模型列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListModelGalleryModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelGalleryModelsResponse
        /// </returns>
        public ListModelGalleryModelsResponse ListModelGalleryModelsWithOptions(ListModelGalleryModelsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModelGalleryModelsShrinkRequest request = new ListModelGalleryModelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Conditions))
            {
                request.ConditionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Conditions, "Conditions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Collections))
            {
                query["Collections"] = request.Collections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Compressible))
            {
                query["Compressible"] = request.Compressible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionsShrink))
            {
                query["Conditions"] = request.ConditionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeepThink))
            {
                query["DeepThink"] = request.DeepThink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Demonstrable))
            {
                query["Demonstrable"] = request.Demonstrable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deployable))
            {
                query["Deployable"] = request.Deployable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Distillable))
            {
                query["Distillable"] = request.Distillable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Evaluable))
            {
                query["Evaluable"] = request.Evaluable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionCall))
            {
                query["FunctionCall"] = request.FunctionCall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelSeries))
            {
                query["ModelSeries"] = request.ModelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["ModelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedCompressionResource))
            {
                query["SupportedCompressionResource"] = request.SupportedCompressionResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedDistillationResource))
            {
                query["SupportedDistillationResource"] = request.SupportedDistillationResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedEvaluationResource))
            {
                query["SupportedEvaluationResource"] = request.SupportedEvaluationResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedInferenceResource))
            {
                query["SupportedInferenceResource"] = request.SupportedInferenceResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedTrainingResource))
            {
                query["SupportedTrainingResource"] = request.SupportedTrainingResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                query["Task"] = request.Task;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trainable))
            {
                query["Trainable"] = request.Trainable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelGalleryModels",
                Version = "2026-06-03",
                Protocol = "HTTPS",
                Pathname = "/api/v2/modelgallery/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelGalleryModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取ModelGallery模型列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListModelGalleryModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModelGalleryModelsResponse
        /// </returns>
        public async Task<ListModelGalleryModelsResponse> ListModelGalleryModelsWithOptionsAsync(ListModelGalleryModelsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModelGalleryModelsShrinkRequest request = new ListModelGalleryModelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Conditions))
            {
                request.ConditionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Conditions, "Conditions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Collections))
            {
                query["Collections"] = request.Collections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Compressible))
            {
                query["Compressible"] = request.Compressible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConditionsShrink))
            {
                query["Conditions"] = request.ConditionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeepThink))
            {
                query["DeepThink"] = request.DeepThink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Demonstrable))
            {
                query["Demonstrable"] = request.Demonstrable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deployable))
            {
                query["Deployable"] = request.Deployable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Distillable))
            {
                query["Distillable"] = request.Distillable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Evaluable))
            {
                query["Evaluable"] = request.Evaluable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionCall))
            {
                query["FunctionCall"] = request.FunctionCall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelSeries))
            {
                query["ModelSeries"] = request.ModelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelType))
            {
                query["ModelType"] = request.ModelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedCompressionResource))
            {
                query["SupportedCompressionResource"] = request.SupportedCompressionResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedDistillationResource))
            {
                query["SupportedDistillationResource"] = request.SupportedDistillationResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedEvaluationResource))
            {
                query["SupportedEvaluationResource"] = request.SupportedEvaluationResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedInferenceResource))
            {
                query["SupportedInferenceResource"] = request.SupportedInferenceResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedTrainingResource))
            {
                query["SupportedTrainingResource"] = request.SupportedTrainingResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                query["Task"] = request.Task;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trainable))
            {
                query["Trainable"] = request.Trainable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModelGalleryModels",
                Version = "2026-06-03",
                Protocol = "HTTPS",
                Pathname = "/api/v2/modelgallery/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModelGalleryModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取ModelGallery模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelGalleryModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelGalleryModelsResponse
        /// </returns>
        public ListModelGalleryModelsResponse ListModelGalleryModels(ListModelGalleryModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModelGalleryModelsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取ModelGallery模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModelGalleryModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModelGalleryModelsResponse
        /// </returns>
        public async Task<ListModelGalleryModelsResponse> ListModelGalleryModelsAsync(ListModelGalleryModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModelGalleryModelsWithOptionsAsync(request, headers, runtime);
        }

    }
}
