// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ICE20201109.Models;

namespace AlibabaCloud.SDK.ICE20201109
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "ice.aliyuncs.com"},
                {"ap-northeast-2-pop", "ice.aliyuncs.com"},
                {"ap-south-1", "ice.aliyuncs.com"},
                {"ap-southeast-1", "ice.aliyuncs.com"},
                {"ap-southeast-2", "ice.aliyuncs.com"},
                {"ap-southeast-3", "ice.aliyuncs.com"},
                {"ap-southeast-5", "ice.aliyuncs.com"},
                {"cn-beijing", "ice.aliyuncs.com"},
                {"cn-beijing-finance-1", "ice.aliyuncs.com"},
                {"cn-beijing-finance-pop", "ice.aliyuncs.com"},
                {"cn-beijing-gov-1", "ice.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "ice.aliyuncs.com"},
                {"cn-chengdu", "ice.aliyuncs.com"},
                {"cn-edge-1", "ice.aliyuncs.com"},
                {"cn-fujian", "ice.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "ice.aliyuncs.com"},
                {"cn-hangzhou", "ice.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "ice.aliyuncs.com"},
                {"cn-hangzhou-finance", "ice.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "ice.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "ice.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "ice.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "ice.aliyuncs.com"},
                {"cn-hangzhou-test-306", "ice.aliyuncs.com"},
                {"cn-hongkong", "ice.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "ice.aliyuncs.com"},
                {"cn-huhehaote", "ice.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "ice.aliyuncs.com"},
                {"cn-north-2-gov-1", "ice.aliyuncs.com"},
                {"cn-qingdao", "ice.aliyuncs.com"},
                {"cn-qingdao-nebula", "ice.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "ice.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "ice.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ice.aliyuncs.com"},
                {"cn-shanghai-inner", "ice.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "ice.aliyuncs.com"},
                {"cn-shenzhen", "ice.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "ice.aliyuncs.com"},
                {"cn-shenzhen-inner", "ice.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "ice.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "ice.aliyuncs.com"},
                {"cn-wuhan", "ice.aliyuncs.com"},
                {"cn-wulanchabu", "ice.aliyuncs.com"},
                {"cn-yushanfang", "ice.aliyuncs.com"},
                {"cn-zhangbei", "ice.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "ice.aliyuncs.com"},
                {"cn-zhangjiakou", "ice.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "ice.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "ice.aliyuncs.com"},
                {"eu-central-1", "ice.aliyuncs.com"},
                {"eu-west-1", "ice.aliyuncs.com"},
                {"eu-west-1-oxs", "ice.aliyuncs.com"},
                {"me-east-1", "ice.aliyuncs.com"},
                {"rus-west-1-pop", "ice.aliyuncs.com"},
                {"us-east-1", "ice.aliyuncs.com"},
                {"us-west-1", "ice.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ice", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddEditingProjectMaterialsResponse AddEditingProjectMaterialsWithOptions(AddEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaterialMaps"] = request.MaterialMaps;
            query["ProjectId"] = request.ProjectId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEditingProjectMaterials",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEditingProjectMaterialsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddEditingProjectMaterialsResponse> AddEditingProjectMaterialsWithOptionsAsync(AddEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaterialMaps"] = request.MaterialMaps;
            query["ProjectId"] = request.ProjectId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEditingProjectMaterials",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEditingProjectMaterialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddEditingProjectMaterialsResponse AddEditingProjectMaterials(AddEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddEditingProjectMaterialsWithOptions(request, runtime);
        }

        public async Task<AddEditingProjectMaterialsResponse> AddEditingProjectMaterialsAsync(AddEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddEditingProjectMaterialsWithOptionsAsync(request, runtime);
        }

        public AddFavoritePublicMediaResponse AddFavoritePublicMediaWithOptions(AddFavoritePublicMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaIds"] = request.MediaIds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFavoritePublicMedia",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFavoritePublicMediaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddFavoritePublicMediaResponse> AddFavoritePublicMediaWithOptionsAsync(AddFavoritePublicMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaIds"] = request.MediaIds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddFavoritePublicMedia",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFavoritePublicMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddFavoritePublicMediaResponse AddFavoritePublicMedia(AddFavoritePublicMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddFavoritePublicMediaWithOptions(request, runtime);
        }

        public async Task<AddFavoritePublicMediaResponse> AddFavoritePublicMediaAsync(AddFavoritePublicMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddFavoritePublicMediaWithOptionsAsync(request, runtime);
        }

        public AddTemplateResponse AddTemplateWithOptions(AddTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Config"] = request.Config;
            query["CoverUrl"] = request.CoverUrl;
            query["Name"] = request.Name;
            query["PreviewMedia"] = request.PreviewMedia;
            query["RelatedMediaids"] = request.RelatedMediaids;
            query["Source"] = request.Source;
            query["Status"] = request.Status;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddTemplateResponse> AddTemplateWithOptionsAsync(AddTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Config"] = request.Config;
            query["CoverUrl"] = request.CoverUrl;
            query["Name"] = request.Name;
            query["PreviewMedia"] = request.PreviewMedia;
            query["RelatedMediaids"] = request.RelatedMediaids;
            query["Source"] = request.Source;
            query["Status"] = request.Status;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddTemplateResponse AddTemplate(AddTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTemplateWithOptions(request, runtime);
        }

        public async Task<AddTemplateResponse> AddTemplateAsync(AddTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTemplateWithOptionsAsync(request, runtime);
        }

        public BatchGetMediaInfosResponse BatchGetMediaInfosWithOptions(BatchGetMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdditionType"] = request.AdditionType;
            query["MediaIds"] = request.MediaIds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetMediaInfos",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetMediaInfosResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchGetMediaInfosResponse> BatchGetMediaInfosWithOptionsAsync(BatchGetMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdditionType"] = request.AdditionType;
            query["MediaIds"] = request.MediaIds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetMediaInfos",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetMediaInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchGetMediaInfosResponse BatchGetMediaInfos(BatchGetMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetMediaInfosWithOptions(request, runtime);
        }

        public async Task<BatchGetMediaInfosResponse> BatchGetMediaInfosAsync(BatchGetMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetMediaInfosWithOptionsAsync(request, runtime);
        }

        public CancelFavoritePublicMediaResponse CancelFavoritePublicMediaWithOptions(CancelFavoritePublicMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaIds"] = request.MediaIds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelFavoritePublicMedia",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelFavoritePublicMediaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelFavoritePublicMediaResponse> CancelFavoritePublicMediaWithOptionsAsync(CancelFavoritePublicMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaIds"] = request.MediaIds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelFavoritePublicMedia",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelFavoritePublicMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelFavoritePublicMediaResponse CancelFavoritePublicMedia(CancelFavoritePublicMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelFavoritePublicMediaWithOptions(request, runtime);
        }

        public async Task<CancelFavoritePublicMediaResponse> CancelFavoritePublicMediaAsync(CancelFavoritePublicMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelFavoritePublicMediaWithOptionsAsync(request, runtime);
        }

        public CreateEditingProjectResponse CreateEditingProjectWithOptions(CreateEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BusinessConfig"] = request.BusinessConfig;
            query["ClipsParam"] = request.ClipsParam;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["MaterialMaps"] = request.MaterialMaps;
            query["ProjectType"] = request.ProjectType;
            query["TemplateId"] = request.TemplateId;
            query["Timeline"] = request.Timeline;
            query["Title"] = request.Title;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEditingProject",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEditingProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateEditingProjectResponse> CreateEditingProjectWithOptionsAsync(CreateEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BusinessConfig"] = request.BusinessConfig;
            query["ClipsParam"] = request.ClipsParam;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["MaterialMaps"] = request.MaterialMaps;
            query["ProjectType"] = request.ProjectType;
            query["TemplateId"] = request.TemplateId;
            query["Timeline"] = request.Timeline;
            query["Title"] = request.Title;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEditingProject",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEditingProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateEditingProjectResponse CreateEditingProject(CreateEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEditingProjectWithOptions(request, runtime);
        }

        public async Task<CreateEditingProjectResponse> CreateEditingProjectAsync(CreateEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEditingProjectWithOptionsAsync(request, runtime);
        }

        public DeleteEditingProjectMaterialsResponse DeleteEditingProjectMaterialsWithOptions(DeleteEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaterialIds"] = request.MaterialIds;
            query["MaterialType"] = request.MaterialType;
            query["ProjectId"] = request.ProjectId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEditingProjectMaterials",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEditingProjectMaterialsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEditingProjectMaterialsResponse> DeleteEditingProjectMaterialsWithOptionsAsync(DeleteEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaterialIds"] = request.MaterialIds;
            query["MaterialType"] = request.MaterialType;
            query["ProjectId"] = request.ProjectId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEditingProjectMaterials",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEditingProjectMaterialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEditingProjectMaterialsResponse DeleteEditingProjectMaterials(DeleteEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEditingProjectMaterialsWithOptions(request, runtime);
        }

        public async Task<DeleteEditingProjectMaterialsResponse> DeleteEditingProjectMaterialsAsync(DeleteEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEditingProjectMaterialsWithOptionsAsync(request, runtime);
        }

        public DeleteEditingProjectsResponse DeleteEditingProjectsWithOptions(DeleteEditingProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectIds"] = request.ProjectIds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEditingProjects",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEditingProjectsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEditingProjectsResponse> DeleteEditingProjectsWithOptionsAsync(DeleteEditingProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectIds"] = request.ProjectIds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEditingProjects",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEditingProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEditingProjectsResponse DeleteEditingProjects(DeleteEditingProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEditingProjectsWithOptions(request, runtime);
        }

        public async Task<DeleteEditingProjectsResponse> DeleteEditingProjectsAsync(DeleteEditingProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEditingProjectsWithOptionsAsync(request, runtime);
        }

        public DeleteMediaInfosResponse DeleteMediaInfosWithOptions(DeleteMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InputURLs"] = request.InputURLs;
            query["MediaIds"] = request.MediaIds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMediaInfos",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMediaInfosResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteMediaInfosResponse> DeleteMediaInfosWithOptionsAsync(DeleteMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InputURLs"] = request.InputURLs;
            query["MediaIds"] = request.MediaIds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMediaInfos",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMediaInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteMediaInfosResponse DeleteMediaInfos(DeleteMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMediaInfosWithOptions(request, runtime);
        }

        public async Task<DeleteMediaInfosResponse> DeleteMediaInfosAsync(DeleteMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMediaInfosWithOptionsAsync(request, runtime);
        }

        public DeleteSmartJobResponse DeleteSmartJobWithOptions(DeleteSmartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobId"] = request.JobId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSmartJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSmartJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSmartJobResponse> DeleteSmartJobWithOptionsAsync(DeleteSmartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobId"] = request.JobId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSmartJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSmartJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteSmartJobResponse DeleteSmartJob(DeleteSmartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSmartJobWithOptions(request, runtime);
        }

        public async Task<DeleteSmartJobResponse> DeleteSmartJobAsync(DeleteSmartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSmartJobWithOptionsAsync(request, runtime);
        }

        public DeleteTemplateResponse DeleteTemplateWithOptions(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateWithOptionsAsync(request, runtime);
        }

        public DescribeIceProductStatusResponse DescribeIceProductStatusWithOptions(DescribeIceProductStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CommodityCode"] = request.CommodityCode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIceProductStatus",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIceProductStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeIceProductStatusResponse> DescribeIceProductStatusWithOptionsAsync(DescribeIceProductStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CommodityCode"] = request.CommodityCode;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIceProductStatus",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIceProductStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeIceProductStatusResponse DescribeIceProductStatus(DescribeIceProductStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIceProductStatusWithOptions(request, runtime);
        }

        public async Task<DescribeIceProductStatusResponse> DescribeIceProductStatusAsync(DescribeIceProductStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIceProductStatusWithOptionsAsync(request, runtime);
        }

        public DescribeMaterialPackageInfoResponse DescribeMaterialPackageInfoWithOptions(DescribeMaterialPackageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaterialPackageId"] = request.MaterialPackageId;
            query["MaterialPackageType"] = request.MaterialPackageType;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMaterialPackageInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMaterialPackageInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMaterialPackageInfoResponse> DescribeMaterialPackageInfoWithOptionsAsync(DescribeMaterialPackageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaterialPackageId"] = request.MaterialPackageId;
            query["MaterialPackageType"] = request.MaterialPackageType;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMaterialPackageInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMaterialPackageInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMaterialPackageInfoResponse DescribeMaterialPackageInfo(DescribeMaterialPackageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMaterialPackageInfoWithOptions(request, runtime);
        }

        public async Task<DescribeMaterialPackageInfoResponse> DescribeMaterialPackageInfoAsync(DescribeMaterialPackageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMaterialPackageInfoWithOptionsAsync(request, runtime);
        }

        public DescribeRelatedAuthorizationStatusResponse DescribeRelatedAuthorizationStatusWithOptions(DescribeRelatedAuthorizationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRelatedAuthorizationStatus",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRelatedAuthorizationStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRelatedAuthorizationStatusResponse> DescribeRelatedAuthorizationStatusWithOptionsAsync(DescribeRelatedAuthorizationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRelatedAuthorizationStatus",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRelatedAuthorizationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRelatedAuthorizationStatusResponse DescribeRelatedAuthorizationStatus(DescribeRelatedAuthorizationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRelatedAuthorizationStatusWithOptions(request, runtime);
        }

        public async Task<DescribeRelatedAuthorizationStatusResponse> DescribeRelatedAuthorizationStatusAsync(DescribeRelatedAuthorizationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRelatedAuthorizationStatusWithOptionsAsync(request, runtime);
        }

        public GetDefaultStorageLocationResponse GetDefaultStorageLocationWithOptions(GetDefaultStorageLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultStorageLocation",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultStorageLocationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDefaultStorageLocationResponse> GetDefaultStorageLocationWithOptionsAsync(GetDefaultStorageLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultStorageLocation",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultStorageLocationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDefaultStorageLocationResponse GetDefaultStorageLocation(GetDefaultStorageLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDefaultStorageLocationWithOptions(request, runtime);
        }

        public async Task<GetDefaultStorageLocationResponse> GetDefaultStorageLocationAsync(GetDefaultStorageLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDefaultStorageLocationWithOptionsAsync(request, runtime);
        }

        public GetEditingProjectResponse GetEditingProjectWithOptions(GetEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectId"] = request.ProjectId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEditingProject",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEditingProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEditingProjectResponse> GetEditingProjectWithOptionsAsync(GetEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectId"] = request.ProjectId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEditingProject",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEditingProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEditingProjectResponse GetEditingProject(GetEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEditingProjectWithOptions(request, runtime);
        }

        public async Task<GetEditingProjectResponse> GetEditingProjectAsync(GetEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEditingProjectWithOptionsAsync(request, runtime);
        }

        public GetEditingProjectMaterialsResponse GetEditingProjectMaterialsWithOptions(GetEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectId"] = request.ProjectId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEditingProjectMaterials",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEditingProjectMaterialsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEditingProjectMaterialsResponse> GetEditingProjectMaterialsWithOptionsAsync(GetEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectId"] = request.ProjectId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEditingProjectMaterials",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEditingProjectMaterialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEditingProjectMaterialsResponse GetEditingProjectMaterials(GetEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEditingProjectMaterialsWithOptions(request, runtime);
        }

        public async Task<GetEditingProjectMaterialsResponse> GetEditingProjectMaterialsAsync(GetEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEditingProjectMaterialsWithOptionsAsync(request, runtime);
        }

        public GetEventCallbackResponse GetEventCallbackWithOptions(GetEventCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventCallback",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventCallbackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEventCallbackResponse> GetEventCallbackWithOptionsAsync(GetEventCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventCallback",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEventCallbackResponse GetEventCallback(GetEventCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEventCallbackWithOptions(request, runtime);
        }

        public async Task<GetEventCallbackResponse> GetEventCallbackAsync(GetEventCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEventCallbackWithOptionsAsync(request, runtime);
        }

        public GetLiveEditingIndexFileResponse GetLiveEditingIndexFileWithOptions(GetLiveEditingIndexFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveEditingIndexFile",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveEditingIndexFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetLiveEditingIndexFileResponse> GetLiveEditingIndexFileWithOptionsAsync(GetLiveEditingIndexFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveEditingIndexFile",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveEditingIndexFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetLiveEditingIndexFileResponse GetLiveEditingIndexFile(GetLiveEditingIndexFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveEditingIndexFileWithOptions(request, runtime);
        }

        public async Task<GetLiveEditingIndexFileResponse> GetLiveEditingIndexFileAsync(GetLiveEditingIndexFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveEditingIndexFileWithOptionsAsync(request, runtime);
        }

        public GetLiveEditingJobResponse GetLiveEditingJobWithOptions(GetLiveEditingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobId"] = request.JobId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveEditingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveEditingJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetLiveEditingJobResponse> GetLiveEditingJobWithOptionsAsync(GetLiveEditingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobId"] = request.JobId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveEditingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveEditingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetLiveEditingJobResponse GetLiveEditingJob(GetLiveEditingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveEditingJobWithOptions(request, runtime);
        }

        public async Task<GetLiveEditingJobResponse> GetLiveEditingJobAsync(GetLiveEditingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveEditingJobWithOptionsAsync(request, runtime);
        }

        public GetMediaInfoResponse GetMediaInfoWithOptions(GetMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InputURL"] = request.InputURL;
            query["MediaId"] = request.MediaId;
            query["OutputType"] = request.OutputType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMediaInfoResponse> GetMediaInfoWithOptionsAsync(GetMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["InputURL"] = request.InputURL;
            query["MediaId"] = request.MediaId;
            query["OutputType"] = request.OutputType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMediaInfoResponse GetMediaInfo(GetMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaInfoWithOptions(request, runtime);
        }

        public async Task<GetMediaInfoResponse> GetMediaInfoAsync(GetMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaInfoWithOptionsAsync(request, runtime);
        }

        public GetMediaProducingJobResponse GetMediaProducingJobWithOptions(GetMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaProducingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaProducingJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMediaProducingJobResponse> GetMediaProducingJobWithOptionsAsync(GetMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaProducingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaProducingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMediaProducingJobResponse GetMediaProducingJob(GetMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaProducingJobWithOptions(request, runtime);
        }

        public async Task<GetMediaProducingJobResponse> GetMediaProducingJobAsync(GetMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaProducingJobWithOptionsAsync(request, runtime);
        }

        public GetPublicMediaInfoResponse GetPublicMediaInfoWithOptions(GetPublicMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublicMediaInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublicMediaInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPublicMediaInfoResponse> GetPublicMediaInfoWithOptionsAsync(GetPublicMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublicMediaInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPublicMediaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPublicMediaInfoResponse GetPublicMediaInfo(GetPublicMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPublicMediaInfoWithOptions(request, runtime);
        }

        public async Task<GetPublicMediaInfoResponse> GetPublicMediaInfoAsync(GetPublicMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPublicMediaInfoWithOptionsAsync(request, runtime);
        }

        public GetSmartHandleJobResponse GetSmartHandleJobWithOptions(GetSmartHandleJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmartHandleJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmartHandleJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSmartHandleJobResponse> GetSmartHandleJobWithOptionsAsync(GetSmartHandleJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSmartHandleJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmartHandleJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSmartHandleJobResponse GetSmartHandleJob(GetSmartHandleJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmartHandleJobWithOptions(request, runtime);
        }

        public async Task<GetSmartHandleJobResponse> GetSmartHandleJobAsync(GetSmartHandleJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmartHandleJobWithOptionsAsync(request, runtime);
        }

        public GetTemplateResponse GetTemplateWithOptions(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateWithOptions(request, runtime);
        }

        public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateWithOptionsAsync(request, runtime);
        }

        public GetTemplateMaterialsResponse GetTemplateMaterialsWithOptions(GetTemplateMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateMaterials",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateMaterialsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTemplateMaterialsResponse> GetTemplateMaterialsWithOptionsAsync(GetTemplateMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateMaterials",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateMaterialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTemplateMaterialsResponse GetTemplateMaterials(GetTemplateMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateMaterialsWithOptions(request, runtime);
        }

        public async Task<GetTemplateMaterialsResponse> GetTemplateMaterialsAsync(GetTemplateMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateMaterialsWithOptionsAsync(request, runtime);
        }

        public ListAllPublicMediaTagsResponse ListAllPublicMediaTagsWithOptions(ListAllPublicMediaTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BusinessType"] = request.BusinessType;
            query["EntityId"] = request.EntityId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllPublicMediaTags",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllPublicMediaTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAllPublicMediaTagsResponse> ListAllPublicMediaTagsWithOptionsAsync(ListAllPublicMediaTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BusinessType"] = request.BusinessType;
            query["EntityId"] = request.EntityId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllPublicMediaTags",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllPublicMediaTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAllPublicMediaTagsResponse ListAllPublicMediaTags(ListAllPublicMediaTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllPublicMediaTagsWithOptions(request, runtime);
        }

        public async Task<ListAllPublicMediaTagsResponse> ListAllPublicMediaTagsAsync(ListAllPublicMediaTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllPublicMediaTagsWithOptionsAsync(request, runtime);
        }

        public ListMediaBasicInfosResponse ListMediaBasicInfosWithOptions(ListMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BusinessType"] = request.BusinessType;
            query["Category"] = request.Category;
            query["EndTime"] = request.EndTime;
            query["IncludeFileBasicInfo"] = request.IncludeFileBasicInfo;
            query["MaxResults"] = request.MaxResults;
            query["MediaType"] = request.MediaType;
            query["NextToken"] = request.NextToken;
            query["SortBy"] = request.SortBy;
            query["Source"] = request.Source;
            query["StartTime"] = request.StartTime;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMediaBasicInfos",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaBasicInfosResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMediaBasicInfosResponse> ListMediaBasicInfosWithOptionsAsync(ListMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BusinessType"] = request.BusinessType;
            query["Category"] = request.Category;
            query["EndTime"] = request.EndTime;
            query["IncludeFileBasicInfo"] = request.IncludeFileBasicInfo;
            query["MaxResults"] = request.MaxResults;
            query["MediaType"] = request.MediaType;
            query["NextToken"] = request.NextToken;
            query["SortBy"] = request.SortBy;
            query["Source"] = request.Source;
            query["StartTime"] = request.StartTime;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMediaBasicInfos",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaBasicInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMediaBasicInfosResponse ListMediaBasicInfos(ListMediaBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaBasicInfosWithOptions(request, runtime);
        }

        public async Task<ListMediaBasicInfosResponse> ListMediaBasicInfosAsync(ListMediaBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaBasicInfosWithOptionsAsync(request, runtime);
        }

        public ListMediaProducingJobsResponse ListMediaProducingJobsWithOptions(ListMediaProducingJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMediaProducingJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaProducingJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMediaProducingJobsResponse> ListMediaProducingJobsWithOptionsAsync(ListMediaProducingJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMediaProducingJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaProducingJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMediaProducingJobsResponse ListMediaProducingJobs(ListMediaProducingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaProducingJobsWithOptions(request, runtime);
        }

        public async Task<ListMediaProducingJobsResponse> ListMediaProducingJobsAsync(ListMediaProducingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaProducingJobsWithOptionsAsync(request, runtime);
        }

        public ListPublicMediaBasicInfosResponse ListPublicMediaBasicInfosWithOptions(ListPublicMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["IncludeFileBasicInfo"] = request.IncludeFileBasicInfo;
            query["MaxResults"] = request.MaxResults;
            query["MediaTagId"] = request.MediaTagId;
            query["NextToken"] = request.NextToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublicMediaBasicInfos",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublicMediaBasicInfosResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPublicMediaBasicInfosResponse> ListPublicMediaBasicInfosWithOptionsAsync(ListPublicMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["IncludeFileBasicInfo"] = request.IncludeFileBasicInfo;
            query["MaxResults"] = request.MaxResults;
            query["MediaTagId"] = request.MediaTagId;
            query["NextToken"] = request.NextToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublicMediaBasicInfos",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublicMediaBasicInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPublicMediaBasicInfosResponse ListPublicMediaBasicInfos(ListPublicMediaBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublicMediaBasicInfosWithOptions(request, runtime);
        }

        public async Task<ListPublicMediaBasicInfosResponse> ListPublicMediaBasicInfosAsync(ListPublicMediaBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublicMediaBasicInfosWithOptionsAsync(request, runtime);
        }

        public ListSmartJobsResponse ListSmartJobsWithOptions(ListSmartJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSmartJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSmartJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSmartJobsResponse> ListSmartJobsWithOptionsAsync(ListSmartJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSmartJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSmartJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSmartJobsResponse ListSmartJobs(ListSmartJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSmartJobsWithOptions(request, runtime);
        }

        public async Task<ListSmartJobsResponse> ListSmartJobsAsync(ListSmartJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSmartJobsWithOptionsAsync(request, runtime);
        }

        public ListSysTemplatesResponse ListSysTemplatesWithOptions(ListSysTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSysTemplates",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSysTemplatesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSysTemplatesResponse> ListSysTemplatesWithOptionsAsync(ListSysTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSysTemplates",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSysTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSysTemplatesResponse ListSysTemplates(ListSysTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSysTemplatesWithOptions(request, runtime);
        }

        public async Task<ListSysTemplatesResponse> ListSysTemplatesAsync(ListSysTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSysTemplatesWithOptionsAsync(request, runtime);
        }

        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CreateSource"] = request.CreateSource;
            query["Keyword"] = request.Keyword;
            query["SortType"] = request.SortType;
            query["Status"] = request.Status;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2020-11-09",
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

        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CreateSource"] = request.CreateSource;
            query["Keyword"] = request.Keyword;
            query["SortType"] = request.SortType;
            query["Status"] = request.Status;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2020-11-09",
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

        public ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplatesWithOptions(request, runtime);
        }

        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplatesWithOptionsAsync(request, runtime);
        }

        public RegisterMediaInfoResponse RegisterMediaInfoWithOptions(RegisterMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BusinessType"] = request.BusinessType;
            query["Category"] = request.Category;
            query["ClientToken"] = request.ClientToken;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["DynamicMetaDataList"] = request.DynamicMetaDataList;
            query["InputURL"] = request.InputURL;
            query["MediaTags"] = request.MediaTags;
            query["MediaType"] = request.MediaType;
            query["Overwrite"] = request.Overwrite;
            query["RegisterConfig"] = request.RegisterConfig;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterMediaInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterMediaInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegisterMediaInfoResponse> RegisterMediaInfoWithOptionsAsync(RegisterMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BusinessType"] = request.BusinessType;
            query["Category"] = request.Category;
            query["ClientToken"] = request.ClientToken;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["DynamicMetaDataList"] = request.DynamicMetaDataList;
            query["InputURL"] = request.InputURL;
            query["MediaTags"] = request.MediaTags;
            query["MediaType"] = request.MediaType;
            query["Overwrite"] = request.Overwrite;
            query["RegisterConfig"] = request.RegisterConfig;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterMediaInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterMediaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RegisterMediaInfoResponse RegisterMediaInfo(RegisterMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterMediaInfoWithOptions(request, runtime);
        }

        public async Task<RegisterMediaInfoResponse> RegisterMediaInfoAsync(RegisterMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterMediaInfoWithOptionsAsync(request, runtime);
        }

        public SearchEditingProjectResponse SearchEditingProjectWithOptions(SearchEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CreateSource"] = request.CreateSource;
            query["EndTime"] = request.EndTime;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["ProjectType"] = request.ProjectType;
            query["SortBy"] = request.SortBy;
            query["StartTime"] = request.StartTime;
            query["Status"] = request.Status;
            query["TemplateType"] = request.TemplateType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchEditingProject",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchEditingProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SearchEditingProjectResponse> SearchEditingProjectWithOptionsAsync(SearchEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CreateSource"] = request.CreateSource;
            query["EndTime"] = request.EndTime;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["ProjectType"] = request.ProjectType;
            query["SortBy"] = request.SortBy;
            query["StartTime"] = request.StartTime;
            query["Status"] = request.Status;
            query["TemplateType"] = request.TemplateType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchEditingProject",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchEditingProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SearchEditingProjectResponse SearchEditingProject(SearchEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchEditingProjectWithOptions(request, runtime);
        }

        public async Task<SearchEditingProjectResponse> SearchEditingProjectAsync(SearchEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchEditingProjectWithOptionsAsync(request, runtime);
        }

        public SearchPublicMediaInfoResponse SearchPublicMediaInfoWithOptions(SearchPublicMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Authorized"] = request.Authorized;
            query["DynamicMetaDataMatchFields"] = request.DynamicMetaDataMatchFields;
            query["EntityId"] = request.EntityId;
            query["Favorite"] = request.Favorite;
            query["MediaIds"] = request.MediaIds;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["SortBy"] = request.SortBy;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchPublicMediaInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchPublicMediaInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SearchPublicMediaInfoResponse> SearchPublicMediaInfoWithOptionsAsync(SearchPublicMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Authorized"] = request.Authorized;
            query["DynamicMetaDataMatchFields"] = request.DynamicMetaDataMatchFields;
            query["EntityId"] = request.EntityId;
            query["Favorite"] = request.Favorite;
            query["MediaIds"] = request.MediaIds;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["SortBy"] = request.SortBy;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchPublicMediaInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchPublicMediaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SearchPublicMediaInfoResponse SearchPublicMediaInfo(SearchPublicMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchPublicMediaInfoWithOptions(request, runtime);
        }

        public async Task<SearchPublicMediaInfoResponse> SearchPublicMediaInfoAsync(SearchPublicMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchPublicMediaInfoWithOptionsAsync(request, runtime);
        }

        public SetDefaultStorageLocationResponse SetDefaultStorageLocationWithOptions(SetDefaultStorageLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Bucket"] = request.Bucket;
            query["Path"] = request.Path;
            query["StorageType"] = request.StorageType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultStorageLocation",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultStorageLocationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDefaultStorageLocationResponse> SetDefaultStorageLocationWithOptionsAsync(SetDefaultStorageLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Bucket"] = request.Bucket;
            query["Path"] = request.Path;
            query["StorageType"] = request.StorageType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultStorageLocation",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultStorageLocationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDefaultStorageLocationResponse SetDefaultStorageLocation(SetDefaultStorageLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultStorageLocationWithOptions(request, runtime);
        }

        public async Task<SetDefaultStorageLocationResponse> SetDefaultStorageLocationAsync(SetDefaultStorageLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultStorageLocationWithOptionsAsync(request, runtime);
        }

        public SetEventCallbackResponse SetEventCallbackWithOptions(SetEventCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallbackQueueName"] = request.CallbackQueueName;
            query["EventTypeList"] = request.EventTypeList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetEventCallback",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetEventCallbackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetEventCallbackResponse> SetEventCallbackWithOptionsAsync(SetEventCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CallbackQueueName"] = request.CallbackQueueName;
            query["EventTypeList"] = request.EventTypeList;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetEventCallback",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetEventCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetEventCallbackResponse SetEventCallback(SetEventCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetEventCallbackWithOptions(request, runtime);
        }

        public async Task<SetEventCallbackResponse> SetEventCallbackAsync(SetEventCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetEventCallbackWithOptionsAsync(request, runtime);
        }

        public SubmitASRJobResponse SubmitASRJobWithOptions(SubmitASRJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["Duration"] = request.Duration;
            query["InputFile"] = request.InputFile;
            query["StartTime"] = request.StartTime;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitASRJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitASRJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitASRJobResponse> SubmitASRJobWithOptionsAsync(SubmitASRJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["Duration"] = request.Duration;
            query["InputFile"] = request.InputFile;
            query["StartTime"] = request.StartTime;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitASRJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitASRJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitASRJobResponse SubmitASRJob(SubmitASRJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitASRJobWithOptions(request, runtime);
        }

        public async Task<SubmitASRJobResponse> SubmitASRJobAsync(SubmitASRJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitASRJobWithOptionsAsync(request, runtime);
        }

        public SubmitAudioProduceJobResponse SubmitAudioProduceJobWithOptions(SubmitAudioProduceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["EditingConfig"] = request.EditingConfig;
            query["InputConfig"] = request.InputConfig;
            query["OutputConfig"] = request.OutputConfig;
            query["Overwrite"] = request.Overwrite;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAudioProduceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAudioProduceJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitAudioProduceJobResponse> SubmitAudioProduceJobWithOptionsAsync(SubmitAudioProduceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["EditingConfig"] = request.EditingConfig;
            query["InputConfig"] = request.InputConfig;
            query["OutputConfig"] = request.OutputConfig;
            query["Overwrite"] = request.Overwrite;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAudioProduceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAudioProduceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitAudioProduceJobResponse SubmitAudioProduceJob(SubmitAudioProduceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAudioProduceJobWithOptions(request, runtime);
        }

        public async Task<SubmitAudioProduceJobResponse> SubmitAudioProduceJobAsync(SubmitAudioProduceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAudioProduceJobWithOptionsAsync(request, runtime);
        }

        public SubmitDelogoJobResponse SubmitDelogoJobWithOptions(SubmitDelogoJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["InputFile"] = request.InputFile;
            query["InputType"] = request.InputType;
            query["OutputConfig"] = request.OutputConfig;
            query["OutputMediaTarget"] = request.OutputMediaTarget;
            query["Overwrite"] = request.Overwrite;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDelogoJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDelogoJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitDelogoJobResponse> SubmitDelogoJobWithOptionsAsync(SubmitDelogoJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["InputFile"] = request.InputFile;
            query["InputType"] = request.InputType;
            query["OutputConfig"] = request.OutputConfig;
            query["OutputMediaTarget"] = request.OutputMediaTarget;
            query["Overwrite"] = request.Overwrite;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDelogoJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDelogoJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitDelogoJobResponse SubmitDelogoJob(SubmitDelogoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDelogoJobWithOptions(request, runtime);
        }

        public async Task<SubmitDelogoJobResponse> SubmitDelogoJobAsync(SubmitDelogoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDelogoJobWithOptionsAsync(request, runtime);
        }

        public SubmitDynamicChartJobResponse SubmitDynamicChartJobWithOptions(SubmitDynamicChartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AxisParams"] = request.AxisParams;
            query["Background"] = request.Background;
            query["ChartConfig"] = request.ChartConfig;
            query["ChartTitle"] = request.ChartTitle;
            query["ChartType"] = request.ChartType;
            query["DataSource"] = request.DataSource;
            query["Description"] = request.Description;
            query["Input"] = request.Input;
            query["OutputConfig"] = request.OutputConfig;
            query["Subtitle"] = request.Subtitle;
            query["Title"] = request.Title;
            query["Unit"] = request.Unit;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDynamicChartJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDynamicChartJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitDynamicChartJobResponse> SubmitDynamicChartJobWithOptionsAsync(SubmitDynamicChartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AxisParams"] = request.AxisParams;
            query["Background"] = request.Background;
            query["ChartConfig"] = request.ChartConfig;
            query["ChartTitle"] = request.ChartTitle;
            query["ChartType"] = request.ChartType;
            query["DataSource"] = request.DataSource;
            query["Description"] = request.Description;
            query["Input"] = request.Input;
            query["OutputConfig"] = request.OutputConfig;
            query["Subtitle"] = request.Subtitle;
            query["Title"] = request.Title;
            query["Unit"] = request.Unit;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDynamicChartJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDynamicChartJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitDynamicChartJobResponse SubmitDynamicChartJob(SubmitDynamicChartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDynamicChartJobWithOptions(request, runtime);
        }

        public async Task<SubmitDynamicChartJobResponse> SubmitDynamicChartJobAsync(SubmitDynamicChartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDynamicChartJobWithOptionsAsync(request, runtime);
        }

        public SubmitH2VJobResponse SubmitH2VJobWithOptions(SubmitH2VJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["InputFile"] = request.InputFile;
            query["InputType"] = request.InputType;
            query["OutputConfig"] = request.OutputConfig;
            query["OutputMediaTarget"] = request.OutputMediaTarget;
            query["Overwrite"] = request.Overwrite;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitH2VJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitH2VJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitH2VJobResponse> SubmitH2VJobWithOptionsAsync(SubmitH2VJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["InputFile"] = request.InputFile;
            query["InputType"] = request.InputType;
            query["OutputConfig"] = request.OutputConfig;
            query["OutputMediaTarget"] = request.OutputMediaTarget;
            query["Overwrite"] = request.Overwrite;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitH2VJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitH2VJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitH2VJobResponse SubmitH2VJob(SubmitH2VJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitH2VJobWithOptions(request, runtime);
        }

        public async Task<SubmitH2VJobResponse> SubmitH2VJobAsync(SubmitH2VJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitH2VJobWithOptionsAsync(request, runtime);
        }

        public SubmitKeyWordCutJobResponse SubmitKeyWordCutJobWithOptions(SubmitKeyWordCutJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitKeyWordCutJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitKeyWordCutJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitKeyWordCutJobResponse> SubmitKeyWordCutJobWithOptionsAsync(SubmitKeyWordCutJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitKeyWordCutJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitKeyWordCutJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitKeyWordCutJobResponse SubmitKeyWordCutJob(SubmitKeyWordCutJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitKeyWordCutJobWithOptions(request, runtime);
        }

        public async Task<SubmitKeyWordCutJobResponse> SubmitKeyWordCutJobAsync(SubmitKeyWordCutJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitKeyWordCutJobWithOptionsAsync(request, runtime);
        }

        public SubmitLiveEditingJobResponse SubmitLiveEditingJobWithOptions(SubmitLiveEditingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Clips"] = request.Clips;
            query["LiveStreamConfig"] = request.LiveStreamConfig;
            query["MediaProduceConfig"] = request.MediaProduceConfig;
            query["OutputMediaConfig"] = request.OutputMediaConfig;
            query["OutputMediaTarget"] = request.OutputMediaTarget;
            query["ProjectId"] = request.ProjectId;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitLiveEditingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitLiveEditingJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitLiveEditingJobResponse> SubmitLiveEditingJobWithOptionsAsync(SubmitLiveEditingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Clips"] = request.Clips;
            query["LiveStreamConfig"] = request.LiveStreamConfig;
            query["MediaProduceConfig"] = request.MediaProduceConfig;
            query["OutputMediaConfig"] = request.OutputMediaConfig;
            query["OutputMediaTarget"] = request.OutputMediaTarget;
            query["ProjectId"] = request.ProjectId;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitLiveEditingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitLiveEditingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitLiveEditingJobResponse SubmitLiveEditingJob(SubmitLiveEditingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitLiveEditingJobWithOptions(request, runtime);
        }

        public async Task<SubmitLiveEditingJobResponse> SubmitLiveEditingJobAsync(SubmitLiveEditingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitLiveEditingJobWithOptionsAsync(request, runtime);
        }

        public SubmitMattingJobResponse SubmitMattingJobWithOptions(SubmitMattingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["InputFile"] = request.InputFile;
            query["InputType"] = request.InputType;
            query["OutputConfig"] = request.OutputConfig;
            query["OutputMediaTarget"] = request.OutputMediaTarget;
            query["Overwrite"] = request.Overwrite;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitMattingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMattingJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitMattingJobResponse> SubmitMattingJobWithOptionsAsync(SubmitMattingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["InputFile"] = request.InputFile;
            query["InputType"] = request.InputType;
            query["OutputConfig"] = request.OutputConfig;
            query["OutputMediaTarget"] = request.OutputMediaTarget;
            query["Overwrite"] = request.Overwrite;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitMattingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMattingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitMattingJobResponse SubmitMattingJob(SubmitMattingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMattingJobWithOptions(request, runtime);
        }

        public async Task<SubmitMattingJobResponse> SubmitMattingJobAsync(SubmitMattingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMattingJobWithOptionsAsync(request, runtime);
        }

        public SubmitMediaProducingJobResponse SubmitMediaProducingJobWithOptions(SubmitMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["ClipsParam"] = request.ClipsParam;
            query["EditingProduceConfig"] = request.EditingProduceConfig;
            query["OutputMediaConfig"] = request.OutputMediaConfig;
            query["OutputMediaTarget"] = request.OutputMediaTarget;
            query["ProjectId"] = request.ProjectId;
            query["ProjectMetadata"] = request.ProjectMetadata;
            query["Source"] = request.Source;
            query["TemplateId"] = request.TemplateId;
            query["Timeline"] = request.Timeline;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitMediaProducingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMediaProducingJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitMediaProducingJobResponse> SubmitMediaProducingJobWithOptionsAsync(SubmitMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["ClipsParam"] = request.ClipsParam;
            query["EditingProduceConfig"] = request.EditingProduceConfig;
            query["OutputMediaConfig"] = request.OutputMediaConfig;
            query["OutputMediaTarget"] = request.OutputMediaTarget;
            query["ProjectId"] = request.ProjectId;
            query["ProjectMetadata"] = request.ProjectMetadata;
            query["Source"] = request.Source;
            query["TemplateId"] = request.TemplateId;
            query["Timeline"] = request.Timeline;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitMediaProducingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMediaProducingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitMediaProducingJobResponse SubmitMediaProducingJob(SubmitMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaProducingJobWithOptions(request, runtime);
        }

        public async Task<SubmitMediaProducingJobResponse> SubmitMediaProducingJobAsync(SubmitMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaProducingJobWithOptionsAsync(request, runtime);
        }

        public SubmitPPTCutJobResponse SubmitPPTCutJobWithOptions(SubmitPPTCutJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitPPTCutJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitPPTCutJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitPPTCutJobResponse> SubmitPPTCutJobWithOptionsAsync(SubmitPPTCutJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitPPTCutJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitPPTCutJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitPPTCutJobResponse SubmitPPTCutJob(SubmitPPTCutJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitPPTCutJobWithOptions(request, runtime);
        }

        public async Task<SubmitPPTCutJobResponse> SubmitPPTCutJobAsync(SubmitPPTCutJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitPPTCutJobWithOptionsAsync(request, runtime);
        }

        public SubmitSubtitleProduceJobResponse SubmitSubtitleProduceJobWithOptions(SubmitSubtitleProduceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["EditingConfig"] = request.EditingConfig;
            query["InputConfig"] = request.InputConfig;
            query["IsAsync"] = request.IsAsync;
            query["OutputConfig"] = request.OutputConfig;
            query["Title"] = request.Title;
            query["Type"] = request.Type;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSubtitleProduceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSubtitleProduceJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitSubtitleProduceJobResponse> SubmitSubtitleProduceJobWithOptionsAsync(SubmitSubtitleProduceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Description"] = request.Description;
            query["EditingConfig"] = request.EditingConfig;
            query["InputConfig"] = request.InputConfig;
            query["IsAsync"] = request.IsAsync;
            query["OutputConfig"] = request.OutputConfig;
            query["Title"] = request.Title;
            query["Type"] = request.Type;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSubtitleProduceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSubtitleProduceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitSubtitleProduceJobResponse SubmitSubtitleProduceJob(SubmitSubtitleProduceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSubtitleProduceJobWithOptions(request, runtime);
        }

        public async Task<SubmitSubtitleProduceJobResponse> SubmitSubtitleProduceJobAsync(SubmitSubtitleProduceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSubtitleProduceJobWithOptionsAsync(request, runtime);
        }

        public UpdateEditingProjectResponse UpdateEditingProjectWithOptions(UpdateEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BusinessStatus"] = request.BusinessStatus;
            query["ClipsParam"] = request.ClipsParam;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["ProjectId"] = request.ProjectId;
            query["TemplateId"] = request.TemplateId;
            query["Timeline"] = request.Timeline;
            query["Title"] = request.Title;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEditingProject",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEditingProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateEditingProjectResponse> UpdateEditingProjectWithOptionsAsync(UpdateEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BusinessStatus"] = request.BusinessStatus;
            query["ClipsParam"] = request.ClipsParam;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["ProjectId"] = request.ProjectId;
            query["TemplateId"] = request.TemplateId;
            query["Timeline"] = request.Timeline;
            query["Title"] = request.Title;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEditingProject",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEditingProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateEditingProjectResponse UpdateEditingProject(UpdateEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEditingProjectWithOptions(request, runtime);
        }

        public async Task<UpdateEditingProjectResponse> UpdateEditingProjectAsync(UpdateEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEditingProjectWithOptionsAsync(request, runtime);
        }

        public UpdateMediaInfoResponse UpdateMediaInfoWithOptions(UpdateMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppendDynamicMeta"] = request.AppendDynamicMeta;
            query["AppendTags"] = request.AppendTags;
            query["BusinessType"] = request.BusinessType;
            query["Category"] = request.Category;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["DynamicMetaDataList"] = request.DynamicMetaDataList;
            query["InputURL"] = request.InputURL;
            query["MediaId"] = request.MediaId;
            query["MediaTags"] = request.MediaTags;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMediaInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMediaInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateMediaInfoResponse> UpdateMediaInfoWithOptionsAsync(UpdateMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppendDynamicMeta"] = request.AppendDynamicMeta;
            query["AppendTags"] = request.AppendTags;
            query["BusinessType"] = request.BusinessType;
            query["Category"] = request.Category;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["DynamicMetaDataList"] = request.DynamicMetaDataList;
            query["InputURL"] = request.InputURL;
            query["MediaId"] = request.MediaId;
            query["MediaTags"] = request.MediaTags;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMediaInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMediaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateMediaInfoResponse UpdateMediaInfo(UpdateMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaInfoWithOptions(request, runtime);
        }

        public async Task<UpdateMediaInfoResponse> UpdateMediaInfoAsync(UpdateMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaInfoWithOptionsAsync(request, runtime);
        }

        public UpdateSmartJobResponse UpdateSmartJobWithOptions(UpdateSmartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FEExtend"] = request.FEExtend;
            query["JobId"] = request.JobId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSmartJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSmartJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateSmartJobResponse> UpdateSmartJobWithOptionsAsync(UpdateSmartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["FEExtend"] = request.FEExtend;
            query["JobId"] = request.JobId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSmartJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSmartJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateSmartJobResponse UpdateSmartJob(UpdateSmartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSmartJobWithOptions(request, runtime);
        }

        public async Task<UpdateSmartJobResponse> UpdateSmartJobAsync(UpdateSmartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSmartJobWithOptionsAsync(request, runtime);
        }

        public UpdateTemplateResponse UpdateTemplateWithOptions(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Config"] = request.Config;
            query["CoverUrl"] = request.CoverUrl;
            query["Name"] = request.Name;
            query["PreviewMedia"] = request.PreviewMedia;
            query["RelatedMediaids"] = request.RelatedMediaids;
            query["Source"] = request.Source;
            query["Status"] = request.Status;
            query["TemplateId"] = request.TemplateId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2020-11-09",
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

        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Config"] = request.Config;
            query["CoverUrl"] = request.CoverUrl;
            query["Name"] = request.Name;
            query["PreviewMedia"] = request.PreviewMedia;
            query["RelatedMediaids"] = request.RelatedMediaids;
            query["Source"] = request.Source;
            query["Status"] = request.Status;
            query["TemplateId"] = request.TemplateId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2020-11-09",
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

        public UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTemplateWithOptionsAsync(request, runtime);
        }

    }
}
