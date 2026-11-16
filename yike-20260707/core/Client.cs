// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Yike20260707.Models;

namespace AlibabaCloud.SDK.Yike20260707
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "Yike";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("yike", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Adds members to a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Adds users under the same Alibaba Cloud account to a specified project in the default workspace of the Alibaba Cloud account, and grants the Edit permission by default. ProjectId specifies the project ID. YikeUserIds specifies a comma-separated list of Yike user IDs, which are not Alibaba Cloud UIDs. Currently, only the default workspace of the Alibaba Cloud account is supported, and projects in newly created workspaces are not supported. This operation follows the behavior of the original member API operation: adding an existing member resets the project permissions. Regular members are assigned the Edit permission, and SuperAdmins of the default workspace retain the Manage permission. Only Alibaba Cloud accounts that have activated ProductionOpenAPI are supported. Default Alibaba Cloud account projects (pd_Alibaba Cloud account ID) are not supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddProjectMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddProjectMembersResponse
        /// </returns>
        public AddProjectMembersResponse AddProjectMembersWithOptions(AddProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YikeUserIds))
            {
                query["YikeUserIds"] = request.YikeUserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddProjectMembers",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddProjectMembersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds members to a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Adds users under the same Alibaba Cloud account to a specified project in the default workspace of the Alibaba Cloud account, and grants the Edit permission by default. ProjectId specifies the project ID. YikeUserIds specifies a comma-separated list of Yike user IDs, which are not Alibaba Cloud UIDs. Currently, only the default workspace of the Alibaba Cloud account is supported, and projects in newly created workspaces are not supported. This operation follows the behavior of the original member API operation: adding an existing member resets the project permissions. Regular members are assigned the Edit permission, and SuperAdmins of the default workspace retain the Manage permission. Only Alibaba Cloud accounts that have activated ProductionOpenAPI are supported. Default Alibaba Cloud account projects (pd_Alibaba Cloud account ID) are not supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddProjectMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddProjectMembersResponse
        /// </returns>
        public async Task<AddProjectMembersResponse> AddProjectMembersWithOptionsAsync(AddProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YikeUserIds))
            {
                query["YikeUserIds"] = request.YikeUserIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddProjectMembers",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddProjectMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds members to a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Adds users under the same Alibaba Cloud account to a specified project in the default workspace of the Alibaba Cloud account, and grants the Edit permission by default. ProjectId specifies the project ID. YikeUserIds specifies a comma-separated list of Yike user IDs, which are not Alibaba Cloud UIDs. Currently, only the default workspace of the Alibaba Cloud account is supported, and projects in newly created workspaces are not supported. This operation follows the behavior of the original member API operation: adding an existing member resets the project permissions. Regular members are assigned the Edit permission, and SuperAdmins of the default workspace retain the Manage permission. Only Alibaba Cloud accounts that have activated ProductionOpenAPI are supported. Default Alibaba Cloud account projects (pd_Alibaba Cloud account ID) are not supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddProjectMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddProjectMembersResponse
        /// </returns>
        public AddProjectMembersResponse AddProjectMembers(AddProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddProjectMembersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds members to a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Adds users under the same Alibaba Cloud account to a specified project in the default workspace of the Alibaba Cloud account, and grants the Edit permission by default. ProjectId specifies the project ID. YikeUserIds specifies a comma-separated list of Yike user IDs, which are not Alibaba Cloud UIDs. Currently, only the default workspace of the Alibaba Cloud account is supported, and projects in newly created workspaces are not supported. This operation follows the behavior of the original member API operation: adding an existing member resets the project permissions. Regular members are assigned the Edit permission, and SuperAdmins of the default workspace retain the Manage permission. Only Alibaba Cloud accounts that have activated ProductionOpenAPI are supported. Default Alibaba Cloud account projects (pd_Alibaba Cloud account ID) are not supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddProjectMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// AddProjectMembersResponse
        /// </returns>
        public async Task<AddProjectMembersResponse> AddProjectMembersAsync(AddProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddProjectMembersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information of multiple media assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchGetMediasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMediasResponse
        /// </returns>
        public BatchGetMediasResponse BatchGetMediasWithOptions(BatchGetMediasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizConfig))
            {
                query["BizConfig"] = request.BizConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnDynamicMeta))
            {
                query["ReturnDynamicMeta"] = request.ReturnDynamicMeta;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetMedias",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetMediasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information of multiple media assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchGetMediasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMediasResponse
        /// </returns>
        public async Task<BatchGetMediasResponse> BatchGetMediasWithOptionsAsync(BatchGetMediasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizConfig))
            {
                query["BizConfig"] = request.BizConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnDynamicMeta))
            {
                query["ReturnDynamicMeta"] = request.ReturnDynamicMeta;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetMedias",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetMediasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information of multiple media assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchGetMediasRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMediasResponse
        /// </returns>
        public BatchGetMediasResponse BatchGetMedias(BatchGetMediasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetMediasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the information of multiple media assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchGetMediasRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetMediasResponse
        /// </returns>
        public async Task<BatchGetMediasResponse> BatchGetMediasAsync(BatchGetMediasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetMediasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries video character replacement jobs in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status and results of video character replacement jobs in batches. JobIds is a comma-separated string of job IDs. The response includes a JobList. The input parameters for each job are located in the AppInputConfig field. For the single query operation GetVideoCharacterReplaceJob, the corresponding field is AppParams. When the Status is Finished, you can retrieve the output media assets from Result.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchGetVideoCharacterReplaceJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetVideoCharacterReplaceJobsResponse
        /// </returns>
        public BatchGetVideoCharacterReplaceJobsResponse BatchGetVideoCharacterReplaceJobsWithOptions(BatchGetVideoCharacterReplaceJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetVideoCharacterReplaceJobs",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetVideoCharacterReplaceJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries video character replacement jobs in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status and results of video character replacement jobs in batches. JobIds is a comma-separated string of job IDs. The response includes a JobList. The input parameters for each job are located in the AppInputConfig field. For the single query operation GetVideoCharacterReplaceJob, the corresponding field is AppParams. When the Status is Finished, you can retrieve the output media assets from Result.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchGetVideoCharacterReplaceJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGetVideoCharacterReplaceJobsResponse
        /// </returns>
        public async Task<BatchGetVideoCharacterReplaceJobsResponse> BatchGetVideoCharacterReplaceJobsWithOptionsAsync(BatchGetVideoCharacterReplaceJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetVideoCharacterReplaceJobs",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetVideoCharacterReplaceJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries video character replacement jobs in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status and results of video character replacement jobs in batches. JobIds is a comma-separated string of job IDs. The response includes a JobList. The input parameters for each job are located in the AppInputConfig field. For the single query operation GetVideoCharacterReplaceJob, the corresponding field is AppParams. When the Status is Finished, you can retrieve the output media assets from Result.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchGetVideoCharacterReplaceJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetVideoCharacterReplaceJobsResponse
        /// </returns>
        public BatchGetVideoCharacterReplaceJobsResponse BatchGetVideoCharacterReplaceJobs(BatchGetVideoCharacterReplaceJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetVideoCharacterReplaceJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries video character replacement jobs in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status and results of video character replacement jobs in batches. JobIds is a comma-separated string of job IDs. The response includes a JobList. The input parameters for each job are located in the AppInputConfig field. For the single query operation GetVideoCharacterReplaceJob, the corresponding field is AppParams. When the Status is Finished, you can retrieve the output media assets from Result.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchGetVideoCharacterReplaceJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGetVideoCharacterReplaceJobsResponse
        /// </returns>
        public async Task<BatchGetVideoCharacterReplaceJobsResponse> BatchGetVideoCharacterReplaceJobsAsync(BatchGetVideoCharacterReplaceJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetVideoCharacterReplaceJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelGenerationJobResponse
        /// </returns>
        public CancelGenerationJobResponse CancelGenerationJobWithOptions(CancelGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelGenerationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelGenerationJobResponse
        /// </returns>
        public async Task<CancelGenerationJobResponse> CancelGenerationJobWithOptionsAsync(CancelGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelGenerationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelGenerationJobResponse
        /// </returns>
        public CancelGenerationJobResponse CancelGenerationJob(CancelGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelGenerationJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelGenerationJobResponse
        /// </returns>
        public async Task<CancelGenerationJobResponse> CancelGenerationJobAsync(CancelGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelGenerationJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a media asset category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Categories support up to three levels of hierarchy, and each level supports up to 100 subcategories.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAssetCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAssetCategoryResponse
        /// </returns>
        public CreateAssetCategoryResponse CreateAssetCategoryWithOptions(CreateAssetCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAssetCategory",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssetCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a media asset category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Categories support up to three levels of hierarchy, and each level supports up to 100 subcategories.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAssetCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAssetCategoryResponse
        /// </returns>
        public async Task<CreateAssetCategoryResponse> CreateAssetCategoryWithOptionsAsync(CreateAssetCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAssetCategory",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssetCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a media asset category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Categories support up to three levels of hierarchy, and each level supports up to 100 subcategories.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAssetCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAssetCategoryResponse
        /// </returns>
        public CreateAssetCategoryResponse CreateAssetCategory(CreateAssetCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAssetCategoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a media asset category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Categories support up to three levels of hierarchy, and each level supports up to 100 subcategories.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAssetCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAssetCategoryResponse
        /// </returns>
        public async Task<CreateAssetCategoryResponse> CreateAssetCategoryAsync(CreateAssetCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAssetCategoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInfiniteCanvasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInfiniteCanvasResponse
        /// </returns>
        public CreateInfiniteCanvasResponse CreateInfiniteCanvasWithOptions(CreateInfiniteCanvasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                query["CoverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionId))
            {
                query["ProductionId"] = request.ProductionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInfiniteCanvas",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInfiniteCanvasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInfiniteCanvasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInfiniteCanvasResponse
        /// </returns>
        public async Task<CreateInfiniteCanvasResponse> CreateInfiniteCanvasWithOptionsAsync(CreateInfiniteCanvasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                query["CoverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionId))
            {
                query["ProductionId"] = request.ProductionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInfiniteCanvas",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInfiniteCanvasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInfiniteCanvasRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInfiniteCanvasResponse
        /// </returns>
        public CreateInfiniteCanvasResponse CreateInfiniteCanvas(CreateInfiniteCanvasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInfiniteCanvasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInfiniteCanvasRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInfiniteCanvasResponse
        /// </returns>
        public async Task<CreateInfiniteCanvasResponse> CreateInfiniteCanvasAsync(CreateInfiniteCanvasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInfiniteCanvasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a project in a specified workspace and returns the ProjectId. If WorkspaceId is not specified, the default workspace of the current account is used. After the project is created, you can call GetProject to query the details or call ListProjects to list projects.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a project in a specified workspace and returns the ProjectId. If WorkspaceId is not specified, the default workspace of the current account is used. After the project is created, you can call GetProject to query the details or call ListProjects to list projects.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a project in a specified workspace and returns the ProjectId. If WorkspaceId is not specified, the default workspace of the current account is used. After the project is created, you can call GetProject to query the details or call ListProjects to list projects.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a project in a specified workspace and returns the ProjectId. If WorkspaceId is not specified, the default workspace of the current account is used. After the project is created, you can call GetProject to query the details or call ListProjects to list projects.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a studio.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a studio and triggers automatic creation of a default project for the studio. Returns the WorkspaceId and the ProjectId of the default project. You can directly use the ProjectId without creating the default project again.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspaceWithOptions(CreateWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCountLimit))
            {
                query["UserCountLimit"] = request.UserCountLimit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a studio.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a studio and triggers automatic creation of a default project for the studio. Returns the WorkspaceId and the ProjectId of the default project. You can directly use the ProjectId without creating the default project again.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceWithOptionsAsync(CreateWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCountLimit))
            {
                query["UserCountLimit"] = request.UserCountLimit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a studio.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a studio and triggers automatic creation of a default project for the studio. Returns the WorkspaceId and the ProjectId of the default project. You can directly use the ProjectId without creating the default project again.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a studio.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a studio and triggers automatic creation of a default project for the studio. Returns the WorkspaceId and the ProjectId of the default project. You can directly use the ProjectId without creating the default project again.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWorkspaceResponse
        /// </returns>
        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a media asset category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation also deletes its subcategories, including level-2 and level-3 subcategories. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAssetCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAssetCategoryResponse
        /// </returns>
        public DeleteAssetCategoryResponse DeleteAssetCategoryWithOptions(DeleteAssetCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAssetCategory",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssetCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a media asset category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation also deletes its subcategories, including level-2 and level-3 subcategories. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAssetCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAssetCategoryResponse
        /// </returns>
        public async Task<DeleteAssetCategoryResponse> DeleteAssetCategoryWithOptionsAsync(DeleteAssetCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAssetCategory",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssetCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a media asset category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation also deletes its subcategories, including level-2 and level-3 subcategories. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAssetCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAssetCategoryResponse
        /// </returns>
        public DeleteAssetCategoryResponse DeleteAssetCategory(DeleteAssetCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAssetCategoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a media asset category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation also deletes its subcategories, including level-2 and level-3 subcategories. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAssetCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAssetCategoryResponse
        /// </returns>
        public async Task<DeleteAssetCategoryResponse> DeleteAssetCategoryAsync(DeleteAssetCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAssetCategoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInfiniteCanvasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInfiniteCanvasResponse
        /// </returns>
        public DeleteInfiniteCanvasResponse DeleteInfiniteCanvasWithOptions(DeleteInfiniteCanvasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanvasId))
            {
                query["CanvasId"] = request.CanvasId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInfiniteCanvas",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInfiniteCanvasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInfiniteCanvasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInfiniteCanvasResponse
        /// </returns>
        public async Task<DeleteInfiniteCanvasResponse> DeleteInfiniteCanvasWithOptionsAsync(DeleteInfiniteCanvasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanvasId))
            {
                query["CanvasId"] = request.CanvasId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInfiniteCanvas",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInfiniteCanvasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInfiniteCanvasRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInfiniteCanvasResponse
        /// </returns>
        public DeleteInfiniteCanvasResponse DeleteInfiniteCanvas(DeleteInfiniteCanvasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInfiniteCanvasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteInfiniteCanvasRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInfiniteCanvasResponse
        /// </returns>
        public async Task<DeleteInfiniteCanvasResponse> DeleteInfiniteCanvasAsync(DeleteInfiniteCanvasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInfiniteCanvasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes media asset information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMediasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMediasResponse
        /// </returns>
        public DeleteMediasResponse DeleteMediasWithOptions(DeleteMediasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizConfig))
            {
                query["BizConfig"] = request.BizConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePhysicalFiles))
            {
                query["DeletePhysicalFiles"] = request.DeletePhysicalFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURLs))
            {
                query["InputURLs"] = request.InputURLs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMedias",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMediasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes media asset information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMediasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMediasResponse
        /// </returns>
        public async Task<DeleteMediasResponse> DeleteMediasWithOptionsAsync(DeleteMediasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizConfig))
            {
                query["BizConfig"] = request.BizConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePhysicalFiles))
            {
                query["DeletePhysicalFiles"] = request.DeletePhysicalFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURLs))
            {
                query["InputURLs"] = request.InputURLs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMedias",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMediasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes media asset information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMediasRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMediasResponse
        /// </returns>
        public DeleteMediasResponse DeleteMedias(DeleteMediasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMediasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes media asset information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMediasRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMediasResponse
        /// </returns>
        public async Task<DeleteMediasResponse> DeleteMediasAsync(DeleteMediasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMediasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a project by ProjectId. The caller must have project management permissions.
        /// Default projects cannot be deleted. If you attempt to delete a default project, DefaultProductionNotSupported is returned. This operation marks the project as deleted and does not physically delete all assets in the project.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectResponse
        /// </returns>
        public DeleteProjectResponse DeleteProjectWithOptions(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a project by ProjectId. The caller must have project management permissions.
        /// Default projects cannot be deleted. If you attempt to delete a default project, DefaultProductionNotSupported is returned. This operation marks the project as deleted and does not physically delete all assets in the project.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectResponse
        /// </returns>
        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a project by ProjectId. The caller must have project management permissions.
        /// Default projects cannot be deleted. If you attempt to delete a default project, DefaultProductionNotSupported is returned. This operation marks the project as deleted and does not physically delete all assets in the project.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectResponse
        /// </returns>
        public DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a project by ProjectId. The caller must have project management permissions.
        /// Default projects cannot be deleted. If you attempt to delete a default project, DefaultProductionNotSupported is returned. This operation marks the project as deleted and does not physically delete all assets in the project.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectResponse
        /// </returns>
        public async Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the logon token for an enterprise account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice:  The AI generation-related API operations in the current 2026-03-19 API version will be retired soon. Upgrade to the 2026-07-07 API version.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateYikeLoginTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateYikeLoginTokenResponse
        /// </returns>
        public GenerateYikeLoginTokenResponse GenerateYikeLoginTokenWithOptions(GenerateYikeLoginTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateProduction))
            {
                query["AutoCreateProduction"] = request.AutoCreateProduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expires))
            {
                query["Expires"] = request.Expires;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                query["NickName"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionAuth))
            {
                query["ProductionAuth"] = request.ProductionAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserCredit))
            {
                query["SubUserCredit"] = request.SubUserCredit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                query["Tenant"] = request.Tenant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateYikeLoginToken",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateYikeLoginTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the logon token for an enterprise account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice:  The AI generation-related API operations in the current 2026-03-19 API version will be retired soon. Upgrade to the 2026-07-07 API version.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateYikeLoginTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateYikeLoginTokenResponse
        /// </returns>
        public async Task<GenerateYikeLoginTokenResponse> GenerateYikeLoginTokenWithOptionsAsync(GenerateYikeLoginTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateProduction))
            {
                query["AutoCreateProduction"] = request.AutoCreateProduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expires))
            {
                query["Expires"] = request.Expires;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NickName))
            {
                query["NickName"] = request.NickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionAuth))
            {
                query["ProductionAuth"] = request.ProductionAuth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserCredit))
            {
                query["SubUserCredit"] = request.SubUserCredit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tenant))
            {
                query["Tenant"] = request.Tenant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateYikeLoginToken",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateYikeLoginTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the logon token for an enterprise account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice:  The AI generation-related API operations in the current 2026-03-19 API version will be retired soon. Upgrade to the 2026-07-07 API version.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateYikeLoginTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateYikeLoginTokenResponse
        /// </returns>
        public GenerateYikeLoginTokenResponse GenerateYikeLoginToken(GenerateYikeLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateYikeLoginTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the logon token for an enterprise account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Notice:  The AI generation-related API operations in the current 2026-03-19 API version will be retired soon. Upgrade to the 2026-07-07 API version.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateYikeLoginTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateYikeLoginTokenResponse
        /// </returns>
        public async Task<GenerateYikeLoginTokenResponse> GenerateYikeLoginTokenAsync(GenerateYikeLoginTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateYikeLoginTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an asynchronous task of the agent node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentJobResponse
        /// </returns>
        public GetAgentJobResponse GetAgentJobWithOptions(GetAgentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an asynchronous task of the agent node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentJobResponse
        /// </returns>
        public async Task<GetAgentJobResponse> GetAgentJobWithOptionsAsync(GetAgentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAgentJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an asynchronous task of the agent node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentJobResponse
        /// </returns>
        public GetAgentJobResponse GetAgentJob(GetAgentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an asynchronous task of the agent node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentJobResponse
        /// </returns>
        public async Task<GetAgentJobResponse> GetAgentJobAsync(GetAgentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified category and a list of its subcategories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAssetCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAssetCategoryResponse
        /// </returns>
        public GetAssetCategoryResponse GetAssetCategoryWithOptions(GetAssetCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAssetCategory",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAssetCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified category and a list of its subcategories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAssetCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAssetCategoryResponse
        /// </returns>
        public async Task<GetAssetCategoryResponse> GetAssetCategoryWithOptionsAsync(GetAssetCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAssetCategory",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAssetCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified category and a list of its subcategories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAssetCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAssetCategoryResponse
        /// </returns>
        public GetAssetCategoryResponse GetAssetCategory(GetAssetCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAssetCategoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified category and a list of its subcategories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAssetCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAssetCategoryResponse
        /// </returns>
        public async Task<GetAssetCategoryResponse> GetAssetCategoryAsync(GetAssetCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAssetCategoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an image generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageGenerationJobResponse
        /// </returns>
        public GetImageGenerationJobResponse GetImageGenerationJobWithOptions(GetImageGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageGenerationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an image generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageGenerationJobResponse
        /// </returns>
        public async Task<GetImageGenerationJobResponse> GetImageGenerationJobWithOptionsAsync(GetImageGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageGenerationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an image generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageGenerationJobResponse
        /// </returns>
        public GetImageGenerationJobResponse GetImageGenerationJob(GetImageGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageGenerationJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an image generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageGenerationJobResponse
        /// </returns>
        public async Task<GetImageGenerationJobResponse> GetImageGenerationJobAsync(GetImageGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageGenerationJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInfiniteCanvasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInfiniteCanvasResponse
        /// </returns>
        public GetInfiniteCanvasResponse GetInfiniteCanvasWithOptions(GetInfiniteCanvasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanvasId))
            {
                query["CanvasId"] = request.CanvasId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInfiniteCanvas",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInfiniteCanvasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInfiniteCanvasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInfiniteCanvasResponse
        /// </returns>
        public async Task<GetInfiniteCanvasResponse> GetInfiniteCanvasWithOptionsAsync(GetInfiniteCanvasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanvasId))
            {
                query["CanvasId"] = request.CanvasId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInfiniteCanvas",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInfiniteCanvasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInfiniteCanvasRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInfiniteCanvasResponse
        /// </returns>
        public GetInfiniteCanvasResponse GetInfiniteCanvas(GetInfiniteCanvasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInfiniteCanvasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInfiniteCanvasRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInfiniteCanvasResponse
        /// </returns>
        public async Task<GetInfiniteCanvasResponse> GetInfiniteCanvasAsync(GetInfiniteCanvasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInfiniteCanvasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries media assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMediaResponse
        /// </returns>
        public GetMediaResponse GetMediaWithOptions(GetMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizConfig))
            {
                query["BizConfig"] = request.BizConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries media assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMediaResponse
        /// </returns>
        public async Task<GetMediaResponse> GetMediaWithOptionsAsync(GetMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizConfig))
            {
                query["BizConfig"] = request.BizConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries media assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMediaResponse
        /// </returns>
        public GetMediaResponse GetMedia(GetMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries media assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMediaResponse
        /// </returns>
        public async Task<GetMediaResponse> GetMediaAsync(GetMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries media content understanding jobs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaComprehensionJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMediaComprehensionJobResponse
        /// </returns>
        public GetMediaComprehensionJobResponse GetMediaComprehensionJobWithOptions(GetMediaComprehensionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaComprehensionJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaComprehensionJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries media content understanding jobs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaComprehensionJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMediaComprehensionJobResponse
        /// </returns>
        public async Task<GetMediaComprehensionJobResponse> GetMediaComprehensionJobWithOptionsAsync(GetMediaComprehensionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaComprehensionJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaComprehensionJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries media content understanding jobs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaComprehensionJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMediaComprehensionJobResponse
        /// </returns>
        public GetMediaComprehensionJobResponse GetMediaComprehensionJob(GetMediaComprehensionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaComprehensionJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries media content understanding jobs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetMediaComprehensionJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMediaComprehensionJobResponse
        /// </returns>
        public async Task<GetMediaComprehensionJobResponse> GetMediaComprehensionJobAsync(GetMediaComprehensionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaComprehensionJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the basic information of a project and the project permissions of the current caller by ProjectId. The project information is located in the Project object of the response and does not include the project asset list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public GetProjectResponse GetProjectWithOptions(GetProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the basic information of a project and the project permissions of the current caller by ProjectId. The project information is located in the Project object of the response and does not include the project asset list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(GetProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the basic information of a project and the project permissions of the current caller by ProjectId. The project information is located in the Project object of the response and does not include the project asset list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public GetProjectResponse GetProject(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the basic information of a project and the project permissions of the current caller by ProjectId. The project information is located in the Project object of the response and does not include the project asset list.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public async Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a creative script generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRemakeScriptJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRemakeScriptJobResponse
        /// </returns>
        public GetRemakeScriptJobResponse GetRemakeScriptJobWithOptions(GetRemakeScriptJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRemakeScriptJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRemakeScriptJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a creative script generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRemakeScriptJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRemakeScriptJobResponse
        /// </returns>
        public async Task<GetRemakeScriptJobResponse> GetRemakeScriptJobWithOptionsAsync(GetRemakeScriptJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRemakeScriptJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRemakeScriptJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a creative script generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRemakeScriptJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRemakeScriptJobResponse
        /// </returns>
        public GetRemakeScriptJobResponse GetRemakeScriptJob(GetRemakeScriptJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRemakeScriptJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a creative script generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRemakeScriptJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRemakeScriptJobResponse
        /// </returns>
        public async Task<GetRemakeScriptJobResponse> GetRemakeScriptJobAsync(GetRemakeScriptJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRemakeScriptJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a video character replacement task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status and result of a single task by using the JobId returned by the submit operation. When Status is Finished, you can read the output media assets in Result. Executing indicates that the task is still running.
        /// This operation uses AppParams to return the task input parameters. The corresponding field name in the batch query operation is AppInputConfig. The output results are categorized into ImageResult, VideoResult, and AudioResult. Each item contains MediaId and OutputUrl.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoCharacterReplaceJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoCharacterReplaceJobResponse
        /// </returns>
        public GetVideoCharacterReplaceJobResponse GetVideoCharacterReplaceJobWithOptions(GetVideoCharacterReplaceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoCharacterReplaceJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoCharacterReplaceJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a video character replacement task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status and result of a single task by using the JobId returned by the submit operation. When Status is Finished, you can read the output media assets in Result. Executing indicates that the task is still running.
        /// This operation uses AppParams to return the task input parameters. The corresponding field name in the batch query operation is AppInputConfig. The output results are categorized into ImageResult, VideoResult, and AudioResult. Each item contains MediaId and OutputUrl.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoCharacterReplaceJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoCharacterReplaceJobResponse
        /// </returns>
        public async Task<GetVideoCharacterReplaceJobResponse> GetVideoCharacterReplaceJobWithOptionsAsync(GetVideoCharacterReplaceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoCharacterReplaceJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoCharacterReplaceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a video character replacement task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status and result of a single task by using the JobId returned by the submit operation. When Status is Finished, you can read the output media assets in Result. Executing indicates that the task is still running.
        /// This operation uses AppParams to return the task input parameters. The corresponding field name in the batch query operation is AppInputConfig. The output results are categorized into ImageResult, VideoResult, and AudioResult. Each item contains MediaId and OutputUrl.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoCharacterReplaceJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoCharacterReplaceJobResponse
        /// </returns>
        public GetVideoCharacterReplaceJobResponse GetVideoCharacterReplaceJob(GetVideoCharacterReplaceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoCharacterReplaceJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a video character replacement task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status and result of a single task by using the JobId returned by the submit operation. When Status is Finished, you can read the output media assets in Result. Executing indicates that the task is still running.
        /// This operation uses AppParams to return the task input parameters. The corresponding field name in the batch query operation is AppInputConfig. The output results are categorized into ImageResult, VideoResult, and AudioResult. Each item contains MediaId and OutputUrl.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoCharacterReplaceJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoCharacterReplaceJobResponse
        /// </returns>
        public async Task<GetVideoCharacterReplaceJobResponse> GetVideoCharacterReplaceJobAsync(GetVideoCharacterReplaceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoCharacterReplaceJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries video creative generation jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoCreativeGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoCreativeGenerationJobResponse
        /// </returns>
        public GetVideoCreativeGenerationJobResponse GetVideoCreativeGenerationJobWithOptions(GetVideoCreativeGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoCreativeGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoCreativeGenerationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries video creative generation jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoCreativeGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoCreativeGenerationJobResponse
        /// </returns>
        public async Task<GetVideoCreativeGenerationJobResponse> GetVideoCreativeGenerationJobWithOptionsAsync(GetVideoCreativeGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoCreativeGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoCreativeGenerationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries video creative generation jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoCreativeGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoCreativeGenerationJobResponse
        /// </returns>
        public GetVideoCreativeGenerationJobResponse GetVideoCreativeGenerationJob(GetVideoCreativeGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoCreativeGenerationJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries video creative generation jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoCreativeGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoCreativeGenerationJobResponse
        /// </returns>
        public async Task<GetVideoCreativeGenerationJobResponse> GetVideoCreativeGenerationJobAsync(GetVideoCreativeGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoCreativeGenerationJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status, input parameters, and video results of a video text removal job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status, input, parameters, and final results of a video text removal job based on the <c>JobId</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoDetextJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoDetextJobResponse
        /// </returns>
        public GetVideoDetextJobResponse GetVideoDetextJobWithOptions(GetVideoDetextJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoDetextJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoDetextJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status, input parameters, and video results of a video text removal job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status, input, parameters, and final results of a video text removal job based on the <c>JobId</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoDetextJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoDetextJobResponse
        /// </returns>
        public async Task<GetVideoDetextJobResponse> GetVideoDetextJobWithOptionsAsync(GetVideoDetextJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoDetextJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoDetextJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status, input parameters, and video results of a video text removal job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status, input, parameters, and final results of a video text removal job based on the <c>JobId</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoDetextJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoDetextJobResponse
        /// </returns>
        public GetVideoDetextJobResponse GetVideoDetextJob(GetVideoDetextJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoDetextJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status, input parameters, and video results of a video text removal job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status, input, parameters, and final results of a video text removal job based on the <c>JobId</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoDetextJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoDetextJobResponse
        /// </returns>
        public async Task<GetVideoDetextJobResponse> GetVideoDetextJobAsync(GetVideoDetextJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoDetextJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a video generation job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoGenerationJobResponse
        /// </returns>
        public GetVideoGenerationJobResponse GetVideoGenerationJobWithOptions(GetVideoGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoGenerationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a video generation job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoGenerationJobResponse
        /// </returns>
        public async Task<GetVideoGenerationJobResponse> GetVideoGenerationJobWithOptionsAsync(GetVideoGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoGenerationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a video generation job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoGenerationJobResponse
        /// </returns>
        public GetVideoGenerationJobResponse GetVideoGenerationJob(GetVideoGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoGenerationJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a video generation job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoGenerationJobResponse
        /// </returns>
        public async Task<GetVideoGenerationJobResponse> GetVideoGenerationJobAsync(GetVideoGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoGenerationJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a content understanding and creative script generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the task status based on the JobId returned by SubmitVideoRemakeJob. Upon completion, returns the download URLs of the JSON files for the video content understanding results and the creative script. If the task fails, returns ErrorCode and ErrorMessage.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoRemakeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoRemakeJobResponse
        /// </returns>
        public GetVideoRemakeJobResponse GetVideoRemakeJobWithOptions(GetVideoRemakeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoRemakeJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoRemakeJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a content understanding and creative script generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the task status based on the JobId returned by SubmitVideoRemakeJob. Upon completion, returns the download URLs of the JSON files for the video content understanding results and the creative script. If the task fails, returns ErrorCode and ErrorMessage.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoRemakeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoRemakeJobResponse
        /// </returns>
        public async Task<GetVideoRemakeJobResponse> GetVideoRemakeJobWithOptionsAsync(GetVideoRemakeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoRemakeJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoRemakeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a content understanding and creative script generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the task status based on the JobId returned by SubmitVideoRemakeJob. Upon completion, returns the download URLs of the JSON files for the video content understanding results and the creative script. If the task fails, returns ErrorCode and ErrorMessage.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoRemakeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoRemakeJobResponse
        /// </returns>
        public GetVideoRemakeJobResponse GetVideoRemakeJob(GetVideoRemakeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoRemakeJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a content understanding and creative script generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the task status based on the JobId returned by SubmitVideoRemakeJob. Upon completion, returns the download URLs of the JSON files for the video content understanding results and the creative script. If the task fails, returns ErrorCode and ErrorMessage.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoRemakeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoRemakeJobResponse
        /// </returns>
        public async Task<GetVideoRemakeJobResponse> GetVideoRemakeJobAsync(GetVideoRemakeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoRemakeJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video rendering and compositing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoRenderJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoRenderJobResponse
        /// </returns>
        public GetVideoRenderJobResponse GetVideoRenderJobWithOptions(GetVideoRenderJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoRenderJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoRenderJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video rendering and compositing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoRenderJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoRenderJobResponse
        /// </returns>
        public async Task<GetVideoRenderJobResponse> GetVideoRenderJobWithOptionsAsync(GetVideoRenderJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoRenderJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoRenderJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video rendering and compositing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoRenderJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoRenderJobResponse
        /// </returns>
        public GetVideoRenderJobResponse GetVideoRenderJob(GetVideoRenderJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoRenderJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video rendering and compositing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoRenderJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoRenderJobResponse
        /// </returns>
        public async Task<GetVideoRenderJobResponse> GetVideoRenderJobAsync(GetVideoRenderJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoRenderJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status, input parameters, and multilingual outputs of a video translation job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status, input, parameters, and final results of a video translation job based on JobId.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoTranslationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoTranslationJobResponse
        /// </returns>
        public GetVideoTranslationJobResponse GetVideoTranslationJobWithOptions(GetVideoTranslationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoTranslationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoTranslationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status, input parameters, and multilingual outputs of a video translation job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status, input, parameters, and final results of a video translation job based on JobId.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoTranslationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoTranslationJobResponse
        /// </returns>
        public async Task<GetVideoTranslationJobResponse> GetVideoTranslationJobWithOptionsAsync(GetVideoTranslationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoTranslationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoTranslationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status, input parameters, and multilingual outputs of a video translation job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status, input, parameters, and final results of a video translation job based on JobId.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoTranslationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoTranslationJobResponse
        /// </returns>
        public GetVideoTranslationJobResponse GetVideoTranslationJob(GetVideoTranslationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoTranslationJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status, input parameters, and multilingual outputs of a video translation job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status, input, parameters, and final results of a video translation job based on JobId.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetVideoTranslationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoTranslationJobResponse
        /// </returns>
        public async Task<GetVideoTranslationJobResponse> GetVideoTranslationJobAsync(GetVideoTranslationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoTranslationJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the membership plan and credit information of the Yike main account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeAccountCreditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeAccountCreditResponse
        /// </returns>
        public GetYikeAccountCreditResponse GetYikeAccountCreditWithOptions(GetYikeAccountCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeAccountCredit",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeAccountCreditResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the membership plan and credit information of the Yike main account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeAccountCreditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeAccountCreditResponse
        /// </returns>
        public async Task<GetYikeAccountCreditResponse> GetYikeAccountCreditWithOptionsAsync(GetYikeAccountCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeAccountCredit",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeAccountCreditResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the membership plan and credit information of the Yike main account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeAccountCreditRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeAccountCreditResponse
        /// </returns>
        public GetYikeAccountCreditResponse GetYikeAccountCredit(GetYikeAccountCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetYikeAccountCreditWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the membership plan and credit information of the Yike main account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeAccountCreditRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeAccountCreditResponse
        /// </returns>
        public async Task<GetYikeAccountCreditResponse> GetYikeAccountCreditAsync(GetYikeAccountCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetYikeAccountCreditWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the actual credits consumed by a task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeJobCreditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeJobCreditResponse
        /// </returns>
        public GetYikeJobCreditResponse GetYikeJobCreditWithOptions(GetYikeJobCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeJobCredit",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeJobCreditResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the actual credits consumed by a task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeJobCreditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYikeJobCreditResponse
        /// </returns>
        public async Task<GetYikeJobCreditResponse> GetYikeJobCreditWithOptionsAsync(GetYikeJobCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYikeJobCredit",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYikeJobCreditResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the actual credits consumed by a task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeJobCreditRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeJobCreditResponse
        /// </returns>
        public GetYikeJobCreditResponse GetYikeJobCredit(GetYikeJobCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetYikeJobCreditWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the actual credits consumed by a task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYikeJobCreditRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYikeJobCreditResponse
        /// </returns>
        public async Task<GetYikeJobCreditResponse> GetYikeJobCreditAsync(GetYikeJobCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetYikeJobCreditWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports media assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportMediaResponse
        /// </returns>
        public ImportMediaResponse ImportMediaWithOptions(ImportMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizConfig))
            {
                query["BizConfig"] = request.BizConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicMetaData))
            {
                query["DynamicMetaData"] = request.DynamicMetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportSource))
            {
                query["ImportSource"] = request.ImportSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTags))
            {
                query["MediaTags"] = request.MediaTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                query["Overwrite"] = request.Overwrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterConfig))
            {
                query["RegisterConfig"] = request.RegisterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YikeAssetConfig))
            {
                query["YikeAssetConfig"] = request.YikeAssetConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportMediaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports media assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportMediaResponse
        /// </returns>
        public async Task<ImportMediaResponse> ImportMediaWithOptionsAsync(ImportMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizConfig))
            {
                query["BizConfig"] = request.BizConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicMetaData))
            {
                query["DynamicMetaData"] = request.DynamicMetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportSource))
            {
                query["ImportSource"] = request.ImportSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTags))
            {
                query["MediaTags"] = request.MediaTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                query["Overwrite"] = request.Overwrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterConfig))
            {
                query["RegisterConfig"] = request.RegisterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YikeAssetConfig))
            {
                query["YikeAssetConfig"] = request.YikeAssetConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports media assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportMediaResponse
        /// </returns>
        public ImportMediaResponse ImportMedia(ImportMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportMediaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports media assets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API operation queries media content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportMediaResponse
        /// </returns>
        public async Task<ImportMediaResponse> ImportMediaAsync(ImportMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportMediaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a paginated list of categories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAssetCategoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAssetCategoriesResponse
        /// </returns>
        public ListAssetCategoriesResponse ListAssetCategoriesWithOptions(ListAssetCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListAssetCategories",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssetCategoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a paginated list of categories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAssetCategoriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAssetCategoriesResponse
        /// </returns>
        public async Task<ListAssetCategoriesResponse> ListAssetCategoriesWithOptionsAsync(ListAssetCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListAssetCategories",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssetCategoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a paginated list of categories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAssetCategoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAssetCategoriesResponse
        /// </returns>
        public ListAssetCategoriesResponse ListAssetCategories(ListAssetCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAssetCategoriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a paginated list of categories.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAssetCategoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAssetCategoriesResponse
        /// </returns>
        public async Task<ListAssetCategoriesResponse> ListAssetCategoriesAsync(ListAssetCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAssetCategoriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of infinite canvases.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInfiniteCanvasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInfiniteCanvasesResponse
        /// </returns>
        public ListInfiniteCanvasesResponse ListInfiniteCanvasesWithOptions(ListInfiniteCanvasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionId))
            {
                query["ProductionId"] = request.ProductionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInfiniteCanvases",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInfiniteCanvasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of infinite canvases.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInfiniteCanvasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInfiniteCanvasesResponse
        /// </returns>
        public async Task<ListInfiniteCanvasesResponse> ListInfiniteCanvasesWithOptionsAsync(ListInfiniteCanvasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionId))
            {
                query["ProductionId"] = request.ProductionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInfiniteCanvases",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInfiniteCanvasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of infinite canvases.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInfiniteCanvasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInfiniteCanvasesResponse
        /// </returns>
        public ListInfiniteCanvasesResponse ListInfiniteCanvases(ListInfiniteCanvasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInfiniteCanvasesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of infinite canvases.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInfiniteCanvasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInfiniteCanvasesResponse
        /// </returns>
        public async Task<ListInfiniteCanvasesResponse> ListInfiniteCanvasesAsync(ListInfiniteCanvasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInfiniteCanvasesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of projects.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of projects accessible to the current caller. You can use WorkspaceId to filter projects by workspace.
        /// For pagination, specify both PageNo and PageSize with valid positive integers starting from 1. If valid values are not provided for both parameters, the query defaults to page 1 with 10 entries per page. The response returns ProjectList but does not return TotalCount. MaxResults and NextToken are retained for compatibility and are not used for current pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of projects.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of projects accessible to the current caller. You can use WorkspaceId to filter projects by workspace.
        /// For pagination, specify both PageNo and PageSize with valid positive integers starting from 1. If valid values are not provided for both parameters, the query defaults to page 1 with 10 entries per page. The response returns ProjectList but does not return TotalCount. MaxResults and NextToken are retained for compatibility and are not used for current pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of projects.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of projects accessible to the current caller. You can use WorkspaceId to filter projects by workspace.
        /// For pagination, specify both PageNo and PageSize with valid positive integers starting from 1. If valid values are not provided for both parameters, the query defaults to page 1 with 10 entries per page. The response returns ProjectList but does not return TotalCount. MaxResults and NextToken are retained for compatibility and are not used for current pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of projects.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of projects accessible to the current caller. You can use WorkspaceId to filter projects by workspace.
        /// For pagination, specify both PageNo and PageSize with valid positive integers starting from 1. If valid values are not provided for both parameters, the query defaults to page 1 with 10 entries per page. The response returns ProjectList but does not return TotalCount. MaxResults and NextToken are retained for compatibility and are not used for current pagination.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workspaces.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a list of workspaces accessible to the current caller. Pagination is supported by using PageNo and PageSize. The default value of PageNo is 1, and the default value of PageSize is 10. The response includes WorkspaceList and TotalCount. The ID of the default project for a workspace is returned in the DefaultProjectId field.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspacesWithOptions(ListWorkspacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListWorkspaces",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workspaces.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a list of workspaces accessible to the current caller. Pagination is supported by using PageNo and PageSize. The default value of PageNo is 1, and the default value of PageSize is 10. The response includes WorkspaceList and TotalCount. The ID of the default project for a workspace is returned in the DefaultProjectId field.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesWithOptionsAsync(ListWorkspacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListWorkspaces",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workspaces.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a list of workspaces accessible to the current caller. Pagination is supported by using PageNo and PageSize. The default value of PageNo is 1, and the default value of PageSize is 10. The response includes WorkspaceList and TotalCount. The ID of the default project for a workspace is returned in the DefaultProjectId field.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWorkspacesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workspaces.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries a list of workspaces accessible to the current caller. Pagination is supported by using PageNo and PageSize. The default value of PageNo is 1, and the default value of PageSize is 10. The response includes WorkspaceList and TotalCount. The ID of the default project for a workspace is returned in the DefaultProjectId field.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkspacesResponse
        /// </returns>
        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWorkspacesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pre-validates a video character replacement task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Validates the input materials of a specified application before submitting a task. AppParams is a JSON-serialized string. The field names must be consistent with the input definition of the application corresponding to AppId. Image, audio, and video materials must match the input types and be accessible.
        /// If Status is Success, the validation passes and Result is an empty array. If Status is Failed, Result returns the failed parameter Key and ErrorCode for each item. This operation does not create a task. After the validation passes, call SubmitVideoCharacterReplaceJob to submit the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PrecheckVideoCharacterReplaceJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrecheckVideoCharacterReplaceJobResponse
        /// </returns>
        public PrecheckVideoCharacterReplaceJobResponse PrecheckVideoCharacterReplaceJobWithOptions(PrecheckVideoCharacterReplaceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppParams))
            {
                query["AppParams"] = request.AppParams;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrecheckVideoCharacterReplaceJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrecheckVideoCharacterReplaceJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pre-validates a video character replacement task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Validates the input materials of a specified application before submitting a task. AppParams is a JSON-serialized string. The field names must be consistent with the input definition of the application corresponding to AppId. Image, audio, and video materials must match the input types and be accessible.
        /// If Status is Success, the validation passes and Result is an empty array. If Status is Failed, Result returns the failed parameter Key and ErrorCode for each item. This operation does not create a task. After the validation passes, call SubmitVideoCharacterReplaceJob to submit the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PrecheckVideoCharacterReplaceJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrecheckVideoCharacterReplaceJobResponse
        /// </returns>
        public async Task<PrecheckVideoCharacterReplaceJobResponse> PrecheckVideoCharacterReplaceJobWithOptionsAsync(PrecheckVideoCharacterReplaceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppParams))
            {
                query["AppParams"] = request.AppParams;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrecheckVideoCharacterReplaceJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrecheckVideoCharacterReplaceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pre-validates a video character replacement task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Validates the input materials of a specified application before submitting a task. AppParams is a JSON-serialized string. The field names must be consistent with the input definition of the application corresponding to AppId. Image, audio, and video materials must match the input types and be accessible.
        /// If Status is Success, the validation passes and Result is an empty array. If Status is Failed, Result returns the failed parameter Key and ErrorCode for each item. This operation does not create a task. After the validation passes, call SubmitVideoCharacterReplaceJob to submit the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PrecheckVideoCharacterReplaceJobRequest
        /// </param>
        /// 
        /// <returns>
        /// PrecheckVideoCharacterReplaceJobResponse
        /// </returns>
        public PrecheckVideoCharacterReplaceJobResponse PrecheckVideoCharacterReplaceJob(PrecheckVideoCharacterReplaceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PrecheckVideoCharacterReplaceJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pre-validates a video character replacement task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Validates the input materials of a specified application before submitting a task. AppParams is a JSON-serialized string. The field names must be consistent with the input definition of the application corresponding to AppId. Image, audio, and video materials must match the input types and be accessible.
        /// If Status is Success, the validation passes and Result is an empty array. If Status is Failed, Result returns the failed parameter Key and ErrorCode for each item. This operation does not create a task. After the validation passes, call SubmitVideoCharacterReplaceJob to submit the task.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PrecheckVideoCharacterReplaceJobRequest
        /// </param>
        /// 
        /// <returns>
        /// PrecheckVideoCharacterReplaceJobResponse
        /// </returns>
        public async Task<PrecheckVideoCharacterReplaceJobResponse> PrecheckVideoCharacterReplaceJobAsync(PrecheckVideoCharacterReplaceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PrecheckVideoCharacterReplaceJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves media asset information that matches the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchMediaResponse
        /// </returns>
        public SearchMediaResponse SearchMediaWithOptions(SearchMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizConfig))
            {
                query["BizConfig"] = request.BizConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                query["Match"] = request.Match;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScrollToken))
            {
                query["ScrollToken"] = request.ScrollToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMediaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves media asset information that matches the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchMediaResponse
        /// </returns>
        public async Task<SearchMediaResponse> SearchMediaWithOptionsAsync(SearchMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizConfig))
            {
                query["BizConfig"] = request.BizConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Match))
            {
                query["Match"] = request.Match;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScrollToken))
            {
                query["ScrollToken"] = request.ScrollToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves media asset information that matches the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchMediaResponse
        /// </returns>
        public SearchMediaResponse SearchMedia(SearchMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchMediaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves media asset information that matches the specified parameters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchMediaResponse
        /// </returns>
        public async Task<SearchMediaResponse> SearchMediaAsync(SearchMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchMediaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an asynchronous task for an agent node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAgentJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitAgentJobResponse
        /// </returns>
        public SubmitAgentJobResponse SubmitAgentJobWithOptions(SubmitAgentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyUrl))
            {
                query["NotifyUrl"] = request.NotifyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skill))
            {
                query["Skill"] = request.Skill;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAgentJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAgentJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an asynchronous task for an agent node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAgentJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitAgentJobResponse
        /// </returns>
        public async Task<SubmitAgentJobResponse> SubmitAgentJobWithOptionsAsync(SubmitAgentJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyUrl))
            {
                query["NotifyUrl"] = request.NotifyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skill))
            {
                query["Skill"] = request.Skill;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAgentJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAgentJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an asynchronous task for an agent node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAgentJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitAgentJobResponse
        /// </returns>
        public SubmitAgentJobResponse SubmitAgentJob(SubmitAgentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAgentJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an asynchronous task for an agent node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitAgentJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitAgentJobResponse
        /// </returns>
        public async Task<SubmitAgentJobResponse> SubmitAgentJobAsync(SubmitAgentJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAgentJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImageGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitImageGenerationJobResponse
        /// </returns>
        public SubmitImageGenerationJobResponse SubmitImageGenerationJobWithOptions(SubmitImageGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatio))
            {
                query["AspectRatio"] = request.AspectRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParameters))
            {
                query["JobParameters"] = request.JobParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                query["N"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitImageGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitImageGenerationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImageGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitImageGenerationJobResponse
        /// </returns>
        public async Task<SubmitImageGenerationJobResponse> SubmitImageGenerationJobWithOptionsAsync(SubmitImageGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatio))
            {
                query["AspectRatio"] = request.AspectRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParameters))
            {
                query["JobParameters"] = request.JobParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                query["N"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitImageGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitImageGenerationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImageGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitImageGenerationJobResponse
        /// </returns>
        public SubmitImageGenerationJobResponse SubmitImageGenerationJob(SubmitImageGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitImageGenerationJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an image generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitImageGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitImageGenerationJobResponse
        /// </returns>
        public async Task<SubmitImageGenerationJobResponse> SubmitImageGenerationJobAsync(SubmitImageGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitImageGenerationJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a media asset content understanding job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation performs content understanding based on the provided media asset files, such as video URLs. Additionally, you can pass custom parameters through the <c>UserData</c> field, which are returned as-is in the callback.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitMediaComprehensionJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitMediaComprehensionJobResponse
        /// </returns>
        public SubmitMediaComprehensionJobResponse SubmitMediaComprehensionJobWithOptions(SubmitMediaComprehensionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParams))
            {
                query["JobParams"] = request.JobParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitMediaComprehensionJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMediaComprehensionJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a media asset content understanding job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation performs content understanding based on the provided media asset files, such as video URLs. Additionally, you can pass custom parameters through the <c>UserData</c> field, which are returned as-is in the callback.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitMediaComprehensionJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitMediaComprehensionJobResponse
        /// </returns>
        public async Task<SubmitMediaComprehensionJobResponse> SubmitMediaComprehensionJobWithOptionsAsync(SubmitMediaComprehensionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParams))
            {
                query["JobParams"] = request.JobParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitMediaComprehensionJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMediaComprehensionJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a media asset content understanding job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation performs content understanding based on the provided media asset files, such as video URLs. Additionally, you can pass custom parameters through the <c>UserData</c> field, which are returned as-is in the callback.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitMediaComprehensionJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitMediaComprehensionJobResponse
        /// </returns>
        public SubmitMediaComprehensionJobResponse SubmitMediaComprehensionJob(SubmitMediaComprehensionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaComprehensionJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a media asset content understanding job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation performs content understanding based on the provided media asset files, such as video URLs. Additionally, you can pass custom parameters through the <c>UserData</c> field, which are returned as-is in the callback.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitMediaComprehensionJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitMediaComprehensionJobResponse
        /// </returns>
        public async Task<SubmitMediaComprehensionJobResponse> SubmitMediaComprehensionJobAsync(SubmitMediaComprehensionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaComprehensionJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a creative script generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API generates a new voiceover script based on content understanding results and new product or avatar information. It also supports passing custom parameters through the UserData field, which are returned as-is in the callback.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitRemakeScriptJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitRemakeScriptJobResponse
        /// </returns>
        public SubmitRemakeScriptJobResponse SubmitRemakeScriptJobWithOptions(SubmitRemakeScriptJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemakeParams))
            {
                query["RemakeParams"] = request.RemakeParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemakeType))
            {
                query["RemakeType"] = request.RemakeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitRemakeScriptJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitRemakeScriptJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a creative script generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API generates a new voiceover script based on content understanding results and new product or avatar information. It also supports passing custom parameters through the UserData field, which are returned as-is in the callback.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitRemakeScriptJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitRemakeScriptJobResponse
        /// </returns>
        public async Task<SubmitRemakeScriptJobResponse> SubmitRemakeScriptJobWithOptionsAsync(SubmitRemakeScriptJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemakeParams))
            {
                query["RemakeParams"] = request.RemakeParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemakeType))
            {
                query["RemakeType"] = request.RemakeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitRemakeScriptJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitRemakeScriptJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a creative script generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API generates a new voiceover script based on content understanding results and new product or avatar information. It also supports passing custom parameters through the UserData field, which are returned as-is in the callback.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitRemakeScriptJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitRemakeScriptJobResponse
        /// </returns>
        public SubmitRemakeScriptJobResponse SubmitRemakeScriptJob(SubmitRemakeScriptJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitRemakeScriptJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a creative script generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API generates a new voiceover script based on content understanding results and new product or avatar information. It also supports passing custom parameters through the UserData field, which are returned as-is in the callback.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitRemakeScriptJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitRemakeScriptJobResponse
        /// </returns>
        public async Task<SubmitRemakeScriptJobResponse> SubmitRemakeScriptJobAsync(SubmitRemakeScriptJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitRemakeScriptJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video character replacement task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits a video character replacement node via asynchronous commit. Invoke PrecheckVideoCharacterReplaceJob with the same AppId and AppParams to validate the input assets first.
        /// The returned JobId only indicates that the node is submitted, not completed. Use GetVideoCharacterReplaceJob or BatchGetVideoCharacterReplaceJobs to query the status and output results. ProjectId specifies the project, and FolderId specifies the file folder.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoCharacterReplaceJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoCharacterReplaceJobResponse
        /// </returns>
        public SubmitVideoCharacterReplaceJobResponse SubmitVideoCharacterReplaceJobWithOptions(SubmitVideoCharacterReplaceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppParams))
            {
                body["AppParams"] = request.AppParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoCharacterReplaceJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoCharacterReplaceJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video character replacement task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits a video character replacement node via asynchronous commit. Invoke PrecheckVideoCharacterReplaceJob with the same AppId and AppParams to validate the input assets first.
        /// The returned JobId only indicates that the node is submitted, not completed. Use GetVideoCharacterReplaceJob or BatchGetVideoCharacterReplaceJobs to query the status and output results. ProjectId specifies the project, and FolderId specifies the file folder.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoCharacterReplaceJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoCharacterReplaceJobResponse
        /// </returns>
        public async Task<SubmitVideoCharacterReplaceJobResponse> SubmitVideoCharacterReplaceJobWithOptionsAsync(SubmitVideoCharacterReplaceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppParams))
            {
                body["AppParams"] = request.AppParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoCharacterReplaceJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoCharacterReplaceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video character replacement task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits a video character replacement node via asynchronous commit. Invoke PrecheckVideoCharacterReplaceJob with the same AppId and AppParams to validate the input assets first.
        /// The returned JobId only indicates that the node is submitted, not completed. Use GetVideoCharacterReplaceJob or BatchGetVideoCharacterReplaceJobs to query the status and output results. ProjectId specifies the project, and FolderId specifies the file folder.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoCharacterReplaceJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoCharacterReplaceJobResponse
        /// </returns>
        public SubmitVideoCharacterReplaceJobResponse SubmitVideoCharacterReplaceJob(SubmitVideoCharacterReplaceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitVideoCharacterReplaceJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video character replacement task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits a video character replacement node via asynchronous commit. Invoke PrecheckVideoCharacterReplaceJob with the same AppId and AppParams to validate the input assets first.
        /// The returned JobId only indicates that the node is submitted, not completed. Use GetVideoCharacterReplaceJob or BatchGetVideoCharacterReplaceJobs to query the status and output results. ProjectId specifies the project, and FolderId specifies the file folder.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoCharacterReplaceJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoCharacterReplaceJobResponse
        /// </returns>
        public async Task<SubmitVideoCharacterReplaceJobResponse> SubmitVideoCharacterReplaceJobAsync(SubmitVideoCharacterReplaceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitVideoCharacterReplaceJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video creative generation job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoCreativeGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoCreativeGenerationJobResponse
        /// </returns>
        public SubmitVideoCreativeGenerationJobResponse SubmitVideoCreativeGenerationJobWithOptions(SubmitVideoCreativeGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatio))
            {
                query["AspectRatio"] = request.AspectRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarData))
            {
                query["AvatarData"] = request.AvatarData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParams))
            {
                query["JobParams"] = request.JobParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputLanguages))
            {
                query["OutputLanguages"] = request.OutputLanguages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMaterials))
            {
                query["UserMaterials"] = request.UserMaterials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithSubtitles))
            {
                query["WithSubtitles"] = request.WithSubtitles;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoCreativeGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoCreativeGenerationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video creative generation job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoCreativeGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoCreativeGenerationJobResponse
        /// </returns>
        public async Task<SubmitVideoCreativeGenerationJobResponse> SubmitVideoCreativeGenerationJobWithOptionsAsync(SubmitVideoCreativeGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatio))
            {
                query["AspectRatio"] = request.AspectRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarData))
            {
                query["AvatarData"] = request.AvatarData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParams))
            {
                query["JobParams"] = request.JobParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputLanguages))
            {
                query["OutputLanguages"] = request.OutputLanguages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMaterials))
            {
                query["UserMaterials"] = request.UserMaterials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithSubtitles))
            {
                query["WithSubtitles"] = request.WithSubtitles;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoCreativeGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoCreativeGenerationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video creative generation job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoCreativeGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoCreativeGenerationJobResponse
        /// </returns>
        public SubmitVideoCreativeGenerationJobResponse SubmitVideoCreativeGenerationJob(SubmitVideoCreativeGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitVideoCreativeGenerationJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video creative generation job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoCreativeGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoCreativeGenerationJobResponse
        /// </returns>
        public async Task<SubmitVideoCreativeGenerationJobResponse> SubmitVideoCreativeGenerationJobAsync(SubmitVideoCreativeGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitVideoCreativeGenerationJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an asynchronous video text erasure task that supports full-area erasure, time ranges, and specified regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits an asynchronous video text erasure task. The input can be an accessible video URL or a Yike video media asset ID. You can configure the erasure time range and text region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoDetextJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoDetextJobResponse
        /// </returns>
        public SubmitVideoDetextJobResponse SubmitVideoDetextJobWithOptions(SubmitVideoDetextJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParameters))
            {
                body["JobParameters"] = request.JobParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["Output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoDetextJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoDetextJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an asynchronous video text erasure task that supports full-area erasure, time ranges, and specified regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits an asynchronous video text erasure task. The input can be an accessible video URL or a Yike video media asset ID. You can configure the erasure time range and text region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoDetextJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoDetextJobResponse
        /// </returns>
        public async Task<SubmitVideoDetextJobResponse> SubmitVideoDetextJobWithOptionsAsync(SubmitVideoDetextJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParameters))
            {
                body["JobParameters"] = request.JobParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["Output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoDetextJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoDetextJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an asynchronous video text erasure task that supports full-area erasure, time ranges, and specified regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits an asynchronous video text erasure task. The input can be an accessible video URL or a Yike video media asset ID. You can configure the erasure time range and text region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoDetextJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoDetextJobResponse
        /// </returns>
        public SubmitVideoDetextJobResponse SubmitVideoDetextJob(SubmitVideoDetextJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitVideoDetextJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an asynchronous video text erasure task that supports full-area erasure, time ranges, and specified regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits an asynchronous video text erasure task. The input can be an accessible video URL or a Yike video media asset ID. You can configure the erasure time range and text region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoDetextJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoDetextJobResponse
        /// </returns>
        public async Task<SubmitVideoDetextJobResponse> SubmitVideoDetextJobAsync(SubmitVideoDetextJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitVideoDetextJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoGenerationJobResponse
        /// </returns>
        public SubmitVideoGenerationJobResponse SubmitVideoGenerationJobWithOptions(SubmitVideoGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatio))
            {
                query["AspectRatio"] = request.AspectRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParameters))
            {
                query["JobParameters"] = request.JobParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                query["N"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                query["Output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoGenerationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoGenerationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoGenerationJobResponse
        /// </returns>
        public async Task<SubmitVideoGenerationJobResponse> SubmitVideoGenerationJobWithOptionsAsync(SubmitVideoGenerationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatio))
            {
                query["AspectRatio"] = request.AspectRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParameters))
            {
                query["JobParameters"] = request.JobParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.N))
            {
                query["N"] = request.N;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                query["Output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoGenerationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoGenerationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoGenerationJobResponse
        /// </returns>
        public SubmitVideoGenerationJobResponse SubmitVideoGenerationJob(SubmitVideoGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitVideoGenerationJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoGenerationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoGenerationJobResponse
        /// </returns>
        public async Task<SubmitVideoGenerationJobResponse> SubmitVideoGenerationJobAsync(SubmitVideoGenerationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitVideoGenerationJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a content understanding and creative script generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits the original video and remake information such as new products and characters to asynchronously complete video content understanding and creative script generation. Uses the returned JobId to call GetVideoRemakeJob to query the progress and outputs. Video rendering requires a separate call to SubmitVideoRenderJob.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoRemakeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoRemakeJobResponse
        /// </returns>
        public SubmitVideoRemakeJobResponse SubmitVideoRemakeJobWithOptions(SubmitVideoRemakeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemakeParams))
            {
                query["RemakeParams"] = request.RemakeParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoRemakeJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoRemakeJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a content understanding and creative script generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits the original video and remake information such as new products and characters to asynchronously complete video content understanding and creative script generation. Uses the returned JobId to call GetVideoRemakeJob to query the progress and outputs. Video rendering requires a separate call to SubmitVideoRenderJob.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoRemakeJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoRemakeJobResponse
        /// </returns>
        public async Task<SubmitVideoRemakeJobResponse> SubmitVideoRemakeJobWithOptionsAsync(SubmitVideoRemakeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemakeParams))
            {
                query["RemakeParams"] = request.RemakeParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoRemakeJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoRemakeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a content understanding and creative script generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits the original video and remake information such as new products and characters to asynchronously complete video content understanding and creative script generation. Uses the returned JobId to call GetVideoRemakeJob to query the progress and outputs. Video rendering requires a separate call to SubmitVideoRenderJob.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoRemakeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoRemakeJobResponse
        /// </returns>
        public SubmitVideoRemakeJobResponse SubmitVideoRemakeJob(SubmitVideoRemakeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitVideoRemakeJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a content understanding and creative script generation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits the original video and remake information such as new products and characters to asynchronously complete video content understanding and creative script generation. Uses the returned JobId to call GetVideoRemakeJob to query the progress and outputs. Video rendering requires a separate call to SubmitVideoRenderJob.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoRemakeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoRemakeJobResponse
        /// </returns>
        public async Task<SubmitVideoRemakeJobResponse> SubmitVideoRemakeJobAsync(SubmitVideoRemakeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitVideoRemakeJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video rendering and compositing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoRenderJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoRenderJobResponse
        /// </returns>
        public SubmitVideoRenderJobResponse SubmitVideoRenderJobWithOptions(SubmitVideoRenderJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Script))
            {
                query["Script"] = request.Script;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Settings))
            {
                query["Settings"] = request.Settings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoRenderJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoRenderJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video rendering and compositing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoRenderJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoRenderJobResponse
        /// </returns>
        public async Task<SubmitVideoRenderJobResponse> SubmitVideoRenderJobWithOptionsAsync(SubmitVideoRenderJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Script))
            {
                query["Script"] = request.Script;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Settings))
            {
                query["Settings"] = request.Settings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoRenderJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoRenderJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video rendering and compositing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoRenderJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoRenderJobResponse
        /// </returns>
        public SubmitVideoRenderJobResponse SubmitVideoRenderJob(SubmitVideoRenderJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitVideoRenderJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a video rendering and compositing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitVideoRenderJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoRenderJobResponse
        /// </returns>
        public async Task<SubmitVideoRenderJobResponse> SubmitVideoRenderJobAsync(SubmitVideoRenderJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitVideoRenderJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an asynchronous video translation task that supports subtitle translation, voice translation, primary subtitle removal, and on-screen text translation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits an asynchronous video translation task. The input supports a media URL or a Yike media asset ID. The task parameters are used to select the source language, target language, and the translation capabilities to be enabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoTranslationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoTranslationJobResponse
        /// </returns>
        public SubmitVideoTranslationJobResponse SubmitVideoTranslationJobWithOptions(SubmitVideoTranslationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParameters))
            {
                body["JobParameters"] = request.JobParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                body["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["Output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoTranslationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoTranslationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an asynchronous video translation task that supports subtitle translation, voice translation, primary subtitle removal, and on-screen text translation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits an asynchronous video translation task. The input supports a media URL or a Yike media asset ID. The task parameters are used to select the source language, target language, and the translation capabilities to be enabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoTranslationJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoTranslationJobResponse
        /// </returns>
        public async Task<SubmitVideoTranslationJobResponse> SubmitVideoTranslationJobWithOptionsAsync(SubmitVideoTranslationJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParameters))
            {
                body["JobParameters"] = request.JobParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                body["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                body["Output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitVideoTranslationJob",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitVideoTranslationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an asynchronous video translation task that supports subtitle translation, voice translation, primary subtitle removal, and on-screen text translation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits an asynchronous video translation task. The input supports a media URL or a Yike media asset ID. The task parameters are used to select the source language, target language, and the translation capabilities to be enabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoTranslationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoTranslationJobResponse
        /// </returns>
        public SubmitVideoTranslationJobResponse SubmitVideoTranslationJob(SubmitVideoTranslationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitVideoTranslationJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits an asynchronous video translation task that supports subtitle translation, voice translation, primary subtitle removal, and on-screen text translation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Submits an asynchronous video translation task. The input supports a media URL or a Yike media asset ID. The task parameters are used to select the source language, target language, and the translation capabilities to be enabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitVideoTranslationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitVideoTranslationJobResponse
        /// </returns>
        public async Task<SubmitVideoTranslationJobResponse> SubmitVideoTranslationJobAsync(SubmitVideoTranslationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitVideoTranslationJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a media asset category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a media asset category, you can call this operation to update the name of the category by specifying its ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAssetCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAssetCategoryResponse
        /// </returns>
        public UpdateAssetCategoryResponse UpdateAssetCategoryWithOptions(UpdateAssetCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAssetCategory",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAssetCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a media asset category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a media asset category, you can call this operation to update the name of the category by specifying its ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAssetCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAssetCategoryResponse
        /// </returns>
        public async Task<UpdateAssetCategoryResponse> UpdateAssetCategoryWithOptionsAsync(UpdateAssetCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                query["CategoryName"] = request.CategoryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAssetCategory",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAssetCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a media asset category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a media asset category, you can call this operation to update the name of the category by specifying its ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAssetCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAssetCategoryResponse
        /// </returns>
        public UpdateAssetCategoryResponse UpdateAssetCategory(UpdateAssetCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAssetCategoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a media asset category.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a media asset category, you can call this operation to update the name of the category by specifying its ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAssetCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAssetCategoryResponse
        /// </returns>
        public async Task<UpdateAssetCategoryResponse> UpdateAssetCategoryAsync(UpdateAssetCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAssetCategoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInfiniteCanvasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInfiniteCanvasResponse
        /// </returns>
        public UpdateInfiniteCanvasResponse UpdateInfiniteCanvasWithOptions(UpdateInfiniteCanvasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanvasId))
            {
                query["CanvasId"] = request.CanvasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                query["CoverUrl"] = request.CoverUrl;
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
                Action = "UpdateInfiniteCanvas",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInfiniteCanvasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInfiniteCanvasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInfiniteCanvasResponse
        /// </returns>
        public async Task<UpdateInfiniteCanvasResponse> UpdateInfiniteCanvasWithOptionsAsync(UpdateInfiniteCanvasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanvasId))
            {
                query["CanvasId"] = request.CanvasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                query["CoverUrl"] = request.CoverUrl;
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
                Action = "UpdateInfiniteCanvas",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInfiniteCanvasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInfiniteCanvasRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInfiniteCanvasResponse
        /// </returns>
        public UpdateInfiniteCanvasResponse UpdateInfiniteCanvas(UpdateInfiniteCanvasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInfiniteCanvasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of an infinite canvas.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInfiniteCanvasRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInfiniteCanvasResponse
        /// </returns>
        public async Task<UpdateInfiniteCanvasResponse> UpdateInfiniteCanvasAsync(UpdateInfiniteCanvasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInfiniteCanvasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates media asset information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMediaResponse
        /// </returns>
        public UpdateMediaResponse UpdateMediaWithOptions(UpdateMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppendTags))
            {
                query["AppendTags"] = request.AppendTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizConfig))
            {
                query["BizConfig"] = request.BizConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicMetaData))
            {
                query["DynamicMetaData"] = request.DynamicMetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTags))
            {
                query["MediaTags"] = request.MediaTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMediaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates media asset information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMediaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMediaResponse
        /// </returns>
        public async Task<UpdateMediaResponse> UpdateMediaWithOptionsAsync(UpdateMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppendTags))
            {
                query["AppendTags"] = request.AppendTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizConfig))
            {
                query["BizConfig"] = request.BizConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryId))
            {
                query["CategoryId"] = request.CategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicMetaData))
            {
                query["DynamicMetaData"] = request.DynamicMetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTags))
            {
                query["MediaTags"] = request.MediaTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMedia",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates media asset information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMediaResponse
        /// </returns>
        public UpdateMediaResponse UpdateMedia(UpdateMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates media asset information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries media asset content understanding jobs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMediaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMediaResponse
        /// </returns>
        public async Task<UpdateMediaResponse> UpdateMediaAsync(UpdateMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name of a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the name of a project specified by ProjectId. Use Title to specify the new name. This operation only supports modifying the project name. You cannot modify the description or cover image. The caller must have edit permissions for the project.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public UpdateProjectResponse UpdateProjectWithOptions(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "UpdateProject",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name of a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the name of a project specified by ProjectId. Use Title to specify the new name. This operation only supports modifying the project name. You cannot modify the description or cover image. The caller must have edit permissions for the project.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "UpdateProject",
                Version = "2026-07-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name of a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the name of a project specified by ProjectId. Use Title to specify the new name. This operation only supports modifying the project name. You cannot modify the description or cover image. The caller must have edit permissions for the project.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProjectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the name of a project.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the name of a project specified by ProjectId. Use Title to specify the new name. This operation only supports modifying the project name. You cannot modify the description or cover image. The caller must have edit permissions for the project.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public async Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProjectWithOptionsAsync(request, runtime);
        }

    }
}
