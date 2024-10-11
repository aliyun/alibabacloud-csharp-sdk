// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Airec20201126.Models;

namespace AlibabaCloud.SDK.Airec20201126
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("airec", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Uses a dataset of a specified version of a specified instance to provide online services.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachDatasetResponse
        /// </returns>
        public AttachDatasetResponse AttachDatasetWithOptions(string instanceId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachDataset",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId) + "/actions/current",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachDatasetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uses a dataset of a specified version of a specified instance to provide online services.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachDatasetResponse
        /// </returns>
        public async Task<AttachDatasetResponse> AttachDatasetWithOptionsAsync(string instanceId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachDataset",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId) + "/actions/current",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uses a dataset of a specified version of a specified instance to provide online services.</para>
        /// </summary>
        /// 
        /// <returns>
        /// AttachDatasetResponse
        /// </returns>
        public AttachDatasetResponse AttachDataset(string instanceId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AttachDatasetWithOptions(instanceId, versionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uses a dataset of a specified version of a specified instance to provide online services.</para>
        /// </summary>
        /// 
        /// <returns>
        /// AttachDatasetResponse
        /// </returns>
        public async Task<AttachDatasetResponse> AttachDatasetAsync(string instanceId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AttachDatasetWithOptionsAsync(instanceId, versionId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachIndexVersionResponse
        /// </returns>
        public AttachIndexVersionResponse AttachIndexVersionWithOptions(string instanceId, string algorithmId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachIndexVersion",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/index-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId) + "/actions/attach",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachIndexVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachIndexVersionResponse
        /// </returns>
        public async Task<AttachIndexVersionResponse> AttachIndexVersionWithOptionsAsync(string instanceId, string algorithmId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachIndexVersion",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/index-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId) + "/actions/attach",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachIndexVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// AttachIndexVersionResponse
        /// </returns>
        public AttachIndexVersionResponse AttachIndexVersion(string instanceId, string algorithmId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AttachIndexVersionWithOptions(instanceId, algorithmId, versionId, headers, runtime);
        }

        /// <returns>
        /// AttachIndexVersionResponse
        /// </returns>
        public async Task<AttachIndexVersionResponse> AttachIndexVersionAsync(string instanceId, string algorithmId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AttachIndexVersionWithOptionsAsync(instanceId, algorithmId, versionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the network connectivity of a ranking model.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckRankingModelReachableResponse
        /// </returns>
        public CheckRankingModelReachableResponse CheckRankingModelReachableWithOptions(string instanceId, string rankingModelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckRankingModelReachable",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rankingModelId) + "/actions/check-connectivity",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckRankingModelReachableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the network connectivity of a ranking model.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckRankingModelReachableResponse
        /// </returns>
        public async Task<CheckRankingModelReachableResponse> CheckRankingModelReachableWithOptionsAsync(string instanceId, string rankingModelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckRankingModelReachable",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rankingModelId) + "/actions/check-connectivity",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckRankingModelReachableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the network connectivity of a ranking model.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CheckRankingModelReachableResponse
        /// </returns>
        public CheckRankingModelReachableResponse CheckRankingModelReachable(string instanceId, string rankingModelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckRankingModelReachableWithOptions(instanceId, rankingModelId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the network connectivity of a ranking model.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CheckRankingModelReachableResponse
        /// </returns>
        public async Task<CheckRankingModelReachableResponse> CheckRankingModelReachableAsync(string instanceId, string rankingModelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckRankingModelReachableWithOptionsAsync(instanceId, rankingModelId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clones an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneExperimentResponse
        /// </returns>
        public CloneExperimentResponse CloneExperimentWithOptions(string instanceId, string sceneId, string experimentId, CloneExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CloneExperiment",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId) + "/actions/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clones an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneExperimentResponse
        /// </returns>
        public async Task<CloneExperimentResponse> CloneExperimentWithOptionsAsync(string instanceId, string sceneId, string experimentId, CloneExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CloneExperiment",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId) + "/actions/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clones an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneExperimentResponse
        /// </returns>
        public CloneExperimentResponse CloneExperiment(string instanceId, string sceneId, string experimentId, CloneExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneExperimentWithOptions(instanceId, sceneId, experimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clones an experiment.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneExperimentResponse
        /// </returns>
        public async Task<CloneExperimentResponse> CloneExperimentAsync(string instanceId, string sceneId, string experimentId, CloneExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneExperimentWithOptionsAsync(instanceId, sceneId, experimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clones a sample.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneSampleResponse
        /// </returns>
        public CloneSampleResponse CloneSampleWithOptions(string instanceId, string sampleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneSample",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId) + "/actions/clone",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneSampleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clones a sample.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneSampleResponse
        /// </returns>
        public async Task<CloneSampleResponse> CloneSampleWithOptionsAsync(string instanceId, string sampleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneSample",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId) + "/actions/clone",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneSampleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clones a sample.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CloneSampleResponse
        /// </returns>
        public CloneSampleResponse CloneSample(string instanceId, string sampleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneSampleWithOptions(instanceId, sampleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clones a sample.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CloneSampleResponse
        /// </returns>
        public async Task<CloneSampleResponse> CloneSampleAsync(string instanceId, string sampleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneSampleWithOptionsAsync(instanceId, sampleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于获取指定冷启动实例的排序结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ColdStartRankRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ColdStartRankResponse
        /// </returns>
        public ColdStartRankResponse ColdStartRankWithOptions(string instanceId, ColdStartRankRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Features))
            {
                query["features"] = request.Features;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                query["imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                query["items"] = request.Items;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ColdStartRank",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/cold-start/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/rank",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ColdStartRankResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于获取指定冷启动实例的排序结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ColdStartRankRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ColdStartRankResponse
        /// </returns>
        public async Task<ColdStartRankResponse> ColdStartRankWithOptionsAsync(string instanceId, ColdStartRankRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Features))
            {
                query["features"] = request.Features;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                query["imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                query["items"] = request.Items;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ColdStartRank",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/cold-start/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/rank",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ColdStartRankResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于获取指定冷启动实例的排序结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ColdStartRankRequest
        /// </param>
        /// 
        /// <returns>
        /// ColdStartRankResponse
        /// </returns>
        public ColdStartRankResponse ColdStartRank(string instanceId, ColdStartRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ColdStartRankWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于获取指定冷启动实例的排序结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ColdStartRankRequest
        /// </param>
        /// 
        /// <returns>
        /// ColdStartRankResponse
        /// </returns>
        public async Task<ColdStartRankResponse> ColdStartRankAsync(string instanceId, ColdStartRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ColdStartRankWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomAnalysisTaskResponse
        /// </returns>
        public CreateCustomAnalysisTaskResponse CreateCustomAnalysisTaskWithOptions(string instanceId, CreateCustomAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateCustomAnalysisTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/custom-analysis-tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomAnalysisTaskResponse
        /// </returns>
        public async Task<CreateCustomAnalysisTaskResponse> CreateCustomAnalysisTaskWithOptionsAsync(string instanceId, CreateCustomAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateCustomAnalysisTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/custom-analysis-tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomAnalysisTaskResponse
        /// </returns>
        public CreateCustomAnalysisTaskResponse CreateCustomAnalysisTask(string instanceId, CreateCustomAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCustomAnalysisTaskWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomAnalysisTaskResponse
        /// </returns>
        public async Task<CreateCustomAnalysisTaskResponse> CreateCustomAnalysisTaskAsync(string instanceId, CreateCustomAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCustomAnalysisTaskWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义样本</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomSampleResponse
        /// </returns>
        public CreateCustomSampleResponse CreateCustomSampleWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomSample",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomSampleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义样本</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomSampleResponse
        /// </returns>
        public async Task<CreateCustomSampleResponse> CreateCustomSampleWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomSample",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomSampleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义样本</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateCustomSampleResponse
        /// </returns>
        public CreateCustomSampleResponse CreateCustomSample(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCustomSampleWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义样本</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateCustomSampleResponse
        /// </returns>
        public async Task<CreateCustomSampleResponse> CreateCustomSampleAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCustomSampleWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据诊断任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataDiagnoseTaskResponse
        /// </returns>
        public CreateDataDiagnoseTaskResponse CreateDataDiagnoseTaskWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataDiagnoseTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-diagnose-task",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataDiagnoseTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据诊断任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataDiagnoseTaskResponse
        /// </returns>
        public async Task<CreateDataDiagnoseTaskResponse> CreateDataDiagnoseTaskWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataDiagnoseTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-diagnose-task",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataDiagnoseTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据诊断任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateDataDiagnoseTaskResponse
        /// </returns>
        public CreateDataDiagnoseTaskResponse CreateDataDiagnoseTask(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDataDiagnoseTaskWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据诊断任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateDataDiagnoseTaskResponse
        /// </returns>
        public async Task<CreateDataDiagnoseTaskResponse> CreateDataDiagnoseTaskAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDataDiagnoseTaskWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data source.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExtraDataSourceResponse
        /// </returns>
        public CreateExtraDataSourceResponse CreateExtraDataSourceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExtraDataSource",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/extra-data-sources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExtraDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data source.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExtraDataSourceResponse
        /// </returns>
        public async Task<CreateExtraDataSourceResponse> CreateExtraDataSourceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExtraDataSource",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/extra-data-sources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExtraDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data source.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateExtraDataSourceResponse
        /// </returns>
        public CreateExtraDataSourceResponse CreateExtraDataSource(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExtraDataSourceWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data source.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateExtraDataSourceResponse
        /// </returns>
        public async Task<CreateExtraDataSourceResponse> CreateExtraDataSourceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExtraDataSourceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The time when the filtering table was created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFilteringAlgorithmRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFilteringAlgorithmResponse
        /// </returns>
        public CreateFilteringAlgorithmResponse CreateFilteringAlgorithmWithOptions(string instanceId, CreateFilteringAlgorithmRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateFilteringAlgorithm",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFilteringAlgorithmResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The time when the filtering table was created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFilteringAlgorithmRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFilteringAlgorithmResponse
        /// </returns>
        public async Task<CreateFilteringAlgorithmResponse> CreateFilteringAlgorithmWithOptionsAsync(string instanceId, CreateFilteringAlgorithmRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateFilteringAlgorithm",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFilteringAlgorithmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The time when the filtering table was created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFilteringAlgorithmRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFilteringAlgorithmResponse
        /// </returns>
        public CreateFilteringAlgorithmResponse CreateFilteringAlgorithm(string instanceId, CreateFilteringAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFilteringAlgorithmWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The time when the filtering table was created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFilteringAlgorithmRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFilteringAlgorithmResponse
        /// </returns>
        public async Task<CreateFilteringAlgorithmResponse> CreateFilteringAlgorithmAsync(string instanceId, CreateFilteringAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFilteringAlgorithmWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a throttling task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlowControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowControlTaskResponse
        /// </returns>
        public CreateFlowControlTaskResponse CreateFlowControlTaskWithOptions(string instanceId, CreateFlowControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a throttling task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlowControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowControlTaskResponse
        /// </returns>
        public async Task<CreateFlowControlTaskResponse> CreateFlowControlTaskWithOptionsAsync(string instanceId, CreateFlowControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a throttling task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlowControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowControlTaskResponse
        /// </returns>
        public CreateFlowControlTaskResponse CreateFlowControlTask(string instanceId, CreateFlowControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFlowControlTaskWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a throttling task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlowControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowControlTaskResponse
        /// </returns>
        public async Task<CreateFlowControlTaskResponse> CreateFlowControlTaskAsync(string instanceId, CreateFlowControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFlowControlTaskWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Artificial Intelligence Recommendation (AIRec) instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstanceWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Artificial Intelligence Recommendation (AIRec) instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Artificial Intelligence Recommendation (AIRec) instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstance()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Artificial Intelligence Recommendation (AIRec) instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceWithOptionsAsync(headers, runtime);
        }

        /// <param name="request">
        /// CreateRankingModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRankingModelResponse
        /// </returns>
        public CreateRankingModelResponse CreateRankingModelWithOptions(string instanceId, CreateRankingModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateRankingModel",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-models",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRankingModelResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateRankingModelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRankingModelResponse
        /// </returns>
        public async Task<CreateRankingModelResponse> CreateRankingModelWithOptionsAsync(string instanceId, CreateRankingModelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateRankingModel",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-models",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRankingModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateRankingModelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRankingModelResponse
        /// </returns>
        public CreateRankingModelResponse CreateRankingModel(string instanceId, CreateRankingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRankingModelWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// CreateRankingModelRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRankingModelResponse
        /// </returns>
        public async Task<CreateRankingModelResponse> CreateRankingModelAsync(string instanceId, CreateRankingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRankingModelWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建排序模型模板配置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRankingModelTemplateResponse
        /// </returns>
        public CreateRankingModelTemplateResponse CreateRankingModelTemplateWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRankingModelTemplate",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRankingModelTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建排序模型模板配置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRankingModelTemplateResponse
        /// </returns>
        public async Task<CreateRankingModelTemplateResponse> CreateRankingModelTemplateWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRankingModelTemplate",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRankingModelTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建排序模型模板配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateRankingModelTemplateResponse
        /// </returns>
        public CreateRankingModelTemplateResponse CreateRankingModelTemplate(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRankingModelTemplateWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建排序模型模板配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateRankingModelTemplateResponse
        /// </returns>
        public async Task<CreateRankingModelTemplateResponse> CreateRankingModelTemplateAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRankingModelTemplateWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建排序服务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRankingSystemResponse
        /// </returns>
        public CreateRankingSystemResponse CreateRankingSystemWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRankingSystemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建排序服务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRankingSystemResponse
        /// </returns>
        public async Task<CreateRankingSystemResponse> CreateRankingSystemWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRankingSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建排序服务</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateRankingSystemResponse
        /// </returns>
        public CreateRankingSystemResponse CreateRankingSystem(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRankingSystemWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建排序服务</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateRankingSystemResponse
        /// </returns>
        public async Task<CreateRankingSystemResponse> CreateRankingSystemAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRankingSystemWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a rule.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public CreateRuleResponse CreateRuleWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRule",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a rule.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public async Task<CreateRuleResponse> CreateRuleWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRule",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a rule.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public CreateRuleResponse CreateRule(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRuleWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a rule.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateRuleResponse
        /// </returns>
        public async Task<CreateRuleResponse> CreateRuleAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRuleWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建样本格式化配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSampleFormatConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSampleFormatConfigResponse
        /// </returns>
        public CreateSampleFormatConfigResponse CreateSampleFormatConfigWithOptions(string instanceId, string sampleId, CreateSampleFormatConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSampleFormatConfig",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId) + "/format-configs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSampleFormatConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建样本格式化配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSampleFormatConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSampleFormatConfigResponse
        /// </returns>
        public async Task<CreateSampleFormatConfigResponse> CreateSampleFormatConfigWithOptionsAsync(string instanceId, string sampleId, CreateSampleFormatConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSampleFormatConfig",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId) + "/format-configs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSampleFormatConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建样本格式化配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSampleFormatConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSampleFormatConfigResponse
        /// </returns>
        public CreateSampleFormatConfigResponse CreateSampleFormatConfig(string instanceId, string sampleId, CreateSampleFormatConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSampleFormatConfigWithOptions(instanceId, sampleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建样本格式化配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSampleFormatConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSampleFormatConfigResponse
        /// </returns>
        public async Task<CreateSampleFormatConfigResponse> CreateSampleFormatConfigAsync(string instanceId, string sampleId, CreateSampleFormatConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSampleFormatConfigWithOptionsAsync(instanceId, sampleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the information that you specified for creating a scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSceneResponse
        /// </returns>
        public CreateSceneResponse CreateSceneWithOptions(string instanceId, CreateSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateScene",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSceneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the information that you specified for creating a scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSceneResponse
        /// </returns>
        public async Task<CreateSceneResponse> CreateSceneWithOptionsAsync(string instanceId, CreateSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateScene",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the information that you specified for creating a scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSceneResponse
        /// </returns>
        public CreateSceneResponse CreateScene(string instanceId, CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSceneWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the information that you specified for creating a scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSceneResponse
        /// </returns>
        public async Task<CreateSceneResponse> CreateSceneAsync(string instanceId, CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSceneWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建友盟授权token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUmengTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUmengTokenResponse
        /// </returns>
        public CreateUmengTokenResponse CreateUmengTokenWithOptions(CreateUmengTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUmengToken",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/umeng/token",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUmengTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建友盟授权token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUmengTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUmengTokenResponse
        /// </returns>
        public async Task<CreateUmengTokenResponse> CreateUmengTokenWithOptionsAsync(CreateUmengTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUmengToken",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/umeng/token",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUmengTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建友盟授权token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUmengTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUmengTokenResponse
        /// </returns>
        public CreateUmengTokenResponse CreateUmengToken(CreateUmengTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateUmengTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建友盟授权token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUmengTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUmengTokenResponse
        /// </returns>
        public async Task<CreateUmengTokenResponse> CreateUmengTokenAsync(CreateUmengTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateUmengTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a ranking model.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DecribeRankingModelResponse
        /// </returns>
        public DecribeRankingModelResponse DecribeRankingModelWithOptions(string instanceId, string rankingModelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DecribeRankingModel",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rankingModelId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecribeRankingModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a ranking model.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DecribeRankingModelResponse
        /// </returns>
        public async Task<DecribeRankingModelResponse> DecribeRankingModelWithOptionsAsync(string instanceId, string rankingModelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DecribeRankingModel",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rankingModelId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecribeRankingModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a ranking model.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DecribeRankingModelResponse
        /// </returns>
        public DecribeRankingModelResponse DecribeRankingModel(string instanceId, string rankingModelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DecribeRankingModelWithOptions(instanceId, rankingModelId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a ranking model.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DecribeRankingModelResponse
        /// </returns>
        public async Task<DecribeRankingModelResponse> DecribeRankingModelAsync(string instanceId, string rankingModelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DecribeRankingModelWithOptionsAsync(instanceId, rankingModelId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset of a specified version for an instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetResponse
        /// </returns>
        public DeleteDataSetResponse DeleteDataSetWithOptions(string instanceId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSet",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset of a specified version for an instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetResponse
        /// </returns>
        public async Task<DeleteDataSetResponse> DeleteDataSetWithOptionsAsync(string instanceId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSet",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset of a specified version for an instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDataSetResponse
        /// </returns>
        public DeleteDataSetResponse DeleteDataSet(string instanceId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDataSetWithOptions(instanceId, versionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset of a specified version for an instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteDataSetResponse
        /// </returns>
        public async Task<DeleteDataSetResponse> DeleteDataSetAsync(string instanceId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDataSetWithOptionsAsync(instanceId, versionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the test.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public DeleteExperimentResponse DeleteExperimentWithOptions(string instanceId, string sceneId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperiment",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the test.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public async Task<DeleteExperimentResponse> DeleteExperimentWithOptionsAsync(string instanceId, string sceneId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperiment",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the test.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public DeleteExperimentResponse DeleteExperiment(string instanceId, string sceneId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperimentWithOptions(instanceId, sceneId, experimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the test.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public async Task<DeleteExperimentResponse> DeleteExperimentAsync(string instanceId, string sceneId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperimentWithOptionsAsync(instanceId, sceneId, experimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除特征、样本等表扩展数据源</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExtraDataSourceResponse
        /// </returns>
        public DeleteExtraDataSourceResponse DeleteExtraDataSourceWithOptions(string instanceId, string type, string dataSourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExtraDataSource",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/extra-data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExtraDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除特征、样本等表扩展数据源</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExtraDataSourceResponse
        /// </returns>
        public async Task<DeleteExtraDataSourceResponse> DeleteExtraDataSourceWithOptionsAsync(string instanceId, string type, string dataSourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExtraDataSource",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/extra-data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExtraDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除特征、样本等表扩展数据源</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteExtraDataSourceResponse
        /// </returns>
        public DeleteExtraDataSourceResponse DeleteExtraDataSource(string instanceId, string type, string dataSourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExtraDataSourceWithOptions(instanceId, type, dataSourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除特征、样本等表扩展数据源</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteExtraDataSourceResponse
        /// </returns>
        public async Task<DeleteExtraDataSourceResponse> DeleteExtraDataSourceAsync(string instanceId, string type, string dataSourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExtraDataSourceWithOptionsAsync(instanceId, type, dataSourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the configurations of a specified filtering table and the information about the related index table.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilteringAlgorithmResponse
        /// </returns>
        public DeleteFilteringAlgorithmResponse DeleteFilteringAlgorithmWithOptions(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFilteringAlgorithm",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFilteringAlgorithmResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the configurations of a specified filtering table and the information about the related index table.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilteringAlgorithmResponse
        /// </returns>
        public async Task<DeleteFilteringAlgorithmResponse> DeleteFilteringAlgorithmWithOptionsAsync(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFilteringAlgorithm",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFilteringAlgorithmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the configurations of a specified filtering table and the information about the related index table.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteFilteringAlgorithmResponse
        /// </returns>
        public DeleteFilteringAlgorithmResponse DeleteFilteringAlgorithm(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFilteringAlgorithmWithOptions(instanceId, algorithmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the configurations of a specified filtering table and the information about the related index table.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteFilteringAlgorithmResponse
        /// </returns>
        public async Task<DeleteFilteringAlgorithmResponse> DeleteFilteringAlgorithmAsync(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFilteringAlgorithmWithOptionsAsync(instanceId, algorithmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a throttling task.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowControlTaskResponse
        /// </returns>
        public DeleteFlowControlTaskResponse DeleteFlowControlTaskWithOptions(string instanceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a throttling task.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowControlTaskResponse
        /// </returns>
        public async Task<DeleteFlowControlTaskResponse> DeleteFlowControlTaskWithOptionsAsync(string instanceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a throttling task.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteFlowControlTaskResponse
        /// </returns>
        public DeleteFlowControlTaskResponse DeleteFlowControlTask(string instanceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFlowControlTaskWithOptions(instanceId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a throttling task.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteFlowControlTaskResponse
        /// </returns>
        public async Task<DeleteFlowControlTaskResponse> DeleteFlowControlTaskAsync(string instanceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFlowControlTaskWithOptionsAsync(instanceId, taskId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRankingModelResponse
        /// </returns>
        public DeleteRankingModelResponse DeleteRankingModelWithOptions(string instanceId, string rankingModelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRankingModel",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rankingModelId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRankingModelResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRankingModelResponse
        /// </returns>
        public async Task<DeleteRankingModelResponse> DeleteRankingModelWithOptionsAsync(string instanceId, string rankingModelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRankingModel",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rankingModelId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRankingModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// DeleteRankingModelResponse
        /// </returns>
        public DeleteRankingModelResponse DeleteRankingModel(string instanceId, string rankingModelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRankingModelWithOptions(instanceId, rankingModelId, headers, runtime);
        }

        /// <returns>
        /// DeleteRankingModelResponse
        /// </returns>
        public async Task<DeleteRankingModelResponse> DeleteRankingModelAsync(string instanceId, string rankingModelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRankingModelWithOptionsAsync(instanceId, rankingModelId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除排序模型模板</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRankingModelTemplateResponse
        /// </returns>
        public DeleteRankingModelTemplateResponse DeleteRankingModelTemplateWithOptions(string instanceId, string templateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRankingModelTemplate",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRankingModelTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除排序模型模板</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRankingModelTemplateResponse
        /// </returns>
        public async Task<DeleteRankingModelTemplateResponse> DeleteRankingModelTemplateWithOptionsAsync(string instanceId, string templateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRankingModelTemplate",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRankingModelTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除排序模型模板</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRankingModelTemplateResponse
        /// </returns>
        public DeleteRankingModelTemplateResponse DeleteRankingModelTemplate(string instanceId, string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRankingModelTemplateWithOptions(instanceId, templateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除排序模型模板</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRankingModelTemplateResponse
        /// </returns>
        public async Task<DeleteRankingModelTemplateResponse> DeleteRankingModelTemplateAsync(string instanceId, string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRankingModelTemplateWithOptionsAsync(instanceId, templateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除排序模型版本</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRankingModelVersionResponse
        /// </returns>
        public DeleteRankingModelVersionResponse DeleteRankingModelVersionWithOptions(string instanceId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRankingModelVersion",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRankingModelVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除排序模型版本</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRankingModelVersionResponse
        /// </returns>
        public async Task<DeleteRankingModelVersionResponse> DeleteRankingModelVersionWithOptionsAsync(string instanceId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRankingModelVersion",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRankingModelVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除排序模型版本</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRankingModelVersionResponse
        /// </returns>
        public DeleteRankingModelVersionResponse DeleteRankingModelVersion(string instanceId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRankingModelVersionWithOptions(instanceId, versionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除排序模型版本</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRankingModelVersionResponse
        /// </returns>
        public async Task<DeleteRankingModelVersionResponse> DeleteRankingModelVersionAsync(string instanceId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRankingModelVersionWithOptionsAsync(instanceId, versionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除某个排序服务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRankingSystemResponse
        /// </returns>
        public DeleteRankingSystemResponse DeleteRankingSystemWithOptions(string instanceId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRankingSystemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除某个排序服务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRankingSystemResponse
        /// </returns>
        public async Task<DeleteRankingSystemResponse> DeleteRankingSystemWithOptionsAsync(string instanceId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRankingSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除某个排序服务</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRankingSystemResponse
        /// </returns>
        public DeleteRankingSystemResponse DeleteRankingSystem(string instanceId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRankingSystemWithOptions(instanceId, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除某个排序服务</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRankingSystemResponse
        /// </returns>
        public async Task<DeleteRankingSystemResponse> DeleteRankingSystemAsync(string instanceId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRankingSystemWithOptionsAsync(instanceId, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除样本</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSampleResponse
        /// </returns>
        public DeleteSampleResponse DeleteSampleWithOptions(string instanceId, string sampleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSample",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSampleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除样本</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSampleResponse
        /// </returns>
        public async Task<DeleteSampleResponse> DeleteSampleWithOptionsAsync(string instanceId, string sampleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSample",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSampleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除样本</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSampleResponse
        /// </returns>
        public DeleteSampleResponse DeleteSample(string instanceId, string sampleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSampleWithOptions(instanceId, sampleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除样本</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSampleResponse
        /// </returns>
        public async Task<DeleteSampleResponse> DeleteSampleAsync(string instanceId, string sampleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSampleWithOptionsAsync(instanceId, sampleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSceneResponse
        /// </returns>
        public DeleteSceneResponse DeleteSceneWithOptions(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScene",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSceneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSceneResponse
        /// </returns>
        public async Task<DeleteSceneResponse> DeleteSceneWithOptionsAsync(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScene",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteSceneResponse
        /// </returns>
        public DeleteSceneResponse DeleteScene(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSceneWithOptions(instanceId, sceneId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <returns>
        /// DeleteSceneResponse
        /// </returns>
        public async Task<DeleteSceneResponse> DeleteSceneAsync(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSceneWithOptionsAsync(instanceId, sceneId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployRankingSystemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployRankingSystemResponse
        /// </returns>
        public DeployRankingSystemResponse DeployRankingSystemWithOptions(string instanceId, string name, DeployRankingSystemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/actions/deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployRankingSystemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployRankingSystemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployRankingSystemResponse
        /// </returns>
        public async Task<DeployRankingSystemResponse> DeployRankingSystemWithOptionsAsync(string instanceId, string name, DeployRankingSystemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/actions/deploy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployRankingSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployRankingSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployRankingSystemResponse
        /// </returns>
        public DeployRankingSystemResponse DeployRankingSystem(string instanceId, string name, DeployRankingSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeployRankingSystemWithOptions(instanceId, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployRankingSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployRankingSystemResponse
        /// </returns>
        public async Task<DeployRankingSystemResponse> DeployRankingSystemAsync(string instanceId, string name, DeployRankingSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeployRankingSystemWithOptionsAsync(instanceId, name, request, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBaseExperimentResponse
        /// </returns>
        public DescribeBaseExperimentResponse DescribeBaseExperimentWithOptions(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBaseExperiment",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/base-experiment",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBaseExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBaseExperimentResponse
        /// </returns>
        public async Task<DescribeBaseExperimentResponse> DescribeBaseExperimentWithOptionsAsync(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBaseExperiment",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/base-experiment",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBaseExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// DescribeBaseExperimentResponse
        /// </returns>
        public DescribeBaseExperimentResponse DescribeBaseExperiment(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeBaseExperimentWithOptions(instanceId, sceneId, headers, runtime);
        }

        /// <returns>
        /// DescribeBaseExperimentResponse
        /// </returns>
        public async Task<DescribeBaseExperimentResponse> DescribeBaseExperimentAsync(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeBaseExperimentWithOptionsAsync(instanceId, sceneId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomAnalysisTaskResponse
        /// </returns>
        public DescribeCustomAnalysisTaskResponse DescribeCustomAnalysisTaskWithOptions(string instanceId, string taskId, DescribeCustomAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCustomAnalysisTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/custom-analysis-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomAnalysisTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomAnalysisTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomAnalysisTaskResponse
        /// </returns>
        public async Task<DescribeCustomAnalysisTaskResponse> DescribeCustomAnalysisTaskWithOptionsAsync(string instanceId, string taskId, DescribeCustomAnalysisTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeCustomAnalysisTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/custom-analysis-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomAnalysisTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomAnalysisTaskResponse
        /// </returns>
        public DescribeCustomAnalysisTaskResponse DescribeCustomAnalysisTask(string instanceId, string taskId, DescribeCustomAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCustomAnalysisTaskWithOptions(instanceId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义分析任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCustomAnalysisTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomAnalysisTaskResponse
        /// </returns>
        public async Task<DescribeCustomAnalysisTaskResponse> DescribeCustomAnalysisTaskAsync(string instanceId, string taskId, DescribeCustomAnalysisTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCustomAnalysisTaskWithOptionsAsync(instanceId, taskId, request, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataSetMessageResponse
        /// </returns>
        public DescribeDataSetMessageResponse DescribeDataSetMessageWithOptions(string instanceId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataSetMessage",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId) + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataSetMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataSetMessageResponse
        /// </returns>
        public async Task<DescribeDataSetMessageResponse> DescribeDataSetMessageWithOptionsAsync(string instanceId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataSetMessage",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId) + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataSetMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// DescribeDataSetMessageResponse
        /// </returns>
        public DescribeDataSetMessageResponse DescribeDataSetMessage(string instanceId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeDataSetMessageWithOptions(instanceId, versionId, headers, runtime);
        }

        /// <returns>
        /// DescribeDataSetMessageResponse
        /// </returns>
        public async Task<DescribeDataSetMessageResponse> DescribeDataSetMessageAsync(string instanceId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeDataSetMessageWithOptionsAsync(instanceId, versionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of default algorithms.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDefaultAlgorithmsResponse
        /// </returns>
        public DescribeDefaultAlgorithmsResponse DescribeDefaultAlgorithmsWithOptions(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefaultAlgorithms",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/default-algorithms",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefaultAlgorithmsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of default algorithms.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDefaultAlgorithmsResponse
        /// </returns>
        public async Task<DescribeDefaultAlgorithmsResponse> DescribeDefaultAlgorithmsWithOptionsAsync(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefaultAlgorithms",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/default-algorithms",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefaultAlgorithmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of default algorithms.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeDefaultAlgorithmsResponse
        /// </returns>
        public DescribeDefaultAlgorithmsResponse DescribeDefaultAlgorithms(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeDefaultAlgorithmsWithOptions(instanceId, sceneId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of default algorithms.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeDefaultAlgorithmsResponse
        /// </returns>
        public async Task<DescribeDefaultAlgorithmsResponse> DescribeDefaultAlgorithmsAsync(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeDefaultAlgorithmsWithOptionsAsync(instanceId, sceneId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an experiment.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExperimentResponse
        /// </returns>
        public DescribeExperimentResponse DescribeExperimentWithOptions(string instanceId, string sceneId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExperiment",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an experiment.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExperimentResponse
        /// </returns>
        public async Task<DescribeExperimentResponse> DescribeExperimentWithOptionsAsync(string instanceId, string sceneId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExperiment",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an experiment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeExperimentResponse
        /// </returns>
        public DescribeExperimentResponse DescribeExperiment(string instanceId, string sceneId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeExperimentWithOptions(instanceId, sceneId, experimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an experiment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeExperimentResponse
        /// </returns>
        public async Task<DescribeExperimentResponse> DescribeExperimentAsync(string instanceId, string sceneId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeExperimentWithOptionsAsync(instanceId, sceneId, experimentId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExperimentEnvResponse
        /// </returns>
        public DescribeExperimentEnvResponse DescribeExperimentEnvWithOptions(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExperimentEnv",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiment-env",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExperimentEnvResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExperimentEnvResponse
        /// </returns>
        public async Task<DescribeExperimentEnvResponse> DescribeExperimentEnvWithOptionsAsync(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExperimentEnv",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiment-env",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExperimentEnvResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// DescribeExperimentEnvResponse
        /// </returns>
        public DescribeExperimentEnvResponse DescribeExperimentEnv(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeExperimentEnvWithOptions(instanceId, sceneId, headers, runtime);
        }

        /// <returns>
        /// DescribeExperimentEnvResponse
        /// </returns>
        public async Task<DescribeExperimentEnvResponse> DescribeExperimentEnvAsync(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeExperimentEnvWithOptionsAsync(instanceId, sceneId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExperimentEnvProgressResponse
        /// </returns>
        public DescribeExperimentEnvProgressResponse DescribeExperimentEnvProgressWithOptions(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExperimentEnvProgress",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiment-progress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExperimentEnvProgressResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExperimentEnvProgressResponse
        /// </returns>
        public async Task<DescribeExperimentEnvProgressResponse> DescribeExperimentEnvProgressWithOptionsAsync(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExperimentEnvProgress",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiment-progress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExperimentEnvProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// DescribeExperimentEnvProgressResponse
        /// </returns>
        public DescribeExperimentEnvProgressResponse DescribeExperimentEnvProgress(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeExperimentEnvProgressWithOptions(instanceId, sceneId, headers, runtime);
        }

        /// <returns>
        /// DescribeExperimentEnvProgressResponse
        /// </returns>
        public async Task<DescribeExperimentEnvProgressResponse> DescribeExperimentEnvProgressAsync(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeExperimentEnvProgressWithOptionsAsync(instanceId, sceneId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The fluctuation threshold for the data entries in the source table.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilteringAlgorithmResponse
        /// </returns>
        public DescribeFilteringAlgorithmResponse DescribeFilteringAlgorithmWithOptions(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFilteringAlgorithm",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFilteringAlgorithmResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The fluctuation threshold for the data entries in the source table.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFilteringAlgorithmResponse
        /// </returns>
        public async Task<DescribeFilteringAlgorithmResponse> DescribeFilteringAlgorithmWithOptionsAsync(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFilteringAlgorithm",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFilteringAlgorithmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The fluctuation threshold for the data entries in the source table.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeFilteringAlgorithmResponse
        /// </returns>
        public DescribeFilteringAlgorithmResponse DescribeFilteringAlgorithm(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeFilteringAlgorithmWithOptions(instanceId, algorithmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The fluctuation threshold for the data entries in the source table.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeFilteringAlgorithmResponse
        /// </returns>
        public async Task<DescribeFilteringAlgorithmResponse> DescribeFilteringAlgorithmAsync(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeFilteringAlgorithmWithOptionsAsync(instanceId, algorithmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an instance based on the instance ID.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public DescribeInstanceResponse DescribeInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an instance based on the instance ID.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an instance based on the instance ID.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public DescribeInstanceResponse DescribeInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInstanceWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about an instance based on the instance ID.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLatestTaskResponse
        /// </returns>
        public DescribeLatestTaskResponse DescribeLatestTaskWithOptions(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLatestTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/tasks/latest",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLatestTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLatestTaskResponse
        /// </returns>
        public async Task<DescribeLatestTaskResponse> DescribeLatestTaskWithOptionsAsync(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLatestTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/tasks/latest",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLatestTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// DescribeLatestTaskResponse
        /// </returns>
        public DescribeLatestTaskResponse DescribeLatestTask(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeLatestTaskWithOptions(instanceId, algorithmId, headers, runtime);
        }

        /// <returns>
        /// DescribeLatestTaskResponse
        /// </returns>
        public async Task<DescribeLatestTaskResponse> DescribeLatestTaskAsync(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeLatestTaskWithOptionsAsync(instanceId, algorithmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quotas of an instance based on a specified instance ID.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQuotaResponse
        /// </returns>
        public DescribeQuotaResponse DescribeQuotaWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQuota",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/quota",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quotas of an instance based on a specified instance ID.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeQuotaResponse
        /// </returns>
        public async Task<DescribeQuotaResponse> DescribeQuotaWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeQuota",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/quota",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quotas of an instance based on a specified instance ID.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeQuotaResponse
        /// </returns>
        public DescribeQuotaResponse DescribeQuota(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeQuotaWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quotas of an instance based on a specified instance ID.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeQuotaResponse
        /// </returns>
        public async Task<DescribeQuotaResponse> DescribeQuotaAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeQuotaWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available Alibaba Cloud regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["acceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/configurations/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available Alibaba Cloud regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["acceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/configurations/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available Alibaba Cloud regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available Alibaba Cloud regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRuleResponse
        /// </returns>
        public DescribeRuleResponse DescribeRuleWithOptions(string instanceId, string ruleId, DescribeRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["ruleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRule",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ruleId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRuleResponse
        /// </returns>
        public async Task<DescribeRuleResponse> DescribeRuleWithOptionsAsync(string instanceId, string ruleId, DescribeRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["ruleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRule",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ruleId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRuleResponse
        /// </returns>
        public DescribeRuleResponse DescribeRule(string instanceId, string ruleId, DescribeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRuleWithOptions(instanceId, ruleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRuleResponse
        /// </returns>
        public async Task<DescribeRuleResponse> DescribeRuleAsync(string instanceId, string ruleId, DescribeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRuleWithOptionsAsync(instanceId, ruleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a specified scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSceneResponse
        /// </returns>
        public DescribeSceneResponse DescribeSceneWithOptions(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScene",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSceneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a specified scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSceneResponse
        /// </returns>
        public async Task<DescribeSceneResponse> DescribeSceneWithOptionsAsync(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScene",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a specified scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <returns>
        /// DescribeSceneResponse
        /// </returns>
        public DescribeSceneResponse DescribeScene(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSceneWithOptions(instanceId, sceneId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a specified scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <returns>
        /// DescribeSceneResponse
        /// </returns>
        public async Task<DescribeSceneResponse> DescribeSceneAsync(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSceneWithOptionsAsync(instanceId, sceneId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSceneBucketResponse
        /// </returns>
        public DescribeSceneBucketResponse DescribeSceneBucketWithOptions(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSceneBucket",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiment-bucket",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSceneBucketResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSceneBucketResponse
        /// </returns>
        public async Task<DescribeSceneBucketResponse> DescribeSceneBucketWithOptionsAsync(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSceneBucket",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiment-bucket",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSceneBucketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// DescribeSceneBucketResponse
        /// </returns>
        public DescribeSceneBucketResponse DescribeSceneBucket(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSceneBucketWithOptions(instanceId, sceneId, headers, runtime);
        }

        /// <returns>
        /// DescribeSceneBucketResponse
        /// </returns>
        public async Task<DescribeSceneBucketResponse> DescribeSceneBucketAsync(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSceneBucketWithOptionsAsync(instanceId, sceneId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The error message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><b>null</b></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSceneThroughputResponse
        /// </returns>
        public DescribeSceneThroughputResponse DescribeSceneThroughputWithOptions(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSceneThroughput",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/throughput",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSceneThroughputResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The error message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><b>null</b></para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSceneThroughputResponse
        /// </returns>
        public async Task<DescribeSceneThroughputResponse> DescribeSceneThroughputWithOptionsAsync(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSceneThroughput",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/throughput",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSceneThroughputResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The error message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><b>null</b></para>
        /// </description>
        /// 
        /// <returns>
        /// DescribeSceneThroughputResponse
        /// </returns>
        public DescribeSceneThroughputResponse DescribeSceneThroughput(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSceneThroughputWithOptions(instanceId, sceneId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The error message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><b>null</b></para>
        /// </description>
        /// 
        /// <returns>
        /// DescribeSceneThroughputResponse
        /// </returns>
        public async Task<DescribeSceneThroughputResponse> DescribeSceneThroughputAsync(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSceneThroughputWithOptionsAsync(instanceId, sceneId, headers, runtime);
        }

        /// <param name="request">
        /// DescribeSyncReportDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSyncReportDetailResponse
        /// </returns>
        public DescribeSyncReportDetailResponse DescribeSyncReportDetailWithOptions(string instanceId, DescribeSyncReportDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LevelType))
            {
                query["levelType"] = request.LevelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
                Action = "DescribeSyncReportDetail",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sync-reports/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSyncReportDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeSyncReportDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSyncReportDetailResponse
        /// </returns>
        public async Task<DescribeSyncReportDetailResponse> DescribeSyncReportDetailWithOptionsAsync(string instanceId, DescribeSyncReportDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LevelType))
            {
                query["levelType"] = request.LevelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
                Action = "DescribeSyncReportDetail",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sync-reports/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSyncReportDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeSyncReportDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSyncReportDetailResponse
        /// </returns>
        public DescribeSyncReportDetailResponse DescribeSyncReportDetail(string instanceId, DescribeSyncReportDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSyncReportDetailWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// DescribeSyncReportDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSyncReportDetailResponse
        /// </returns>
        public async Task<DescribeSyncReportDetailResponse> DescribeSyncReportDetailAsync(string instanceId, DescribeSyncReportDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSyncReportDetailWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// DescribeSyncReportOutliersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSyncReportOutliersResponse
        /// </returns>
        public DescribeSyncReportOutliersResponse DescribeSyncReportOutliersWithOptions(string instanceId, DescribeSyncReportOutliersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LevelType))
            {
                query["levelType"] = request.LevelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
                Action = "DescribeSyncReportOutliers",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sync-reports/outliers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSyncReportOutliersResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeSyncReportOutliersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSyncReportOutliersResponse
        /// </returns>
        public async Task<DescribeSyncReportOutliersResponse> DescribeSyncReportOutliersWithOptionsAsync(string instanceId, DescribeSyncReportOutliersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LevelType))
            {
                query["levelType"] = request.LevelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
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
                Action = "DescribeSyncReportOutliers",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sync-reports/outliers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSyncReportOutliersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeSyncReportOutliersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSyncReportOutliersResponse
        /// </returns>
        public DescribeSyncReportOutliersResponse DescribeSyncReportOutliers(string instanceId, DescribeSyncReportOutliersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSyncReportOutliersWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// DescribeSyncReportOutliersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSyncReportOutliersResponse
        /// </returns>
        public async Task<DescribeSyncReportOutliersResponse> DescribeSyncReportOutliersAsync(string instanceId, DescribeSyncReportOutliersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSyncReportOutliersWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user metrics related to the conversion rate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserMetricsResponse
        /// </returns>
        public DescribeUserMetricsResponse DescribeUserMetricsWithOptions(string instanceId, DescribeUserMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
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
                Action = "DescribeUserMetrics",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user metrics related to the conversion rate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserMetricsResponse
        /// </returns>
        public async Task<DescribeUserMetricsResponse> DescribeUserMetricsWithOptionsAsync(string instanceId, DescribeUserMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
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
                Action = "DescribeUserMetrics",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user metrics related to the conversion rate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserMetricsResponse
        /// </returns>
        public DescribeUserMetricsResponse DescribeUserMetrics(string instanceId, DescribeUserMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUserMetricsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries user metrics related to the conversion rate.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUserMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserMetricsResponse
        /// </returns>
        public async Task<DescribeUserMetricsResponse> DescribeUserMetricsAsync(string instanceId, DescribeUserMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUserMetricsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The returned results.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DowngradeInstanceResponse
        /// </returns>
        public DowngradeInstanceResponse DowngradeInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DowngradeInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/downgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DowngradeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The returned results.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DowngradeInstanceResponse
        /// </returns>
        public async Task<DowngradeInstanceResponse> DowngradeInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DowngradeInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/downgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DowngradeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The returned results.</para>
        /// </description>
        /// 
        /// <returns>
        /// DowngradeInstanceResponse
        /// </returns>
        public DowngradeInstanceResponse DowngradeInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DowngradeInstanceWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The returned results.</para>
        /// </description>
        /// 
        /// <returns>
        /// DowngradeInstanceResponse
        /// </returns>
        public async Task<DowngradeInstanceResponse> DowngradeInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DowngradeInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableExperimentResponse
        /// </returns>
        public EnableExperimentResponse EnableExperimentWithOptions(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableExperiment",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/actions/enable-experiment",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableExperimentResponse
        /// </returns>
        public async Task<EnableExperimentResponse> EnableExperimentWithOptionsAsync(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableExperiment",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/actions/enable-experiment",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// EnableExperimentResponse
        /// </returns>
        public EnableExperimentResponse EnableExperiment(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableExperimentWithOptions(instanceId, sceneId, headers, runtime);
        }

        /// <returns>
        /// EnableExperimentResponse
        /// </returns>
        public async Task<EnableExperimentResponse> EnableExperimentAsync(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableExperimentWithOptionsAsync(instanceId, sceneId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成样本，只针对复制创建的样本</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateSampleResponse
        /// </returns>
        public GenerateSampleResponse GenerateSampleWithOptions(string instanceId, string sampleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateSample",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId) + "/actions/generate",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateSampleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成样本，只针对复制创建的样本</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateSampleResponse
        /// </returns>
        public async Task<GenerateSampleResponse> GenerateSampleWithOptionsAsync(string instanceId, string sampleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateSample",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId) + "/actions/generate",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateSampleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成样本，只针对复制创建的样本</para>
        /// </summary>
        /// 
        /// <returns>
        /// GenerateSampleResponse
        /// </returns>
        public GenerateSampleResponse GenerateSample(string instanceId, string sampleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateSampleWithOptions(instanceId, sampleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成样本，只针对复制创建的样本</para>
        /// </summary>
        /// 
        /// <returns>
        /// GenerateSampleResponse
        /// </returns>
        public async Task<GenerateSampleResponse> GenerateSampleAsync(string instanceId, string sampleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateSampleWithOptionsAsync(instanceId, sampleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of other data sources.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExtraDataSourceResponse
        /// </returns>
        public GetExtraDataSourceResponse GetExtraDataSourceWithOptions(string instanceId, string type, string dataSourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExtraDataSource",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/extra-data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExtraDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of other data sources.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExtraDataSourceResponse
        /// </returns>
        public async Task<GetExtraDataSourceResponse> GetExtraDataSourceWithOptionsAsync(string instanceId, string type, string dataSourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExtraDataSource",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/extra-data-sources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dataSourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExtraDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of other data sources.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetExtraDataSourceResponse
        /// </returns>
        public GetExtraDataSourceResponse GetExtraDataSource(string instanceId, string type, string dataSourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExtraDataSourceWithOptions(instanceId, type, dataSourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of other data sources.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetExtraDataSourceResponse
        /// </returns>
        public async Task<GetExtraDataSourceResponse> GetExtraDataSourceAsync(string instanceId, string type, string dataSourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExtraDataSourceWithOptionsAsync(instanceId, type, dataSourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a throttling task.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowControlTaskResponse
        /// </returns>
        public GetFlowControlTaskResponse GetFlowControlTaskWithOptions(string instanceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a throttling task.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowControlTaskResponse
        /// </returns>
        public async Task<GetFlowControlTaskResponse> GetFlowControlTaskWithOptionsAsync(string instanceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a throttling task.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFlowControlTaskResponse
        /// </returns>
        public GetFlowControlTaskResponse GetFlowControlTask(string instanceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFlowControlTaskWithOptions(instanceId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a throttling task.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFlowControlTaskResponse
        /// </returns>
        public async Task<GetFlowControlTaskResponse> GetFlowControlTaskAsync(string instanceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFlowControlTaskWithOptionsAsync(instanceId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最新诊断任务状态</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLatestDataDiagnoseTaskStatusResponse
        /// </returns>
        public GetLatestDataDiagnoseTaskStatusResponse GetLatestDataDiagnoseTaskStatusWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLatestDataDiagnoseTaskStatus",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-diagnose-task/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLatestDataDiagnoseTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最新诊断任务状态</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLatestDataDiagnoseTaskStatusResponse
        /// </returns>
        public async Task<GetLatestDataDiagnoseTaskStatusResponse> GetLatestDataDiagnoseTaskStatusWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLatestDataDiagnoseTaskStatus",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-diagnose-task/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLatestDataDiagnoseTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最新诊断任务状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetLatestDataDiagnoseTaskStatusResponse
        /// </returns>
        public GetLatestDataDiagnoseTaskStatusResponse GetLatestDataDiagnoseTaskStatus(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLatestDataDiagnoseTaskStatusWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最新诊断任务状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetLatestDataDiagnoseTaskStatusResponse
        /// </returns>
        public async Task<GetLatestDataDiagnoseTaskStatusResponse> GetLatestDataDiagnoseTaskStatusAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLatestDataDiagnoseTaskStatusWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看排序模型模板配置详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRankingModelTemplateResponse
        /// </returns>
        public GetRankingModelTemplateResponse GetRankingModelTemplateWithOptions(string instanceId, string templateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRankingModelTemplate",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRankingModelTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看排序模型模板配置详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRankingModelTemplateResponse
        /// </returns>
        public async Task<GetRankingModelTemplateResponse> GetRankingModelTemplateWithOptionsAsync(string instanceId, string templateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRankingModelTemplate",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRankingModelTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看排序模型模板配置详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRankingModelTemplateResponse
        /// </returns>
        public GetRankingModelTemplateResponse GetRankingModelTemplate(string instanceId, string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRankingModelTemplateWithOptions(instanceId, templateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看排序模型模板配置详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRankingModelTemplateResponse
        /// </returns>
        public async Task<GetRankingModelTemplateResponse> GetRankingModelTemplateAsync(string instanceId, string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRankingModelTemplateWithOptionsAsync(instanceId, templateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看排序模型版本详情，包括评估结果和训练结果</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRankingModelVersionResponse
        /// </returns>
        public GetRankingModelVersionResponse GetRankingModelVersionWithOptions(string instanceId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRankingModelVersion",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRankingModelVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看排序模型版本详情，包括评估结果和训练结果</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRankingModelVersionResponse
        /// </returns>
        public async Task<GetRankingModelVersionResponse> GetRankingModelVersionWithOptionsAsync(string instanceId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRankingModelVersion",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRankingModelVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看排序模型版本详情，包括评估结果和训练结果</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRankingModelVersionResponse
        /// </returns>
        public GetRankingModelVersionResponse GetRankingModelVersion(string instanceId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRankingModelVersionWithOptions(instanceId, versionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看排序模型版本详情，包括评估结果和训练结果</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRankingModelVersionResponse
        /// </returns>
        public async Task<GetRankingModelVersionResponse> GetRankingModelVersionAsync(string instanceId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRankingModelVersionWithOptionsAsync(instanceId, versionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个排序服务详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRankingSystemResponse
        /// </returns>
        public GetRankingSystemResponse GetRankingSystemWithOptions(string instanceId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRankingSystemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个排序服务详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRankingSystemResponse
        /// </returns>
        public async Task<GetRankingSystemResponse> GetRankingSystemWithOptionsAsync(string instanceId, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRankingSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个排序服务详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRankingSystemResponse
        /// </returns>
        public GetRankingSystemResponse GetRankingSystem(string instanceId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRankingSystemWithOptions(instanceId, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个排序服务详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRankingSystemResponse
        /// </returns>
        public async Task<GetRankingSystemResponse> GetRankingSystemAsync(string instanceId, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRankingSystemWithOptionsAsync(instanceId, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某个服务操作记录</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRankingSystemHistoryResponse
        /// </returns>
        public GetRankingSystemHistoryResponse GetRankingSystemHistoryWithOptions(string instanceId, string name, string operateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRankingSystemHistory",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/histories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRankingSystemHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某个服务操作记录</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRankingSystemHistoryResponse
        /// </returns>
        public async Task<GetRankingSystemHistoryResponse> GetRankingSystemHistoryWithOptionsAsync(string instanceId, string name, string operateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRankingSystemHistory",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/histories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRankingSystemHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某个服务操作记录</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRankingSystemHistoryResponse
        /// </returns>
        public GetRankingSystemHistoryResponse GetRankingSystemHistory(string instanceId, string name, string operateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRankingSystemHistoryWithOptions(instanceId, name, operateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某个服务操作记录</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRankingSystemHistoryResponse
        /// </returns>
        public async Task<GetRankingSystemHistoryResponse> GetRankingSystemHistoryAsync(string instanceId, string name, string operateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRankingSystemHistoryWithOptionsAsync(instanceId, name, operateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取样本详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSampleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSampleResponse
        /// </returns>
        public GetSampleResponse GetSampleWithOptions(string instanceId, string sampleId, GetSampleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithExtendParmas))
            {
                query["withExtendParmas"] = request.WithExtendParmas;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSample",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSampleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取样本详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSampleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSampleResponse
        /// </returns>
        public async Task<GetSampleResponse> GetSampleWithOptionsAsync(string instanceId, string sampleId, GetSampleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithExtendParmas))
            {
                query["withExtendParmas"] = request.WithExtendParmas;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSample",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSampleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取样本详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSampleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSampleResponse
        /// </returns>
        public GetSampleResponse GetSample(string instanceId, string sampleId, GetSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSampleWithOptions(instanceId, sampleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取样本详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSampleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSampleResponse
        /// </returns>
        public async Task<GetSampleResponse> GetSampleAsync(string instanceId, string sampleId, GetSampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSampleWithOptionsAsync(instanceId, sampleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>初始化计算资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitComputingResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitComputingResourceResponse
        /// </returns>
        public InitComputingResourceResponse InitComputingResourceWithOptions(string instanceId, InitComputingResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["key"] = request.Key;
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
                Action = "InitComputingResource",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/computing-resources/actions/init",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitComputingResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>初始化计算资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitComputingResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitComputingResourceResponse
        /// </returns>
        public async Task<InitComputingResourceResponse> InitComputingResourceWithOptionsAsync(string instanceId, InitComputingResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["key"] = request.Key;
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
                Action = "InitComputingResource",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/computing-resources/actions/init",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitComputingResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>初始化计算资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitComputingResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// InitComputingResourceResponse
        /// </returns>
        public InitComputingResourceResponse InitComputingResource(string instanceId, InitComputingResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InitComputingResourceWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>初始化计算资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitComputingResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// InitComputingResourceResponse
        /// </returns>
        public async Task<InitComputingResourceResponse> InitComputingResourceAsync(string instanceId, InitComputingResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InitComputingResourceWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListDashboardDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardDetailsResponse
        /// </returns>
        public ListDashboardDetailsResponse ListDashboardDetailsWithOptions(string instanceId, ListDashboardDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentIds))
            {
                query["experimentIds"] = request.ExperimentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchTypes))
            {
                query["matchTypes"] = request.MatchTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["metricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIds))
            {
                query["sceneIds"] = request.SceneIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceIds))
            {
                query["traceIds"] = request.TraceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDashboardDetails",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDashboardDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDashboardDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardDetailsResponse
        /// </returns>
        public async Task<ListDashboardDetailsResponse> ListDashboardDetailsWithOptionsAsync(string instanceId, ListDashboardDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentIds))
            {
                query["experimentIds"] = request.ExperimentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchTypes))
            {
                query["matchTypes"] = request.MatchTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["metricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIds))
            {
                query["sceneIds"] = request.SceneIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceIds))
            {
                query["traceIds"] = request.TraceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDashboardDetails",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDashboardDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDashboardDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardDetailsResponse
        /// </returns>
        public ListDashboardDetailsResponse ListDashboardDetails(string instanceId, ListDashboardDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDashboardDetailsWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListDashboardDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardDetailsResponse
        /// </returns>
        public async Task<ListDashboardDetailsResponse> ListDashboardDetailsAsync(string instanceId, ListDashboardDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDashboardDetailsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListDashboardDetailsFlowsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardDetailsFlowsResponse
        /// </returns>
        public ListDashboardDetailsFlowsResponse ListDashboardDetailsFlowsWithOptions(string instanceId, ListDashboardDetailsFlowsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentIds))
            {
                query["experimentIds"] = request.ExperimentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["metricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIds))
            {
                query["sceneIds"] = request.SceneIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceIds))
            {
                query["traceIds"] = request.TraceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDashboardDetailsFlows",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/details/flows",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDashboardDetailsFlowsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDashboardDetailsFlowsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardDetailsFlowsResponse
        /// </returns>
        public async Task<ListDashboardDetailsFlowsResponse> ListDashboardDetailsFlowsWithOptionsAsync(string instanceId, ListDashboardDetailsFlowsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentIds))
            {
                query["experimentIds"] = request.ExperimentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["metricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIds))
            {
                query["sceneIds"] = request.SceneIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceIds))
            {
                query["traceIds"] = request.TraceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDashboardDetailsFlows",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/details/flows",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDashboardDetailsFlowsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListDashboardDetailsFlowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardDetailsFlowsResponse
        /// </returns>
        public ListDashboardDetailsFlowsResponse ListDashboardDetailsFlows(string instanceId, ListDashboardDetailsFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDashboardDetailsFlowsWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListDashboardDetailsFlowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardDetailsFlowsResponse
        /// </returns>
        public async Task<ListDashboardDetailsFlowsResponse> ListDashboardDetailsFlowsAsync(string instanceId, ListDashboardDetailsFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDashboardDetailsFlowsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The end time. The value is a timestamp in seconds.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDashboardMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardMetricsResponse
        /// </returns>
        public ListDashboardMetricsResponse ListDashboardMetricsWithOptions(string instanceId, ListDashboardMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricQuery))
            {
                query["metricQuery"] = request.MetricQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["metricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricView))
            {
                query["metricView"] = request.MetricView;
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
                Action = "ListDashboardMetrics",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDashboardMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The end time. The value is a timestamp in seconds.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDashboardMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardMetricsResponse
        /// </returns>
        public async Task<ListDashboardMetricsResponse> ListDashboardMetricsWithOptionsAsync(string instanceId, ListDashboardMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricQuery))
            {
                query["metricQuery"] = request.MetricQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["metricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricView))
            {
                query["metricView"] = request.MetricView;
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
                Action = "ListDashboardMetrics",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/metrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDashboardMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The end time. The value is a timestamp in seconds.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDashboardMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardMetricsResponse
        /// </returns>
        public ListDashboardMetricsResponse ListDashboardMetrics(string instanceId, ListDashboardMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDashboardMetricsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The end time. The value is a timestamp in seconds.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDashboardMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardMetricsResponse
        /// </returns>
        public async Task<ListDashboardMetricsResponse> ListDashboardMetricsAsync(string instanceId, ListDashboardMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDashboardMetricsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The end time. The value is a timestamp in seconds.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDashboardMetricsFlowsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardMetricsFlowsResponse
        /// </returns>
        public ListDashboardMetricsFlowsResponse ListDashboardMetricsFlowsWithOptions(string instanceId, ListDashboardMetricsFlowsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
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
                Action = "ListDashboardMetricsFlows",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/metrics/flows",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDashboardMetricsFlowsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The end time. The value is a timestamp in seconds.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDashboardMetricsFlowsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardMetricsFlowsResponse
        /// </returns>
        public async Task<ListDashboardMetricsFlowsResponse> ListDashboardMetricsFlowsWithOptionsAsync(string instanceId, ListDashboardMetricsFlowsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
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
                Action = "ListDashboardMetricsFlows",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/metrics/flows",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDashboardMetricsFlowsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The end time. The value is a timestamp in seconds.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDashboardMetricsFlowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardMetricsFlowsResponse
        /// </returns>
        public ListDashboardMetricsFlowsResponse ListDashboardMetricsFlows(string instanceId, ListDashboardMetricsFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDashboardMetricsFlowsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The end time. The value is a timestamp in seconds.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDashboardMetricsFlowsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDashboardMetricsFlowsResponse
        /// </returns>
        public async Task<ListDashboardMetricsFlowsResponse> ListDashboardMetricsFlowsAsync(string instanceId, ListDashboardMetricsFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDashboardMetricsFlowsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据诊断报告 (包括用户手动触发的诊断、每天产出的周期报告、数据启动时诊断的报告)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDiagnoseReportsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataDiagnoseReportsResponse
        /// </returns>
        public ListDataDiagnoseReportsResponse ListDataDiagnoseReportsWithOptions(string instanceId, ListDataDiagnoseReportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCreateTime))
            {
                query["taskCreateTime"] = request.TaskCreateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataDiagnoseReports",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-diagnose-reports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataDiagnoseReportsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据诊断报告 (包括用户手动触发的诊断、每天产出的周期报告、数据启动时诊断的报告)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDiagnoseReportsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataDiagnoseReportsResponse
        /// </returns>
        public async Task<ListDataDiagnoseReportsResponse> ListDataDiagnoseReportsWithOptionsAsync(string instanceId, ListDataDiagnoseReportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCreateTime))
            {
                query["taskCreateTime"] = request.TaskCreateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataDiagnoseReports",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-diagnose-reports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataDiagnoseReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据诊断报告 (包括用户手动触发的诊断、每天产出的周期报告、数据启动时诊断的报告)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDiagnoseReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataDiagnoseReportsResponse
        /// </returns>
        public ListDataDiagnoseReportsResponse ListDataDiagnoseReports(string instanceId, ListDataDiagnoseReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataDiagnoseReportsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据诊断报告 (包括用户手动触发的诊断、每天产出的周期报告、数据启动时诊断的报告)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDiagnoseReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataDiagnoseReportsResponse
        /// </returns>
        public async Task<ListDataDiagnoseReportsResponse> ListDataDiagnoseReportsAsync(string instanceId, ListDataDiagnoseReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataDiagnoseReportsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据诊断项抽样明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDiagnoseSampleDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataDiagnoseSampleDetailsResponse
        /// </returns>
        public ListDataDiagnoseSampleDetailsResponse ListDataDiagnoseSampleDetailsWithOptions(string instanceId, ListDataDiagnoseSampleDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCreateTime))
            {
                query["taskCreateTime"] = request.TaskCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskSource))
            {
                query["taskSource"] = request.TaskSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataDiagnoseSampleDetails",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-diagnose-reports/sample-details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataDiagnoseSampleDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据诊断项抽样明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDiagnoseSampleDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataDiagnoseSampleDetailsResponse
        /// </returns>
        public async Task<ListDataDiagnoseSampleDetailsResponse> ListDataDiagnoseSampleDetailsWithOptionsAsync(string instanceId, ListDataDiagnoseSampleDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCreateTime))
            {
                query["taskCreateTime"] = request.TaskCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskSource))
            {
                query["taskSource"] = request.TaskSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataDiagnoseSampleDetails",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/data-diagnose-reports/sample-details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataDiagnoseSampleDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据诊断项抽样明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDiagnoseSampleDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataDiagnoseSampleDetailsResponse
        /// </returns>
        public ListDataDiagnoseSampleDetailsResponse ListDataDiagnoseSampleDetails(string instanceId, ListDataDiagnoseSampleDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataDiagnoseSampleDetailsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据诊断项抽样明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataDiagnoseSampleDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataDiagnoseSampleDetailsResponse
        /// </returns>
        public async Task<ListDataDiagnoseSampleDetailsResponse> ListDataDiagnoseSampleDetailsAsync(string instanceId, ListDataDiagnoseSampleDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataDiagnoseSampleDetailsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries datasets of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetResponse
        /// </returns>
        public ListDataSetResponse ListDataSetWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSet",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries datasets of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetResponse
        /// </returns>
        public async Task<ListDataSetResponse> ListDataSetWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSet",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries datasets of a specified instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListDataSetResponse
        /// </returns>
        public ListDataSetResponse ListDataSet(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSetWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries datasets of a specified instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListDataSetResponse
        /// </returns>
        public async Task<ListDataSetResponse> ListDataSetAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSetWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceResponse
        /// </returns>
        public ListDataSourceResponse ListDataSourceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSource",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourceResponse
        /// </returns>
        public async Task<ListDataSourceResponse> ListDataSourceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSource",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// ListDataSourceResponse
        /// </returns>
        public ListDataSourceResponse ListDataSource(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSourceWithOptions(instanceId, headers, runtime);
        }

        /// <returns>
        /// ListDataSourceResponse
        /// </returns>
        public async Task<ListDataSourceResponse> ListDataSourceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSourceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentsResponse
        /// </returns>
        public ListExperimentsResponse ListExperimentsWithOptions(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExperiments",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentsResponse
        /// </returns>
        public async Task<ListExperimentsResponse> ListExperimentsWithOptionsAsync(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExperiments",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// ListExperimentsResponse
        /// </returns>
        public ListExperimentsResponse ListExperiments(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExperimentsWithOptions(instanceId, sceneId, headers, runtime);
        }

        /// <returns>
        /// ListExperimentsResponse
        /// </returns>
        public async Task<ListExperimentsResponse> ListExperimentsAsync(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExperimentsWithOptionsAsync(instanceId, sceneId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征、样本等表扩展数据源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExtraDataSourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExtraDataSourcesResponse
        /// </returns>
        public ListExtraDataSourcesResponse ListExtraDataSourcesWithOptions(string instanceId, ListExtraDataSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListExtraDataSources",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/extra-data-sources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExtraDataSourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征、样本等表扩展数据源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExtraDataSourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExtraDataSourcesResponse
        /// </returns>
        public async Task<ListExtraDataSourcesResponse> ListExtraDataSourcesWithOptionsAsync(string instanceId, ListExtraDataSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListExtraDataSources",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/extra-data-sources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExtraDataSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征、样本等表扩展数据源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExtraDataSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExtraDataSourcesResponse
        /// </returns>
        public ListExtraDataSourcesResponse ListExtraDataSources(string instanceId, ListExtraDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExtraDataSourcesWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征、样本等表扩展数据源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExtraDataSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExtraDataSourcesResponse
        /// </returns>
        public async Task<ListExtraDataSourcesResponse> ListExtraDataSourcesAsync(string instanceId, ListExtraDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExtraDataSourcesWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征表列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureTablesResponse
        /// </returns>
        public ListFeatureTablesResponse ListFeatureTablesWithOptions(string instanceId, ListFeatureTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateFrequency))
            {
                query["updateFrequency"] = request.UpdateFrequency;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureTables",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/feature-tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureTablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征表列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureTablesResponse
        /// </returns>
        public async Task<ListFeatureTablesResponse> ListFeatureTablesWithOptionsAsync(string instanceId, ListFeatureTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["dataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateFrequency))
            {
                query["updateFrequency"] = request.UpdateFrequency;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureTables",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/feature-tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征表列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureTablesResponse
        /// </returns>
        public ListFeatureTablesResponse ListFeatureTables(string instanceId, ListFeatureTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureTablesWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征表列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureTablesResponse
        /// </returns>
        public async Task<ListFeatureTablesResponse> ListFeatureTablesAsync(string instanceId, ListFeatureTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureTablesWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListFilteringAlgorithmsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFilteringAlgorithmsResponse
        /// </returns>
        public ListFilteringAlgorithmsResponse ListFilteringAlgorithmsWithOptions(string instanceId, ListFilteringAlgorithmsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmId))
            {
                query["algorithmId"] = request.AlgorithmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
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
                Action = "ListFilteringAlgorithms",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFilteringAlgorithmsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListFilteringAlgorithmsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFilteringAlgorithmsResponse
        /// </returns>
        public async Task<ListFilteringAlgorithmsResponse> ListFilteringAlgorithmsWithOptionsAsync(string instanceId, ListFilteringAlgorithmsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgorithmId))
            {
                query["algorithmId"] = request.AlgorithmId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
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
                Action = "ListFilteringAlgorithms",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFilteringAlgorithmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListFilteringAlgorithmsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFilteringAlgorithmsResponse
        /// </returns>
        public ListFilteringAlgorithmsResponse ListFilteringAlgorithms(string instanceId, ListFilteringAlgorithmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFilteringAlgorithmsWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListFilteringAlgorithmsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFilteringAlgorithmsResponse
        /// </returns>
        public async Task<ListFilteringAlgorithmsResponse> ListFilteringAlgorithmsAsync(string instanceId, ListFilteringAlgorithmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFilteringAlgorithmsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流控任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskResponse
        /// </returns>
        public ListFlowControlTaskResponse ListFlowControlTaskWithOptions(string instanceId, ListFlowControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
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
                Action = "ListFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流控任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskResponse
        /// </returns>
        public async Task<ListFlowControlTaskResponse> ListFlowControlTaskWithOptionsAsync(string instanceId, ListFlowControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
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
                Action = "ListFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流控任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskResponse
        /// </returns>
        public ListFlowControlTaskResponse ListFlowControlTask(string instanceId, ListFlowControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFlowControlTaskWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流控任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskResponse
        /// </returns>
        public async Task<ListFlowControlTaskResponse> ListFlowControlTaskAsync(string instanceId, ListFlowControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFlowControlTaskWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询失效物品 id_type</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskInvalidItemsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskInvalidItemsResponse
        /// </returns>
        public ListFlowControlTaskInvalidItemsResponse ListFlowControlTaskInvalidItemsWithOptions(string instanceId, string taskId, ListFlowControlTaskInvalidItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowControlTaskInvalidItems",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/invalidItems",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowControlTaskInvalidItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询失效物品 id_type</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskInvalidItemsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskInvalidItemsResponse
        /// </returns>
        public async Task<ListFlowControlTaskInvalidItemsResponse> ListFlowControlTaskInvalidItemsWithOptionsAsync(string instanceId, string taskId, ListFlowControlTaskInvalidItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowControlTaskInvalidItems",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/invalidItems",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowControlTaskInvalidItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询失效物品 id_type</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskInvalidItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskInvalidItemsResponse
        /// </returns>
        public ListFlowControlTaskInvalidItemsResponse ListFlowControlTaskInvalidItems(string instanceId, string taskId, ListFlowControlTaskInvalidItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFlowControlTaskInvalidItemsWithOptions(instanceId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询失效物品 id_type</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskInvalidItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskInvalidItemsResponse
        /// </returns>
        public async Task<ListFlowControlTaskInvalidItemsResponse> ListFlowControlTaskInvalidItemsAsync(string instanceId, string taskId, ListFlowControlTaskInvalidItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFlowControlTaskInvalidItemsWithOptionsAsync(instanceId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流量调控曝光排名物品/失效物品查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskItemReportsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskItemReportsResponse
        /// </returns>
        public ListFlowControlTaskItemReportsResponse ListFlowControlTaskItemReportsWithOptions(string instanceId, string taskId, ListFlowControlTaskItemReportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectTimeType))
            {
                query["selectTimeType"] = request.SelectTimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectType))
            {
                query["selectType"] = request.SelectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowControlTaskItemReports",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/itemReports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowControlTaskItemReportsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流量调控曝光排名物品/失效物品查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskItemReportsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskItemReportsResponse
        /// </returns>
        public async Task<ListFlowControlTaskItemReportsResponse> ListFlowControlTaskItemReportsWithOptionsAsync(string instanceId, string taskId, ListFlowControlTaskItemReportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectTimeType))
            {
                query["selectTimeType"] = request.SelectTimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectType))
            {
                query["selectType"] = request.SelectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowControlTaskItemReports",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/itemReports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowControlTaskItemReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流量调控曝光排名物品/失效物品查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskItemReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskItemReportsResponse
        /// </returns>
        public ListFlowControlTaskItemReportsResponse ListFlowControlTaskItemReports(string instanceId, string taskId, ListFlowControlTaskItemReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFlowControlTaskItemReportsWithOptions(instanceId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流量调控曝光排名物品/失效物品查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskItemReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskItemReportsResponse
        /// </returns>
        public async Task<ListFlowControlTaskItemReportsResponse> ListFlowControlTaskItemReportsAsync(string instanceId, string taskId, ListFlowControlTaskItemReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFlowControlTaskItemReportsWithOptionsAsync(instanceId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流量调控预览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskItemsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskItemsResponse
        /// </returns>
        public ListFlowControlTaskItemsResponse ListFlowControlTaskItemsWithOptions(string instanceId, string taskId, ListFlowControlTaskItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListFlowControlTaskItems",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/actions/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowControlTaskItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流量调控预览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskItemsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskItemsResponse
        /// </returns>
        public async Task<ListFlowControlTaskItemsResponse> ListFlowControlTaskItemsWithOptionsAsync(string instanceId, string taskId, ListFlowControlTaskItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListFlowControlTaskItems",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/actions/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowControlTaskItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流量调控预览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskItemsResponse
        /// </returns>
        public ListFlowControlTaskItemsResponse ListFlowControlTaskItems(string instanceId, string taskId, ListFlowControlTaskItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFlowControlTaskItemsWithOptions(instanceId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流量调控预览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskItemsResponse
        /// </returns>
        public async Task<ListFlowControlTaskItemsResponse> ListFlowControlTaskItemsAsync(string instanceId, string taskId, ListFlowControlTaskItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFlowControlTaskItemsWithOptionsAsync(instanceId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries reference data for throttling.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskReferenceResponse
        /// </returns>
        public ListFlowControlTaskReferenceResponse ListFlowControlTaskReferenceWithOptions(string instanceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowControlTaskReference",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/reference",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowControlTaskReferenceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries reference data for throttling.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskReferenceResponse
        /// </returns>
        public async Task<ListFlowControlTaskReferenceResponse> ListFlowControlTaskReferenceWithOptionsAsync(string instanceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowControlTaskReference",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/reference",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowControlTaskReferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries reference data for throttling.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListFlowControlTaskReferenceResponse
        /// </returns>
        public ListFlowControlTaskReferenceResponse ListFlowControlTaskReference(string instanceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFlowControlTaskReferenceWithOptions(instanceId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries reference data for throttling.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListFlowControlTaskReferenceResponse
        /// </returns>
        public async Task<ListFlowControlTaskReferenceResponse> ListFlowControlTaskReferenceAsync(string instanceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFlowControlTaskReferenceWithOptionsAsync(instanceId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流量调控任务曝光分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskReportsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskReportsResponse
        /// </returns>
        public ListFlowControlTaskReportsResponse ListFlowControlTaskReportsWithOptions(string instanceId, string taskId, ListFlowControlTaskReportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListFlowControlTaskReports",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/flowTaskReports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowControlTaskReportsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流量调控任务曝光分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskReportsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskReportsResponse
        /// </returns>
        public async Task<ListFlowControlTaskReportsResponse> ListFlowControlTaskReportsWithOptionsAsync(string instanceId, string taskId, ListFlowControlTaskReportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListFlowControlTaskReports",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/flowTaskReports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowControlTaskReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流量调控任务曝光分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskReportsResponse
        /// </returns>
        public ListFlowControlTaskReportsResponse ListFlowControlTaskReports(string instanceId, string taskId, ListFlowControlTaskReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFlowControlTaskReportsWithOptions(instanceId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>流量调控任务曝光分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFlowControlTaskReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlowControlTaskReportsResponse
        /// </returns>
        public async Task<ListFlowControlTaskReportsResponse> ListFlowControlTaskReportsAsync(string instanceId, string taskId, ListFlowControlTaskReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFlowControlTaskReportsWithOptionsAsync(instanceId, taskId, request, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndexVersionsResponse
        /// </returns>
        public ListIndexVersionsResponse ListIndexVersionsWithOptions(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndexVersions",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/index-versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndexVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIndexVersionsResponse
        /// </returns>
        public async Task<ListIndexVersionsResponse> ListIndexVersionsWithOptionsAsync(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIndexVersions",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/index-versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIndexVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// ListIndexVersionsResponse
        /// </returns>
        public ListIndexVersionsResponse ListIndexVersions(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIndexVersionsWithOptions(instanceId, algorithmId, headers, runtime);
        }

        /// <returns>
        /// ListIndexVersionsResponse
        /// </returns>
        public async Task<ListIndexVersionsResponse> ListIndexVersionsAsync(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIndexVersionsWithOptionsAsync(instanceId, algorithmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the list of instances. The returned instances are ranked in descending order based on the values of GmtCreate. You can specify multiple request parameters. These request parameters can be used to filter query results. The request parameters that you specify have logical AND relations. Only the specified parameters can be used to filter query results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceResponse
        /// </returns>
        public ListInstanceResponse ListInstanceWithOptions(ListInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTime))
            {
                query["expiredTime"] = request.ExpiredTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
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
                Action = "ListInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the list of instances. The returned instances are ranked in descending order based on the values of GmtCreate. You can specify multiple request parameters. These request parameters can be used to filter query results. The request parameters that you specify have logical AND relations. Only the specified parameters can be used to filter query results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceResponse
        /// </returns>
        public async Task<ListInstanceResponse> ListInstanceWithOptionsAsync(ListInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTime))
            {
                query["expiredTime"] = request.ExpiredTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
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
                Action = "ListInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the list of instances. The returned instances are ranked in descending order based on the values of GmtCreate. You can specify multiple request parameters. These request parameters can be used to filter query results. The request parameters that you specify have logical AND relations. Only the specified parameters can be used to filter query results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceResponse
        /// </returns>
        public ListInstanceResponse ListInstance(ListInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query the list of instances. The returned instances are ranked in descending order based on the values of GmtCreate. You can specify multiple request parameters. These request parameters can be used to filter query results. The request parameters that you specify have logical AND relations. Only the specified parameters can be used to filter query results.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceResponse
        /// </returns>
        public async Task<ListInstanceResponse> ListInstanceAsync(ListInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all asynchronous tasks of a specified instance by using the instance ID.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceTaskResponse
        /// </returns>
        public ListInstanceTaskResponse ListInstanceTaskWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all asynchronous tasks of a specified instance by using the instance ID.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceTaskResponse
        /// </returns>
        public async Task<ListInstanceTaskResponse> ListInstanceTaskWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all asynchronous tasks of a specified instance by using the instance ID.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListInstanceTaskResponse
        /// </returns>
        public ListInstanceTaskResponse ListInstanceTask(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceTaskWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all asynchronous tasks of a specified instance by using the instance ID.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListInstanceTaskResponse
        /// </returns>
        public async Task<ListInstanceTaskResponse> ListInstanceTaskAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceTaskWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <param name="request">
        /// ListItemsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListItemsResponse
        /// </returns>
        public ListItemsResponse ListItemsWithOptions(string instanceId, ListItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyUsed))
            {
                query["strategyUsed"] = request.StrategyUsed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithInvalidDetail))
            {
                query["withInvalidDetail"] = request.WithInvalidDetail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListItems",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/items/actions/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListItemsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListItemsResponse
        /// </returns>
        public async Task<ListItemsResponse> ListItemsWithOptionsAsync(string instanceId, ListItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyUsed))
            {
                query["strategyUsed"] = request.StrategyUsed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithInvalidDetail))
            {
                query["withInvalidDetail"] = request.WithInvalidDetail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListItems",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/items/actions/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListItemsResponse
        /// </returns>
        public ListItemsResponse ListItems(string instanceId, ListItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListItemsWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListItemsResponse
        /// </returns>
        public async Task<ListItemsResponse> ListItemsAsync(string instanceId, ListItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListItemsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogsResponse
        /// </returns>
        public ListLogsResponse ListLogsWithOptions(string instanceId, ListLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryParams))
            {
                query["queryParams"] = request.QueryParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
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
                Action = "ListLogs",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogsResponse
        /// </returns>
        public async Task<ListLogsResponse> ListLogsWithOptionsAsync(string instanceId, ListLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryParams))
            {
                query["queryParams"] = request.QueryParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
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
                Action = "ListLogs",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogsResponse
        /// </returns>
        public ListLogsResponse ListLogs(string instanceId, ListLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogsWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogsResponse
        /// </returns>
        public async Task<ListLogsResponse> ListLogsAsync(string instanceId, ListLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the content types supported in the diversity rule configurations of an instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMixCategoriesResponse
        /// </returns>
        public ListMixCategoriesResponse ListMixCategoriesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMixCategories",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/configurations/mixCategories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMixCategoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the content types supported in the diversity rule configurations of an instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMixCategoriesResponse
        /// </returns>
        public async Task<ListMixCategoriesResponse> ListMixCategoriesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMixCategories",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/configurations/mixCategories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMixCategoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the content types supported in the diversity rule configurations of an instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListMixCategoriesResponse
        /// </returns>
        public ListMixCategoriesResponse ListMixCategories()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMixCategoriesWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the content types supported in the diversity rule configurations of an instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListMixCategoriesResponse
        /// </returns>
        public async Task<ListMixCategoriesResponse> ListMixCategoriesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMixCategoriesWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线存储列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOfflineStoragesResponse
        /// </returns>
        public ListOfflineStoragesResponse ListOfflineStoragesWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOfflineStorages",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/%5BinstanceId%5D/offlineStorages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOfflineStoragesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线存储列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOfflineStoragesResponse
        /// </returns>
        public async Task<ListOfflineStoragesResponse> ListOfflineStoragesWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOfflineStorages",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/%5BinstanceId%5D/offlineStorages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOfflineStoragesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线存储列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListOfflineStoragesResponse
        /// </returns>
        public ListOfflineStoragesResponse ListOfflineStorages(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOfflineStoragesWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取离线存储列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListOfflineStoragesResponse
        /// </returns>
        public async Task<ListOfflineStoragesResponse> ListOfflineStoragesAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOfflineStoragesWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the templates of a ranking model. The returned templates are sorted in reverse chronological order based on the time when the templates were created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingModelTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRankingModelTemplatesResponse
        /// </returns>
        public ListRankingModelTemplatesResponse ListRankingModelTemplatesWithOptions(string instanceId, ListRankingModelTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListRankingModelTemplates",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRankingModelTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the templates of a ranking model. The returned templates are sorted in reverse chronological order based on the time when the templates were created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingModelTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRankingModelTemplatesResponse
        /// </returns>
        public async Task<ListRankingModelTemplatesResponse> ListRankingModelTemplatesWithOptionsAsync(string instanceId, ListRankingModelTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListRankingModelTemplates",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRankingModelTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the templates of a ranking model. The returned templates are sorted in reverse chronological order based on the time when the templates were created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingModelTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRankingModelTemplatesResponse
        /// </returns>
        public ListRankingModelTemplatesResponse ListRankingModelTemplates(string instanceId, ListRankingModelTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRankingModelTemplatesWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the templates of a ranking model. The returned templates are sorted in reverse chronological order based on the time when the templates were created.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingModelTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRankingModelTemplatesResponse
        /// </returns>
        public async Task<ListRankingModelTemplatesResponse> ListRankingModelTemplatesAsync(string instanceId, ListRankingModelTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRankingModelTemplatesWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of versions for a ranking model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingModelVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRankingModelVersionsResponse
        /// </returns>
        public ListRankingModelVersionsResponse ListRankingModelVersionsWithOptions(string instanceId, ListRankingModelVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRankingModelVersions",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRankingModelVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of versions for a ranking model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingModelVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRankingModelVersionsResponse
        /// </returns>
        public async Task<ListRankingModelVersionsResponse> ListRankingModelVersionsWithOptionsAsync(string instanceId, ListRankingModelVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRankingModelVersions",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRankingModelVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of versions for a ranking model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingModelVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRankingModelVersionsResponse
        /// </returns>
        public ListRankingModelVersionsResponse ListRankingModelVersions(string instanceId, ListRankingModelVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRankingModelVersionsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of versions for a ranking model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingModelVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRankingModelVersionsResponse
        /// </returns>
        public async Task<ListRankingModelVersionsResponse> ListRankingModelVersionsAsync(string instanceId, ListRankingModelVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRankingModelVersionsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListRankingModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRankingModelsResponse
        /// </returns>
        public ListRankingModelsResponse ListRankingModelsWithOptions(string instanceId, ListRankingModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankingModelId))
            {
                query["rankingModelId"] = request.RankingModelId;
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
                Action = "ListRankingModels",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRankingModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListRankingModelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRankingModelsResponse
        /// </returns>
        public async Task<ListRankingModelsResponse> ListRankingModelsWithOptionsAsync(string instanceId, ListRankingModelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankingModelId))
            {
                query["rankingModelId"] = request.RankingModelId;
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
                Action = "ListRankingModels",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRankingModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListRankingModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRankingModelsResponse
        /// </returns>
        public ListRankingModelsResponse ListRankingModels(string instanceId, ListRankingModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRankingModelsWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListRankingModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRankingModelsResponse
        /// </returns>
        public async Task<ListRankingModelsResponse> ListRankingModelsAsync(string instanceId, ListRankingModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRankingModelsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingSystemHistoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRankingSystemHistoriesResponse
        /// </returns>
        public ListRankingSystemHistoriesResponse ListRankingSystemHistoriesWithOptions(string instanceId, string name, ListRankingSystemHistoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["operateType"] = request.OperateType;
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
                Action = "ListRankingSystemHistories",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/histories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRankingSystemHistoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingSystemHistoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRankingSystemHistoriesResponse
        /// </returns>
        public async Task<ListRankingSystemHistoriesResponse> ListRankingSystemHistoriesWithOptionsAsync(string instanceId, string name, ListRankingSystemHistoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["operateType"] = request.OperateType;
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
                Action = "ListRankingSystemHistories",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/histories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRankingSystemHistoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingSystemHistoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRankingSystemHistoriesResponse
        /// </returns>
        public ListRankingSystemHistoriesResponse ListRankingSystemHistories(string instanceId, string name, ListRankingSystemHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRankingSystemHistoriesWithOptions(instanceId, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingSystemHistoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRankingSystemHistoriesResponse
        /// </returns>
        public async Task<ListRankingSystemHistoriesResponse> ListRankingSystemHistoriesAsync(string instanceId, string name, ListRankingSystemHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRankingSystemHistoriesWithOptionsAsync(instanceId, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取排序服务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingSystemsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRankingSystemsResponse
        /// </returns>
        public ListRankingSystemsResponse ListRankingSystemsWithOptions(string instanceId, ListRankingSystemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployStatus))
            {
                query["deployStatus"] = request.DeployStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
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
                Action = "ListRankingSystems",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRankingSystemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取排序服务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingSystemsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRankingSystemsResponse
        /// </returns>
        public async Task<ListRankingSystemsResponse> ListRankingSystemsWithOptionsAsync(string instanceId, ListRankingSystemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployStatus))
            {
                query["deployStatus"] = request.DeployStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
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
                Action = "ListRankingSystems",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRankingSystemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取排序服务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingSystemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRankingSystemsResponse
        /// </returns>
        public ListRankingSystemsResponse ListRankingSystems(string instanceId, ListRankingSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRankingSystemsWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取排序服务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRankingSystemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRankingSystemsResponse
        /// </returns>
        public async Task<ListRankingSystemsResponse> ListRankingSystemsAsync(string instanceId, ListRankingSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRankingSystemsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries item selection rules of an instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRuleConditionsResponse
        /// </returns>
        public ListRuleConditionsResponse ListRuleConditionsWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRuleConditions",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rule-conditions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRuleConditionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries item selection rules of an instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRuleConditionsResponse
        /// </returns>
        public async Task<ListRuleConditionsResponse> ListRuleConditionsWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRuleConditions",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rule-conditions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRuleConditionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries item selection rules of an instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListRuleConditionsResponse
        /// </returns>
        public ListRuleConditionsResponse ListRuleConditions(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRuleConditionsWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries item selection rules of an instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListRuleConditionsResponse
        /// </returns>
        public async Task<ListRuleConditionsResponse> ListRuleConditionsAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRuleConditionsWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRuleTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRuleTasksResponse
        /// </returns>
        public ListRuleTasksResponse ListRuleTasksWithOptions(string instanceId, ListRuleTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRuleTasks",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rule-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRuleTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRuleTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRuleTasksResponse
        /// </returns>
        public async Task<ListRuleTasksResponse> ListRuleTasksWithOptionsAsync(string instanceId, ListRuleTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRuleTasks",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rule-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRuleTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRuleTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRuleTasksResponse
        /// </returns>
        public ListRuleTasksResponse ListRuleTasks(string instanceId, ListRuleTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRuleTasksWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRuleTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRuleTasksResponse
        /// </returns>
        public async Task<ListRuleTasksResponse> ListRuleTasksAsync(string instanceId, ListRuleTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRuleTasksWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public ListRulesResponse ListRulesWithOptions(string instanceId, ListRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["ruleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
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
                Action = "ListRules",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public async Task<ListRulesResponse> ListRulesWithOptionsAsync(string instanceId, ListRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["ruleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
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
                Action = "ListRules",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public ListRulesResponse ListRules(string instanceId, ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRulesWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        public async Task<ListRulesResponse> ListRulesAsync(string instanceId, ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRulesWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取样本格式化配置列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSampleFormatConfigsResponse
        /// </returns>
        public ListSampleFormatConfigsResponse ListSampleFormatConfigsWithOptions(string instanceId, string sampleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSampleFormatConfigs",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId) + "/format-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSampleFormatConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取样本格式化配置列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSampleFormatConfigsResponse
        /// </returns>
        public async Task<ListSampleFormatConfigsResponse> ListSampleFormatConfigsWithOptionsAsync(string instanceId, string sampleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSampleFormatConfigs",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId) + "/format-configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSampleFormatConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取样本格式化配置列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListSampleFormatConfigsResponse
        /// </returns>
        public ListSampleFormatConfigsResponse ListSampleFormatConfigs(string instanceId, string sampleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSampleFormatConfigsWithOptions(instanceId, sampleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取样本格式化配置列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListSampleFormatConfigsResponse
        /// </returns>
        public async Task<ListSampleFormatConfigsResponse> ListSampleFormatConfigsAsync(string instanceId, string sampleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSampleFormatConfigsWithOptionsAsync(instanceId, sampleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取样本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSamplesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSamplesResponse
        /// </returns>
        public ListSamplesResponse ListSamplesWithOptions(string instanceId, ListSamplesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleId))
            {
                query["sampleId"] = request.SampleId;
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
                Action = "ListSamples",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSamplesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取样本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSamplesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSamplesResponse
        /// </returns>
        public async Task<ListSamplesResponse> ListSamplesWithOptionsAsync(string instanceId, ListSamplesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleId))
            {
                query["sampleId"] = request.SampleId;
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
                Action = "ListSamples",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSamplesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取样本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSamplesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSamplesResponse
        /// </returns>
        public ListSamplesResponse ListSamples(string instanceId, ListSamplesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSamplesWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取样本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSamplesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSamplesResponse
        /// </returns>
        public async Task<ListSamplesResponse> ListSamplesAsync(string instanceId, ListSamplesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSamplesWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries preview results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSceneItemsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSceneItemsResponse
        /// </returns>
        public ListSceneItemsResponse ListSceneItemsWithOptions(string instanceId, string sceneId, ListSceneItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationRuleId))
            {
                query["operationRuleId"] = request.OperationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewType))
            {
                query["previewType"] = request.PreviewType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCount))
            {
                query["queryCount"] = request.QueryCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionRuleId))
            {
                query["selectionRuleId"] = request.SelectionRuleId;
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
                Action = "ListSceneItems",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSceneItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries preview results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSceneItemsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSceneItemsResponse
        /// </returns>
        public async Task<ListSceneItemsResponse> ListSceneItemsWithOptionsAsync(string instanceId, string sceneId, ListSceneItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationRuleId))
            {
                query["operationRuleId"] = request.OperationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewType))
            {
                query["previewType"] = request.PreviewType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCount))
            {
                query["queryCount"] = request.QueryCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionRuleId))
            {
                query["selectionRuleId"] = request.SelectionRuleId;
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
                Action = "ListSceneItems",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSceneItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries preview results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSceneItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSceneItemsResponse
        /// </returns>
        public ListSceneItemsResponse ListSceneItems(string instanceId, string sceneId, ListSceneItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSceneItemsWithOptions(instanceId, sceneId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries preview results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSceneItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSceneItemsResponse
        /// </returns>
        public async Task<ListSceneItemsResponse> ListSceneItemsAsync(string instanceId, string sceneId, ListSceneItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSceneItemsWithOptionsAsync(instanceId, sceneId, request, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSceneParametersResponse
        /// </returns>
        public ListSceneParametersResponse ListSceneParametersWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSceneParameters",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/scene-parameters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSceneParametersResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSceneParametersResponse
        /// </returns>
        public async Task<ListSceneParametersResponse> ListSceneParametersWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSceneParameters",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dashboard/scene-parameters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSceneParametersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// ListSceneParametersResponse
        /// </returns>
        public ListSceneParametersResponse ListSceneParameters(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSceneParametersWithOptions(instanceId, headers, runtime);
        }

        /// <returns>
        /// ListSceneParametersResponse
        /// </returns>
        public async Task<ListSceneParametersResponse> ListSceneParametersAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSceneParametersWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries scenes of a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. Go to the Scenario Building page in the AIRec console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScenesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScenesResponse
        /// </returns>
        public ListScenesResponse ListScenesWithOptions(string instanceId, ListScenesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
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
                Action = "ListScenes",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScenesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries scenes of a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. Go to the Scenario Building page in the AIRec console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScenesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScenesResponse
        /// </returns>
        public async Task<ListScenesResponse> ListScenesWithOptionsAsync(string instanceId, ListScenesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
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
                Action = "ListScenes",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScenesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries scenes of a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. Go to the Scenario Building page in the AIRec console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScenesResponse
        /// </returns>
        public ListScenesResponse ListScenes(string instanceId, ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListScenesWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries scenes of a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. Go to the Scenario Building page in the AIRec console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScenesResponse
        /// </returns>
        public async Task<ListScenesResponse> ListScenesAsync(string instanceId, ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListScenesWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUmengAppkeysResponse
        /// </returns>
        public ListUmengAppkeysResponse ListUmengAppkeysWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUmengAppkeys",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/umeng/appkeys",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUmengAppkeysResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUmengAppkeysResponse
        /// </returns>
        public async Task<ListUmengAppkeysResponse> ListUmengAppkeysWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUmengAppkeys",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/umeng/appkeys",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUmengAppkeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// ListUmengAppkeysResponse
        /// </returns>
        public ListUmengAppkeysResponse ListUmengAppkeys()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUmengAppkeysWithOptions(headers, runtime);
        }

        /// <returns>
        /// ListUmengAppkeysResponse
        /// </returns>
        public async Task<ListUmengAppkeysResponse> ListUmengAppkeysAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUmengAppkeysWithOptionsAsync(headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserClustersResponse
        /// </returns>
        public ListUserClustersResponse ListUserClustersWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserClusters",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/user-clusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserClustersResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserClustersResponse
        /// </returns>
        public async Task<ListUserClustersResponse> ListUserClustersWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserClusters",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/user-clusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// ListUserClustersResponse
        /// </returns>
        public ListUserClustersResponse ListUserClusters(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserClustersWithOptions(instanceId, headers, runtime);
        }

        /// <returns>
        /// ListUserClustersResponse
        /// </returns>
        public async Task<ListUserClustersResponse> ListUserClustersAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserClustersWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information of a single data source in a table of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceResponse
        /// </returns>
        public ModifyDataSourceResponse ModifyDataSourceWithOptions(string instanceId, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataSource",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information of a single data source in a table of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDataSourceResponse
        /// </returns>
        public async Task<ModifyDataSourceResponse> ModifyDataSourceWithOptionsAsync(string instanceId, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataSource",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information of a single data source in a table of a specified instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModifyDataSourceResponse
        /// </returns>
        public ModifyDataSourceResponse ModifyDataSource(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyDataSourceWithOptions(instanceId, tableName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information of a single data source in a table of a specified instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModifyDataSourceResponse
        /// </returns>
        public async Task<ModifyDataSourceResponse> ModifyDataSourceAsync(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyDataSourceWithOptionsAsync(instanceId, tableName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改特征表，只支表级别持特征列表的全量修改</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFeatureTableResponse
        /// </returns>
        public ModifyFeatureTableResponse ModifyFeatureTableWithOptions(string instanceId, string type, string featureTableId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFeatureTable",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/feature-tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(featureTableId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFeatureTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改特征表，只支表级别持特征列表的全量修改</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFeatureTableResponse
        /// </returns>
        public async Task<ModifyFeatureTableResponse> ModifyFeatureTableWithOptionsAsync(string instanceId, string type, string featureTableId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFeatureTable",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/feature-tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(featureTableId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFeatureTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改特征表，只支表级别持特征列表的全量修改</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModifyFeatureTableResponse
        /// </returns>
        public ModifyFeatureTableResponse ModifyFeatureTable(string instanceId, string type, string featureTableId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyFeatureTableWithOptions(instanceId, type, featureTableId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改特征表，只支表级别持特征列表的全量修改</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModifyFeatureTableResponse
        /// </returns>
        public async Task<ModifyFeatureTableResponse> ModifyFeatureTableAsync(string instanceId, string type, string featureTableId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyFeatureTableWithOptionsAsync(instanceId, type, featureTableId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The name of the project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The name of the filtering algorithm.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFilteringAlgorithmMetaResponse
        /// </returns>
        public ModifyFilteringAlgorithmMetaResponse ModifyFilteringAlgorithmMetaWithOptions(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFilteringAlgorithmMeta",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/meta",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFilteringAlgorithmMetaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The name of the project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The name of the filtering algorithm.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFilteringAlgorithmMetaResponse
        /// </returns>
        public async Task<ModifyFilteringAlgorithmMetaResponse> ModifyFilteringAlgorithmMetaWithOptionsAsync(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFilteringAlgorithmMeta",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/meta",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFilteringAlgorithmMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The name of the project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The name of the filtering algorithm.</para>
        /// </description>
        /// 
        /// <returns>
        /// ModifyFilteringAlgorithmMetaResponse
        /// </returns>
        public ModifyFilteringAlgorithmMetaResponse ModifyFilteringAlgorithmMeta(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyFilteringAlgorithmMetaWithOptions(instanceId, algorithmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The name of the project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The name of the filtering algorithm.</para>
        /// </description>
        /// 
        /// <returns>
        /// ModifyFilteringAlgorithmMetaResponse
        /// </returns>
        public async Task<ModifyFilteringAlgorithmMetaResponse> ModifyFilteringAlgorithmMetaAsync(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyFilteringAlgorithmMetaWithOptionsAsync(instanceId, algorithmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a throttling task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFlowControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFlowControlTaskResponse
        /// </returns>
        public ModifyFlowControlTaskResponse ModifyFlowControlTaskWithOptions(string instanceId, string taskId, ModifyFlowControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaType))
            {
                body["metaType"] = request.MetaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIds))
            {
                body["sceneIds"] = request.SceneIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionParams))
            {
                body["selectionParams"] = request.SelectionParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a throttling task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFlowControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFlowControlTaskResponse
        /// </returns>
        public async Task<ModifyFlowControlTaskResponse> ModifyFlowControlTaskWithOptionsAsync(string instanceId, string taskId, ModifyFlowControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetaType))
            {
                body["metaType"] = request.MetaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIds))
            {
                body["sceneIds"] = request.SceneIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionParams))
            {
                body["selectionParams"] = request.SelectionParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a throttling task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFlowControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFlowControlTaskResponse
        /// </returns>
        public ModifyFlowControlTaskResponse ModifyFlowControlTask(string instanceId, string taskId, ModifyFlowControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyFlowControlTaskWithOptions(instanceId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a throttling task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFlowControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFlowControlTaskResponse
        /// </returns>
        public async Task<ModifyFlowControlTaskResponse> ModifyFlowControlTaskAsync(string instanceId, string taskId, ModifyFlowControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyFlowControlTaskWithOptionsAsync(instanceId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceResponse
        /// </returns>
        public ModifyInstanceResponse ModifyInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a specified instance.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceResponse
        /// </returns>
        public async Task<ModifyInstanceResponse> ModifyInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a specified instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModifyInstanceResponse
        /// </returns>
        public ModifyInstanceResponse ModifyInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyInstanceWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a specified instance.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModifyInstanceResponse
        /// </returns>
        public async Task<ModifyInstanceResponse> ModifyInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyItemsResponse
        /// </returns>
        public ModifyItemsResponse ModifyItemsWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyItems",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/items",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyItemsResponse
        /// </returns>
        public async Task<ModifyItemsResponse> ModifyItemsWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyItems",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/items",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// ModifyItemsResponse
        /// </returns>
        public ModifyItemsResponse ModifyItems(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyItemsWithOptions(instanceId, headers, runtime);
        }

        /// <returns>
        /// ModifyItemsResponse
        /// </returns>
        public async Task<ModifyItemsResponse> ModifyItemsAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyItemsWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the offline storage configurations of an instance. You need to modify three tables at the same time.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyOfflineStoragesResponse
        /// </returns>
        public ModifyOfflineStoragesResponse ModifyOfflineStoragesWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyOfflineStorages",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/%5BinstanceId%5D/offlineStorages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOfflineStoragesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the offline storage configurations of an instance. You need to modify three tables at the same time.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyOfflineStoragesResponse
        /// </returns>
        public async Task<ModifyOfflineStoragesResponse> ModifyOfflineStoragesWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyOfflineStorages",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/%5BinstanceId%5D/offlineStorages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyOfflineStoragesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the offline storage configurations of an instance. You need to modify three tables at the same time.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModifyOfflineStoragesResponse
        /// </returns>
        public ModifyOfflineStoragesResponse ModifyOfflineStorages(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyOfflineStoragesWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the offline storage configurations of an instance. You need to modify three tables at the same time.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModifyOfflineStoragesResponse
        /// </returns>
        public async Task<ModifyOfflineStoragesResponse> ModifyOfflineStoragesAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyOfflineStoragesWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the ranking model.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyRankingModelResponse
        /// </returns>
        public ModifyRankingModelResponse ModifyRankingModelWithOptions(string instanceId, string rankingModelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRankingModel",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rankingModelId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRankingModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the ranking model.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyRankingModelResponse
        /// </returns>
        public async Task<ModifyRankingModelResponse> ModifyRankingModelWithOptionsAsync(string instanceId, string rankingModelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRankingModel",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-models/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(rankingModelId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRankingModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the ranking model.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModifyRankingModelResponse
        /// </returns>
        public ModifyRankingModelResponse ModifyRankingModel(string instanceId, string rankingModelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyRankingModelWithOptions(instanceId, rankingModelId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the ranking model.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModifyRankingModelResponse
        /// </returns>
        public async Task<ModifyRankingModelResponse> ModifyRankingModelAsync(string instanceId, string rankingModelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyRankingModelWithOptionsAsync(instanceId, rankingModelId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a ranking model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyRankingModelTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyRankingModelTemplateResponse
        /// </returns>
        public ModifyRankingModelTemplateResponse ModifyRankingModelTemplateWithOptions(string instanceId, string templateId, ModifyRankingModelTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRankingModelTemplate",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRankingModelTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a ranking model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyRankingModelTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyRankingModelTemplateResponse
        /// </returns>
        public async Task<ModifyRankingModelTemplateResponse> ModifyRankingModelTemplateWithOptionsAsync(string instanceId, string templateId, ModifyRankingModelTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRankingModelTemplate",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRankingModelTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a ranking model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyRankingModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyRankingModelTemplateResponse
        /// </returns>
        public ModifyRankingModelTemplateResponse ModifyRankingModelTemplate(string instanceId, string templateId, ModifyRankingModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyRankingModelTemplateWithOptions(instanceId, templateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a ranking model.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyRankingModelTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyRankingModelTemplateResponse
        /// </returns>
        public async Task<ModifyRankingModelTemplateResponse> ModifyRankingModelTemplateAsync(string instanceId, string templateId, ModifyRankingModelTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyRankingModelTemplateWithOptionsAsync(instanceId, templateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a ranking service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyRankingSystemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyRankingSystemResponse
        /// </returns>
        public ModifyRankingSystemResponse ModifyRankingSystemWithOptions(string instanceId, string name, ModifyRankingSystemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRankingSystemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a ranking service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyRankingSystemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyRankingSystemResponse
        /// </returns>
        public async Task<ModifyRankingSystemResponse> ModifyRankingSystemWithOptionsAsync(string instanceId, string name, ModifyRankingSystemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRankingSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a ranking service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyRankingSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyRankingSystemResponse
        /// </returns>
        public ModifyRankingSystemResponse ModifyRankingSystem(string instanceId, string name, ModifyRankingSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyRankingSystemWithOptions(instanceId, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a ranking service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyRankingSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyRankingSystemResponse
        /// </returns>
        public async Task<ModifyRankingSystemResponse> ModifyRankingSystemAsync(string instanceId, string name, ModifyRankingSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyRankingSystemWithOptionsAsync(instanceId, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a rule.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyRuleResponse
        /// </returns>
        public ModifyRuleResponse ModifyRuleWithOptions(string instanceId, string ruleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRule",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ruleId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a rule.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyRuleResponse
        /// </returns>
        public async Task<ModifyRuleResponse> ModifyRuleWithOptionsAsync(string instanceId, string ruleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRule",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ruleId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a rule.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModifyRuleResponse
        /// </returns>
        public ModifyRuleResponse ModifyRule(string instanceId, string ruleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyRuleWithOptions(instanceId, ruleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a rule.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ModifyRuleResponse
        /// </returns>
        public async Task<ModifyRuleResponse> ModifyRuleAsync(string instanceId, string ruleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyRuleWithOptionsAsync(instanceId, ruleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改样本配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySampleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySampleResponse
        /// </returns>
        public ModifySampleResponse ModifySampleWithOptions(string instanceId, string sampleId, ModifySampleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySample",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySampleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改样本配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySampleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySampleResponse
        /// </returns>
        public async Task<ModifySampleResponse> ModifySampleWithOptionsAsync(string instanceId, string sampleId, ModifySampleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySample",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySampleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改样本配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySampleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySampleResponse
        /// </returns>
        public ModifySampleResponse ModifySample(string instanceId, string sampleId, ModifySampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifySampleWithOptions(instanceId, sampleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改样本配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifySampleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySampleResponse
        /// </returns>
        public async Task<ModifySampleResponse> ModifySampleAsync(string instanceId, string sampleId, ModifySampleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifySampleWithOptionsAsync(instanceId, sampleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about a scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySceneResponse
        /// </returns>
        public ModifySceneResponse ModifySceneWithOptions(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScene",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySceneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about a scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySceneResponse
        /// </returns>
        public async Task<ModifySceneResponse> ModifySceneWithOptionsAsync(string instanceId, string sceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScene",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about a scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <returns>
        /// ModifySceneResponse
        /// </returns>
        public ModifySceneResponse ModifyScene(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifySceneWithOptions(instanceId, sceneId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about a scene.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you do not call an API operation to manage scenes. We recommend that you go to the Scenario Building page in the Artificial Intelligence Recommendation (AIRec) console to manage scenes.</para>
        /// </description>
        /// 
        /// <returns>
        /// ModifySceneResponse
        /// </returns>
        public async Task<ModifySceneResponse> ModifySceneAsync(string instanceId, string sceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifySceneWithOptionsAsync(instanceId, sceneId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineFilteringAlgorithmResponse
        /// </returns>
        public OfflineFilteringAlgorithmResponse OfflineFilteringAlgorithmWithOptions(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineFilteringAlgorithm",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/actions/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineFilteringAlgorithmResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineFilteringAlgorithmResponse
        /// </returns>
        public async Task<OfflineFilteringAlgorithmResponse> OfflineFilteringAlgorithmWithOptionsAsync(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineFilteringAlgorithm",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/actions/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineFilteringAlgorithmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// OfflineFilteringAlgorithmResponse
        /// </returns>
        public OfflineFilteringAlgorithmResponse OfflineFilteringAlgorithm(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OfflineFilteringAlgorithmWithOptions(instanceId, algorithmId, headers, runtime);
        }

        /// <returns>
        /// OfflineFilteringAlgorithmResponse
        /// </returns>
        public async Task<OfflineFilteringAlgorithmResponse> OfflineFilteringAlgorithmAsync(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OfflineFilteringAlgorithmWithOptionsAsync(instanceId, algorithmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布流调任务接口</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishFlowControlTaskResponse
        /// </returns>
        public PublishFlowControlTaskResponse PublishFlowControlTaskWithOptions(string instanceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/actions/publish",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishFlowControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布流调任务接口</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishFlowControlTaskResponse
        /// </returns>
        public async Task<PublishFlowControlTaskResponse> PublishFlowControlTaskWithOptionsAsync(string instanceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/actions/publish",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishFlowControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布流调任务接口</para>
        /// </summary>
        /// 
        /// <returns>
        /// PublishFlowControlTaskResponse
        /// </returns>
        public PublishFlowControlTaskResponse PublishFlowControlTask(string instanceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishFlowControlTaskWithOptions(instanceId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布流调任务接口</para>
        /// </summary>
        /// 
        /// <returns>
        /// PublishFlowControlTaskResponse
        /// </returns>
        public async Task<PublishFlowControlTaskResponse> PublishFlowControlTaskAsync(string instanceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishFlowControlTaskWithOptionsAsync(instanceId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishRuleResponse
        /// </returns>
        public PublishRuleResponse PublishRuleWithOptions(string ruleId, string instanceId, PublishRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["ruleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishRule",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ruleId) + "/actions/publish",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishRuleResponse
        /// </returns>
        public async Task<PublishRuleResponse> PublishRuleWithOptionsAsync(string ruleId, string instanceId, PublishRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["ruleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishRule",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/rules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ruleId) + "/actions/publish",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishRuleResponse
        /// </returns>
        public PublishRuleResponse PublishRule(string ruleId, string instanceId, PublishRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishRuleWithOptions(ruleId, instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes a rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishRuleResponse
        /// </returns>
        public async Task<PublishRuleResponse> PublishRuleAsync(string ruleId, string instanceId, PublishRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishRuleWithOptionsAsync(ruleId, instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于向指定冷启动实例指定表推送文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushColdStartDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushColdStartDocumentResponse
        /// </returns>
        public PushColdStartDocumentResponse PushColdStartDocumentWithOptions(string instanceId, string tableName, PushColdStartDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushColdStartDocument",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/cold-start/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/actions/bulk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushColdStartDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于向指定冷启动实例指定表推送文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushColdStartDocumentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushColdStartDocumentResponse
        /// </returns>
        public async Task<PushColdStartDocumentResponse> PushColdStartDocumentWithOptionsAsync(string instanceId, string tableName, PushColdStartDocumentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushColdStartDocument",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/cold-start/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/actions/bulk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushColdStartDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于向指定冷启动实例指定表推送文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushColdStartDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// PushColdStartDocumentResponse
        /// </returns>
        public PushColdStartDocumentResponse PushColdStartDocument(string instanceId, string tableName, PushColdStartDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushColdStartDocumentWithOptions(instanceId, tableName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>该接口用于向指定冷启动实例指定表推送文档</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushColdStartDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// PushColdStartDocumentResponse
        /// </returns>
        public async Task<PushColdStartDocumentResponse> PushColdStartDocumentAsync(string instanceId, string tableName, PushColdStartDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushColdStartDocumentWithOptionsAsync(instanceId, tableName, request, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushDocumentResponse
        /// </returns>
        public PushDocumentResponse PushDocumentWithOptions(string instanceId, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDocument",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/actions/bulk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushDocumentResponse
        /// </returns>
        public async Task<PushDocumentResponse> PushDocumentWithOptionsAsync(string instanceId, string tableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDocument",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName) + "/actions/bulk",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// PushDocumentResponse
        /// </returns>
        public PushDocumentResponse PushDocument(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushDocumentWithOptions(instanceId, tableName, headers, runtime);
        }

        /// <returns>
        /// PushDocumentResponse
        /// </returns>
        public async Task<PushDocumentResponse> PushDocumentAsync(string instanceId, string tableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushDocumentWithOptionsAsync(instanceId, tableName, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushInterventionResponse
        /// </returns>
        public PushInterventionResponse PushInterventionWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushIntervention",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/intervene",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushInterventionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushInterventionResponse
        /// </returns>
        public async Task<PushInterventionResponse> PushInterventionWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushIntervention",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/intervene",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushInterventionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// PushInterventionResponse
        /// </returns>
        public PushInterventionResponse PushIntervention(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushInterventionWithOptions(instanceId, headers, runtime);
        }

        /// <returns>
        /// PushInterventionResponse
        /// </returns>
        public async Task<PushInterventionResponse> PushInterventionAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushInterventionWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <param name="request">
        /// QueryDataMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDataMessageResponse
        /// </returns>
        public QueryDataMessageResponse QueryDataMessageWithOptions(string instanceId, string table, QueryDataMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BhvType))
            {
                query["bhvType"] = request.BhvType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmdType))
            {
                query["cmdType"] = request.CmdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                query["imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["itemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["itemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageSource))
            {
                query["messageSource"] = request.MessageSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                query["traceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["userType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDataMessage",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/data-message",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDataMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryDataMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDataMessageResponse
        /// </returns>
        public async Task<QueryDataMessageResponse> QueryDataMessageWithOptionsAsync(string instanceId, string table, QueryDataMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BhvType))
            {
                query["bhvType"] = request.BhvType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmdType))
            {
                query["cmdType"] = request.CmdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                query["imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["itemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["itemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageSource))
            {
                query["messageSource"] = request.MessageSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                query["traceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["userType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDataMessage",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/data-message",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDataMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryDataMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDataMessageResponse
        /// </returns>
        public QueryDataMessageResponse QueryDataMessage(string instanceId, string table, QueryDataMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryDataMessageWithOptions(instanceId, table, request, headers, runtime);
        }

        /// <param name="request">
        /// QueryDataMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDataMessageResponse
        /// </returns>
        public async Task<QueryDataMessageResponse> QueryDataMessageAsync(string instanceId, string table, QueryDataMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryDataMessageWithOptionsAsync(instanceId, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics on update messages in a data table of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query statistics on update messages in a specified data table of a specified instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDataMessageStatisticsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDataMessageStatisticsResponse
        /// </returns>
        public QueryDataMessageStatisticsResponse QueryDataMessageStatisticsWithOptions(string instanceId, string table, QueryDataMessageStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BhvType))
            {
                query["bhvType"] = request.BhvType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmdType))
            {
                query["cmdType"] = request.CmdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                query["imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["itemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["itemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageSource))
            {
                query["messageSource"] = request.MessageSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                query["traceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["userType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDataMessageStatistics",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/data-message-statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDataMessageStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics on update messages in a data table of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query statistics on update messages in a specified data table of a specified instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDataMessageStatisticsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDataMessageStatisticsResponse
        /// </returns>
        public async Task<QueryDataMessageStatisticsResponse> QueryDataMessageStatisticsWithOptionsAsync(string instanceId, string table, QueryDataMessageStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BhvType))
            {
                query["bhvType"] = request.BhvType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmdType))
            {
                query["cmdType"] = request.CmdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                query["imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["itemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["itemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageSource))
            {
                query["messageSource"] = request.MessageSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                query["traceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["userType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDataMessageStatistics",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/data-message-statistics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDataMessageStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics on update messages in a data table of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query statistics on update messages in a specified data table of a specified instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDataMessageStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDataMessageStatisticsResponse
        /// </returns>
        public QueryDataMessageStatisticsResponse QueryDataMessageStatistics(string instanceId, string table, QueryDataMessageStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryDataMessageStatisticsWithOptions(instanceId, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries statistics on update messages in a data table of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to query statistics on update messages in a specified data table of a specified instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryDataMessageStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDataMessageStatisticsResponse
        /// </returns>
        public async Task<QueryDataMessageStatisticsResponse> QueryDataMessageStatisticsAsync(string instanceId, string table, QueryDataMessageStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryDataMessageStatisticsWithOptionsAsync(instanceId, table, request, headers, runtime);
        }

        /// <param name="request">
        /// QueryExceptionHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExceptionHistoryResponse
        /// </returns>
        public QueryExceptionHistoryResponse QueryExceptionHistoryWithOptions(string instanceId, QueryExceptionHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryExceptionHistory",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sync-reports/exception-history",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExceptionHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryExceptionHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExceptionHistoryResponse
        /// </returns>
        public async Task<QueryExceptionHistoryResponse> QueryExceptionHistoryWithOptionsAsync(string instanceId, QueryExceptionHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryExceptionHistory",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sync-reports/exception-history",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExceptionHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryExceptionHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExceptionHistoryResponse
        /// </returns>
        public QueryExceptionHistoryResponse QueryExceptionHistory(string instanceId, QueryExceptionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryExceptionHistoryWithOptions(instanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// QueryExceptionHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExceptionHistoryResponse
        /// </returns>
        public async Task<QueryExceptionHistoryResponse> QueryExceptionHistoryAsync(string instanceId, QueryExceptionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryExceptionHistoryWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries raw data in a specific data table of an instance by using the primary key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query raw data in a specific data table of an instance by using the primary key. The returned results need to be confirmed by customers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRawDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRawDataResponse
        /// </returns>
        public QueryRawDataResponse QueryRawDataWithOptions(string instanceId, string table, QueryRawDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                query["imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["itemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["itemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["userType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRawData",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/raw-data",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRawDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries raw data in a specific data table of an instance by using the primary key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query raw data in a specific data table of an instance by using the primary key. The returned results need to be confirmed by customers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRawDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRawDataResponse
        /// </returns>
        public async Task<QueryRawDataResponse> QueryRawDataWithOptionsAsync(string instanceId, string table, QueryRawDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                query["imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["itemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["itemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["userType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRawData",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/raw-data",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRawDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries raw data in a specific data table of an instance by using the primary key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query raw data in a specific data table of an instance by using the primary key. The returned results need to be confirmed by customers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRawDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRawDataResponse
        /// </returns>
        public QueryRawDataResponse QueryRawData(string instanceId, string table, QueryRawDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryRawDataWithOptions(instanceId, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries raw data in a specific data table of an instance by using the primary key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query raw data in a specific data table of an instance by using the primary key. The returned results need to be confirmed by customers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRawDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRawDataResponse
        /// </returns>
        public async Task<QueryRawDataResponse> QueryRawDataAsync(string instanceId, string table, QueryRawDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryRawDataWithOptionsAsync(instanceId, table, request, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleAggregationReportResponse
        /// </returns>
        public QuerySingleAggregationReportResponse QuerySingleAggregationReportWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySingleAggregationReport",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sync-reports/single-aggregation-report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleAggregationReportResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleAggregationReportResponse
        /// </returns>
        public async Task<QuerySingleAggregationReportResponse> QuerySingleAggregationReportWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySingleAggregationReport",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sync-reports/single-aggregation-report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleAggregationReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// QuerySingleAggregationReportResponse
        /// </returns>
        public QuerySingleAggregationReportResponse QuerySingleAggregationReport(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QuerySingleAggregationReportWithOptions(instanceId, headers, runtime);
        }

        /// <returns>
        /// QuerySingleAggregationReportResponse
        /// </returns>
        public async Task<QuerySingleAggregationReportResponse> QuerySingleAggregationReportAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QuerySingleAggregationReportWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a single table report. More report types may be supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySingleReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleReportResponse
        /// </returns>
        public QuerySingleReportResponse QuerySingleReportWithOptions(string instanceId, QuerySingleReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["reportType"] = request.ReportType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySingleReport",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sync-reports/single-report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a single table report. More report types may be supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySingleReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleReportResponse
        /// </returns>
        public async Task<QuerySingleReportResponse> QuerySingleReportWithOptionsAsync(string instanceId, QuerySingleReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["reportType"] = request.ReportType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySingleReport",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sync-reports/single-report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a single table report. More report types may be supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySingleReportRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleReportResponse
        /// </returns>
        public QuerySingleReportResponse QuerySingleReport(string instanceId, QuerySingleReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QuerySingleReportWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a single table report. More report types may be supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySingleReportRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleReportResponse
        /// </returns>
        public async Task<QuerySingleReportResponse> QuerySingleReportAsync(string instanceId, QuerySingleReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QuerySingleReportWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data overview.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySyncReportAggregationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySyncReportAggregationResponse
        /// </returns>
        public QuerySyncReportAggregationResponse QuerySyncReportAggregationWithOptions(string instanceId, QuerySyncReportAggregationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QuerySyncReportAggregation",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sync-reports/aggregation",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySyncReportAggregationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data overview.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySyncReportAggregationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySyncReportAggregationResponse
        /// </returns>
        public async Task<QuerySyncReportAggregationResponse> QuerySyncReportAggregationWithOptionsAsync(string instanceId, QuerySyncReportAggregationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QuerySyncReportAggregation",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/sync-reports/aggregation",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySyncReportAggregationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data overview.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySyncReportAggregationRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySyncReportAggregationResponse
        /// </returns>
        public QuerySyncReportAggregationResponse QuerySyncReportAggregation(string instanceId, QuerySyncReportAggregationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QuerySyncReportAggregationWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data overview.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySyncReportAggregationRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySyncReportAggregationResponse
        /// </returns>
        public async Task<QuerySyncReportAggregationResponse> QuerySyncReportAggregationAsync(string instanceId, QuerySyncReportAggregationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QuerySyncReportAggregationWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rebuilds an index.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebuildIndexResponse
        /// </returns>
        public RebuildIndexResponse RebuildIndexWithOptions(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebuildIndex",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/actions/rebuild",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebuildIndexResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rebuilds an index.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebuildIndexResponse
        /// </returns>
        public async Task<RebuildIndexResponse> RebuildIndexWithOptionsAsync(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RebuildIndex",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/actions/rebuild",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebuildIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rebuilds an index.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RebuildIndexResponse
        /// </returns>
        public RebuildIndexResponse RebuildIndex(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RebuildIndexWithOptions(instanceId, algorithmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rebuilds an index.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RebuildIndexResponse
        /// </returns>
        public async Task<RebuildIndexResponse> RebuildIndexAsync(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RebuildIndexWithOptionsAsync(instanceId, algorithmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The type of the recommendation service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecommendRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecommendResponse
        /// </returns>
        public RecommendResponse RecommendWithOptions(string instanceId, RecommendRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                query["imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                query["items"] = request.Items;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankOpen))
            {
                query["rankOpen"] = request.RankOpen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecType))
            {
                query["recType"] = request.RecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnCount))
            {
                query["returnCount"] = request.ReturnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                query["strategy"] = request.Strategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfo))
            {
                query["userInfo"] = request.UserInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Recommend",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/recommend",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecommendResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The type of the recommendation service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecommendRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecommendResponse
        /// </returns>
        public async Task<RecommendResponse> RecommendWithOptionsAsync(string instanceId, RecommendRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                query["imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                query["items"] = request.Items;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankOpen))
            {
                query["rankOpen"] = request.RankOpen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecType))
            {
                query["recType"] = request.RecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnCount))
            {
                query["returnCount"] = request.ReturnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["sceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["serviceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                query["strategy"] = request.Strategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfo))
            {
                query["userInfo"] = request.UserInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Recommend",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/recommend",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecommendResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The type of the recommendation service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecommendRequest
        /// </param>
        /// 
        /// <returns>
        /// RecommendResponse
        /// </returns>
        public RecommendResponse Recommend(string instanceId, RecommendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecommendWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The type of the recommendation service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecommendRequest
        /// </param>
        /// 
        /// <returns>
        /// RecommendResponse
        /// </returns>
        public async Task<RecommendResponse> RecommendAsync(string instanceId, RecommendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecommendWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Refreshes a feature table based on the source table in MaxCompute. The refresh policy is subject to data in the source table.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshFeatureTableResponse
        /// </returns>
        public RefreshFeatureTableResponse RefreshFeatureTableWithOptions(string instanceId, string type, string featureTableId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshFeatureTable",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/feature-tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(featureTableId) + "/actions/refresh",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshFeatureTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Refreshes a feature table based on the source table in MaxCompute. The refresh policy is subject to data in the source table.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefreshFeatureTableResponse
        /// </returns>
        public async Task<RefreshFeatureTableResponse> RefreshFeatureTableWithOptionsAsync(string instanceId, string type, string featureTableId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshFeatureTable",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/feature-tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(type) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(featureTableId) + "/actions/refresh",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshFeatureTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Refreshes a feature table based on the source table in MaxCompute. The refresh policy is subject to data in the source table.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RefreshFeatureTableResponse
        /// </returns>
        public RefreshFeatureTableResponse RefreshFeatureTable(string instanceId, string type, string featureTableId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RefreshFeatureTableWithOptions(instanceId, type, featureTableId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Refreshes a feature table based on the source table in MaxCompute. The refresh policy is subject to data in the source table.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RefreshFeatureTableResponse
        /// </returns>
        public async Task<RefreshFeatureTableResponse> RefreshFeatureTableAsync(string instanceId, string type, string featureTableId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RefreshFeatureTableWithOptionsAsync(instanceId, type, featureTableId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚某个排序服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackRankingSystemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackRankingSystemResponse
        /// </returns>
        public RollbackRankingSystemResponse RollbackRankingSystemWithOptions(string instanceId, string name, RollbackRankingSystemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/actions/rollback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackRankingSystemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚某个排序服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackRankingSystemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackRankingSystemResponse
        /// </returns>
        public async Task<RollbackRankingSystemResponse> RollbackRankingSystemWithOptionsAsync(string instanceId, string name, RollbackRankingSystemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/actions/rollback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackRankingSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚某个排序服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackRankingSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackRankingSystemResponse
        /// </returns>
        public RollbackRankingSystemResponse RollbackRankingSystem(string instanceId, string name, RollbackRankingSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RollbackRankingSystemWithOptions(instanceId, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚某个排序服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackRankingSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackRankingSystemResponse
        /// </returns>
        public async Task<RollbackRankingSystemResponse> RollbackRankingSystemAsync(string instanceId, string name, RollbackRankingSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RollbackRankingSystemWithOptionsAsync(instanceId, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs an instance to start a full data import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to run an instance to start a full data import task. After you call this API operation, the system creates a dataset. Then, the system imports all data from your data sources into the dataset for data training.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunInstanceResponse
        /// </returns>
        public RunInstanceResponse RunInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs an instance to start a full data import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to run an instance to start a full data import task. After you call this API operation, the system creates a dataset. Then, the system imports all data from your data sources into the dataset for data training.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunInstanceResponse
        /// </returns>
        public async Task<RunInstanceResponse> RunInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs an instance to start a full data import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to run an instance to start a full data import task. After you call this API operation, the system creates a dataset. Then, the system imports all data from your data sources into the dataset for data training.</para>
        /// </description>
        /// 
        /// <returns>
        /// RunInstanceResponse
        /// </returns>
        public RunInstanceResponse RunInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunInstanceWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs an instance to start a full data import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to run an instance to start a full data import task. After you call this API operation, the system creates a dataset. Then, the system imports all data from your data sources into the dataset for data training.</para>
        /// </description>
        /// 
        /// <returns>
        /// RunInstanceResponse
        /// </returns>
        public async Task<RunInstanceResponse> RunInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动模型训练</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunRankingModelTemplateResponse
        /// </returns>
        public RunRankingModelTemplateResponse RunRankingModelTemplateWithOptions(string instanceId, string templateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunRankingModelTemplate",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateId) + "/actions/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunRankingModelTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动模型训练</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunRankingModelTemplateResponse
        /// </returns>
        public async Task<RunRankingModelTemplateResponse> RunRankingModelTemplateWithOptionsAsync(string instanceId, string templateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunRankingModelTemplate",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-model-templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(templateId) + "/actions/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunRankingModelTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动模型训练</para>
        /// </summary>
        /// 
        /// <returns>
        /// RunRankingModelTemplateResponse
        /// </returns>
        public RunRankingModelTemplateResponse RunRankingModelTemplate(string instanceId, string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunRankingModelTemplateWithOptions(instanceId, templateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>启动模型训练</para>
        /// </summary>
        /// 
        /// <returns>
        /// RunRankingModelTemplateResponse
        /// </returns>
        public async Task<RunRankingModelTemplateResponse> RunRankingModelTemplateAsync(string instanceId, string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunRankingModelTemplateWithOptionsAsync(instanceId, templateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers sample formatting configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSampleFormatConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSampleFormatConfigResponse
        /// </returns>
        public RunSampleFormatConfigResponse RunSampleFormatConfigWithOptions(string instanceId, string sampleId, RunSampleFormatConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["mode"] = request.Mode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSampleFormatConfig",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId) + "/format-configs/actions/run",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSampleFormatConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers sample formatting configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSampleFormatConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSampleFormatConfigResponse
        /// </returns>
        public async Task<RunSampleFormatConfigResponse> RunSampleFormatConfigWithOptionsAsync(string instanceId, string sampleId, RunSampleFormatConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["mode"] = request.Mode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSampleFormatConfig",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/samples/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sampleId) + "/format-configs/actions/run",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSampleFormatConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers sample formatting configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSampleFormatConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSampleFormatConfigResponse
        /// </returns>
        public RunSampleFormatConfigResponse RunSampleFormatConfig(string instanceId, string sampleId, RunSampleFormatConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunSampleFormatConfigWithOptions(instanceId, sampleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers sample formatting configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSampleFormatConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSampleFormatConfigResponse
        /// </returns>
        public async Task<RunSampleFormatConfigResponse> RunSampleFormatConfigAsync(string instanceId, string sampleId, RunSampleFormatConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunSampleFormatConfigWithOptionsAsync(instanceId, sampleId, request, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDataSetResponse
        /// </returns>
        public StopDataSetResponse StopDataSetWithOptions(string instanceId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDataSet",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId) + "/actions/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDataSetResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDataSetResponse
        /// </returns>
        public async Task<StopDataSetResponse> StopDataSetWithOptionsAsync(string instanceId, string versionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopDataSet",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/dataSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionId) + "/actions/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// StopDataSetResponse
        /// </returns>
        public StopDataSetResponse StopDataSet(string instanceId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopDataSetWithOptions(instanceId, versionId, headers, runtime);
        }

        /// <returns>
        /// StopDataSetResponse
        /// </returns>
        public async Task<StopDataSetResponse> StopDataSetAsync(string instanceId, string versionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopDataSetWithOptionsAsync(instanceId, versionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止流调任务接口</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopFlowControlTaskResponse
        /// </returns>
        public StopFlowControlTaskResponse StopFlowControlTaskWithOptions(string instanceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/actions/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopFlowControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止流调任务接口</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopFlowControlTaskResponse
        /// </returns>
        public async Task<StopFlowControlTaskResponse> StopFlowControlTaskWithOptionsAsync(string instanceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopFlowControlTask",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/flowControlTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/actions/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopFlowControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止流调任务接口</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopFlowControlTaskResponse
        /// </returns>
        public StopFlowControlTaskResponse StopFlowControlTask(string instanceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopFlowControlTaskWithOptions(instanceId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止流调任务接口</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopFlowControlTaskResponse
        /// </returns>
        public async Task<StopFlowControlTaskResponse> StopFlowControlTaskAsync(string instanceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopFlowControlTaskWithOptionsAsync(instanceId, taskId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnLockIndexVersionResponse
        /// </returns>
        public UnLockIndexVersionResponse UnLockIndexVersionWithOptions(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnLockIndexVersion",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/actions/unlock",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnLockIndexVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnLockIndexVersionResponse
        /// </returns>
        public async Task<UnLockIndexVersionResponse> UnLockIndexVersionWithOptionsAsync(string instanceId, string algorithmId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnLockIndexVersion",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/filtering-algorithms/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(algorithmId) + "/actions/unlock",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnLockIndexVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// UnLockIndexVersionResponse
        /// </returns>
        public UnLockIndexVersionResponse UnLockIndexVersion(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnLockIndexVersionWithOptions(instanceId, algorithmId, headers, runtime);
        }

        /// <returns>
        /// UnLockIndexVersionResponse
        /// </returns>
        public async Task<UnLockIndexVersionResponse> UnLockIndexVersionAsync(string instanceId, string algorithmId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnLockIndexVersionWithOptionsAsync(instanceId, algorithmId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the basic information about an experiment.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentBasicInfoResponse
        /// </returns>
        public UpdateExperimentBasicInfoResponse UpdateExperimentBasicInfoWithOptions(string instanceId, string sceneId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentBasicInfo",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId) + "/basic",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentBasicInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the basic information about an experiment.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentBasicInfoResponse
        /// </returns>
        public async Task<UpdateExperimentBasicInfoResponse> UpdateExperimentBasicInfoWithOptionsAsync(string instanceId, string sceneId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentBasicInfo",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId) + "/basic",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentBasicInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the basic information about an experiment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// UpdateExperimentBasicInfoResponse
        /// </returns>
        public UpdateExperimentBasicInfoResponse UpdateExperimentBasicInfo(string instanceId, string sceneId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentBasicInfoWithOptions(instanceId, sceneId, experimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the basic information about an experiment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// UpdateExperimentBasicInfoResponse
        /// </returns>
        public async Task<UpdateExperimentBasicInfoResponse> UpdateExperimentBasicInfoAsync(string instanceId, string sceneId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentBasicInfoWithOptionsAsync(instanceId, sceneId, experimentId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentConfigResponse
        /// </returns>
        public UpdateExperimentConfigResponse UpdateExperimentConfigWithOptions(string instanceId, string sceneId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentConfig",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId) + "/config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentConfigResponse
        /// </returns>
        public async Task<UpdateExperimentConfigResponse> UpdateExperimentConfigWithOptionsAsync(string instanceId, string sceneId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentConfig",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId) + "/config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// UpdateExperimentConfigResponse
        /// </returns>
        public UpdateExperimentConfigResponse UpdateExperimentConfig(string instanceId, string sceneId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentConfigWithOptions(instanceId, sceneId, experimentId, headers, runtime);
        }

        /// <returns>
        /// UpdateExperimentConfigResponse
        /// </returns>
        public async Task<UpdateExperimentConfigResponse> UpdateExperimentConfigAsync(string instanceId, string sceneId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentConfigWithOptionsAsync(instanceId, sceneId, experimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the state of an experiment.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentStatusResponse
        /// </returns>
        public UpdateExperimentStatusResponse UpdateExperimentStatusWithOptions(string instanceId, string sceneId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentStatus",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId) + "/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the state of an experiment.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentStatusResponse
        /// </returns>
        public async Task<UpdateExperimentStatusResponse> UpdateExperimentStatusWithOptionsAsync(string instanceId, string sceneId, string experimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentStatus",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sceneId) + "/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(experimentId) + "/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the state of an experiment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// UpdateExperimentStatusResponse
        /// </returns>
        public UpdateExperimentStatusResponse UpdateExperimentStatus(string instanceId, string sceneId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentStatusWithOptions(instanceId, sceneId, experimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the state of an experiment.</para>
        /// </summary>
        /// 
        /// <returns>
        /// UpdateExperimentStatusResponse
        /// </returns>
        public async Task<UpdateExperimentStatusResponse> UpdateExperimentStatusAsync(string instanceId, string sceneId, string experimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentStatusWithOptionsAsync(instanceId, sceneId, experimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the quotas of a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the quotas of a specified instance.
        /// The limits on the number of users: 1,000,000 to 10,000,000. The limits on the number of items: 1,000,000 to 10,000,000. The limits on the queries per second (QPS) for recommendation requests: 10 to 500.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeInstanceResponse
        /// </returns>
        public UpgradeInstanceResponse UpgradeInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the quotas of a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the quotas of a specified instance.
        /// The limits on the number of users: 1,000,000 to 10,000,000. The limits on the number of items: 1,000,000 to 10,000,000. The limits on the queries per second (QPS) for recommendation requests: 10 to 500.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeInstanceResponse
        /// </returns>
        public async Task<UpgradeInstanceResponse> UpgradeInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the quotas of a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the quotas of a specified instance.
        /// The limits on the number of users: 1,000,000 to 10,000,000. The limits on the number of items: 1,000,000 to 10,000,000. The limits on the queries per second (QPS) for recommendation requests: 10 to 500.</para>
        /// </description>
        /// 
        /// <returns>
        /// UpgradeInstanceResponse
        /// </returns>
        public UpgradeInstanceResponse UpgradeInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeInstanceWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the quotas of a specified instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the quotas of a specified instance.
        /// The limits on the number of users: 1,000,000 to 10,000,000. The limits on the number of items: 1,000,000 to 10,000,000. The limits on the queries per second (QPS) for recommendation requests: 10 to 500.</para>
        /// </description>
        /// 
        /// <returns>
        /// UpgradeInstanceResponse
        /// </returns>
        public async Task<UpgradeInstanceResponse> UpgradeInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateInstanceResponse
        /// </returns>
        public ValidateInstanceResponse ValidateInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/validate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateInstanceResponse
        /// </returns>
        public async Task<ValidateInstanceResponse> ValidateInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateInstance",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/actions/validate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// ValidateInstanceResponse
        /// </returns>
        public ValidateInstanceResponse ValidateInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ValidateInstanceWithOptions(instanceId, headers, runtime);
        }

        /// <returns>
        /// ValidateInstanceResponse
        /// </returns>
        public async Task<ValidateInstanceResponse> ValidateInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ValidateInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试排序服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyRankingSystemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyRankingSystemResponse
        /// </returns>
        public VerifyRankingSystemResponse VerifyRankingSystemWithOptions(string instanceId, string name, VerifyRankingSystemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/actions/verify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyRankingSystemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试排序服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyRankingSystemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyRankingSystemResponse
        /// </returns>
        public async Task<VerifyRankingSystemResponse> VerifyRankingSystemWithOptionsAsync(string instanceId, string name, VerifyRankingSystemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Body))
            {
                body["body"] = request.Body;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyRankingSystem",
                Version = "2020-11-26",
                Protocol = "HTTPS",
                Pathname = "/v2/openapi/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ranking-systems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/actions/verify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyRankingSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试排序服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyRankingSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyRankingSystemResponse
        /// </returns>
        public VerifyRankingSystemResponse VerifyRankingSystem(string instanceId, string name, VerifyRankingSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VerifyRankingSystemWithOptions(instanceId, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调试排序服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyRankingSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyRankingSystemResponse
        /// </returns>
        public async Task<VerifyRankingSystemResponse> VerifyRankingSystemAsync(string instanceId, string name, VerifyRankingSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VerifyRankingSystemWithOptionsAsync(instanceId, name, request, headers, runtime);
        }

    }
}
