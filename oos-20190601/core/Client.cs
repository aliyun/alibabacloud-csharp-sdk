// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Oos20190601.Models;

namespace AlibabaCloud.SDK.Oos20190601
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("oos", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>分析仓库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeGitRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeGitRepositoryResponse
        /// </returns>
        public AnalyzeGitRepositoryResponse AnalyzeGitRepositoryWithOptions(AnalyzeGitRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Branch))
            {
                query["Branch"] = request.Branch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnalyzeGitRepository",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalyzeGitRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分析仓库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeGitRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeGitRepositoryResponse
        /// </returns>
        public async Task<AnalyzeGitRepositoryResponse> AnalyzeGitRepositoryWithOptionsAsync(AnalyzeGitRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Branch))
            {
                query["Branch"] = request.Branch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AnalyzeGitRepository",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalyzeGitRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分析仓库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeGitRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeGitRepositoryResponse
        /// </returns>
        public AnalyzeGitRepositoryResponse AnalyzeGitRepository(AnalyzeGitRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AnalyzeGitRepositoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分析仓库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeGitRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeGitRepositoryResponse
        /// </returns>
        public async Task<AnalyzeGitRepositoryResponse> AnalyzeGitRepositoryAsync(AnalyzeGitRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AnalyzeGitRepositoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelExecutionResponse
        /// </returns>
        public CancelExecutionResponse CancelExecutionWithOptions(CancelExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
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
                Action = "CancelExecution",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelExecutionResponse
        /// </returns>
        public async Task<CancelExecutionResponse> CancelExecutionWithOptionsAsync(CancelExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
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
                Action = "CancelExecution",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelExecutionResponse
        /// </returns>
        public CancelExecutionResponse CancelExecution(CancelExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelExecutionResponse
        /// </returns>
        public async Task<CancelExecutionResponse> CancelExecutionAsync(CancelExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource group to which a cloud resource belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource group to which a cloud resource belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource group to which a cloud resource belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource group to which a cloud resource belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检测仓库中文件是否存在</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckGitRepoFileExistsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckGitRepoFileExistsResponse
        /// </returns>
        public CheckGitRepoFileExistsResponse CheckGitRepoFileExistsWithOptions(CheckGitRepoFileExistsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Branch))
            {
                query["Branch"] = request.Branch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckGitRepoFileExists",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckGitRepoFileExistsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检测仓库中文件是否存在</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckGitRepoFileExistsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckGitRepoFileExistsResponse
        /// </returns>
        public async Task<CheckGitRepoFileExistsResponse> CheckGitRepoFileExistsWithOptionsAsync(CheckGitRepoFileExistsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Branch))
            {
                query["Branch"] = request.Branch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckGitRepoFileExists",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckGitRepoFileExistsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检测仓库中文件是否存在</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckGitRepoFileExistsRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckGitRepoFileExistsResponse
        /// </returns>
        public CheckGitRepoFileExistsResponse CheckGitRepoFileExists(CheckGitRepoFileExistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckGitRepoFileExistsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检测仓库中文件是否存在</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckGitRepoFileExistsRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckGitRepoFileExistsResponse
        /// </returns>
        public async Task<CheckGitRepoFileExistsResponse> CheckGitRepoFileExistsAsync(CheckGitRepoFileExistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckGitRepoFileExistsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检测仓库是否存在</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckGitRepositoryExistsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckGitRepositoryExistsResponse
        /// </returns>
        public CheckGitRepositoryExistsResponse CheckGitRepositoryExistsWithOptions(CheckGitRepositoryExistsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckGitRepositoryExists",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckGitRepositoryExistsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检测仓库是否存在</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckGitRepositoryExistsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckGitRepositoryExistsResponse
        /// </returns>
        public async Task<CheckGitRepositoryExistsResponse> CheckGitRepositoryExistsWithOptionsAsync(CheckGitRepositoryExistsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckGitRepositoryExists",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckGitRepositoryExistsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检测仓库是否存在</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckGitRepositoryExistsRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckGitRepositoryExistsResponse
        /// </returns>
        public CheckGitRepositoryExistsResponse CheckGitRepositoryExists(CheckGitRepositoryExistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckGitRepositoryExistsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检测仓库是否存在</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckGitRepositoryExistsRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckGitRepositoryExistsResponse
        /// </returns>
        public async Task<CheckGitRepositoryExistsResponse> CheckGitRepositoryExistsAsync(CheckGitRepositoryExistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckGitRepositoryExistsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Continues deploying an application group when an error occurs for calling the DeployApplicationGroup operation. You can call this operation only for the applications which reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContinueDeployApplicationGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContinueDeployApplicationGroupResponse
        /// </returns>
        public ContinueDeployApplicationGroupResponse ContinueDeployApplicationGroupWithOptions(ContinueDeployApplicationGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployParameters))
            {
                query["DeployParameters"] = request.DeployParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "ContinueDeployApplicationGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinueDeployApplicationGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Continues deploying an application group when an error occurs for calling the DeployApplicationGroup operation. You can call this operation only for the applications which reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContinueDeployApplicationGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContinueDeployApplicationGroupResponse
        /// </returns>
        public async Task<ContinueDeployApplicationGroupResponse> ContinueDeployApplicationGroupWithOptionsAsync(ContinueDeployApplicationGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployParameters))
            {
                query["DeployParameters"] = request.DeployParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "ContinueDeployApplicationGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContinueDeployApplicationGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Continues deploying an application group when an error occurs for calling the DeployApplicationGroup operation. You can call this operation only for the applications which reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContinueDeployApplicationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ContinueDeployApplicationGroupResponse
        /// </returns>
        public ContinueDeployApplicationGroupResponse ContinueDeployApplicationGroup(ContinueDeployApplicationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContinueDeployApplicationGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Continues deploying an application group when an error occurs for calling the DeployApplicationGroup operation. You can call this operation only for the applications which reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContinueDeployApplicationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ContinueDeployApplicationGroupResponse
        /// </returns>
        public async Task<ContinueDeployApplicationGroupResponse> ContinueDeployApplicationGroupAsync(ContinueDeployApplicationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContinueDeployApplicationGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationResponse
        /// </returns>
        public CreateApplicationResponse CreateApplicationWithOptions(CreateApplicationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateApplicationShrinkRequest request = new CreateApplicationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlarmConfig))
            {
                request.AlarmConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlarmConfig, "AlarmConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmConfigShrink))
            {
                query["AlarmConfig"] = request.AlarmConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationSource))
            {
                query["ApplicationSource"] = request.ApplicationSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplication",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationResponse
        /// </returns>
        public async Task<CreateApplicationResponse> CreateApplicationWithOptionsAsync(CreateApplicationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateApplicationShrinkRequest request = new CreateApplicationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlarmConfig))
            {
                request.AlarmConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlarmConfig, "AlarmConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmConfigShrink))
            {
                query["AlarmConfig"] = request.AlarmConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationSource))
            {
                query["ApplicationSource"] = request.ApplicationSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplication",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationResponse
        /// </returns>
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationResponse
        /// </returns>
        public async Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application group. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApplicationGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationGroupResponse
        /// </returns>
        public CreateApplicationGroupResponse CreateApplicationGroupWithOptions(CreateApplicationGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmsGroupId))
            {
                query["CmsGroupId"] = request.CmsGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployRegionId))
            {
                query["DeployRegionId"] = request.DeployRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportTagKey))
            {
                query["ImportTagKey"] = request.ImportTagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportTagValue))
            {
                query["ImportTagValue"] = request.ImportTagValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "CreateApplicationGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application group. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApplicationGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationGroupResponse
        /// </returns>
        public async Task<CreateApplicationGroupResponse> CreateApplicationGroupWithOptionsAsync(CreateApplicationGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmsGroupId))
            {
                query["CmsGroupId"] = request.CmsGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployRegionId))
            {
                query["DeployRegionId"] = request.DeployRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportTagKey))
            {
                query["ImportTagKey"] = request.ImportTagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportTagValue))
            {
                query["ImportTagValue"] = request.ImportTagValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "CreateApplicationGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application group. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApplicationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationGroupResponse
        /// </returns>
        public CreateApplicationGroupResponse CreateApplicationGroup(CreateApplicationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApplicationGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application group. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApplicationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationGroupResponse
        /// </returns>
        public async Task<CreateApplicationGroupResponse> CreateApplicationGroupAsync(CreateApplicationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApplicationGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建仓库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGitRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGitRepositoryResponse
        /// </returns>
        public CreateGitRepositoryResponse CreateGitRepositoryWithOptions(CreateGitRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPrivate))
            {
                query["IsPrivate"] = request.IsPrivate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRepoBranch))
            {
                query["SourceRepoBranch"] = request.SourceRepoBranch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRepoName))
            {
                query["SourceRepoName"] = request.SourceRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRepoOwner))
            {
                query["SourceRepoOwner"] = request.SourceRepoOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRepoName))
            {
                query["TargetRepoName"] = request.TargetRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRepoOwner))
            {
                query["TargetRepoOwner"] = request.TargetRepoOwner;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGitRepository",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGitRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建仓库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGitRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGitRepositoryResponse
        /// </returns>
        public async Task<CreateGitRepositoryResponse> CreateGitRepositoryWithOptionsAsync(CreateGitRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPrivate))
            {
                query["IsPrivate"] = request.IsPrivate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRepoBranch))
            {
                query["SourceRepoBranch"] = request.SourceRepoBranch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRepoName))
            {
                query["SourceRepoName"] = request.SourceRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRepoOwner))
            {
                query["SourceRepoOwner"] = request.SourceRepoOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRepoName))
            {
                query["TargetRepoName"] = request.TargetRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRepoOwner))
            {
                query["TargetRepoOwner"] = request.TargetRepoOwner;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGitRepository",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGitRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建仓库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGitRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGitRepositoryResponse
        /// </returns>
        public CreateGitRepositoryResponse CreateGitRepository(CreateGitRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGitRepositoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建仓库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGitRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGitRepositoryResponse
        /// </returns>
        public async Task<CreateGitRepositoryResponse> CreateGitRepositoryAsync(CreateGitRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGitRepositoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an O\\\\\\&amp;M Item.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOpsItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOpsItemResponse
        /// </returns>
        public CreateOpsItemResponse CreateOpsItemWithOptions(CreateOpsItemRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOpsItemShrinkRequest request = new CreateOpsItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedupString))
            {
                query["DedupString"] = request.DedupString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solutions))
            {
                query["Solutions"] = request.Solutions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOpsItem",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOpsItemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an O\\\\\\&amp;M Item.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOpsItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOpsItemResponse
        /// </returns>
        public async Task<CreateOpsItemResponse> CreateOpsItemWithOptionsAsync(CreateOpsItemRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOpsItemShrinkRequest request = new CreateOpsItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedupString))
            {
                query["DedupString"] = request.DedupString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solutions))
            {
                query["Solutions"] = request.Solutions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOpsItem",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOpsItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an O\\\\\\&amp;M Item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOpsItemRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOpsItemResponse
        /// </returns>
        public CreateOpsItemResponse CreateOpsItem(CreateOpsItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOpsItemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an O\\\\\\&amp;M Item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOpsItemRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOpsItemResponse
        /// </returns>
        public async Task<CreateOpsItemResponse> CreateOpsItemAsync(CreateOpsItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOpsItemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateParameterResponse
        /// </returns>
        public CreateParameterResponse CreateParameterWithOptions(CreateParameterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateParameterShrinkRequest request = new CreateParameterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Constraints))
            {
                query["Constraints"] = request.Constraints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateParameterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateParameterResponse
        /// </returns>
        public async Task<CreateParameterResponse> CreateParameterWithOptionsAsync(CreateParameterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateParameterShrinkRequest request = new CreateParameterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Constraints))
            {
                query["Constraints"] = request.Constraints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateParameterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateParameterResponse
        /// </returns>
        public CreateParameterResponse CreateParameter(CreateParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateParameterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateParameterResponse
        /// </returns>
        public async Task<CreateParameterResponse> CreateParameterAsync(CreateParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateParameterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePatchBaselineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePatchBaselineResponse
        /// </returns>
        public CreatePatchBaselineResponse CreatePatchBaselineWithOptions(CreatePatchBaselineRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePatchBaselineShrinkRequest request = new CreatePatchBaselineShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApprovedPatches))
            {
                request.ApprovedPatchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApprovedPatches, "ApprovedPatches", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RejectedPatches))
            {
                request.RejectedPatchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RejectedPatches, "RejectedPatches", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalRules))
            {
                query["ApprovalRules"] = request.ApprovalRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedPatchesShrink))
            {
                query["ApprovedPatches"] = request.ApprovedPatchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedPatchesEnableNonSecurity))
            {
                query["ApprovedPatchesEnableNonSecurity"] = request.ApprovedPatchesEnableNonSecurity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationSystem))
            {
                query["OperationSystem"] = request.OperationSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RejectedPatchesShrink))
            {
                query["RejectedPatches"] = request.RejectedPatchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RejectedPatchesAction))
            {
                query["RejectedPatchesAction"] = request.RejectedPatchesAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePatchBaseline",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePatchBaselineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreatePatchBaselineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePatchBaselineResponse
        /// </returns>
        public async Task<CreatePatchBaselineResponse> CreatePatchBaselineWithOptionsAsync(CreatePatchBaselineRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePatchBaselineShrinkRequest request = new CreatePatchBaselineShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApprovedPatches))
            {
                request.ApprovedPatchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApprovedPatches, "ApprovedPatches", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RejectedPatches))
            {
                request.RejectedPatchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RejectedPatches, "RejectedPatches", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalRules))
            {
                query["ApprovalRules"] = request.ApprovalRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedPatchesShrink))
            {
                query["ApprovedPatches"] = request.ApprovedPatchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedPatchesEnableNonSecurity))
            {
                query["ApprovedPatchesEnableNonSecurity"] = request.ApprovedPatchesEnableNonSecurity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationSystem))
            {
                query["OperationSystem"] = request.OperationSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RejectedPatchesShrink))
            {
                query["RejectedPatches"] = request.RejectedPatchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RejectedPatchesAction))
            {
                query["RejectedPatchesAction"] = request.RejectedPatchesAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePatchBaseline",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePatchBaselineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePatchBaselineRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePatchBaselineResponse
        /// </returns>
        public CreatePatchBaselineResponse CreatePatchBaseline(CreatePatchBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePatchBaselineWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePatchBaselineRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePatchBaselineResponse
        /// </returns>
        public async Task<CreatePatchBaselineResponse> CreatePatchBaselineAsync(CreatePatchBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePatchBaselineWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an encryption parameter. Make sure that you have the permissions to call this operation.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSecretParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSecretParameterResponse
        /// </returns>
        public CreateSecretParameterResponse CreateSecretParameterWithOptions(CreateSecretParameterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSecretParameterShrinkRequest request = new CreateSecretParameterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Constraints))
            {
                query["Constraints"] = request.Constraints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DKMSInstanceId))
            {
                query["DKMSInstanceId"] = request.DKMSInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecretParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecretParameterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an encryption parameter. Make sure that you have the permissions to call this operation.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSecretParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSecretParameterResponse
        /// </returns>
        public async Task<CreateSecretParameterResponse> CreateSecretParameterWithOptionsAsync(CreateSecretParameterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSecretParameterShrinkRequest request = new CreateSecretParameterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Constraints))
            {
                query["Constraints"] = request.Constraints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DKMSInstanceId))
            {
                query["DKMSInstanceId"] = request.DKMSInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecretParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecretParameterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an encryption parameter. Make sure that you have the permissions to call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecretParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSecretParameterResponse
        /// </returns>
        public CreateSecretParameterResponse CreateSecretParameter(CreateSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSecretParameterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an encryption parameter. Make sure that you have the permissions to call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecretParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSecretParameterResponse
        /// </returns>
        public async Task<CreateSecretParameterResponse> CreateSecretParameterAsync(CreateSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSecretParameterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a desired-state configuration.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateStateConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStateConfigurationResponse
        /// </returns>
        public CreateStateConfigurationResponse CreateStateConfigurationWithOptions(CreateStateConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStateConfigurationShrinkRequest request = new CreateStateConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigureMode))
            {
                query["ConfigureMode"] = request.ConfigureMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleExpression))
            {
                query["ScheduleExpression"] = request.ScheduleExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                query["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStateConfiguration",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStateConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a desired-state configuration.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateStateConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStateConfigurationResponse
        /// </returns>
        public async Task<CreateStateConfigurationResponse> CreateStateConfigurationWithOptionsAsync(CreateStateConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStateConfigurationShrinkRequest request = new CreateStateConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigureMode))
            {
                query["ConfigureMode"] = request.ConfigureMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleExpression))
            {
                query["ScheduleExpression"] = request.ScheduleExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                query["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStateConfiguration",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStateConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a desired-state configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateStateConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStateConfigurationResponse
        /// </returns>
        public CreateStateConfigurationResponse CreateStateConfiguration(CreateStateConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStateConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a desired-state configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateStateConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStateConfigurationResponse
        /// </returns>
        public async Task<CreateStateConfigurationResponse> CreateStateConfigurationAsync(CreateStateConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStateConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a template.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2019-06-01",
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
        /// <para>Creates a template.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2019-06-01",
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
        /// <para>Creates a template.</para>
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
        /// <para>Creates a template.</para>
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
        /// <para>Deletes an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationResponse
        /// </returns>
        public DeleteApplicationResponse DeleteApplicationWithOptions(DeleteApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResource))
            {
                query["RetainResource"] = request.RetainResource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplication",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationResponse
        /// </returns>
        public async Task<DeleteApplicationResponse> DeleteApplicationWithOptionsAsync(DeleteApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResource))
            {
                query["RetainResource"] = request.RetainResource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplication",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationResponse
        /// </returns>
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationResponse
        /// </returns>
        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application group. You can call this operation only for the application groups which reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationGroupResponse
        /// </returns>
        public DeleteApplicationGroupResponse DeleteApplicationGroupWithOptions(DeleteApplicationGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResource))
            {
                query["RetainResource"] = request.RetainResource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplicationGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application group. You can call this operation only for the application groups which reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationGroupResponse
        /// </returns>
        public async Task<DeleteApplicationGroupResponse> DeleteApplicationGroupWithOptionsAsync(DeleteApplicationGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResource))
            {
                query["RetainResource"] = request.RetainResource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplicationGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application group. You can call this operation only for the application groups which reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationGroupResponse
        /// </returns>
        public DeleteApplicationGroupResponse DeleteApplicationGroup(DeleteApplicationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApplicationGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application group. You can call this operation only for the application groups which reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationGroupResponse
        /// </returns>
        public async Task<DeleteApplicationGroupResponse> DeleteApplicationGroupAsync(DeleteApplicationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApplicationGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple executions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExecutionsResponse
        /// </returns>
        public DeleteExecutionsResponse DeleteExecutionsWithOptions(DeleteExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionIds))
            {
                query["ExecutionIds"] = request.ExecutionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
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
                Action = "DeleteExecutions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExecutionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple executions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExecutionsResponse
        /// </returns>
        public async Task<DeleteExecutionsResponse> DeleteExecutionsWithOptionsAsync(DeleteExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionIds))
            {
                query["ExecutionIds"] = request.ExecutionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
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
                Action = "DeleteExecutions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExecutionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple executions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExecutionsResponse
        /// </returns>
        public DeleteExecutionsResponse DeleteExecutions(DeleteExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExecutionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple executions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExecutionsResponse
        /// </returns>
        public async Task<DeleteExecutionsResponse> DeleteExecutionsAsync(DeleteExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExecutionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes O\\\&amp;M Items.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOpsItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOpsItemsResponse
        /// </returns>
        public DeleteOpsItemsResponse DeleteOpsItemsWithOptions(DeleteOpsItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsItemIds))
            {
                query["OpsItemIds"] = request.OpsItemIds;
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
                Action = "DeleteOpsItems",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOpsItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes O\\\&amp;M Items.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOpsItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOpsItemsResponse
        /// </returns>
        public async Task<DeleteOpsItemsResponse> DeleteOpsItemsWithOptionsAsync(DeleteOpsItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsItemIds))
            {
                query["OpsItemIds"] = request.OpsItemIds;
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
                Action = "DeleteOpsItems",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOpsItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes O\\\&amp;M Items.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOpsItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOpsItemsResponse
        /// </returns>
        public DeleteOpsItemsResponse DeleteOpsItems(DeleteOpsItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOpsItemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes O\\\&amp;M Items.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOpsItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOpsItemsResponse
        /// </returns>
        public async Task<DeleteOpsItemsResponse> DeleteOpsItemsAsync(DeleteOpsItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOpsItemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteParameterResponse
        /// </returns>
        public DeleteParameterResponse DeleteParameterWithOptions(DeleteParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "DeleteParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteParameterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteParameterResponse
        /// </returns>
        public async Task<DeleteParameterResponse> DeleteParameterWithOptionsAsync(DeleteParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "DeleteParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteParameterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteParameterResponse
        /// </returns>
        public DeleteParameterResponse DeleteParameter(DeleteParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteParameterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteParameterResponse
        /// </returns>
        public async Task<DeleteParameterResponse> DeleteParameterAsync(DeleteParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteParameterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePatchBaselineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePatchBaselineResponse
        /// </returns>
        public DeletePatchBaselineResponse DeletePatchBaselineWithOptions(DeletePatchBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "DeletePatchBaseline",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePatchBaselineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePatchBaselineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePatchBaselineResponse
        /// </returns>
        public async Task<DeletePatchBaselineResponse> DeletePatchBaselineWithOptionsAsync(DeletePatchBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "DeletePatchBaseline",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePatchBaselineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePatchBaselineRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePatchBaselineResponse
        /// </returns>
        public DeletePatchBaselineResponse DeletePatchBaseline(DeletePatchBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePatchBaselineWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePatchBaselineRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePatchBaselineResponse
        /// </returns>
        public async Task<DeletePatchBaselineResponse> DeletePatchBaselineAsync(DeletePatchBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePatchBaselineWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an encryption parameter. Make sure that you have the permissions to call the DeleteSecret operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecretParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretParameterResponse
        /// </returns>
        public DeleteSecretParameterResponse DeleteSecretParameterWithOptions(DeleteSecretParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "DeleteSecretParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecretParameterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an encryption parameter. Make sure that you have the permissions to call the DeleteSecret operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecretParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretParameterResponse
        /// </returns>
        public async Task<DeleteSecretParameterResponse> DeleteSecretParameterWithOptionsAsync(DeleteSecretParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "DeleteSecretParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecretParameterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an encryption parameter. Make sure that you have the permissions to call the DeleteSecret operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecretParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretParameterResponse
        /// </returns>
        public DeleteSecretParameterResponse DeleteSecretParameter(DeleteSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecretParameterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an encryption parameter. Make sure that you have the permissions to call the DeleteSecret operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecretParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretParameterResponse
        /// </returns>
        public async Task<DeleteSecretParameterResponse> DeleteSecretParameterAsync(DeleteSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecretParameterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple desired-state configurations at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteStateConfigurationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteStateConfigurationsResponse
        /// </returns>
        public DeleteStateConfigurationsResponse DeleteStateConfigurationsWithOptions(DeleteStateConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateConfigurationIds))
            {
                query["StateConfigurationIds"] = request.StateConfigurationIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStateConfigurations",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStateConfigurationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple desired-state configurations at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteStateConfigurationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteStateConfigurationsResponse
        /// </returns>
        public async Task<DeleteStateConfigurationsResponse> DeleteStateConfigurationsWithOptionsAsync(DeleteStateConfigurationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateConfigurationIds))
            {
                query["StateConfigurationIds"] = request.StateConfigurationIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStateConfigurations",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStateConfigurationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple desired-state configurations at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteStateConfigurationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteStateConfigurationsResponse
        /// </returns>
        public DeleteStateConfigurationsResponse DeleteStateConfigurations(DeleteStateConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStateConfigurationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple desired-state configurations at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteStateConfigurationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteStateConfigurationsResponse
        /// </returns>
        public async Task<DeleteStateConfigurationsResponse> DeleteStateConfigurationsAsync(DeleteStateConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStateConfigurationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a template.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDeleteExecutions))
            {
                query["AutoDeleteExecutions"] = request.AutoDeleteExecutions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2019-06-01",
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
        /// <para>Deletes a template.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDeleteExecutions))
            {
                query["AutoDeleteExecutions"] = request.AutoDeleteExecutions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2019-06-01",
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
        /// <para>Deletes a template.</para>
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
        /// <para>Deletes a template.</para>
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
        /// <para>Deletes multiple templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplatesResponse
        /// </returns>
        public DeleteTemplatesResponse DeleteTemplatesWithOptions(DeleteTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDeleteExecutions))
            {
                query["AutoDeleteExecutions"] = request.AutoDeleteExecutions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateNames))
            {
                query["TemplateNames"] = request.TemplateNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplates",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplatesResponse
        /// </returns>
        public async Task<DeleteTemplatesResponse> DeleteTemplatesWithOptionsAsync(DeleteTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDeleteExecutions))
            {
                query["AutoDeleteExecutions"] = request.AutoDeleteExecutions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateNames))
            {
                query["TemplateNames"] = request.TemplateNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplates",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplatesResponse
        /// </returns>
        public DeleteTemplatesResponse DeleteTemplates(DeleteTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTemplatesResponse
        /// </returns>
        public async Task<DeleteTemplatesResponse> DeleteTemplatesAsync(DeleteTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploys an application group. You can call this operation only for the applications which reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployApplicationGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployApplicationGroupResponse
        /// </returns>
        public DeployApplicationGroupResponse DeployApplicationGroupWithOptions(DeployApplicationGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployParameters))
            {
                query["DeployParameters"] = request.DeployParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionId))
            {
                query["RevisionId"] = request.RevisionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployApplicationGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployApplicationGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploys an application group. You can call this operation only for the applications which reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployApplicationGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployApplicationGroupResponse
        /// </returns>
        public async Task<DeployApplicationGroupResponse> DeployApplicationGroupWithOptionsAsync(DeployApplicationGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployParameters))
            {
                query["DeployParameters"] = request.DeployParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevisionId))
            {
                query["RevisionId"] = request.RevisionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployApplicationGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployApplicationGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploys an application group. You can call this operation only for the applications which reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployApplicationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployApplicationGroupResponse
        /// </returns>
        public DeployApplicationGroupResponse DeployApplicationGroup(DeployApplicationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployApplicationGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploys an application group. You can call this operation only for the applications which reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployApplicationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployApplicationGroupResponse
        /// </returns>
        public async Task<DeployApplicationGroupResponse> DeployApplicationGroupAsync(DeployApplicationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployApplicationGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用分组资源成本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationGroupBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationGroupBillResponse
        /// </returns>
        public DescribeApplicationGroupBillResponse DescribeApplicationGroupBillWithOptions(DescribeApplicationGroupBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationGroupBill",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationGroupBillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用分组资源成本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationGroupBillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationGroupBillResponse
        /// </returns>
        public async Task<DescribeApplicationGroupBillResponse> DescribeApplicationGroupBillWithOptionsAsync(DescribeApplicationGroupBillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingCycle))
            {
                query["BillingCycle"] = request.BillingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationGroupBill",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationGroupBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用分组资源成本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationGroupBillRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationGroupBillResponse
        /// </returns>
        public DescribeApplicationGroupBillResponse DescribeApplicationGroupBill(DescribeApplicationGroupBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApplicationGroupBillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用分组资源成本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationGroupBillRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationGroupBillResponse
        /// </returns>
        public async Task<DescribeApplicationGroupBillResponse> DescribeApplicationGroupBillAsync(DescribeApplicationGroupBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApplicationGroupBillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries supported regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
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
                Action = "DescribeRegions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries supported regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
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
                Action = "DescribeRegions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries supported regions.</para>
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
            return DescribeRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries supported regions.</para>
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
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Resource Access Management (RAM) policy required for template execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateExecutionPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateExecutionPolicyResponse
        /// </returns>
        public GenerateExecutionPolicyResponse GenerateExecutionPolicyWithOptions(GenerateExecutionPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                query["RamRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateExecutionPolicy",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateExecutionPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Resource Access Management (RAM) policy required for template execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateExecutionPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateExecutionPolicyResponse
        /// </returns>
        public async Task<GenerateExecutionPolicyResponse> GenerateExecutionPolicyWithOptionsAsync(GenerateExecutionPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                query["RamRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateExecutionPolicy",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateExecutionPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Resource Access Management (RAM) policy required for template execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateExecutionPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateExecutionPolicyResponse
        /// </returns>
        public GenerateExecutionPolicyResponse GenerateExecutionPolicy(GenerateExecutionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateExecutionPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Resource Access Management (RAM) policy required for template execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateExecutionPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateExecutionPolicyResponse
        /// </returns>
        public async Task<GenerateExecutionPolicyResponse> GenerateExecutionPolicyAsync(GenerateExecutionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateExecutionPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates an O\\\&amp;M item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateOpsItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateOpsItemResponse
        /// </returns>
        public GenerateOpsItemResponse GenerateOpsItemWithOptions(GenerateOpsItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationId))
            {
                query["ConfigurationId"] = request.ConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["DataSource"] = request.DataSource;
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
                Action = "GenerateOpsItem",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateOpsItemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates an O\\\&amp;M item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateOpsItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateOpsItemResponse
        /// </returns>
        public async Task<GenerateOpsItemResponse> GenerateOpsItemWithOptionsAsync(GenerateOpsItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationId))
            {
                query["ConfigurationId"] = request.ConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["DataSource"] = request.DataSource;
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
                Action = "GenerateOpsItem",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateOpsItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates an O\\\&amp;M item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateOpsItemRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateOpsItemResponse
        /// </returns>
        public GenerateOpsItemResponse GenerateOpsItem(GenerateOpsItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateOpsItemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates an O\\\&amp;M item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateOpsItemRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateOpsItemResponse
        /// </returns>
        public async Task<GenerateOpsItemResponse> GenerateOpsItemAsync(GenerateOpsItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateOpsItemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationResponse
        /// </returns>
        public GetApplicationResponse GetApplicationWithOptions(GetApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "GetApplication",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationResponse
        /// </returns>
        public async Task<GetApplicationResponse> GetApplicationWithOptionsAsync(GetApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "GetApplication",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationResponse
        /// </returns>
        public GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationResponse
        /// </returns>
        public async Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an application group. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationGroupResponse
        /// </returns>
        public GetApplicationGroupResponse GetApplicationGroupWithOptions(GetApplicationGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "GetApplicationGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an application group. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationGroupResponse
        /// </returns>
        public async Task<GetApplicationGroupResponse> GetApplicationGroupWithOptionsAsync(GetApplicationGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "GetApplicationGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an application group. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationGroupResponse
        /// </returns>
        public GetApplicationGroupResponse GetApplicationGroup(GetApplicationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApplicationGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an application group. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationGroupResponse
        /// </returns>
        public async Task<GetApplicationGroupResponse> GetApplicationGroupAsync(GetApplicationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApplicationGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the template of an execution, including the content of the template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExecutionTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExecutionTemplateResponse
        /// </returns>
        public GetExecutionTemplateResponse GetExecutionTemplateWithOptions(GetExecutionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
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
                Action = "GetExecutionTemplate",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExecutionTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the template of an execution, including the content of the template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExecutionTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExecutionTemplateResponse
        /// </returns>
        public async Task<GetExecutionTemplateResponse> GetExecutionTemplateWithOptionsAsync(GetExecutionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
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
                Action = "GetExecutionTemplate",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExecutionTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the template of an execution, including the content of the template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExecutionTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExecutionTemplateResponse
        /// </returns>
        public GetExecutionTemplateResponse GetExecutionTemplate(GetExecutionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetExecutionTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the template of an execution, including the content of the template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExecutionTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExecutionTemplateResponse
        /// </returns>
        public async Task<GetExecutionTemplateResponse> GetExecutionTemplateAsync(GetExecutionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetExecutionTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Git分支详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGitBranchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGitBranchResponse
        /// </returns>
        public GetGitBranchResponse GetGitBranchWithOptions(GetGitBranchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Branch))
            {
                query["Branch"] = request.Branch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGitBranch",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGitBranchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Git分支详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGitBranchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGitBranchResponse
        /// </returns>
        public async Task<GetGitBranchResponse> GetGitBranchWithOptionsAsync(GetGitBranchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Branch))
            {
                query["Branch"] = request.Branch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGitBranch",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGitBranchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Git分支详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGitBranchRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGitBranchResponse
        /// </returns>
        public GetGitBranchResponse GetGitBranch(GetGitBranchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGitBranchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Git分支详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGitBranchRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGitBranchResponse
        /// </returns>
        public async Task<GetGitBranchResponse> GetGitBranchAsync(GetGitBranchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGitBranchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Git仓库详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGitRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGitRepositoryResponse
        /// </returns>
        public GetGitRepositoryResponse GetGitRepositoryWithOptions(GetGitRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGitRepository",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGitRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Git仓库详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGitRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGitRepositoryResponse
        /// </returns>
        public async Task<GetGitRepositoryResponse> GetGitRepositoryWithOptionsAsync(GetGitRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGitRepository",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGitRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Git仓库详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGitRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGitRepositoryResponse
        /// </returns>
        public GetGitRepositoryResponse GetGitRepository(GetGitRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGitRepositoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Git仓库详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetGitRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetGitRepositoryResponse
        /// </returns>
        public async Task<GetGitRepositoryResponse> GetGitRepositoryAsync(GetGitRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGitRepositoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the properties of a configuration list.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInventorySchemaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInventorySchemaResponse
        /// </returns>
        public GetInventorySchemaResponse GetInventorySchemaWithOptions(GetInventorySchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregator))
            {
                query["Aggregator"] = request.Aggregator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeName))
            {
                query["TypeName"] = request.TypeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInventorySchema",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInventorySchemaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the properties of a configuration list.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInventorySchemaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInventorySchemaResponse
        /// </returns>
        public async Task<GetInventorySchemaResponse> GetInventorySchemaWithOptionsAsync(GetInventorySchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregator))
            {
                query["Aggregator"] = request.Aggregator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeName))
            {
                query["TypeName"] = request.TypeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInventorySchema",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInventorySchemaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the properties of a configuration list.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInventorySchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInventorySchemaResponse
        /// </returns>
        public GetInventorySchemaResponse GetInventorySchema(GetInventorySchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInventorySchemaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the properties of a configuration list.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInventorySchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInventorySchemaResponse
        /// </returns>
        public async Task<GetInventorySchemaResponse> GetInventorySchemaAsync(GetInventorySchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInventorySchemaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an O\\\\\\&amp;M item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOpsItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOpsItemResponse
        /// </returns>
        public GetOpsItemResponse GetOpsItemWithOptions(GetOpsItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsItemId))
            {
                query["OpsItemId"] = request.OpsItemId;
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
                Action = "GetOpsItem",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOpsItemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an O\\\\\\&amp;M item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOpsItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOpsItemResponse
        /// </returns>
        public async Task<GetOpsItemResponse> GetOpsItemWithOptionsAsync(GetOpsItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsItemId))
            {
                query["OpsItemId"] = request.OpsItemId;
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
                Action = "GetOpsItem",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOpsItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an O\\\\\\&amp;M item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOpsItemRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOpsItemResponse
        /// </returns>
        public GetOpsItemResponse GetOpsItem(GetOpsItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOpsItemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an O\\\\\\&amp;M item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOpsItemRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOpsItemResponse
        /// </returns>
        public async Task<GetOpsItemResponse> GetOpsItemAsync(GetOpsItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOpsItemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a common parameter and its value.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParameterResponse
        /// </returns>
        public GetParameterResponse GetParameterWithOptions(GetParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterVersion))
            {
                query["ParameterVersion"] = request.ParameterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParameterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a common parameter and its value.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParameterResponse
        /// </returns>
        public async Task<GetParameterResponse> GetParameterWithOptionsAsync(GetParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterVersion))
            {
                query["ParameterVersion"] = request.ParameterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParameterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a common parameter and its value.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParameterResponse
        /// </returns>
        public GetParameterResponse GetParameter(GetParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetParameterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a common parameter and its value.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParameterResponse
        /// </returns>
        public async Task<GetParameterResponse> GetParameterAsync(GetParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetParameterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParametersResponse
        /// </returns>
        public GetParametersResponse GetParametersWithOptions(GetParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Names))
            {
                query["Names"] = request.Names;
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
                Action = "GetParameters",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParametersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParametersResponse
        /// </returns>
        public async Task<GetParametersResponse> GetParametersWithOptionsAsync(GetParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Names))
            {
                query["Names"] = request.Names;
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
                Action = "GetParameters",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParametersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParametersResponse
        /// </returns>
        public GetParametersResponse GetParameters(GetParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetParametersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParametersResponse
        /// </returns>
        public async Task<GetParametersResponse> GetParametersAsync(GetParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetParametersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more parameters by path.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParametersByPathRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParametersByPathResponse
        /// </returns>
        public GetParametersByPathResponse GetParametersByPathWithOptions(GetParametersByPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recursive))
            {
                query["Recursive"] = request.Recursive;
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
                Action = "GetParametersByPath",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParametersByPathResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more parameters by path.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParametersByPathRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParametersByPathResponse
        /// </returns>
        public async Task<GetParametersByPathResponse> GetParametersByPathWithOptionsAsync(GetParametersByPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recursive))
            {
                query["Recursive"] = request.Recursive;
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
                Action = "GetParametersByPath",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParametersByPathResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more parameters by path.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParametersByPathRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParametersByPathResponse
        /// </returns>
        public GetParametersByPathResponse GetParametersByPath(GetParametersByPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetParametersByPathWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more parameters by path.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetParametersByPathRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParametersByPathResponse
        /// </returns>
        public async Task<GetParametersByPathResponse> GetParametersByPathAsync(GetParametersByPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetParametersByPathWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPatchBaselineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPatchBaselineResponse
        /// </returns>
        public GetPatchBaselineResponse GetPatchBaselineWithOptions(GetPatchBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "GetPatchBaseline",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPatchBaselineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPatchBaselineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPatchBaselineResponse
        /// </returns>
        public async Task<GetPatchBaselineResponse> GetPatchBaselineWithOptionsAsync(GetPatchBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "GetPatchBaseline",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPatchBaselineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPatchBaselineRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPatchBaselineResponse
        /// </returns>
        public GetPatchBaselineResponse GetPatchBaseline(GetPatchBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPatchBaselineWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPatchBaselineRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPatchBaselineResponse
        /// </returns>
        public async Task<GetPatchBaselineResponse> GetPatchBaselineAsync(GetPatchBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPatchBaselineWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an encryption parameter, including the parameter value. Make sure that you have the permissions to call the GetSecretValue operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecretParameterResponse
        /// </returns>
        public GetSecretParameterResponse GetSecretParameterWithOptions(GetSecretParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterVersion))
            {
                query["ParameterVersion"] = request.ParameterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDecryption))
            {
                query["WithDecryption"] = request.WithDecryption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecretParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecretParameterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an encryption parameter, including the parameter value. Make sure that you have the permissions to call the GetSecretValue operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecretParameterResponse
        /// </returns>
        public async Task<GetSecretParameterResponse> GetSecretParameterWithOptionsAsync(GetSecretParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterVersion))
            {
                query["ParameterVersion"] = request.ParameterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDecryption))
            {
                query["WithDecryption"] = request.WithDecryption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecretParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecretParameterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an encryption parameter, including the parameter value. Make sure that you have the permissions to call the GetSecretValue operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecretParameterResponse
        /// </returns>
        public GetSecretParameterResponse GetSecretParameter(GetSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretParameterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an encryption parameter, including the parameter value. Make sure that you have the permissions to call the GetSecretValue operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecretParameterResponse
        /// </returns>
        public async Task<GetSecretParameterResponse> GetSecretParameterAsync(GetSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretParameterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more encryption parameters. Make sure that you have the permissions to call the GetSecretValue operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecretParametersResponse
        /// </returns>
        public GetSecretParametersResponse GetSecretParametersWithOptions(GetSecretParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Names))
            {
                query["Names"] = request.Names;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDecryption))
            {
                query["WithDecryption"] = request.WithDecryption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecretParameters",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecretParametersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more encryption parameters. Make sure that you have the permissions to call the GetSecretValue operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecretParametersResponse
        /// </returns>
        public async Task<GetSecretParametersResponse> GetSecretParametersWithOptionsAsync(GetSecretParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Names))
            {
                query["Names"] = request.Names;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDecryption))
            {
                query["WithDecryption"] = request.WithDecryption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecretParameters",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecretParametersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more encryption parameters. Make sure that you have the permissions to call the GetSecretValue operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecretParametersResponse
        /// </returns>
        public GetSecretParametersResponse GetSecretParameters(GetSecretParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretParametersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more encryption parameters. Make sure that you have the permissions to call the GetSecretValue operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecretParametersResponse
        /// </returns>
        public async Task<GetSecretParametersResponse> GetSecretParametersAsync(GetSecretParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretParametersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries encryption parameters by path. Make sure that you have the permissions to call the GetSecretValue operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretParametersByPathRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecretParametersByPathResponse
        /// </returns>
        public GetSecretParametersByPathResponse GetSecretParametersByPathWithOptions(GetSecretParametersByPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recursive))
            {
                query["Recursive"] = request.Recursive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDecryption))
            {
                query["WithDecryption"] = request.WithDecryption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecretParametersByPath",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecretParametersByPathResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries encryption parameters by path. Make sure that you have the permissions to call the GetSecretValue operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretParametersByPathRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecretParametersByPathResponse
        /// </returns>
        public async Task<GetSecretParametersByPathResponse> GetSecretParametersByPathWithOptionsAsync(GetSecretParametersByPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recursive))
            {
                query["Recursive"] = request.Recursive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDecryption))
            {
                query["WithDecryption"] = request.WithDecryption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecretParametersByPath",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecretParametersByPathResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries encryption parameters by path. Make sure that you have the permissions to call the GetSecretValue operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretParametersByPathRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecretParametersByPathResponse
        /// </returns>
        public GetSecretParametersByPathResponse GetSecretParametersByPath(GetSecretParametersByPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretParametersByPathWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries encryption parameters by path. Make sure that you have the permissions to call the GetSecretValue operation before you call this operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretParametersByPathRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecretParametersByPathResponse
        /// </returns>
        public async Task<GetSecretParametersByPathResponse> GetSecretParametersByPathAsync(GetSecretParametersByPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretParametersByPathWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the settings of the delivery feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetServiceSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceSettingsResponse
        /// </returns>
        public GetServiceSettingsResponse GetServiceSettingsWithOptions(GetServiceSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceSettings",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceSettingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the settings of the delivery feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetServiceSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceSettingsResponse
        /// </returns>
        public async Task<GetServiceSettingsResponse> GetServiceSettingsWithOptionsAsync(GetServiceSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceSettings",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the settings of the delivery feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetServiceSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceSettingsResponse
        /// </returns>
        public GetServiceSettingsResponse GetServiceSettings(GetServiceSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceSettingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the settings of the delivery feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetServiceSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceSettingsResponse
        /// </returns>
        public async Task<GetServiceSettingsResponse> GetServiceSettingsAsync(GetServiceSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceSettingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a template, including the content of the template.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2019-06-01",
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
        /// <para>Queries the information about a template, including the content of the template.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2019-06-01",
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
        /// <para>Queries the information about a template, including the content of the template.</para>
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
        /// <para>Queries the information about a template, including the content of the template.</para>
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
        /// <para>获取参数可用值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateParameterConstraintsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateParameterConstraintsResponse
        /// </returns>
        public GetTemplateParameterConstraintsResponse GetTemplateParameterConstraintsWithOptions(GetTemplateParameterConstraintsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateParameterConstraints",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateParameterConstraintsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取参数可用值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateParameterConstraintsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateParameterConstraintsResponse
        /// </returns>
        public async Task<GetTemplateParameterConstraintsResponse> GetTemplateParameterConstraintsWithOptionsAsync(GetTemplateParameterConstraintsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateParameterConstraints",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateParameterConstraintsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取参数可用值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateParameterConstraintsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateParameterConstraintsResponse
        /// </returns>
        public GetTemplateParameterConstraintsResponse GetTemplateParameterConstraints(GetTemplateParameterConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateParameterConstraintsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取参数可用值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateParameterConstraintsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateParameterConstraintsResponse
        /// </returns>
        public async Task<GetTemplateParameterConstraintsResponse> GetTemplateParameterConstraintsAsync(GetTemplateParameterConstraintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateParameterConstraintsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available actions, including atomic actions and cloud product actions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListActionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListActionsResponse
        /// </returns>
        public ListActionsResponse ListActionsWithOptions(ListActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OOSActionName))
            {
                query["OOSActionName"] = request.OOSActionName;
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
                Action = "ListActions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListActionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available actions, including atomic actions and cloud product actions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListActionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListActionsResponse
        /// </returns>
        public async Task<ListActionsResponse> ListActionsWithOptionsAsync(ListActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OOSActionName))
            {
                query["OOSActionName"] = request.OOSActionName;
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
                Action = "ListActions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListActionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available actions, including atomic actions and cloud product actions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListActionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListActionsResponse
        /// </returns>
        public ListActionsResponse ListActions(ListActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListActionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available actions, including atomic actions and cloud product actions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListActionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListActionsResponse
        /// </returns>
        public async Task<ListActionsResponse> ListActionsAsync(ListActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListActionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of application groups. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationGroupsResponse
        /// </returns>
        public ListApplicationGroupsResponse ListApplicationGroupsWithOptions(ListApplicationGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployRegionId))
            {
                query["DeployRegionId"] = request.DeployRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceProduct))
            {
                query["ResourceProduct"] = request.ResourceProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationGroups",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of application groups. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationGroupsResponse
        /// </returns>
        public async Task<ListApplicationGroupsResponse> ListApplicationGroupsWithOptionsAsync(ListApplicationGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployRegionId))
            {
                query["DeployRegionId"] = request.DeployRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceProduct))
            {
                query["ResourceProduct"] = request.ResourceProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationGroups",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of application groups. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationGroupsResponse
        /// </returns>
        public ListApplicationGroupsResponse ListApplicationGroups(ListApplicationGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of application groups. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationGroupsResponse
        /// </returns>
        public async Task<ListApplicationGroupsResponse> ListApplicationGroupsAsync(ListApplicationGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of applications. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsResponse
        /// </returns>
        public ListApplicationsResponse ListApplicationsWithOptions(ListApplicationsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListApplicationsShrinkRequest request = new ListApplicationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                query["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Names))
            {
                query["Names"] = request.Names;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplications",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of applications. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsResponse
        /// </returns>
        public async Task<ListApplicationsResponse> ListApplicationsWithOptionsAsync(ListApplicationsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListApplicationsShrinkRequest request = new ListApplicationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                query["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Names))
            {
                query["Names"] = request.Names;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplications",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of applications. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsResponse
        /// </returns>
        public ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of applications. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsResponse
        /// </returns>
        public async Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of an execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExecutionLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionLogsResponse
        /// </returns>
        public ListExecutionLogsResponse ListExecutionLogsWithOptions(ListExecutionLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                query["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutionId))
            {
                query["TaskExecutionId"] = request.TaskExecutionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutionLogs",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutionLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of an execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExecutionLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionLogsResponse
        /// </returns>
        public async Task<ListExecutionLogsResponse> ListExecutionLogsWithOptionsAsync(ListExecutionLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                query["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutionId))
            {
                query["TaskExecutionId"] = request.TaskExecutionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutionLogs",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutionLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of an execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExecutionLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionLogsResponse
        /// </returns>
        public ListExecutionLogsResponse ListExecutionLogs(ListExecutionLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExecutionLogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of an execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// ListExecutionLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionLogsResponse
        /// </returns>
        public async Task<ListExecutionLogsResponse> ListExecutionLogsAsync(ListExecutionLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExecutionLogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries high-risk tasks in the execution of a template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExecutionRiskyTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionRiskyTasksResponse
        /// </returns>
        public ListExecutionRiskyTasksResponse ListExecutionRiskyTasksWithOptions(ListExecutionRiskyTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutionRiskyTasks",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutionRiskyTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries high-risk tasks in the execution of a template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExecutionRiskyTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionRiskyTasksResponse
        /// </returns>
        public async Task<ListExecutionRiskyTasksResponse> ListExecutionRiskyTasksWithOptionsAsync(ListExecutionRiskyTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutionRiskyTasks",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutionRiskyTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries high-risk tasks in the execution of a template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExecutionRiskyTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionRiskyTasksResponse
        /// </returns>
        public ListExecutionRiskyTasksResponse ListExecutionRiskyTasks(ListExecutionRiskyTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExecutionRiskyTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries high-risk tasks in the execution of a template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExecutionRiskyTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionRiskyTasksResponse
        /// </returns>
        public async Task<ListExecutionRiskyTasksResponse> ListExecutionRiskyTasksAsync(ListExecutionRiskyTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExecutionRiskyTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries executions. Multiple methods are supported to filter executions.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionsResponse
        /// </returns>
        public ListExecutionsResponse ListExecutionsWithOptions(ListExecutionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListExecutionsShrinkRequest request = new ListExecutionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Categories))
            {
                query["Categories"] = request.Categories;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Depth))
            {
                query["Depth"] = request.Depth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateAfter))
            {
                query["EndDateAfter"] = request.EndDateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateBefore))
            {
                query["EndDateBefore"] = request.EndDateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutedBy))
            {
                query["ExecutedBy"] = request.ExecutedBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeChildExecution))
            {
                query["IncludeChildExecution"] = request.IncludeChildExecution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentExecutionId))
            {
                query["ParentExecutionId"] = request.ParentExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                query["RamRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTemplateName))
            {
                query["ResourceTemplateName"] = request.ResourceTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateAfter))
            {
                query["StartDateAfter"] = request.StartDateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateBefore))
            {
                query["StartDateBefore"] = request.StartDateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries executions. Multiple methods are supported to filter executions.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionsResponse
        /// </returns>
        public async Task<ListExecutionsResponse> ListExecutionsWithOptionsAsync(ListExecutionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListExecutionsShrinkRequest request = new ListExecutionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Categories))
            {
                query["Categories"] = request.Categories;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Depth))
            {
                query["Depth"] = request.Depth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateAfter))
            {
                query["EndDateAfter"] = request.EndDateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateBefore))
            {
                query["EndDateBefore"] = request.EndDateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutedBy))
            {
                query["ExecutedBy"] = request.ExecutedBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeChildExecution))
            {
                query["IncludeChildExecution"] = request.IncludeChildExecution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentExecutionId))
            {
                query["ParentExecutionId"] = request.ParentExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                query["RamRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTemplateName))
            {
                query["ResourceTemplateName"] = request.ResourceTemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateAfter))
            {
                query["StartDateAfter"] = request.StartDateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateBefore))
            {
                query["StartDateBefore"] = request.StartDateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries executions. Multiple methods are supported to filter executions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionsResponse
        /// </returns>
        public ListExecutionsResponse ListExecutions(ListExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExecutionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries executions. Multiple methods are supported to filter executions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExecutionsResponse
        /// </returns>
        public async Task<ListExecutionsResponse> ListExecutionsAsync(ListExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExecutionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前阿里云用户已授权在应用管理的托管平台账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGitAccountsResponse
        /// </returns>
        public ListGitAccountsResponse ListGitAccountsWithOptions(ListGitAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGitAccounts",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGitAccountsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前阿里云用户已授权在应用管理的托管平台账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGitAccountsResponse
        /// </returns>
        public async Task<ListGitAccountsResponse> ListGitAccountsWithOptionsAsync(ListGitAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGitAccounts",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGitAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前阿里云用户已授权在应用管理的托管平台账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGitAccountsResponse
        /// </returns>
        public ListGitAccountsResponse ListGitAccounts(ListGitAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGitAccountsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前阿里云用户已授权在应用管理的托管平台账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGitAccountsResponse
        /// </returns>
        public async Task<ListGitAccountsResponse> ListGitAccountsAsync(ListGitAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGitAccountsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定Git仓库的所有分支</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitBranchesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGitBranchesResponse
        /// </returns>
        public ListGitBranchesResponse ListGitBranchesWithOptions(ListGitBranchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGitBranches",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGitBranchesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定Git仓库的所有分支</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitBranchesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGitBranchesResponse
        /// </returns>
        public async Task<ListGitBranchesResponse> ListGitBranchesWithOptionsAsync(ListGitBranchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGitBranches",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGitBranchesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定Git仓库的所有分支</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitBranchesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGitBranchesResponse
        /// </returns>
        public ListGitBranchesResponse ListGitBranches(ListGitBranchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGitBranchesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定Git仓库的所有分支</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitBranchesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGitBranchesResponse
        /// </returns>
        public async Task<ListGitBranchesResponse> ListGitBranchesAsync(ListGitBranchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGitBranchesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取已授权用户的组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitOrganizationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGitOrganizationsResponse
        /// </returns>
        public ListGitOrganizationsResponse ListGitOrganizationsWithOptions(ListGitOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
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
                Action = "ListGitOrganizations",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGitOrganizationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取已授权用户的组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitOrganizationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGitOrganizationsResponse
        /// </returns>
        public async Task<ListGitOrganizationsResponse> ListGitOrganizationsWithOptionsAsync(ListGitOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
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
                Action = "ListGitOrganizations",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGitOrganizationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取已授权用户的组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitOrganizationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGitOrganizationsResponse
        /// </returns>
        public ListGitOrganizationsResponse ListGitOrganizations(ListGitOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGitOrganizationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取已授权用户的组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitOrganizationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGitOrganizationsResponse
        /// </returns>
        public async Task<ListGitOrganizationsResponse> ListGitOrganizationsAsync(ListGitOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGitOrganizationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Git仓库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitRepositoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGitRepositoriesResponse
        /// </returns>
        public ListGitRepositoriesResponse ListGitRepositoriesWithOptions(ListGitRepositoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                query["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
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
                Action = "ListGitRepositories",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGitRepositoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Git仓库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitRepositoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGitRepositoriesResponse
        /// </returns>
        public async Task<ListGitRepositoriesResponse> ListGitRepositoriesWithOptionsAsync(ListGitRepositoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                query["OrgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
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
                Action = "ListGitRepositories",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGitRepositoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Git仓库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitRepositoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGitRepositoriesResponse
        /// </returns>
        public ListGitRepositoriesResponse ListGitRepositories(ListGitRepositoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGitRepositoriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Git仓库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitRepositoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGitRepositoriesResponse
        /// </returns>
        public async Task<ListGitRepositoriesResponse> ListGitRepositoriesAsync(ListGitRepositoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGitRepositoriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取仓库文件与目录信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitRepositoryContentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGitRepositoryContentsResponse
        /// </returns>
        public ListGitRepositoryContentsResponse ListGitRepositoryContentsWithOptions(ListGitRepositoryContentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Branch))
            {
                query["Branch"] = request.Branch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["ContentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGitRepositoryContents",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGitRepositoryContentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取仓库文件与目录信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitRepositoryContentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGitRepositoryContentsResponse
        /// </returns>
        public async Task<ListGitRepositoryContentsResponse> ListGitRepositoryContentsWithOptionsAsync(ListGitRepositoryContentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Branch))
            {
                query["Branch"] = request.Branch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["ContentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                query["OrgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Owner))
            {
                query["Owner"] = request.Owner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoFullName))
            {
                query["RepoFullName"] = request.RepoFullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGitRepositoryContents",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGitRepositoryContentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取仓库文件与目录信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitRepositoryContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGitRepositoryContentsResponse
        /// </returns>
        public ListGitRepositoryContentsResponse ListGitRepositoryContents(ListGitRepositoryContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGitRepositoryContentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取仓库文件与目录信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGitRepositoryContentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGitRepositoryContentsResponse
        /// </returns>
        public async Task<ListGitRepositoryContentsResponse> ListGitRepositoryContentsAsync(ListGitRepositoryContentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGitRepositoryContentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Instance Package States</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancePackageStatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePackageStatesResponse
        /// </returns>
        public ListInstancePackageStatesResponse ListInstancePackageStatesWithOptions(ListInstancePackageStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateNames))
            {
                query["TemplateNames"] = request.TemplateNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstancePackageStates",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancePackageStatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Instance Package States</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancePackageStatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePackageStatesResponse
        /// </returns>
        public async Task<ListInstancePackageStatesResponse> ListInstancePackageStatesWithOptionsAsync(ListInstancePackageStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateNames))
            {
                query["TemplateNames"] = request.TemplateNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstancePackageStates",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancePackageStatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Instance Package States</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancePackageStatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePackageStatesResponse
        /// </returns>
        public ListInstancePackageStatesResponse ListInstancePackageStates(ListInstancePackageStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancePackageStatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>List Instance Package States</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancePackageStatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePackageStatesResponse
        /// </returns>
        public async Task<ListInstancePackageStatesResponse> ListInstancePackageStatesAsync(ListInstancePackageStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancePackageStatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the patches of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancePatchStatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePatchStatesResponse
        /// </returns>
        public ListInstancePatchStatesResponse ListInstancePatchStatesWithOptions(ListInstancePatchStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListInstancePatchStates",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancePatchStatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the patches of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancePatchStatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePatchStatesResponse
        /// </returns>
        public async Task<ListInstancePatchStatesResponse> ListInstancePatchStatesWithOptionsAsync(ListInstancePatchStatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListInstancePatchStates",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancePatchStatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the patches of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancePatchStatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePatchStatesResponse
        /// </returns>
        public ListInstancePatchStatesResponse ListInstancePatchStates(ListInstancePatchStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancePatchStatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the patches of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancePatchStatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePatchStatesResponse
        /// </returns>
        public async Task<ListInstancePatchStatesResponse> ListInstancePatchStatesAsync(ListInstancePatchStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancePatchStatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the patches of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancePatchesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePatchesResponse
        /// </returns>
        public ListInstancePatchesResponse ListInstancePatchesWithOptions(ListInstancePatchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PatchStatuses))
            {
                query["PatchStatuses"] = request.PatchStatuses;
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
                Action = "ListInstancePatches",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancePatchesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the patches of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancePatchesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePatchesResponse
        /// </returns>
        public async Task<ListInstancePatchesResponse> ListInstancePatchesWithOptionsAsync(ListInstancePatchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PatchStatuses))
            {
                query["PatchStatuses"] = request.PatchStatuses;
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
                Action = "ListInstancePatches",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancePatchesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the patches of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancePatchesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePatchesResponse
        /// </returns>
        public ListInstancePatchesResponse ListInstancePatches(ListInstancePatchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancePatchesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the patches of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancePatchesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePatchesResponse
        /// </returns>
        public async Task<ListInstancePatchesResponse> ListInstancePatchesAsync(ListInstancePatchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancePatchesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an Elastic Compute Service (ECS) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInventoryEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInventoryEntriesResponse
        /// </returns>
        public ListInventoryEntriesResponse ListInventoryEntriesWithOptions(ListInventoryEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeName))
            {
                query["TypeName"] = request.TypeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInventoryEntries",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInventoryEntriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an Elastic Compute Service (ECS) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInventoryEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInventoryEntriesResponse
        /// </returns>
        public async Task<ListInventoryEntriesResponse> ListInventoryEntriesWithOptionsAsync(ListInventoryEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeName))
            {
                query["TypeName"] = request.TypeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInventoryEntries",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInventoryEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an Elastic Compute Service (ECS) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInventoryEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInventoryEntriesResponse
        /// </returns>
        public ListInventoryEntriesResponse ListInventoryEntries(ListInventoryEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInventoryEntriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an Elastic Compute Service (ECS) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInventoryEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInventoryEntriesResponse
        /// </returns>
        public async Task<ListInventoryEntriesResponse> ListInventoryEntriesAsync(ListInventoryEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInventoryEntriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries O\&amp;M items.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListOpsItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOpsItemsResponse
        /// </returns>
        public ListOpsItemsResponse ListOpsItemsWithOptions(ListOpsItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListOpsItemsShrinkRequest request = new ListOpsItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTags))
            {
                request.ResourceTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTags, "ResourceTags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTagsShrink))
            {
                query["ResourceTags"] = request.ResourceTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOpsItems",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOpsItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries O\&amp;M items.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListOpsItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOpsItemsResponse
        /// </returns>
        public async Task<ListOpsItemsResponse> ListOpsItemsWithOptionsAsync(ListOpsItemsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListOpsItemsShrinkRequest request = new ListOpsItemsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTags))
            {
                request.ResourceTagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTags, "ResourceTags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTagsShrink))
            {
                query["ResourceTags"] = request.ResourceTagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOpsItems",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOpsItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries O\&amp;M items.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpsItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOpsItemsResponse
        /// </returns>
        public ListOpsItemsResponse ListOpsItems(ListOpsItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOpsItemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries O\&amp;M items.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpsItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOpsItemsResponse
        /// </returns>
        public async Task<ListOpsItemsResponse> ListOpsItemsAsync(ListOpsItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOpsItemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParameterVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListParameterVersionsResponse
        /// </returns>
        public ListParameterVersionsResponse ListParameterVersionsWithOptions(ListParameterVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListParameterVersions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParameterVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParameterVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListParameterVersionsResponse
        /// </returns>
        public async Task<ListParameterVersionsResponse> ListParameterVersionsWithOptionsAsync(ListParameterVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListParameterVersions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParameterVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParameterVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListParameterVersionsResponse
        /// </returns>
        public ListParameterVersionsResponse ListParameterVersions(ListParameterVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListParameterVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParameterVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListParameterVersionsResponse
        /// </returns>
        public async Task<ListParameterVersionsResponse> ListParameterVersionsAsync(ListParameterVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListParameterVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries common parameters. Multiple methods are supported to filter common parameters.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListParametersResponse
        /// </returns>
        public ListParametersResponse ListParametersWithOptions(ListParametersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListParametersShrinkRequest request = new ListParametersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recursive))
            {
                query["Recursive"] = request.Recursive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListParameters",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParametersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries common parameters. Multiple methods are supported to filter common parameters.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListParametersResponse
        /// </returns>
        public async Task<ListParametersResponse> ListParametersWithOptionsAsync(ListParametersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListParametersShrinkRequest request = new ListParametersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recursive))
            {
                query["Recursive"] = request.Recursive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListParameters",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParametersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries common parameters. Multiple methods are supported to filter common parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListParametersResponse
        /// </returns>
        public ListParametersResponse ListParameters(ListParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListParametersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries common parameters. Multiple methods are supported to filter common parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListParametersResponse
        /// </returns>
        public async Task<ListParametersResponse> ListParametersAsync(ListParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListParametersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of patch baselines.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListPatchBaselinesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPatchBaselinesResponse
        /// </returns>
        public ListPatchBaselinesResponse ListPatchBaselinesWithOptions(ListPatchBaselinesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPatchBaselinesShrinkRequest request = new ListPatchBaselinesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApprovedPatches))
            {
                request.ApprovedPatchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApprovedPatches, "ApprovedPatches", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedPatchesShrink))
            {
                query["ApprovedPatches"] = request.ApprovedPatchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedPatchesEnableNonSecurity))
            {
                query["ApprovedPatchesEnableNonSecurity"] = request.ApprovedPatchesEnableNonSecurity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationSystem))
            {
                query["OperationSystem"] = request.OperationSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPatchBaselines",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPatchBaselinesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of patch baselines.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListPatchBaselinesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPatchBaselinesResponse
        /// </returns>
        public async Task<ListPatchBaselinesResponse> ListPatchBaselinesWithOptionsAsync(ListPatchBaselinesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPatchBaselinesShrinkRequest request = new ListPatchBaselinesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApprovedPatches))
            {
                request.ApprovedPatchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApprovedPatches, "ApprovedPatches", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedPatchesShrink))
            {
                query["ApprovedPatches"] = request.ApprovedPatchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedPatchesEnableNonSecurity))
            {
                query["ApprovedPatchesEnableNonSecurity"] = request.ApprovedPatchesEnableNonSecurity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationSystem))
            {
                query["OperationSystem"] = request.OperationSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPatchBaselines",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPatchBaselinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of patch baselines.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPatchBaselinesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPatchBaselinesResponse
        /// </returns>
        public ListPatchBaselinesResponse ListPatchBaselines(ListPatchBaselinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPatchBaselinesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of patch baselines.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPatchBaselinesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPatchBaselinesResponse
        /// </returns>
        public async Task<ListPatchBaselinesResponse> ListPatchBaselinesAsync(ListPatchBaselinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPatchBaselinesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a scheduled execution that involves O&amp;M operations on Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceExecutionStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceExecutionStatusResponse
        /// </returns>
        public ListResourceExecutionStatusResponse ListResourceExecutionStatusWithOptions(ListResourceExecutionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListResourceExecutionStatus",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceExecutionStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a scheduled execution that involves O&amp;M operations on Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceExecutionStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceExecutionStatusResponse
        /// </returns>
        public async Task<ListResourceExecutionStatusResponse> ListResourceExecutionStatusWithOptionsAsync(ListResourceExecutionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListResourceExecutionStatus",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceExecutionStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a scheduled execution that involves O&amp;M operations on Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceExecutionStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceExecutionStatusResponse
        /// </returns>
        public ListResourceExecutionStatusResponse ListResourceExecutionStatus(ListResourceExecutionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceExecutionStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a scheduled execution that involves O&amp;M operations on Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceExecutionStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceExecutionStatusResponse
        /// </returns>
        public async Task<ListResourceExecutionStatusResponse> ListResourceExecutionStatusAsync(ListResourceExecutionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceExecutionStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries versions of an encryption parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecretParameterVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecretParameterVersionsResponse
        /// </returns>
        public ListSecretParameterVersionsResponse ListSecretParameterVersionsWithOptions(ListSecretParameterVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDecryption))
            {
                query["WithDecryption"] = request.WithDecryption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecretParameterVersions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecretParameterVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries versions of an encryption parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecretParameterVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecretParameterVersionsResponse
        /// </returns>
        public async Task<ListSecretParameterVersionsResponse> ListSecretParameterVersionsWithOptionsAsync(ListSecretParameterVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDecryption))
            {
                query["WithDecryption"] = request.WithDecryption;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecretParameterVersions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecretParameterVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries versions of an encryption parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecretParameterVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecretParameterVersionsResponse
        /// </returns>
        public ListSecretParameterVersionsResponse ListSecretParameterVersions(ListSecretParameterVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecretParameterVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries versions of an encryption parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecretParameterVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecretParameterVersionsResponse
        /// </returns>
        public async Task<ListSecretParameterVersionsResponse> ListSecretParameterVersionsAsync(ListSecretParameterVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecretParameterVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries common parameters. Multiple types of queries are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you have the permission to manage Key Management Service (KMS) secrets.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListSecretParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecretParametersResponse
        /// </returns>
        public ListSecretParametersResponse ListSecretParametersWithOptions(ListSecretParametersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSecretParametersShrinkRequest request = new ListSecretParametersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recursive))
            {
                query["Recursive"] = request.Recursive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecretParameters",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecretParametersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries common parameters. Multiple types of queries are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you have the permission to manage Key Management Service (KMS) secrets.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListSecretParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecretParametersResponse
        /// </returns>
        public async Task<ListSecretParametersResponse> ListSecretParametersWithOptionsAsync(ListSecretParametersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSecretParametersShrinkRequest request = new ListSecretParametersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recursive))
            {
                query["Recursive"] = request.Recursive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecretParameters",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecretParametersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries common parameters. Multiple types of queries are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you have the permission to manage Key Management Service (KMS) secrets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecretParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecretParametersResponse
        /// </returns>
        public ListSecretParametersResponse ListSecretParameters(ListSecretParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecretParametersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries common parameters. Multiple types of queries are supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you have the permission to manage Key Management Service (KMS) secrets.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecretParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecretParametersResponse
        /// </returns>
        public async Task<ListSecretParametersResponse> ListSecretParametersAsync(ListSecretParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecretParametersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries desired-state configurations.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListStateConfigurationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStateConfigurationsResponse
        /// </returns>
        public ListStateConfigurationsResponse ListStateConfigurationsWithOptions(ListStateConfigurationsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListStateConfigurationsShrinkRequest request = new ListStateConfigurationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateConfigurationIds))
            {
                query["StateConfigurationIds"] = request.StateConfigurationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStateConfigurations",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStateConfigurationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries desired-state configurations.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListStateConfigurationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStateConfigurationsResponse
        /// </returns>
        public async Task<ListStateConfigurationsResponse> ListStateConfigurationsWithOptionsAsync(ListStateConfigurationsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListStateConfigurationsShrinkRequest request = new ListStateConfigurationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateConfigurationIds))
            {
                query["StateConfigurationIds"] = request.StateConfigurationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStateConfigurations",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStateConfigurationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries desired-state configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStateConfigurationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStateConfigurationsResponse
        /// </returns>
        public ListStateConfigurationsResponse ListStateConfigurations(ListStateConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStateConfigurationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries desired-state configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStateConfigurationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStateConfigurationsResponse
        /// </returns>
        public async Task<ListStateConfigurationsResponse> ListStateConfigurationsAsync(ListStateConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStateConfigurationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagKeys",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagKeysResponse
        /// </returns>
        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to one or more resources.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["ResourceIds"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to one or more resources.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["ResourceIds"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to one or more resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to one or more resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the values of created tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public ListTagValuesResponse ListTagValuesWithOptions(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagValuesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the values of created tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public async Task<ListTagValuesResponse> ListTagValuesWithOptionsAsync(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagValuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the values of created tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public ListTagValuesResponse ListTagValues(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagValuesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the values of created tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagValuesResponse
        /// </returns>
        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagValuesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries task executions. Multiple methods are supported to filter task executions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTaskExecutionsResponse
        /// </returns>
        public ListTaskExecutionsResponse ListTaskExecutionsWithOptions(ListTaskExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateAfter))
            {
                query["EndDateAfter"] = request.EndDateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateBefore))
            {
                query["EndDateBefore"] = request.EndDateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeChildTaskExecution))
            {
                query["IncludeChildTaskExecution"] = request.IncludeChildTaskExecution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentTaskExecutionId))
            {
                query["ParentTaskExecutionId"] = request.ParentTaskExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateAfter))
            {
                query["StartDateAfter"] = request.StartDateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateBefore))
            {
                query["StartDateBefore"] = request.StartDateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskAction))
            {
                query["TaskAction"] = request.TaskAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutionId))
            {
                query["TaskExecutionId"] = request.TaskExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTaskExecutions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaskExecutionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries task executions. Multiple methods are supported to filter task executions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTaskExecutionsResponse
        /// </returns>
        public async Task<ListTaskExecutionsResponse> ListTaskExecutionsWithOptionsAsync(ListTaskExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateAfter))
            {
                query["EndDateAfter"] = request.EndDateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateBefore))
            {
                query["EndDateBefore"] = request.EndDateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeChildTaskExecution))
            {
                query["IncludeChildTaskExecution"] = request.IncludeChildTaskExecution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentTaskExecutionId))
            {
                query["ParentTaskExecutionId"] = request.ParentTaskExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateAfter))
            {
                query["StartDateAfter"] = request.StartDateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateBefore))
            {
                query["StartDateBefore"] = request.StartDateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskAction))
            {
                query["TaskAction"] = request.TaskAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutionId))
            {
                query["TaskExecutionId"] = request.TaskExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTaskExecutions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaskExecutionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries task executions. Multiple methods are supported to filter task executions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTaskExecutionsResponse
        /// </returns>
        public ListTaskExecutionsResponse ListTaskExecutions(ListTaskExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTaskExecutionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries task executions. Multiple methods are supported to filter task executions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTaskExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTaskExecutionsResponse
        /// </returns>
        public async Task<ListTaskExecutionsResponse> ListTaskExecutionsAsync(ListTaskExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTaskExecutionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of versions of a template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateVersionsResponse
        /// </returns>
        public ListTemplateVersionsResponse ListTemplateVersionsWithOptions(ListTemplateVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplateVersions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of versions of a template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateVersionsResponse
        /// </returns>
        public async Task<ListTemplateVersionsResponse> ListTemplateVersionsWithOptionsAsync(ListTemplateVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplateVersions",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplateVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of versions of a template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateVersionsResponse
        /// </returns>
        public ListTemplateVersionsResponse ListTemplateVersions(ListTemplateVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplateVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of versions of a template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplateVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplateVersionsResponse
        /// </returns>
        public async Task<ListTemplateVersionsResponse> ListTemplateVersionsAsync(ListTemplateVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplateVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries templates. Multiple methods are supported to filter templates.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTemplatesShrinkRequest request = new ListTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedBy))
            {
                query["CreatedBy"] = request.CreatedBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedDateAfter))
            {
                query["CreatedDateAfter"] = request.CreatedDateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedDateBefore))
            {
                query["CreatedDateBefore"] = request.CreatedDateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasTrigger))
            {
                query["HasTrigger"] = request.HasTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsExample))
            {
                query["IsExample"] = request.IsExample;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsFavorite))
            {
                query["IsFavorite"] = request.IsFavorite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateFormat))
            {
                query["TemplateFormat"] = request.TemplateFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2019-06-01",
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
        /// <para>Queries templates. Multiple methods are supported to filter templates.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTemplatesShrinkRequest request = new ListTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedBy))
            {
                query["CreatedBy"] = request.CreatedBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedDateAfter))
            {
                query["CreatedDateAfter"] = request.CreatedDateAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedDateBefore))
            {
                query["CreatedDateBefore"] = request.CreatedDateBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasTrigger))
            {
                query["HasTrigger"] = request.HasTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsExample))
            {
                query["IsExample"] = request.IsExample;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsFavorite))
            {
                query["IsFavorite"] = request.IsFavorite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareType))
            {
                query["ShareType"] = request.ShareType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateFormat))
            {
                query["TemplateFormat"] = request.TemplateFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2019-06-01",
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
        /// <para>Queries templates. Multiple methods are supported to filter templates.</para>
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
        /// <para>Queries templates. Multiple methods are supported to filter templates.</para>
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
        /// <para>Notifies an execution in the Waiting state of the subsequent operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to notify an execution in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>If a template contains a special task, such as an approval task, the Operation Orchestration Service (OOS) execution engine sets the execution state to Waiting when the approval task is being run. You can call this operation to specify whether to continue the execution.</description></item>
        /// <item><description>If you perform debugging in the debug mode, you can call this operation to notify the execution of the subsequent operations after the execution is created or a task is complete.</description></item>
        /// <item><description>If a high-risk operation task waits for approval, you can call this operation to specify whether to continue the execution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// NotifyExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NotifyExecutionResponse
        /// </returns>
        public NotifyExecutionResponse NotifyExecutionWithOptions(NotifyExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionStatus))
            {
                query["ExecutionStatus"] = request.ExecutionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoopItem))
            {
                query["LoopItem"] = request.LoopItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyNote))
            {
                query["NotifyNote"] = request.NotifyNote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                query["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutionId))
            {
                query["TaskExecutionId"] = request.TaskExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutionIds))
            {
                query["TaskExecutionIds"] = request.TaskExecutionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NotifyExecution",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Notifies an execution in the Waiting state of the subsequent operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to notify an execution in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>If a template contains a special task, such as an approval task, the Operation Orchestration Service (OOS) execution engine sets the execution state to Waiting when the approval task is being run. You can call this operation to specify whether to continue the execution.</description></item>
        /// <item><description>If you perform debugging in the debug mode, you can call this operation to notify the execution of the subsequent operations after the execution is created or a task is complete.</description></item>
        /// <item><description>If a high-risk operation task waits for approval, you can call this operation to specify whether to continue the execution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// NotifyExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NotifyExecutionResponse
        /// </returns>
        public async Task<NotifyExecutionResponse> NotifyExecutionWithOptionsAsync(NotifyExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionStatus))
            {
                query["ExecutionStatus"] = request.ExecutionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoopItem))
            {
                query["LoopItem"] = request.LoopItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyNote))
            {
                query["NotifyNote"] = request.NotifyNote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                query["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutionId))
            {
                query["TaskExecutionId"] = request.TaskExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskExecutionIds))
            {
                query["TaskExecutionIds"] = request.TaskExecutionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "NotifyExecution",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Notifies an execution in the Waiting state of the subsequent operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to notify an execution in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>If a template contains a special task, such as an approval task, the Operation Orchestration Service (OOS) execution engine sets the execution state to Waiting when the approval task is being run. You can call this operation to specify whether to continue the execution.</description></item>
        /// <item><description>If you perform debugging in the debug mode, you can call this operation to notify the execution of the subsequent operations after the execution is created or a task is complete.</description></item>
        /// <item><description>If a high-risk operation task waits for approval, you can call this operation to specify whether to continue the execution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// NotifyExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// NotifyExecutionResponse
        /// </returns>
        public NotifyExecutionResponse NotifyExecution(NotifyExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return NotifyExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Notifies an execution in the Waiting state of the subsequent operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to notify an execution in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>If a template contains a special task, such as an approval task, the Operation Orchestration Service (OOS) execution engine sets the execution state to Waiting when the approval task is being run. You can call this operation to specify whether to continue the execution.</description></item>
        /// <item><description>If you perform debugging in the debug mode, you can call this operation to notify the execution of the subsequent operations after the execution is created or a task is complete.</description></item>
        /// <item><description>If a high-risk operation task waits for approval, you can call this operation to specify whether to continue the execution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// NotifyExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// NotifyExecutionResponse
        /// </returns>
        public async Task<NotifyExecutionResponse> NotifyExecutionAsync(NotifyExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await NotifyExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers the default patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterDefaultPatchBaselineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterDefaultPatchBaselineResponse
        /// </returns>
        public RegisterDefaultPatchBaselineResponse RegisterDefaultPatchBaselineWithOptions(RegisterDefaultPatchBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "RegisterDefaultPatchBaseline",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDefaultPatchBaselineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers the default patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterDefaultPatchBaselineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterDefaultPatchBaselineResponse
        /// </returns>
        public async Task<RegisterDefaultPatchBaselineResponse> RegisterDefaultPatchBaselineWithOptionsAsync(RegisterDefaultPatchBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "RegisterDefaultPatchBaseline",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDefaultPatchBaselineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers the default patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterDefaultPatchBaselineRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterDefaultPatchBaselineResponse
        /// </returns>
        public RegisterDefaultPatchBaselineResponse RegisterDefaultPatchBaseline(RegisterDefaultPatchBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterDefaultPatchBaselineWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers the default patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterDefaultPatchBaselineRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterDefaultPatchBaselineResponse
        /// </returns>
        public async Task<RegisterDefaultPatchBaselineResponse> RegisterDefaultPatchBaselineAsync(RegisterDefaultPatchBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterDefaultPatchBaselineWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details or aggregate information of a configuration inventory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchInventoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchInventoryResponse
        /// </returns>
        public SearchInventoryResponse SearchInventoryWithOptions(SearchInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregator))
            {
                query["Aggregator"] = request.Aggregator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "SearchInventory",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchInventoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details or aggregate information of a configuration inventory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchInventoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchInventoryResponse
        /// </returns>
        public async Task<SearchInventoryResponse> SearchInventoryWithOptionsAsync(SearchInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregator))
            {
                query["Aggregator"] = request.Aggregator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "SearchInventory",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchInventoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details or aggregate information of a configuration inventory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchInventoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchInventoryResponse
        /// </returns>
        public SearchInventoryResponse SearchInventory(SearchInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchInventoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details or aggregate information of a configuration inventory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchInventoryRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchInventoryResponse
        /// </returns>
        public async Task<SearchInventoryResponse> SearchInventoryAsync(SearchInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchInventoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the feature of delivering template execution records and sets the storage location.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetServiceSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetServiceSettingsResponse
        /// </returns>
        public SetServiceSettingsResponse SetServiceSettingsWithOptions(SetServiceSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryOssBucketName))
            {
                query["DeliveryOssBucketName"] = request.DeliveryOssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryOssEnabled))
            {
                query["DeliveryOssEnabled"] = request.DeliveryOssEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryOssKeyPrefix))
            {
                query["DeliveryOssKeyPrefix"] = request.DeliveryOssKeyPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverySlsEnabled))
            {
                query["DeliverySlsEnabled"] = request.DeliverySlsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverySlsProjectName))
            {
                query["DeliverySlsProjectName"] = request.DeliverySlsProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdcEnterpriseId))
            {
                query["RdcEnterpriseId"] = request.RdcEnterpriseId;
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
                Action = "SetServiceSettings",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetServiceSettingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the feature of delivering template execution records and sets the storage location.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetServiceSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetServiceSettingsResponse
        /// </returns>
        public async Task<SetServiceSettingsResponse> SetServiceSettingsWithOptionsAsync(SetServiceSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryOssBucketName))
            {
                query["DeliveryOssBucketName"] = request.DeliveryOssBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryOssEnabled))
            {
                query["DeliveryOssEnabled"] = request.DeliveryOssEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryOssKeyPrefix))
            {
                query["DeliveryOssKeyPrefix"] = request.DeliveryOssKeyPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverySlsEnabled))
            {
                query["DeliverySlsEnabled"] = request.DeliverySlsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverySlsProjectName))
            {
                query["DeliverySlsProjectName"] = request.DeliverySlsProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdcEnterpriseId))
            {
                query["RdcEnterpriseId"] = request.RdcEnterpriseId;
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
                Action = "SetServiceSettings",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetServiceSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the feature of delivering template execution records and sets the storage location.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetServiceSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// SetServiceSettingsResponse
        /// </returns>
        public SetServiceSettingsResponse SetServiceSettings(SetServiceSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetServiceSettingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables the feature of delivering template execution records and sets the storage location.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetServiceSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// SetServiceSettingsResponse
        /// </returns>
        public async Task<SetServiceSettingsResponse> SetServiceSettingsAsync(SetServiceSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetServiceSettingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an execution.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StartExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartExecutionResponse
        /// </returns>
        public StartExecutionResponse StartExecutionWithOptions(StartExecutionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartExecutionShrinkRequest request = new StartExecutionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoopMode))
            {
                query["LoopMode"] = request.LoopMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentExecutionId))
            {
                query["ParentExecutionId"] = request.ParentExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SafetyCheck))
            {
                query["SafetyCheck"] = request.SafetyCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartExecution",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an execution.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StartExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartExecutionResponse
        /// </returns>
        public async Task<StartExecutionResponse> StartExecutionWithOptionsAsync(StartExecutionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartExecutionShrinkRequest request = new StartExecutionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoopMode))
            {
                query["LoopMode"] = request.LoopMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentExecutionId))
            {
                query["ParentExecutionId"] = request.ParentExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SafetyCheck))
            {
                query["SafetyCheck"] = request.SafetyCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateContent))
            {
                query["TemplateContent"] = request.TemplateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartExecution",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartExecutionResponse
        /// </returns>
        public StartExecutionResponse StartExecution(StartExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartExecutionResponse
        /// </returns>
        public async Task<StartExecutionResponse> StartExecutionAsync(StartExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to one or more resources.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TagResourcesShrinkRequest request = new TagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["ResourceIds"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to one or more resources.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TagResourcesShrinkRequest request = new TagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["ResourceIds"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to one or more resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to one or more resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Debugs a started execution that contains an event trigger task or alert trigger task. If the operation is called, a message body is sent to the event trigger task or alert trigger task. After the trigger task receives the message body, the trigger task generates a new child execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TriggerExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TriggerExecutionResponse
        /// </returns>
        public TriggerExecutionResponse TriggerExecutionWithOptions(TriggerExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerExecution",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Debugs a started execution that contains an event trigger task or alert trigger task. If the operation is called, a message body is sent to the event trigger task or alert trigger task. After the trigger task receives the message body, the trigger task generates a new child execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TriggerExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TriggerExecutionResponse
        /// </returns>
        public async Task<TriggerExecutionResponse> TriggerExecutionWithOptionsAsync(TriggerExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerExecution",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Debugs a started execution that contains an event trigger task or alert trigger task. If the operation is called, a message body is sent to the event trigger task or alert trigger task. After the trigger task receives the message body, the trigger task generates a new child execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TriggerExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// TriggerExecutionResponse
        /// </returns>
        public TriggerExecutionResponse TriggerExecution(TriggerExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Debugs a started execution that contains an event trigger task or alert trigger task. If the operation is called, a message body is sent to the event trigger task or alert trigger task. After the trigger task receives the message body, the trigger task generates a new child execution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TriggerExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// TriggerExecutionResponse
        /// </returns>
        public async Task<TriggerExecutionResponse> TriggerExecutionAsync(TriggerExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from one or more resources.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKeys))
            {
                request.TagKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKeys, "TagKeys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["ResourceIds"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeysShrink))
            {
                query["TagKeys"] = request.TagKeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from one or more resources.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKeys))
            {
                request.TagKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKeys, "TagKeys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["ResourceIds"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeysShrink))
            {
                query["TagKeys"] = request.TagKeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from one or more resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from one or more resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationResponse
        /// </returns>
        public UpdateApplicationResponse UpdateApplicationWithOptions(UpdateApplicationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateApplicationShrinkRequest request = new UpdateApplicationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlarmConfig))
            {
                request.AlarmConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlarmConfig, "AlarmConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmConfigShrink))
            {
                query["AlarmConfig"] = request.AlarmConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAlarmRulesBeforeUpdate))
            {
                query["DeleteAlarmRulesBeforeUpdate"] = request.DeleteAlarmRulesBeforeUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplication",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationResponse
        /// </returns>
        public async Task<UpdateApplicationResponse> UpdateApplicationWithOptionsAsync(UpdateApplicationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateApplicationShrinkRequest request = new UpdateApplicationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlarmConfig))
            {
                request.AlarmConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlarmConfig, "AlarmConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmConfigShrink))
            {
                query["AlarmConfig"] = request.AlarmConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAlarmRulesBeforeUpdate))
            {
                query["DeleteAlarmRulesBeforeUpdate"] = request.DeleteAlarmRulesBeforeUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplication",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationResponse
        /// </returns>
        public UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an application. You can call this operation only for the applications that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationResponse
        /// </returns>
        public async Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of an application group. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateApplicationGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationGroupResponse
        /// </returns>
        public UpdateApplicationGroupResponse UpdateApplicationGroupWithOptions(UpdateApplicationGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateApplicationGroupShrinkRequest request = new UpdateApplicationGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployedRevisionId))
            {
                query["DeployedRevisionId"] = request.DeployedRevisionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewName))
            {
                query["NewName"] = request.NewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationName))
            {
                query["OperationName"] = request.OperationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
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
                Action = "UpdateApplicationGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of an application group. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateApplicationGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationGroupResponse
        /// </returns>
        public async Task<UpdateApplicationGroupResponse> UpdateApplicationGroupWithOptionsAsync(UpdateApplicationGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateApplicationGroupShrinkRequest request = new UpdateApplicationGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployedRevisionId))
            {
                query["DeployedRevisionId"] = request.DeployedRevisionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewName))
            {
                query["NewName"] = request.NewName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationName))
            {
                query["OperationName"] = request.OperationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
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
                Action = "UpdateApplicationGroup",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of an application group. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationGroupResponse
        /// </returns>
        public UpdateApplicationGroupResponse UpdateApplicationGroup(UpdateApplicationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApplicationGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of an application group. You can call this operation only for the application groups that reside in the China (Hangzhou) region. Use an endpoint of the China (Hangzhou) region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationGroupResponse
        /// </returns>
        public async Task<UpdateApplicationGroupResponse> UpdateApplicationGroupAsync(UpdateApplicationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApplicationGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update executions that are in Running or Waiting status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExecutionResponse
        /// </returns>
        public UpdateExecutionResponse UpdateExecutionWithOptions(UpdateExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExecution",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update executions that are in Running or Waiting status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExecutionResponse
        /// </returns>
        public async Task<UpdateExecutionResponse> UpdateExecutionWithOptionsAsync(UpdateExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionId))
            {
                query["ExecutionId"] = request.ExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExecution",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update executions that are in Running or Waiting status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExecutionResponse
        /// </returns>
        public UpdateExecutionResponse UpdateExecution(UpdateExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update executions that are in Running or Waiting status.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExecutionResponse
        /// </returns>
        public async Task<UpdateExecutionResponse> UpdateExecutionAsync(UpdateExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the installed extensions of an instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateInstancePackageStateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstancePackageStateResponse
        /// </returns>
        public UpdateInstancePackageStateResponse UpdateInstancePackageStateWithOptions(UpdateInstancePackageStateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateInstancePackageStateShrinkRequest request = new UpdateInstancePackageStateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationInfo))
            {
                query["ConfigurationInfo"] = request.ConfigurationInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigureAction))
            {
                query["ConfigureAction"] = request.ConfigureAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstancePackageState",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstancePackageStateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the installed extensions of an instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateInstancePackageStateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstancePackageStateResponse
        /// </returns>
        public async Task<UpdateInstancePackageStateResponse> UpdateInstancePackageStateWithOptionsAsync(UpdateInstancePackageStateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateInstancePackageStateShrinkRequest request = new UpdateInstancePackageStateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationInfo))
            {
                query["ConfigurationInfo"] = request.ConfigurationInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigureAction))
            {
                query["ConfigureAction"] = request.ConfigureAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateVersion))
            {
                query["TemplateVersion"] = request.TemplateVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstancePackageState",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstancePackageStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the installed extensions of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstancePackageStateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstancePackageStateResponse
        /// </returns>
        public UpdateInstancePackageStateResponse UpdateInstancePackageState(UpdateInstancePackageStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstancePackageStateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the installed extensions of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstancePackageStateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstancePackageStateResponse
        /// </returns>
        public async Task<UpdateInstancePackageStateResponse> UpdateInstancePackageStateAsync(UpdateInstancePackageStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstancePackageStateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an O\\\\\\&amp;M item.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateOpsItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOpsItemResponse
        /// </returns>
        public UpdateOpsItemResponse UpdateOpsItemWithOptions(UpdateOpsItemRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateOpsItemShrinkRequest request = new UpdateOpsItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedupString))
            {
                query["DedupString"] = request.DedupString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsItemId))
            {
                query["OpsItemId"] = request.OpsItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solutions))
            {
                query["Solutions"] = request.Solutions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOpsItem",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOpsItemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an O\\\\\\&amp;M item.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateOpsItemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOpsItemResponse
        /// </returns>
        public async Task<UpdateOpsItemResponse> UpdateOpsItemWithOptionsAsync(UpdateOpsItemRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateOpsItemShrinkRequest request = new UpdateOpsItemShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DedupString))
            {
                query["DedupString"] = request.DedupString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsItemId))
            {
                query["OpsItemId"] = request.OpsItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solutions))
            {
                query["Solutions"] = request.Solutions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOpsItem",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOpsItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an O\\\\\\&amp;M item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOpsItemRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOpsItemResponse
        /// </returns>
        public UpdateOpsItemResponse UpdateOpsItem(UpdateOpsItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOpsItemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an O\\\\\\&amp;M item.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOpsItemRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOpsItemResponse
        /// </returns>
        public async Task<UpdateOpsItemResponse> UpdateOpsItemAsync(UpdateOpsItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOpsItemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateParameterResponse
        /// </returns>
        public UpdateParameterResponse UpdateParameterWithOptions(UpdateParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateParameterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateParameterResponse
        /// </returns>
        public async Task<UpdateParameterResponse> UpdateParameterWithOptionsAsync(UpdateParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateParameterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateParameterResponse
        /// </returns>
        public UpdateParameterResponse UpdateParameter(UpdateParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateParameterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a common parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateParameterResponse
        /// </returns>
        public async Task<UpdateParameterResponse> UpdateParameterAsync(UpdateParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateParameterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePatchBaselineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePatchBaselineResponse
        /// </returns>
        public UpdatePatchBaselineResponse UpdatePatchBaselineWithOptions(UpdatePatchBaselineRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePatchBaselineShrinkRequest request = new UpdatePatchBaselineShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApprovedPatches))
            {
                request.ApprovedPatchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApprovedPatches, "ApprovedPatches", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RejectedPatches))
            {
                request.RejectedPatchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RejectedPatches, "RejectedPatches", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalRules))
            {
                query["ApprovalRules"] = request.ApprovalRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedPatchesShrink))
            {
                query["ApprovedPatches"] = request.ApprovedPatchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedPatchesEnableNonSecurity))
            {
                query["ApprovedPatchesEnableNonSecurity"] = request.ApprovedPatchesEnableNonSecurity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RejectedPatchesShrink))
            {
                query["RejectedPatches"] = request.RejectedPatchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RejectedPatchesAction))
            {
                query["RejectedPatchesAction"] = request.RejectedPatchesAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePatchBaseline",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePatchBaselineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePatchBaselineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePatchBaselineResponse
        /// </returns>
        public async Task<UpdatePatchBaselineResponse> UpdatePatchBaselineWithOptionsAsync(UpdatePatchBaselineRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePatchBaselineShrinkRequest request = new UpdatePatchBaselineShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApprovedPatches))
            {
                request.ApprovedPatchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApprovedPatches, "ApprovedPatches", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RejectedPatches))
            {
                request.RejectedPatchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RejectedPatches, "RejectedPatches", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalRules))
            {
                query["ApprovalRules"] = request.ApprovalRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedPatchesShrink))
            {
                query["ApprovedPatches"] = request.ApprovedPatchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovedPatchesEnableNonSecurity))
            {
                query["ApprovedPatchesEnableNonSecurity"] = request.ApprovedPatchesEnableNonSecurity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RejectedPatchesShrink))
            {
                query["RejectedPatches"] = request.RejectedPatchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RejectedPatchesAction))
            {
                query["RejectedPatchesAction"] = request.RejectedPatchesAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePatchBaseline",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePatchBaselineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePatchBaselineRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePatchBaselineResponse
        /// </returns>
        public UpdatePatchBaselineResponse UpdatePatchBaseline(UpdatePatchBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePatchBaselineWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a patch baseline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePatchBaselineRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePatchBaselineResponse
        /// </returns>
        public async Task<UpdatePatchBaselineResponse> UpdatePatchBaselineAsync(UpdatePatchBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePatchBaselineWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an encryption parameter.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSecretParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretParameterResponse
        /// </returns>
        public UpdateSecretParameterResponse UpdateSecretParameterWithOptions(UpdateSecretParameterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSecretParameterShrinkRequest request = new UpdateSecretParameterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecretParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSecretParameterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an encryption parameter.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSecretParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretParameterResponse
        /// </returns>
        public async Task<UpdateSecretParameterResponse> UpdateSecretParameterWithOptionsAsync(UpdateSecretParameterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSecretParameterShrinkRequest request = new UpdateSecretParameterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecretParameter",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSecretParameterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an encryption parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSecretParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretParameterResponse
        /// </returns>
        public UpdateSecretParameterResponse UpdateSecretParameter(UpdateSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSecretParameterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an encryption parameter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSecretParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretParameterResponse
        /// </returns>
        public async Task<UpdateSecretParameterResponse> UpdateSecretParameterAsync(UpdateSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSecretParameterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a desired-state configuration.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateStateConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStateConfigurationResponse
        /// </returns>
        public UpdateStateConfigurationResponse UpdateStateConfigurationWithOptions(UpdateStateConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStateConfigurationShrinkRequest request = new UpdateStateConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigureMode))
            {
                query["ConfigureMode"] = request.ConfigureMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleExpression))
            {
                query["ScheduleExpression"] = request.ScheduleExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                query["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateConfigurationId))
            {
                query["StateConfigurationId"] = request.StateConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStateConfiguration",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStateConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a desired-state configuration.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateStateConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateStateConfigurationResponse
        /// </returns>
        public async Task<UpdateStateConfigurationResponse> UpdateStateConfigurationWithOptionsAsync(UpdateStateConfigurationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStateConfigurationShrinkRequest request = new UpdateStateConfigurationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigureMode))
            {
                query["ConfigureMode"] = request.ConfigureMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleExpression))
            {
                query["ScheduleExpression"] = request.ScheduleExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                query["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateConfigurationId))
            {
                query["StateConfigurationId"] = request.StateConfigurationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStateConfiguration",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStateConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a desired-state configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateStateConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStateConfigurationResponse
        /// </returns>
        public UpdateStateConfigurationResponse UpdateStateConfiguration(UpdateStateConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStateConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a desired-state configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateStateConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateStateConfigurationResponse
        /// </returns>
        public async Task<UpdateStateConfigurationResponse> UpdateStateConfigurationAsync(UpdateStateConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStateConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about an existing template.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2019-06-01",
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
        /// <para>Updates the information about an existing template.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2019-06-01",
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
        /// <para>Updates the information about an existing template.</para>
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
        /// <para>Updates the information about an existing template.</para>
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
        /// <para>Check whether a template is valid.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateTemplateContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateTemplateContentResponse
        /// </returns>
        public ValidateTemplateContentResponse ValidateTemplateContentWithOptions(ValidateTemplateContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateTemplateContent",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateTemplateContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check whether a template is valid.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateTemplateContentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateTemplateContentResponse
        /// </returns>
        public async Task<ValidateTemplateContentResponse> ValidateTemplateContentWithOptionsAsync(ValidateTemplateContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateURL))
            {
                query["TemplateURL"] = request.TemplateURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateTemplateContent",
                Version = "2019-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateTemplateContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check whether a template is valid.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateTemplateContentRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateTemplateContentResponse
        /// </returns>
        public ValidateTemplateContentResponse ValidateTemplateContent(ValidateTemplateContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateTemplateContentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Check whether a template is valid.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateTemplateContentRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateTemplateContentResponse
        /// </returns>
        public async Task<ValidateTemplateContentResponse> ValidateTemplateContentAsync(ValidateTemplateContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateTemplateContentWithOptionsAsync(request, runtime);
        }

    }
}
