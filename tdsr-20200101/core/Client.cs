// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Tdsr20200101.Models;

namespace AlibabaCloud.SDK.Tdsr20200101
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "lyj.cn-hangzhou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("tdsr", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public SaveHotspotConfigResponse SaveHotspotConfigWithOptions(SaveHotspotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveHotspotConfigResponse>(DoRequest("SaveHotspotConfig", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<SaveHotspotConfigResponse> SaveHotspotConfigWithOptionsAsync(SaveHotspotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveHotspotConfigResponse>(await DoRequestAsync("SaveHotspotConfig", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public SaveHotspotConfigResponse SaveHotspotConfig(SaveHotspotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveHotspotConfigWithOptions(request, runtime);
        }

        public async Task<SaveHotspotConfigResponse> SaveHotspotConfigAsync(SaveHotspotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveHotspotConfigWithOptionsAsync(request, runtime);
        }

        public GetHotspotConfigResponse GetHotspotConfigWithOptions(GetHotspotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetHotspotConfigResponse>(DoRequest("GetHotspotConfig", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<GetHotspotConfigResponse> GetHotspotConfigWithOptionsAsync(GetHotspotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetHotspotConfigResponse>(await DoRequestAsync("GetHotspotConfig", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public GetHotspotConfigResponse GetHotspotConfig(GetHotspotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotspotConfigWithOptions(request, runtime);
        }

        public async Task<GetHotspotConfigResponse> GetHotspotConfigAsync(GetHotspotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotspotConfigWithOptionsAsync(request, runtime);
        }

        public ListMainScenesResponse ListMainScenesWithOptions(ListMainScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListMainScenesResponse>(DoRequest("ListMainScenes", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<ListMainScenesResponse> ListMainScenesWithOptionsAsync(ListMainScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListMainScenesResponse>(await DoRequestAsync("ListMainScenes", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public ListMainScenesResponse ListMainScenes(ListMainScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMainScenesWithOptions(request, runtime);
        }

        public async Task<ListMainScenesResponse> ListMainScenesAsync(ListMainScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMainScenesWithOptionsAsync(request, runtime);
        }

        public SaveHotspotTagResponse SaveHotspotTagWithOptions(SaveHotspotTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveHotspotTagResponse>(DoRequest("SaveHotspotTag", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<SaveHotspotTagResponse> SaveHotspotTagWithOptionsAsync(SaveHotspotTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveHotspotTagResponse>(await DoRequestAsync("SaveHotspotTag", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public SaveHotspotTagResponse SaveHotspotTag(SaveHotspotTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveHotspotTagWithOptions(request, runtime);
        }

        public async Task<SaveHotspotTagResponse> SaveHotspotTagAsync(SaveHotspotTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveHotspotTagWithOptionsAsync(request, runtime);
        }

        public GetSceneListResponse GetSceneListWithOptions(GetSceneListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSceneListResponse>(DoRequest("GetSceneList", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<GetSceneListResponse> GetSceneListWithOptionsAsync(GetSceneListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSceneListResponse>(await DoRequestAsync("GetSceneList", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public GetSceneListResponse GetSceneList(GetSceneListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSceneListWithOptions(request, runtime);
        }

        public async Task<GetSceneListResponse> GetSceneListAsync(GetSceneListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSceneListWithOptionsAsync(request, runtime);
        }

        public SaveFileResponse SaveFileWithOptions(SaveFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveFileResponse>(DoRequest("SaveFile", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<SaveFileResponse> SaveFileWithOptionsAsync(SaveFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveFileResponse>(await DoRequestAsync("SaveFile", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public SaveFileResponse SaveFile(SaveFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveFileWithOptions(request, runtime);
        }

        public async Task<SaveFileResponse> SaveFileAsync(SaveFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveFileWithOptionsAsync(request, runtime);
        }

        public DeleteFileResponse DeleteFileWithOptions(DeleteFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteFileResponse>(DoRequest("DeleteFile", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(DeleteFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteFileResponse>(await DoRequestAsync("DeleteFile", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public DeleteFileResponse DeleteFile(DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFileWithOptions(request, runtime);
        }

        public async Task<DeleteFileResponse> DeleteFileAsync(DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFileWithOptionsAsync(request, runtime);
        }

        public GetHotspotTagResponse GetHotspotTagWithOptions(GetHotspotTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetHotspotTagResponse>(DoRequest("GetHotspotTag", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<GetHotspotTagResponse> GetHotspotTagWithOptionsAsync(GetHotspotTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetHotspotTagResponse>(await DoRequestAsync("GetHotspotTag", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public GetHotspotTagResponse GetHotspotTag(GetHotspotTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotspotTagWithOptions(request, runtime);
        }

        public async Task<GetHotspotTagResponse> GetHotspotTagAsync(GetHotspotTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotspotTagWithOptionsAsync(request, runtime);
        }

        public GetPolicyResponse GetPolicyWithOptions(GetPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPolicyResponse>(DoRequest("GetPolicy", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<GetPolicyResponse> GetPolicyWithOptionsAsync(GetPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPolicyResponse>(await DoRequestAsync("GetPolicy", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPolicyWithOptions(request, runtime);
        }

        public async Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPolicyWithOptionsAsync(request, runtime);
        }

        public PublishHotspotResponse PublishHotspotWithOptions(PublishHotspotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PublishHotspotResponse>(DoRequest("PublishHotspot", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<PublishHotspotResponse> PublishHotspotWithOptionsAsync(PublishHotspotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PublishHotspotResponse>(await DoRequestAsync("PublishHotspot", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public PublishHotspotResponse PublishHotspot(PublishHotspotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishHotspotWithOptions(request, runtime);
        }

        public async Task<PublishHotspotResponse> PublishHotspotAsync(PublishHotspotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishHotspotWithOptionsAsync(request, runtime);
        }

        public GetWindowConfigResponse GetWindowConfigWithOptions(GetWindowConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetWindowConfigResponse>(DoRequest("GetWindowConfig", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<GetWindowConfigResponse> GetWindowConfigWithOptionsAsync(GetWindowConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetWindowConfigResponse>(await DoRequestAsync("GetWindowConfig", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public GetWindowConfigResponse GetWindowConfig(GetWindowConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWindowConfigWithOptions(request, runtime);
        }

        public async Task<GetWindowConfigResponse> GetWindowConfigAsync(GetWindowConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWindowConfigWithOptionsAsync(request, runtime);
        }

        public GetSceneDataResponse GetSceneDataWithOptions(GetSceneDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSceneDataResponse>(DoRequest("GetSceneData", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<GetSceneDataResponse> GetSceneDataWithOptionsAsync(GetSceneDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSceneDataResponse>(await DoRequestAsync("GetSceneData", "HTTPS", "POST", "2020-01-01", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public GetSceneDataResponse GetSceneData(GetSceneDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSceneDataWithOptions(request, runtime);
        }

        public async Task<GetSceneDataResponse> GetSceneDataAsync(GetSceneDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSceneDataWithOptionsAsync(request, runtime);
        }

        public CheckPermissionResponse CheckPermissionWithOptions(CheckPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckPermissionResponse>(DoRequest("CheckPermission", "HTTPS", "POST", "2020-01-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CheckPermissionResponse> CheckPermissionWithOptionsAsync(CheckPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckPermissionResponse>(await DoRequestAsync("CheckPermission", "HTTPS", "POST", "2020-01-01", "AK", null, request.ToMap(), runtime));
        }

        public CheckPermissionResponse CheckPermission(CheckPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckPermissionWithOptions(request, runtime);
        }

        public async Task<CheckPermissionResponse> CheckPermissionAsync(CheckPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckPermissionWithOptionsAsync(request, runtime);
        }

        public CheckResourceResponse CheckResourceWithOptions(CheckResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckResourceResponse>(DoRequest("CheckResource", "HTTPS", "POST", "2020-01-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CheckResourceResponse> CheckResourceWithOptionsAsync(CheckResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckResourceResponse>(await DoRequestAsync("CheckResource", "HTTPS", "POST", "2020-01-01", "AK", null, request.ToMap(), runtime));
        }

        public CheckResourceResponse CheckResource(CheckResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckResourceWithOptions(request, runtime);
        }

        public async Task<CheckResourceResponse> CheckResourceAsync(CheckResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckResourceWithOptionsAsync(request, runtime);
        }

        public CreateSceneResponse CreateSceneWithOptions(CreateSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSceneResponse>(DoRequest("CreateScene", "HTTPS", "POST", "2020-01-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateSceneResponse> CreateSceneWithOptionsAsync(CreateSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSceneResponse>(await DoRequestAsync("CreateScene", "HTTPS", "POST", "2020-01-01", "AK", null, request.ToMap(), runtime));
        }

        public CreateSceneResponse CreateScene(CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSceneWithOptions(request, runtime);
        }

        public async Task<CreateSceneResponse> CreateSceneAsync(CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSceneWithOptionsAsync(request, runtime);
        }

        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProjectResponse>(DoRequest("CreateProject", "HTTPS", "POST", "2020-01-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProjectResponse>(await DoRequestAsync("CreateProject", "HTTPS", "POST", "2020-01-01", "AK", null, request.ToMap(), runtime));
        }

        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectWithOptions(request, runtime);
        }

        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectWithOptionsAsync(request, runtime);
        }

        public DeleteProjectResponse DeleteProjectWithOptions(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProjectResponse>(DoRequest("DeleteProject", "HTTPS", "POST", "2020-01-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProjectResponse>(await DoRequestAsync("DeleteProject", "HTTPS", "POST", "2020-01-01", "AK", null, request.ToMap(), runtime));
        }

        public DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectWithOptions(request, runtime);
        }

        public async Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectWithOptionsAsync(request, runtime);
        }

        public ListScenesResponse ListScenesWithOptions(ListScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListScenesResponse>(DoRequest("ListScenes", "HTTPS", "POST", "2020-01-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListScenesResponse> ListScenesWithOptionsAsync(ListScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListScenesResponse>(await DoRequestAsync("ListScenes", "HTTPS", "POST", "2020-01-01", "AK", null, request.ToMap(), runtime));
        }

        public ListScenesResponse ListScenes(ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScenesWithOptions(request, runtime);
        }

        public async Task<ListScenesResponse> ListScenesAsync(ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScenesWithOptionsAsync(request, runtime);
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

    }
}
