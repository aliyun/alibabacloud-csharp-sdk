// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cr20181201.Models;

namespace AlibabaCloud.SDK.Cr20181201
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cr", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Cancels an artifact building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelArtifactBuildTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelArtifactBuildTaskResponse
        /// </returns>
        public CancelArtifactBuildTaskResponse CancelArtifactBuildTaskWithOptions(CancelArtifactBuildTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildTaskId))
            {
                query["BuildTaskId"] = request.BuildTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelArtifactBuildTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelArtifactBuildTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an artifact building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelArtifactBuildTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelArtifactBuildTaskResponse
        /// </returns>
        public async Task<CancelArtifactBuildTaskResponse> CancelArtifactBuildTaskWithOptionsAsync(CancelArtifactBuildTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildTaskId))
            {
                query["BuildTaskId"] = request.BuildTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelArtifactBuildTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelArtifactBuildTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an artifact building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelArtifactBuildTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelArtifactBuildTaskResponse
        /// </returns>
        public CancelArtifactBuildTaskResponse CancelArtifactBuildTask(CancelArtifactBuildTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelArtifactBuildTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an artifact building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelArtifactBuildTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelArtifactBuildTaskResponse
        /// </returns>
        public async Task<CancelArtifactBuildTaskResponse> CancelArtifactBuildTaskAsync(CancelArtifactBuildTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelArtifactBuildTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an image building task of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRepoBuildRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRepoBuildRecordResponse
        /// </returns>
        public CancelRepoBuildRecordResponse CancelRepoBuildRecordWithOptions(CancelRepoBuildRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRecordId))
            {
                query["BuildRecordId"] = request.BuildRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "CancelRepoBuildRecord",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRepoBuildRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an image building task of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRepoBuildRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRepoBuildRecordResponse
        /// </returns>
        public async Task<CancelRepoBuildRecordResponse> CancelRepoBuildRecordWithOptionsAsync(CancelRepoBuildRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRecordId))
            {
                query["BuildRecordId"] = request.BuildRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "CancelRepoBuildRecord",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRepoBuildRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an image building task of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRepoBuildRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelRepoBuildRecordResponse
        /// </returns>
        public CancelRepoBuildRecordResponse CancelRepoBuildRecord(CancelRepoBuildRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelRepoBuildRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an image building task of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRepoBuildRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelRepoBuildRecordResponse
        /// </returns>
        public async Task<CancelRepoBuildRecordResponse> CancelRepoBuildRecordAsync(CancelRepoBuildRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelRepoBuildRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a single replication task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRepoSyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRepoSyncTaskResponse
        /// </returns>
        public CancelRepoSyncTaskResponse CancelRepoSyncTaskWithOptions(CancelRepoSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncTaskId))
            {
                query["SyncTaskId"] = request.SyncTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRepoSyncTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRepoSyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a single replication task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRepoSyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRepoSyncTaskResponse
        /// </returns>
        public async Task<CancelRepoSyncTaskResponse> CancelRepoSyncTaskWithOptionsAsync(CancelRepoSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncTaskId))
            {
                query["SyncTaskId"] = request.SyncTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRepoSyncTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRepoSyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a single replication task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRepoSyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelRepoSyncTaskResponse
        /// </returns>
        public CancelRepoSyncTaskResponse CancelRepoSyncTask(CancelRepoSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelRepoSyncTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a single replication task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRepoSyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelRepoSyncTaskResponse
        /// </returns>
        public async Task<CancelRepoSyncTaskResponse> CancelRepoSyncTaskAsync(CancelRepoSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelRepoSyncTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which a resource belongs.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2018-12-01",
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
        /// <para>Changes the resource group to which a resource belongs.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2018-12-01",
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
        /// <para>Changes the resource group to which a resource belongs.</para>
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
        /// <para>Changes the resource group to which a resource belongs.</para>
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
        /// <para>Create image repository acceleration rules for image building.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create building rules of accelerated images only for image repositories of Container Registry Advanced Edition instances. You cannot create building rules of accelerated images for image repositories of Container Registry Basic Edition instances. For more information, see <a href="https://www.alibabacloud.com/help/en/acr/product-overview/what-is-container-registry?spm=openapi-amp.newDocPublishment.0.0.bf82281fRj7rmV#section-n3q-ps7-x6k">Specifications of different editions</a>.
        /// Accelerated images are not supported in Alibaba Finance Cloud regions or Alibaba Gov Cloud regions.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateArtifactBuildRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactBuildRuleResponse
        /// </returns>
        public CreateArtifactBuildRuleResponse CreateArtifactBuildRuleWithOptions(CreateArtifactBuildRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateArtifactBuildRuleShrinkRequest request = new CreateArtifactBuildRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactType))
            {
                query["ArtifactType"] = request.ArtifactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeId))
            {
                query["ScopeId"] = request.ScopeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["ScopeType"] = request.ScopeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArtifactBuildRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateArtifactBuildRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create image repository acceleration rules for image building.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create building rules of accelerated images only for image repositories of Container Registry Advanced Edition instances. You cannot create building rules of accelerated images for image repositories of Container Registry Basic Edition instances. For more information, see <a href="https://www.alibabacloud.com/help/en/acr/product-overview/what-is-container-registry?spm=openapi-amp.newDocPublishment.0.0.bf82281fRj7rmV#section-n3q-ps7-x6k">Specifications of different editions</a>.
        /// Accelerated images are not supported in Alibaba Finance Cloud regions or Alibaba Gov Cloud regions.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateArtifactBuildRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactBuildRuleResponse
        /// </returns>
        public async Task<CreateArtifactBuildRuleResponse> CreateArtifactBuildRuleWithOptionsAsync(CreateArtifactBuildRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateArtifactBuildRuleShrinkRequest request = new CreateArtifactBuildRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArtifactType))
            {
                query["ArtifactType"] = request.ArtifactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeId))
            {
                query["ScopeId"] = request.ScopeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeType))
            {
                query["ScopeType"] = request.ScopeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArtifactBuildRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateArtifactBuildRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create image repository acceleration rules for image building.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create building rules of accelerated images only for image repositories of Container Registry Advanced Edition instances. You cannot create building rules of accelerated images for image repositories of Container Registry Basic Edition instances. For more information, see <a href="https://www.alibabacloud.com/help/en/acr/product-overview/what-is-container-registry?spm=openapi-amp.newDocPublishment.0.0.bf82281fRj7rmV#section-n3q-ps7-x6k">Specifications of different editions</a>.
        /// Accelerated images are not supported in Alibaba Finance Cloud regions or Alibaba Gov Cloud regions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateArtifactBuildRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactBuildRuleResponse
        /// </returns>
        public CreateArtifactBuildRuleResponse CreateArtifactBuildRule(CreateArtifactBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateArtifactBuildRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create image repository acceleration rules for image building.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create building rules of accelerated images only for image repositories of Container Registry Advanced Edition instances. You cannot create building rules of accelerated images for image repositories of Container Registry Basic Edition instances. For more information, see <a href="https://www.alibabacloud.com/help/en/acr/product-overview/what-is-container-registry?spm=openapi-amp.newDocPublishment.0.0.bf82281fRj7rmV#section-n3q-ps7-x6k">Specifications of different editions</a>.
        /// Accelerated images are not supported in Alibaba Finance Cloud regions or Alibaba Gov Cloud regions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateArtifactBuildRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactBuildRuleResponse
        /// </returns>
        public async Task<CreateArtifactBuildRuleResponse> CreateArtifactBuildRuleAsync(CreateArtifactBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateArtifactBuildRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a lifecycle management rule for an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactLifecycleRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactLifecycleRuleResponse
        /// </returns>
        public CreateArtifactLifecycleRuleResponse CreateArtifactLifecycleRuleWithOptions(CreateArtifactLifecycleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Auto))
            {
                query["Auto"] = request.Auto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDeleteTag))
            {
                query["EnableDeleteTag"] = request.EnableDeleteTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionTagCount))
            {
                query["RetentionTagCount"] = request.RetentionTagCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["ScheduleTime"] = request.ScheduleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRegexp))
            {
                query["TagRegexp"] = request.TagRegexp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArtifactLifecycleRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateArtifactLifecycleRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a lifecycle management rule for an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactLifecycleRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactLifecycleRuleResponse
        /// </returns>
        public async Task<CreateArtifactLifecycleRuleResponse> CreateArtifactLifecycleRuleWithOptionsAsync(CreateArtifactLifecycleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Auto))
            {
                query["Auto"] = request.Auto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDeleteTag))
            {
                query["EnableDeleteTag"] = request.EnableDeleteTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionTagCount))
            {
                query["RetentionTagCount"] = request.RetentionTagCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["ScheduleTime"] = request.ScheduleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRegexp))
            {
                query["TagRegexp"] = request.TagRegexp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArtifactLifecycleRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateArtifactLifecycleRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a lifecycle management rule for an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactLifecycleRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactLifecycleRuleResponse
        /// </returns>
        public CreateArtifactLifecycleRuleResponse CreateArtifactLifecycleRule(CreateArtifactLifecycleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateArtifactLifecycleRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a lifecycle management rule for an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactLifecycleRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactLifecycleRuleResponse
        /// </returns>
        public async Task<CreateArtifactLifecycleRuleResponse> CreateArtifactLifecycleRuleAsync(CreateArtifactLifecycleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateArtifactLifecycleRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactSubscriptionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactSubscriptionRuleResponse
        /// </returns>
        public CreateArtifactSubscriptionRuleResponse CreateArtifactSubscriptionRuleWithOptions(CreateArtifactSubscriptionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accelerate))
            {
                query["Accelerate"] = request.Accelerate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Override))
            {
                query["Override"] = request.Override;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceNamespaceName))
            {
                query["SourceNamespaceName"] = request.SourceNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProvider))
            {
                query["SourceProvider"] = request.SourceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRepoName))
            {
                query["SourceRepoName"] = request.SourceRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCount))
            {
                query["TagCount"] = request.TagCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRegexp))
            {
                query["TagRegexp"] = request.TagRegexp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArtifactSubscriptionRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateArtifactSubscriptionRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactSubscriptionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactSubscriptionRuleResponse
        /// </returns>
        public async Task<CreateArtifactSubscriptionRuleResponse> CreateArtifactSubscriptionRuleWithOptionsAsync(CreateArtifactSubscriptionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accelerate))
            {
                query["Accelerate"] = request.Accelerate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Override))
            {
                query["Override"] = request.Override;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceNamespaceName))
            {
                query["SourceNamespaceName"] = request.SourceNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProvider))
            {
                query["SourceProvider"] = request.SourceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRepoName))
            {
                query["SourceRepoName"] = request.SourceRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCount))
            {
                query["TagCount"] = request.TagCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRegexp))
            {
                query["TagRegexp"] = request.TagRegexp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArtifactSubscriptionRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateArtifactSubscriptionRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactSubscriptionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactSubscriptionRuleResponse
        /// </returns>
        public CreateArtifactSubscriptionRuleResponse CreateArtifactSubscriptionRule(CreateArtifactSubscriptionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateArtifactSubscriptionRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactSubscriptionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactSubscriptionRuleResponse
        /// </returns>
        public async Task<CreateArtifactSubscriptionRuleResponse> CreateArtifactSubscriptionRuleAsync(CreateArtifactSubscriptionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateArtifactSubscriptionRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an artifact subscription task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactSubscriptionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactSubscriptionTaskResponse
        /// </returns>
        public CreateArtifactSubscriptionTaskResponse CreateArtifactSubscriptionTaskWithOptions(CreateArtifactSubscriptionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArtifactSubscriptionTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateArtifactSubscriptionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an artifact subscription task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactSubscriptionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactSubscriptionTaskResponse
        /// </returns>
        public async Task<CreateArtifactSubscriptionTaskResponse> CreateArtifactSubscriptionTaskWithOptionsAsync(CreateArtifactSubscriptionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArtifactSubscriptionTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateArtifactSubscriptionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an artifact subscription task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactSubscriptionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactSubscriptionTaskResponse
        /// </returns>
        public CreateArtifactSubscriptionTaskResponse CreateArtifactSubscriptionTask(CreateArtifactSubscriptionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateArtifactSubscriptionTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an artifact subscription task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactSubscriptionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactSubscriptionTaskResponse
        /// </returns>
        public async Task<CreateArtifactSubscriptionTaskResponse> CreateArtifactSubscriptionTaskAsync(CreateArtifactSubscriptionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateArtifactSubscriptionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image building record based on an existing record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBuildRecordByRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBuildRecordByRecordResponse
        /// </returns>
        public CreateBuildRecordByRecordResponse CreateBuildRecordByRecordWithOptions(CreateBuildRecordByRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRecordId))
            {
                query["BuildRecordId"] = request.BuildRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "CreateBuildRecordByRecord",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBuildRecordByRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image building record based on an existing record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBuildRecordByRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBuildRecordByRecordResponse
        /// </returns>
        public async Task<CreateBuildRecordByRecordResponse> CreateBuildRecordByRecordWithOptionsAsync(CreateBuildRecordByRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRecordId))
            {
                query["BuildRecordId"] = request.BuildRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "CreateBuildRecordByRecord",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBuildRecordByRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image building record based on an existing record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBuildRecordByRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBuildRecordByRecordResponse
        /// </returns>
        public CreateBuildRecordByRecordResponse CreateBuildRecordByRecord(CreateBuildRecordByRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBuildRecordByRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image building record based on an existing record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBuildRecordByRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBuildRecordByRecordResponse
        /// </returns>
        public async Task<CreateBuildRecordByRecordResponse> CreateBuildRecordByRecordAsync(CreateBuildRecordByRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBuildRecordByRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image building record based on a rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBuildRecordByRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBuildRecordByRuleResponse
        /// </returns>
        public CreateBuildRecordByRuleResponse CreateBuildRecordByRuleWithOptions(CreateBuildRecordByRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRuleId))
            {
                query["BuildRuleId"] = request.BuildRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "CreateBuildRecordByRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBuildRecordByRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image building record based on a rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBuildRecordByRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBuildRecordByRuleResponse
        /// </returns>
        public async Task<CreateBuildRecordByRuleResponse> CreateBuildRecordByRuleWithOptionsAsync(CreateBuildRecordByRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRuleId))
            {
                query["BuildRuleId"] = request.BuildRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "CreateBuildRecordByRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBuildRecordByRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image building record based on a rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBuildRecordByRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBuildRecordByRuleResponse
        /// </returns>
        public CreateBuildRecordByRuleResponse CreateBuildRecordByRule(CreateBuildRecordByRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBuildRecordByRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image building record based on a rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBuildRecordByRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBuildRecordByRuleResponse
        /// </returns>
        public async Task<CreateBuildRecordByRuleResponse> CreateBuildRecordByRuleAsync(CreateBuildRecordByRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBuildRecordByRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a delivery chain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChainResponse
        /// </returns>
        public CreateChainResponse CreateChainWithOptions(CreateChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainConfig))
            {
                query["ChainConfig"] = request.ChainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeExclude))
            {
                query["ScopeExclude"] = request.ScopeExclude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChain",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a delivery chain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChainResponse
        /// </returns>
        public async Task<CreateChainResponse> CreateChainWithOptionsAsync(CreateChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainConfig))
            {
                query["ChainConfig"] = request.ChainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeExclude))
            {
                query["ScopeExclude"] = request.ScopeExclude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChain",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a delivery chain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChainRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChainResponse
        /// </returns>
        public CreateChainResponse CreateChain(CreateChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateChainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a delivery chain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChainRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChainResponse
        /// </returns>
        public async Task<CreateChainResponse> CreateChainAsync(CreateChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateChainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a chart namespace in an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChartNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChartNamespaceResponse
        /// </returns>
        public CreateChartNamespaceResponse CreateChartNamespaceWithOptions(CreateChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateRepo))
            {
                query["AutoCreateRepo"] = request.AutoCreateRepo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRepoType))
            {
                query["DefaultRepoType"] = request.DefaultRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChartNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChartNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a chart namespace in an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChartNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChartNamespaceResponse
        /// </returns>
        public async Task<CreateChartNamespaceResponse> CreateChartNamespaceWithOptionsAsync(CreateChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateRepo))
            {
                query["AutoCreateRepo"] = request.AutoCreateRepo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRepoType))
            {
                query["DefaultRepoType"] = request.DefaultRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChartNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChartNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a chart namespace in an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChartNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChartNamespaceResponse
        /// </returns>
        public CreateChartNamespaceResponse CreateChartNamespace(CreateChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateChartNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a chart namespace in an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChartNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChartNamespaceResponse
        /// </returns>
        public async Task<CreateChartNamespaceResponse> CreateChartNamespaceAsync(CreateChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateChartNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChartRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChartRepositoryResponse
        /// </returns>
        public CreateChartRepositoryResponse CreateChartRepositoryWithOptions(CreateChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoType))
            {
                query["RepoType"] = request.RepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                query["Summary"] = request.Summary;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChartRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChartRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChartRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChartRepositoryResponse
        /// </returns>
        public async Task<CreateChartRepositoryResponse> CreateChartRepositoryWithOptionsAsync(CreateChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoType))
            {
                query["RepoType"] = request.RepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                query["Summary"] = request.Summary;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChartRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChartRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChartRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChartRepositoryResponse
        /// </returns>
        public CreateChartRepositoryResponse CreateChartRepository(CreateChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateChartRepositoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChartRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChartRepositoryResponse
        /// </returns>
        public async Task<CreateChartRepositoryResponse> CreateChartRepositoryAsync(CreateChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateChartRepositoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a whitelist policy for the public endpoint of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceEndpointAclPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceEndpointAclPolicyResponse
        /// </returns>
        public CreateInstanceEndpointAclPolicyResponse CreateInstanceEndpointAclPolicyWithOptions(CreateInstanceEndpointAclPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointType))
            {
                query["EndpointType"] = request.EndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Entry))
            {
                query["Entry"] = request.Entry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceEndpointAclPolicy",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceEndpointAclPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a whitelist policy for the public endpoint of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceEndpointAclPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceEndpointAclPolicyResponse
        /// </returns>
        public async Task<CreateInstanceEndpointAclPolicyResponse> CreateInstanceEndpointAclPolicyWithOptionsAsync(CreateInstanceEndpointAclPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointType))
            {
                query["EndpointType"] = request.EndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Entry))
            {
                query["Entry"] = request.Entry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceEndpointAclPolicy",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceEndpointAclPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a whitelist policy for the public endpoint of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceEndpointAclPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceEndpointAclPolicyResponse
        /// </returns>
        public CreateInstanceEndpointAclPolicyResponse CreateInstanceEndpointAclPolicy(CreateInstanceEndpointAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceEndpointAclPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a whitelist policy for the public endpoint of the instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceEndpointAclPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceEndpointAclPolicyResponse
        /// </returns>
        public async Task<CreateInstanceEndpointAclPolicyResponse> CreateInstanceEndpointAclPolicyAsync(CreateInstanceEndpointAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceEndpointAclPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates a virtual private cloud (VPC) with a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The VPC quota must be purchased separately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceVpcEndpointLinkedVpcRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceVpcEndpointLinkedVpcResponse
        /// </returns>
        public CreateInstanceVpcEndpointLinkedVpcResponse CreateInstanceVpcEndpointLinkedVpcWithOptions(CreateInstanceVpcEndpointLinkedVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCreateDNSRecordInPvzt))
            {
                query["EnableCreateDNSRecordInPvzt"] = request.EnableCreateDNSRecordInPvzt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchId))
            {
                query["VswitchId"] = request.VswitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceVpcEndpointLinkedVpc",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceVpcEndpointLinkedVpcResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates a virtual private cloud (VPC) with a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The VPC quota must be purchased separately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceVpcEndpointLinkedVpcRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceVpcEndpointLinkedVpcResponse
        /// </returns>
        public async Task<CreateInstanceVpcEndpointLinkedVpcResponse> CreateInstanceVpcEndpointLinkedVpcWithOptionsAsync(CreateInstanceVpcEndpointLinkedVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCreateDNSRecordInPvzt))
            {
                query["EnableCreateDNSRecordInPvzt"] = request.EnableCreateDNSRecordInPvzt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchId))
            {
                query["VswitchId"] = request.VswitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceVpcEndpointLinkedVpc",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceVpcEndpointLinkedVpcResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates a virtual private cloud (VPC) with a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The VPC quota must be purchased separately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceVpcEndpointLinkedVpcRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceVpcEndpointLinkedVpcResponse
        /// </returns>
        public CreateInstanceVpcEndpointLinkedVpcResponse CreateInstanceVpcEndpointLinkedVpc(CreateInstanceVpcEndpointLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceVpcEndpointLinkedVpcWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates a virtual private cloud (VPC) with a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The VPC quota must be purchased separately.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceVpcEndpointLinkedVpcRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceVpcEndpointLinkedVpcResponse
        /// </returns>
        public async Task<CreateInstanceVpcEndpointLinkedVpcResponse> CreateInstanceVpcEndpointLinkedVpcAsync(CreateInstanceVpcEndpointLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceVpcEndpointLinkedVpcWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a namespace of image repositories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public CreateNamespaceResponse CreateNamespaceWithOptions(CreateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateRepo))
            {
                query["AutoCreateRepo"] = request.AutoCreateRepo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRepoType))
            {
                query["DefaultRepoType"] = request.DefaultRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a namespace of image repositories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public async Task<CreateNamespaceResponse> CreateNamespaceWithOptionsAsync(CreateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateRepo))
            {
                query["AutoCreateRepo"] = request.AutoCreateRepo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRepoType))
            {
                query["DefaultRepoType"] = request.DefaultRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a namespace of image repositories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a namespace of image repositories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image building rule for a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoBuildRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoBuildRuleResponse
        /// </returns>
        public CreateRepoBuildRuleResponse CreateRepoBuildRuleWithOptions(CreateRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildArgs))
            {
                query["BuildArgs"] = request.BuildArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DockerfileLocation))
            {
                query["DockerfileLocation"] = request.DockerfileLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DockerfileName))
            {
                query["DockerfileName"] = request.DockerfileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTag))
            {
                query["ImageTag"] = request.ImageTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platforms))
            {
                query["Platforms"] = request.Platforms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushName))
            {
                query["PushName"] = request.PushName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
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
                Action = "CreateRepoBuildRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoBuildRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image building rule for a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoBuildRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoBuildRuleResponse
        /// </returns>
        public async Task<CreateRepoBuildRuleResponse> CreateRepoBuildRuleWithOptionsAsync(CreateRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildArgs))
            {
                query["BuildArgs"] = request.BuildArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DockerfileLocation))
            {
                query["DockerfileLocation"] = request.DockerfileLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DockerfileName))
            {
                query["DockerfileName"] = request.DockerfileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTag))
            {
                query["ImageTag"] = request.ImageTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platforms))
            {
                query["Platforms"] = request.Platforms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushName))
            {
                query["PushName"] = request.PushName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
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
                Action = "CreateRepoBuildRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoBuildRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image building rule for a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoBuildRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoBuildRuleResponse
        /// </returns>
        public CreateRepoBuildRuleResponse CreateRepoBuildRule(CreateRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoBuildRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image building rule for a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoBuildRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoBuildRuleResponse
        /// </returns>
        public async Task<CreateRepoBuildRuleResponse> CreateRepoBuildRuleAsync(CreateRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoBuildRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a source code repository to an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoSourceCodeRepoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSourceCodeRepoResponse
        /// </returns>
        public CreateRepoSourceCodeRepoResponse CreateRepoSourceCodeRepoWithOptions(CreateRepoSourceCodeRepoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoBuild))
            {
                query["AutoBuild"] = request.AutoBuild;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoName))
            {
                query["CodeRepoName"] = request.CodeRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoNamespaceName))
            {
                query["CodeRepoNamespaceName"] = request.CodeRepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoType))
            {
                query["CodeRepoType"] = request.CodeRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableCacheBuild))
            {
                query["DisableCacheBuild"] = request.DisableCacheBuild;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverseaBuild))
            {
                query["OverseaBuild"] = request.OverseaBuild;
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
                Action = "CreateRepoSourceCodeRepo",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoSourceCodeRepoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a source code repository to an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoSourceCodeRepoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSourceCodeRepoResponse
        /// </returns>
        public async Task<CreateRepoSourceCodeRepoResponse> CreateRepoSourceCodeRepoWithOptionsAsync(CreateRepoSourceCodeRepoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoBuild))
            {
                query["AutoBuild"] = request.AutoBuild;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoName))
            {
                query["CodeRepoName"] = request.CodeRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoNamespaceName))
            {
                query["CodeRepoNamespaceName"] = request.CodeRepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoType))
            {
                query["CodeRepoType"] = request.CodeRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableCacheBuild))
            {
                query["DisableCacheBuild"] = request.DisableCacheBuild;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverseaBuild))
            {
                query["OverseaBuild"] = request.OverseaBuild;
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
                Action = "CreateRepoSourceCodeRepo",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoSourceCodeRepoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a source code repository to an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoSourceCodeRepoRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSourceCodeRepoResponse
        /// </returns>
        public CreateRepoSourceCodeRepoResponse CreateRepoSourceCodeRepo(CreateRepoSourceCodeRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoSourceCodeRepoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a source code repository to an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoSourceCodeRepoRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSourceCodeRepoResponse
        /// </returns>
        public async Task<CreateRepoSourceCodeRepoResponse> CreateRepoSourceCodeRepoAsync(CreateRepoSourceCodeRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoSourceCodeRepoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image synchronization rule for an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoSyncRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSyncRuleResponse
        /// </returns>
        public CreateRepoSyncRuleResponse CreateRepoSyncRuleWithOptions(CreateRepoSyncRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNameFilter))
            {
                query["RepoNameFilter"] = request.RepoNameFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncRuleName))
            {
                query["SyncRuleName"] = request.SyncRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncScope))
            {
                query["SyncScope"] = request.SyncScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncTrigger))
            {
                query["SyncTrigger"] = request.SyncTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilter))
            {
                query["TagFilter"] = request.TagFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                query["TargetInstanceId"] = request.TargetInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetNamespaceName))
            {
                query["TargetNamespaceName"] = request.TargetNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRegionId))
            {
                query["TargetRegionId"] = request.TargetRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRepoName))
            {
                query["TargetRepoName"] = request.TargetRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepoSyncRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoSyncRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image synchronization rule for an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoSyncRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSyncRuleResponse
        /// </returns>
        public async Task<CreateRepoSyncRuleResponse> CreateRepoSyncRuleWithOptionsAsync(CreateRepoSyncRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNameFilter))
            {
                query["RepoNameFilter"] = request.RepoNameFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncRuleName))
            {
                query["SyncRuleName"] = request.SyncRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncScope))
            {
                query["SyncScope"] = request.SyncScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncTrigger))
            {
                query["SyncTrigger"] = request.SyncTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagFilter))
            {
                query["TagFilter"] = request.TagFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                query["TargetInstanceId"] = request.TargetInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetNamespaceName))
            {
                query["TargetNamespaceName"] = request.TargetNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRegionId))
            {
                query["TargetRegionId"] = request.TargetRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRepoName))
            {
                query["TargetRepoName"] = request.TargetRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepoSyncRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoSyncRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image synchronization rule for an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoSyncRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSyncRuleResponse
        /// </returns>
        public CreateRepoSyncRuleResponse CreateRepoSyncRule(CreateRepoSyncRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoSyncRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image synchronization rule for an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoSyncRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSyncRuleResponse
        /// </returns>
        public async Task<CreateRepoSyncRuleResponse> CreateRepoSyncRuleAsync(CreateRepoSyncRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoSyncRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateRepoSyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSyncTaskResponse
        /// </returns>
        public CreateRepoSyncTaskResponse CreateRepoSyncTaskWithOptions(CreateRepoSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Override))
            {
                query["Override"] = request.Override;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                query["TargetInstanceId"] = request.TargetInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetNamespace))
            {
                query["TargetNamespace"] = request.TargetNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRegionId))
            {
                query["TargetRegionId"] = request.TargetRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRepoName))
            {
                query["TargetRepoName"] = request.TargetRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetTag))
            {
                query["TargetTag"] = request.TargetTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepoSyncTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoSyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateRepoSyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSyncTaskResponse
        /// </returns>
        public async Task<CreateRepoSyncTaskResponse> CreateRepoSyncTaskWithOptionsAsync(CreateRepoSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Override))
            {
                query["Override"] = request.Override;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                query["TargetInstanceId"] = request.TargetInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetNamespace))
            {
                query["TargetNamespace"] = request.TargetNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRegionId))
            {
                query["TargetRegionId"] = request.TargetRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRepoName))
            {
                query["TargetRepoName"] = request.TargetRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetTag))
            {
                query["TargetTag"] = request.TargetTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepoSyncTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoSyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateRepoSyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSyncTaskResponse
        /// </returns>
        public CreateRepoSyncTaskResponse CreateRepoSyncTask(CreateRepoSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoSyncTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateRepoSyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSyncTaskResponse
        /// </returns>
        public async Task<CreateRepoSyncTaskResponse> CreateRepoSyncTaskAsync(CreateRepoSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoSyncTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image replication task based on a manual replication rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoSyncTaskByRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSyncTaskByRuleResponse
        /// </returns>
        public CreateRepoSyncTaskByRuleResponse CreateRepoSyncTaskByRuleWithOptions(CreateRepoSyncTaskByRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncRuleId))
            {
                query["SyncRuleId"] = request.SyncRuleId;
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
                Action = "CreateRepoSyncTaskByRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoSyncTaskByRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image replication task based on a manual replication rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoSyncTaskByRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSyncTaskByRuleResponse
        /// </returns>
        public async Task<CreateRepoSyncTaskByRuleResponse> CreateRepoSyncTaskByRuleWithOptionsAsync(CreateRepoSyncTaskByRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncRuleId))
            {
                query["SyncRuleId"] = request.SyncRuleId;
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
                Action = "CreateRepoSyncTaskByRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoSyncTaskByRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image replication task based on a manual replication rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoSyncTaskByRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSyncTaskByRuleResponse
        /// </returns>
        public CreateRepoSyncTaskByRuleResponse CreateRepoSyncTaskByRule(CreateRepoSyncTaskByRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoSyncTaskByRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image replication task based on a manual replication rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoSyncTaskByRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoSyncTaskByRuleResponse
        /// </returns>
        public async Task<CreateRepoSyncTaskByRuleResponse> CreateRepoSyncTaskByRuleAsync(CreateRepoSyncTaskByRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoSyncTaskByRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image tag based on an existing image tag in an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoTagResponse
        /// </returns>
        public CreateRepoTagResponse CreateRepoTagWithOptions(CreateRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTag))
            {
                query["FromTag"] = request.FromTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTag))
            {
                query["ToTag"] = request.ToTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepoTag",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image tag based on an existing image tag in an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoTagResponse
        /// </returns>
        public async Task<CreateRepoTagResponse> CreateRepoTagWithOptionsAsync(CreateRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromTag))
            {
                query["FromTag"] = request.FromTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToTag))
            {
                query["ToTag"] = request.ToTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepoTag",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image tag based on an existing image tag in an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoTagRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoTagResponse
        /// </returns>
        public CreateRepoTagResponse CreateRepoTag(CreateRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image tag based on an existing image tag in an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoTagRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoTagResponse
        /// </returns>
        public async Task<CreateRepoTagResponse> CreateRepoTagAsync(CreateRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoTagWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateRepoTagScanTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoTagScanTaskResponse
        /// </returns>
        public CreateRepoTagScanTaskResponse CreateRepoTagScanTaskWithOptions(CreateRepoTagScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanService))
            {
                query["ScanService"] = request.ScanService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanType))
            {
                query["ScanType"] = request.ScanType;
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
                Action = "CreateRepoTagScanTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoTagScanTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateRepoTagScanTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoTagScanTaskResponse
        /// </returns>
        public async Task<CreateRepoTagScanTaskResponse> CreateRepoTagScanTaskWithOptionsAsync(CreateRepoTagScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanService))
            {
                query["ScanService"] = request.ScanService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanType))
            {
                query["ScanType"] = request.ScanType;
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
                Action = "CreateRepoTagScanTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoTagScanTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateRepoTagScanTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoTagScanTaskResponse
        /// </returns>
        public CreateRepoTagScanTaskResponse CreateRepoTagScanTask(CreateRepoTagScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoTagScanTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateRepoTagScanTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoTagScanTaskResponse
        /// </returns>
        public async Task<CreateRepoTagScanTaskResponse> CreateRepoTagScanTaskAsync(CreateRepoTagScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoTagScanTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trigger for a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoTriggerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoTriggerResponse
        /// </returns>
        public CreateRepoTriggerResponse CreateRepoTriggerWithOptions(CreateRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerName))
            {
                query["TriggerName"] = request.TriggerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerTag))
            {
                query["TriggerTag"] = request.TriggerTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                query["TriggerType"] = request.TriggerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerUrl))
            {
                query["TriggerUrl"] = request.TriggerUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepoTrigger",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoTriggerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trigger for a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoTriggerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoTriggerResponse
        /// </returns>
        public async Task<CreateRepoTriggerResponse> CreateRepoTriggerWithOptionsAsync(CreateRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerName))
            {
                query["TriggerName"] = request.TriggerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerTag))
            {
                query["TriggerTag"] = request.TriggerTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                query["TriggerType"] = request.TriggerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerUrl))
            {
                query["TriggerUrl"] = request.TriggerUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepoTrigger",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepoTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trigger for a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoTriggerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoTriggerResponse
        /// </returns>
        public CreateRepoTriggerResponse CreateRepoTrigger(CreateRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoTriggerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a trigger for a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepoTriggerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepoTriggerResponse
        /// </returns>
        public async Task<CreateRepoTriggerResponse> CreateRepoTriggerAsync(CreateRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoTriggerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepositoryResponse
        /// </returns>
        public CreateRepositoryResponse CreateRepositoryWithOptions(CreateRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                query["Detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoType))
            {
                query["RepoType"] = request.RepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                query["Summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagImmutability))
            {
                query["TagImmutability"] = request.TagImmutability;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRepositoryResponse
        /// </returns>
        public async Task<CreateRepositoryResponse> CreateRepositoryWithOptionsAsync(CreateRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                query["Detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoType))
            {
                query["RepoType"] = request.RepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                query["Summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagImmutability))
            {
                query["TagImmutability"] = request.TagImmutability;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepositoryResponse
        /// </returns>
        public CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepositoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRepositoryResponse
        /// </returns>
        public async Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepositoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an artifact lifecycle management rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteArtifactLifecycleRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteArtifactLifecycleRuleResponse
        /// </returns>
        public DeleteArtifactLifecycleRuleResponse DeleteArtifactLifecycleRuleWithOptions(DeleteArtifactLifecycleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteArtifactLifecycleRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteArtifactLifecycleRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an artifact lifecycle management rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteArtifactLifecycleRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteArtifactLifecycleRuleResponse
        /// </returns>
        public async Task<DeleteArtifactLifecycleRuleResponse> DeleteArtifactLifecycleRuleWithOptionsAsync(DeleteArtifactLifecycleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteArtifactLifecycleRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteArtifactLifecycleRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an artifact lifecycle management rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteArtifactLifecycleRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteArtifactLifecycleRuleResponse
        /// </returns>
        public DeleteArtifactLifecycleRuleResponse DeleteArtifactLifecycleRule(DeleteArtifactLifecycleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteArtifactLifecycleRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an artifact lifecycle management rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteArtifactLifecycleRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteArtifactLifecycleRuleResponse
        /// </returns>
        public async Task<DeleteArtifactLifecycleRuleResponse> DeleteArtifactLifecycleRuleAsync(DeleteArtifactLifecycleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteArtifactLifecycleRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteArtifactSubscriptionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteArtifactSubscriptionRuleResponse
        /// </returns>
        public DeleteArtifactSubscriptionRuleResponse DeleteArtifactSubscriptionRuleWithOptions(DeleteArtifactSubscriptionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteArtifactSubscriptionRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteArtifactSubscriptionRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteArtifactSubscriptionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteArtifactSubscriptionRuleResponse
        /// </returns>
        public async Task<DeleteArtifactSubscriptionRuleResponse> DeleteArtifactSubscriptionRuleWithOptionsAsync(DeleteArtifactSubscriptionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteArtifactSubscriptionRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteArtifactSubscriptionRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteArtifactSubscriptionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteArtifactSubscriptionRuleResponse
        /// </returns>
        public DeleteArtifactSubscriptionRuleResponse DeleteArtifactSubscriptionRule(DeleteArtifactSubscriptionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteArtifactSubscriptionRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteArtifactSubscriptionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteArtifactSubscriptionRuleResponse
        /// </returns>
        public async Task<DeleteArtifactSubscriptionRuleResponse> DeleteArtifactSubscriptionRuleAsync(DeleteArtifactSubscriptionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteArtifactSubscriptionRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a delivery pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChainResponse
        /// </returns>
        public DeleteChainResponse DeleteChainWithOptions(DeleteChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainId))
            {
                query["ChainId"] = request.ChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChain",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a delivery pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChainResponse
        /// </returns>
        public async Task<DeleteChainResponse> DeleteChainWithOptionsAsync(DeleteChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainId))
            {
                query["ChainId"] = request.ChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChain",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a delivery pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChainRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChainResponse
        /// </returns>
        public DeleteChainResponse DeleteChain(DeleteChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a delivery pipeline.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChainRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChainResponse
        /// </returns>
        public async Task<DeleteChainResponse> DeleteChainAsync(DeleteChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a chart namespace from an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If you delete a chart namespace, all repositories in the namespace and the charts in all repositories are deleted.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteChartNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChartNamespaceResponse
        /// </returns>
        public DeleteChartNamespaceResponse DeleteChartNamespaceWithOptions(DeleteChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChartNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChartNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a chart namespace from an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If you delete a chart namespace, all repositories in the namespace and the charts in all repositories are deleted.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteChartNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChartNamespaceResponse
        /// </returns>
        public async Task<DeleteChartNamespaceResponse> DeleteChartNamespaceWithOptionsAsync(DeleteChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChartNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChartNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a chart namespace from an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If you delete a chart namespace, all repositories in the namespace and the charts in all repositories are deleted.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteChartNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChartNamespaceResponse
        /// </returns>
        public DeleteChartNamespaceResponse DeleteChartNamespace(DeleteChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChartNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a chart namespace from an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> If you delete a chart namespace, all repositories in the namespace and the charts in all repositories are deleted.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteChartNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChartNamespaceResponse
        /// </returns>
        public async Task<DeleteChartNamespaceResponse> DeleteChartNamespaceAsync(DeleteChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChartNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a chart version from a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChartReleaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChartReleaseResponse
        /// </returns>
        public DeleteChartReleaseResponse DeleteChartReleaseWithOptions(DeleteChartReleaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chart))
            {
                query["Chart"] = request.Chart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChartRelease",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChartReleaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a chart version from a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChartReleaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChartReleaseResponse
        /// </returns>
        public async Task<DeleteChartReleaseResponse> DeleteChartReleaseWithOptionsAsync(DeleteChartReleaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chart))
            {
                query["Chart"] = request.Chart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChartRelease",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChartReleaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a chart version from a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChartReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChartReleaseResponse
        /// </returns>
        public DeleteChartReleaseResponse DeleteChartRelease(DeleteChartReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChartReleaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a chart version from a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChartReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChartReleaseResponse
        /// </returns>
        public async Task<DeleteChartReleaseResponse> DeleteChartReleaseAsync(DeleteChartReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChartReleaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a chart repository from an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChartRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChartRepositoryResponse
        /// </returns>
        public DeleteChartRepositoryResponse DeleteChartRepositoryWithOptions(DeleteChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChartRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChartRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a chart repository from an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChartRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChartRepositoryResponse
        /// </returns>
        public async Task<DeleteChartRepositoryResponse> DeleteChartRepositoryWithOptionsAsync(DeleteChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChartRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChartRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a chart repository from an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChartRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChartRepositoryResponse
        /// </returns>
        public DeleteChartRepositoryResponse DeleteChartRepository(DeleteChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChartRepositoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a chart repository from an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChartRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChartRepositoryResponse
        /// </returns>
        public async Task<DeleteChartRepositoryResponse> DeleteChartRepositoryAsync(DeleteChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChartRepositoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event notification rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventCenterRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventCenterRuleResponse
        /// </returns>
        public DeleteEventCenterRuleResponse DeleteEventCenterRuleWithOptions(DeleteEventCenterRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventCenterRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventCenterRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event notification rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventCenterRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventCenterRuleResponse
        /// </returns>
        public async Task<DeleteEventCenterRuleResponse> DeleteEventCenterRuleWithOptionsAsync(DeleteEventCenterRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventCenterRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventCenterRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event notification rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventCenterRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventCenterRuleResponse
        /// </returns>
        public DeleteEventCenterRuleResponse DeleteEventCenterRule(DeleteEventCenterRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventCenterRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an event notification rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEventCenterRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEventCenterRuleResponse
        /// </returns>
        public async Task<DeleteEventCenterRuleResponse> DeleteEventCenterRuleAsync(DeleteEventCenterRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventCenterRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a whitelist policy for the public endpoint of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceEndpointAclPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceEndpointAclPolicyResponse
        /// </returns>
        public DeleteInstanceEndpointAclPolicyResponse DeleteInstanceEndpointAclPolicyWithOptions(DeleteInstanceEndpointAclPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointType))
            {
                query["EndpointType"] = request.EndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Entry))
            {
                query["Entry"] = request.Entry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceEndpointAclPolicy",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceEndpointAclPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a whitelist policy for the public endpoint of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceEndpointAclPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceEndpointAclPolicyResponse
        /// </returns>
        public async Task<DeleteInstanceEndpointAclPolicyResponse> DeleteInstanceEndpointAclPolicyWithOptionsAsync(DeleteInstanceEndpointAclPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointType))
            {
                query["EndpointType"] = request.EndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Entry))
            {
                query["Entry"] = request.Entry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceEndpointAclPolicy",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceEndpointAclPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a whitelist policy for the public endpoint of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceEndpointAclPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceEndpointAclPolicyResponse
        /// </returns>
        public DeleteInstanceEndpointAclPolicyResponse DeleteInstanceEndpointAclPolicy(DeleteInstanceEndpointAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceEndpointAclPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a whitelist policy for the public endpoint of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceEndpointAclPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceEndpointAclPolicyResponse
        /// </returns>
        public async Task<DeleteInstanceEndpointAclPolicyResponse> DeleteInstanceEndpointAclPolicyAsync(DeleteInstanceEndpointAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceEndpointAclPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a virtual private cloud (VPC) from an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceVpcEndpointLinkedVpcRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceVpcEndpointLinkedVpcResponse
        /// </returns>
        public DeleteInstanceVpcEndpointLinkedVpcResponse DeleteInstanceVpcEndpointLinkedVpcWithOptions(DeleteInstanceVpcEndpointLinkedVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchId))
            {
                query["VswitchId"] = request.VswitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceVpcEndpointLinkedVpc",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceVpcEndpointLinkedVpcResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a virtual private cloud (VPC) from an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceVpcEndpointLinkedVpcRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceVpcEndpointLinkedVpcResponse
        /// </returns>
        public async Task<DeleteInstanceVpcEndpointLinkedVpcResponse> DeleteInstanceVpcEndpointLinkedVpcWithOptionsAsync(DeleteInstanceVpcEndpointLinkedVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchId))
            {
                query["VswitchId"] = request.VswitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceVpcEndpointLinkedVpc",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceVpcEndpointLinkedVpcResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a virtual private cloud (VPC) from an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceVpcEndpointLinkedVpcRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceVpcEndpointLinkedVpcResponse
        /// </returns>
        public DeleteInstanceVpcEndpointLinkedVpcResponse DeleteInstanceVpcEndpointLinkedVpc(DeleteInstanceVpcEndpointLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceVpcEndpointLinkedVpcWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a virtual private cloud (VPC) from an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceVpcEndpointLinkedVpcRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceVpcEndpointLinkedVpcResponse
        /// </returns>
        public async Task<DeleteInstanceVpcEndpointLinkedVpcResponse> DeleteInstanceVpcEndpointLinkedVpcAsync(DeleteInstanceVpcEndpointLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceVpcEndpointLinkedVpcWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a namespace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After you delete a namespace, all repositories in the namespace and all images in these repositories are deleted as well.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public DeleteNamespaceResponse DeleteNamespaceWithOptions(DeleteNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a namespace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After you delete a namespace, all repositories in the namespace and all images in these repositories are deleted as well.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespaceWithOptionsAsync(DeleteNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a namespace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After you delete a namespace, all repositories in the namespace and all images in these repositories are deleted as well.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a namespace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>After you delete a namespace, all repositories in the namespace and all images in these repositories are deleted as well.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image building rule of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoBuildRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoBuildRuleResponse
        /// </returns>
        public DeleteRepoBuildRuleResponse DeleteRepoBuildRuleWithOptions(DeleteRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRuleId))
            {
                query["BuildRuleId"] = request.BuildRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteRepoBuildRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoBuildRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image building rule of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoBuildRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoBuildRuleResponse
        /// </returns>
        public async Task<DeleteRepoBuildRuleResponse> DeleteRepoBuildRuleWithOptionsAsync(DeleteRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRuleId))
            {
                query["BuildRuleId"] = request.BuildRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteRepoBuildRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoBuildRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image building rule of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoBuildRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoBuildRuleResponse
        /// </returns>
        public DeleteRepoBuildRuleResponse DeleteRepoBuildRule(DeleteRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRepoBuildRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image building rule of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoBuildRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoBuildRuleResponse
        /// </returns>
        public async Task<DeleteRepoBuildRuleResponse> DeleteRepoBuildRuleAsync(DeleteRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRepoBuildRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image replication rule of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoSyncRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoSyncRuleResponse
        /// </returns>
        public DeleteRepoSyncRuleResponse DeleteRepoSyncRuleWithOptions(DeleteRepoSyncRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncRuleId))
            {
                query["SyncRuleId"] = request.SyncRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepoSyncRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoSyncRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image replication rule of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoSyncRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoSyncRuleResponse
        /// </returns>
        public async Task<DeleteRepoSyncRuleResponse> DeleteRepoSyncRuleWithOptionsAsync(DeleteRepoSyncRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncRuleId))
            {
                query["SyncRuleId"] = request.SyncRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepoSyncRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoSyncRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image replication rule of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoSyncRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoSyncRuleResponse
        /// </returns>
        public DeleteRepoSyncRuleResponse DeleteRepoSyncRule(DeleteRepoSyncRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRepoSyncRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image replication rule of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoSyncRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoSyncRuleResponse
        /// </returns>
        public async Task<DeleteRepoSyncRuleResponse> DeleteRepoSyncRuleAsync(DeleteRepoSyncRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRepoSyncRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoTagResponse
        /// </returns>
        public DeleteRepoTagResponse DeleteRepoTagWithOptions(DeleteRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
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
                Action = "DeleteRepoTag",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoTagResponse
        /// </returns>
        public async Task<DeleteRepoTagResponse> DeleteRepoTagWithOptionsAsync(DeleteRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
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
                Action = "DeleteRepoTag",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoTagRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoTagResponse
        /// </returns>
        public DeleteRepoTagResponse DeleteRepoTag(DeleteRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRepoTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoTagRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoTagResponse
        /// </returns>
        public async Task<DeleteRepoTagResponse> DeleteRepoTagAsync(DeleteRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRepoTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a trigger of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoTriggerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoTriggerResponse
        /// </returns>
        public DeleteRepoTriggerResponse DeleteRepoTriggerWithOptions(DeleteRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerId))
            {
                query["TriggerId"] = request.TriggerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepoTrigger",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoTriggerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a trigger of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoTriggerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoTriggerResponse
        /// </returns>
        public async Task<DeleteRepoTriggerResponse> DeleteRepoTriggerWithOptionsAsync(DeleteRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerId))
            {
                query["TriggerId"] = request.TriggerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepoTrigger",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepoTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a trigger of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoTriggerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoTriggerResponse
        /// </returns>
        public DeleteRepoTriggerResponse DeleteRepoTrigger(DeleteRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRepoTriggerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a trigger of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRepoTriggerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepoTriggerResponse
        /// </returns>
        public async Task<DeleteRepoTriggerResponse> DeleteRepoTriggerAsync(DeleteRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRepoTriggerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image repository.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you delete a repository, all images in the repository are also deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepositoryResponse
        /// </returns>
        public DeleteRepositoryResponse DeleteRepositoryWithOptions(DeleteRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image repository.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you delete a repository, all images in the repository are also deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepositoryResponse
        /// </returns>
        public async Task<DeleteRepositoryResponse> DeleteRepositoryWithOptionsAsync(DeleteRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image repository.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you delete a repository, all images in the repository are also deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepositoryResponse
        /// </returns>
        public DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRepositoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image repository.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you delete a repository, all images in the repository are also deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRepositoryResponse
        /// </returns>
        public async Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRepositoryWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetArtifactBuildRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactBuildRuleResponse
        /// </returns>
        public GetArtifactBuildRuleResponse GetArtifactBuildRuleWithOptions(GetArtifactBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactBuildRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactBuildRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetArtifactBuildRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactBuildRuleResponse
        /// </returns>
        public async Task<GetArtifactBuildRuleResponse> GetArtifactBuildRuleWithOptionsAsync(GetArtifactBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactBuildRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactBuildRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetArtifactBuildRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactBuildRuleResponse
        /// </returns>
        public GetArtifactBuildRuleResponse GetArtifactBuildRule(GetArtifactBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetArtifactBuildRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetArtifactBuildRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactBuildRuleResponse
        /// </returns>
        public async Task<GetArtifactBuildRuleResponse> GetArtifactBuildRuleAsync(GetArtifactBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetArtifactBuildRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an artifact building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactBuildTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactBuildTaskResponse
        /// </returns>
        public GetArtifactBuildTaskResponse GetArtifactBuildTaskWithOptions(GetArtifactBuildTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactBuildTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactBuildTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an artifact building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactBuildTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactBuildTaskResponse
        /// </returns>
        public async Task<GetArtifactBuildTaskResponse> GetArtifactBuildTaskWithOptionsAsync(GetArtifactBuildTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactBuildTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactBuildTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an artifact building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactBuildTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactBuildTaskResponse
        /// </returns>
        public GetArtifactBuildTaskResponse GetArtifactBuildTask(GetArtifactBuildTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetArtifactBuildTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an artifact building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactBuildTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactBuildTaskResponse
        /// </returns>
        public async Task<GetArtifactBuildTaskResponse> GetArtifactBuildTaskAsync(GetArtifactBuildTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetArtifactBuildTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the lifecycle management rules of an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactLifecycleRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactLifecycleRuleResponse
        /// </returns>
        public GetArtifactLifecycleRuleResponse GetArtifactLifecycleRuleWithOptions(GetArtifactLifecycleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactLifecycleRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactLifecycleRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the lifecycle management rules of an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactLifecycleRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactLifecycleRuleResponse
        /// </returns>
        public async Task<GetArtifactLifecycleRuleResponse> GetArtifactLifecycleRuleWithOptionsAsync(GetArtifactLifecycleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactLifecycleRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactLifecycleRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the lifecycle management rules of an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactLifecycleRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactLifecycleRuleResponse
        /// </returns>
        public GetArtifactLifecycleRuleResponse GetArtifactLifecycleRule(GetArtifactLifecycleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetArtifactLifecycleRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the lifecycle management rules of an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactLifecycleRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactLifecycleRuleResponse
        /// </returns>
        public async Task<GetArtifactLifecycleRuleResponse> GetArtifactLifecycleRuleAsync(GetArtifactLifecycleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetArtifactLifecycleRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactSubscriptionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactSubscriptionRuleResponse
        /// </returns>
        public GetArtifactSubscriptionRuleResponse GetArtifactSubscriptionRuleWithOptions(GetArtifactSubscriptionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactSubscriptionRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactSubscriptionRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactSubscriptionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactSubscriptionRuleResponse
        /// </returns>
        public async Task<GetArtifactSubscriptionRuleResponse> GetArtifactSubscriptionRuleWithOptionsAsync(GetArtifactSubscriptionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactSubscriptionRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactSubscriptionRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactSubscriptionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactSubscriptionRuleResponse
        /// </returns>
        public GetArtifactSubscriptionRuleResponse GetArtifactSubscriptionRule(GetArtifactSubscriptionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetArtifactSubscriptionRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactSubscriptionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactSubscriptionRuleResponse
        /// </returns>
        public async Task<GetArtifactSubscriptionRuleResponse> GetArtifactSubscriptionRuleAsync(GetArtifactSubscriptionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetArtifactSubscriptionRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an artifact subscription task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactSubscriptionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactSubscriptionTaskResponse
        /// </returns>
        public GetArtifactSubscriptionTaskResponse GetArtifactSubscriptionTaskWithOptions(GetArtifactSubscriptionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactSubscriptionTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactSubscriptionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an artifact subscription task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactSubscriptionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactSubscriptionTaskResponse
        /// </returns>
        public async Task<GetArtifactSubscriptionTaskResponse> GetArtifactSubscriptionTaskWithOptionsAsync(GetArtifactSubscriptionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactSubscriptionTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactSubscriptionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an artifact subscription task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactSubscriptionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactSubscriptionTaskResponse
        /// </returns>
        public GetArtifactSubscriptionTaskResponse GetArtifactSubscriptionTask(GetArtifactSubscriptionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetArtifactSubscriptionTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an artifact subscription task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactSubscriptionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactSubscriptionTaskResponse
        /// </returns>
        public async Task<GetArtifactSubscriptionTaskResponse> GetArtifactSubscriptionTaskAsync(GetArtifactSubscriptionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetArtifactSubscriptionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an artifact subscription task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactSubscriptionTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactSubscriptionTaskResultResponse
        /// </returns>
        public GetArtifactSubscriptionTaskResultResponse GetArtifactSubscriptionTaskResultWithOptions(GetArtifactSubscriptionTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactSubscriptionTaskResult",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactSubscriptionTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an artifact subscription task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactSubscriptionTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactSubscriptionTaskResultResponse
        /// </returns>
        public async Task<GetArtifactSubscriptionTaskResultResponse> GetArtifactSubscriptionTaskResultWithOptionsAsync(GetArtifactSubscriptionTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifactSubscriptionTaskResult",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArtifactSubscriptionTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an artifact subscription task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactSubscriptionTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactSubscriptionTaskResultResponse
        /// </returns>
        public GetArtifactSubscriptionTaskResultResponse GetArtifactSubscriptionTaskResult(GetArtifactSubscriptionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetArtifactSubscriptionTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an artifact subscription task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArtifactSubscriptionTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArtifactSubscriptionTaskResultResponse
        /// </returns>
        public async Task<GetArtifactSubscriptionTaskResultResponse> GetArtifactSubscriptionTaskResultAsync(GetArtifactSubscriptionTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetArtifactSubscriptionTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a temporary username and a token that you can use to log on to a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The ID of the Container Registry instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAuthorizationTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAuthorizationTokenResponse
        /// </returns>
        public GetAuthorizationTokenResponse GetAuthorizationTokenWithOptions(GetAuthorizationTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuthorizationToken",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthorizationTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a temporary username and a token that you can use to log on to a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The ID of the Container Registry instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAuthorizationTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAuthorizationTokenResponse
        /// </returns>
        public async Task<GetAuthorizationTokenResponse> GetAuthorizationTokenWithOptionsAsync(GetAuthorizationTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuthorizationToken",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthorizationTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a temporary username and a token that you can use to log on to a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The ID of the Container Registry instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAuthorizationTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAuthorizationTokenResponse
        /// </returns>
        public GetAuthorizationTokenResponse GetAuthorizationToken(GetAuthorizationTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAuthorizationTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a temporary username and a token that you can use to log on to a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The ID of the Container Registry instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAuthorizationTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAuthorizationTokenResponse
        /// </returns>
        public async Task<GetAuthorizationTokenResponse> GetAuthorizationTokenAsync(GetAuthorizationTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAuthorizationTokenWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChainResponse
        /// </returns>
        public GetChainResponse GetChainWithOptions(GetChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainId))
            {
                query["ChainId"] = request.ChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChain",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChainResponse
        /// </returns>
        public async Task<GetChainResponse> GetChainWithOptionsAsync(GetChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainId))
            {
                query["ChainId"] = request.ChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChain",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetChainRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChainResponse
        /// </returns>
        public GetChainResponse GetChain(GetChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetChainRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChainResponse
        /// </returns>
        public async Task<GetChainResponse> GetChainAsync(GetChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a chart namespace in an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChartNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChartNamespaceResponse
        /// </returns>
        public GetChartNamespaceResponse GetChartNamespaceWithOptions(GetChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChartNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChartNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a chart namespace in an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChartNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChartNamespaceResponse
        /// </returns>
        public async Task<GetChartNamespaceResponse> GetChartNamespaceWithOptionsAsync(GetChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChartNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChartNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a chart namespace in an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChartNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChartNamespaceResponse
        /// </returns>
        public GetChartNamespaceResponse GetChartNamespace(GetChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChartNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a chart namespace in an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChartNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChartNamespaceResponse
        /// </returns>
        public async Task<GetChartNamespaceResponse> GetChartNamespaceAsync(GetChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChartNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChartRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChartRepositoryResponse
        /// </returns>
        public GetChartRepositoryResponse GetChartRepositoryWithOptions(GetChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChartRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChartRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChartRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChartRepositoryResponse
        /// </returns>
        public async Task<GetChartRepositoryResponse> GetChartRepositoryWithOptionsAsync(GetChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChartRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChartRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChartRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChartRepositoryResponse
        /// </returns>
        public GetChartRepositoryResponse GetChartRepository(GetChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChartRepositoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChartRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChartRepositoryResponse
        /// </returns>
        public async Task<GetChartRepositoryResponse> GetChartRepositoryAsync(GetChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChartRepositoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public GetInstanceResponse GetInstanceWithOptions(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public async Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceCountResponse
        /// </returns>
        public GetInstanceCountResponse GetInstanceCountWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceCount",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceCountResponse
        /// </returns>
        public async Task<GetInstanceCountResponse> GetInstanceCountWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceCount",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of instances.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetInstanceCountResponse
        /// </returns>
        public GetInstanceCountResponse GetInstanceCount()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceCountWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of instances.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetInstanceCountResponse
        /// </returns>
        public async Task<GetInstanceCountResponse> GetInstanceCountAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceCountWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoint of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceEndpointResponse
        /// </returns>
        public GetInstanceEndpointResponse GetInstanceEndpointWithOptions(GetInstanceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointType))
            {
                query["EndpointType"] = request.EndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceEndpoint",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoint of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceEndpointResponse
        /// </returns>
        public async Task<GetInstanceEndpointResponse> GetInstanceEndpointWithOptionsAsync(GetInstanceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointType))
            {
                query["EndpointType"] = request.EndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceEndpoint",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoint of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceEndpointResponse
        /// </returns>
        public GetInstanceEndpointResponse GetInstanceEndpoint(GetInstanceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoint of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceEndpointResponse
        /// </returns>
        public async Task<GetInstanceEndpointResponse> GetInstanceEndpointAsync(GetInstanceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quota usage of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceUsageResponse
        /// </returns>
        public GetInstanceUsageResponse GetInstanceUsageWithOptions(GetInstanceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceUsage",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceUsageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quota usage of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceUsageResponse
        /// </returns>
        public async Task<GetInstanceUsageResponse> GetInstanceUsageWithOptionsAsync(GetInstanceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceUsage",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quota usage of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceUsageResponse
        /// </returns>
        public GetInstanceUsageResponse GetInstanceUsage(GetInstanceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceUsageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the quota usage of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceUsageResponse
        /// </returns>
        public async Task<GetInstanceUsageResponse> GetInstanceUsageAsync(GetInstanceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceUsageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoints of the virtual private clouds (VPCs) in which a Container Registry instance is deployed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceVpcEndpointResponse
        /// </returns>
        public GetInstanceVpcEndpointResponse GetInstanceVpcEndpointWithOptions(GetInstanceVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceVpcEndpoint",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceVpcEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoints of the virtual private clouds (VPCs) in which a Container Registry instance is deployed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceVpcEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceVpcEndpointResponse
        /// </returns>
        public async Task<GetInstanceVpcEndpointResponse> GetInstanceVpcEndpointWithOptionsAsync(GetInstanceVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceVpcEndpoint",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceVpcEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoints of the virtual private clouds (VPCs) in which a Container Registry instance is deployed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceVpcEndpointResponse
        /// </returns>
        public GetInstanceVpcEndpointResponse GetInstanceVpcEndpoint(GetInstanceVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceVpcEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoints of the virtual private clouds (VPCs) in which a Container Registry instance is deployed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceVpcEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceVpcEndpointResponse
        /// </returns>
        public async Task<GetInstanceVpcEndpointResponse> GetInstanceVpcEndpointAsync(GetInstanceVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceVpcEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNamespaceResponse
        /// </returns>
        public GetNamespaceResponse GetNamespaceWithOptions(GetNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNamespaceResponse
        /// </returns>
        public async Task<GetNamespaceResponse> GetNamespaceWithOptionsAsync(GetNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNamespaceResponse
        /// </returns>
        public GetNamespaceResponse GetNamespace(GetNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNamespaceResponse
        /// </returns>
        public async Task<GetNamespaceResponse> GetNamespaceAsync(GetNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about image building records of a repository.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRepoBuildRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoBuildRecordResponse
        /// </returns>
        public GetRepoBuildRecordResponse GetRepoBuildRecordWithOptions(GetRepoBuildRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRecordId))
            {
                query["BuildRecordId"] = request.BuildRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoBuildRecord",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoBuildRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about image building records of a repository.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRepoBuildRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoBuildRecordResponse
        /// </returns>
        public async Task<GetRepoBuildRecordResponse> GetRepoBuildRecordWithOptionsAsync(GetRepoBuildRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRecordId))
            {
                query["BuildRecordId"] = request.BuildRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoBuildRecord",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoBuildRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about image building records of a repository.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRepoBuildRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoBuildRecordResponse
        /// </returns>
        public GetRepoBuildRecordResponse GetRepoBuildRecord(GetRepoBuildRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoBuildRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about image building records of a repository.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <hr>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRepoBuildRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoBuildRecordResponse
        /// </returns>
        public async Task<GetRepoBuildRecordResponse> GetRepoBuildRecordAsync(GetRepoBuildRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoBuildRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an image building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoBuildRecordStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoBuildRecordStatusResponse
        /// </returns>
        public GetRepoBuildRecordStatusResponse GetRepoBuildRecordStatusWithOptions(GetRepoBuildRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRecordId))
            {
                query["BuildRecordId"] = request.BuildRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetRepoBuildRecordStatus",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoBuildRecordStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an image building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoBuildRecordStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoBuildRecordStatusResponse
        /// </returns>
        public async Task<GetRepoBuildRecordStatusResponse> GetRepoBuildRecordStatusWithOptionsAsync(GetRepoBuildRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRecordId))
            {
                query["BuildRecordId"] = request.BuildRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetRepoBuildRecordStatus",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoBuildRecordStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an image building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoBuildRecordStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoBuildRecordStatusResponse
        /// </returns>
        public GetRepoBuildRecordStatusResponse GetRepoBuildRecordStatus(GetRepoBuildRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoBuildRecordStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an image building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoBuildRecordStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoBuildRecordStatusResponse
        /// </returns>
        public async Task<GetRepoBuildRecordStatusResponse> GetRepoBuildRecordStatusAsync(GetRepoBuildRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoBuildRecordStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the source code repository that is bound to an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoSourceCodeRepoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoSourceCodeRepoResponse
        /// </returns>
        public GetRepoSourceCodeRepoResponse GetRepoSourceCodeRepoWithOptions(GetRepoSourceCodeRepoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetRepoSourceCodeRepo",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoSourceCodeRepoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the source code repository that is bound to an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoSourceCodeRepoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoSourceCodeRepoResponse
        /// </returns>
        public async Task<GetRepoSourceCodeRepoResponse> GetRepoSourceCodeRepoWithOptionsAsync(GetRepoSourceCodeRepoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetRepoSourceCodeRepo",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoSourceCodeRepoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the source code repository that is bound to an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoSourceCodeRepoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoSourceCodeRepoResponse
        /// </returns>
        public GetRepoSourceCodeRepoResponse GetRepoSourceCodeRepo(GetRepoSourceCodeRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoSourceCodeRepoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the source code repository that is bound to an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoSourceCodeRepoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoSourceCodeRepoResponse
        /// </returns>
        public async Task<GetRepoSourceCodeRepoResponse> GetRepoSourceCodeRepoAsync(GetRepoSourceCodeRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoSourceCodeRepoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an image synchronization task in an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoSyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoSyncTaskResponse
        /// </returns>
        public GetRepoSyncTaskResponse GetRepoSyncTaskWithOptions(GetRepoSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncTaskId))
            {
                query["SyncTaskId"] = request.SyncTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoSyncTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoSyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an image synchronization task in an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoSyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoSyncTaskResponse
        /// </returns>
        public async Task<GetRepoSyncTaskResponse> GetRepoSyncTaskWithOptionsAsync(GetRepoSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncTaskId))
            {
                query["SyncTaskId"] = request.SyncTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoSyncTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoSyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an image synchronization task in an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoSyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoSyncTaskResponse
        /// </returns>
        public GetRepoSyncTaskResponse GetRepoSyncTask(GetRepoSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoSyncTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an image synchronization task in an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoSyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoSyncTaskResponse
        /// </returns>
        public async Task<GetRepoSyncTaskResponse> GetRepoSyncTaskAsync(GetRepoSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoSyncTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The version of the repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoTagResponse
        /// </returns>
        public GetRepoTagResponse GetRepoTagWithOptions(GetRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoTag",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The version of the repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoTagResponse
        /// </returns>
        public async Task<GetRepoTagResponse> GetRepoTagWithOptionsAsync(GetRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepoTag",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The version of the repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoTagRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoTagResponse
        /// </returns>
        public GetRepoTagResponse GetRepoTag(GetRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The version of the repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepoTagRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoTagResponse
        /// </returns>
        public async Task<GetRepoTagResponse> GetRepoTagAsync(GetRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoTagWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetRepoTagScanStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoTagScanStatusResponse
        /// </returns>
        public GetRepoTagScanStatusResponse GetRepoTagScanStatusWithOptions(GetRepoTagScanStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanTaskId))
            {
                query["ScanTaskId"] = request.ScanTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanType))
            {
                query["ScanType"] = request.ScanType;
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
                Action = "GetRepoTagScanStatus",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagScanStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRepoTagScanStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoTagScanStatusResponse
        /// </returns>
        public async Task<GetRepoTagScanStatusResponse> GetRepoTagScanStatusWithOptionsAsync(GetRepoTagScanStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanTaskId))
            {
                query["ScanTaskId"] = request.ScanTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanType))
            {
                query["ScanType"] = request.ScanType;
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
                Action = "GetRepoTagScanStatus",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagScanStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRepoTagScanStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoTagScanStatusResponse
        /// </returns>
        public GetRepoTagScanStatusResponse GetRepoTagScanStatus(GetRepoTagScanStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoTagScanStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetRepoTagScanStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoTagScanStatusResponse
        /// </returns>
        public async Task<GetRepoTagScanStatusResponse> GetRepoTagScanStatusAsync(GetRepoTagScanStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoTagScanStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetRepoTagScanSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoTagScanSummaryResponse
        /// </returns>
        public GetRepoTagScanSummaryResponse GetRepoTagScanSummaryWithOptions(GetRepoTagScanSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanTaskId))
            {
                query["ScanTaskId"] = request.ScanTaskId;
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
                Action = "GetRepoTagScanSummary",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagScanSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRepoTagScanSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepoTagScanSummaryResponse
        /// </returns>
        public async Task<GetRepoTagScanSummaryResponse> GetRepoTagScanSummaryWithOptionsAsync(GetRepoTagScanSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanTaskId))
            {
                query["ScanTaskId"] = request.ScanTaskId;
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
                Action = "GetRepoTagScanSummary",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepoTagScanSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRepoTagScanSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoTagScanSummaryResponse
        /// </returns>
        public GetRepoTagScanSummaryResponse GetRepoTagScanSummary(GetRepoTagScanSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoTagScanSummaryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetRepoTagScanSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepoTagScanSummaryResponse
        /// </returns>
        public async Task<GetRepoTagScanSummaryResponse> GetRepoTagScanSummaryAsync(GetRepoTagScanSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoTagScanSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepositoryResponse
        /// </returns>
        public GetRepositoryResponse GetRepositoryWithOptions(GetRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRepositoryResponse
        /// </returns>
        public async Task<GetRepositoryResponse> GetRepositoryWithOptionsAsync(GetRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepositoryResponse
        /// </returns>
        public GetRepositoryResponse GetRepository(GetRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepositoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRepositoryResponse
        /// </returns>
        public async Task<GetRepositoryResponse> GetRepositoryAsync(GetRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepositoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log entries of an artifact building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactBuildTaskLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactBuildTaskLogResponse
        /// </returns>
        public ListArtifactBuildTaskLogResponse ListArtifactBuildTaskLogWithOptions(ListArtifactBuildTaskLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListArtifactBuildTaskLog",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactBuildTaskLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log entries of an artifact building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactBuildTaskLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactBuildTaskLogResponse
        /// </returns>
        public async Task<ListArtifactBuildTaskLogResponse> ListArtifactBuildTaskLogWithOptionsAsync(ListArtifactBuildTaskLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListArtifactBuildTaskLog",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactBuildTaskLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log entries of an artifact building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactBuildTaskLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactBuildTaskLogResponse
        /// </returns>
        public ListArtifactBuildTaskLogResponse ListArtifactBuildTaskLog(ListArtifactBuildTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListArtifactBuildTaskLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log entries of an artifact building task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactBuildTaskLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactBuildTaskLogResponse
        /// </returns>
        public async Task<ListArtifactBuildTaskLogResponse> ListArtifactBuildTaskLogAsync(ListArtifactBuildTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListArtifactBuildTaskLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the lifecycle management rules of an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactLifecycleRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactLifecycleRuleResponse
        /// </returns>
        public ListArtifactLifecycleRuleResponse ListArtifactLifecycleRuleWithOptions(ListArtifactLifecycleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListArtifactLifecycleRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactLifecycleRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the lifecycle management rules of an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactLifecycleRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactLifecycleRuleResponse
        /// </returns>
        public async Task<ListArtifactLifecycleRuleResponse> ListArtifactLifecycleRuleWithOptionsAsync(ListArtifactLifecycleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListArtifactLifecycleRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactLifecycleRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the lifecycle management rules of an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactLifecycleRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactLifecycleRuleResponse
        /// </returns>
        public ListArtifactLifecycleRuleResponse ListArtifactLifecycleRule(ListArtifactLifecycleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListArtifactLifecycleRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the lifecycle management rules of an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactLifecycleRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactLifecycleRuleResponse
        /// </returns>
        public async Task<ListArtifactLifecycleRuleResponse> ListArtifactLifecycleRuleAsync(ListArtifactLifecycleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListArtifactLifecycleRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the subscription rules of artifacts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactSubscriptionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactSubscriptionRuleResponse
        /// </returns>
        public ListArtifactSubscriptionRuleResponse ListArtifactSubscriptionRuleWithOptions(ListArtifactSubscriptionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListArtifactSubscriptionRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactSubscriptionRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the subscription rules of artifacts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactSubscriptionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactSubscriptionRuleResponse
        /// </returns>
        public async Task<ListArtifactSubscriptionRuleResponse> ListArtifactSubscriptionRuleWithOptionsAsync(ListArtifactSubscriptionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListArtifactSubscriptionRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactSubscriptionRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the subscription rules of artifacts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactSubscriptionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactSubscriptionRuleResponse
        /// </returns>
        public ListArtifactSubscriptionRuleResponse ListArtifactSubscriptionRule(ListArtifactSubscriptionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListArtifactSubscriptionRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the subscription rules of artifacts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactSubscriptionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactSubscriptionRuleResponse
        /// </returns>
        public async Task<ListArtifactSubscriptionRuleResponse> ListArtifactSubscriptionRuleAsync(ListArtifactSubscriptionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListArtifactSubscriptionRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists artifact subscription tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactSubscriptionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactSubscriptionTaskResponse
        /// </returns>
        public ListArtifactSubscriptionTaskResponse ListArtifactSubscriptionTaskWithOptions(ListArtifactSubscriptionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListArtifactSubscriptionTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactSubscriptionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists artifact subscription tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactSubscriptionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactSubscriptionTaskResponse
        /// </returns>
        public async Task<ListArtifactSubscriptionTaskResponse> ListArtifactSubscriptionTaskWithOptionsAsync(ListArtifactSubscriptionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListArtifactSubscriptionTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListArtifactSubscriptionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists artifact subscription tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactSubscriptionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactSubscriptionTaskResponse
        /// </returns>
        public ListArtifactSubscriptionTaskResponse ListArtifactSubscriptionTask(ListArtifactSubscriptionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListArtifactSubscriptionTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists artifact subscription tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListArtifactSubscriptionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListArtifactSubscriptionTaskResponse
        /// </returns>
        public async Task<ListArtifactSubscriptionTaskResponse> ListArtifactSubscriptionTaskAsync(ListArtifactSubscriptionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListArtifactSubscriptionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries delivery chains.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChainResponse
        /// </returns>
        public ListChainResponse ListChainWithOptions(ListChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChain",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries delivery chains.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChainResponse
        /// </returns>
        public async Task<ListChainResponse> ListChainWithOptionsAsync(ListChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChain",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries delivery chains.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChainRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChainResponse
        /// </returns>
        public ListChainResponse ListChain(ListChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries delivery chains.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChainRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChainResponse
        /// </returns>
        public async Task<ListChainResponse> ListChainAsync(ListChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The response code.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChainInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChainInstanceResponse
        /// </returns>
        public ListChainInstanceResponse ListChainInstanceWithOptions(ListChainInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChainInstance",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChainInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The response code.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChainInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChainInstanceResponse
        /// </returns>
        public async Task<ListChainInstanceResponse> ListChainInstanceWithOptionsAsync(ListChainInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChainInstance",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChainInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The response code.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChainInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChainInstanceResponse
        /// </returns>
        public ListChainInstanceResponse ListChainInstance(ListChainInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChainInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The response code.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChainInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChainInstanceResponse
        /// </returns>
        public async Task<ListChainInstanceResponse> ListChainInstanceAsync(ListChainInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChainInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the chart namespaces of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChartNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChartNamespaceResponse
        /// </returns>
        public ListChartNamespaceResponse ListChartNamespaceWithOptions(ListChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceStatus))
            {
                query["NamespaceStatus"] = request.NamespaceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChartNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChartNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the chart namespaces of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChartNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChartNamespaceResponse
        /// </returns>
        public async Task<ListChartNamespaceResponse> ListChartNamespaceWithOptionsAsync(ListChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceStatus))
            {
                query["NamespaceStatus"] = request.NamespaceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChartNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChartNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the chart namespaces of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChartNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChartNamespaceResponse
        /// </returns>
        public ListChartNamespaceResponse ListChartNamespace(ListChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChartNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the chart namespaces of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChartNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChartNamespaceResponse
        /// </returns>
        public async Task<ListChartNamespaceResponse> ListChartNamespaceAsync(ListChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChartNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of a chart in a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChartReleaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChartReleaseResponse
        /// </returns>
        public ListChartReleaseResponse ListChartReleaseWithOptions(ListChartReleaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chart))
            {
                query["Chart"] = request.Chart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChartRelease",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChartReleaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of a chart in a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChartReleaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChartReleaseResponse
        /// </returns>
        public async Task<ListChartReleaseResponse> ListChartReleaseWithOptionsAsync(ListChartReleaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Chart))
            {
                query["Chart"] = request.Chart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChartRelease",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChartReleaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of a chart in a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChartReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChartReleaseResponse
        /// </returns>
        public ListChartReleaseResponse ListChartRelease(ListChartReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChartReleaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of a chart in a chart repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChartReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChartReleaseResponse
        /// </returns>
        public async Task<ListChartReleaseResponse> ListChartReleaseAsync(ListChartReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChartReleaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the chart repositories of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChartRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChartRepositoryResponse
        /// </returns>
        public ListChartRepositoryResponse ListChartRepositoryWithOptions(ListChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoStatus))
            {
                query["RepoStatus"] = request.RepoStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChartRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChartRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the chart repositories of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChartRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChartRepositoryResponse
        /// </returns>
        public async Task<ListChartRepositoryResponse> ListChartRepositoryWithOptionsAsync(ListChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoStatus))
            {
                query["RepoStatus"] = request.RepoStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChartRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChartRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the chart repositories of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChartRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChartRepositoryResponse
        /// </returns>
        public ListChartRepositoryResponse ListChartRepository(ListChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChartRepositoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the chart repositories of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChartRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChartRepositoryResponse
        /// </returns>
        public async Task<ListChartRepositoryResponse> ListChartRepositoryAsync(ListChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChartRepositoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical events of an event rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventCenterRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventCenterRecordResponse
        /// </returns>
        public ListEventCenterRecordResponse ListEventCenterRecordWithOptions(ListEventCenterRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventCenterRecord",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventCenterRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical events of an event rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventCenterRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventCenterRecordResponse
        /// </returns>
        public async Task<ListEventCenterRecordResponse> ListEventCenterRecordWithOptionsAsync(ListEventCenterRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventCenterRecord",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventCenterRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical events of an event rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventCenterRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventCenterRecordResponse
        /// </returns>
        public ListEventCenterRecordResponse ListEventCenterRecord(ListEventCenterRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEventCenterRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical events of an event rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventCenterRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventCenterRecordResponse
        /// </returns>
        public async Task<ListEventCenterRecordResponse> ListEventCenterRecordAsync(ListEventCenterRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEventCenterRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the names of event notification rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventCenterRuleNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventCenterRuleNameResponse
        /// </returns>
        public ListEventCenterRuleNameResponse ListEventCenterRuleNameWithOptions(ListEventCenterRuleNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventCenterRuleName",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventCenterRuleNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the names of event notification rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventCenterRuleNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEventCenterRuleNameResponse
        /// </returns>
        public async Task<ListEventCenterRuleNameResponse> ListEventCenterRuleNameWithOptionsAsync(ListEventCenterRuleNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventCenterRuleName",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventCenterRuleNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the names of event notification rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventCenterRuleNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventCenterRuleNameResponse
        /// </returns>
        public ListEventCenterRuleNameResponse ListEventCenterRuleName(ListEventCenterRuleNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEventCenterRuleNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the names of event notification rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEventCenterRuleNameRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEventCenterRuleNameResponse
        /// </returns>
        public async Task<ListEventCenterRuleNameResponse> ListEventCenterRuleNameAsync(ListEventCenterRuleNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEventCenterRuleNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Container Registry instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceResponse
        /// </returns>
        public ListInstanceResponse ListInstanceWithOptions(ListInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                query["InstanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListInstance",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Container Registry instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceResponse
        /// </returns>
        public async Task<ListInstanceResponse> ListInstanceWithOptionsAsync(ListInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                query["InstanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListInstance",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Container Registry instances.</para>
        /// </summary>
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
            return ListInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries Container Registry instances.</para>
        /// </summary>
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
            return await ListInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoints of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceEndpointResponse
        /// </returns>
        public ListInstanceEndpointResponse ListInstanceEndpointWithOptions(ListInstanceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                query["Summary"] = request.Summary;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceEndpoint",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceEndpointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoints of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceEndpointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceEndpointResponse
        /// </returns>
        public async Task<ListInstanceEndpointResponse> ListInstanceEndpointWithOptionsAsync(ListInstanceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                query["Summary"] = request.Summary;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceEndpoint",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceEndpointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoints of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceEndpointResponse
        /// </returns>
        public ListInstanceEndpointResponse ListInstanceEndpoint(ListInstanceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceEndpointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoints of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceEndpointRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceEndpointResponse
        /// </returns>
        public async Task<ListInstanceEndpointResponse> ListInstanceEndpointAsync(ListInstanceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceEndpointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries regions in which you can create Container Registry instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceRegionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceRegionResponse
        /// </returns>
        public ListInstanceRegionResponse ListInstanceRegionWithOptions(ListInstanceRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceRegion",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceRegionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries regions in which you can create Container Registry instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceRegionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceRegionResponse
        /// </returns>
        public async Task<ListInstanceRegionResponse> ListInstanceRegionWithOptionsAsync(ListInstanceRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceRegion",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries regions in which you can create Container Registry instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceRegionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceRegionResponse
        /// </returns>
        public ListInstanceRegionResponse ListInstanceRegion(ListInstanceRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceRegionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries regions in which you can create Container Registry instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceRegionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceRegionResponse
        /// </returns>
        public async Task<ListInstanceRegionResponse> ListInstanceRegionAsync(ListInstanceRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceRegionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cri-94klsruryslx****</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNamespaceResponse
        /// </returns>
        public ListNamespaceResponse ListNamespaceWithOptions(ListNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceStatus))
            {
                query["NamespaceStatus"] = request.NamespaceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cri-94klsruryslx****</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNamespaceResponse
        /// </returns>
        public async Task<ListNamespaceResponse> ListNamespaceWithOptionsAsync(ListNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceStatus))
            {
                query["NamespaceStatus"] = request.NamespaceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cri-94klsruryslx****</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNamespaceResponse
        /// </returns>
        public ListNamespaceResponse ListNamespace(ListNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cri-94klsruryslx****</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNamespaceResponse
        /// </returns>
        public async Task<ListNamespaceResponse> ListNamespaceAsync(ListNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image building records of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoBuildRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoBuildRecordResponse
        /// </returns>
        public ListRepoBuildRecordResponse ListRepoBuildRecordWithOptions(ListRepoBuildRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListRepoBuildRecord",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoBuildRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image building records of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoBuildRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoBuildRecordResponse
        /// </returns>
        public async Task<ListRepoBuildRecordResponse> ListRepoBuildRecordWithOptionsAsync(ListRepoBuildRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListRepoBuildRecord",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoBuildRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image building records of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoBuildRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoBuildRecordResponse
        /// </returns>
        public ListRepoBuildRecordResponse ListRepoBuildRecord(ListRepoBuildRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoBuildRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image building records of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoBuildRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoBuildRecordResponse
        /// </returns>
        public async Task<ListRepoBuildRecordResponse> ListRepoBuildRecordAsync(ListRepoBuildRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoBuildRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an image building record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoBuildRecordLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoBuildRecordLogResponse
        /// </returns>
        public ListRepoBuildRecordLogResponse ListRepoBuildRecordLogWithOptions(ListRepoBuildRecordLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRecordId))
            {
                query["BuildRecordId"] = request.BuildRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
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
                Action = "ListRepoBuildRecordLog",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoBuildRecordLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an image building record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoBuildRecordLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoBuildRecordLogResponse
        /// </returns>
        public async Task<ListRepoBuildRecordLogResponse> ListRepoBuildRecordLogWithOptionsAsync(ListRepoBuildRecordLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRecordId))
            {
                query["BuildRecordId"] = request.BuildRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
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
                Action = "ListRepoBuildRecordLog",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoBuildRecordLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an image building record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoBuildRecordLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoBuildRecordLogResponse
        /// </returns>
        public ListRepoBuildRecordLogResponse ListRepoBuildRecordLog(ListRepoBuildRecordLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoBuildRecordLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the log of an image building record.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoBuildRecordLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoBuildRecordLogResponse
        /// </returns>
        public async Task<ListRepoBuildRecordLogResponse> ListRepoBuildRecordLogAsync(ListRepoBuildRecordLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoBuildRecordLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image building rules of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoBuildRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoBuildRuleResponse
        /// </returns>
        public ListRepoBuildRuleResponse ListRepoBuildRuleWithOptions(ListRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListRepoBuildRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoBuildRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image building rules of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoBuildRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoBuildRuleResponse
        /// </returns>
        public async Task<ListRepoBuildRuleResponse> ListRepoBuildRuleWithOptionsAsync(ListRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListRepoBuildRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoBuildRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image building rules of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoBuildRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoBuildRuleResponse
        /// </returns>
        public ListRepoBuildRuleResponse ListRepoBuildRule(ListRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoBuildRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image building rules of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoBuildRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoBuildRuleResponse
        /// </returns>
        public async Task<ListRepoBuildRuleResponse> ListRepoBuildRuleAsync(ListRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoBuildRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image synchronization rules of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoSyncRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoSyncRuleResponse
        /// </returns>
        public ListRepoSyncRuleResponse ListRepoSyncRuleWithOptions(ListRepoSyncRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                query["TargetInstanceId"] = request.TargetInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRegionId))
            {
                query["TargetRegionId"] = request.TargetRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepoSyncRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoSyncRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image synchronization rules of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoSyncRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoSyncRuleResponse
        /// </returns>
        public async Task<ListRepoSyncRuleResponse> ListRepoSyncRuleWithOptionsAsync(ListRepoSyncRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                query["TargetInstanceId"] = request.TargetInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetRegionId))
            {
                query["TargetRegionId"] = request.TargetRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepoSyncRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoSyncRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image synchronization rules of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoSyncRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoSyncRuleResponse
        /// </returns>
        public ListRepoSyncRuleResponse ListRepoSyncRule(ListRepoSyncRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoSyncRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image synchronization rules of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoSyncRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoSyncRuleResponse
        /// </returns>
        public async Task<ListRepoSyncRuleResponse> ListRepoSyncRuleAsync(ListRepoSyncRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoSyncRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Indicates whether automatic link is used.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoSyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoSyncTaskResponse
        /// </returns>
        public ListRepoSyncTaskResponse ListRepoSyncTaskWithOptions(ListRepoSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncRecordId))
            {
                query["SyncRecordId"] = request.SyncRecordId;
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
                Action = "ListRepoSyncTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoSyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Indicates whether automatic link is used.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoSyncTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoSyncTaskResponse
        /// </returns>
        public async Task<ListRepoSyncTaskResponse> ListRepoSyncTaskWithOptionsAsync(ListRepoSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncRecordId))
            {
                query["SyncRecordId"] = request.SyncRecordId;
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
                Action = "ListRepoSyncTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoSyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Indicates whether automatic link is used.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoSyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoSyncTaskResponse
        /// </returns>
        public ListRepoSyncTaskResponse ListRepoSyncTask(ListRepoSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoSyncTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Indicates whether automatic link is used.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoSyncTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoSyncTaskResponse
        /// </returns>
        public async Task<ListRepoSyncTaskResponse> ListRepoSyncTaskAsync(ListRepoSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoSyncTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image tags in a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoTagResponse
        /// </returns>
        public ListRepoTagResponse ListRepoTagWithOptions(ListRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListRepoTag",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image tags in a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoTagResponse
        /// </returns>
        public async Task<ListRepoTagResponse> ListRepoTagWithOptionsAsync(ListRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListRepoTag",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image tags in a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoTagRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoTagResponse
        /// </returns>
        public ListRepoTagResponse ListRepoTag(ListRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image tags in a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoTagRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoTagResponse
        /// </returns>
        public async Task<ListRepoTagResponse> ListRepoTagAsync(ListRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of a security scan that is created for an image tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoTagScanResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoTagScanResultResponse
        /// </returns>
        public ListRepoTagScanResultResponse ListRepoTagScanResultWithOptions(ListRepoTagScanResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanTaskId))
            {
                query["ScanTaskId"] = request.ScanTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanType))
            {
                query["ScanType"] = request.ScanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulQueryKey))
            {
                query["VulQueryKey"] = request.VulQueryKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepoTagScanResult",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoTagScanResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of a security scan that is created for an image tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoTagScanResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoTagScanResultResponse
        /// </returns>
        public async Task<ListRepoTagScanResultResponse> ListRepoTagScanResultWithOptionsAsync(ListRepoTagScanResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValue))
            {
                query["FilterValue"] = request.FilterValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanTaskId))
            {
                query["ScanTaskId"] = request.ScanTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanType))
            {
                query["ScanType"] = request.ScanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Severity))
            {
                query["Severity"] = request.Severity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulQueryKey))
            {
                query["VulQueryKey"] = request.VulQueryKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepoTagScanResult",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoTagScanResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of a security scan that is created for an image tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoTagScanResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoTagScanResultResponse
        /// </returns>
        public ListRepoTagScanResultResponse ListRepoTagScanResult(ListRepoTagScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoTagScanResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of a security scan that is created for an image tag.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoTagScanResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoTagScanResultResponse
        /// </returns>
        public async Task<ListRepoTagScanResultResponse> ListRepoTagScanResultAsync(ListRepoTagScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoTagScanResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the triggers of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoTriggerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoTriggerResponse
        /// </returns>
        public ListRepoTriggerResponse ListRepoTriggerWithOptions(ListRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListRepoTrigger",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoTriggerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the triggers of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoTriggerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepoTriggerResponse
        /// </returns>
        public async Task<ListRepoTriggerResponse> ListRepoTriggerWithOptionsAsync(ListRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListRepoTrigger",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepoTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the triggers of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoTriggerRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoTriggerResponse
        /// </returns>
        public ListRepoTriggerResponse ListRepoTrigger(ListRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoTriggerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the triggers of a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepoTriggerRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepoTriggerResponse
        /// </returns>
        public async Task<ListRepoTriggerResponse> ListRepoTriggerAsync(ListRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoTriggerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image repositories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepositoryResponse
        /// </returns>
        public ListRepositoryResponse ListRepositoryWithOptions(ListRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoStatus))
            {
                query["RepoStatus"] = request.RepoStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image repositories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRepositoryResponse
        /// </returns>
        public async Task<ListRepositoryResponse> ListRepositoryWithOptionsAsync(ListRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoStatus))
            {
                query["RepoStatus"] = request.RepoStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image repositories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepositoryResponse
        /// </returns>
        public ListRepositoryResponse ListRepository(ListRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepositoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries image repositories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRepositoryResponse
        /// </returns>
        public async Task<ListRepositoryResponse> ListRepositoryAsync(ListRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepositoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the baseline risks of a scan task by page.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, use a Security Center scan engine to scan the image.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScanBaselineByTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScanBaselineByTaskResponse
        /// </returns>
        public ListScanBaselineByTaskResponse ListScanBaselineByTaskWithOptions(ListScanBaselineByTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScanBaselineByTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScanBaselineByTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the baseline risks of a scan task by page.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, use a Security Center scan engine to scan the image.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScanBaselineByTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScanBaselineByTaskResponse
        /// </returns>
        public async Task<ListScanBaselineByTaskResponse> ListScanBaselineByTaskWithOptionsAsync(ListScanBaselineByTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScanBaselineByTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScanBaselineByTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the baseline risks of a scan task by page.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, use a Security Center scan engine to scan the image.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScanBaselineByTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScanBaselineByTaskResponse
        /// </returns>
        public ListScanBaselineByTaskResponse ListScanBaselineByTask(ListScanBaselineByTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScanBaselineByTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the baseline risks of a scan task by page.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, use a Security Center scan engine to scan the image.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScanBaselineByTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScanBaselineByTaskResponse
        /// </returns>
        public async Task<ListScanBaselineByTaskResponse> ListScanBaselineByTaskAsync(ListScanBaselineByTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScanBaselineByTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the malicious files of a scan task by page.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, use a Security Center scan engine to scan the image.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScanMaliciousFileByTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScanMaliciousFileByTaskResponse
        /// </returns>
        public ListScanMaliciousFileByTaskResponse ListScanMaliciousFileByTaskWithOptions(ListScanMaliciousFileByTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScanMaliciousFileByTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScanMaliciousFileByTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the malicious files of a scan task by page.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, use a Security Center scan engine to scan the image.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScanMaliciousFileByTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScanMaliciousFileByTaskResponse
        /// </returns>
        public async Task<ListScanMaliciousFileByTaskResponse> ListScanMaliciousFileByTaskWithOptionsAsync(ListScanMaliciousFileByTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScanMaliciousFileByTask",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScanMaliciousFileByTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the malicious files of a scan task by page.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, use a Security Center scan engine to scan the image.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScanMaliciousFileByTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScanMaliciousFileByTaskResponse
        /// </returns>
        public ListScanMaliciousFileByTaskResponse ListScanMaliciousFileByTask(ListScanMaliciousFileByTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScanMaliciousFileByTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the malicious files of a scan task by page.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, use a Security Center scan engine to scan the image.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScanMaliciousFileByTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScanMaliciousFileByTaskResponse
        /// </returns>
        public async Task<ListScanMaliciousFileByTaskResponse> ListScanMaliciousFileByTaskAsync(ListScanMaliciousFileByTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScanMaliciousFileByTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to cloud resources. Instance resources are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
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
                Action = "ListTagResources",
                Version = "2018-12-01",
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
        /// <para>Queries the tags that are added to cloud resources. Instance resources are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
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
                Action = "ListTagResources",
                Version = "2018-12-01",
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
        /// <para>Queries the tags that are added to cloud resources. Instance resources are supported.</para>
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
        /// <para>Queries the tags that are added to cloud resources. Instance resources are supported.</para>
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
        /// <para>Resets the logon password of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetLoginPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetLoginPasswordResponse
        /// </returns>
        public ResetLoginPasswordResponse ResetLoginPasswordWithOptions(ResetLoginPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetLoginPassword",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetLoginPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the logon password of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetLoginPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetLoginPasswordResponse
        /// </returns>
        public async Task<ResetLoginPasswordResponse> ResetLoginPasswordWithOptionsAsync(ResetLoginPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetLoginPassword",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetLoginPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the logon password of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetLoginPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetLoginPasswordResponse
        /// </returns>
        public ResetLoginPasswordResponse ResetLoginPassword(ResetLoginPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetLoginPasswordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the logon password of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetLoginPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetLoginPasswordResponse
        /// </returns>
        public async Task<ResetLoginPasswordResponse> ResetLoginPasswordAsync(ResetLoginPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetLoginPasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to resources. Instance resources are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "TagResources",
                Version = "2018-12-01",
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
        /// <para>Adds tags to resources. Instance resources are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "TagResources",
                Version = "2018-12-01",
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
        /// <para>Adds tags to resources. Instance resources are supported.</para>
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
        /// <para>Adds tags to resources. Instance resources are supported.</para>
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
        /// <para>Removes tags from resources. Instance resources are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2018-12-01",
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
        /// <para>Removes tags from resources. Instance resources are supported.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2018-12-01",
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
        /// <para>Removes tags from resources. Instance resources are supported.</para>
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
        /// <para>Removes tags from resources. Instance resources are supported.</para>
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
        /// <para>Updates a lifecycle management rule of an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateArtifactLifecycleRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateArtifactLifecycleRuleResponse
        /// </returns>
        public UpdateArtifactLifecycleRuleResponse UpdateArtifactLifecycleRuleWithOptions(UpdateArtifactLifecycleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Auto))
            {
                query["Auto"] = request.Auto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDeleteTag))
            {
                query["EnableDeleteTag"] = request.EnableDeleteTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionTagCount))
            {
                query["RetentionTagCount"] = request.RetentionTagCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["ScheduleTime"] = request.ScheduleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRegexp))
            {
                query["TagRegexp"] = request.TagRegexp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateArtifactLifecycleRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateArtifactLifecycleRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a lifecycle management rule of an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateArtifactLifecycleRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateArtifactLifecycleRuleResponse
        /// </returns>
        public async Task<UpdateArtifactLifecycleRuleResponse> UpdateArtifactLifecycleRuleWithOptionsAsync(UpdateArtifactLifecycleRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Auto))
            {
                query["Auto"] = request.Auto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDeleteTag))
            {
                query["EnableDeleteTag"] = request.EnableDeleteTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionTagCount))
            {
                query["RetentionTagCount"] = request.RetentionTagCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["ScheduleTime"] = request.ScheduleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRegexp))
            {
                query["TagRegexp"] = request.TagRegexp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateArtifactLifecycleRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateArtifactLifecycleRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a lifecycle management rule of an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateArtifactLifecycleRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateArtifactLifecycleRuleResponse
        /// </returns>
        public UpdateArtifactLifecycleRuleResponse UpdateArtifactLifecycleRule(UpdateArtifactLifecycleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateArtifactLifecycleRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a lifecycle management rule of an artifact.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateArtifactLifecycleRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateArtifactLifecycleRuleResponse
        /// </returns>
        public async Task<UpdateArtifactLifecycleRuleResponse> UpdateArtifactLifecycleRuleAsync(UpdateArtifactLifecycleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateArtifactLifecycleRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateArtifactSubscriptionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateArtifactSubscriptionRuleResponse
        /// </returns>
        public UpdateArtifactSubscriptionRuleResponse UpdateArtifactSubscriptionRuleWithOptions(UpdateArtifactSubscriptionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accelerate))
            {
                query["Accelerate"] = request.Accelerate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Override))
            {
                query["Override"] = request.Override;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceNamespaceName))
            {
                query["SourceNamespaceName"] = request.SourceNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProvider))
            {
                query["SourceProvider"] = request.SourceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRepoName))
            {
                query["SourceRepoName"] = request.SourceRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCount))
            {
                query["TagCount"] = request.TagCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRegexp))
            {
                query["TagRegexp"] = request.TagRegexp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateArtifactSubscriptionRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateArtifactSubscriptionRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateArtifactSubscriptionRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateArtifactSubscriptionRuleResponse
        /// </returns>
        public async Task<UpdateArtifactSubscriptionRuleResponse> UpdateArtifactSubscriptionRuleWithOptionsAsync(UpdateArtifactSubscriptionRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accelerate))
            {
                query["Accelerate"] = request.Accelerate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Override))
            {
                query["Override"] = request.Override;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceNamespaceName))
            {
                query["SourceNamespaceName"] = request.SourceNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProvider))
            {
                query["SourceProvider"] = request.SourceProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRepoName))
            {
                query["SourceRepoName"] = request.SourceRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCount))
            {
                query["TagCount"] = request.TagCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRegexp))
            {
                query["TagRegexp"] = request.TagRegexp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateArtifactSubscriptionRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateArtifactSubscriptionRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateArtifactSubscriptionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateArtifactSubscriptionRuleResponse
        /// </returns>
        public UpdateArtifactSubscriptionRuleResponse UpdateArtifactSubscriptionRule(UpdateArtifactSubscriptionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateArtifactSubscriptionRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an artifact subscription rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateArtifactSubscriptionRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateArtifactSubscriptionRuleResponse
        /// </returns>
        public async Task<UpdateArtifactSubscriptionRuleResponse> UpdateArtifactSubscriptionRuleAsync(UpdateArtifactSubscriptionRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateArtifactSubscriptionRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a delivery chain, such as the node execution sequence of the delivery chain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateChainResponse
        /// </returns>
        public UpdateChainResponse UpdateChainWithOptions(UpdateChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainConfig))
            {
                query["ChainConfig"] = request.ChainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainId))
            {
                query["ChainId"] = request.ChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeExclude))
            {
                query["ScopeExclude"] = request.ScopeExclude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateChain",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateChainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a delivery chain, such as the node execution sequence of the delivery chain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateChainResponse
        /// </returns>
        public async Task<UpdateChainResponse> UpdateChainWithOptionsAsync(UpdateChainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainConfig))
            {
                query["ChainConfig"] = request.ChainConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChainId))
            {
                query["ChainId"] = request.ChainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeExclude))
            {
                query["ScopeExclude"] = request.ScopeExclude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateChain",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateChainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a delivery chain, such as the node execution sequence of the delivery chain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChainRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateChainResponse
        /// </returns>
        public UpdateChainResponse UpdateChain(UpdateChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateChainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a delivery chain, such as the node execution sequence of the delivery chain.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChainRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateChainResponse
        /// </returns>
        public async Task<UpdateChainResponse> UpdateChainAsync(UpdateChainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateChainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a chart namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChartNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateChartNamespaceResponse
        /// </returns>
        public UpdateChartNamespaceResponse UpdateChartNamespaceWithOptions(UpdateChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateRepo))
            {
                query["AutoCreateRepo"] = request.AutoCreateRepo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRepoType))
            {
                query["DefaultRepoType"] = request.DefaultRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateChartNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateChartNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a chart namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChartNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateChartNamespaceResponse
        /// </returns>
        public async Task<UpdateChartNamespaceResponse> UpdateChartNamespaceWithOptionsAsync(UpdateChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateRepo))
            {
                query["AutoCreateRepo"] = request.AutoCreateRepo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRepoType))
            {
                query["DefaultRepoType"] = request.DefaultRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateChartNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateChartNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a chart namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChartNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateChartNamespaceResponse
        /// </returns>
        public UpdateChartNamespaceResponse UpdateChartNamespace(UpdateChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateChartNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a chart namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChartNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateChartNamespaceResponse
        /// </returns>
        public async Task<UpdateChartNamespaceResponse> UpdateChartNamespaceAsync(UpdateChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateChartNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a chart repository of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChartRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateChartRepositoryResponse
        /// </returns>
        public UpdateChartRepositoryResponse UpdateChartRepositoryWithOptions(UpdateChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoType))
            {
                query["RepoType"] = request.RepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                query["Summary"] = request.Summary;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateChartRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateChartRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a chart repository of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChartRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateChartRepositoryResponse
        /// </returns>
        public async Task<UpdateChartRepositoryResponse> UpdateChartRepositoryWithOptionsAsync(UpdateChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoType))
            {
                query["RepoType"] = request.RepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                query["Summary"] = request.Summary;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateChartRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateChartRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a chart repository of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChartRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateChartRepositoryResponse
        /// </returns>
        public UpdateChartRepositoryResponse UpdateChartRepository(UpdateChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateChartRepositoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a chart repository of a Container Registry instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateChartRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateChartRepositoryResponse
        /// </returns>
        public async Task<UpdateChartRepositoryResponse> UpdateChartRepositoryAsync(UpdateChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateChartRepositoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an event notification rule.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateEventCenterRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventCenterRuleResponse
        /// </returns>
        public UpdateEventCenterRuleResponse UpdateEventCenterRuleWithOptions(UpdateEventCenterRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEventCenterRuleShrinkRequest request = new UpdateEventCenterRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Namespaces))
            {
                request.NamespacesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Namespaces, "Namespaces", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepoNames))
            {
                request.RepoNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepoNames, "RepoNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventChannel))
            {
                query["EventChannel"] = request.EventChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventConfig))
            {
                query["EventConfig"] = request.EventConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventScope))
            {
                query["EventScope"] = request.EventScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespacesShrink))
            {
                query["Namespaces"] = request.NamespacesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamesShrink))
            {
                query["RepoNames"] = request.RepoNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoTagFilterPattern))
            {
                query["RepoTagFilterPattern"] = request.RepoTagFilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventCenterRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventCenterRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an event notification rule.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateEventCenterRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventCenterRuleResponse
        /// </returns>
        public async Task<UpdateEventCenterRuleResponse> UpdateEventCenterRuleWithOptionsAsync(UpdateEventCenterRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEventCenterRuleShrinkRequest request = new UpdateEventCenterRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Namespaces))
            {
                request.NamespacesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Namespaces, "Namespaces", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RepoNames))
            {
                request.RepoNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RepoNames, "RepoNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventChannel))
            {
                query["EventChannel"] = request.EventChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventConfig))
            {
                query["EventConfig"] = request.EventConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventScope))
            {
                query["EventScope"] = request.EventScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespacesShrink))
            {
                query["Namespaces"] = request.NamespacesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamesShrink))
            {
                query["RepoNames"] = request.RepoNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoTagFilterPattern))
            {
                query["RepoTagFilterPattern"] = request.RepoTagFilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventCenterRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventCenterRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an event notification rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEventCenterRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventCenterRuleResponse
        /// </returns>
        public UpdateEventCenterRuleResponse UpdateEventCenterRule(UpdateEventCenterRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEventCenterRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an event notification rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEventCenterRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEventCenterRuleResponse
        /// </returns>
        public async Task<UpdateEventCenterRuleResponse> UpdateEventCenterRuleAsync(UpdateEventCenterRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEventCenterRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of an instance endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceEndpointStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceEndpointStatusResponse
        /// </returns>
        public UpdateInstanceEndpointStatusResponse UpdateInstanceEndpointStatusWithOptions(UpdateInstanceEndpointStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointType))
            {
                query["EndpointType"] = request.EndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceEndpointStatus",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceEndpointStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of an instance endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceEndpointStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceEndpointStatusResponse
        /// </returns>
        public async Task<UpdateInstanceEndpointStatusResponse> UpdateInstanceEndpointStatusWithOptionsAsync(UpdateInstanceEndpointStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointType))
            {
                query["EndpointType"] = request.EndpointType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleName))
            {
                query["ModuleName"] = request.ModuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceEndpointStatus",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceEndpointStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of an instance endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceEndpointStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceEndpointStatusResponse
        /// </returns>
        public UpdateInstanceEndpointStatusResponse UpdateInstanceEndpointStatus(UpdateInstanceEndpointStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceEndpointStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the status of an instance endpoint.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceEndpointStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceEndpointStatusResponse
        /// </returns>
        public async Task<UpdateInstanceEndpointStatusResponse> UpdateInstanceEndpointStatusAsync(UpdateInstanceEndpointStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceEndpointStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceResponse
        /// </returns>
        public UpdateNamespaceResponse UpdateNamespaceWithOptions(UpdateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateRepo))
            {
                query["AutoCreateRepo"] = request.AutoCreateRepo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRepoType))
            {
                query["DefaultRepoType"] = request.DefaultRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceResponse
        /// </returns>
        public async Task<UpdateNamespaceResponse> UpdateNamespaceWithOptionsAsync(UpdateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateRepo))
            {
                query["AutoCreateRepo"] = request.AutoCreateRepo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRepoType))
            {
                query["DefaultRepoType"] = request.DefaultRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespace",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceResponse
        /// </returns>
        public UpdateNamespaceResponse UpdateNamespace(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNamespaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceResponse
        /// </returns>
        public async Task<UpdateNamespaceResponse> UpdateNamespaceAsync(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNamespaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an image building rule for a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepoBuildRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepoBuildRuleResponse
        /// </returns>
        public UpdateRepoBuildRuleResponse UpdateRepoBuildRuleWithOptions(UpdateRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildArgs))
            {
                query["BuildArgs"] = request.BuildArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRuleId))
            {
                query["BuildRuleId"] = request.BuildRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DockerfileLocation))
            {
                query["DockerfileLocation"] = request.DockerfileLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DockerfileName))
            {
                query["DockerfileName"] = request.DockerfileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTag))
            {
                query["ImageTag"] = request.ImageTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platforms))
            {
                query["Platforms"] = request.Platforms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushName))
            {
                query["PushName"] = request.PushName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
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
                Action = "UpdateRepoBuildRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepoBuildRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an image building rule for a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepoBuildRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepoBuildRuleResponse
        /// </returns>
        public async Task<UpdateRepoBuildRuleResponse> UpdateRepoBuildRuleWithOptionsAsync(UpdateRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildArgs))
            {
                query["BuildArgs"] = request.BuildArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildRuleId))
            {
                query["BuildRuleId"] = request.BuildRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DockerfileLocation))
            {
                query["DockerfileLocation"] = request.DockerfileLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DockerfileName))
            {
                query["DockerfileName"] = request.DockerfileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTag))
            {
                query["ImageTag"] = request.ImageTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platforms))
            {
                query["Platforms"] = request.Platforms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushName))
            {
                query["PushName"] = request.PushName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
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
                Action = "UpdateRepoBuildRule",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepoBuildRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an image building rule for a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepoBuildRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepoBuildRuleResponse
        /// </returns>
        public UpdateRepoBuildRuleResponse UpdateRepoBuildRule(UpdateRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRepoBuildRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an image building rule for a repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepoBuildRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepoBuildRuleResponse
        /// </returns>
        public async Task<UpdateRepoBuildRuleResponse> UpdateRepoBuildRuleAsync(UpdateRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRepoBuildRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the URL of the source code repository that is bound to an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepoSourceCodeRepoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepoSourceCodeRepoResponse
        /// </returns>
        public UpdateRepoSourceCodeRepoResponse UpdateRepoSourceCodeRepoWithOptions(UpdateRepoSourceCodeRepoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoBuild))
            {
                query["AutoBuild"] = request.AutoBuild;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoId))
            {
                query["CodeRepoId"] = request.CodeRepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoName))
            {
                query["CodeRepoName"] = request.CodeRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoNamespaceName))
            {
                query["CodeRepoNamespaceName"] = request.CodeRepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoType))
            {
                query["CodeRepoType"] = request.CodeRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableCacheBuild))
            {
                query["DisableCacheBuild"] = request.DisableCacheBuild;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverseaBuild))
            {
                query["OverseaBuild"] = request.OverseaBuild;
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
                Action = "UpdateRepoSourceCodeRepo",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepoSourceCodeRepoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the URL of the source code repository that is bound to an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepoSourceCodeRepoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepoSourceCodeRepoResponse
        /// </returns>
        public async Task<UpdateRepoSourceCodeRepoResponse> UpdateRepoSourceCodeRepoWithOptionsAsync(UpdateRepoSourceCodeRepoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoBuild))
            {
                query["AutoBuild"] = request.AutoBuild;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoId))
            {
                query["CodeRepoId"] = request.CodeRepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoName))
            {
                query["CodeRepoName"] = request.CodeRepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoNamespaceName))
            {
                query["CodeRepoNamespaceName"] = request.CodeRepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeRepoType))
            {
                query["CodeRepoType"] = request.CodeRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableCacheBuild))
            {
                query["DisableCacheBuild"] = request.DisableCacheBuild;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverseaBuild))
            {
                query["OverseaBuild"] = request.OverseaBuild;
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
                Action = "UpdateRepoSourceCodeRepo",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepoSourceCodeRepoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the URL of the source code repository that is bound to an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepoSourceCodeRepoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepoSourceCodeRepoResponse
        /// </returns>
        public UpdateRepoSourceCodeRepoResponse UpdateRepoSourceCodeRepo(UpdateRepoSourceCodeRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRepoSourceCodeRepoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the URL of the source code repository that is bound to an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepoSourceCodeRepoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepoSourceCodeRepoResponse
        /// </returns>
        public async Task<UpdateRepoSourceCodeRepoResponse> UpdateRepoSourceCodeRepoAsync(UpdateRepoSourceCodeRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRepoSourceCodeRepoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a trigger of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepoTriggerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepoTriggerResponse
        /// </returns>
        public UpdateRepoTriggerResponse UpdateRepoTriggerWithOptions(UpdateRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerId))
            {
                query["TriggerId"] = request.TriggerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerName))
            {
                query["TriggerName"] = request.TriggerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerTag))
            {
                query["TriggerTag"] = request.TriggerTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                query["TriggerType"] = request.TriggerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerUrl))
            {
                query["TriggerUrl"] = request.TriggerUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepoTrigger",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepoTriggerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a trigger of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepoTriggerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepoTriggerResponse
        /// </returns>
        public async Task<UpdateRepoTriggerResponse> UpdateRepoTriggerWithOptionsAsync(UpdateRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerId))
            {
                query["TriggerId"] = request.TriggerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerName))
            {
                query["TriggerName"] = request.TriggerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerTag))
            {
                query["TriggerTag"] = request.TriggerTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                query["TriggerType"] = request.TriggerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerUrl))
            {
                query["TriggerUrl"] = request.TriggerUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepoTrigger",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepoTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a trigger of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepoTriggerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepoTriggerResponse
        /// </returns>
        public UpdateRepoTriggerResponse UpdateRepoTrigger(UpdateRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRepoTriggerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a trigger of an image repository.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepoTriggerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepoTriggerResponse
        /// </returns>
        public async Task<UpdateRepoTriggerResponse> UpdateRepoTriggerAsync(UpdateRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRepoTriggerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the request.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepositoryResponse
        /// </returns>
        public UpdateRepositoryResponse UpdateRepositoryWithOptions(UpdateRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                query["Detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoType))
            {
                query["RepoType"] = request.RepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                query["Summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagImmutability))
            {
                query["TagImmutability"] = request.TagImmutability;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepositoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the request.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepositoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepositoryResponse
        /// </returns>
        public async Task<UpdateRepositoryResponse> UpdateRepositoryWithOptionsAsync(UpdateRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                query["Detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoId))
            {
                query["RepoId"] = request.RepoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoName))
            {
                query["RepoName"] = request.RepoName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoNamespaceName))
            {
                query["RepoNamespaceName"] = request.RepoNamespaceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoType))
            {
                query["RepoType"] = request.RepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Summary))
            {
                query["Summary"] = request.Summary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagImmutability))
            {
                query["TagImmutability"] = request.TagImmutability;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepository",
                Version = "2018-12-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the request.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepositoryResponse
        /// </returns>
        public UpdateRepositoryResponse UpdateRepository(UpdateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRepositoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The ID of the request.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRepositoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRepositoryResponse
        /// </returns>
        public async Task<UpdateRepositoryResponse> UpdateRepositoryAsync(UpdateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRepositoryWithOptionsAsync(request, runtime);
        }

    }
}
