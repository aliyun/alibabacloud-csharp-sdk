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

        /**
         * @summary Initiates a task for analyzing network reachability.
         *
         * @description You can call this operation to initiate a task for analyzing network reachability by specifying only the information about the source and destination. You do not need to create a network path for reachability analysis. The analysis result is not recorded in the system. If you want to record the path parameters and analysis result in the Network Intelligence Service (NIS) console, we recommend that you call the **createNetworkReachableAnalysis** operation.
         *
         * @param request CreateAndAnalyzeNetworkPathRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAndAnalyzeNetworkPathResponse
         */
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

        /**
         * @summary Initiates a task for analyzing network reachability.
         *
         * @description You can call this operation to initiate a task for analyzing network reachability by specifying only the information about the source and destination. You do not need to create a network path for reachability analysis. The analysis result is not recorded in the system. If you want to record the path parameters and analysis result in the Network Intelligence Service (NIS) console, we recommend that you call the **createNetworkReachableAnalysis** operation.
         *
         * @param request CreateAndAnalyzeNetworkPathRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAndAnalyzeNetworkPathResponse
         */
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

        /**
         * @summary Initiates a task for analyzing network reachability.
         *
         * @description You can call this operation to initiate a task for analyzing network reachability by specifying only the information about the source and destination. You do not need to create a network path for reachability analysis. The analysis result is not recorded in the system. If you want to record the path parameters and analysis result in the Network Intelligence Service (NIS) console, we recommend that you call the **createNetworkReachableAnalysis** operation.
         *
         * @param request CreateAndAnalyzeNetworkPathRequest
         * @return CreateAndAnalyzeNetworkPathResponse
         */
        public CreateAndAnalyzeNetworkPathResponse CreateAndAnalyzeNetworkPath(CreateAndAnalyzeNetworkPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAndAnalyzeNetworkPathWithOptions(request, runtime);
        }

        /**
         * @summary Initiates a task for analyzing network reachability.
         *
         * @description You can call this operation to initiate a task for analyzing network reachability by specifying only the information about the source and destination. You do not need to create a network path for reachability analysis. The analysis result is not recorded in the system. If you want to record the path parameters and analysis result in the Network Intelligence Service (NIS) console, we recommend that you call the **createNetworkReachableAnalysis** operation.
         *
         * @param request CreateAndAnalyzeNetworkPathRequest
         * @return CreateAndAnalyzeNetworkPathResponse
         */
        public async Task<CreateAndAnalyzeNetworkPathResponse> CreateAndAnalyzeNetworkPathAsync(CreateAndAnalyzeNetworkPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAndAnalyzeNetworkPathWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a network path in the cloud for reachability analysis.
         *
         * @description *   You can call the **CreateNetworkPath** operation to create network paths in multiple networking scenarios and between multiple resources. After a path is created, the path parameters are saved for repeated analysis.
         * *   You can create up to 100 network paths within one Alibaba Cloud account.
         *
         * @param request CreateNetworkPathRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNetworkPathResponse
         */
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

        /**
         * @summary Creates a network path in the cloud for reachability analysis.
         *
         * @description *   You can call the **CreateNetworkPath** operation to create network paths in multiple networking scenarios and between multiple resources. After a path is created, the path parameters are saved for repeated analysis.
         * *   You can create up to 100 network paths within one Alibaba Cloud account.
         *
         * @param request CreateNetworkPathRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNetworkPathResponse
         */
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

        /**
         * @summary Creates a network path in the cloud for reachability analysis.
         *
         * @description *   You can call the **CreateNetworkPath** operation to create network paths in multiple networking scenarios and between multiple resources. After a path is created, the path parameters are saved for repeated analysis.
         * *   You can create up to 100 network paths within one Alibaba Cloud account.
         *
         * @param request CreateNetworkPathRequest
         * @return CreateNetworkPathResponse
         */
        public CreateNetworkPathResponse CreateNetworkPath(CreateNetworkPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNetworkPathWithOptions(request, runtime);
        }

        /**
         * @summary Creates a network path in the cloud for reachability analysis.
         *
         * @description *   You can call the **CreateNetworkPath** operation to create network paths in multiple networking scenarios and between multiple resources. After a path is created, the path parameters are saved for repeated analysis.
         * *   You can create up to 100 network paths within one Alibaba Cloud account.
         *
         * @param request CreateNetworkPathRequest
         * @return CreateNetworkPathResponse
         */
        public async Task<CreateNetworkPathResponse> CreateNetworkPathAsync(CreateNetworkPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNetworkPathWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a task for analyzing network reachability.
         *
         * @description *   The **CreateNetworkReachableAnalysis** operation is used to create a task for analyzing the reachability of the network path that is created by calling the **CreateNetworkPath** operation and record the analysis results.
         * *   The **CreateNetworkReachableAnalysis** operation can be called to repeatedly analyze the reachability of a network path.
         * *   You can create up to 1,000 reachability analysis records within one Alibaba Cloud account.
         *
         * @param request CreateNetworkReachableAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNetworkReachableAnalysisResponse
         */
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

        /**
         * @summary Creates a task for analyzing network reachability.
         *
         * @description *   The **CreateNetworkReachableAnalysis** operation is used to create a task for analyzing the reachability of the network path that is created by calling the **CreateNetworkPath** operation and record the analysis results.
         * *   The **CreateNetworkReachableAnalysis** operation can be called to repeatedly analyze the reachability of a network path.
         * *   You can create up to 1,000 reachability analysis records within one Alibaba Cloud account.
         *
         * @param request CreateNetworkReachableAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNetworkReachableAnalysisResponse
         */
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

        /**
         * @summary Creates a task for analyzing network reachability.
         *
         * @description *   The **CreateNetworkReachableAnalysis** operation is used to create a task for analyzing the reachability of the network path that is created by calling the **CreateNetworkPath** operation and record the analysis results.
         * *   The **CreateNetworkReachableAnalysis** operation can be called to repeatedly analyze the reachability of a network path.
         * *   You can create up to 1,000 reachability analysis records within one Alibaba Cloud account.
         *
         * @param request CreateNetworkReachableAnalysisRequest
         * @return CreateNetworkReachableAnalysisResponse
         */
        public CreateNetworkReachableAnalysisResponse CreateNetworkReachableAnalysis(CreateNetworkReachableAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNetworkReachableAnalysisWithOptions(request, runtime);
        }

        /**
         * @summary Creates a task for analyzing network reachability.
         *
         * @description *   The **CreateNetworkReachableAnalysis** operation is used to create a task for analyzing the reachability of the network path that is created by calling the **CreateNetworkPath** operation and record the analysis results.
         * *   The **CreateNetworkReachableAnalysis** operation can be called to repeatedly analyze the reachability of a network path.
         * *   You can create up to 1,000 reachability analysis records within one Alibaba Cloud account.
         *
         * @param request CreateNetworkReachableAnalysisRequest
         * @return CreateNetworkReachableAnalysisResponse
         */
        public async Task<CreateNetworkReachableAnalysisResponse> CreateNetworkReachableAnalysisAsync(CreateNetworkReachableAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNetworkReachableAnalysisWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a network path.
         *
         * @param tmpReq DeleteNetworkPathRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNetworkPathResponse
         */
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

        /**
         * @summary Deletes a network path.
         *
         * @param tmpReq DeleteNetworkPathRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNetworkPathResponse
         */
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

        /**
         * @summary Deletes a network path.
         *
         * @param request DeleteNetworkPathRequest
         * @return DeleteNetworkPathResponse
         */
        public DeleteNetworkPathResponse DeleteNetworkPath(DeleteNetworkPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNetworkPathWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a network path.
         *
         * @param request DeleteNetworkPathRequest
         * @return DeleteNetworkPathResponse
         */
        public async Task<DeleteNetworkPathResponse> DeleteNetworkPathAsync(DeleteNetworkPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNetworkPathWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a task for analyzing network reachability.
         *
         * @param tmpReq DeleteNetworkReachableAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNetworkReachableAnalysisResponse
         */
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

        /**
         * @summary Deletes a task for analyzing network reachability.
         *
         * @param tmpReq DeleteNetworkReachableAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNetworkReachableAnalysisResponse
         */
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

        /**
         * @summary Deletes a task for analyzing network reachability.
         *
         * @param request DeleteNetworkReachableAnalysisRequest
         * @return DeleteNetworkReachableAnalysisResponse
         */
        public DeleteNetworkReachableAnalysisResponse DeleteNetworkReachableAnalysis(DeleteNetworkReachableAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNetworkReachableAnalysisWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a task for analyzing network reachability.
         *
         * @param request DeleteNetworkReachableAnalysisRequest
         * @return DeleteNetworkReachableAnalysisResponse
         */
        public async Task<DeleteNetworkReachableAnalysisResponse> DeleteNetworkReachableAnalysisAsync(DeleteNetworkReachableAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNetworkReachableAnalysisWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除报告
         *
         * @param request DeleteNisInspectionReportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNisInspectionReportResponse
         */
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

        /**
         * @summary 删除报告
         *
         * @param request DeleteNisInspectionReportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNisInspectionReportResponse
         */
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

        /**
         * @summary 删除报告
         *
         * @param request DeleteNisInspectionReportRequest
         * @return DeleteNisInspectionReportResponse
         */
        public DeleteNisInspectionReportResponse DeleteNisInspectionReport(DeleteNisInspectionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNisInspectionReportWithOptions(request, runtime);
        }

        /**
         * @summary 删除报告
         *
         * @param request DeleteNisInspectionReportRequest
         * @return DeleteNisInspectionReportResponse
         */
        public async Task<DeleteNisInspectionReportResponse> DeleteNisInspectionReportAsync(DeleteNisInspectionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNisInspectionReportWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除巡检任务
         *
         * @param request DeleteNisInspectionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNisInspectionTaskResponse
         */
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

        /**
         * @summary 删除巡检任务
         *
         * @param request DeleteNisInspectionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNisInspectionTaskResponse
         */
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

        /**
         * @summary 删除巡检任务
         *
         * @param request DeleteNisInspectionTaskRequest
         * @return DeleteNisInspectionTaskResponse
         */
        public DeleteNisInspectionTaskResponse DeleteNisInspectionTask(DeleteNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNisInspectionTaskWithOptions(request, runtime);
        }

        /**
         * @summary 删除巡检任务
         *
         * @param request DeleteNisInspectionTaskRequest
         * @return DeleteNisInspectionTaskResponse
         */
        public async Task<DeleteNisInspectionTaskResponse> DeleteNisInspectionTaskAsync(DeleteNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNisInspectionTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 受影响资源列表
         *
         * @param request DescribeNisInspectionRecommendationResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNisInspectionRecommendationResourcesResponse
         */
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

        /**
         * @summary 受影响资源列表
         *
         * @param request DescribeNisInspectionRecommendationResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNisInspectionRecommendationResourcesResponse
         */
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

        /**
         * @summary 受影响资源列表
         *
         * @param request DescribeNisInspectionRecommendationResourcesRequest
         * @return DescribeNisInspectionRecommendationResourcesResponse
         */
        public DescribeNisInspectionRecommendationResourcesResponse DescribeNisInspectionRecommendationResources(DescribeNisInspectionRecommendationResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNisInspectionRecommendationResourcesWithOptions(request, runtime);
        }

        /**
         * @summary 受影响资源列表
         *
         * @param request DescribeNisInspectionRecommendationResourcesRequest
         * @return DescribeNisInspectionRecommendationResourcesResponse
         */
        public async Task<DescribeNisInspectionRecommendationResourcesResponse> DescribeNisInspectionRecommendationResourcesAsync(DescribeNisInspectionRecommendationResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNisInspectionRecommendationResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 报告巡检项列表
         *
         * @param tmpReq DescribeNisInspectionReportCheckItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNisInspectionReportCheckItemsResponse
         */
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

        /**
         * @summary 报告巡检项列表
         *
         * @param tmpReq DescribeNisInspectionReportCheckItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNisInspectionReportCheckItemsResponse
         */
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

        /**
         * @summary 报告巡检项列表
         *
         * @param request DescribeNisInspectionReportCheckItemsRequest
         * @return DescribeNisInspectionReportCheckItemsResponse
         */
        public DescribeNisInspectionReportCheckItemsResponse DescribeNisInspectionReportCheckItems(DescribeNisInspectionReportCheckItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNisInspectionReportCheckItemsWithOptions(request, runtime);
        }

        /**
         * @summary 报告巡检项列表
         *
         * @param request DescribeNisInspectionReportCheckItemsRequest
         * @return DescribeNisInspectionReportCheckItemsResponse
         */
        public async Task<DescribeNisInspectionReportCheckItemsResponse> DescribeNisInspectionReportCheckItemsAsync(DescribeNisInspectionReportCheckItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNisInspectionReportCheckItemsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询报告状态
         *
         * @param request DescribeNisInspectionReportStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNisInspectionReportStatusResponse
         */
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

        /**
         * @summary 查询报告状态
         *
         * @param request DescribeNisInspectionReportStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNisInspectionReportStatusResponse
         */
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

        /**
         * @summary 查询报告状态
         *
         * @param request DescribeNisInspectionReportStatusRequest
         * @return DescribeNisInspectionReportStatusResponse
         */
        public DescribeNisInspectionReportStatusResponse DescribeNisInspectionReportStatus(DescribeNisInspectionReportStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNisInspectionReportStatusWithOptions(request, runtime);
        }

        /**
         * @summary 查询报告状态
         *
         * @param request DescribeNisInspectionReportStatusRequest
         * @return DescribeNisInspectionReportStatusResponse
         */
        public async Task<DescribeNisInspectionReportStatusResponse> DescribeNisInspectionReportStatusAsync(DescribeNisInspectionReportStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNisInspectionReportStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 报告总结信息
         *
         * @param request DescribeNisInspectionReportSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNisInspectionReportSummaryResponse
         */
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

        /**
         * @summary 报告总结信息
         *
         * @param request DescribeNisInspectionReportSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNisInspectionReportSummaryResponse
         */
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

        /**
         * @summary 报告总结信息
         *
         * @param request DescribeNisInspectionReportSummaryRequest
         * @return DescribeNisInspectionReportSummaryResponse
         */
        public DescribeNisInspectionReportSummaryResponse DescribeNisInspectionReportSummary(DescribeNisInspectionReportSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNisInspectionReportSummaryWithOptions(request, runtime);
        }

        /**
         * @summary 报告总结信息
         *
         * @param request DescribeNisInspectionReportSummaryRequest
         * @return DescribeNisInspectionReportSummaryResponse
         */
        public async Task<DescribeNisInspectionReportSummaryResponse> DescribeNisInspectionReportSummaryAsync(DescribeNisInspectionReportSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNisInspectionReportSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询巡检任务
         *
         * @param request DescribeNisInspectionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNisInspectionTaskResponse
         */
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

        /**
         * @summary 查询巡检任务
         *
         * @param request DescribeNisInspectionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNisInspectionTaskResponse
         */
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

        /**
         * @summary 查询巡检任务
         *
         * @param request DescribeNisInspectionTaskRequest
         * @return DescribeNisInspectionTaskResponse
         */
        public DescribeNisInspectionTaskResponse DescribeNisInspectionTask(DescribeNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNisInspectionTaskWithOptions(request, runtime);
        }

        /**
         * @summary 查询巡检任务
         *
         * @param request DescribeNisInspectionTaskRequest
         * @return DescribeNisInspectionTaskResponse
         */
        public async Task<DescribeNisInspectionTaskResponse> DescribeNisInspectionTaskAsync(DescribeNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNisInspectionTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetInternetTuple is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the rankings of Internet traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Internet traffic data can be ranked by metrics such as traffic volumes and the number of packets.
         *
         * @param tmpReq GetInternetTupleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInternetTupleResponse
         */
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

        /**
         * @deprecated OpenAPI GetInternetTuple is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the rankings of Internet traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Internet traffic data can be ranked by metrics such as traffic volumes and the number of packets.
         *
         * @param tmpReq GetInternetTupleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInternetTupleResponse
         */
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

        /**
         * @deprecated OpenAPI GetInternetTuple is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the rankings of Internet traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Internet traffic data can be ranked by metrics such as traffic volumes and the number of packets.
         *
         * @param request GetInternetTupleRequest
         * @return GetInternetTupleResponse
         */
        // Deprecated
        public GetInternetTupleResponse GetInternetTuple(GetInternetTupleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInternetTupleWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetInternetTuple is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the rankings of Internet traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Internet traffic data can be ranked by metrics such as traffic volumes and the number of packets.
         *
         * @param request GetInternetTupleRequest
         * @return GetInternetTupleResponse
         */
        // Deprecated
        public async Task<GetInternetTupleResponse> GetInternetTupleAsync(GetInternetTupleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInternetTupleWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetNatTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the real-time SNAT performance ranking of a NAT gateway.
         *
         * @param request GetNatTopNRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNatTopNResponse
         */
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

        /**
         * @deprecated OpenAPI GetNatTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the real-time SNAT performance ranking of a NAT gateway.
         *
         * @param request GetNatTopNRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNatTopNResponse
         */
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

        /**
         * @deprecated OpenAPI GetNatTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the real-time SNAT performance ranking of a NAT gateway.
         *
         * @param request GetNatTopNRequest
         * @return GetNatTopNResponse
         */
        // Deprecated
        public GetNatTopNResponse GetNatTopN(GetNatTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNatTopNWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetNatTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the real-time SNAT performance ranking of a NAT gateway.
         *
         * @param request GetNatTopNRequest
         * @return GetNatTopNResponse
         */
        // Deprecated
        public async Task<GetNatTopNResponse> GetNatTopNAsync(GetNatTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNatTopNWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the results of network reachability analysis.
         *
         * @description **GetNetworkReachableAnalysis** is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can query the state of the task for analyzing network reachability.
         * *   The **init** state indicates that the task is in progress.
         * *   The **finish** state indicates that the task is complete. In this state, you can obtain the analysis result.
         *
         * @param request GetNetworkReachableAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNetworkReachableAnalysisResponse
         */
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

        /**
         * @summary Obtains the results of network reachability analysis.
         *
         * @description **GetNetworkReachableAnalysis** is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can query the state of the task for analyzing network reachability.
         * *   The **init** state indicates that the task is in progress.
         * *   The **finish** state indicates that the task is complete. In this state, you can obtain the analysis result.
         *
         * @param request GetNetworkReachableAnalysisRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNetworkReachableAnalysisResponse
         */
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

        /**
         * @summary Obtains the results of network reachability analysis.
         *
         * @description **GetNetworkReachableAnalysis** is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can query the state of the task for analyzing network reachability.
         * *   The **init** state indicates that the task is in progress.
         * *   The **finish** state indicates that the task is complete. In this state, you can obtain the analysis result.
         *
         * @param request GetNetworkReachableAnalysisRequest
         * @return GetNetworkReachableAnalysisResponse
         */
        public GetNetworkReachableAnalysisResponse GetNetworkReachableAnalysis(GetNetworkReachableAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNetworkReachableAnalysisWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the results of network reachability analysis.
         *
         * @description **GetNetworkReachableAnalysis** is an asynchronous operation. After a request is sent, the system returns a request ID and runs the task in the background. You can query the state of the task for analyzing network reachability.
         * *   The **init** state indicates that the task is in progress.
         * *   The **finish** state indicates that the task is complete. In this state, you can obtain the analysis result.
         *
         * @param request GetNetworkReachableAnalysisRequest
         * @return GetNetworkReachableAnalysisResponse
         */
        public async Task<GetNetworkReachableAnalysisResponse> GetNetworkReachableAnalysisAsync(GetNetworkReachableAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNetworkReachableAnalysisWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取云网络指标趋势
         *
         * @param tmpReq GetNisNetworkMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNisNetworkMetricsResponse
         */
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

        /**
         * @summary 获取云网络指标趋势
         *
         * @param tmpReq GetNisNetworkMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNisNetworkMetricsResponse
         */
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

        /**
         * @summary 获取云网络指标趋势
         *
         * @param request GetNisNetworkMetricsRequest
         * @return GetNisNetworkMetricsResponse
         */
        public GetNisNetworkMetricsResponse GetNisNetworkMetrics(GetNisNetworkMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNisNetworkMetricsWithOptions(request, runtime);
        }

        /**
         * @summary 获取云网络指标趋势
         *
         * @param request GetNisNetworkMetricsRequest
         * @return GetNisNetworkMetricsResponse
         */
        public async Task<GetNisNetworkMetricsResponse> GetNisNetworkMetricsAsync(GetNisNetworkMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNisNetworkMetricsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取云网络指标排名
         *
         * @param tmpReq GetNisNetworkRankingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNisNetworkRankingResponse
         */
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

        /**
         * @summary 获取云网络指标排名
         *
         * @param tmpReq GetNisNetworkRankingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNisNetworkRankingResponse
         */
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

        /**
         * @summary 获取云网络指标排名
         *
         * @param request GetNisNetworkRankingRequest
         * @return GetNisNetworkRankingResponse
         */
        public GetNisNetworkRankingResponse GetNisNetworkRanking(GetNisNetworkRankingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNisNetworkRankingWithOptions(request, runtime);
        }

        /**
         * @summary 获取云网络指标排名
         *
         * @param request GetNisNetworkRankingRequest
         * @return GetNisNetworkRankingResponse
         */
        public async Task<GetNisNetworkRankingResponse> GetNisNetworkRankingAsync(GetNisNetworkRankingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNisNetworkRankingWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetTransitRouterFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the rankings of inter-region traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Inter-region traffic data can be ranked by metrics such as traffic volumes and the number of packets.
         *
         * @param tmpReq GetTransitRouterFlowTopNRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTransitRouterFlowTopNResponse
         */
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

        /**
         * @deprecated OpenAPI GetTransitRouterFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the rankings of inter-region traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Inter-region traffic data can be ranked by metrics such as traffic volumes and the number of packets.
         *
         * @param tmpReq GetTransitRouterFlowTopNRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTransitRouterFlowTopNResponse
         */
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

        /**
         * @deprecated OpenAPI GetTransitRouterFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the rankings of inter-region traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Inter-region traffic data can be ranked by metrics such as traffic volumes and the number of packets.
         *
         * @param request GetTransitRouterFlowTopNRequest
         * @return GetTransitRouterFlowTopNResponse
         */
        // Deprecated
        public GetTransitRouterFlowTopNResponse GetTransitRouterFlowTopN(GetTransitRouterFlowTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTransitRouterFlowTopNWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetTransitRouterFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the rankings of inter-region traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Inter-region traffic data can be ranked by metrics such as traffic volumes and the number of packets.
         *
         * @param request GetTransitRouterFlowTopNRequest
         * @return GetTransitRouterFlowTopNResponse
         */
        // Deprecated
        public async Task<GetTransitRouterFlowTopNResponse> GetTransitRouterFlowTopNAsync(GetTransitRouterFlowTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTransitRouterFlowTopNWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetVbrFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the rankings of hybrid cloud traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Hybrid cloud traffic data can be ranked by metrics such as traffic volumes and the number of packets.
         *
         * @param tmpReq GetVbrFlowTopNRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVbrFlowTopNResponse
         */
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

        /**
         * @deprecated OpenAPI GetVbrFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the rankings of hybrid cloud traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Hybrid cloud traffic data can be ranked by metrics such as traffic volumes and the number of packets.
         *
         * @param tmpReq GetVbrFlowTopNRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVbrFlowTopNResponse
         */
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

        /**
         * @deprecated OpenAPI GetVbrFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the rankings of hybrid cloud traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Hybrid cloud traffic data can be ranked by metrics such as traffic volumes and the number of packets.
         *
         * @param request GetVbrFlowTopNRequest
         * @return GetVbrFlowTopNResponse
         */
        // Deprecated
        public GetVbrFlowTopNResponse GetVbrFlowTopN(GetVbrFlowTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVbrFlowTopNWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetVbrFlowTopN is deprecated, please use nis::2021-12-16::GetNisNetworkRanking instead.
         *
         * @summary Queries the rankings of hybrid cloud traffic data in the form of 1-tuple, 2-tuple, or 5-tuple. Hybrid cloud traffic data can be ranked by metrics such as traffic volumes and the number of packets.
         *
         * @param request GetVbrFlowTopNRequest
         * @return GetVbrFlowTopNResponse
         */
        // Deprecated
        public async Task<GetVbrFlowTopNResponse> GetVbrFlowTopNAsync(GetVbrFlowTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVbrFlowTopNWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 巡检资源类型列表
         *
         * @param request ListNisInspectionResourceTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNisInspectionResourceTypeResponse
         */
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

        /**
         * @summary 巡检资源类型列表
         *
         * @param request ListNisInspectionResourceTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNisInspectionResourceTypeResponse
         */
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

        /**
         * @summary 巡检资源类型列表
         *
         * @return ListNisInspectionResourceTypeResponse
         */
        public ListNisInspectionResourceTypeResponse ListNisInspectionResourceType()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNisInspectionResourceTypeWithOptions(runtime);
        }

        /**
         * @summary 巡检资源类型列表
         *
         * @return ListNisInspectionResourceTypeResponse
         */
        public async Task<ListNisInspectionResourceTypeResponse> ListNisInspectionResourceTypeAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNisInspectionResourceTypeWithOptionsAsync(runtime);
        }

        /**
         * @summary 查询巡检报告列表
         *
         * @param request ListNisInspectionTaskReportsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNisInspectionTaskReportsResponse
         */
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

        /**
         * @summary 查询巡检报告列表
         *
         * @param request ListNisInspectionTaskReportsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNisInspectionTaskReportsResponse
         */
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

        /**
         * @summary 查询巡检报告列表
         *
         * @param request ListNisInspectionTaskReportsRequest
         * @return ListNisInspectionTaskReportsResponse
         */
        public ListNisInspectionTaskReportsResponse ListNisInspectionTaskReports(ListNisInspectionTaskReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNisInspectionTaskReportsWithOptions(request, runtime);
        }

        /**
         * @summary 查询巡检报告列表
         *
         * @param request ListNisInspectionTaskReportsRequest
         * @return ListNisInspectionTaskReportsResponse
         */
        public async Task<ListNisInspectionTaskReportsResponse> ListNisInspectionTaskReportsAsync(ListNisInspectionTaskReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNisInspectionTaskReportsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 巡检任务列表
         *
         * @param request ListNisInspectionTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNisInspectionTasksResponse
         */
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

        /**
         * @summary 巡检任务列表
         *
         * @param request ListNisInspectionTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNisInspectionTasksResponse
         */
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

        /**
         * @summary 巡检任务列表
         *
         * @param request ListNisInspectionTasksRequest
         * @return ListNisInspectionTasksResponse
         */
        public ListNisInspectionTasksResponse ListNisInspectionTasks(ListNisInspectionTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNisInspectionTasksWithOptions(request, runtime);
        }

        /**
         * @summary 巡检任务列表
         *
         * @param request ListNisInspectionTasksRequest
         * @return ListNisInspectionTasksResponse
         */
        public async Task<ListNisInspectionTasksResponse> ListNisInspectionTasksAsync(ListNisInspectionTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNisInspectionTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 请补充描述开启任务
         *
         * @param request StartNisInspectionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartNisInspectionTaskResponse
         */
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

        /**
         * @summary 请补充描述开启任务
         *
         * @param request StartNisInspectionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartNisInspectionTaskResponse
         */
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

        /**
         * @summary 请补充描述开启任务
         *
         * @param request StartNisInspectionTaskRequest
         * @return StartNisInspectionTaskResponse
         */
        public StartNisInspectionTaskResponse StartNisInspectionTask(StartNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartNisInspectionTaskWithOptions(request, runtime);
        }

        /**
         * @summary 请补充描述开启任务
         *
         * @param request StartNisInspectionTaskRequest
         * @return StartNisInspectionTaskResponse
         */
        public async Task<StartNisInspectionTaskResponse> StartNisInspectionTaskAsync(StartNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartNisInspectionTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改巡检项
         *
         * @param request UpdateNisInspectionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNisInspectionTaskResponse
         */
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

        /**
         * @summary 修改巡检项
         *
         * @param request UpdateNisInspectionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNisInspectionTaskResponse
         */
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

        /**
         * @summary 修改巡检项
         *
         * @param request UpdateNisInspectionTaskRequest
         * @return UpdateNisInspectionTaskResponse
         */
        public UpdateNisInspectionTaskResponse UpdateNisInspectionTask(UpdateNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNisInspectionTaskWithOptions(request, runtime);
        }

        /**
         * @summary 修改巡检项
         *
         * @param request UpdateNisInspectionTaskRequest
         * @return UpdateNisInspectionTaskResponse
         */
        public async Task<UpdateNisInspectionTaskResponse> UpdateNisInspectionTaskAsync(UpdateNisInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNisInspectionTaskWithOptionsAsync(request, runtime);
        }

    }
}
