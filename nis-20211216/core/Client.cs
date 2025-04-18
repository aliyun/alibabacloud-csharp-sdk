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
            this._endpointRule = "";
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
        /// <para>Creates a network path in the cloud for reachability analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call the <b>CreateNetworkPath</b> operation to create network paths in multiple networking scenarios and between multiple resources. After a path is created, the path parameters are saved for repeated analysis.</para>
        /// <list type="bullet">
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
        /// <para>Creates a network path in the cloud for reachability analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call the <b>CreateNetworkPath</b> operation to create network paths in multiple networking scenarios and between multiple resources. After a path is created, the path parameters are saved for repeated analysis.</para>
        /// <list type="bullet">
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
        /// <para>Creates a network path in the cloud for reachability analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call the <b>CreateNetworkPath</b> operation to create network paths in multiple networking scenarios and between multiple resources. After a path is created, the path parameters are saved for repeated analysis.</para>
        /// <list type="bullet">
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
        /// <para>Creates a network path in the cloud for reachability analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call the <b>CreateNetworkPath</b> operation to create network paths in multiple networking scenarios and between multiple resources. After a path is created, the path parameters are saved for repeated analysis.</para>
        /// <list type="bullet">
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
        /// <para>  The <b>CreateNetworkReachableAnalysis</b> operation is used to create a task for analyzing the reachability of the network path that is created by calling the <b>CreateNetworkPath</b> operation and record the analysis results.</para>
        /// <list type="bullet">
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
        /// <para>  The <b>CreateNetworkReachableAnalysis</b> operation is used to create a task for analyzing the reachability of the network path that is created by calling the <b>CreateNetworkPath</b> operation and record the analysis results.</para>
        /// <list type="bullet">
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
        /// <para>  The <b>CreateNetworkReachableAnalysis</b> operation is used to create a task for analyzing the reachability of the network path that is created by calling the <b>CreateNetworkPath</b> operation and record the analysis results.</para>
        /// <list type="bullet">
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
        /// <para>  The <b>CreateNetworkReachableAnalysis</b> operation is used to create a task for analyzing the reachability of the network path that is created by calling the <b>CreateNetworkPath</b> operation and record the analysis results.</para>
        /// <list type="bullet">
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
        /// <para>删除报告</para>
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
        /// <para>删除报告</para>
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
        /// <para>删除报告</para>
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
        /// <para>删除报告</para>
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
        /// <para>删除巡检任务</para>
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
        /// <para>删除巡检任务</para>
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
        /// <para>删除巡检任务</para>
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
        /// <para>删除巡检任务</para>
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
        /// <para>受影响资源列表</para>
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
        /// <para>受影响资源列表</para>
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
        /// <para>受影响资源列表</para>
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
        /// <para>受影响资源列表</para>
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
        /// <para>报告巡检项列表</para>
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
        /// <para>报告巡检项列表</para>
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
        /// <para>报告巡检项列表</para>
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
        /// <para>报告巡检项列表</para>
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
        /// <para>查询报告状态</para>
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
        /// <para>查询报告状态</para>
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
        /// <para>查询报告状态</para>
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
        /// <para>查询报告状态</para>
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
        /// <para>报告总结信息</para>
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
        /// <para>报告总结信息</para>
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
        /// <para>报告总结信息</para>
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
        /// <para>报告总结信息</para>
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
        /// <para>查询巡检任务</para>
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
        /// <para>查询巡检任务</para>
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
        /// <para>查询巡检任务</para>
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
        /// <para>查询巡检任务</para>
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
        /// <para>获取云网络指标趋势</para>
        /// </summary>
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
        /// <para>获取云网络指标趋势</para>
        /// </summary>
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
        /// <para>获取云网络指标趋势</para>
        /// </summary>
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
        /// <para>获取云网络指标趋势</para>
        /// </summary>
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
        /// <para>获取云网络指标排名</para>
        /// </summary>
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
        /// <para>获取云网络指标排名</para>
        /// </summary>
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
        /// <para>获取云网络指标排名</para>
        /// </summary>
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
        /// <para>获取云网络指标排名</para>
        /// </summary>
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
        /// <para>巡检资源类型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNisInspectionResourceTypeRequest
        /// </param>
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
        /// <para>巡检资源类型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNisInspectionResourceTypeRequest
        /// </param>
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
        /// <para>巡检资源类型列表</para>
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
        /// <para>巡检资源类型列表</para>
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
        /// <para>查询巡检报告列表</para>
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
        /// <para>查询巡检报告列表</para>
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
        /// <para>查询巡检报告列表</para>
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
        /// <para>查询巡检报告列表</para>
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
        /// <para>巡检任务列表</para>
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
        /// <para>巡检任务列表</para>
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
        /// <para>巡检任务列表</para>
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
        /// <para>巡检任务列表</para>
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
        /// <para>请补充描述开启任务</para>
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
        /// <para>请补充描述开启任务</para>
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
        /// <para>请补充描述开启任务</para>
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
        /// <para>请补充描述开启任务</para>
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
        /// <para>修改巡检项</para>
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
        /// <para>修改巡检项</para>
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
        /// <para>修改巡检项</para>
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
        /// <para>修改巡检项</para>
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
