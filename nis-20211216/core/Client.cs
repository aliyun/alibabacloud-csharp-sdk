// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Nis20211216.Models;

namespace AlibabaCloud.SDK.Nis20211216
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-shanghai", "nis.aliyuncs.com"},
                {"ap-southeast-1", "nis-intl.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("nis", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Initiates a task for analyzing network reachability.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to initiate a task for analyzing network reachability by specifying only the information about the source and destination. You do not need to create a network path for reachability analysis. The analysis result is not recorded in the system. If you want to record the path parameters and analysis result in the Network Intelligence Service (NIS) console, we recommend that you call the <b>createNetworkReachableAnalysis</b> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAndAnalyzeNetworkPathRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndAnalyzeNetworkPathResponse
        /// </returns>
        public CreateAndAnalyzeNetworkPathResponse CreateAndAnalyzeNetworkPathWithOptions(CreateAndAnalyzeNetworkPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndAnalyzeNetworkPath",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndAnalyzeNetworkPathResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a task for analyzing network reachability.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to initiate a task for analyzing network reachability by specifying only the information about the source and destination. You do not need to create a network path for reachability analysis. The analysis result is not recorded in the system. If you want to record the path parameters and analysis result in the Network Intelligence Service (NIS) console, we recommend that you call the <b>createNetworkReachableAnalysis</b> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAndAnalyzeNetworkPathRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAndAnalyzeNetworkPathResponse
        /// </returns>
        public async Task<CreateAndAnalyzeNetworkPathResponse> CreateAndAnalyzeNetworkPathWithOptionsAsync(CreateAndAnalyzeNetworkPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAndAnalyzeNetworkPath",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAndAnalyzeNetworkPathResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a task for analyzing network reachability.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to initiate a task for analyzing network reachability by specifying only the information about the source and destination. You do not need to create a network path for reachability analysis. The analysis result is not recorded in the system. If you want to record the path parameters and analysis result in the Network Intelligence Service (NIS) console, we recommend that you call the <b>createNetworkReachableAnalysis</b> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAndAnalyzeNetworkPathRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndAnalyzeNetworkPathResponse
        /// </returns>
        public CreateAndAnalyzeNetworkPathResponse CreateAndAnalyzeNetworkPath(CreateAndAnalyzeNetworkPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAndAnalyzeNetworkPathWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a task for analyzing network reachability.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to initiate a task for analyzing network reachability by specifying only the information about the source and destination. You do not need to create a network path for reachability analysis. The analysis result is not recorded in the system. If you want to record the path parameters and analysis result in the Network Intelligence Service (NIS) console, we recommend that you call the <b>createNetworkReachableAnalysis</b> operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAndAnalyzeNetworkPathRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAndAnalyzeNetworkPathResponse
        /// </returns>
        public async Task<CreateAndAnalyzeNetworkPathResponse> CreateAndAnalyzeNetworkPathAsync(CreateAndAnalyzeNetworkPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAndAnalyzeNetworkPathWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a network path for reachability analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can call the <b>CreateNetworkPath</b> operation to create network paths in multiple networking scenarios and between multiple resources. After a path is created, the path parameters are saved for repeated analysis.</description></item>
        /// <item><description>You can create up to 100 network paths within one Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNetworkPathRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNetworkPathResponse
        /// </returns>
        public CreateNetworkPathResponse CreateNetworkPathWithOptions(CreateNetworkPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkPathDescription))
            {
                query["NetworkPathDescription"] = request.NetworkPathDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkPathName))
            {
                query["NetworkPathName"] = request.NetworkPathName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIpAddress))
            {
                query["SourceIpAddress"] = request.SourceIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePort))
            {
                query["SourcePort"] = request.SourcePort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIpAddress))
            {
                query["TargetIpAddress"] = request.TargetIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPort))
            {
                query["TargetPort"] = request.TargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNetworkPath",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNetworkPathResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a network path for reachability analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can call the <b>CreateNetworkPath</b> operation to create network paths in multiple networking scenarios and between multiple resources. After a path is created, the path parameters are saved for repeated analysis.</description></item>
        /// <item><description>You can create up to 100 network paths within one Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNetworkPathRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNetworkPathResponse
        /// </returns>
        public async Task<CreateNetworkPathResponse> CreateNetworkPathWithOptionsAsync(CreateNetworkPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkPathDescription))
            {
                query["NetworkPathDescription"] = request.NetworkPathDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkPathName))
            {
                query["NetworkPathName"] = request.NetworkPathName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIpAddress))
            {
                query["SourceIpAddress"] = request.SourceIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePort))
            {
                query["SourcePort"] = request.SourcePort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIpAddress))
            {
                query["TargetIpAddress"] = request.TargetIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPort))
            {
                query["TargetPort"] = request.TargetPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNetworkPath",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNetworkPathResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a network path for reachability analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can call the <b>CreateNetworkPath</b> operation to create network paths in multiple networking scenarios and between multiple resources. After a path is created, the path parameters are saved for repeated analysis.</description></item>
        /// <item><description>You can create up to 100 network paths within one Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNetworkPathRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNetworkPathResponse
        /// </returns>
        public CreateNetworkPathResponse CreateNetworkPath(CreateNetworkPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNetworkPathWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a network path for reachability analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can call the <b>CreateNetworkPath</b> operation to create network paths in multiple networking scenarios and between multiple resources. After a path is created, the path parameters are saved for repeated analysis.</description></item>
        /// <item><description>You can create up to 100 network paths within one Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNetworkPathRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNetworkPathResponse
        /// </returns>
        public async Task<CreateNetworkPathResponse> CreateNetworkPathAsync(CreateNetworkPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNetworkPathWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a task for analyzing network reachability.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The <b>CreateNetworkReachableAnalysis</b> operation is used to create a task for analyzing the reachability of the network path that is created by calling the <b>CreateNetworkPath</b> operation and record the analysis results.</description></item>
        /// <item><description>The <b>CreateNetworkReachableAnalysis</b> operation can be called to repeatedly analyze the reachability of a network path.</description></item>
        /// <item><description>You can create up to 1,000 reachability analysis records within one Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNetworkReachableAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNetworkReachableAnalysisResponse
        /// </returns>
        public CreateNetworkReachableAnalysisResponse CreateNetworkReachableAnalysisWithOptions(CreateNetworkReachableAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkPathId))
            {
                query["NetworkPathId"] = request.NetworkPathId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNetworkReachableAnalysis",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNetworkReachableAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a task for analyzing network reachability.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The <b>CreateNetworkReachableAnalysis</b> operation is used to create a task for analyzing the reachability of the network path that is created by calling the <b>CreateNetworkPath</b> operation and record the analysis results.</description></item>
        /// <item><description>The <b>CreateNetworkReachableAnalysis</b> operation can be called to repeatedly analyze the reachability of a network path.</description></item>
        /// <item><description>You can create up to 1,000 reachability analysis records within one Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNetworkReachableAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNetworkReachableAnalysisResponse
        /// </returns>
        public async Task<CreateNetworkReachableAnalysisResponse> CreateNetworkReachableAnalysisWithOptionsAsync(CreateNetworkReachableAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkPathId))
            {
                query["NetworkPathId"] = request.NetworkPathId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNetworkReachableAnalysis",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNetworkReachableAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a task for analyzing network reachability.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The <b>CreateNetworkReachableAnalysis</b> operation is used to create a task for analyzing the reachability of the network path that is created by calling the <b>CreateNetworkPath</b> operation and record the analysis results.</description></item>
        /// <item><description>The <b>CreateNetworkReachableAnalysis</b> operation can be called to repeatedly analyze the reachability of a network path.</description></item>
        /// <item><description>You can create up to 1,000 reachability analysis records within one Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNetworkReachableAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNetworkReachableAnalysisResponse
        /// </returns>
        public CreateNetworkReachableAnalysisResponse CreateNetworkReachableAnalysis(CreateNetworkReachableAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNetworkReachableAnalysisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a task for analyzing network reachability.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The <b>CreateNetworkReachableAnalysis</b> operation is used to create a task for analyzing the reachability of the network path that is created by calling the <b>CreateNetworkPath</b> operation and record the analysis results.</description></item>
        /// <item><description>The <b>CreateNetworkReachableAnalysis</b> operation can be called to repeatedly analyze the reachability of a network path.</description></item>
        /// <item><description>You can create up to 1,000 reachability analysis records within one Alibaba Cloud account.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNetworkReachableAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNetworkReachableAnalysisResponse
        /// </returns>
        public async Task<CreateNetworkReachableAnalysisResponse> CreateNetworkReachableAnalysisAsync(CreateNetworkReachableAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNetworkReachableAnalysisWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a network path.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteNetworkPathRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetworkPathResponse
        /// </returns>
        public DeleteNetworkPathResponse DeleteNetworkPathWithOptions(DeleteNetworkPathRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteNetworkPathShrinkRequest request = new DeleteNetworkPathShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkPathIds))
            {
                request.NetworkPathIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkPathIds, "NetworkPathIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkPathIdsShrink))
            {
                query["NetworkPathIds"] = request.NetworkPathIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNetworkPath",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNetworkPathResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a network path.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteNetworkPathRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetworkPathResponse
        /// </returns>
        public async Task<DeleteNetworkPathResponse> DeleteNetworkPathWithOptionsAsync(DeleteNetworkPathRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteNetworkPathShrinkRequest request = new DeleteNetworkPathShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkPathIds))
            {
                request.NetworkPathIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkPathIds, "NetworkPathIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkPathIdsShrink))
            {
                query["NetworkPathIds"] = request.NetworkPathIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNetworkPath",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNetworkPathResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a network path.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNetworkPathRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetworkPathResponse
        /// </returns>
        public DeleteNetworkPathResponse DeleteNetworkPath(DeleteNetworkPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNetworkPathWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a network path.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNetworkPathRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetworkPathResponse
        /// </returns>
        public async Task<DeleteNetworkPathResponse> DeleteNetworkPathAsync(DeleteNetworkPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNetworkPathWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a task for analyzing network reachability.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteNetworkReachableAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetworkReachableAnalysisResponse
        /// </returns>
        public DeleteNetworkReachableAnalysisResponse DeleteNetworkReachableAnalysisWithOptions(DeleteNetworkReachableAnalysisRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteNetworkReachableAnalysisShrinkRequest request = new DeleteNetworkReachableAnalysisShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkReachableAnalysisIds))
            {
                request.NetworkReachableAnalysisIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkReachableAnalysisIds, "NetworkReachableAnalysisIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkReachableAnalysisIdsShrink))
            {
                query["NetworkReachableAnalysisIds"] = request.NetworkReachableAnalysisIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNetworkReachableAnalysis",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNetworkReachableAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a task for analyzing network reachability.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteNetworkReachableAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetworkReachableAnalysisResponse
        /// </returns>
        public async Task<DeleteNetworkReachableAnalysisResponse> DeleteNetworkReachableAnalysisWithOptionsAsync(DeleteNetworkReachableAnalysisRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteNetworkReachableAnalysisShrinkRequest request = new DeleteNetworkReachableAnalysisShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkReachableAnalysisIds))
            {
                request.NetworkReachableAnalysisIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkReachableAnalysisIds, "NetworkReachableAnalysisIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkReachableAnalysisIdsShrink))
            {
                query["NetworkReachableAnalysisIds"] = request.NetworkReachableAnalysisIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNetworkReachableAnalysis",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNetworkReachableAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a task for analyzing network reachability.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNetworkReachableAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetworkReachableAnalysisResponse
        /// </returns>
        public DeleteNetworkReachableAnalysisResponse DeleteNetworkReachableAnalysis(DeleteNetworkReachableAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNetworkReachableAnalysisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a task for analyzing network reachability.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNetworkReachableAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetworkReachableAnalysisResponse
        /// </returns>
        public async Task<DeleteNetworkReachableAnalysisResponse> DeleteNetworkReachableAnalysisAsync(DeleteNetworkReachableAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNetworkReachableAnalysisWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNisInspectionReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNisInspectionReportResponse
        /// </returns>
        public DeleteNisInspectionReportResponse DeleteNisInspectionReportWithOptions(DeleteNisInspectionReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionReportId))
            {
                query["InspectionReportId"] = request.InspectionReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNisInspectionReport",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNisInspectionReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNisInspectionReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNisInspectionReportResponse
        /// </returns>
        public async Task<DeleteNisInspectionReportResponse> DeleteNisInspectionReportWithOptionsAsync(DeleteNisInspectionReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionReportId))
            {
                query["InspectionReportId"] = request.InspectionReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNisInspectionReport",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNisInspectionReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNisInspectionReportRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNisInspectionReportResponse
        /// </returns>
        public DeleteNisInspectionReportResponse DeleteNisInspectionReport(DeleteNisInspectionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNisInspectionReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNisInspectionReportRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNisInspectionReportResponse
        /// </returns>
        public async Task<DeleteNisInspectionReportResponse> DeleteNisInspectionReportAsync(DeleteNisInspectionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNisInspectionReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNisInspectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNisInspectionTaskResponse
        /// </returns>
        public DeleteNisInspectionTaskResponse DeleteNisInspectionTaskWithOptions(DeleteNisInspectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionTaskId))
            {
                query["InspectionTaskId"] = request.InspectionTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNisInspectionTask",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNisInspectionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNisInspectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNisInspectionTaskResponse
        /// </returns>
        public async Task<DeleteNisInspectionTaskResponse> DeleteNisInspectionTaskWithOptionsAsync(DeleteNisInspectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionTaskId))
            {
                query["InspectionTaskId"] = request.InspectionTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNisInspectionTask",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNisInspectionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNisInspectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNisInspectionTaskResponse
        /// </returns>
        public DeleteNisInspectionTaskResponse DeleteNisInspectionTask(DeleteNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNisInspectionTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNisInspectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNisInspectionTaskResponse
        /// </returns>
        public async Task<DeleteNisInspectionTaskResponse> DeleteNisInspectionTaskAsync(DeleteNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNisInspectionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the instances of abnormal items identified in an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionRecommendationResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionRecommendationResourcesResponse
        /// </returns>
        public DescribeNisInspectionRecommendationResourcesResponse DescribeNisInspectionRecommendationResourcesWithOptions(DescribeNisInspectionRecommendationResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionReportId))
            {
                query["InspectionReportId"] = request.InspectionReportId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendationCode))
            {
                query["RecommendationCode"] = request.RecommendationCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNisInspectionRecommendationResources",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNisInspectionRecommendationResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the instances of abnormal items identified in an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionRecommendationResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionRecommendationResourcesResponse
        /// </returns>
        public async Task<DescribeNisInspectionRecommendationResourcesResponse> DescribeNisInspectionRecommendationResourcesWithOptionsAsync(DescribeNisInspectionRecommendationResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionReportId))
            {
                query["InspectionReportId"] = request.InspectionReportId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendationCode))
            {
                query["RecommendationCode"] = request.RecommendationCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNisInspectionRecommendationResources",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNisInspectionRecommendationResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the instances of abnormal items identified in an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionRecommendationResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionRecommendationResourcesResponse
        /// </returns>
        public DescribeNisInspectionRecommendationResourcesResponse DescribeNisInspectionRecommendationResources(DescribeNisInspectionRecommendationResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNisInspectionRecommendationResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the instances of abnormal items identified in an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionRecommendationResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionRecommendationResourcesResponse
        /// </returns>
        public async Task<DescribeNisInspectionRecommendationResourcesResponse> DescribeNisInspectionRecommendationResourcesAsync(DescribeNisInspectionRecommendationResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNisInspectionRecommendationResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes the details of check items in an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeNisInspectionReportCheckItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionReportCheckItemsResponse
        /// </returns>
        public DescribeNisInspectionReportCheckItemsResponse DescribeNisInspectionReportCheckItemsWithOptions(DescribeNisInspectionReportCheckItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeNisInspectionReportCheckItemsShrinkRequest request = new DescribeNisInspectionReportCheckItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceType))
            {
                request.ResourceTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceType, "ResourceType", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RiskLevel))
            {
                request.RiskLevelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RiskLevel, "RiskLevel", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryCode))
            {
                query["CategoryCode"] = request.CategoryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionReportId))
            {
                query["InspectionReportId"] = request.InspectionReportId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeShrink))
            {
                query["ResourceType"] = request.ResourceTypeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelShrink))
            {
                query["RiskLevel"] = request.RiskLevelShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNisInspectionReportCheckItems",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNisInspectionReportCheckItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes the details of check items in an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeNisInspectionReportCheckItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionReportCheckItemsResponse
        /// </returns>
        public async Task<DescribeNisInspectionReportCheckItemsResponse> DescribeNisInspectionReportCheckItemsWithOptionsAsync(DescribeNisInspectionReportCheckItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeNisInspectionReportCheckItemsShrinkRequest request = new DescribeNisInspectionReportCheckItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceType))
            {
                request.ResourceTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceType, "ResourceType", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RiskLevel))
            {
                request.RiskLevelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RiskLevel, "RiskLevel", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryCode))
            {
                query["CategoryCode"] = request.CategoryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionReportId))
            {
                query["InspectionReportId"] = request.InspectionReportId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeShrink))
            {
                query["ResourceType"] = request.ResourceTypeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelShrink))
            {
                query["RiskLevel"] = request.RiskLevelShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNisInspectionReportCheckItems",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNisInspectionReportCheckItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes the details of check items in an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionReportCheckItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionReportCheckItemsResponse
        /// </returns>
        public DescribeNisInspectionReportCheckItemsResponse DescribeNisInspectionReportCheckItems(DescribeNisInspectionReportCheckItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNisInspectionReportCheckItemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes the details of check items in an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionReportCheckItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionReportCheckItemsResponse
        /// </returns>
        public async Task<DescribeNisInspectionReportCheckItemsResponse> DescribeNisInspectionReportCheckItemsAsync(DescribeNisInspectionReportCheckItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNisInspectionReportCheckItemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes the status of an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionReportStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionReportStatusResponse
        /// </returns>
        public DescribeNisInspectionReportStatusResponse DescribeNisInspectionReportStatusWithOptions(DescribeNisInspectionReportStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionReportId))
            {
                query["InspectionReportId"] = request.InspectionReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNisInspectionReportStatus",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNisInspectionReportStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes the status of an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionReportStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionReportStatusResponse
        /// </returns>
        public async Task<DescribeNisInspectionReportStatusResponse> DescribeNisInspectionReportStatusWithOptionsAsync(DescribeNisInspectionReportStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionReportId))
            {
                query["InspectionReportId"] = request.InspectionReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNisInspectionReportStatus",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNisInspectionReportStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes the status of an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionReportStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionReportStatusResponse
        /// </returns>
        public DescribeNisInspectionReportStatusResponse DescribeNisInspectionReportStatus(DescribeNisInspectionReportStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNisInspectionReportStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describes the status of an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionReportStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionReportStatusResponse
        /// </returns>
        public async Task<DescribeNisInspectionReportStatusResponse> DescribeNisInspectionReportStatusAsync(DescribeNisInspectionReportStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNisInspectionReportStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an inspection report summary.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionReportSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionReportSummaryResponse
        /// </returns>
        public DescribeNisInspectionReportSummaryResponse DescribeNisInspectionReportSummaryWithOptions(DescribeNisInspectionReportSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionReportId))
            {
                query["InspectionReportId"] = request.InspectionReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNisInspectionReportSummary",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNisInspectionReportSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an inspection report summary.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionReportSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionReportSummaryResponse
        /// </returns>
        public async Task<DescribeNisInspectionReportSummaryResponse> DescribeNisInspectionReportSummaryWithOptionsAsync(DescribeNisInspectionReportSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionReportId))
            {
                query["InspectionReportId"] = request.InspectionReportId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNisInspectionReportSummary",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNisInspectionReportSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an inspection report summary.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionReportSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionReportSummaryResponse
        /// </returns>
        public DescribeNisInspectionReportSummaryResponse DescribeNisInspectionReportSummary(DescribeNisInspectionReportSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNisInspectionReportSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an inspection report summary.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionReportSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionReportSummaryResponse
        /// </returns>
        public async Task<DescribeNisInspectionReportSummaryResponse> DescribeNisInspectionReportSummaryAsync(DescribeNisInspectionReportSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNisInspectionReportSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionTaskResponse
        /// </returns>
        public DescribeNisInspectionTaskResponse DescribeNisInspectionTaskWithOptions(DescribeNisInspectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionTaskId))
            {
                query["InspectionTaskId"] = request.InspectionTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNisInspectionTask",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNisInspectionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionTaskResponse
        /// </returns>
        public async Task<DescribeNisInspectionTaskResponse> DescribeNisInspectionTaskWithOptionsAsync(DescribeNisInspectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionTaskId))
            {
                query["InspectionTaskId"] = request.InspectionTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNisInspectionTask",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNisInspectionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionTaskResponse
        /// </returns>
        public DescribeNisInspectionTaskResponse DescribeNisInspectionTask(DescribeNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNisInspectionTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNisInspectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisInspectionTaskResponse
        /// </returns>
        public async Task<DescribeNisInspectionTaskResponse> DescribeNisInspectionTaskAsync(DescribeNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNisInspectionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of NIS traffic ranking analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><a href="https://www.alibabacloud.com/help/en/nis/product-overview/billing-method-new-version">Before using this operation, make sure that you fully understand the billing method and pricing of the NIS Traffic Analyzer.</a>
        /// Supported analysis scenarios: </para>
        /// <list type="bullet">
        /// <item><description>All VPC network traffic analysis</description></item>
        /// <item><description>Public VPC network traffic analysis</description></item>
        /// <item><description>All TR network traffic analysis</description></item>
        /// <item><description>Internet Shared Bandwidth metric analysis</description></item>
        /// </list>
        /// <h2>VPC flow log - All VPC flow log query and analysis results</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionId</td>
        /// <td>string</td>
        /// <td>The region where the flow log resides.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VpcId</td>
        /// <td>string</td>
        /// <td>The VPC ID.</td>
        /// <td>vpc-m5ec6i0h5xss***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID.</td>
        /// <td>vsw-2zeekevlh****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NetworkInterfaceId</td>
        /// <td>string</td>
        /// <td>The elastic network interface (ENI) ID.</td>
        /// <td>eni-8vbf2jxul***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>EcsId</td>
        /// <td>string</td>
        /// <td>The ECS instance ID of the management node.</td>
        /// <td>i-uf6i1zi6yhq7h***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TrafficPath</td>
        /// <td>string</td>
        /// <td>The traffic path.</td>
        /// <td>all</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RoundTripTime</td>
        /// <td>number</td>
        /// <td>The TCP RTT.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>VPC flow log - Public VPC flow log query and analysis results</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionId</td>
        /// <td>string</td>
        /// <td>The region where the flow log resides.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VpcId</td>
        /// <td>string</td>
        /// <td>The VPC ID.</td>
        /// <td>vpc-m5ec6i0h5xss***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID.</td>
        /// <td>vsw-2zeekevlh****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NetworkInterfaceId</td>
        /// <td>string</td>
        /// <td>The elastic network interface (ENI) ID.</td>
        /// <td>eni-8vbf2jxul***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>EcsId</td>
        /// <td>string</td>
        /// <td>The ECS instance ID of the management node.</td>
        /// <td>i-uf6i1zi6yhq7h***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TrafficPath</td>
        /// <td>string</td>
        /// <td>The traffic path.</td>
        /// <td>all</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientCountry</td>
        /// <td>string</td>
        /// <td>The country of the client.</td>
        /// <td>China</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientProvince</td>
        /// <td>string</td>
        /// <td>The province of the client.</td>
        /// <td>Hong Kong SAR</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientCity</td>
        /// <td>string</td>
        /// <td>The city of the client.</td>
        /// <td>Kowloon</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientIsp</td>
        /// <td>string</td>
        /// <td>The network service provider.</td>
        /// <td>Alibaba Cloud</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientAsn</td>
        /// <td>string</td>
        /// <td>The autonomous system number.</td>
        /// <td>45102</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RoundTripTime</td>
        /// <td>number</td>
        /// <td>The TCP RTT.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - TR cross-region scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dscp</td>
        /// <td>string</td>
        /// <td>The Differentiated Services Code Point (DSCP) value.</td>
        /// <td>0</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationRegionNo</td>
        /// <td>string</td>
        /// <td>The destination region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceRegionNo</td>
        /// <td>string</td>
        /// <td>The source region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterAttachmentId</td>
        /// <td>string</td>
        /// <td>The network instance connection ID.</td>
        /// <td>tr-attach-bfde1cd4cj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterId</td>
        /// <td>string</td>
        /// <td>The transit router instance ID.</td>
        /// <td>tr-2zefvwy2fz3444***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterPairAttachmentId</td>
        /// <td>string</td>
        /// <td>The transit router peering connection instance ID.</td>
        /// <td>tr-attach-okvj1cd4cjp***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostNoRoute</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to no route.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostBlackhole</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to blackhole routes.</td>
        /// <td>4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostTTLExpired</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to TTL expiration.</td>
        /// <td>7</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - VPC connection traffic scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dscp</td>
        /// <td>string</td>
        /// <td>The Differentiated Services Code Point (DSCP) value.</td>
        /// <td>0</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationRegionNo</td>
        /// <td>string</td>
        /// <td>The destination region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceRegionNo</td>
        /// <td>string</td>
        /// <td>The source region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterAttachmentId</td>
        /// <td>string</td>
        /// <td>The network instance connection ID.</td>
        /// <td>tr-attach-bfde1cd4cj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterId</td>
        /// <td>string</td>
        /// <td>The transit router instance ID.</td>
        /// <td>tr-2zefvwy2fz3444***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterPairAttachmentId</td>
        /// <td>string</td>
        /// <td>The transit router peering connection instance ID.</td>
        /// <td>tr-attach-okvj1cd4cjp***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceResourceId</td>
        /// <td>string</td>
        /// <td>The source network instance ID.</td>
        /// <td>tr-attach-hvve1cd4cjpj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the source network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceVSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID of the source TR ENI.</td>
        /// <td>vsw-ikfdkevlhxpqxuz****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceNetworkInterface</td>
        /// <td>string</td>
        /// <td>The source TR ENI.</td>
        /// <td>eni-8vbf2jxulma***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceAvailableZone</td>
        /// <td>string</td>
        /// <td>The source zone ID.</td>
        /// <td>ap-southeast-1-j</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationResourceId</td>
        /// <td>string</td>
        /// <td>The destination network instance ID.</td>
        /// <td>tr-attach-bfve1cd4cjp****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the destination network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationVSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID of the destination TR ENI.</td>
        /// <td>vsw-ikfdkevlhxpqxuz****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationNetworkInterface</td>
        /// <td>string</td>
        /// <td>The destination TR ENI.</td>
        /// <td>eni-7kcf2jxulma***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationAvailableZone</td>
        /// <td>string</td>
        /// <td>The destination zone ID.</td>
        /// <td>ap-southeast-1-j</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostNoRoute</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to no route.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostBlackhole</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to blackhole routes.</td>
        /// <td>4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostTTLExpired</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to TTL expiration.</td>
        /// <td>7</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - VBR traffic scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dscp</td>
        /// <td>string</td>
        /// <td>The Differentiated Services Code Point (DSCP) value.</td>
        /// <td>0</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationRegionNo</td>
        /// <td>string</td>
        /// <td>The destination region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceRegionNo</td>
        /// <td>string</td>
        /// <td>The source region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterAttachmentId</td>
        /// <td>string</td>
        /// <td>The network instance connection ID.</td>
        /// <td>tr-attach-bfde1cd4cj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterId</td>
        /// <td>string</td>
        /// <td>The transit router instance ID.</td>
        /// <td>tr-2zefvwy2fz3444***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterPairAttachmentId</td>
        /// <td>string</td>
        /// <td>The transit router peering connection instance ID.</td>
        /// <td>tr-attach-okvj1cd4cjp***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceResourceId</td>
        /// <td>string</td>
        /// <td>The source network instance ID.</td>
        /// <td>tr-attach-hvve1cd4cjpj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the source network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationResourceId</td>
        /// <td>string</td>
        /// <td>The destination network instance ID.</td>
        /// <td>tr-attach-bfve1cd4cjp****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the destination network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostNoRoute</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to no route.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostBlackhole</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to blackhole routes.</td>
        /// <td>4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostTTLExpired</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to TTL expiration.</td>
        /// <td>7</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - ECR traffic scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeNisTrafficRankingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisTrafficRankingResponse
        /// </returns>
        public DescribeNisTrafficRankingResponse DescribeNisTrafficRankingWithOptions(DescribeNisTrafficRankingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NisTrafficRankingId))
            {
                query["NisTrafficRankingId"] = request.NisTrafficRankingId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNisTrafficRanking",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNisTrafficRankingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of NIS traffic ranking analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><a href="https://www.alibabacloud.com/help/en/nis/product-overview/billing-method-new-version">Before using this operation, make sure that you fully understand the billing method and pricing of the NIS Traffic Analyzer.</a>
        /// Supported analysis scenarios: </para>
        /// <list type="bullet">
        /// <item><description>All VPC network traffic analysis</description></item>
        /// <item><description>Public VPC network traffic analysis</description></item>
        /// <item><description>All TR network traffic analysis</description></item>
        /// <item><description>Internet Shared Bandwidth metric analysis</description></item>
        /// </list>
        /// <h2>VPC flow log - All VPC flow log query and analysis results</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionId</td>
        /// <td>string</td>
        /// <td>The region where the flow log resides.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VpcId</td>
        /// <td>string</td>
        /// <td>The VPC ID.</td>
        /// <td>vpc-m5ec6i0h5xss***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID.</td>
        /// <td>vsw-2zeekevlh****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NetworkInterfaceId</td>
        /// <td>string</td>
        /// <td>The elastic network interface (ENI) ID.</td>
        /// <td>eni-8vbf2jxul***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>EcsId</td>
        /// <td>string</td>
        /// <td>The ECS instance ID of the management node.</td>
        /// <td>i-uf6i1zi6yhq7h***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TrafficPath</td>
        /// <td>string</td>
        /// <td>The traffic path.</td>
        /// <td>all</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RoundTripTime</td>
        /// <td>number</td>
        /// <td>The TCP RTT.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>VPC flow log - Public VPC flow log query and analysis results</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionId</td>
        /// <td>string</td>
        /// <td>The region where the flow log resides.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VpcId</td>
        /// <td>string</td>
        /// <td>The VPC ID.</td>
        /// <td>vpc-m5ec6i0h5xss***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID.</td>
        /// <td>vsw-2zeekevlh****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NetworkInterfaceId</td>
        /// <td>string</td>
        /// <td>The elastic network interface (ENI) ID.</td>
        /// <td>eni-8vbf2jxul***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>EcsId</td>
        /// <td>string</td>
        /// <td>The ECS instance ID of the management node.</td>
        /// <td>i-uf6i1zi6yhq7h***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TrafficPath</td>
        /// <td>string</td>
        /// <td>The traffic path.</td>
        /// <td>all</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientCountry</td>
        /// <td>string</td>
        /// <td>The country of the client.</td>
        /// <td>China</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientProvince</td>
        /// <td>string</td>
        /// <td>The province of the client.</td>
        /// <td>Hong Kong SAR</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientCity</td>
        /// <td>string</td>
        /// <td>The city of the client.</td>
        /// <td>Kowloon</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientIsp</td>
        /// <td>string</td>
        /// <td>The network service provider.</td>
        /// <td>Alibaba Cloud</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientAsn</td>
        /// <td>string</td>
        /// <td>The autonomous system number.</td>
        /// <td>45102</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RoundTripTime</td>
        /// <td>number</td>
        /// <td>The TCP RTT.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - TR cross-region scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dscp</td>
        /// <td>string</td>
        /// <td>The Differentiated Services Code Point (DSCP) value.</td>
        /// <td>0</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationRegionNo</td>
        /// <td>string</td>
        /// <td>The destination region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceRegionNo</td>
        /// <td>string</td>
        /// <td>The source region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterAttachmentId</td>
        /// <td>string</td>
        /// <td>The network instance connection ID.</td>
        /// <td>tr-attach-bfde1cd4cj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterId</td>
        /// <td>string</td>
        /// <td>The transit router instance ID.</td>
        /// <td>tr-2zefvwy2fz3444***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterPairAttachmentId</td>
        /// <td>string</td>
        /// <td>The transit router peering connection instance ID.</td>
        /// <td>tr-attach-okvj1cd4cjp***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostNoRoute</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to no route.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostBlackhole</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to blackhole routes.</td>
        /// <td>4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostTTLExpired</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to TTL expiration.</td>
        /// <td>7</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - VPC connection traffic scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dscp</td>
        /// <td>string</td>
        /// <td>The Differentiated Services Code Point (DSCP) value.</td>
        /// <td>0</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationRegionNo</td>
        /// <td>string</td>
        /// <td>The destination region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceRegionNo</td>
        /// <td>string</td>
        /// <td>The source region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterAttachmentId</td>
        /// <td>string</td>
        /// <td>The network instance connection ID.</td>
        /// <td>tr-attach-bfde1cd4cj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterId</td>
        /// <td>string</td>
        /// <td>The transit router instance ID.</td>
        /// <td>tr-2zefvwy2fz3444***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterPairAttachmentId</td>
        /// <td>string</td>
        /// <td>The transit router peering connection instance ID.</td>
        /// <td>tr-attach-okvj1cd4cjp***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceResourceId</td>
        /// <td>string</td>
        /// <td>The source network instance ID.</td>
        /// <td>tr-attach-hvve1cd4cjpj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the source network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceVSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID of the source TR ENI.</td>
        /// <td>vsw-ikfdkevlhxpqxuz****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceNetworkInterface</td>
        /// <td>string</td>
        /// <td>The source TR ENI.</td>
        /// <td>eni-8vbf2jxulma***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceAvailableZone</td>
        /// <td>string</td>
        /// <td>The source zone ID.</td>
        /// <td>ap-southeast-1-j</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationResourceId</td>
        /// <td>string</td>
        /// <td>The destination network instance ID.</td>
        /// <td>tr-attach-bfve1cd4cjp****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the destination network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationVSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID of the destination TR ENI.</td>
        /// <td>vsw-ikfdkevlhxpqxuz****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationNetworkInterface</td>
        /// <td>string</td>
        /// <td>The destination TR ENI.</td>
        /// <td>eni-7kcf2jxulma***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationAvailableZone</td>
        /// <td>string</td>
        /// <td>The destination zone ID.</td>
        /// <td>ap-southeast-1-j</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostNoRoute</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to no route.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostBlackhole</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to blackhole routes.</td>
        /// <td>4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostTTLExpired</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to TTL expiration.</td>
        /// <td>7</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - VBR traffic scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dscp</td>
        /// <td>string</td>
        /// <td>The Differentiated Services Code Point (DSCP) value.</td>
        /// <td>0</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationRegionNo</td>
        /// <td>string</td>
        /// <td>The destination region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceRegionNo</td>
        /// <td>string</td>
        /// <td>The source region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterAttachmentId</td>
        /// <td>string</td>
        /// <td>The network instance connection ID.</td>
        /// <td>tr-attach-bfde1cd4cj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterId</td>
        /// <td>string</td>
        /// <td>The transit router instance ID.</td>
        /// <td>tr-2zefvwy2fz3444***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterPairAttachmentId</td>
        /// <td>string</td>
        /// <td>The transit router peering connection instance ID.</td>
        /// <td>tr-attach-okvj1cd4cjp***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceResourceId</td>
        /// <td>string</td>
        /// <td>The source network instance ID.</td>
        /// <td>tr-attach-hvve1cd4cjpj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the source network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationResourceId</td>
        /// <td>string</td>
        /// <td>The destination network instance ID.</td>
        /// <td>tr-attach-bfve1cd4cjp****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the destination network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostNoRoute</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to no route.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostBlackhole</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to blackhole routes.</td>
        /// <td>4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostTTLExpired</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to TTL expiration.</td>
        /// <td>7</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - ECR traffic scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeNisTrafficRankingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisTrafficRankingResponse
        /// </returns>
        public async Task<DescribeNisTrafficRankingResponse> DescribeNisTrafficRankingWithOptionsAsync(DescribeNisTrafficRankingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NisTrafficRankingId))
            {
                query["NisTrafficRankingId"] = request.NisTrafficRankingId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNisTrafficRanking",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNisTrafficRankingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of NIS traffic ranking analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><a href="https://www.alibabacloud.com/help/en/nis/product-overview/billing-method-new-version">Before using this operation, make sure that you fully understand the billing method and pricing of the NIS Traffic Analyzer.</a>
        /// Supported analysis scenarios: </para>
        /// <list type="bullet">
        /// <item><description>All VPC network traffic analysis</description></item>
        /// <item><description>Public VPC network traffic analysis</description></item>
        /// <item><description>All TR network traffic analysis</description></item>
        /// <item><description>Internet Shared Bandwidth metric analysis</description></item>
        /// </list>
        /// <h2>VPC flow log - All VPC flow log query and analysis results</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionId</td>
        /// <td>string</td>
        /// <td>The region where the flow log resides.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VpcId</td>
        /// <td>string</td>
        /// <td>The VPC ID.</td>
        /// <td>vpc-m5ec6i0h5xss***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID.</td>
        /// <td>vsw-2zeekevlh****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NetworkInterfaceId</td>
        /// <td>string</td>
        /// <td>The elastic network interface (ENI) ID.</td>
        /// <td>eni-8vbf2jxul***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>EcsId</td>
        /// <td>string</td>
        /// <td>The ECS instance ID of the management node.</td>
        /// <td>i-uf6i1zi6yhq7h***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TrafficPath</td>
        /// <td>string</td>
        /// <td>The traffic path.</td>
        /// <td>all</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RoundTripTime</td>
        /// <td>number</td>
        /// <td>The TCP RTT.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>VPC flow log - Public VPC flow log query and analysis results</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionId</td>
        /// <td>string</td>
        /// <td>The region where the flow log resides.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VpcId</td>
        /// <td>string</td>
        /// <td>The VPC ID.</td>
        /// <td>vpc-m5ec6i0h5xss***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID.</td>
        /// <td>vsw-2zeekevlh****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NetworkInterfaceId</td>
        /// <td>string</td>
        /// <td>The elastic network interface (ENI) ID.</td>
        /// <td>eni-8vbf2jxul***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>EcsId</td>
        /// <td>string</td>
        /// <td>The ECS instance ID of the management node.</td>
        /// <td>i-uf6i1zi6yhq7h***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TrafficPath</td>
        /// <td>string</td>
        /// <td>The traffic path.</td>
        /// <td>all</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientCountry</td>
        /// <td>string</td>
        /// <td>The country of the client.</td>
        /// <td>China</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientProvince</td>
        /// <td>string</td>
        /// <td>The province of the client.</td>
        /// <td>Hong Kong SAR</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientCity</td>
        /// <td>string</td>
        /// <td>The city of the client.</td>
        /// <td>Kowloon</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientIsp</td>
        /// <td>string</td>
        /// <td>The network service provider.</td>
        /// <td>Alibaba Cloud</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientAsn</td>
        /// <td>string</td>
        /// <td>The autonomous system number.</td>
        /// <td>45102</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RoundTripTime</td>
        /// <td>number</td>
        /// <td>The TCP RTT.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - TR cross-region scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dscp</td>
        /// <td>string</td>
        /// <td>The Differentiated Services Code Point (DSCP) value.</td>
        /// <td>0</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationRegionNo</td>
        /// <td>string</td>
        /// <td>The destination region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceRegionNo</td>
        /// <td>string</td>
        /// <td>The source region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterAttachmentId</td>
        /// <td>string</td>
        /// <td>The network instance connection ID.</td>
        /// <td>tr-attach-bfde1cd4cj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterId</td>
        /// <td>string</td>
        /// <td>The transit router instance ID.</td>
        /// <td>tr-2zefvwy2fz3444***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterPairAttachmentId</td>
        /// <td>string</td>
        /// <td>The transit router peering connection instance ID.</td>
        /// <td>tr-attach-okvj1cd4cjp***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostNoRoute</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to no route.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostBlackhole</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to blackhole routes.</td>
        /// <td>4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostTTLExpired</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to TTL expiration.</td>
        /// <td>7</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - VPC connection traffic scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dscp</td>
        /// <td>string</td>
        /// <td>The Differentiated Services Code Point (DSCP) value.</td>
        /// <td>0</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationRegionNo</td>
        /// <td>string</td>
        /// <td>The destination region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceRegionNo</td>
        /// <td>string</td>
        /// <td>The source region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterAttachmentId</td>
        /// <td>string</td>
        /// <td>The network instance connection ID.</td>
        /// <td>tr-attach-bfde1cd4cj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterId</td>
        /// <td>string</td>
        /// <td>The transit router instance ID.</td>
        /// <td>tr-2zefvwy2fz3444***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterPairAttachmentId</td>
        /// <td>string</td>
        /// <td>The transit router peering connection instance ID.</td>
        /// <td>tr-attach-okvj1cd4cjp***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceResourceId</td>
        /// <td>string</td>
        /// <td>The source network instance ID.</td>
        /// <td>tr-attach-hvve1cd4cjpj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the source network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceVSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID of the source TR ENI.</td>
        /// <td>vsw-ikfdkevlhxpqxuz****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceNetworkInterface</td>
        /// <td>string</td>
        /// <td>The source TR ENI.</td>
        /// <td>eni-8vbf2jxulma***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceAvailableZone</td>
        /// <td>string</td>
        /// <td>The source zone ID.</td>
        /// <td>ap-southeast-1-j</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationResourceId</td>
        /// <td>string</td>
        /// <td>The destination network instance ID.</td>
        /// <td>tr-attach-bfve1cd4cjp****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the destination network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationVSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID of the destination TR ENI.</td>
        /// <td>vsw-ikfdkevlhxpqxuz****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationNetworkInterface</td>
        /// <td>string</td>
        /// <td>The destination TR ENI.</td>
        /// <td>eni-7kcf2jxulma***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationAvailableZone</td>
        /// <td>string</td>
        /// <td>The destination zone ID.</td>
        /// <td>ap-southeast-1-j</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostNoRoute</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to no route.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostBlackhole</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to blackhole routes.</td>
        /// <td>4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostTTLExpired</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to TTL expiration.</td>
        /// <td>7</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - VBR traffic scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dscp</td>
        /// <td>string</td>
        /// <td>The Differentiated Services Code Point (DSCP) value.</td>
        /// <td>0</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationRegionNo</td>
        /// <td>string</td>
        /// <td>The destination region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceRegionNo</td>
        /// <td>string</td>
        /// <td>The source region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterAttachmentId</td>
        /// <td>string</td>
        /// <td>The network instance connection ID.</td>
        /// <td>tr-attach-bfde1cd4cj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterId</td>
        /// <td>string</td>
        /// <td>The transit router instance ID.</td>
        /// <td>tr-2zefvwy2fz3444***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterPairAttachmentId</td>
        /// <td>string</td>
        /// <td>The transit router peering connection instance ID.</td>
        /// <td>tr-attach-okvj1cd4cjp***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceResourceId</td>
        /// <td>string</td>
        /// <td>The source network instance ID.</td>
        /// <td>tr-attach-hvve1cd4cjpj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the source network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationResourceId</td>
        /// <td>string</td>
        /// <td>The destination network instance ID.</td>
        /// <td>tr-attach-bfve1cd4cjp****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the destination network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostNoRoute</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to no route.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostBlackhole</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to blackhole routes.</td>
        /// <td>4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostTTLExpired</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to TTL expiration.</td>
        /// <td>7</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - ECR traffic scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeNisTrafficRankingRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisTrafficRankingResponse
        /// </returns>
        public DescribeNisTrafficRankingResponse DescribeNisTrafficRanking(DescribeNisTrafficRankingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNisTrafficRankingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of NIS traffic ranking analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><a href="https://www.alibabacloud.com/help/en/nis/product-overview/billing-method-new-version">Before using this operation, make sure that you fully understand the billing method and pricing of the NIS Traffic Analyzer.</a>
        /// Supported analysis scenarios: </para>
        /// <list type="bullet">
        /// <item><description>All VPC network traffic analysis</description></item>
        /// <item><description>Public VPC network traffic analysis</description></item>
        /// <item><description>All TR network traffic analysis</description></item>
        /// <item><description>Internet Shared Bandwidth metric analysis</description></item>
        /// </list>
        /// <h2>VPC flow log - All VPC flow log query and analysis results</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionId</td>
        /// <td>string</td>
        /// <td>The region where the flow log resides.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VpcId</td>
        /// <td>string</td>
        /// <td>The VPC ID.</td>
        /// <td>vpc-m5ec6i0h5xss***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID.</td>
        /// <td>vsw-2zeekevlh****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NetworkInterfaceId</td>
        /// <td>string</td>
        /// <td>The elastic network interface (ENI) ID.</td>
        /// <td>eni-8vbf2jxul***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>EcsId</td>
        /// <td>string</td>
        /// <td>The ECS instance ID of the management node.</td>
        /// <td>i-uf6i1zi6yhq7h***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TrafficPath</td>
        /// <td>string</td>
        /// <td>The traffic path.</td>
        /// <td>all</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RoundTripTime</td>
        /// <td>number</td>
        /// <td>The TCP RTT.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>VPC flow log - Public VPC flow log query and analysis results</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionId</td>
        /// <td>string</td>
        /// <td>The region where the flow log resides.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VpcId</td>
        /// <td>string</td>
        /// <td>The VPC ID.</td>
        /// <td>vpc-m5ec6i0h5xss***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>VSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID.</td>
        /// <td>vsw-2zeekevlh****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NetworkInterfaceId</td>
        /// <td>string</td>
        /// <td>The elastic network interface (ENI) ID.</td>
        /// <td>eni-8vbf2jxul***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>EcsId</td>
        /// <td>string</td>
        /// <td>The ECS instance ID of the management node.</td>
        /// <td>i-uf6i1zi6yhq7h***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TrafficPath</td>
        /// <td>string</td>
        /// <td>The traffic path.</td>
        /// <td>all</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientCountry</td>
        /// <td>string</td>
        /// <td>The country of the client.</td>
        /// <td>China</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientProvince</td>
        /// <td>string</td>
        /// <td>The province of the client.</td>
        /// <td>Hong Kong SAR</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientCity</td>
        /// <td>string</td>
        /// <td>The city of the client.</td>
        /// <td>Kowloon</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientIsp</td>
        /// <td>string</td>
        /// <td>The network service provider.</td>
        /// <td>Alibaba Cloud</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>ClientAsn</td>
        /// <td>string</td>
        /// <td>The autonomous system number.</td>
        /// <td>45102</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RoundTripTime</td>
        /// <td>number</td>
        /// <td>The TCP RTT.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - TR cross-region scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dscp</td>
        /// <td>string</td>
        /// <td>The Differentiated Services Code Point (DSCP) value.</td>
        /// <td>0</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationRegionNo</td>
        /// <td>string</td>
        /// <td>The destination region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceRegionNo</td>
        /// <td>string</td>
        /// <td>The source region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterAttachmentId</td>
        /// <td>string</td>
        /// <td>The network instance connection ID.</td>
        /// <td>tr-attach-bfde1cd4cj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterId</td>
        /// <td>string</td>
        /// <td>The transit router instance ID.</td>
        /// <td>tr-2zefvwy2fz3444***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterPairAttachmentId</td>
        /// <td>string</td>
        /// <td>The transit router peering connection instance ID.</td>
        /// <td>tr-attach-okvj1cd4cjp***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostNoRoute</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to no route.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostBlackhole</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to blackhole routes.</td>
        /// <td>4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostTTLExpired</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to TTL expiration.</td>
        /// <td>7</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - VPC connection traffic scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dscp</td>
        /// <td>string</td>
        /// <td>The Differentiated Services Code Point (DSCP) value.</td>
        /// <td>0</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationRegionNo</td>
        /// <td>string</td>
        /// <td>The destination region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceRegionNo</td>
        /// <td>string</td>
        /// <td>The source region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterAttachmentId</td>
        /// <td>string</td>
        /// <td>The network instance connection ID.</td>
        /// <td>tr-attach-bfde1cd4cj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterId</td>
        /// <td>string</td>
        /// <td>The transit router instance ID.</td>
        /// <td>tr-2zefvwy2fz3444***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterPairAttachmentId</td>
        /// <td>string</td>
        /// <td>The transit router peering connection instance ID.</td>
        /// <td>tr-attach-okvj1cd4cjp***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceResourceId</td>
        /// <td>string</td>
        /// <td>The source network instance ID.</td>
        /// <td>tr-attach-hvve1cd4cjpj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the source network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceVSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID of the source TR ENI.</td>
        /// <td>vsw-ikfdkevlhxpqxuz****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceNetworkInterface</td>
        /// <td>string</td>
        /// <td>The source TR ENI.</td>
        /// <td>eni-8vbf2jxulma***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceAvailableZone</td>
        /// <td>string</td>
        /// <td>The source zone ID.</td>
        /// <td>ap-southeast-1-j</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationResourceId</td>
        /// <td>string</td>
        /// <td>The destination network instance ID.</td>
        /// <td>tr-attach-bfve1cd4cjp****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the destination network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationVSwitchId</td>
        /// <td>string</td>
        /// <td>The vSwitch ID of the destination TR ENI.</td>
        /// <td>vsw-ikfdkevlhxpqxuz****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationNetworkInterface</td>
        /// <td>string</td>
        /// <td>The destination TR ENI.</td>
        /// <td>eni-7kcf2jxulma***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationAvailableZone</td>
        /// <td>string</td>
        /// <td>The destination zone ID.</td>
        /// <td>ap-southeast-1-j</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostNoRoute</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to no route.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostBlackhole</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to blackhole routes.</td>
        /// <td>4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostTTLExpired</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to TTL expiration.</td>
        /// <td>7</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - VBR traffic scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● in: inbound traffic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● out: outbound traffic.</td>
        /// <td>in</td>
        /// <td>-in / -out</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceIp</td>
        /// <td>string</td>
        /// <td>The source IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>47.92.245.***</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourcePort</td>
        /// <td>string</td>
        /// <td>The source port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>5432</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationIp</td>
        /// <td>string</td>
        /// <td>The destination IP address.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 2-tuple statistics are collected.</td>
        /// <td>192.168.***.0</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationPort</td>
        /// <td>string</td>
        /// <td>The destination port.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>23</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Protocol</td>
        /// <td>string</td>
        /// <td>The network protocol.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● This field is returned only when 5-tuple statistics are collected.</td>
        /// <td>TCP</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dscp</td>
        /// <td>string</td>
        /// <td>The Differentiated Services Code Point (DSCP) value.</td>
        /// <td>0</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>DestinationRegionNo</td>
        /// <td>string</td>
        /// <td>The destination region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>SourceRegionNo</td>
        /// <td>string</td>
        /// <td>The source region ID.</td>
        /// <td>ap-southeast-1</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterAttachmentId</td>
        /// <td>string</td>
        /// <td>The network instance connection ID.</td>
        /// <td>tr-attach-bfde1cd4cj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterId</td>
        /// <td>string</td>
        /// <td>The transit router instance ID.</td>
        /// <td>tr-2zefvwy2fz3444***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterPairAttachmentId</td>
        /// <td>string</td>
        /// <td>The transit router peering connection instance ID.</td>
        /// <td>tr-attach-okvj1cd4cjp***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceResourceId</td>
        /// <td>string</td>
        /// <td>The source network instance ID.</td>
        /// <td>tr-attach-hvve1cd4cjpj***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterSourceAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the source network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationResourceId</td>
        /// <td>string</td>
        /// <td>The destination network instance ID.</td>
        /// <td>tr-attach-bfve1cd4cjp****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TransitRouterDestinationAccountId</td>
        /// <td>string</td>
        /// <td>The account ID of the destination network instance.</td>
        /// <td>1906814138***</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Bytes</td>
        /// <td>number</td>
        /// <td>The bandwidth.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Packets</td>
        /// <td>number</td>
        /// <td>The number of packets.</td>
        /// <td>100</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>BytesRate</td>
        /// <td>number</td>
        /// <td>The traffic ratio.</td>
        /// <td>0.2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostNoRoute</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to no route.</td>
        /// <td>2</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostBlackhole</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to blackhole routes.</td>
        /// <td>4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>PacketsLostTTLExpired</td>
        /// <td>number</td>
        /// <td>The number of packets dropped due to TTL expiration.</td>
        /// <td>7</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <hr>
        /// <h2>TR flow log - ECR traffic scenario analysis results.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>No</td>
        /// <td>The paging token. Set this parameter to the NextToken value returned in the previous API call.</td>
        /// <td>2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>No</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h3>Response parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>-</td>
        /// <td>object</td>
        /// <td>RpcResponse</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The ID of the network traffic analysis result.</td>
        /// <td>task-7619ecb1db9148bab9f4</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Status</td>
        /// <td>string</td>
        /// <td>The task running status.</td>
        /// <td>Complete</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>NextToken</td>
        /// <td>string</td>
        /// <td>The token for the next query.</td>
        /// <td>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>MaxResults</td>
        /// <td>integer</td>
        /// <td>The paging size. Valid values: 1 to 100. Default value: 20.</td>
        /// <td>20</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>TotalCount</td>
        /// <td>integer</td>
        /// <td>The total number of entries returned.</td>
        /// <td>72</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>FlowRankingList</td>
        /// <td>array</td>
        /// <td>The list of network traffic analysis results.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <h4>FlowRankingList element structure</h4>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>The traffic direction based on the</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeNisTrafficRankingRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNisTrafficRankingResponse
        /// </returns>
        public async Task<DescribeNisTrafficRankingResponse> DescribeNisTrafficRankingAsync(DescribeNisTrafficRankingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNisTrafficRankingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetInternetTuple is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the rankings of Internet traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Internet traffic data can be ranked by metrics such as traffic volumes and the number of packets.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetInternetTupleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInternetTupleResponse
        /// </returns>
        [Obsolete("OpenAPI GetInternetTuple is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public GetInternetTupleResponse GetInternetTupleWithOptions(GetInternetTupleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetInternetTupleShrinkRequest request = new GetInternetTupleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CloudIpList))
            {
                request.CloudIpListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CloudIpList, "CloudIpList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceList))
            {
                request.InstanceListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceList, "InstanceList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudIp))
            {
                query["CloudIp"] = request.CloudIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudIpListShrink))
            {
                query["CloudIpList"] = request.CloudIpListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudIsp))
            {
                query["CloudIsp"] = request.CloudIsp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudPort))
            {
                query["CloudPort"] = request.CloudPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceListShrink))
            {
                query["InstanceList"] = request.InstanceListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherCity))
            {
                query["OtherCity"] = request.OtherCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherCountry))
            {
                query["OtherCountry"] = request.OtherCountry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherIp))
            {
                query["OtherIp"] = request.OtherIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherIsp))
            {
                query["OtherIsp"] = request.OtherIsp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherPort))
            {
                query["OtherPort"] = request.OtherPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["TopN"] = request.TopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TupleType))
            {
                query["TupleType"] = request.TupleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseMultiAccount))
            {
                query["UseMultiAccount"] = request.UseMultiAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInternetTuple",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInternetTupleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetInternetTuple is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the rankings of Internet traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Internet traffic data can be ranked by metrics such as traffic volumes and the number of packets.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetInternetTupleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInternetTupleResponse
        /// </returns>
        [Obsolete("OpenAPI GetInternetTuple is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public async Task<GetInternetTupleResponse> GetInternetTupleWithOptionsAsync(GetInternetTupleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetInternetTupleShrinkRequest request = new GetInternetTupleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CloudIpList))
            {
                request.CloudIpListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CloudIpList, "CloudIpList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceList))
            {
                request.InstanceListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceList, "InstanceList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudIp))
            {
                query["CloudIp"] = request.CloudIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudIpListShrink))
            {
                query["CloudIpList"] = request.CloudIpListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudIsp))
            {
                query["CloudIsp"] = request.CloudIsp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudPort))
            {
                query["CloudPort"] = request.CloudPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceListShrink))
            {
                query["InstanceList"] = request.InstanceListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherCity))
            {
                query["OtherCity"] = request.OtherCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherCountry))
            {
                query["OtherCountry"] = request.OtherCountry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherIp))
            {
                query["OtherIp"] = request.OtherIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherIsp))
            {
                query["OtherIsp"] = request.OtherIsp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherPort))
            {
                query["OtherPort"] = request.OtherPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["TopN"] = request.TopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TupleType))
            {
                query["TupleType"] = request.TupleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseMultiAccount))
            {
                query["UseMultiAccount"] = request.UseMultiAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInternetTuple",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInternetTupleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetInternetTuple is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the rankings of Internet traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Internet traffic data can be ranked by metrics such as traffic volumes and the number of packets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInternetTupleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInternetTupleResponse
        /// </returns>
        [Obsolete("OpenAPI GetInternetTuple is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public GetInternetTupleResponse GetInternetTuple(GetInternetTupleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInternetTupleWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetInternetTuple is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the rankings of Internet traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Internet traffic data can be ranked by metrics such as traffic volumes and the number of packets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInternetTupleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInternetTupleResponse
        /// </returns>
        [Obsolete("OpenAPI GetInternetTuple is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public async Task<GetInternetTupleResponse> GetInternetTupleAsync(GetInternetTupleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInternetTupleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetNatTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time SNAT performance ranking of a NAT gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNatTopNRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNatTopNResponse
        /// </returns>
        [Obsolete("OpenAPI GetNatTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public GetNatTopNResponse GetNatTopNWithOptions(GetNatTopNRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["TopN"] = request.TopN;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNatTopN",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNatTopNResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetNatTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time SNAT performance ranking of a NAT gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNatTopNRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNatTopNResponse
        /// </returns>
        [Obsolete("OpenAPI GetNatTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public async Task<GetNatTopNResponse> GetNatTopNWithOptionsAsync(GetNatTopNRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGatewayId))
            {
                query["NatGatewayId"] = request.NatGatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["TopN"] = request.TopN;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNatTopN",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNatTopNResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetNatTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time SNAT performance ranking of a NAT gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNatTopNRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNatTopNResponse
        /// </returns>
        [Obsolete("OpenAPI GetNatTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public GetNatTopNResponse GetNatTopN(GetNatTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNatTopNWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetNatTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the real-time SNAT performance ranking of a NAT gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNatTopNRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNatTopNResponse
        /// </returns>
        [Obsolete("OpenAPI GetNatTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public async Task<GetNatTopNResponse> GetNatTopNAsync(GetNatTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNatTopNWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the results of network reachability analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>GetNetworkReachableAnalysis</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can query the state of the task for analyzing network reachability.</para>
        /// <list type="bullet">
        /// <item><description>The <b>init</b> state indicates that the task is in progress.</description></item>
        /// <item><description>The <b>finish</b> state indicates that the task is complete. In this state, you can obtain the analysis result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetNetworkReachableAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNetworkReachableAnalysisResponse
        /// </returns>
        public GetNetworkReachableAnalysisResponse GetNetworkReachableAnalysisWithOptions(GetNetworkReachableAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkReachableAnalysisId))
            {
                query["NetworkReachableAnalysisId"] = request.NetworkReachableAnalysisId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNetworkReachableAnalysis",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNetworkReachableAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the results of network reachability analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>GetNetworkReachableAnalysis</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can query the state of the task for analyzing network reachability.</para>
        /// <list type="bullet">
        /// <item><description>The <b>init</b> state indicates that the task is in progress.</description></item>
        /// <item><description>The <b>finish</b> state indicates that the task is complete. In this state, you can obtain the analysis result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetNetworkReachableAnalysisRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNetworkReachableAnalysisResponse
        /// </returns>
        public async Task<GetNetworkReachableAnalysisResponse> GetNetworkReachableAnalysisWithOptionsAsync(GetNetworkReachableAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkReachableAnalysisId))
            {
                query["NetworkReachableAnalysisId"] = request.NetworkReachableAnalysisId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNetworkReachableAnalysis",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNetworkReachableAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the results of network reachability analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>GetNetworkReachableAnalysis</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can query the state of the task for analyzing network reachability.</para>
        /// <list type="bullet">
        /// <item><description>The <b>init</b> state indicates that the task is in progress.</description></item>
        /// <item><description>The <b>finish</b> state indicates that the task is complete. In this state, you can obtain the analysis result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetNetworkReachableAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNetworkReachableAnalysisResponse
        /// </returns>
        public GetNetworkReachableAnalysisResponse GetNetworkReachableAnalysis(GetNetworkReachableAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNetworkReachableAnalysisWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the results of network reachability analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>GetNetworkReachableAnalysis</em>* is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can query the state of the task for analyzing network reachability.</para>
        /// <list type="bullet">
        /// <item><description>The <b>init</b> state indicates that the task is in progress.</description></item>
        /// <item><description>The <b>finish</b> state indicates that the task is complete. In this state, you can obtain the analysis result.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetNetworkReachableAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNetworkReachableAnalysisResponse
        /// </returns>
        public async Task<GetNetworkReachableAnalysisResponse> GetNetworkReachableAnalysisAsync(GetNetworkReachableAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNetworkReachableAnalysisWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves detailed monitoring metric trends data for a specified NIS network analysis scenario, including traffic metric trends for network traffic analysis scenarios and performance metric trends for performance observation scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Data query result synchronization:</para>
        /// <list type="bullet">
        /// <item><description>API data is synchronized every 6 hours. You can query current network analysis data only after 6 hours.
        /// Supported analysis scenarios: </description></item>
        /// <item><description>Internet performance observation dashboard scenario</description></item>
        /// <item><description>Cross-zone internal network performance observation dashboard scenario</description></item>
        /// <item><description>Cross-region internal network performance observation dashboard scenario</description></item>
        /// </list>
        /// <h2>Internet performance observation dashboard scenario</h2>
        /// <para><b>Note</b>
        /// The maximum query time span is 24 hours. If not specified, the most recent 1 hour is queried by default. The query result contains one data point per minute.</para>
        /// <h3><b>Request parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Required</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The Alibaba Cloud region where the probing source is located.</td>
        /// </tr>
        /// <tr>
        /// <td>ResourceType</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Set to <b>InternetProbing</b> to query Internet performance monitoring trends.</td>
        /// </tr>
        /// <tr>
        /// <td>MetricName</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The metric for which to query trends. Valid value: <b>rtt</b>, the round-trip time of probing.</td>
        /// </tr>
        /// <tr>
        /// <td>Dimensions</td>
        /// <td>object[\]</td>
        /// <td>Yes</td>
        /// <td>The filter information.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Name</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The filter condition. Valid values:</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>Country</b>: the probing country.</description></item>
        /// <item><description><b>Province</b>: the probing province.</description></item>
        /// <item><description><b>Isp</b>: the probing ISP.
        ///  <b>Note:</b> Specify at least one of the preceding parameters. |
        /// | \-Value | string | Yes | The filter value corresponding to the filter condition. Examples:</description></item>
        /// <item><description>Country: China</description></item>
        /// <item><description>Province: Zhejiang </description></item>
        /// <item><description>Isp: Alibaba 
        /// <b>Note:</b> Country and province values are capitalized. The ISP parameter value must match the name displayed in the console. |</description></item>
        /// </list>
        /// <h3><b>Response parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// </tr>
        /// <tr>
        /// <td>Data</td>
        /// <td>object</td>
        /// <td>The cloud network metric trends data object.</td>
        /// </tr>
        /// <tr>
        /// <td>Metrics</td>
        /// <td>array</td>
        /// <td>The collection of metric trends data.</td>
        /// </tr>
        /// <tr>
        /// <td>\-TimeStamp</td>
        /// <td>long</td>
        /// <td>The UNIX timestamp in milliseconds.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Value</td>
        /// <td>double</td>
        /// <td>The metric value corresponding to the <b>MetricName</b> input parameter.</td>
        /// </tr>
        /// <tr>
        /// <td>Unit</td>
        /// <td>String</td>
        /// <td>The unit of <b>Value</b>.</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>Cross-zone internal network performance observation dashboard scenario</h2>
        /// <para><b>Note</b></para>
        /// <list type="bullet">
        /// <item><description><para>If the query time span exceeds 5 days, the query result contains one data point per day.</para>
        /// </description></item>
        /// <item><description><para>If the query time span exceeds 1 day, the query result contains one data point per hour.</para>
        /// </description></item>
        /// <item><description><para>If the query time span is less than 1 day, the query result contains one data point per 5 minutes.</para>
        /// </description></item>
        /// </list>
        /// <h3><b>Request parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Required</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The Alibaba Cloud region.</td>
        /// </tr>
        /// <tr>
        /// <td>ResourceType</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Set to <b>IntranetProbing</b> to query cross-zone performance monitoring trends.</td>
        /// </tr>
        /// <tr>
        /// <td>MetricName</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The metric for which to query trends. Valid value: <b>rtt</b>, the round-trip time of probing.</td>
        /// </tr>
        /// <tr>
        /// <td>Dimensions</td>
        /// <td>object[\]</td>
        /// <td>Yes</td>
        /// <td>The filter information.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Name</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The filter condition. Valid values:</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>SourceZone</b>: the source zone for probing. This parameter is required.</description></item>
        /// <item><description><b>DestinationZone</b>: the destination zone for probing. This parameter is required. |
        /// | \-Value | string | Yes | The filter value corresponding to the filter condition. Examples:</description></item>
        /// <item><description>SourceZone: cn-hangzhou-j</description></item>
        /// <item><description>DestinationZone: cn-hangzhou-k |</description></item>
        /// </list>
        /// <h3><b>Response parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// </tr>
        /// <tr>
        /// <td>Data</td>
        /// <td>object</td>
        /// <td>The cloud network metric trends data object.</td>
        /// </tr>
        /// <tr>
        /// <td>Metrics</td>
        /// <td>array</td>
        /// <td>The collection of metric trends data.</td>
        /// </tr>
        /// <tr>
        /// <td>\-TimeStamp</td>
        /// <td>long</td>
        /// <td>The UNIX timestamp in milliseconds.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Value</td>
        /// <td>double</td>
        /// <td>The metric value corresponding to the <b>MetricName</b> input parameter.</td>
        /// </tr>
        /// <tr>
        /// <td>Unit</td>
        /// <td>String</td>
        /// <td>The unit of <b>Value</b>.</td>
        /// </tr>
        /// </tbody></table>
        /// <h2><b>Cross-region internal network performance observation dashboard scenario</b></h2>
        /// <para><b>Note</b></para>
        /// <list type="bullet">
        /// <item><description><para>If the query time span exceeds 5 days, the query result contains one data point per day.</para>
        /// </description></item>
        /// <item><description><para>If the query time span exceeds 1 day, the query result contains one data point per hour.</para>
        /// </description></item>
        /// <item><description><para>If the query time span is less than 1 day, the query result contains one data point per 5 minutes.</para>
        /// </description></item>
        /// </list>
        /// <h3><b>Request parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Required</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The Alibaba Cloud region.</td>
        /// </tr>
        /// <tr>
        /// <td>ResourceType</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Set to <b>IntranetProbing</b> to query cross-region performance observation rankings.</td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The probing direction. Valid values:</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>in</b>: probing with RegionNo as the destination.</description></item>
        /// <item><description><b>out</b>: probing with RegionNo as the source. |
        /// | MetricName | string | Yes | The metric for which to query trends. Valid value: <b>rtt</b>, the round-trip time of probing. |
        /// | Dimensions | object[\] | No | The filter information. |
        /// | \-Name | string | No | The filter condition. Valid value: <b>DestinationRegionNo</b>, the destination region for probing. This parameter is required. |
        /// | \-Value | string | No | The destination region ID. Example: DestinationRegionNo: cn-shenzhen |</description></item>
        /// </list>
        /// <h3><b>Response parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// </tr>
        /// <tr>
        /// <td>Data</td>
        /// <td>object</td>
        /// <td>The cloud network metric trends data object.</td>
        /// </tr>
        /// <tr>
        /// <td>Metrics</td>
        /// <td>array</td>
        /// <td>The collection of metric trends data.</td>
        /// </tr>
        /// <tr>
        /// <td>\-TimeStamp</td>
        /// <td>long</td>
        /// <td>The UNIX timestamp in milliseconds.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Value</td>
        /// <td>double</td>
        /// <td>The metric value corresponding to the <b>MetricName</b> input parameter.</td>
        /// </tr>
        /// <tr>
        /// <td>Unit</td>
        /// <td>String</td>
        /// <td>The unit of <b>Value</b>.</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetNisNetworkMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNisNetworkMetricsResponse
        /// </returns>
        public GetNisNetworkMetricsResponse GetNisNetworkMetricsWithOptions(GetNisNetworkMetricsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNisNetworkMetricsShrinkRequest request = new GetNisNetworkMetricsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Dimensions))
            {
                request.DimensionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Dimensions, "Dimensions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DimensionsShrink))
            {
                query["Dimensions"] = request.DimensionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanBy))
            {
                query["ScanBy"] = request.ScanBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepMinutes))
            {
                query["StepMinutes"] = request.StepMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCrossAccount))
            {
                query["UseCrossAccount"] = request.UseCrossAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNisNetworkMetrics",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNisNetworkMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves detailed monitoring metric trends data for a specified NIS network analysis scenario, including traffic metric trends for network traffic analysis scenarios and performance metric trends for performance observation scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Data query result synchronization:</para>
        /// <list type="bullet">
        /// <item><description>API data is synchronized every 6 hours. You can query current network analysis data only after 6 hours.
        /// Supported analysis scenarios: </description></item>
        /// <item><description>Internet performance observation dashboard scenario</description></item>
        /// <item><description>Cross-zone internal network performance observation dashboard scenario</description></item>
        /// <item><description>Cross-region internal network performance observation dashboard scenario</description></item>
        /// </list>
        /// <h2>Internet performance observation dashboard scenario</h2>
        /// <para><b>Note</b>
        /// The maximum query time span is 24 hours. If not specified, the most recent 1 hour is queried by default. The query result contains one data point per minute.</para>
        /// <h3><b>Request parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Required</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The Alibaba Cloud region where the probing source is located.</td>
        /// </tr>
        /// <tr>
        /// <td>ResourceType</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Set to <b>InternetProbing</b> to query Internet performance monitoring trends.</td>
        /// </tr>
        /// <tr>
        /// <td>MetricName</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The metric for which to query trends. Valid value: <b>rtt</b>, the round-trip time of probing.</td>
        /// </tr>
        /// <tr>
        /// <td>Dimensions</td>
        /// <td>object[\]</td>
        /// <td>Yes</td>
        /// <td>The filter information.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Name</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The filter condition. Valid values:</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>Country</b>: the probing country.</description></item>
        /// <item><description><b>Province</b>: the probing province.</description></item>
        /// <item><description><b>Isp</b>: the probing ISP.
        ///  <b>Note:</b> Specify at least one of the preceding parameters. |
        /// | \-Value | string | Yes | The filter value corresponding to the filter condition. Examples:</description></item>
        /// <item><description>Country: China</description></item>
        /// <item><description>Province: Zhejiang </description></item>
        /// <item><description>Isp: Alibaba 
        /// <b>Note:</b> Country and province values are capitalized. The ISP parameter value must match the name displayed in the console. |</description></item>
        /// </list>
        /// <h3><b>Response parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// </tr>
        /// <tr>
        /// <td>Data</td>
        /// <td>object</td>
        /// <td>The cloud network metric trends data object.</td>
        /// </tr>
        /// <tr>
        /// <td>Metrics</td>
        /// <td>array</td>
        /// <td>The collection of metric trends data.</td>
        /// </tr>
        /// <tr>
        /// <td>\-TimeStamp</td>
        /// <td>long</td>
        /// <td>The UNIX timestamp in milliseconds.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Value</td>
        /// <td>double</td>
        /// <td>The metric value corresponding to the <b>MetricName</b> input parameter.</td>
        /// </tr>
        /// <tr>
        /// <td>Unit</td>
        /// <td>String</td>
        /// <td>The unit of <b>Value</b>.</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>Cross-zone internal network performance observation dashboard scenario</h2>
        /// <para><b>Note</b></para>
        /// <list type="bullet">
        /// <item><description><para>If the query time span exceeds 5 days, the query result contains one data point per day.</para>
        /// </description></item>
        /// <item><description><para>If the query time span exceeds 1 day, the query result contains one data point per hour.</para>
        /// </description></item>
        /// <item><description><para>If the query time span is less than 1 day, the query result contains one data point per 5 minutes.</para>
        /// </description></item>
        /// </list>
        /// <h3><b>Request parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Required</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The Alibaba Cloud region.</td>
        /// </tr>
        /// <tr>
        /// <td>ResourceType</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Set to <b>IntranetProbing</b> to query cross-zone performance monitoring trends.</td>
        /// </tr>
        /// <tr>
        /// <td>MetricName</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The metric for which to query trends. Valid value: <b>rtt</b>, the round-trip time of probing.</td>
        /// </tr>
        /// <tr>
        /// <td>Dimensions</td>
        /// <td>object[\]</td>
        /// <td>Yes</td>
        /// <td>The filter information.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Name</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The filter condition. Valid values:</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>SourceZone</b>: the source zone for probing. This parameter is required.</description></item>
        /// <item><description><b>DestinationZone</b>: the destination zone for probing. This parameter is required. |
        /// | \-Value | string | Yes | The filter value corresponding to the filter condition. Examples:</description></item>
        /// <item><description>SourceZone: cn-hangzhou-j</description></item>
        /// <item><description>DestinationZone: cn-hangzhou-k |</description></item>
        /// </list>
        /// <h3><b>Response parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// </tr>
        /// <tr>
        /// <td>Data</td>
        /// <td>object</td>
        /// <td>The cloud network metric trends data object.</td>
        /// </tr>
        /// <tr>
        /// <td>Metrics</td>
        /// <td>array</td>
        /// <td>The collection of metric trends data.</td>
        /// </tr>
        /// <tr>
        /// <td>\-TimeStamp</td>
        /// <td>long</td>
        /// <td>The UNIX timestamp in milliseconds.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Value</td>
        /// <td>double</td>
        /// <td>The metric value corresponding to the <b>MetricName</b> input parameter.</td>
        /// </tr>
        /// <tr>
        /// <td>Unit</td>
        /// <td>String</td>
        /// <td>The unit of <b>Value</b>.</td>
        /// </tr>
        /// </tbody></table>
        /// <h2><b>Cross-region internal network performance observation dashboard scenario</b></h2>
        /// <para><b>Note</b></para>
        /// <list type="bullet">
        /// <item><description><para>If the query time span exceeds 5 days, the query result contains one data point per day.</para>
        /// </description></item>
        /// <item><description><para>If the query time span exceeds 1 day, the query result contains one data point per hour.</para>
        /// </description></item>
        /// <item><description><para>If the query time span is less than 1 day, the query result contains one data point per 5 minutes.</para>
        /// </description></item>
        /// </list>
        /// <h3><b>Request parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Required</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The Alibaba Cloud region.</td>
        /// </tr>
        /// <tr>
        /// <td>ResourceType</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Set to <b>IntranetProbing</b> to query cross-region performance observation rankings.</td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The probing direction. Valid values:</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>in</b>: probing with RegionNo as the destination.</description></item>
        /// <item><description><b>out</b>: probing with RegionNo as the source. |
        /// | MetricName | string | Yes | The metric for which to query trends. Valid value: <b>rtt</b>, the round-trip time of probing. |
        /// | Dimensions | object[\] | No | The filter information. |
        /// | \-Name | string | No | The filter condition. Valid value: <b>DestinationRegionNo</b>, the destination region for probing. This parameter is required. |
        /// | \-Value | string | No | The destination region ID. Example: DestinationRegionNo: cn-shenzhen |</description></item>
        /// </list>
        /// <h3><b>Response parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// </tr>
        /// <tr>
        /// <td>Data</td>
        /// <td>object</td>
        /// <td>The cloud network metric trends data object.</td>
        /// </tr>
        /// <tr>
        /// <td>Metrics</td>
        /// <td>array</td>
        /// <td>The collection of metric trends data.</td>
        /// </tr>
        /// <tr>
        /// <td>\-TimeStamp</td>
        /// <td>long</td>
        /// <td>The UNIX timestamp in milliseconds.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Value</td>
        /// <td>double</td>
        /// <td>The metric value corresponding to the <b>MetricName</b> input parameter.</td>
        /// </tr>
        /// <tr>
        /// <td>Unit</td>
        /// <td>String</td>
        /// <td>The unit of <b>Value</b>.</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetNisNetworkMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNisNetworkMetricsResponse
        /// </returns>
        public async Task<GetNisNetworkMetricsResponse> GetNisNetworkMetricsWithOptionsAsync(GetNisNetworkMetricsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNisNetworkMetricsShrinkRequest request = new GetNisNetworkMetricsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Dimensions))
            {
                request.DimensionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Dimensions, "Dimensions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DimensionsShrink))
            {
                query["Dimensions"] = request.DimensionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanBy))
            {
                query["ScanBy"] = request.ScanBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepMinutes))
            {
                query["StepMinutes"] = request.StepMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCrossAccount))
            {
                query["UseCrossAccount"] = request.UseCrossAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNisNetworkMetrics",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNisNetworkMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves detailed monitoring metric trends data for a specified NIS network analysis scenario, including traffic metric trends for network traffic analysis scenarios and performance metric trends for performance observation scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Data query result synchronization:</para>
        /// <list type="bullet">
        /// <item><description>API data is synchronized every 6 hours. You can query current network analysis data only after 6 hours.
        /// Supported analysis scenarios: </description></item>
        /// <item><description>Internet performance observation dashboard scenario</description></item>
        /// <item><description>Cross-zone internal network performance observation dashboard scenario</description></item>
        /// <item><description>Cross-region internal network performance observation dashboard scenario</description></item>
        /// </list>
        /// <h2>Internet performance observation dashboard scenario</h2>
        /// <para><b>Note</b>
        /// The maximum query time span is 24 hours. If not specified, the most recent 1 hour is queried by default. The query result contains one data point per minute.</para>
        /// <h3><b>Request parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Required</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The Alibaba Cloud region where the probing source is located.</td>
        /// </tr>
        /// <tr>
        /// <td>ResourceType</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Set to <b>InternetProbing</b> to query Internet performance monitoring trends.</td>
        /// </tr>
        /// <tr>
        /// <td>MetricName</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The metric for which to query trends. Valid value: <b>rtt</b>, the round-trip time of probing.</td>
        /// </tr>
        /// <tr>
        /// <td>Dimensions</td>
        /// <td>object[\]</td>
        /// <td>Yes</td>
        /// <td>The filter information.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Name</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The filter condition. Valid values:</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>Country</b>: the probing country.</description></item>
        /// <item><description><b>Province</b>: the probing province.</description></item>
        /// <item><description><b>Isp</b>: the probing ISP.
        ///  <b>Note:</b> Specify at least one of the preceding parameters. |
        /// | \-Value | string | Yes | The filter value corresponding to the filter condition. Examples:</description></item>
        /// <item><description>Country: China</description></item>
        /// <item><description>Province: Zhejiang </description></item>
        /// <item><description>Isp: Alibaba 
        /// <b>Note:</b> Country and province values are capitalized. The ISP parameter value must match the name displayed in the console. |</description></item>
        /// </list>
        /// <h3><b>Response parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// </tr>
        /// <tr>
        /// <td>Data</td>
        /// <td>object</td>
        /// <td>The cloud network metric trends data object.</td>
        /// </tr>
        /// <tr>
        /// <td>Metrics</td>
        /// <td>array</td>
        /// <td>The collection of metric trends data.</td>
        /// </tr>
        /// <tr>
        /// <td>\-TimeStamp</td>
        /// <td>long</td>
        /// <td>The UNIX timestamp in milliseconds.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Value</td>
        /// <td>double</td>
        /// <td>The metric value corresponding to the <b>MetricName</b> input parameter.</td>
        /// </tr>
        /// <tr>
        /// <td>Unit</td>
        /// <td>String</td>
        /// <td>The unit of <b>Value</b>.</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>Cross-zone internal network performance observation dashboard scenario</h2>
        /// <para><b>Note</b></para>
        /// <list type="bullet">
        /// <item><description><para>If the query time span exceeds 5 days, the query result contains one data point per day.</para>
        /// </description></item>
        /// <item><description><para>If the query time span exceeds 1 day, the query result contains one data point per hour.</para>
        /// </description></item>
        /// <item><description><para>If the query time span is less than 1 day, the query result contains one data point per 5 minutes.</para>
        /// </description></item>
        /// </list>
        /// <h3><b>Request parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Required</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The Alibaba Cloud region.</td>
        /// </tr>
        /// <tr>
        /// <td>ResourceType</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Set to <b>IntranetProbing</b> to query cross-zone performance monitoring trends.</td>
        /// </tr>
        /// <tr>
        /// <td>MetricName</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The metric for which to query trends. Valid value: <b>rtt</b>, the round-trip time of probing.</td>
        /// </tr>
        /// <tr>
        /// <td>Dimensions</td>
        /// <td>object[\]</td>
        /// <td>Yes</td>
        /// <td>The filter information.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Name</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The filter condition. Valid values:</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>SourceZone</b>: the source zone for probing. This parameter is required.</description></item>
        /// <item><description><b>DestinationZone</b>: the destination zone for probing. This parameter is required. |
        /// | \-Value | string | Yes | The filter value corresponding to the filter condition. Examples:</description></item>
        /// <item><description>SourceZone: cn-hangzhou-j</description></item>
        /// <item><description>DestinationZone: cn-hangzhou-k |</description></item>
        /// </list>
        /// <h3><b>Response parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// </tr>
        /// <tr>
        /// <td>Data</td>
        /// <td>object</td>
        /// <td>The cloud network metric trends data object.</td>
        /// </tr>
        /// <tr>
        /// <td>Metrics</td>
        /// <td>array</td>
        /// <td>The collection of metric trends data.</td>
        /// </tr>
        /// <tr>
        /// <td>\-TimeStamp</td>
        /// <td>long</td>
        /// <td>The UNIX timestamp in milliseconds.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Value</td>
        /// <td>double</td>
        /// <td>The metric value corresponding to the <b>MetricName</b> input parameter.</td>
        /// </tr>
        /// <tr>
        /// <td>Unit</td>
        /// <td>String</td>
        /// <td>The unit of <b>Value</b>.</td>
        /// </tr>
        /// </tbody></table>
        /// <h2><b>Cross-region internal network performance observation dashboard scenario</b></h2>
        /// <para><b>Note</b></para>
        /// <list type="bullet">
        /// <item><description><para>If the query time span exceeds 5 days, the query result contains one data point per day.</para>
        /// </description></item>
        /// <item><description><para>If the query time span exceeds 1 day, the query result contains one data point per hour.</para>
        /// </description></item>
        /// <item><description><para>If the query time span is less than 1 day, the query result contains one data point per 5 minutes.</para>
        /// </description></item>
        /// </list>
        /// <h3><b>Request parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Required</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The Alibaba Cloud region.</td>
        /// </tr>
        /// <tr>
        /// <td>ResourceType</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Set to <b>IntranetProbing</b> to query cross-region performance observation rankings.</td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The probing direction. Valid values:</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>in</b>: probing with RegionNo as the destination.</description></item>
        /// <item><description><b>out</b>: probing with RegionNo as the source. |
        /// | MetricName | string | Yes | The metric for which to query trends. Valid value: <b>rtt</b>, the round-trip time of probing. |
        /// | Dimensions | object[\] | No | The filter information. |
        /// | \-Name | string | No | The filter condition. Valid value: <b>DestinationRegionNo</b>, the destination region for probing. This parameter is required. |
        /// | \-Value | string | No | The destination region ID. Example: DestinationRegionNo: cn-shenzhen |</description></item>
        /// </list>
        /// <h3><b>Response parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// </tr>
        /// <tr>
        /// <td>Data</td>
        /// <td>object</td>
        /// <td>The cloud network metric trends data object.</td>
        /// </tr>
        /// <tr>
        /// <td>Metrics</td>
        /// <td>array</td>
        /// <td>The collection of metric trends data.</td>
        /// </tr>
        /// <tr>
        /// <td>\-TimeStamp</td>
        /// <td>long</td>
        /// <td>The UNIX timestamp in milliseconds.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Value</td>
        /// <td>double</td>
        /// <td>The metric value corresponding to the <b>MetricName</b> input parameter.</td>
        /// </tr>
        /// <tr>
        /// <td>Unit</td>
        /// <td>String</td>
        /// <td>The unit of <b>Value</b>.</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// GetNisNetworkMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNisNetworkMetricsResponse
        /// </returns>
        public GetNisNetworkMetricsResponse GetNisNetworkMetrics(GetNisNetworkMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNisNetworkMetricsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves detailed monitoring metric trends data for a specified NIS network analysis scenario, including traffic metric trends for network traffic analysis scenarios and performance metric trends for performance observation scenarios.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Data query result synchronization:</para>
        /// <list type="bullet">
        /// <item><description>API data is synchronized every 6 hours. You can query current network analysis data only after 6 hours.
        /// Supported analysis scenarios: </description></item>
        /// <item><description>Internet performance observation dashboard scenario</description></item>
        /// <item><description>Cross-zone internal network performance observation dashboard scenario</description></item>
        /// <item><description>Cross-region internal network performance observation dashboard scenario</description></item>
        /// </list>
        /// <h2>Internet performance observation dashboard scenario</h2>
        /// <para><b>Note</b>
        /// The maximum query time span is 24 hours. If not specified, the most recent 1 hour is queried by default. The query result contains one data point per minute.</para>
        /// <h3><b>Request parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Required</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The Alibaba Cloud region where the probing source is located.</td>
        /// </tr>
        /// <tr>
        /// <td>ResourceType</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Set to <b>InternetProbing</b> to query Internet performance monitoring trends.</td>
        /// </tr>
        /// <tr>
        /// <td>MetricName</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The metric for which to query trends. Valid value: <b>rtt</b>, the round-trip time of probing.</td>
        /// </tr>
        /// <tr>
        /// <td>Dimensions</td>
        /// <td>object[\]</td>
        /// <td>Yes</td>
        /// <td>The filter information.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Name</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The filter condition. Valid values:</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>Country</b>: the probing country.</description></item>
        /// <item><description><b>Province</b>: the probing province.</description></item>
        /// <item><description><b>Isp</b>: the probing ISP.
        ///  <b>Note:</b> Specify at least one of the preceding parameters. |
        /// | \-Value | string | Yes | The filter value corresponding to the filter condition. Examples:</description></item>
        /// <item><description>Country: China</description></item>
        /// <item><description>Province: Zhejiang </description></item>
        /// <item><description>Isp: Alibaba 
        /// <b>Note:</b> Country and province values are capitalized. The ISP parameter value must match the name displayed in the console. |</description></item>
        /// </list>
        /// <h3><b>Response parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// </tr>
        /// <tr>
        /// <td>Data</td>
        /// <td>object</td>
        /// <td>The cloud network metric trends data object.</td>
        /// </tr>
        /// <tr>
        /// <td>Metrics</td>
        /// <td>array</td>
        /// <td>The collection of metric trends data.</td>
        /// </tr>
        /// <tr>
        /// <td>\-TimeStamp</td>
        /// <td>long</td>
        /// <td>The UNIX timestamp in milliseconds.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Value</td>
        /// <td>double</td>
        /// <td>The metric value corresponding to the <b>MetricName</b> input parameter.</td>
        /// </tr>
        /// <tr>
        /// <td>Unit</td>
        /// <td>String</td>
        /// <td>The unit of <b>Value</b>.</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>Cross-zone internal network performance observation dashboard scenario</h2>
        /// <para><b>Note</b></para>
        /// <list type="bullet">
        /// <item><description><para>If the query time span exceeds 5 days, the query result contains one data point per day.</para>
        /// </description></item>
        /// <item><description><para>If the query time span exceeds 1 day, the query result contains one data point per hour.</para>
        /// </description></item>
        /// <item><description><para>If the query time span is less than 1 day, the query result contains one data point per 5 minutes.</para>
        /// </description></item>
        /// </list>
        /// <h3><b>Request parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Required</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The Alibaba Cloud region.</td>
        /// </tr>
        /// <tr>
        /// <td>ResourceType</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Set to <b>IntranetProbing</b> to query cross-zone performance monitoring trends.</td>
        /// </tr>
        /// <tr>
        /// <td>MetricName</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The metric for which to query trends. Valid value: <b>rtt</b>, the round-trip time of probing.</td>
        /// </tr>
        /// <tr>
        /// <td>Dimensions</td>
        /// <td>object[\]</td>
        /// <td>Yes</td>
        /// <td>The filter information.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Name</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The filter condition. Valid values:</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>SourceZone</b>: the source zone for probing. This parameter is required.</description></item>
        /// <item><description><b>DestinationZone</b>: the destination zone for probing. This parameter is required. |
        /// | \-Value | string | Yes | The filter value corresponding to the filter condition. Examples:</description></item>
        /// <item><description>SourceZone: cn-hangzhou-j</description></item>
        /// <item><description>DestinationZone: cn-hangzhou-k |</description></item>
        /// </list>
        /// <h3><b>Response parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// </tr>
        /// <tr>
        /// <td>Data</td>
        /// <td>object</td>
        /// <td>The cloud network metric trends data object.</td>
        /// </tr>
        /// <tr>
        /// <td>Metrics</td>
        /// <td>array</td>
        /// <td>The collection of metric trends data.</td>
        /// </tr>
        /// <tr>
        /// <td>\-TimeStamp</td>
        /// <td>long</td>
        /// <td>The UNIX timestamp in milliseconds.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Value</td>
        /// <td>double</td>
        /// <td>The metric value corresponding to the <b>MetricName</b> input parameter.</td>
        /// </tr>
        /// <tr>
        /// <td>Unit</td>
        /// <td>String</td>
        /// <td>The unit of <b>Value</b>.</td>
        /// </tr>
        /// </tbody></table>
        /// <h2><b>Cross-region internal network performance observation dashboard scenario</b></h2>
        /// <para><b>Note</b></para>
        /// <list type="bullet">
        /// <item><description><para>If the query time span exceeds 5 days, the query result contains one data point per day.</para>
        /// </description></item>
        /// <item><description><para>If the query time span exceeds 1 day, the query result contains one data point per hour.</para>
        /// </description></item>
        /// <item><description><para>If the query time span is less than 1 day, the query result contains one data point per 5 minutes.</para>
        /// </description></item>
        /// </list>
        /// <h3><b>Request parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Required</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The Alibaba Cloud region.</td>
        /// </tr>
        /// <tr>
        /// <td>ResourceType</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Set to <b>IntranetProbing</b> to query cross-region performance observation rankings.</td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The probing direction. Valid values:</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><b>in</b>: probing with RegionNo as the destination.</description></item>
        /// <item><description><b>out</b>: probing with RegionNo as the source. |
        /// | MetricName | string | Yes | The metric for which to query trends. Valid value: <b>rtt</b>, the round-trip time of probing. |
        /// | Dimensions | object[\] | No | The filter information. |
        /// | \-Name | string | No | The filter condition. Valid value: <b>DestinationRegionNo</b>, the destination region for probing. This parameter is required. |
        /// | \-Value | string | No | The destination region ID. Example: DestinationRegionNo: cn-shenzhen |</description></item>
        /// </list>
        /// <h3><b>Response parameters</b></h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Name</b></th>
        /// <th><b>Type</b></th>
        /// <th><b>Description</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// </tr>
        /// <tr>
        /// <td>Data</td>
        /// <td>object</td>
        /// <td>The cloud network metric trends data object.</td>
        /// </tr>
        /// <tr>
        /// <td>Metrics</td>
        /// <td>array</td>
        /// <td>The collection of metric trends data.</td>
        /// </tr>
        /// <tr>
        /// <td>\-TimeStamp</td>
        /// <td>long</td>
        /// <td>The UNIX timestamp in milliseconds.</td>
        /// </tr>
        /// <tr>
        /// <td>\-Value</td>
        /// <td>double</td>
        /// <td>The metric value corresponding to the <b>MetricName</b> input parameter.</td>
        /// </tr>
        /// <tr>
        /// <td>Unit</td>
        /// <td>String</td>
        /// <td>The unit of <b>Value</b>.</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// GetNisNetworkMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNisNetworkMetricsResponse
        /// </returns>
        public async Task<GetNisNetworkMetricsResponse> GetNisNetworkMetricsAsync(GetNisNetworkMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNisNetworkMetricsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Supports ranking analysis of traffic flowing through different cloud network resources by using sorting algorithms and data processing capabilities, and sorts detection metrics of Alibaba Cloud performance observation to help you quickly identify network bottlenecks, optimize resource configurations, and improve overall network performance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Supported analysis scenarios:</para>
        /// <h2>Internet performance observation dashboard scenario.</h2>
        /// <h3><b>Request parameters</b></h3>
        /// <h3><b>Response parameters</b></h3>
        /// <h2>Cross-zone internal network performance observation dashboard scenario.</h2>
        /// <h3><b>Request parameters</b></h3>
        /// <h3><b>Response parameters</b></h3>
        /// <h2><b>Cross-region internal network performance observation dashboard scenario</b></h2>
        /// <h3><b>Request parameters</b></h3>
        /// <h3><b>Response parameters</b></h3>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetNisNetworkRankingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNisNetworkRankingResponse
        /// </returns>
        public GetNisNetworkRankingResponse GetNisNetworkRankingWithOptions(GetNisNetworkRankingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNisNetworkRankingShrinkRequest request = new GetNisNetworkRankingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["TopN"] = request.TopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCrossAccount))
            {
                query["UseCrossAccount"] = request.UseCrossAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNisNetworkRanking",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNisNetworkRankingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Supports ranking analysis of traffic flowing through different cloud network resources by using sorting algorithms and data processing capabilities, and sorts detection metrics of Alibaba Cloud performance observation to help you quickly identify network bottlenecks, optimize resource configurations, and improve overall network performance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Supported analysis scenarios:</para>
        /// <h2>Internet performance observation dashboard scenario.</h2>
        /// <h3><b>Request parameters</b></h3>
        /// <h3><b>Response parameters</b></h3>
        /// <h2>Cross-zone internal network performance observation dashboard scenario.</h2>
        /// <h3><b>Request parameters</b></h3>
        /// <h3><b>Response parameters</b></h3>
        /// <h2><b>Cross-region internal network performance observation dashboard scenario</b></h2>
        /// <h3><b>Request parameters</b></h3>
        /// <h3><b>Response parameters</b></h3>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GetNisNetworkRankingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNisNetworkRankingResponse
        /// </returns>
        public async Task<GetNisNetworkRankingResponse> GetNisNetworkRankingWithOptionsAsync(GetNisNetworkRankingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNisNetworkRankingShrinkRequest request = new GetNisNetworkRankingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIds))
            {
                query["AccountIds"] = request.AccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["TopN"] = request.TopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCrossAccount))
            {
                query["UseCrossAccount"] = request.UseCrossAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNisNetworkRanking",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNisNetworkRankingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Supports ranking analysis of traffic flowing through different cloud network resources by using sorting algorithms and data processing capabilities, and sorts detection metrics of Alibaba Cloud performance observation to help you quickly identify network bottlenecks, optimize resource configurations, and improve overall network performance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Supported analysis scenarios:</para>
        /// <h2>Internet performance observation dashboard scenario.</h2>
        /// <h3><b>Request parameters</b></h3>
        /// <h3><b>Response parameters</b></h3>
        /// <h2>Cross-zone internal network performance observation dashboard scenario.</h2>
        /// <h3><b>Request parameters</b></h3>
        /// <h3><b>Response parameters</b></h3>
        /// <h2><b>Cross-region internal network performance observation dashboard scenario</b></h2>
        /// <h3><b>Request parameters</b></h3>
        /// <h3><b>Response parameters</b></h3>
        /// </description>
        /// 
        /// <param name="request">
        /// GetNisNetworkRankingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNisNetworkRankingResponse
        /// </returns>
        public GetNisNetworkRankingResponse GetNisNetworkRanking(GetNisNetworkRankingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNisNetworkRankingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Supports ranking analysis of traffic flowing through different cloud network resources by using sorting algorithms and data processing capabilities, and sorts detection metrics of Alibaba Cloud performance observation to help you quickly identify network bottlenecks, optimize resource configurations, and improve overall network performance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Supported analysis scenarios:</para>
        /// <h2>Internet performance observation dashboard scenario.</h2>
        /// <h3><b>Request parameters</b></h3>
        /// <h3><b>Response parameters</b></h3>
        /// <h2>Cross-zone internal network performance observation dashboard scenario.</h2>
        /// <h3><b>Request parameters</b></h3>
        /// <h3><b>Response parameters</b></h3>
        /// <h2><b>Cross-region internal network performance observation dashboard scenario</b></h2>
        /// <h3><b>Request parameters</b></h3>
        /// <h3><b>Response parameters</b></h3>
        /// </description>
        /// 
        /// <param name="request">
        /// GetNisNetworkRankingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNisNetworkRankingResponse
        /// </returns>
        public async Task<GetNisNetworkRankingResponse> GetNisNetworkRankingAsync(GetNisNetworkRankingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNisNetworkRankingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the metric trends for network traffic analysis.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetNisTrafficMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNisTrafficMetricsResponse
        /// </returns>
        public GetNisTrafficMetricsResponse GetNisTrafficMetricsWithOptions(GetNisTrafficMetricsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNisTrafficMetricsShrinkRequest request = new GetNisTrafficMetricsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanBy))
            {
                query["ScanBy"] = request.ScanBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepMinutes))
            {
                query["StepMinutes"] = request.StepMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageInterval))
            {
                query["StorageInterval"] = request.StorageInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficAnalyzerId))
            {
                query["TrafficAnalyzerId"] = request.TrafficAnalyzerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficScenario))
            {
                query["TrafficScenario"] = request.TrafficScenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TupleDimension))
            {
                query["TupleDimension"] = request.TupleDimension;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNisTrafficMetrics",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNisTrafficMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the metric trends for network traffic analysis.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetNisTrafficMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNisTrafficMetricsResponse
        /// </returns>
        public async Task<GetNisTrafficMetricsResponse> GetNisTrafficMetricsWithOptionsAsync(GetNisTrafficMetricsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetNisTrafficMetricsShrinkRequest request = new GetNisTrafficMetricsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanBy))
            {
                query["ScanBy"] = request.ScanBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StepMinutes))
            {
                query["StepMinutes"] = request.StepMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageInterval))
            {
                query["StorageInterval"] = request.StorageInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficAnalyzerId))
            {
                query["TrafficAnalyzerId"] = request.TrafficAnalyzerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficScenario))
            {
                query["TrafficScenario"] = request.TrafficScenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TupleDimension))
            {
                query["TupleDimension"] = request.TupleDimension;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNisTrafficMetrics",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNisTrafficMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the metric trends for network traffic analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNisTrafficMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNisTrafficMetricsResponse
        /// </returns>
        public GetNisTrafficMetricsResponse GetNisTrafficMetrics(GetNisTrafficMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNisTrafficMetricsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the metric trends for network traffic analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNisTrafficMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNisTrafficMetricsResponse
        /// </returns>
        public async Task<GetNisTrafficMetricsResponse> GetNisTrafficMetricsAsync(GetNisTrafficMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNisTrafficMetricsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetTransitRouterFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the rankings of inter-region traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Inter-region traffic data can be ranked by metrics such as traffic volumes and the number of packets.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetTransitRouterFlowTopNRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTransitRouterFlowTopNResponse
        /// </returns>
        [Obsolete("OpenAPI GetTransitRouterFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public GetTransitRouterFlowTopNResponse GetTransitRouterFlowTopNWithOptions(GetTransitRouterFlowTopNRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTransitRouterFlowTopNShrinkRequest request = new GetTransitRouterFlowTopNShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                query["AccountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwithPackageId))
            {
                query["BandwithPackageId"] = request.BandwithPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherIp))
            {
                query["OtherIp"] = request.OtherIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherPort))
            {
                query["OtherPort"] = request.OtherPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherRegion))
            {
                query["OtherRegion"] = request.OtherRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThisIp))
            {
                query["ThisIp"] = request.ThisIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThisPort))
            {
                query["ThisPort"] = request.ThisPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThisRegion))
            {
                query["ThisRegion"] = request.ThisRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["TopN"] = request.TopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseMultiAccount))
            {
                query["UseMultiAccount"] = request.UseMultiAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTransitRouterFlowTopN",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTransitRouterFlowTopNResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetTransitRouterFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the rankings of inter-region traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Inter-region traffic data can be ranked by metrics such as traffic volumes and the number of packets.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetTransitRouterFlowTopNRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTransitRouterFlowTopNResponse
        /// </returns>
        [Obsolete("OpenAPI GetTransitRouterFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public async Task<GetTransitRouterFlowTopNResponse> GetTransitRouterFlowTopNWithOptionsAsync(GetTransitRouterFlowTopNRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetTransitRouterFlowTopNShrinkRequest request = new GetTransitRouterFlowTopNShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                query["AccountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwithPackageId))
            {
                query["BandwithPackageId"] = request.BandwithPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherIp))
            {
                query["OtherIp"] = request.OtherIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherPort))
            {
                query["OtherPort"] = request.OtherPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherRegion))
            {
                query["OtherRegion"] = request.OtherRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThisIp))
            {
                query["ThisIp"] = request.ThisIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThisPort))
            {
                query["ThisPort"] = request.ThisPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThisRegion))
            {
                query["ThisRegion"] = request.ThisRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["TopN"] = request.TopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseMultiAccount))
            {
                query["UseMultiAccount"] = request.UseMultiAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTransitRouterFlowTopN",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTransitRouterFlowTopNResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetTransitRouterFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the rankings of inter-region traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Inter-region traffic data can be ranked by metrics such as traffic volumes and the number of packets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTransitRouterFlowTopNRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTransitRouterFlowTopNResponse
        /// </returns>
        [Obsolete("OpenAPI GetTransitRouterFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public GetTransitRouterFlowTopNResponse GetTransitRouterFlowTopN(GetTransitRouterFlowTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTransitRouterFlowTopNWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetTransitRouterFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the rankings of inter-region traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Inter-region traffic data can be ranked by metrics such as traffic volumes and the number of packets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTransitRouterFlowTopNRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTransitRouterFlowTopNResponse
        /// </returns>
        [Obsolete("OpenAPI GetTransitRouterFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public async Task<GetTransitRouterFlowTopNResponse> GetTransitRouterFlowTopNAsync(GetTransitRouterFlowTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTransitRouterFlowTopNWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetVbrFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the rankings of hybrid cloud traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Hybrid cloud traffic data can be ranked by metrics such as traffic volumes and the number of packets.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetVbrFlowTopNRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVbrFlowTopNResponse
        /// </returns>
        [Obsolete("OpenAPI GetVbrFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public GetVbrFlowTopNResponse GetVbrFlowTopNWithOptions(GetVbrFlowTopNRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetVbrFlowTopNShrinkRequest request = new GetVbrFlowTopNShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                query["AccountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentId))
            {
                query["AttachmentId"] = request.AttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudIp))
            {
                query["CloudIp"] = request.CloudIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudPort))
            {
                query["CloudPort"] = request.CloudPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherIp))
            {
                query["OtherIp"] = request.OtherIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherPort))
            {
                query["OtherPort"] = request.OtherPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["TopN"] = request.TopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseMultiAccount))
            {
                query["UseMultiAccount"] = request.UseMultiAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualBorderRouterId))
            {
                query["VirtualBorderRouterId"] = request.VirtualBorderRouterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVbrFlowTopN",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVbrFlowTopNResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetVbrFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the rankings of hybrid cloud traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Hybrid cloud traffic data can be ranked by metrics such as traffic volumes and the number of packets.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetVbrFlowTopNRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVbrFlowTopNResponse
        /// </returns>
        [Obsolete("OpenAPI GetVbrFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public async Task<GetVbrFlowTopNResponse> GetVbrFlowTopNWithOptionsAsync(GetVbrFlowTopNRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetVbrFlowTopNShrinkRequest request = new GetVbrFlowTopNShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccountIds))
            {
                request.AccountIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccountIds, "AccountIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountIdsShrink))
            {
                query["AccountIds"] = request.AccountIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachmentId))
            {
                query["AttachmentId"] = request.AttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudIp))
            {
                query["CloudIp"] = request.CloudIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudPort))
            {
                query["CloudPort"] = request.CloudPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherIp))
            {
                query["OtherIp"] = request.OtherIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherPort))
            {
                query["OtherPort"] = request.OtherPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["TopN"] = request.TopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseMultiAccount))
            {
                query["UseMultiAccount"] = request.UseMultiAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualBorderRouterId))
            {
                query["VirtualBorderRouterId"] = request.VirtualBorderRouterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVbrFlowTopN",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVbrFlowTopNResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetVbrFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the rankings of hybrid cloud traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Hybrid cloud traffic data can be ranked by metrics such as traffic volumes and the number of packets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVbrFlowTopNRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVbrFlowTopNResponse
        /// </returns>
        [Obsolete("OpenAPI GetVbrFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public GetVbrFlowTopNResponse GetVbrFlowTopN(GetVbrFlowTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVbrFlowTopNWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetVbrFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the rankings of hybrid cloud traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Hybrid cloud traffic data can be ranked by metrics such as traffic volumes and the number of packets.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVbrFlowTopNRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVbrFlowTopNResponse
        /// </returns>
        [Obsolete("OpenAPI GetVbrFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.")]
        // Deprecated
        public async Task<GetVbrFlowTopNResponse> GetVbrFlowTopNAsync(GetVbrFlowTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVbrFlowTopNWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the resource types available for inspection.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNisInspectionResourceTypeResponse
        /// </returns>
        public ListNisInspectionResourceTypeResponse ListNisInspectionResourceTypeWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNisInspectionResourceType",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNisInspectionResourceTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the resource types available for inspection.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNisInspectionResourceTypeResponse
        /// </returns>
        public async Task<ListNisInspectionResourceTypeResponse> ListNisInspectionResourceTypeWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNisInspectionResourceType",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNisInspectionResourceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the resource types available for inspection.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListNisInspectionResourceTypeResponse
        /// </returns>
        public ListNisInspectionResourceTypeResponse ListNisInspectionResourceType()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNisInspectionResourceTypeWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the resource types available for inspection.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListNisInspectionResourceTypeResponse
        /// </returns>
        public async Task<ListNisInspectionResourceTypeResponse> ListNisInspectionResourceTypeAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNisInspectionResourceTypeWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of inspection task reports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNisInspectionTaskReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNisInspectionTaskReportsResponse
        /// </returns>
        public ListNisInspectionTaskReportsResponse ListNisInspectionTaskReportsWithOptions(ListNisInspectionTaskReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionTaskId))
            {
                query["InspectionTaskId"] = request.InspectionTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNisInspectionTaskReports",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNisInspectionTaskReportsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of inspection task reports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNisInspectionTaskReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNisInspectionTaskReportsResponse
        /// </returns>
        public async Task<ListNisInspectionTaskReportsResponse> ListNisInspectionTaskReportsWithOptionsAsync(ListNisInspectionTaskReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionTaskId))
            {
                query["InspectionTaskId"] = request.InspectionTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNisInspectionTaskReports",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNisInspectionTaskReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of inspection task reports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNisInspectionTaskReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNisInspectionTaskReportsResponse
        /// </returns>
        public ListNisInspectionTaskReportsResponse ListNisInspectionTaskReports(ListNisInspectionTaskReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNisInspectionTaskReportsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of inspection task reports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNisInspectionTaskReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNisInspectionTaskReportsResponse
        /// </returns>
        public async Task<ListNisInspectionTaskReportsResponse> ListNisInspectionTaskReportsAsync(ListNisInspectionTaskReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNisInspectionTaskReportsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the network inspection tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNisInspectionTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNisInspectionTasksResponse
        /// </returns>
        public ListNisInspectionTasksResponse ListNisInspectionTasksWithOptions(ListNisInspectionTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionName))
            {
                query["InspectionName"] = request.InspectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionProject))
            {
                query["InspectionProject"] = request.InspectionProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionTaskId))
            {
                query["InspectionTaskId"] = request.InspectionTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNisInspectionTasks",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNisInspectionTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the network inspection tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNisInspectionTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNisInspectionTasksResponse
        /// </returns>
        public async Task<ListNisInspectionTasksResponse> ListNisInspectionTasksWithOptionsAsync(ListNisInspectionTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionName))
            {
                query["InspectionName"] = request.InspectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionProject))
            {
                query["InspectionProject"] = request.InspectionProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionTaskId))
            {
                query["InspectionTaskId"] = request.InspectionTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNisInspectionTasks",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNisInspectionTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the network inspection tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNisInspectionTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNisInspectionTasksResponse
        /// </returns>
        public ListNisInspectionTasksResponse ListNisInspectionTasks(ListNisInspectionTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNisInspectionTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the network inspection tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNisInspectionTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNisInspectionTasksResponse
        /// </returns>
        public async Task<ListNisInspectionTasksResponse> ListNisInspectionTasksAsync(ListNisInspectionTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNisInspectionTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an inspection task to generate an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartNisInspectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartNisInspectionTaskResponse
        /// </returns>
        public StartNisInspectionTaskResponse StartNisInspectionTaskWithOptions(StartNisInspectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionTaskId))
            {
                query["InspectionTaskId"] = request.InspectionTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartNisInspectionTask",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartNisInspectionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an inspection task to generate an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartNisInspectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartNisInspectionTaskResponse
        /// </returns>
        public async Task<StartNisInspectionTaskResponse> StartNisInspectionTaskWithOptionsAsync(StartNisInspectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionTaskId))
            {
                query["InspectionTaskId"] = request.InspectionTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartNisInspectionTask",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartNisInspectionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an inspection task to generate an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartNisInspectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartNisInspectionTaskResponse
        /// </returns>
        public StartNisInspectionTaskResponse StartNisInspectionTask(StartNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartNisInspectionTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an inspection task to generate an inspection report.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartNisInspectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartNisInspectionTaskResponse
        /// </returns>
        public async Task<StartNisInspectionTaskResponse> StartNisInspectionTaskAsync(StartNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartNisInspectionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers the NIS traffic analyzer to execute a traffic sorting task within a specified scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><a href="https://www.alibabacloud.com/help/en/nis/product-overview/billing-method-new-version">Before using this operation, make sure that you fully understand the billing method and pricing of the NIS traffic analyzer.</a>
        /// Before using this operation, create a traffic analyzer and add a data source.
        /// <a href="https://www.alibabacloud.com/help/en/nis/user-guide/traffic-analyzer-management#39d1693bce6yp">Create a traffic analyzer</a>
        /// <a href="https://www.alibabacloud.com/help/en/nis/user-guide/data-source-management#73845748bfstv">Add a data source</a>
        /// Supported analysis scenarios: </para>
        /// <list type="bullet">
        /// <item><description>All VPC network traffic analysis</description></item>
        /// <item><description>Internet VPC network traffic analysis</description></item>
        /// <item><description>All TR network traffic analysis</description></item>
        /// <item><description>Internet Shared Bandwidth metric analysis</description></item>
        /// </list>
        /// <h2>All VPC flow log analysis.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The region where the resource resides.</td>
        /// <td>cn-shanghai</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficAnalyzerId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The traffic analyzer ID.</td>
        /// <td>nta-262****ca07f</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficScenario</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The supported analysis scenario:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● All VPC flow log analysis</td>
        /// <td>Fixed value: VpcFlowLogAll</td>
        /// <td>VpcFlowLogAll</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The network traffic direction based on Alibaba Cloud resources. ● In: Traffic flowing into the elastic network interface (ENI).</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● Out: Traffic flowing out of the elastic network interface (ENI).</td>
        /// <td>In</td>
        /// <td>- In</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description>Out                                                                                                                                                                                                                                                                                                                                                                                                                                            |
        /// | TupleDimension    | string   | Yes   | The traffic storage aggregation dimension.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Tuple1                 | - Tuple1 </description></item>
        /// <item><description>Tuple2 </description></item>
        /// <item><description>Tuple5                                                                                                                                                                                                                                                                                                                                                                                                                              |
        /// | GroupBy           | array    | No   | Specifies multiple traffic dimensions for aggregation and sorting.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |  | -                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
        /// |                   | string   | No   | Based on the TupleDimension field, you can specify the following aggregation dimensions:</description></item>
        /// </list>
        /// <para>● When TupleDimension = Tuple1:
        /// 　■  VpcId: VPC ID
        /// 　■  VSwitchId: vSwitch ID
        /// 　■  NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■  EcsId: ECS instance ID
        /// 　■  CloudIp: Cloud IP
        /// ● When TupleDimension = Tuple2:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// ● When TupleDimension = Tuple5:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// 　■ SourcePort: Source port
        /// 　■ DestinationPort: Destination port
        /// 　■ Protocol: Network protocol | [&quot;VpcId&quot;]                                | - VpcId</para>
        /// <list type="bullet">
        /// <item><description>VSwitchId</description></item>
        /// <item><description>CloudIp</description></item>
        /// <item><description>SourceIp</description></item>
        /// <item><description>DestinationIp</description></item>
        /// <item><description>Protocol</description></item>
        /// <item><description>SourcePort</description></item>
        /// <item><description>DestinationPort</description></item>
        /// <item><description>TrafficPath</description></item>
        /// <item><description>Country</description></item>
        /// <item><description>Province</description></item>
        /// <item><description>City</description></item>
        /// <item><description>Isp</description></item>
        /// <item><description>Asn                                                                                                                                                                                                                                          |
        /// | OrderBy           | string   | Yes   | Based on the TrafficScenario field, the following traffic metrics are supported for sorting:
        /// TrafficScenario = VpcFlowLogAll / VpcFlowLogInternet (VPC flow log scenario):
        /// ● Bytes: Bandwidth
        /// ● Packets: Packet count
        /// ● RoundTripTime: TCP RTT                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Bytes                                    | - Bytes</description></item>
        /// <item><description>Packets</description></item>
        /// <item><description>RoundTripTime                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | Filter            | array    | No   | Specifies additional filter conditions for focused traffic analysis.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |                                          | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// |                   | object   | No   | The filter condition for traffic, a Key-Value-Operator object.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |                                          | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |</description></item>
        /// </list>
        /// <para>| key               | string   | No   | The supported filter condition label keys are as follows:</para>
        /// <list type="bullet">
        /// <item><description>When <c>TupleDimension</c> is 1-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (<b>required</b>, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>CloudIp</c>: Cloud IP (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 2-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (<b>required</b>, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP (the corresponding value supports multiple selections)
        /// 　- <c>DestinationIp</c>: Destination IP (the corresponding value supports multiple selections)
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 5-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (<b>required</b>, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP
        /// 　- <c>DestinationIp</c>: Destination IP
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)
        /// 　- <c>SourcePort</c>: Source port (the corresponding value supports multiple selections)
        /// 　- <c>DestinationPort</c>: Destination port (the corresponding value supports multiple selections)
        /// 　- <c>Protocol</c>: Network protocol (the corresponding value supports multiple selections)</description></item>
        /// <item><description>In VPC scenarios, you can also filter by traffic metrics:
        /// 　- <c>MinBytes</c>: The minimum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)
        /// 　- <c>MaxBytes</c>: The maximum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)
        /// 　- <c>MinRoundTripTime</c>: The minimum RTT for sorting, in ms (the corresponding value does not support multiple selections)
        /// 　- <c>MaxRoundTripTime</c>: The maximum RTT for sorting, in ms (the corresponding value does not support multiple selections)
        /// 　- <c>MinPackages</c>: The minimum packet count for sorting (the corresponding value does not support multiple selections)
        /// 　- <c>MaxPackages</c>: The maximum packet count for sorting (the corresponding value does not support multiple selections) | FlowAction                               | - FlowAction</description></item>
        /// <item><description>VpcId</description></item>
        /// <item><description>VSwitchId</description></item>
        /// <item><description>NetworkInterfaceId</description></item>
        /// <item><description>CloudIp</description></item>
        /// <item><description>DestinationIp</description></item>
        /// <item><description>SourceIp</description></item>
        /// <item><description>EcsId</description></item>
        /// <item><description>TrafficPath</description></item>
        /// <item><description>SourcePort</description></item>
        /// <item><description>DestinationPort</description></item>
        /// <item><description>Protocol</description></item>
        /// <item><description>MinBytes</description></item>
        /// <item><description>MaxBytes</description></item>
        /// <item><description>MinRoundTripTime</description></item>
        /// <item><description>MaxRoundTripTime</description></item>
        /// <item><description>MinPackages</description></item>
        /// <item><description>MaxPackages                                                                                                                |
        /// | value             | array    | No   | The filter condition values.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |                                          | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// |                   | string   | No   | The filter value corresponding to the specified key type.</description></item>
        /// </list>
        /// <para>When the key is <c>FlowAction</c>, the valid values are:
        /// 　- <c>ACCEPT</c> (default: <c>Accept</c>): Traffic allowed by security groups and network ACLs
        /// 　- <c>REJECT</c>: Traffic denied by security groups and network ACLs                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | Accept                                   | When the key is FlowAction: ACCEPT / REJECT                                                                                                                                                                                                                                                                                                                                                              |
        /// | Operator          | string   | No   | For specified key types, some support operators for character string matching on the passed value. The supported values are as follows (default: in):
        /// ● in: Equals
        /// ● not in: Not equals
        /// ● like: Contains
        /// Based on the TupleDimension and TrafficScenario fields, the support for <c>like</c> is as follows:
        /// TrafficScenario = VpcFlowLogAll / VpcFlowLogInternet (VPC flow log scenario):
        /// The following keys support <c>like</c>:
        /// 　○ CloudIp
        /// 　○ SourceIp
        /// 　○ DestinationIp
        /// All other keys support only <c>in</c> and <c>not in</c> operators.                                                                                                                                                                                                                                                                                                                                                                                                                           | in                                       | - not in</para>
        /// <list type="bullet">
        /// <item><description>in</description></item>
        /// <item><description>like                                                                                                                                                                                                                                                                                                                                                                                                                                   |
        /// | BeginTime         | long     | Yes   | The start time of the query as a millisecond UNIX timestamp.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | 1638239092000                            | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | EndTime           | long     | Yes   | The end time of the query as a millisecond UNIX timestamp.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | 1684373700099                            | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | Sort              | string   | No   | The sorting order for traffic analysis:
        /// ● ASC: Ascending order.
        /// ● DESC: Descending order.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Desc                                     | - Desc</description></item>
        /// <item><description>Asc                                                                                                                                                                                                                                                                                                                                                                                                                                           |
        /// | TopN              | integer  | No   | The number of entries to return for the traffic sorting query.
        /// You can specify a custom number. If this field is not specified, all traffic data that meets the specified conditions is sorted and analyzed within the performance limits of traffic analysis data.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | 10                                       | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | Language          | string   | No   | The language. Valid values: zh-CN, en-US.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | zh-CN                                    | - zh-CN</description></item>
        /// <item><description>en-US                                                                                                                                                                                                                                                                                                                                                                                                                                        |
        /// | NextToken         | string   | No   | The pagination token. Leave this parameter empty for the first query or when no more results are available. If more results exist, set this to the NextToken value returned by the previous API call.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | 2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+ | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | MaxResults        | integer  | No   | The page size. Valid values: 1 to 100. Default value: 20.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | 20                                       |                                                                                                                                                                                                                                                                                                                                                                                                                                         |
        /// | StorageInterval   | integer  | No   | The storage bucket granularity property.
        /// The storage bucket granularity specifies the storage aggregation period for the query. Two granularity levels are supported: high-precision (such as 1 minute) and long-period (such as 1 day). The specific granularity is determined by the traffic analysis sampling interval configured for high-precision or long-period traffic statistics when creating or editing the traffic analyzer.</description></item>
        /// <item><description>The supported storage granularity values for the traffic analyzer tuple are:
        /// 　- <c>1</c>: In minutes (1 minute)
        /// 　- <c>10</c>: In minutes (10 minutes)
        /// 　- <c>60</c>: In minutes (60 minutes, i.e., 1 hour)
        /// 　- <c>1440</c>: In minutes (1440 minutes, i.e., 1 day)</description></item>
        /// <item><description>The storage bucket granularity serves two typical purposes:
        /// 　- High-precision traffic statistics: such as 1-minute, 10-minute, or 60-minute aggregation
        /// 　- Long-period traffic statistics: such as 1440-minute (1-day) aggregation</description></item>
        /// <item><description>Specify this field during the query to select the storage aggregation period. For example:
        /// 　- Pass <c>10</c>: Query short-period data aggregated at 10-minute granularity
        /// 　- Pass <c>1440</c>: Query long-period data aggregated at 1-day granularity | 10                                       | - 1</description></item>
        /// <item><description>10</description></item>
        /// <item><description>60</description></item>
        /// <item><description>1440                                                                                                                                                                                                                                                                                                                                                                                                                                   |</description></item>
        /// </list>
        /// <h3>Response elements</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example value</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td></td>
        /// <td>object</td>
        /// <td>RpcResponse <ArrayList></td>
        /// <td></td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The result ID of this traffic ranking analysis. Call the DescribeNisTrafficRanking operation to obtain the final analysis results.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td>-</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>Internet VPC flow log analysis.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The region where the resource resides.</td>
        /// <td>cn-shanghai</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficAnalyzerId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The traffic analyzer ID.</td>
        /// <td>nta-262****ca07f</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficScenario</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The supported analysis scenario:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● Internet VPC flow log analysis</td>
        /// <td>Fixed value: VpcFlowLogInternet</td>
        /// <td>VpcFlowLogInternet</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The network traffic direction based on Alibaba Cloud resources. ● In: Traffic flowing into the elastic network interfaces (ENIs).</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● Out: Traffic flowing out of the elastic network interfaces (ENIs).</td>
        /// <td>In</td>
        /// <td>- In</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description>Out                                                                                                                                                                                                                                                                                                      |
        /// | TupleDimension    | string  | Yes   | The traffic storage aggregation dimension.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | Tuple1                                   | - Tuple1</description></item>
        /// <item><description>Tuple2</description></item>
        /// <item><description>Tuple5                                                                                                                                                                                                                                                                                    |
        /// | GroupBy           | array   | No   | Specifies multiple traffic dimensions for aggregation and sorting.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |                                          | -                                                                                                                                                                                                                                                                                                                |
        /// |                   | string  | No   | Based on the TupleDimension field, you can specify the following aggregation dimensions:</description></item>
        /// </list>
        /// <para>● When TupleDimension = Tuple1:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ CloudIp: Cloud IP
        /// ● When TupleDimension = Tuple2:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// 　■ <c>Country</c>: Client country
        /// 　■ <c>Province</c>: Client province
        /// 　■ <c>City</c>: Client city
        /// 　■ <c>Isp</c>: Internet service provider
        /// 　■ <c>Asn</c>: Autonomous system number
        /// ● When TupleDimension = Tuple5:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// 　■ SourcePort: Source port
        /// 　■ DestinationPort: Destination port
        /// 　■ Protocol: Network protocol
        /// 　■ Country: Client country
        /// 　■ Province: Client province
        /// 　■ City: Client city
        /// 　■ Isp: Internet service provider
        /// 　■ Asn: Autonomous system number | [&quot;VpcId&quot;]                                | - VpcId</para>
        /// <list type="bullet">
        /// <item><description>VSwitchId</description></item>
        /// <item><description>CloudIp</description></item>
        /// <item><description>SourceIp</description></item>
        /// <item><description>DestinationIp</description></item>
        /// <item><description>Protocol</description></item>
        /// <item><description>SourcePort</description></item>
        /// <item><description>DestinationPort</description></item>
        /// <item><description>TrafficPath</description></item>
        /// <item><description>Country</description></item>
        /// <item><description>Province</description></item>
        /// <item><description>City</description></item>
        /// <item><description>Isp</description></item>
        /// <item><description>Asn                                                                                         |
        /// | OrderBy           | string  | Yes   | The following traffic metrics are supported for sorting: Bytes, Packets, RoundTripTime.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Bytes                                    | - Bytes</description></item>
        /// <item><description>Packets</description></item>
        /// <item><description>RoundTripTime                                                                                                                                                                                                                                                                         |
        /// | Filter            | array   | No   | Specifies additional filter conditions for focused traffic analysis.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |                                          | -                                                                                                                                                                                                                                                                                                                |
        /// |                   | object  | No   | The filter condition for traffic, a Key-Value-Operator object.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |                                          | -                                                                                                                                                                                                                                                                                                                |</description></item>
        /// </list>
        /// <para>| key               | string  | No   | The supported filter condition label keys are as follows:</para>
        /// <list type="bullet">
        /// <item><description>When <c>TupleDimension</c> is 1-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (required, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>CloudIp</c>: Cloud IP (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 2-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (required, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP (the corresponding value supports multiple selections)
        /// 　- <c>DestinationIp</c>: Destination IP (the corresponding value supports multiple selections)
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)
        /// 　- <c>ClientCountry</c>: Filter traffic analysis scope by country (the corresponding value supports multiple selections)
        /// 　- <c>ClientCity</c>: Filter traffic analysis scope by city (the corresponding value supports multiple selections)
        /// 　- <c>ClientAsn</c>: Filter traffic analysis scope by ASN (the corresponding value supports multiple selections)
        /// 　- <c>ClientIsp</c>: Filter traffic analysis scope by client ISP (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 5-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (required, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP
        /// 　- <c>DestinationIp</c>: Destination IP
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)
        /// 　- <c>SourcePort</c>: Source port (the corresponding value supports multiple selections)
        /// 　- <c>DestinationPort</c>: Destination port (the corresponding value supports multiple selections)</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// StartNisTrafficRankingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartNisTrafficRankingResponse
        /// </returns>
        public StartNisTrafficRankingResponse StartNisTrafficRankingWithOptions(StartNisTrafficRankingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartNisTrafficRankingShrinkRequest request = new StartNisTrafficRankingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupBy))
            {
                request.GroupByShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupBy, "GroupBy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupByShrink))
            {
                query["GroupBy"] = request.GroupByShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageInterval))
            {
                query["StorageInterval"] = request.StorageInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["TopN"] = request.TopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficAnalyzerId))
            {
                query["TrafficAnalyzerId"] = request.TrafficAnalyzerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficScenario))
            {
                query["TrafficScenario"] = request.TrafficScenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TupleDimension))
            {
                query["TupleDimension"] = request.TupleDimension;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartNisTrafficRanking",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartNisTrafficRankingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers the NIS traffic analyzer to execute a traffic sorting task within a specified scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><a href="https://www.alibabacloud.com/help/en/nis/product-overview/billing-method-new-version">Before using this operation, make sure that you fully understand the billing method and pricing of the NIS traffic analyzer.</a>
        /// Before using this operation, create a traffic analyzer and add a data source.
        /// <a href="https://www.alibabacloud.com/help/en/nis/user-guide/traffic-analyzer-management#39d1693bce6yp">Create a traffic analyzer</a>
        /// <a href="https://www.alibabacloud.com/help/en/nis/user-guide/data-source-management#73845748bfstv">Add a data source</a>
        /// Supported analysis scenarios: </para>
        /// <list type="bullet">
        /// <item><description>All VPC network traffic analysis</description></item>
        /// <item><description>Internet VPC network traffic analysis</description></item>
        /// <item><description>All TR network traffic analysis</description></item>
        /// <item><description>Internet Shared Bandwidth metric analysis</description></item>
        /// </list>
        /// <h2>All VPC flow log analysis.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The region where the resource resides.</td>
        /// <td>cn-shanghai</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficAnalyzerId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The traffic analyzer ID.</td>
        /// <td>nta-262****ca07f</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficScenario</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The supported analysis scenario:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● All VPC flow log analysis</td>
        /// <td>Fixed value: VpcFlowLogAll</td>
        /// <td>VpcFlowLogAll</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The network traffic direction based on Alibaba Cloud resources. ● In: Traffic flowing into the elastic network interface (ENI).</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● Out: Traffic flowing out of the elastic network interface (ENI).</td>
        /// <td>In</td>
        /// <td>- In</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description>Out                                                                                                                                                                                                                                                                                                                                                                                                                                            |
        /// | TupleDimension    | string   | Yes   | The traffic storage aggregation dimension.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Tuple1                 | - Tuple1 </description></item>
        /// <item><description>Tuple2 </description></item>
        /// <item><description>Tuple5                                                                                                                                                                                                                                                                                                                                                                                                                              |
        /// | GroupBy           | array    | No   | Specifies multiple traffic dimensions for aggregation and sorting.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |  | -                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
        /// |                   | string   | No   | Based on the TupleDimension field, you can specify the following aggregation dimensions:</description></item>
        /// </list>
        /// <para>● When TupleDimension = Tuple1:
        /// 　■  VpcId: VPC ID
        /// 　■  VSwitchId: vSwitch ID
        /// 　■  NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■  EcsId: ECS instance ID
        /// 　■  CloudIp: Cloud IP
        /// ● When TupleDimension = Tuple2:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// ● When TupleDimension = Tuple5:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// 　■ SourcePort: Source port
        /// 　■ DestinationPort: Destination port
        /// 　■ Protocol: Network protocol | [&quot;VpcId&quot;]                                | - VpcId</para>
        /// <list type="bullet">
        /// <item><description>VSwitchId</description></item>
        /// <item><description>CloudIp</description></item>
        /// <item><description>SourceIp</description></item>
        /// <item><description>DestinationIp</description></item>
        /// <item><description>Protocol</description></item>
        /// <item><description>SourcePort</description></item>
        /// <item><description>DestinationPort</description></item>
        /// <item><description>TrafficPath</description></item>
        /// <item><description>Country</description></item>
        /// <item><description>Province</description></item>
        /// <item><description>City</description></item>
        /// <item><description>Isp</description></item>
        /// <item><description>Asn                                                                                                                                                                                                                                          |
        /// | OrderBy           | string   | Yes   | Based on the TrafficScenario field, the following traffic metrics are supported for sorting:
        /// TrafficScenario = VpcFlowLogAll / VpcFlowLogInternet (VPC flow log scenario):
        /// ● Bytes: Bandwidth
        /// ● Packets: Packet count
        /// ● RoundTripTime: TCP RTT                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Bytes                                    | - Bytes</description></item>
        /// <item><description>Packets</description></item>
        /// <item><description>RoundTripTime                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | Filter            | array    | No   | Specifies additional filter conditions for focused traffic analysis.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |                                          | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// |                   | object   | No   | The filter condition for traffic, a Key-Value-Operator object.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |                                          | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |</description></item>
        /// </list>
        /// <para>| key               | string   | No   | The supported filter condition label keys are as follows:</para>
        /// <list type="bullet">
        /// <item><description>When <c>TupleDimension</c> is 1-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (<b>required</b>, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>CloudIp</c>: Cloud IP (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 2-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (<b>required</b>, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP (the corresponding value supports multiple selections)
        /// 　- <c>DestinationIp</c>: Destination IP (the corresponding value supports multiple selections)
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 5-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (<b>required</b>, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP
        /// 　- <c>DestinationIp</c>: Destination IP
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)
        /// 　- <c>SourcePort</c>: Source port (the corresponding value supports multiple selections)
        /// 　- <c>DestinationPort</c>: Destination port (the corresponding value supports multiple selections)
        /// 　- <c>Protocol</c>: Network protocol (the corresponding value supports multiple selections)</description></item>
        /// <item><description>In VPC scenarios, you can also filter by traffic metrics:
        /// 　- <c>MinBytes</c>: The minimum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)
        /// 　- <c>MaxBytes</c>: The maximum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)
        /// 　- <c>MinRoundTripTime</c>: The minimum RTT for sorting, in ms (the corresponding value does not support multiple selections)
        /// 　- <c>MaxRoundTripTime</c>: The maximum RTT for sorting, in ms (the corresponding value does not support multiple selections)
        /// 　- <c>MinPackages</c>: The minimum packet count for sorting (the corresponding value does not support multiple selections)
        /// 　- <c>MaxPackages</c>: The maximum packet count for sorting (the corresponding value does not support multiple selections) | FlowAction                               | - FlowAction</description></item>
        /// <item><description>VpcId</description></item>
        /// <item><description>VSwitchId</description></item>
        /// <item><description>NetworkInterfaceId</description></item>
        /// <item><description>CloudIp</description></item>
        /// <item><description>DestinationIp</description></item>
        /// <item><description>SourceIp</description></item>
        /// <item><description>EcsId</description></item>
        /// <item><description>TrafficPath</description></item>
        /// <item><description>SourcePort</description></item>
        /// <item><description>DestinationPort</description></item>
        /// <item><description>Protocol</description></item>
        /// <item><description>MinBytes</description></item>
        /// <item><description>MaxBytes</description></item>
        /// <item><description>MinRoundTripTime</description></item>
        /// <item><description>MaxRoundTripTime</description></item>
        /// <item><description>MinPackages</description></item>
        /// <item><description>MaxPackages                                                                                                                |
        /// | value             | array    | No   | The filter condition values.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |                                          | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// |                   | string   | No   | The filter value corresponding to the specified key type.</description></item>
        /// </list>
        /// <para>When the key is <c>FlowAction</c>, the valid values are:
        /// 　- <c>ACCEPT</c> (default: <c>Accept</c>): Traffic allowed by security groups and network ACLs
        /// 　- <c>REJECT</c>: Traffic denied by security groups and network ACLs                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | Accept                                   | When the key is FlowAction: ACCEPT / REJECT                                                                                                                                                                                                                                                                                                                                                              |
        /// | Operator          | string   | No   | For specified key types, some support operators for character string matching on the passed value. The supported values are as follows (default: in):
        /// ● in: Equals
        /// ● not in: Not equals
        /// ● like: Contains
        /// Based on the TupleDimension and TrafficScenario fields, the support for <c>like</c> is as follows:
        /// TrafficScenario = VpcFlowLogAll / VpcFlowLogInternet (VPC flow log scenario):
        /// The following keys support <c>like</c>:
        /// 　○ CloudIp
        /// 　○ SourceIp
        /// 　○ DestinationIp
        /// All other keys support only <c>in</c> and <c>not in</c> operators.                                                                                                                                                                                                                                                                                                                                                                                                                           | in                                       | - not in</para>
        /// <list type="bullet">
        /// <item><description>in</description></item>
        /// <item><description>like                                                                                                                                                                                                                                                                                                                                                                                                                                   |
        /// | BeginTime         | long     | Yes   | The start time of the query as a millisecond UNIX timestamp.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | 1638239092000                            | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | EndTime           | long     | Yes   | The end time of the query as a millisecond UNIX timestamp.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | 1684373700099                            | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | Sort              | string   | No   | The sorting order for traffic analysis:
        /// ● ASC: Ascending order.
        /// ● DESC: Descending order.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Desc                                     | - Desc</description></item>
        /// <item><description>Asc                                                                                                                                                                                                                                                                                                                                                                                                                                           |
        /// | TopN              | integer  | No   | The number of entries to return for the traffic sorting query.
        /// You can specify a custom number. If this field is not specified, all traffic data that meets the specified conditions is sorted and analyzed within the performance limits of traffic analysis data.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | 10                                       | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | Language          | string   | No   | The language. Valid values: zh-CN, en-US.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | zh-CN                                    | - zh-CN</description></item>
        /// <item><description>en-US                                                                                                                                                                                                                                                                                                                                                                                                                                        |
        /// | NextToken         | string   | No   | The pagination token. Leave this parameter empty for the first query or when no more results are available. If more results exist, set this to the NextToken value returned by the previous API call.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | 2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+ | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | MaxResults        | integer  | No   | The page size. Valid values: 1 to 100. Default value: 20.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | 20                                       |                                                                                                                                                                                                                                                                                                                                                                                                                                         |
        /// | StorageInterval   | integer  | No   | The storage bucket granularity property.
        /// The storage bucket granularity specifies the storage aggregation period for the query. Two granularity levels are supported: high-precision (such as 1 minute) and long-period (such as 1 day). The specific granularity is determined by the traffic analysis sampling interval configured for high-precision or long-period traffic statistics when creating or editing the traffic analyzer.</description></item>
        /// <item><description>The supported storage granularity values for the traffic analyzer tuple are:
        /// 　- <c>1</c>: In minutes (1 minute)
        /// 　- <c>10</c>: In minutes (10 minutes)
        /// 　- <c>60</c>: In minutes (60 minutes, i.e., 1 hour)
        /// 　- <c>1440</c>: In minutes (1440 minutes, i.e., 1 day)</description></item>
        /// <item><description>The storage bucket granularity serves two typical purposes:
        /// 　- High-precision traffic statistics: such as 1-minute, 10-minute, or 60-minute aggregation
        /// 　- Long-period traffic statistics: such as 1440-minute (1-day) aggregation</description></item>
        /// <item><description>Specify this field during the query to select the storage aggregation period. For example:
        /// 　- Pass <c>10</c>: Query short-period data aggregated at 10-minute granularity
        /// 　- Pass <c>1440</c>: Query long-period data aggregated at 1-day granularity | 10                                       | - 1</description></item>
        /// <item><description>10</description></item>
        /// <item><description>60</description></item>
        /// <item><description>1440                                                                                                                                                                                                                                                                                                                                                                                                                                   |</description></item>
        /// </list>
        /// <h3>Response elements</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example value</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td></td>
        /// <td>object</td>
        /// <td>RpcResponse <ArrayList></td>
        /// <td></td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The result ID of this traffic ranking analysis. Call the DescribeNisTrafficRanking operation to obtain the final analysis results.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td>-</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>Internet VPC flow log analysis.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The region where the resource resides.</td>
        /// <td>cn-shanghai</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficAnalyzerId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The traffic analyzer ID.</td>
        /// <td>nta-262****ca07f</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficScenario</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The supported analysis scenario:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● Internet VPC flow log analysis</td>
        /// <td>Fixed value: VpcFlowLogInternet</td>
        /// <td>VpcFlowLogInternet</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The network traffic direction based on Alibaba Cloud resources. ● In: Traffic flowing into the elastic network interfaces (ENIs).</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● Out: Traffic flowing out of the elastic network interfaces (ENIs).</td>
        /// <td>In</td>
        /// <td>- In</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description>Out                                                                                                                                                                                                                                                                                                      |
        /// | TupleDimension    | string  | Yes   | The traffic storage aggregation dimension.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | Tuple1                                   | - Tuple1</description></item>
        /// <item><description>Tuple2</description></item>
        /// <item><description>Tuple5                                                                                                                                                                                                                                                                                    |
        /// | GroupBy           | array   | No   | Specifies multiple traffic dimensions for aggregation and sorting.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |                                          | -                                                                                                                                                                                                                                                                                                                |
        /// |                   | string  | No   | Based on the TupleDimension field, you can specify the following aggregation dimensions:</description></item>
        /// </list>
        /// <para>● When TupleDimension = Tuple1:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ CloudIp: Cloud IP
        /// ● When TupleDimension = Tuple2:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// 　■ <c>Country</c>: Client country
        /// 　■ <c>Province</c>: Client province
        /// 　■ <c>City</c>: Client city
        /// 　■ <c>Isp</c>: Internet service provider
        /// 　■ <c>Asn</c>: Autonomous system number
        /// ● When TupleDimension = Tuple5:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// 　■ SourcePort: Source port
        /// 　■ DestinationPort: Destination port
        /// 　■ Protocol: Network protocol
        /// 　■ Country: Client country
        /// 　■ Province: Client province
        /// 　■ City: Client city
        /// 　■ Isp: Internet service provider
        /// 　■ Asn: Autonomous system number | [&quot;VpcId&quot;]                                | - VpcId</para>
        /// <list type="bullet">
        /// <item><description>VSwitchId</description></item>
        /// <item><description>CloudIp</description></item>
        /// <item><description>SourceIp</description></item>
        /// <item><description>DestinationIp</description></item>
        /// <item><description>Protocol</description></item>
        /// <item><description>SourcePort</description></item>
        /// <item><description>DestinationPort</description></item>
        /// <item><description>TrafficPath</description></item>
        /// <item><description>Country</description></item>
        /// <item><description>Province</description></item>
        /// <item><description>City</description></item>
        /// <item><description>Isp</description></item>
        /// <item><description>Asn                                                                                         |
        /// | OrderBy           | string  | Yes   | The following traffic metrics are supported for sorting: Bytes, Packets, RoundTripTime.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Bytes                                    | - Bytes</description></item>
        /// <item><description>Packets</description></item>
        /// <item><description>RoundTripTime                                                                                                                                                                                                                                                                         |
        /// | Filter            | array   | No   | Specifies additional filter conditions for focused traffic analysis.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |                                          | -                                                                                                                                                                                                                                                                                                                |
        /// |                   | object  | No   | The filter condition for traffic, a Key-Value-Operator object.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |                                          | -                                                                                                                                                                                                                                                                                                                |</description></item>
        /// </list>
        /// <para>| key               | string  | No   | The supported filter condition label keys are as follows:</para>
        /// <list type="bullet">
        /// <item><description>When <c>TupleDimension</c> is 1-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (required, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>CloudIp</c>: Cloud IP (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 2-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (required, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP (the corresponding value supports multiple selections)
        /// 　- <c>DestinationIp</c>: Destination IP (the corresponding value supports multiple selections)
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)
        /// 　- <c>ClientCountry</c>: Filter traffic analysis scope by country (the corresponding value supports multiple selections)
        /// 　- <c>ClientCity</c>: Filter traffic analysis scope by city (the corresponding value supports multiple selections)
        /// 　- <c>ClientAsn</c>: Filter traffic analysis scope by ASN (the corresponding value supports multiple selections)
        /// 　- <c>ClientIsp</c>: Filter traffic analysis scope by client ISP (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 5-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (required, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP
        /// 　- <c>DestinationIp</c>: Destination IP
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)
        /// 　- <c>SourcePort</c>: Source port (the corresponding value supports multiple selections)
        /// 　- <c>DestinationPort</c>: Destination port (the corresponding value supports multiple selections)</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// StartNisTrafficRankingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartNisTrafficRankingResponse
        /// </returns>
        public async Task<StartNisTrafficRankingResponse> StartNisTrafficRankingWithOptionsAsync(StartNisTrafficRankingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartNisTrafficRankingShrinkRequest request = new StartNisTrafficRankingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "Filter", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GroupBy))
            {
                request.GroupByShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GroupBy, "GroupBy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["Filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupByShrink))
            {
                query["GroupBy"] = request.GroupByShrink;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageInterval))
            {
                query["StorageInterval"] = request.StorageInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                query["TopN"] = request.TopN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficAnalyzerId))
            {
                query["TrafficAnalyzerId"] = request.TrafficAnalyzerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficScenario))
            {
                query["TrafficScenario"] = request.TrafficScenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TupleDimension))
            {
                query["TupleDimension"] = request.TupleDimension;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartNisTrafficRanking",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartNisTrafficRankingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers the NIS traffic analyzer to execute a traffic sorting task within a specified scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><a href="https://www.alibabacloud.com/help/en/nis/product-overview/billing-method-new-version">Before using this operation, make sure that you fully understand the billing method and pricing of the NIS traffic analyzer.</a>
        /// Before using this operation, create a traffic analyzer and add a data source.
        /// <a href="https://www.alibabacloud.com/help/en/nis/user-guide/traffic-analyzer-management#39d1693bce6yp">Create a traffic analyzer</a>
        /// <a href="https://www.alibabacloud.com/help/en/nis/user-guide/data-source-management#73845748bfstv">Add a data source</a>
        /// Supported analysis scenarios: </para>
        /// <list type="bullet">
        /// <item><description>All VPC network traffic analysis</description></item>
        /// <item><description>Internet VPC network traffic analysis</description></item>
        /// <item><description>All TR network traffic analysis</description></item>
        /// <item><description>Internet Shared Bandwidth metric analysis</description></item>
        /// </list>
        /// <h2>All VPC flow log analysis.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The region where the resource resides.</td>
        /// <td>cn-shanghai</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficAnalyzerId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The traffic analyzer ID.</td>
        /// <td>nta-262****ca07f</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficScenario</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The supported analysis scenario:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● All VPC flow log analysis</td>
        /// <td>Fixed value: VpcFlowLogAll</td>
        /// <td>VpcFlowLogAll</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The network traffic direction based on Alibaba Cloud resources. ● In: Traffic flowing into the elastic network interface (ENI).</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● Out: Traffic flowing out of the elastic network interface (ENI).</td>
        /// <td>In</td>
        /// <td>- In</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description>Out                                                                                                                                                                                                                                                                                                                                                                                                                                            |
        /// | TupleDimension    | string   | Yes   | The traffic storage aggregation dimension.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Tuple1                 | - Tuple1 </description></item>
        /// <item><description>Tuple2 </description></item>
        /// <item><description>Tuple5                                                                                                                                                                                                                                                                                                                                                                                                                              |
        /// | GroupBy           | array    | No   | Specifies multiple traffic dimensions for aggregation and sorting.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |  | -                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
        /// |                   | string   | No   | Based on the TupleDimension field, you can specify the following aggregation dimensions:</description></item>
        /// </list>
        /// <para>● When TupleDimension = Tuple1:
        /// 　■  VpcId: VPC ID
        /// 　■  VSwitchId: vSwitch ID
        /// 　■  NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■  EcsId: ECS instance ID
        /// 　■  CloudIp: Cloud IP
        /// ● When TupleDimension = Tuple2:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// ● When TupleDimension = Tuple5:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// 　■ SourcePort: Source port
        /// 　■ DestinationPort: Destination port
        /// 　■ Protocol: Network protocol | [&quot;VpcId&quot;]                                | - VpcId</para>
        /// <list type="bullet">
        /// <item><description>VSwitchId</description></item>
        /// <item><description>CloudIp</description></item>
        /// <item><description>SourceIp</description></item>
        /// <item><description>DestinationIp</description></item>
        /// <item><description>Protocol</description></item>
        /// <item><description>SourcePort</description></item>
        /// <item><description>DestinationPort</description></item>
        /// <item><description>TrafficPath</description></item>
        /// <item><description>Country</description></item>
        /// <item><description>Province</description></item>
        /// <item><description>City</description></item>
        /// <item><description>Isp</description></item>
        /// <item><description>Asn                                                                                                                                                                                                                                          |
        /// | OrderBy           | string   | Yes   | Based on the TrafficScenario field, the following traffic metrics are supported for sorting:
        /// TrafficScenario = VpcFlowLogAll / VpcFlowLogInternet (VPC flow log scenario):
        /// ● Bytes: Bandwidth
        /// ● Packets: Packet count
        /// ● RoundTripTime: TCP RTT                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Bytes                                    | - Bytes</description></item>
        /// <item><description>Packets</description></item>
        /// <item><description>RoundTripTime                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | Filter            | array    | No   | Specifies additional filter conditions for focused traffic analysis.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |                                          | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// |                   | object   | No   | The filter condition for traffic, a Key-Value-Operator object.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |                                          | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |</description></item>
        /// </list>
        /// <para>| key               | string   | No   | The supported filter condition label keys are as follows:</para>
        /// <list type="bullet">
        /// <item><description>When <c>TupleDimension</c> is 1-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (<b>required</b>, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>CloudIp</c>: Cloud IP (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 2-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (<b>required</b>, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP (the corresponding value supports multiple selections)
        /// 　- <c>DestinationIp</c>: Destination IP (the corresponding value supports multiple selections)
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 5-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (<b>required</b>, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP
        /// 　- <c>DestinationIp</c>: Destination IP
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)
        /// 　- <c>SourcePort</c>: Source port (the corresponding value supports multiple selections)
        /// 　- <c>DestinationPort</c>: Destination port (the corresponding value supports multiple selections)
        /// 　- <c>Protocol</c>: Network protocol (the corresponding value supports multiple selections)</description></item>
        /// <item><description>In VPC scenarios, you can also filter by traffic metrics:
        /// 　- <c>MinBytes</c>: The minimum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)
        /// 　- <c>MaxBytes</c>: The maximum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)
        /// 　- <c>MinRoundTripTime</c>: The minimum RTT for sorting, in ms (the corresponding value does not support multiple selections)
        /// 　- <c>MaxRoundTripTime</c>: The maximum RTT for sorting, in ms (the corresponding value does not support multiple selections)
        /// 　- <c>MinPackages</c>: The minimum packet count for sorting (the corresponding value does not support multiple selections)
        /// 　- <c>MaxPackages</c>: The maximum packet count for sorting (the corresponding value does not support multiple selections) | FlowAction                               | - FlowAction</description></item>
        /// <item><description>VpcId</description></item>
        /// <item><description>VSwitchId</description></item>
        /// <item><description>NetworkInterfaceId</description></item>
        /// <item><description>CloudIp</description></item>
        /// <item><description>DestinationIp</description></item>
        /// <item><description>SourceIp</description></item>
        /// <item><description>EcsId</description></item>
        /// <item><description>TrafficPath</description></item>
        /// <item><description>SourcePort</description></item>
        /// <item><description>DestinationPort</description></item>
        /// <item><description>Protocol</description></item>
        /// <item><description>MinBytes</description></item>
        /// <item><description>MaxBytes</description></item>
        /// <item><description>MinRoundTripTime</description></item>
        /// <item><description>MaxRoundTripTime</description></item>
        /// <item><description>MinPackages</description></item>
        /// <item><description>MaxPackages                                                                                                                |
        /// | value             | array    | No   | The filter condition values.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |                                          | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// |                   | string   | No   | The filter value corresponding to the specified key type.</description></item>
        /// </list>
        /// <para>When the key is <c>FlowAction</c>, the valid values are:
        /// 　- <c>ACCEPT</c> (default: <c>Accept</c>): Traffic allowed by security groups and network ACLs
        /// 　- <c>REJECT</c>: Traffic denied by security groups and network ACLs                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | Accept                                   | When the key is FlowAction: ACCEPT / REJECT                                                                                                                                                                                                                                                                                                                                                              |
        /// | Operator          | string   | No   | For specified key types, some support operators for character string matching on the passed value. The supported values are as follows (default: in):
        /// ● in: Equals
        /// ● not in: Not equals
        /// ● like: Contains
        /// Based on the TupleDimension and TrafficScenario fields, the support for <c>like</c> is as follows:
        /// TrafficScenario = VpcFlowLogAll / VpcFlowLogInternet (VPC flow log scenario):
        /// The following keys support <c>like</c>:
        /// 　○ CloudIp
        /// 　○ SourceIp
        /// 　○ DestinationIp
        /// All other keys support only <c>in</c> and <c>not in</c> operators.                                                                                                                                                                                                                                                                                                                                                                                                                           | in                                       | - not in</para>
        /// <list type="bullet">
        /// <item><description>in</description></item>
        /// <item><description>like                                                                                                                                                                                                                                                                                                                                                                                                                                   |
        /// | BeginTime         | long     | Yes   | The start time of the query as a millisecond UNIX timestamp.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | 1638239092000                            | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | EndTime           | long     | Yes   | The end time of the query as a millisecond UNIX timestamp.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | 1684373700099                            | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | Sort              | string   | No   | The sorting order for traffic analysis:
        /// ● ASC: Ascending order.
        /// ● DESC: Descending order.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Desc                                     | - Desc</description></item>
        /// <item><description>Asc                                                                                                                                                                                                                                                                                                                                                                                                                                           |
        /// | TopN              | integer  | No   | The number of entries to return for the traffic sorting query.
        /// You can specify a custom number. If this field is not specified, all traffic data that meets the specified conditions is sorted and analyzed within the performance limits of traffic analysis data.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | 10                                       | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | Language          | string   | No   | The language. Valid values: zh-CN, en-US.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | zh-CN                                    | - zh-CN</description></item>
        /// <item><description>en-US                                                                                                                                                                                                                                                                                                                                                                                                                                        |
        /// | NextToken         | string   | No   | The pagination token. Leave this parameter empty for the first query or when no more results are available. If more results exist, set this to the NextToken value returned by the previous API call.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | 2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+ | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | MaxResults        | integer  | No   | The page size. Valid values: 1 to 100. Default value: 20.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | 20                                       |                                                                                                                                                                                                                                                                                                                                                                                                                                         |
        /// | StorageInterval   | integer  | No   | The storage bucket granularity property.
        /// The storage bucket granularity specifies the storage aggregation period for the query. Two granularity levels are supported: high-precision (such as 1 minute) and long-period (such as 1 day). The specific granularity is determined by the traffic analysis sampling interval configured for high-precision or long-period traffic statistics when creating or editing the traffic analyzer.</description></item>
        /// <item><description>The supported storage granularity values for the traffic analyzer tuple are:
        /// 　- <c>1</c>: In minutes (1 minute)
        /// 　- <c>10</c>: In minutes (10 minutes)
        /// 　- <c>60</c>: In minutes (60 minutes, i.e., 1 hour)
        /// 　- <c>1440</c>: In minutes (1440 minutes, i.e., 1 day)</description></item>
        /// <item><description>The storage bucket granularity serves two typical purposes:
        /// 　- High-precision traffic statistics: such as 1-minute, 10-minute, or 60-minute aggregation
        /// 　- Long-period traffic statistics: such as 1440-minute (1-day) aggregation</description></item>
        /// <item><description>Specify this field during the query to select the storage aggregation period. For example:
        /// 　- Pass <c>10</c>: Query short-period data aggregated at 10-minute granularity
        /// 　- Pass <c>1440</c>: Query long-period data aggregated at 1-day granularity | 10                                       | - 1</description></item>
        /// <item><description>10</description></item>
        /// <item><description>60</description></item>
        /// <item><description>1440                                                                                                                                                                                                                                                                                                                                                                                                                                   |</description></item>
        /// </list>
        /// <h3>Response elements</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example value</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td></td>
        /// <td>object</td>
        /// <td>RpcResponse <ArrayList></td>
        /// <td></td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The result ID of this traffic ranking analysis. Call the DescribeNisTrafficRanking operation to obtain the final analysis results.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td>-</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>Internet VPC flow log analysis.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The region where the resource resides.</td>
        /// <td>cn-shanghai</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficAnalyzerId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The traffic analyzer ID.</td>
        /// <td>nta-262****ca07f</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficScenario</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The supported analysis scenario:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● Internet VPC flow log analysis</td>
        /// <td>Fixed value: VpcFlowLogInternet</td>
        /// <td>VpcFlowLogInternet</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The network traffic direction based on Alibaba Cloud resources. ● In: Traffic flowing into the elastic network interfaces (ENIs).</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● Out: Traffic flowing out of the elastic network interfaces (ENIs).</td>
        /// <td>In</td>
        /// <td>- In</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description>Out                                                                                                                                                                                                                                                                                                      |
        /// | TupleDimension    | string  | Yes   | The traffic storage aggregation dimension.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | Tuple1                                   | - Tuple1</description></item>
        /// <item><description>Tuple2</description></item>
        /// <item><description>Tuple5                                                                                                                                                                                                                                                                                    |
        /// | GroupBy           | array   | No   | Specifies multiple traffic dimensions for aggregation and sorting.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |                                          | -                                                                                                                                                                                                                                                                                                                |
        /// |                   | string  | No   | Based on the TupleDimension field, you can specify the following aggregation dimensions:</description></item>
        /// </list>
        /// <para>● When TupleDimension = Tuple1:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ CloudIp: Cloud IP
        /// ● When TupleDimension = Tuple2:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// 　■ <c>Country</c>: Client country
        /// 　■ <c>Province</c>: Client province
        /// 　■ <c>City</c>: Client city
        /// 　■ <c>Isp</c>: Internet service provider
        /// 　■ <c>Asn</c>: Autonomous system number
        /// ● When TupleDimension = Tuple5:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// 　■ SourcePort: Source port
        /// 　■ DestinationPort: Destination port
        /// 　■ Protocol: Network protocol
        /// 　■ Country: Client country
        /// 　■ Province: Client province
        /// 　■ City: Client city
        /// 　■ Isp: Internet service provider
        /// 　■ Asn: Autonomous system number | [&quot;VpcId&quot;]                                | - VpcId</para>
        /// <list type="bullet">
        /// <item><description>VSwitchId</description></item>
        /// <item><description>CloudIp</description></item>
        /// <item><description>SourceIp</description></item>
        /// <item><description>DestinationIp</description></item>
        /// <item><description>Protocol</description></item>
        /// <item><description>SourcePort</description></item>
        /// <item><description>DestinationPort</description></item>
        /// <item><description>TrafficPath</description></item>
        /// <item><description>Country</description></item>
        /// <item><description>Province</description></item>
        /// <item><description>City</description></item>
        /// <item><description>Isp</description></item>
        /// <item><description>Asn                                                                                         |
        /// | OrderBy           | string  | Yes   | The following traffic metrics are supported for sorting: Bytes, Packets, RoundTripTime.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Bytes                                    | - Bytes</description></item>
        /// <item><description>Packets</description></item>
        /// <item><description>RoundTripTime                                                                                                                                                                                                                                                                         |
        /// | Filter            | array   | No   | Specifies additional filter conditions for focused traffic analysis.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |                                          | -                                                                                                                                                                                                                                                                                                                |
        /// |                   | object  | No   | The filter condition for traffic, a Key-Value-Operator object.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |                                          | -                                                                                                                                                                                                                                                                                                                |</description></item>
        /// </list>
        /// <para>| key               | string  | No   | The supported filter condition label keys are as follows:</para>
        /// <list type="bullet">
        /// <item><description>When <c>TupleDimension</c> is 1-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (required, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>CloudIp</c>: Cloud IP (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 2-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (required, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP (the corresponding value supports multiple selections)
        /// 　- <c>DestinationIp</c>: Destination IP (the corresponding value supports multiple selections)
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)
        /// 　- <c>ClientCountry</c>: Filter traffic analysis scope by country (the corresponding value supports multiple selections)
        /// 　- <c>ClientCity</c>: Filter traffic analysis scope by city (the corresponding value supports multiple selections)
        /// 　- <c>ClientAsn</c>: Filter traffic analysis scope by ASN (the corresponding value supports multiple selections)
        /// 　- <c>ClientIsp</c>: Filter traffic analysis scope by client ISP (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 5-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (required, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP
        /// 　- <c>DestinationIp</c>: Destination IP
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)
        /// 　- <c>SourcePort</c>: Source port (the corresponding value supports multiple selections)
        /// 　- <c>DestinationPort</c>: Destination port (the corresponding value supports multiple selections)</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartNisTrafficRankingRequest
        /// </param>
        /// 
        /// <returns>
        /// StartNisTrafficRankingResponse
        /// </returns>
        public StartNisTrafficRankingResponse StartNisTrafficRanking(StartNisTrafficRankingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartNisTrafficRankingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers the NIS traffic analyzer to execute a traffic sorting task within a specified scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><a href="https://www.alibabacloud.com/help/en/nis/product-overview/billing-method-new-version">Before using this operation, make sure that you fully understand the billing method and pricing of the NIS traffic analyzer.</a>
        /// Before using this operation, create a traffic analyzer and add a data source.
        /// <a href="https://www.alibabacloud.com/help/en/nis/user-guide/traffic-analyzer-management#39d1693bce6yp">Create a traffic analyzer</a>
        /// <a href="https://www.alibabacloud.com/help/en/nis/user-guide/data-source-management#73845748bfstv">Add a data source</a>
        /// Supported analysis scenarios: </para>
        /// <list type="bullet">
        /// <item><description>All VPC network traffic analysis</description></item>
        /// <item><description>Internet VPC network traffic analysis</description></item>
        /// <item><description>All TR network traffic analysis</description></item>
        /// <item><description>Internet Shared Bandwidth metric analysis</description></item>
        /// </list>
        /// <h2>All VPC flow log analysis.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The region where the resource resides.</td>
        /// <td>cn-shanghai</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficAnalyzerId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The traffic analyzer ID.</td>
        /// <td>nta-262****ca07f</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficScenario</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The supported analysis scenario:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● All VPC flow log analysis</td>
        /// <td>Fixed value: VpcFlowLogAll</td>
        /// <td>VpcFlowLogAll</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The network traffic direction based on Alibaba Cloud resources. ● In: Traffic flowing into the elastic network interface (ENI).</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● Out: Traffic flowing out of the elastic network interface (ENI).</td>
        /// <td>In</td>
        /// <td>- In</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description>Out                                                                                                                                                                                                                                                                                                                                                                                                                                            |
        /// | TupleDimension    | string   | Yes   | The traffic storage aggregation dimension.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Tuple1                 | - Tuple1 </description></item>
        /// <item><description>Tuple2 </description></item>
        /// <item><description>Tuple5                                                                                                                                                                                                                                                                                                                                                                                                                              |
        /// | GroupBy           | array    | No   | Specifies multiple traffic dimensions for aggregation and sorting.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |  | -                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
        /// |                   | string   | No   | Based on the TupleDimension field, you can specify the following aggregation dimensions:</description></item>
        /// </list>
        /// <para>● When TupleDimension = Tuple1:
        /// 　■  VpcId: VPC ID
        /// 　■  VSwitchId: vSwitch ID
        /// 　■  NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■  EcsId: ECS instance ID
        /// 　■  CloudIp: Cloud IP
        /// ● When TupleDimension = Tuple2:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// ● When TupleDimension = Tuple5:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// 　■ SourcePort: Source port
        /// 　■ DestinationPort: Destination port
        /// 　■ Protocol: Network protocol | [&quot;VpcId&quot;]                                | - VpcId</para>
        /// <list type="bullet">
        /// <item><description>VSwitchId</description></item>
        /// <item><description>CloudIp</description></item>
        /// <item><description>SourceIp</description></item>
        /// <item><description>DestinationIp</description></item>
        /// <item><description>Protocol</description></item>
        /// <item><description>SourcePort</description></item>
        /// <item><description>DestinationPort</description></item>
        /// <item><description>TrafficPath</description></item>
        /// <item><description>Country</description></item>
        /// <item><description>Province</description></item>
        /// <item><description>City</description></item>
        /// <item><description>Isp</description></item>
        /// <item><description>Asn                                                                                                                                                                                                                                          |
        /// | OrderBy           | string   | Yes   | Based on the TrafficScenario field, the following traffic metrics are supported for sorting:
        /// TrafficScenario = VpcFlowLogAll / VpcFlowLogInternet (VPC flow log scenario):
        /// ● Bytes: Bandwidth
        /// ● Packets: Packet count
        /// ● RoundTripTime: TCP RTT                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Bytes                                    | - Bytes</description></item>
        /// <item><description>Packets</description></item>
        /// <item><description>RoundTripTime                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | Filter            | array    | No   | Specifies additional filter conditions for focused traffic analysis.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |                                          | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// |                   | object   | No   | The filter condition for traffic, a Key-Value-Operator object.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |                                          | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |</description></item>
        /// </list>
        /// <para>| key               | string   | No   | The supported filter condition label keys are as follows:</para>
        /// <list type="bullet">
        /// <item><description>When <c>TupleDimension</c> is 1-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (<b>required</b>, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>CloudIp</c>: Cloud IP (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 2-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (<b>required</b>, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP (the corresponding value supports multiple selections)
        /// 　- <c>DestinationIp</c>: Destination IP (the corresponding value supports multiple selections)
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 5-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (<b>required</b>, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP
        /// 　- <c>DestinationIp</c>: Destination IP
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)
        /// 　- <c>SourcePort</c>: Source port (the corresponding value supports multiple selections)
        /// 　- <c>DestinationPort</c>: Destination port (the corresponding value supports multiple selections)
        /// 　- <c>Protocol</c>: Network protocol (the corresponding value supports multiple selections)</description></item>
        /// <item><description>In VPC scenarios, you can also filter by traffic metrics:
        /// 　- <c>MinBytes</c>: The minimum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)
        /// 　- <c>MaxBytes</c>: The maximum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)
        /// 　- <c>MinRoundTripTime</c>: The minimum RTT for sorting, in ms (the corresponding value does not support multiple selections)
        /// 　- <c>MaxRoundTripTime</c>: The maximum RTT for sorting, in ms (the corresponding value does not support multiple selections)
        /// 　- <c>MinPackages</c>: The minimum packet count for sorting (the corresponding value does not support multiple selections)
        /// 　- <c>MaxPackages</c>: The maximum packet count for sorting (the corresponding value does not support multiple selections) | FlowAction                               | - FlowAction</description></item>
        /// <item><description>VpcId</description></item>
        /// <item><description>VSwitchId</description></item>
        /// <item><description>NetworkInterfaceId</description></item>
        /// <item><description>CloudIp</description></item>
        /// <item><description>DestinationIp</description></item>
        /// <item><description>SourceIp</description></item>
        /// <item><description>EcsId</description></item>
        /// <item><description>TrafficPath</description></item>
        /// <item><description>SourcePort</description></item>
        /// <item><description>DestinationPort</description></item>
        /// <item><description>Protocol</description></item>
        /// <item><description>MinBytes</description></item>
        /// <item><description>MaxBytes</description></item>
        /// <item><description>MinRoundTripTime</description></item>
        /// <item><description>MaxRoundTripTime</description></item>
        /// <item><description>MinPackages</description></item>
        /// <item><description>MaxPackages                                                                                                                |
        /// | value             | array    | No   | The filter condition values.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |                                          | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// |                   | string   | No   | The filter value corresponding to the specified key type.</description></item>
        /// </list>
        /// <para>When the key is <c>FlowAction</c>, the valid values are:
        /// 　- <c>ACCEPT</c> (default: <c>Accept</c>): Traffic allowed by security groups and network ACLs
        /// 　- <c>REJECT</c>: Traffic denied by security groups and network ACLs                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | Accept                                   | When the key is FlowAction: ACCEPT / REJECT                                                                                                                                                                                                                                                                                                                                                              |
        /// | Operator          | string   | No   | For specified key types, some support operators for character string matching on the passed value. The supported values are as follows (default: in):
        /// ● in: Equals
        /// ● not in: Not equals
        /// ● like: Contains
        /// Based on the TupleDimension and TrafficScenario fields, the support for <c>like</c> is as follows:
        /// TrafficScenario = VpcFlowLogAll / VpcFlowLogInternet (VPC flow log scenario):
        /// The following keys support <c>like</c>:
        /// 　○ CloudIp
        /// 　○ SourceIp
        /// 　○ DestinationIp
        /// All other keys support only <c>in</c> and <c>not in</c> operators.                                                                                                                                                                                                                                                                                                                                                                                                                           | in                                       | - not in</para>
        /// <list type="bullet">
        /// <item><description>in</description></item>
        /// <item><description>like                                                                                                                                                                                                                                                                                                                                                                                                                                   |
        /// | BeginTime         | long     | Yes   | The start time of the query as a millisecond UNIX timestamp.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | 1638239092000                            | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | EndTime           | long     | Yes   | The end time of the query as a millisecond UNIX timestamp.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            | 1684373700099                            | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | Sort              | string   | No   | The sorting order for traffic analysis:
        /// ● ASC: Ascending order.
        /// ● DESC: Descending order.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Desc                                     | - Desc</description></item>
        /// <item><description>Asc                                                                                                                                                                                                                                                                                                                                                                                                                                           |
        /// | TopN              | integer  | No   | The number of entries to return for the traffic sorting query.
        /// You can specify a custom number. If this field is not specified, all traffic data that meets the specified conditions is sorted and analyzed within the performance limits of traffic analysis data.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   | 10                                       | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | Language          | string   | No   | The language. Valid values: zh-CN, en-US.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              | zh-CN                                    | - zh-CN</description></item>
        /// <item><description>en-US                                                                                                                                                                                                                                                                                                                                                                                                                                        |
        /// | NextToken         | string   | No   | The pagination token. Leave this parameter empty for the first query or when no more results are available. If more results exist, set this to the NextToken value returned by the previous API call.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             | 2A07PfBPlzmmNi/75Qca9SK73UfY48/+WBiREjfVfXqMQxtV8XckOg5lk7F2bhC+ | -                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
        /// | MaxResults        | integer  | No   | The page size. Valid values: 1 to 100. Default value: 20.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               | 20                                       |                                                                                                                                                                                                                                                                                                                                                                                                                                         |
        /// | StorageInterval   | integer  | No   | The storage bucket granularity property.
        /// The storage bucket granularity specifies the storage aggregation period for the query. Two granularity levels are supported: high-precision (such as 1 minute) and long-period (such as 1 day). The specific granularity is determined by the traffic analysis sampling interval configured for high-precision or long-period traffic statistics when creating or editing the traffic analyzer.</description></item>
        /// <item><description>The supported storage granularity values for the traffic analyzer tuple are:
        /// 　- <c>1</c>: In minutes (1 minute)
        /// 　- <c>10</c>: In minutes (10 minutes)
        /// 　- <c>60</c>: In minutes (60 minutes, i.e., 1 hour)
        /// 　- <c>1440</c>: In minutes (1440 minutes, i.e., 1 day)</description></item>
        /// <item><description>The storage bucket granularity serves two typical purposes:
        /// 　- High-precision traffic statistics: such as 1-minute, 10-minute, or 60-minute aggregation
        /// 　- Long-period traffic statistics: such as 1440-minute (1-day) aggregation</description></item>
        /// <item><description>Specify this field during the query to select the storage aggregation period. For example:
        /// 　- Pass <c>10</c>: Query short-period data aggregated at 10-minute granularity
        /// 　- Pass <c>1440</c>: Query long-period data aggregated at 1-day granularity | 10                                       | - 1</description></item>
        /// <item><description>10</description></item>
        /// <item><description>60</description></item>
        /// <item><description>1440                                                                                                                                                                                                                                                                                                                                                                                                                                   |</description></item>
        /// </list>
        /// <h3>Response elements</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Description</th>
        /// <th>Example value</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td></td>
        /// <td>object</td>
        /// <td>RpcResponse <ArrayList></td>
        /// <td></td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>RequestId</td>
        /// <td>string</td>
        /// <td>The request ID.</td>
        /// <td>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>NisTrafficRankingId</td>
        /// <td>string</td>
        /// <td>The result ID of this traffic ranking analysis. Call the DescribeNisTrafficRanking operation to obtain the final analysis results.</td>
        /// <td>task-6462a7b4c4a54b****</td>
        /// <td>-</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>Internet VPC flow log analysis.</h2>
        /// <h3>Request parameters</h3>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// <th>Example</th>
        /// <th>Valid values</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RegionNo</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The region where the resource resides.</td>
        /// <td>cn-shanghai</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficAnalyzerId</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The traffic analyzer ID.</td>
        /// <td>nta-262****ca07f</td>
        /// <td>-</td>
        /// </tr>
        /// <tr>
        /// <td>TrafficScenario</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The supported analysis scenario:</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● Internet VPC flow log analysis</td>
        /// <td>Fixed value: VpcFlowLogInternet</td>
        /// <td>VpcFlowLogInternet</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Direction</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>The network traffic direction based on Alibaba Cloud resources. ● In: Traffic flowing into the elastic network interfaces (ENIs).</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>● Out: Traffic flowing out of the elastic network interfaces (ENIs).</td>
        /// <td>In</td>
        /// <td>- In</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description>Out                                                                                                                                                                                                                                                                                                      |
        /// | TupleDimension    | string  | Yes   | The traffic storage aggregation dimension.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  | Tuple1                                   | - Tuple1</description></item>
        /// <item><description>Tuple2</description></item>
        /// <item><description>Tuple5                                                                                                                                                                                                                                                                                    |
        /// | GroupBy           | array   | No   | Specifies multiple traffic dimensions for aggregation and sorting.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |                                          | -                                                                                                                                                                                                                                                                                                                |
        /// |                   | string  | No   | Based on the TupleDimension field, you can specify the following aggregation dimensions:</description></item>
        /// </list>
        /// <para>● When TupleDimension = Tuple1:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ CloudIp: Cloud IP
        /// ● When TupleDimension = Tuple2:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// 　■ <c>Country</c>: Client country
        /// 　■ <c>Province</c>: Client province
        /// 　■ <c>City</c>: Client city
        /// 　■ <c>Isp</c>: Internet service provider
        /// 　■ <c>Asn</c>: Autonomous system number
        /// ● When TupleDimension = Tuple5:
        /// 　■ VpcId: VPC ID
        /// 　■ VSwitchId: vSwitch ID
        /// 　■ NetworkInterfaceId: elastic network interfaces (ENIs) ID
        /// 　■ EcsId: ECS instance ID
        /// 　■ SourceIp: Source IP
        /// 　■ DestinationIp: Destination IP
        /// 　■ TrafficPath: Traffic path
        /// 　■ SourcePort: Source port
        /// 　■ DestinationPort: Destination port
        /// 　■ Protocol: Network protocol
        /// 　■ Country: Client country
        /// 　■ Province: Client province
        /// 　■ City: Client city
        /// 　■ Isp: Internet service provider
        /// 　■ Asn: Autonomous system number | [&quot;VpcId&quot;]                                | - VpcId</para>
        /// <list type="bullet">
        /// <item><description>VSwitchId</description></item>
        /// <item><description>CloudIp</description></item>
        /// <item><description>SourceIp</description></item>
        /// <item><description>DestinationIp</description></item>
        /// <item><description>Protocol</description></item>
        /// <item><description>SourcePort</description></item>
        /// <item><description>DestinationPort</description></item>
        /// <item><description>TrafficPath</description></item>
        /// <item><description>Country</description></item>
        /// <item><description>Province</description></item>
        /// <item><description>City</description></item>
        /// <item><description>Isp</description></item>
        /// <item><description>Asn                                                                                         |
        /// | OrderBy           | string  | Yes   | The following traffic metrics are supported for sorting: Bytes, Packets, RoundTripTime.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        | Bytes                                    | - Bytes</description></item>
        /// <item><description>Packets</description></item>
        /// <item><description>RoundTripTime                                                                                                                                                                                                                                                                         |
        /// | Filter            | array   | No   | Specifies additional filter conditions for focused traffic analysis.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |                                          | -                                                                                                                                                                                                                                                                                                                |
        /// |                   | object  | No   | The filter condition for traffic, a Key-Value-Operator object.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |                                          | -                                                                                                                                                                                                                                                                                                                |</description></item>
        /// </list>
        /// <para>| key               | string  | No   | The supported filter condition label keys are as follows:</para>
        /// <list type="bullet">
        /// <item><description>When <c>TupleDimension</c> is 1-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (required, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>CloudIp</c>: Cloud IP (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 2-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (required, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP (the corresponding value supports multiple selections)
        /// 　- <c>DestinationIp</c>: Destination IP (the corresponding value supports multiple selections)
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)
        /// 　- <c>ClientCountry</c>: Filter traffic analysis scope by country (the corresponding value supports multiple selections)
        /// 　- <c>ClientCity</c>: Filter traffic analysis scope by city (the corresponding value supports multiple selections)
        /// 　- <c>ClientAsn</c>: Filter traffic analysis scope by ASN (the corresponding value supports multiple selections)
        /// 　- <c>ClientIsp</c>: Filter traffic analysis scope by client ISP (the corresponding value supports multiple selections)</description></item>
        /// <item><description>When <c>TupleDimension</c> is 5-tuple:
        /// 　- <c>FlowAction</c>: The action type executed on traffic after matching the corresponding rule or policy (required, the corresponding value does not support multiple selections)
        /// 　- <c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)
        /// 　- <c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)
        /// 　- <c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)
        /// 　- <c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)
        /// 　- <c>SourceIp</c>: Source IP
        /// 　- <c>DestinationIp</c>: Destination IP
        /// 　- <c>TrafficPath</c>: Traffic path (the corresponding value supports multiple selections)
        /// 　- <c>SourcePort</c>: Source port (the corresponding value supports multiple selections)
        /// 　- <c>DestinationPort</c>: Destination port (the corresponding value supports multiple selections)</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StartNisTrafficRankingRequest
        /// </param>
        /// 
        /// <returns>
        /// StartNisTrafficRankingResponse
        /// </returns>
        public async Task<StartNisTrafficRankingResponse> StartNisTrafficRankingAsync(StartNisTrafficRankingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartNisTrafficRankingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNisInspectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNisInspectionTaskResponse
        /// </returns>
        public UpdateNisInspectionTaskResponse UpdateNisInspectionTaskWithOptions(UpdateNisInspectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionTaskId))
            {
                query["InspectionTaskId"] = request.InspectionTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNisInspectionTask",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNisInspectionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNisInspectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNisInspectionTaskResponse
        /// </returns>
        public async Task<UpdateNisInspectionTaskResponse> UpdateNisInspectionTaskWithOptionsAsync(UpdateNisInspectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionTaskId))
            {
                query["InspectionTaskId"] = request.InspectionTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNisInspectionTask",
                Version = "2021-12-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNisInspectionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNisInspectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNisInspectionTaskResponse
        /// </returns>
        public UpdateNisInspectionTaskResponse UpdateNisInspectionTask(UpdateNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNisInspectionTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNisInspectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNisInspectionTaskResponse
        /// </returns>
        public async Task<UpdateNisInspectionTaskResponse> UpdateNisInspectionTaskAsync(UpdateNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNisInspectionTaskWithOptionsAsync(request, runtime);
        }

    }
}
