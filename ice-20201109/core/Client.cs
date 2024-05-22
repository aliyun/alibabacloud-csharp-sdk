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
            this._signatureAlgorithm = "v2";
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

        /**
         * @summary 创建媒资分类
         *
         * @param request AddCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCategoryResponse
         */
        public AddCategoryResponse AddCategoryWithOptions(AddCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateName))
            {
                query["CateName"] = request.CateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
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
                Action = "AddCategory",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCategoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建媒资分类
         *
         * @param request AddCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCategoryResponse
         */
        public async Task<AddCategoryResponse> AddCategoryWithOptionsAsync(AddCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateName))
            {
                query["CateName"] = request.CateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
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
                Action = "AddCategory",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建媒资分类
         *
         * @param request AddCategoryRequest
         * @return AddCategoryResponse
         */
        public AddCategoryResponse AddCategory(AddCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCategoryWithOptions(request, runtime);
        }

        /**
         * @summary 创建媒资分类
         *
         * @param request AddCategoryRequest
         * @return AddCategoryResponse
         */
        public async Task<AddCategoryResponse> AddCategoryAsync(AddCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCategoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 剪辑工程增加素材
         *
         * @param request AddEditingProjectMaterialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddEditingProjectMaterialsResponse
         */
        public AddEditingProjectMaterialsResponse AddEditingProjectMaterialsWithOptions(AddEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialMaps))
            {
                query["MaterialMaps"] = request.MaterialMaps;
            }
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

        /**
         * @summary 剪辑工程增加素材
         *
         * @param request AddEditingProjectMaterialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddEditingProjectMaterialsResponse
         */
        public async Task<AddEditingProjectMaterialsResponse> AddEditingProjectMaterialsWithOptionsAsync(AddEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialMaps))
            {
                query["MaterialMaps"] = request.MaterialMaps;
            }
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

        /**
         * @summary 剪辑工程增加素材
         *
         * @param request AddEditingProjectMaterialsRequest
         * @return AddEditingProjectMaterialsResponse
         */
        public AddEditingProjectMaterialsResponse AddEditingProjectMaterials(AddEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddEditingProjectMaterialsWithOptions(request, runtime);
        }

        /**
         * @summary 剪辑工程增加素材
         *
         * @param request AddEditingProjectMaterialsRequest
         * @return AddEditingProjectMaterialsResponse
         */
        public async Task<AddEditingProjectMaterialsResponse> AddEditingProjectMaterialsAsync(AddEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddEditingProjectMaterialsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 收藏公共媒资
         *
         * @param request AddFavoritePublicMediaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddFavoritePublicMediaResponse
         */
        public AddFavoritePublicMediaResponse AddFavoritePublicMediaWithOptions(AddFavoritePublicMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary 收藏公共媒资
         *
         * @param request AddFavoritePublicMediaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddFavoritePublicMediaResponse
         */
        public async Task<AddFavoritePublicMediaResponse> AddFavoritePublicMediaWithOptionsAsync(AddFavoritePublicMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary 收藏公共媒资
         *
         * @param request AddFavoritePublicMediaRequest
         * @return AddFavoritePublicMediaResponse
         */
        public AddFavoritePublicMediaResponse AddFavoritePublicMedia(AddFavoritePublicMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddFavoritePublicMediaWithOptions(request, runtime);
        }

        /**
         * @summary 收藏公共媒资
         *
         * @param request AddFavoritePublicMediaRequest
         * @return AddFavoritePublicMediaResponse
         */
        public async Task<AddFavoritePublicMediaResponse> AddFavoritePublicMediaAsync(AddFavoritePublicMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddFavoritePublicMediaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 为媒资增加标注信息
         *
         * @param request AddMediaMarksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddMediaMarksResponse
         */
        public AddMediaMarksResponse AddMediaMarksWithOptions(AddMediaMarksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMarks))
            {
                query["MediaMarks"] = request.MediaMarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMediaMarks",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMediaMarksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 为媒资增加标注信息
         *
         * @param request AddMediaMarksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddMediaMarksResponse
         */
        public async Task<AddMediaMarksResponse> AddMediaMarksWithOptionsAsync(AddMediaMarksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMarks))
            {
                query["MediaMarks"] = request.MediaMarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMediaMarks",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMediaMarksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 为媒资增加标注信息
         *
         * @param request AddMediaMarksRequest
         * @return AddMediaMarksResponse
         */
        public AddMediaMarksResponse AddMediaMarks(AddMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMediaMarksWithOptions(request, runtime);
        }

        /**
         * @summary 为媒资增加标注信息
         *
         * @param request AddMediaMarksRequest
         * @return AddMediaMarksResponse
         */
        public async Task<AddMediaMarksResponse> AddMediaMarksAsync(AddMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMediaMarksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary AddTemplate
         *
         * @param request AddTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTemplateResponse
         */
        public AddTemplateResponse AddTemplateWithOptions(AddTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                query["CoverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewMedia))
            {
                query["PreviewMedia"] = request.PreviewMedia;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedMediaids))
            {
                query["RelatedMediaids"] = request.RelatedMediaids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /**
         * @summary AddTemplate
         *
         * @param request AddTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTemplateResponse
         */
        public async Task<AddTemplateResponse> AddTemplateWithOptionsAsync(AddTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                query["CoverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewMedia))
            {
                query["PreviewMedia"] = request.PreviewMedia;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedMediaids))
            {
                query["RelatedMediaids"] = request.RelatedMediaids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /**
         * @summary AddTemplate
         *
         * @param request AddTemplateRequest
         * @return AddTemplateResponse
         */
        public AddTemplateResponse AddTemplate(AddTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTemplateWithOptions(request, runtime);
        }

        /**
         * @summary AddTemplate
         *
         * @param request AddTemplateRequest
         * @return AddTemplateResponse
         */
        public async Task<AddTemplateResponse> AddTemplateAsync(AddTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新搜索索引
         *
         * @param request AlterSearchIndexRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AlterSearchIndexResponse
         */
        public AlterSearchIndexResponse AlterSearchIndexWithOptions(AlterSearchIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexConfig))
            {
                query["IndexConfig"] = request.IndexConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexStatus))
            {
                query["IndexStatus"] = request.IndexStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexType))
            {
                query["IndexType"] = request.IndexType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterSearchIndex",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AlterSearchIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新搜索索引
         *
         * @param request AlterSearchIndexRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AlterSearchIndexResponse
         */
        public async Task<AlterSearchIndexResponse> AlterSearchIndexWithOptionsAsync(AlterSearchIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexConfig))
            {
                query["IndexConfig"] = request.IndexConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexStatus))
            {
                query["IndexStatus"] = request.IndexStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexType))
            {
                query["IndexType"] = request.IndexType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterSearchIndex",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AlterSearchIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新搜索索引
         *
         * @param request AlterSearchIndexRequest
         * @return AlterSearchIndexResponse
         */
        public AlterSearchIndexResponse AlterSearchIndex(AlterSearchIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AlterSearchIndexWithOptions(request, runtime);
        }

        /**
         * @summary 更新搜索索引
         *
         * @param request AlterSearchIndexRequest
         * @return AlterSearchIndexResponse
         */
        public async Task<AlterSearchIndexResponse> AlterSearchIndexAsync(AlterSearchIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AlterSearchIndexWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量获取媒资信息
         *
         * @param request BatchGetMediaInfosRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchGetMediaInfosResponse
         */
        public BatchGetMediaInfosResponse BatchGetMediaInfosWithOptions(BatchGetMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionType))
            {
                query["AdditionType"] = request.AdditionType;
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

        /**
         * @summary 批量获取媒资信息
         *
         * @param request BatchGetMediaInfosRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchGetMediaInfosResponse
         */
        public async Task<BatchGetMediaInfosResponse> BatchGetMediaInfosWithOptionsAsync(BatchGetMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionType))
            {
                query["AdditionType"] = request.AdditionType;
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

        /**
         * @summary 批量获取媒资信息
         *
         * @param request BatchGetMediaInfosRequest
         * @return BatchGetMediaInfosResponse
         */
        public BatchGetMediaInfosResponse BatchGetMediaInfos(BatchGetMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetMediaInfosWithOptions(request, runtime);
        }

        /**
         * @summary 批量获取媒资信息
         *
         * @param request BatchGetMediaInfosRequest
         * @return BatchGetMediaInfosResponse
         */
        public async Task<BatchGetMediaInfosResponse> BatchGetMediaInfosAsync(BatchGetMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetMediaInfosWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 取消DNA作业
         *
         * @param request CancelDNAJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelDNAJobResponse
         */
        public CancelDNAJobResponse CancelDNAJobWithOptions(CancelDNAJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDNAJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDNAJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 取消DNA作业
         *
         * @param request CancelDNAJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelDNAJobResponse
         */
        public async Task<CancelDNAJobResponse> CancelDNAJobWithOptionsAsync(CancelDNAJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDNAJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDNAJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 取消DNA作业
         *
         * @param request CancelDNAJobRequest
         * @return CancelDNAJobResponse
         */
        public CancelDNAJobResponse CancelDNAJob(CancelDNAJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelDNAJobWithOptions(request, runtime);
        }

        /**
         * @summary 取消DNA作业
         *
         * @param request CancelDNAJobRequest
         * @return CancelDNAJobResponse
         */
        public async Task<CancelDNAJobResponse> CancelDNAJobAsync(CancelDNAJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelDNAJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 取消收藏公共媒资
         *
         * @param request CancelFavoritePublicMediaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelFavoritePublicMediaResponse
         */
        public CancelFavoritePublicMediaResponse CancelFavoritePublicMediaWithOptions(CancelFavoritePublicMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary 取消收藏公共媒资
         *
         * @param request CancelFavoritePublicMediaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelFavoritePublicMediaResponse
         */
        public async Task<CancelFavoritePublicMediaResponse> CancelFavoritePublicMediaWithOptionsAsync(CancelFavoritePublicMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary 取消收藏公共媒资
         *
         * @param request CancelFavoritePublicMediaRequest
         * @return CancelFavoritePublicMediaResponse
         */
        public CancelFavoritePublicMediaResponse CancelFavoritePublicMedia(CancelFavoritePublicMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelFavoritePublicMediaWithOptions(request, runtime);
        }

        /**
         * @summary 取消收藏公共媒资
         *
         * @param request CancelFavoritePublicMediaRequest
         * @return CancelFavoritePublicMediaResponse
         */
        public async Task<CancelFavoritePublicMediaResponse> CancelFavoritePublicMediaAsync(CancelFavoritePublicMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelFavoritePublicMediaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交人工审核
         *
         * @param request CreateAuditRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAuditResponse
         */
        public CreateAuditResponse CreateAuditWithOptions(CreateAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditContent))
            {
                query["AuditContent"] = request.AuditContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAudit",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAuditResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交人工审核
         *
         * @param request CreateAuditRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAuditResponse
         */
        public async Task<CreateAuditResponse> CreateAuditWithOptionsAsync(CreateAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditContent))
            {
                query["AuditContent"] = request.AuditContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAudit",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAuditResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交人工审核
         *
         * @param request CreateAuditRequest
         * @return CreateAuditResponse
         */
        public CreateAuditResponse CreateAudit(CreateAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAuditWithOptions(request, runtime);
        }

        /**
         * @summary 提交人工审核
         *
         * @param request CreateAuditRequest
         * @return CreateAuditResponse
         */
        public async Task<CreateAuditResponse> CreateAuditAsync(CreateAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAuditWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建数字人训练任务
         *
         * @param request CreateAvatarTrainingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAvatarTrainingJobResponse
         */
        public CreateAvatarTrainingJobResponse CreateAvatarTrainingJobWithOptions(CreateAvatarTrainingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarDescription))
            {
                query["AvatarDescription"] = request.AvatarDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarName))
            {
                query["AvatarName"] = request.AvatarName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarType))
            {
                query["AvatarType"] = request.AvatarType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Portrait))
            {
                query["Portrait"] = request.Portrait;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Thumbnail))
            {
                query["Thumbnail"] = request.Thumbnail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transparent))
            {
                query["Transparent"] = request.Transparent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Video))
            {
                query["Video"] = request.Video;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAvatarTrainingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAvatarTrainingJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建数字人训练任务
         *
         * @param request CreateAvatarTrainingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAvatarTrainingJobResponse
         */
        public async Task<CreateAvatarTrainingJobResponse> CreateAvatarTrainingJobWithOptionsAsync(CreateAvatarTrainingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarDescription))
            {
                query["AvatarDescription"] = request.AvatarDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarName))
            {
                query["AvatarName"] = request.AvatarName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarType))
            {
                query["AvatarType"] = request.AvatarType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Portrait))
            {
                query["Portrait"] = request.Portrait;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Thumbnail))
            {
                query["Thumbnail"] = request.Thumbnail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transparent))
            {
                query["Transparent"] = request.Transparent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Video))
            {
                query["Video"] = request.Video;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAvatarTrainingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAvatarTrainingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建数字人训练任务
         *
         * @param request CreateAvatarTrainingJobRequest
         * @return CreateAvatarTrainingJobResponse
         */
        public CreateAvatarTrainingJobResponse CreateAvatarTrainingJob(CreateAvatarTrainingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAvatarTrainingJobWithOptions(request, runtime);
        }

        /**
         * @summary 创建数字人训练任务
         *
         * @param request CreateAvatarTrainingJobRequest
         * @return CreateAvatarTrainingJobResponse
         */
        public async Task<CreateAvatarTrainingJobResponse> CreateAvatarTrainingJobAsync(CreateAvatarTrainingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAvatarTrainingJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建媒体处理自定义模板
         *
         * @param request CreateCustomTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomTemplateResponse
         */
        public CreateCustomTemplateResponse CreateCustomTemplateWithOptions(CreateCustomTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subtype))
            {
                query["Subtype"] = request.Subtype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                query["TemplateConfig"] = request.TemplateConfig;
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
                Action = "CreateCustomTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建媒体处理自定义模板
         *
         * @param request CreateCustomTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomTemplateResponse
         */
        public async Task<CreateCustomTemplateResponse> CreateCustomTemplateWithOptionsAsync(CreateCustomTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subtype))
            {
                query["Subtype"] = request.Subtype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                query["TemplateConfig"] = request.TemplateConfig;
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
                Action = "CreateCustomTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建媒体处理自定义模板
         *
         * @param request CreateCustomTemplateRequest
         * @return CreateCustomTemplateResponse
         */
        public CreateCustomTemplateResponse CreateCustomTemplate(CreateCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 创建媒体处理自定义模板
         *
         * @param request CreateCustomTemplateRequest
         * @return CreateCustomTemplateResponse
         */
        public async Task<CreateCustomTemplateResponse> CreateCustomTemplateAsync(CreateCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建人声克隆任务
         *
         * @param request CreateCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomizedVoiceJobResponse
         */
        public CreateCustomizedVoiceJobResponse CreateCustomizedVoiceJobWithOptions(CreateCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                query["Gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                query["Scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceDesc))
            {
                query["VoiceDesc"] = request.VoiceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                query["VoiceId"] = request.VoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceName))
            {
                query["VoiceName"] = request.VoiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomizedVoiceJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建人声克隆任务
         *
         * @param request CreateCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomizedVoiceJobResponse
         */
        public async Task<CreateCustomizedVoiceJobResponse> CreateCustomizedVoiceJobWithOptionsAsync(CreateCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                query["Gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                query["Scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceDesc))
            {
                query["VoiceDesc"] = request.VoiceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                query["VoiceId"] = request.VoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceName))
            {
                query["VoiceName"] = request.VoiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomizedVoiceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建人声克隆任务
         *
         * @param request CreateCustomizedVoiceJobRequest
         * @return CreateCustomizedVoiceJobResponse
         */
        public CreateCustomizedVoiceJobResponse CreateCustomizedVoiceJob(CreateCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomizedVoiceJobWithOptions(request, runtime);
        }

        /**
         * @summary 创建人声克隆任务
         *
         * @param request CreateCustomizedVoiceJobRequest
         * @return CreateCustomizedVoiceJobResponse
         */
        public async Task<CreateCustomizedVoiceJobResponse> CreateCustomizedVoiceJobAsync(CreateCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomizedVoiceJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建指纹库
         *
         * @param request CreateDNADBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDNADBResponse
         */
        public CreateDNADBResponse CreateDNADBWithOptions(CreateDNADBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDNADB",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDNADBResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建指纹库
         *
         * @param request CreateDNADBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDNADBResponse
         */
        public async Task<CreateDNADBResponse> CreateDNADBWithOptionsAsync(CreateDNADBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDNADB",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDNADBResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建指纹库
         *
         * @param request CreateDNADBRequest
         * @return CreateDNADBResponse
         */
        public CreateDNADBResponse CreateDNADB(CreateDNADBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDNADBWithOptions(request, runtime);
        }

        /**
         * @summary 创建指纹库
         *
         * @param request CreateDNADBRequest
         * @return CreateDNADBResponse
         */
        public async Task<CreateDNADBResponse> CreateDNADBAsync(CreateDNADBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDNADBWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建云剪辑工程
         *
         * @param request CreateEditingProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEditingProjectResponse
         */
        public CreateEditingProjectResponse CreateEditingProjectWithOptions(CreateEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessConfig))
            {
                query["BusinessConfig"] = request.BusinessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClipsParam))
            {
                query["ClipsParam"] = request.ClipsParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialMaps))
            {
                query["MaterialMaps"] = request.MaterialMaps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectType))
            {
                query["ProjectType"] = request.ProjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                body["Timeline"] = request.Timeline;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /**
         * @summary 创建云剪辑工程
         *
         * @param request CreateEditingProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEditingProjectResponse
         */
        public async Task<CreateEditingProjectResponse> CreateEditingProjectWithOptionsAsync(CreateEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessConfig))
            {
                query["BusinessConfig"] = request.BusinessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClipsParam))
            {
                query["ClipsParam"] = request.ClipsParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialMaps))
            {
                query["MaterialMaps"] = request.MaterialMaps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectType))
            {
                query["ProjectType"] = request.ProjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                body["Timeline"] = request.Timeline;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /**
         * @summary 创建云剪辑工程
         *
         * @param request CreateEditingProjectRequest
         * @return CreateEditingProjectResponse
         */
        public CreateEditingProjectResponse CreateEditingProject(CreateEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEditingProjectWithOptions(request, runtime);
        }

        /**
         * @summary 创建云剪辑工程
         *
         * @param request CreateEditingProjectRequest
         * @return CreateEditingProjectResponse
         */
        public async Task<CreateEditingProjectResponse> CreateEditingProjectAsync(CreateEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEditingProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建直播录制模板
         *
         * @param tmpReq CreateLiveRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLiveRecordTemplateResponse
         */
        public CreateLiveRecordTemplateResponse CreateLiveRecordTemplateWithOptions(CreateLiveRecordTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateLiveRecordTemplateShrinkRequest request = new CreateLiveRecordTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordFormat))
            {
                request.RecordFormatShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordFormat, "RecordFormat", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFormatShrink))
            {
                body["RecordFormat"] = request.RecordFormatShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLiveRecordTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLiveRecordTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建直播录制模板
         *
         * @param tmpReq CreateLiveRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLiveRecordTemplateResponse
         */
        public async Task<CreateLiveRecordTemplateResponse> CreateLiveRecordTemplateWithOptionsAsync(CreateLiveRecordTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateLiveRecordTemplateShrinkRequest request = new CreateLiveRecordTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordFormat))
            {
                request.RecordFormatShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordFormat, "RecordFormat", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFormatShrink))
            {
                body["RecordFormat"] = request.RecordFormatShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLiveRecordTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLiveRecordTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建直播录制模板
         *
         * @param request CreateLiveRecordTemplateRequest
         * @return CreateLiveRecordTemplateResponse
         */
        public CreateLiveRecordTemplateResponse CreateLiveRecordTemplate(CreateLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLiveRecordTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 创建直播录制模板
         *
         * @param request CreateLiveRecordTemplateRequest
         * @return CreateLiveRecordTemplateResponse
         */
        public async Task<CreateLiveRecordTemplateResponse> CreateLiveRecordTemplateAsync(CreateLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLiveRecordTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建直播截图模板
         *
         * @param request CreateLiveSnapshotTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLiveSnapshotTemplateResponse
         */
        public CreateLiveSnapshotTemplateResponse CreateLiveSnapshotTemplateWithOptions(CreateLiveSnapshotTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverwriteFormat))
            {
                body["OverwriteFormat"] = request.OverwriteFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceFormat))
            {
                body["SequenceFormat"] = request.SequenceFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeInterval))
            {
                body["TimeInterval"] = request.TimeInterval;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLiveSnapshotTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLiveSnapshotTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建直播截图模板
         *
         * @param request CreateLiveSnapshotTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLiveSnapshotTemplateResponse
         */
        public async Task<CreateLiveSnapshotTemplateResponse> CreateLiveSnapshotTemplateWithOptionsAsync(CreateLiveSnapshotTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverwriteFormat))
            {
                body["OverwriteFormat"] = request.OverwriteFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceFormat))
            {
                body["SequenceFormat"] = request.SequenceFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeInterval))
            {
                body["TimeInterval"] = request.TimeInterval;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLiveSnapshotTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLiveSnapshotTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建直播截图模板
         *
         * @param request CreateLiveSnapshotTemplateRequest
         * @return CreateLiveSnapshotTemplateResponse
         */
        public CreateLiveSnapshotTemplateResponse CreateLiveSnapshotTemplate(CreateLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLiveSnapshotTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 创建直播截图模板
         *
         * @param request CreateLiveSnapshotTemplateRequest
         * @return CreateLiveSnapshotTemplateResponse
         */
        public async Task<CreateLiveSnapshotTemplateResponse> CreateLiveSnapshotTemplateAsync(CreateLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLiveSnapshotTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建转码模版
         *
         * @param tmpReq CreateLiveTranscodeTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLiveTranscodeTemplateResponse
         */
        public CreateLiveTranscodeTemplateResponse CreateLiveTranscodeTemplateWithOptions(CreateLiveTranscodeTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateLiveTranscodeTemplateShrinkRequest request = new CreateLiveTranscodeTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateConfig))
            {
                request.TemplateConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateConfig, "TemplateConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfigShrink))
            {
                query["TemplateConfig"] = request.TemplateConfigShrink;
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
                Action = "CreateLiveTranscodeTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLiveTranscodeTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建转码模版
         *
         * @param tmpReq CreateLiveTranscodeTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLiveTranscodeTemplateResponse
         */
        public async Task<CreateLiveTranscodeTemplateResponse> CreateLiveTranscodeTemplateWithOptionsAsync(CreateLiveTranscodeTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateLiveTranscodeTemplateShrinkRequest request = new CreateLiveTranscodeTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateConfig))
            {
                request.TemplateConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateConfig, "TemplateConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfigShrink))
            {
                query["TemplateConfig"] = request.TemplateConfigShrink;
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
                Action = "CreateLiveTranscodeTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLiveTranscodeTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建转码模版
         *
         * @param request CreateLiveTranscodeTemplateRequest
         * @return CreateLiveTranscodeTemplateResponse
         */
        public CreateLiveTranscodeTemplateResponse CreateLiveTranscodeTemplate(CreateLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLiveTranscodeTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 创建转码模版
         *
         * @param request CreateLiveTranscodeTemplateRequest
         * @return CreateLiveTranscodeTemplateResponse
         */
        public async Task<CreateLiveTranscodeTemplateResponse> CreateLiveTranscodeTemplateAsync(CreateLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLiveTranscodeTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 添加用户管道配置
         *
         * @param request CreatePipelineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePipelineResponse
         */
        public CreatePipelineResponse CreatePipelineWithOptions(CreatePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipeline",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加用户管道配置
         *
         * @param request CreatePipelineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePipelineResponse
         */
        public async Task<CreatePipelineResponse> CreatePipelineWithOptionsAsync(CreatePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipeline",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加用户管道配置
         *
         * @param request CreatePipelineRequest
         * @return CreatePipelineResponse
         */
        public CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePipelineWithOptions(request, runtime);
        }

        /**
         * @summary 添加用户管道配置
         *
         * @param request CreatePipelineRequest
         * @return CreatePipelineResponse
         */
        public async Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePipelineWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建搜索索引
         *
         * @param request CreateSearchIndexRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSearchIndexResponse
         */
        public CreateSearchIndexResponse CreateSearchIndexWithOptions(CreateSearchIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexConfig))
            {
                query["IndexConfig"] = request.IndexConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexStatus))
            {
                query["IndexStatus"] = request.IndexStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexType))
            {
                query["IndexType"] = request.IndexType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSearchIndex",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSearchIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建搜索索引
         *
         * @param request CreateSearchIndexRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSearchIndexResponse
         */
        public async Task<CreateSearchIndexResponse> CreateSearchIndexWithOptionsAsync(CreateSearchIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexConfig))
            {
                query["IndexConfig"] = request.IndexConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexStatus))
            {
                query["IndexStatus"] = request.IndexStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexType))
            {
                query["IndexType"] = request.IndexType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSearchIndex",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSearchIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建搜索索引
         *
         * @param request CreateSearchIndexRequest
         * @return CreateSearchIndexResponse
         */
        public CreateSearchIndexResponse CreateSearchIndex(CreateSearchIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSearchIndexWithOptions(request, runtime);
        }

        /**
         * @summary 创建搜索索引
         *
         * @param request CreateSearchIndexRequest
         * @return CreateSearchIndexResponse
         */
        public async Task<CreateSearchIndexResponse> CreateSearchIndexAsync(CreateSearchIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSearchIndexWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建库
         *
         * @param request CreateSearchLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSearchLibResponse
         */
        public CreateSearchLibResponse CreateSearchLibWithOptions(CreateSearchLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSearchLib",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSearchLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建库
         *
         * @param request CreateSearchLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSearchLibResponse
         */
        public async Task<CreateSearchLibResponse> CreateSearchLibWithOptionsAsync(CreateSearchLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSearchLib",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSearchLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建库
         *
         * @param request CreateSearchLibRequest
         * @return CreateSearchLibResponse
         */
        public CreateSearchLibResponse CreateSearchLib(CreateSearchLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSearchLibWithOptions(request, runtime);
        }

        /**
         * @summary 创建库
         *
         * @param request CreateSearchLibRequest
         * @return CreateSearchLibResponse
         */
        public async Task<CreateSearchLibResponse> CreateSearchLibAsync(CreateSearchLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSearchLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 本地媒资上传
         *
         * @param request CreateUploadMediaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUploadMediaResponse
         */
        public CreateUploadMediaResponse CreateUploadMediaWithOptions(CreateUploadMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileInfo))
            {
                query["FileInfo"] = request.FileInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMetaData))
            {
                query["MediaMetaData"] = request.MediaMetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostProcessConfig))
            {
                query["PostProcessConfig"] = request.PostProcessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadTargetConfig))
            {
                query["UploadTargetConfig"] = request.UploadTargetConfig;
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
                Action = "CreateUploadMedia",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUploadMediaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 本地媒资上传
         *
         * @param request CreateUploadMediaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUploadMediaResponse
         */
        public async Task<CreateUploadMediaResponse> CreateUploadMediaWithOptionsAsync(CreateUploadMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileInfo))
            {
                query["FileInfo"] = request.FileInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMetaData))
            {
                query["MediaMetaData"] = request.MediaMetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostProcessConfig))
            {
                query["PostProcessConfig"] = request.PostProcessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadTargetConfig))
            {
                query["UploadTargetConfig"] = request.UploadTargetConfig;
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
                Action = "CreateUploadMedia",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUploadMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 本地媒资上传
         *
         * @param request CreateUploadMediaRequest
         * @return CreateUploadMediaResponse
         */
        public CreateUploadMediaResponse CreateUploadMedia(CreateUploadMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUploadMediaWithOptions(request, runtime);
        }

        /**
         * @summary 本地媒资上传
         *
         * @param request CreateUploadMediaRequest
         * @return CreateUploadMediaResponse
         */
        public async Task<CreateUploadMediaResponse> CreateUploadMediaAsync(CreateUploadMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUploadMediaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 本地上传媒体流
         *
         * @param request CreateUploadStreamRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUploadStreamResponse
         */
        public CreateUploadStreamResponse CreateUploadStreamWithOptions(CreateUploadStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                query["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileExtension))
            {
                query["FileExtension"] = request.FileExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HDRType))
            {
                query["HDRType"] = request.HDRType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "CreateUploadStream",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUploadStreamResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 本地上传媒体流
         *
         * @param request CreateUploadStreamRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUploadStreamResponse
         */
        public async Task<CreateUploadStreamResponse> CreateUploadStreamWithOptionsAsync(CreateUploadStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                query["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileExtension))
            {
                query["FileExtension"] = request.FileExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HDRType))
            {
                query["HDRType"] = request.HDRType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "CreateUploadStream",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUploadStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 本地上传媒体流
         *
         * @param request CreateUploadStreamRequest
         * @return CreateUploadStreamResponse
         */
        public CreateUploadStreamResponse CreateUploadStream(CreateUploadStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUploadStreamWithOptions(request, runtime);
        }

        /**
         * @summary 本地上传媒体流
         *
         * @param request CreateUploadStreamRequest
         * @return CreateUploadStreamResponse
         */
        public async Task<CreateUploadStreamResponse> CreateUploadStreamAsync(CreateUploadStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUploadStreamWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 解密KMS密钥DataKey
         *
         * @param request DecryptKMSDataKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DecryptKMSDataKeyResponse
         */
        public DecryptKMSDataKeyResponse DecryptKMSDataKeyWithOptions(DecryptKMSDataKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DecryptKMSDataKey",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecryptKMSDataKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 解密KMS密钥DataKey
         *
         * @param request DecryptKMSDataKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DecryptKMSDataKeyResponse
         */
        public async Task<DecryptKMSDataKeyResponse> DecryptKMSDataKeyWithOptionsAsync(DecryptKMSDataKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DecryptKMSDataKey",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecryptKMSDataKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 解密KMS密钥DataKey
         *
         * @param request DecryptKMSDataKeyRequest
         * @return DecryptKMSDataKeyResponse
         */
        public DecryptKMSDataKeyResponse DecryptKMSDataKey(DecryptKMSDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DecryptKMSDataKeyWithOptions(request, runtime);
        }

        /**
         * @summary 解密KMS密钥DataKey
         *
         * @param request DecryptKMSDataKeyRequest
         * @return DecryptKMSDataKeyResponse
         */
        public async Task<DecryptKMSDataKeyResponse> DecryptKMSDataKeyAsync(DecryptKMSDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DecryptKMSDataKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新数字人训练任务信息
         *
         * @param request DeleteAvatarTrainingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAvatarTrainingJobResponse
         */
        public DeleteAvatarTrainingJobResponse DeleteAvatarTrainingJobWithOptions(DeleteAvatarTrainingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAvatarTrainingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAvatarTrainingJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新数字人训练任务信息
         *
         * @param request DeleteAvatarTrainingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAvatarTrainingJobResponse
         */
        public async Task<DeleteAvatarTrainingJobResponse> DeleteAvatarTrainingJobWithOptionsAsync(DeleteAvatarTrainingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAvatarTrainingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAvatarTrainingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新数字人训练任务信息
         *
         * @param request DeleteAvatarTrainingJobRequest
         * @return DeleteAvatarTrainingJobResponse
         */
        public DeleteAvatarTrainingJobResponse DeleteAvatarTrainingJob(DeleteAvatarTrainingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAvatarTrainingJobWithOptions(request, runtime);
        }

        /**
         * @summary 更新数字人训练任务信息
         *
         * @param request DeleteAvatarTrainingJobRequest
         * @return DeleteAvatarTrainingJobResponse
         */
        public async Task<DeleteAvatarTrainingJobResponse> DeleteAvatarTrainingJobAsync(DeleteAvatarTrainingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAvatarTrainingJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除媒资分类
         *
         * @param request DeleteCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCategoryResponse
         */
        public DeleteCategoryResponse DeleteCategoryWithOptions(DeleteCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCategory",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCategoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除媒资分类
         *
         * @param request DeleteCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCategoryResponse
         */
        public async Task<DeleteCategoryResponse> DeleteCategoryWithOptionsAsync(DeleteCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCategory",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除媒资分类
         *
         * @param request DeleteCategoryRequest
         * @return DeleteCategoryResponse
         */
        public DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCategoryWithOptions(request, runtime);
        }

        /**
         * @summary 删除媒资分类
         *
         * @param request DeleteCategoryRequest
         * @return DeleteCategoryResponse
         */
        public async Task<DeleteCategoryResponse> DeleteCategoryAsync(DeleteCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCategoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除媒体处理自定义模板
         *
         * @param request DeleteCustomTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomTemplateResponse
         */
        public DeleteCustomTemplateResponse DeleteCustomTemplateWithOptions(DeleteCustomTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除媒体处理自定义模板
         *
         * @param request DeleteCustomTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomTemplateResponse
         */
        public async Task<DeleteCustomTemplateResponse> DeleteCustomTemplateWithOptionsAsync(DeleteCustomTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除媒体处理自定义模板
         *
         * @param request DeleteCustomTemplateRequest
         * @return DeleteCustomTemplateResponse
         */
        public DeleteCustomTemplateResponse DeleteCustomTemplate(DeleteCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 删除媒体处理自定义模板
         *
         * @param request DeleteCustomTemplateRequest
         * @return DeleteCustomTemplateResponse
         */
        public async Task<DeleteCustomTemplateResponse> DeleteCustomTemplateAsync(DeleteCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除用户的专属人声任务
         *
         * @param request DeleteCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomizedVoiceJobResponse
         */
        public DeleteCustomizedVoiceJobResponse DeleteCustomizedVoiceJobWithOptions(DeleteCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomizedVoiceJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除用户的专属人声任务
         *
         * @param request DeleteCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomizedVoiceJobResponse
         */
        public async Task<DeleteCustomizedVoiceJobResponse> DeleteCustomizedVoiceJobWithOptionsAsync(DeleteCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomizedVoiceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除用户的专属人声任务
         *
         * @param request DeleteCustomizedVoiceJobRequest
         * @return DeleteCustomizedVoiceJobResponse
         */
        public DeleteCustomizedVoiceJobResponse DeleteCustomizedVoiceJob(DeleteCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomizedVoiceJobWithOptions(request, runtime);
        }

        /**
         * @summary 删除用户的专属人声任务
         *
         * @param request DeleteCustomizedVoiceJobRequest
         * @return DeleteCustomizedVoiceJobResponse
         */
        public async Task<DeleteCustomizedVoiceJobResponse> DeleteCustomizedVoiceJobAsync(DeleteCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomizedVoiceJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除DNA库
         *
         * @param request DeleteDNADBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDNADBResponse
         */
        public DeleteDNADBResponse DeleteDNADBWithOptions(DeleteDNADBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBId))
            {
                query["DBId"] = request.DBId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDNADB",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDNADBResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除DNA库
         *
         * @param request DeleteDNADBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDNADBResponse
         */
        public async Task<DeleteDNADBResponse> DeleteDNADBWithOptionsAsync(DeleteDNADBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBId))
            {
                query["DBId"] = request.DBId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDNADB",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDNADBResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除DNA库
         *
         * @param request DeleteDNADBRequest
         * @return DeleteDNADBResponse
         */
        public DeleteDNADBResponse DeleteDNADB(DeleteDNADBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDNADBWithOptions(request, runtime);
        }

        /**
         * @summary 删除DNA库
         *
         * @param request DeleteDNADBRequest
         * @return DeleteDNADBResponse
         */
        public async Task<DeleteDNADBResponse> DeleteDNADBAsync(DeleteDNADBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDNADBWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除DNA文件
         *
         * @param request DeleteDNAFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDNAFilesResponse
         */
        public DeleteDNAFilesResponse DeleteDNAFilesWithOptions(DeleteDNAFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBId))
            {
                query["DBId"] = request.DBId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKeys))
            {
                query["PrimaryKeys"] = request.PrimaryKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDNAFiles",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDNAFilesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除DNA文件
         *
         * @param request DeleteDNAFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDNAFilesResponse
         */
        public async Task<DeleteDNAFilesResponse> DeleteDNAFilesWithOptionsAsync(DeleteDNAFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBId))
            {
                query["DBId"] = request.DBId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKeys))
            {
                query["PrimaryKeys"] = request.PrimaryKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDNAFiles",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDNAFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除DNA文件
         *
         * @param request DeleteDNAFilesRequest
         * @return DeleteDNAFilesResponse
         */
        public DeleteDNAFilesResponse DeleteDNAFiles(DeleteDNAFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDNAFilesWithOptions(request, runtime);
        }

        /**
         * @summary 删除DNA文件
         *
         * @param request DeleteDNAFilesRequest
         * @return DeleteDNAFilesResponse
         */
        public async Task<DeleteDNAFilesResponse> DeleteDNAFilesAsync(DeleteDNAFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDNAFilesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除剪辑工程关联素材
         *
         * @param request DeleteEditingProjectMaterialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEditingProjectMaterialsResponse
         */
        public DeleteEditingProjectMaterialsResponse DeleteEditingProjectMaterialsWithOptions(DeleteEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialIds))
            {
                query["MaterialIds"] = request.MaterialIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialType))
            {
                query["MaterialType"] = request.MaterialType;
            }
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

        /**
         * @summary 删除剪辑工程关联素材
         *
         * @param request DeleteEditingProjectMaterialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEditingProjectMaterialsResponse
         */
        public async Task<DeleteEditingProjectMaterialsResponse> DeleteEditingProjectMaterialsWithOptionsAsync(DeleteEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialIds))
            {
                query["MaterialIds"] = request.MaterialIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialType))
            {
                query["MaterialType"] = request.MaterialType;
            }
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

        /**
         * @summary 删除剪辑工程关联素材
         *
         * @param request DeleteEditingProjectMaterialsRequest
         * @return DeleteEditingProjectMaterialsResponse
         */
        public DeleteEditingProjectMaterialsResponse DeleteEditingProjectMaterials(DeleteEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEditingProjectMaterialsWithOptions(request, runtime);
        }

        /**
         * @summary 删除剪辑工程关联素材
         *
         * @param request DeleteEditingProjectMaterialsRequest
         * @return DeleteEditingProjectMaterialsResponse
         */
        public async Task<DeleteEditingProjectMaterialsResponse> DeleteEditingProjectMaterialsAsync(DeleteEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEditingProjectMaterialsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除云剪辑工程
         *
         * @param request DeleteEditingProjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEditingProjectsResponse
         */
        public DeleteEditingProjectsResponse DeleteEditingProjectsWithOptions(DeleteEditingProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                query["ProjectIds"] = request.ProjectIds;
            }
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

        /**
         * @summary 删除云剪辑工程
         *
         * @param request DeleteEditingProjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEditingProjectsResponse
         */
        public async Task<DeleteEditingProjectsResponse> DeleteEditingProjectsWithOptionsAsync(DeleteEditingProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                query["ProjectIds"] = request.ProjectIds;
            }
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

        /**
         * @summary 删除云剪辑工程
         *
         * @param request DeleteEditingProjectsRequest
         * @return DeleteEditingProjectsResponse
         */
        public DeleteEditingProjectsResponse DeleteEditingProjects(DeleteEditingProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEditingProjectsWithOptions(request, runtime);
        }

        /**
         * @summary 删除云剪辑工程
         *
         * @param request DeleteEditingProjectsRequest
         * @return DeleteEditingProjectsResponse
         */
        public async Task<DeleteEditingProjectsResponse> DeleteEditingProjectsAsync(DeleteEditingProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEditingProjectsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 实时媒体服务-删除录制文件
         *
         * @param request DeleteLiveRecordFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLiveRecordFilesResponse
         */
        public DeleteLiveRecordFilesResponse DeleteLiveRecordFilesWithOptions(DeleteLiveRecordFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordIds))
            {
                query["RecordIds"] = request.RecordIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveFile))
            {
                query["RemoveFile"] = request.RemoveFile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLiveRecordFiles",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveRecordFilesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 实时媒体服务-删除录制文件
         *
         * @param request DeleteLiveRecordFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLiveRecordFilesResponse
         */
        public async Task<DeleteLiveRecordFilesResponse> DeleteLiveRecordFilesWithOptionsAsync(DeleteLiveRecordFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordIds))
            {
                query["RecordIds"] = request.RecordIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveFile))
            {
                query["RemoveFile"] = request.RemoveFile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLiveRecordFiles",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveRecordFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 实时媒体服务-删除录制文件
         *
         * @param request DeleteLiveRecordFilesRequest
         * @return DeleteLiveRecordFilesResponse
         */
        public DeleteLiveRecordFilesResponse DeleteLiveRecordFiles(DeleteLiveRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveRecordFilesWithOptions(request, runtime);
        }

        /**
         * @summary 实时媒体服务-删除录制文件
         *
         * @param request DeleteLiveRecordFilesRequest
         * @return DeleteLiveRecordFilesResponse
         */
        public async Task<DeleteLiveRecordFilesResponse> DeleteLiveRecordFilesAsync(DeleteLiveRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveRecordFilesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除直播录制模板
         *
         * @param request DeleteLiveRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLiveRecordTemplateResponse
         */
        public DeleteLiveRecordTemplateResponse DeleteLiveRecordTemplateWithOptions(DeleteLiveRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLiveRecordTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveRecordTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除直播录制模板
         *
         * @param request DeleteLiveRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLiveRecordTemplateResponse
         */
        public async Task<DeleteLiveRecordTemplateResponse> DeleteLiveRecordTemplateWithOptionsAsync(DeleteLiveRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLiveRecordTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveRecordTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除直播录制模板
         *
         * @param request DeleteLiveRecordTemplateRequest
         * @return DeleteLiveRecordTemplateResponse
         */
        public DeleteLiveRecordTemplateResponse DeleteLiveRecordTemplate(DeleteLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveRecordTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 删除直播录制模板
         *
         * @param request DeleteLiveRecordTemplateRequest
         * @return DeleteLiveRecordTemplateResponse
         */
        public async Task<DeleteLiveRecordTemplateResponse> DeleteLiveRecordTemplateAsync(DeleteLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveRecordTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量删除直播截图文件
         *
         * @param tmpReq DeleteLiveSnapshotFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLiveSnapshotFilesResponse
         */
        public DeleteLiveSnapshotFilesResponse DeleteLiveSnapshotFilesWithOptions(DeleteLiveSnapshotFilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteLiveSnapshotFilesShrinkRequest request = new DeleteLiveSnapshotFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateTimestampList))
            {
                request.CreateTimestampListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateTimestampList, "CreateTimestampList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimestampListShrink))
            {
                query["CreateTimestampList"] = request.CreateTimestampListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteOriginalFile))
            {
                query["DeleteOriginalFile"] = request.DeleteOriginalFile;
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
                Action = "DeleteLiveSnapshotFiles",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveSnapshotFilesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量删除直播截图文件
         *
         * @param tmpReq DeleteLiveSnapshotFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLiveSnapshotFilesResponse
         */
        public async Task<DeleteLiveSnapshotFilesResponse> DeleteLiveSnapshotFilesWithOptionsAsync(DeleteLiveSnapshotFilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteLiveSnapshotFilesShrinkRequest request = new DeleteLiveSnapshotFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateTimestampList))
            {
                request.CreateTimestampListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateTimestampList, "CreateTimestampList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimestampListShrink))
            {
                query["CreateTimestampList"] = request.CreateTimestampListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteOriginalFile))
            {
                query["DeleteOriginalFile"] = request.DeleteOriginalFile;
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
                Action = "DeleteLiveSnapshotFiles",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveSnapshotFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量删除直播截图文件
         *
         * @param request DeleteLiveSnapshotFilesRequest
         * @return DeleteLiveSnapshotFilesResponse
         */
        public DeleteLiveSnapshotFilesResponse DeleteLiveSnapshotFiles(DeleteLiveSnapshotFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveSnapshotFilesWithOptions(request, runtime);
        }

        /**
         * @summary 批量删除直播截图文件
         *
         * @param request DeleteLiveSnapshotFilesRequest
         * @return DeleteLiveSnapshotFilesResponse
         */
        public async Task<DeleteLiveSnapshotFilesResponse> DeleteLiveSnapshotFilesAsync(DeleteLiveSnapshotFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveSnapshotFilesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除直播截图模板
         *
         * @param request DeleteLiveSnapshotTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLiveSnapshotTemplateResponse
         */
        public DeleteLiveSnapshotTemplateResponse DeleteLiveSnapshotTemplateWithOptions(DeleteLiveSnapshotTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLiveSnapshotTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveSnapshotTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除直播截图模板
         *
         * @param request DeleteLiveSnapshotTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLiveSnapshotTemplateResponse
         */
        public async Task<DeleteLiveSnapshotTemplateResponse> DeleteLiveSnapshotTemplateWithOptionsAsync(DeleteLiveSnapshotTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLiveSnapshotTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveSnapshotTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除直播截图模板
         *
         * @param request DeleteLiveSnapshotTemplateRequest
         * @return DeleteLiveSnapshotTemplateResponse
         */
        public DeleteLiveSnapshotTemplateResponse DeleteLiveSnapshotTemplate(DeleteLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveSnapshotTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 删除直播截图模板
         *
         * @param request DeleteLiveSnapshotTemplateRequest
         * @return DeleteLiveSnapshotTemplateResponse
         */
        public async Task<DeleteLiveSnapshotTemplateResponse> DeleteLiveSnapshotTemplateAsync(DeleteLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveSnapshotTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除指定转码任务
         *
         * @param request DeleteLiveTranscodeJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLiveTranscodeJobResponse
         */
        public DeleteLiveTranscodeJobResponse DeleteLiveTranscodeJobWithOptions(DeleteLiveTranscodeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteLiveTranscodeJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveTranscodeJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定转码任务
         *
         * @param request DeleteLiveTranscodeJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLiveTranscodeJobResponse
         */
        public async Task<DeleteLiveTranscodeJobResponse> DeleteLiveTranscodeJobWithOptionsAsync(DeleteLiveTranscodeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteLiveTranscodeJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveTranscodeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定转码任务
         *
         * @param request DeleteLiveTranscodeJobRequest
         * @return DeleteLiveTranscodeJobResponse
         */
        public DeleteLiveTranscodeJobResponse DeleteLiveTranscodeJob(DeleteLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveTranscodeJobWithOptions(request, runtime);
        }

        /**
         * @summary 删除指定转码任务
         *
         * @param request DeleteLiveTranscodeJobRequest
         * @return DeleteLiveTranscodeJobResponse
         */
        public async Task<DeleteLiveTranscodeJobResponse> DeleteLiveTranscodeJobAsync(DeleteLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveTranscodeJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除指定转码模版
         *
         * @param request DeleteLiveTranscodeTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLiveTranscodeTemplateResponse
         */
        public DeleteLiveTranscodeTemplateResponse DeleteLiveTranscodeTemplateWithOptions(DeleteLiveTranscodeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLiveTranscodeTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveTranscodeTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除指定转码模版
         *
         * @param request DeleteLiveTranscodeTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLiveTranscodeTemplateResponse
         */
        public async Task<DeleteLiveTranscodeTemplateResponse> DeleteLiveTranscodeTemplateWithOptionsAsync(DeleteLiveTranscodeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLiveTranscodeTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLiveTranscodeTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除指定转码模版
         *
         * @param request DeleteLiveTranscodeTemplateRequest
         * @return DeleteLiveTranscodeTemplateResponse
         */
        public DeleteLiveTranscodeTemplateResponse DeleteLiveTranscodeTemplate(DeleteLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveTranscodeTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 删除指定转码模版
         *
         * @param request DeleteLiveTranscodeTemplateRequest
         * @return DeleteLiveTranscodeTemplateResponse
         */
        public async Task<DeleteLiveTranscodeTemplateResponse> DeleteLiveTranscodeTemplateAsync(DeleteLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveTranscodeTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除媒资从搜索
         *
         * @param request DeleteMediaFromSearchLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMediaFromSearchLibResponse
         */
        public DeleteMediaFromSearchLibResponse DeleteMediaFromSearchLibWithOptions(DeleteMediaFromSearchLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgBody))
            {
                query["MsgBody"] = request.MsgBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMediaFromSearchLib",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMediaFromSearchLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除媒资从搜索
         *
         * @param request DeleteMediaFromSearchLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMediaFromSearchLibResponse
         */
        public async Task<DeleteMediaFromSearchLibResponse> DeleteMediaFromSearchLibWithOptionsAsync(DeleteMediaFromSearchLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgBody))
            {
                query["MsgBody"] = request.MsgBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMediaFromSearchLib",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMediaFromSearchLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除媒资从搜索
         *
         * @param request DeleteMediaFromSearchLibRequest
         * @return DeleteMediaFromSearchLibResponse
         */
        public DeleteMediaFromSearchLibResponse DeleteMediaFromSearchLib(DeleteMediaFromSearchLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMediaFromSearchLibWithOptions(request, runtime);
        }

        /**
         * @summary 删除媒资从搜索
         *
         * @param request DeleteMediaFromSearchLibRequest
         * @return DeleteMediaFromSearchLibResponse
         */
        public async Task<DeleteMediaFromSearchLibResponse> DeleteMediaFromSearchLibAsync(DeleteMediaFromSearchLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMediaFromSearchLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除媒资信息
         *
         * @param request DeleteMediaInfosRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMediaInfosResponse
         */
        public DeleteMediaInfosResponse DeleteMediaInfosWithOptions(DeleteMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary 删除媒资信息
         *
         * @param request DeleteMediaInfosRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMediaInfosResponse
         */
        public async Task<DeleteMediaInfosResponse> DeleteMediaInfosWithOptionsAsync(DeleteMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary 删除媒资信息
         *
         * @param request DeleteMediaInfosRequest
         * @return DeleteMediaInfosResponse
         */
        public DeleteMediaInfosResponse DeleteMediaInfos(DeleteMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMediaInfosWithOptions(request, runtime);
        }

        /**
         * @summary 删除媒资信息
         *
         * @param request DeleteMediaInfosRequest
         * @return DeleteMediaInfosResponse
         */
        public async Task<DeleteMediaInfosResponse> DeleteMediaInfosAsync(DeleteMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMediaInfosWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除媒资标注信息
         *
         * @param request DeleteMediaMarksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMediaMarksResponse
         */
        public DeleteMediaMarksResponse DeleteMediaMarksWithOptions(DeleteMediaMarksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMarkIds))
            {
                query["MediaMarkIds"] = request.MediaMarkIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMediaMarks",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMediaMarksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除媒资标注信息
         *
         * @param request DeleteMediaMarksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMediaMarksResponse
         */
        public async Task<DeleteMediaMarksResponse> DeleteMediaMarksWithOptionsAsync(DeleteMediaMarksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMarkIds))
            {
                query["MediaMarkIds"] = request.MediaMarkIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMediaMarks",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMediaMarksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除媒资标注信息
         *
         * @param request DeleteMediaMarksRequest
         * @return DeleteMediaMarksResponse
         */
        public DeleteMediaMarksResponse DeleteMediaMarks(DeleteMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMediaMarksWithOptions(request, runtime);
        }

        /**
         * @summary 删除媒资标注信息
         *
         * @param request DeleteMediaMarksRequest
         * @return DeleteMediaMarksResponse
         */
        public async Task<DeleteMediaMarksResponse> DeleteMediaMarksAsync(DeleteMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMediaMarksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除管道配置
         *
         * @param request DeletePipelineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePipelineResponse
         */
        public DeletePipelineResponse DeletePipelineWithOptions(DeletePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipeline",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除管道配置
         *
         * @param request DeletePipelineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePipelineResponse
         */
        public async Task<DeletePipelineResponse> DeletePipelineWithOptionsAsync(DeletePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipeline",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除管道配置
         *
         * @param request DeletePipelineRequest
         * @return DeletePipelineResponse
         */
        public DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePipelineWithOptions(request, runtime);
        }

        /**
         * @summary 删除管道配置
         *
         * @param request DeletePipelineRequest
         * @return DeletePipelineResponse
         */
        public async Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePipelineWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除播放信息
         *
         * @param request DeletePlayInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePlayInfoResponse
         */
        public DeletePlayInfoResponse DeletePlayInfoWithOptions(DeletePlayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePhysicalFiles))
            {
                query["DeletePhysicalFiles"] = request.DeletePhysicalFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURLs))
            {
                query["FileURLs"] = request.FileURLs;
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
                Action = "DeletePlayInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePlayInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除播放信息
         *
         * @param request DeletePlayInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePlayInfoResponse
         */
        public async Task<DeletePlayInfoResponse> DeletePlayInfoWithOptionsAsync(DeletePlayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletePhysicalFiles))
            {
                query["DeletePhysicalFiles"] = request.DeletePhysicalFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURLs))
            {
                query["FileURLs"] = request.FileURLs;
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
                Action = "DeletePlayInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePlayInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除播放信息
         *
         * @param request DeletePlayInfoRequest
         * @return DeletePlayInfoResponse
         */
        public DeletePlayInfoResponse DeletePlayInfo(DeletePlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePlayInfoWithOptions(request, runtime);
        }

        /**
         * @summary 删除播放信息
         *
         * @param request DeletePlayInfoRequest
         * @return DeletePlayInfoResponse
         */
        public async Task<DeletePlayInfoResponse> DeletePlayInfoAsync(DeletePlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePlayInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary DeleteSmartJob
         *
         * @param request DeleteSmartJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSmartJobResponse
         */
        public DeleteSmartJobResponse DeleteSmartJobWithOptions(DeleteSmartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary DeleteSmartJob
         *
         * @param request DeleteSmartJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSmartJobResponse
         */
        public async Task<DeleteSmartJobResponse> DeleteSmartJobWithOptionsAsync(DeleteSmartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary DeleteSmartJob
         *
         * @param request DeleteSmartJobRequest
         * @return DeleteSmartJobResponse
         */
        public DeleteSmartJobResponse DeleteSmartJob(DeleteSmartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSmartJobWithOptions(request, runtime);
        }

        /**
         * @summary DeleteSmartJob
         *
         * @param request DeleteSmartJobRequest
         * @return DeleteSmartJobResponse
         */
        public async Task<DeleteSmartJobResponse> DeleteSmartJobAsync(DeleteSmartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSmartJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary DeleteTemplate
         *
         * @param request DeleteTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTemplateResponse
         */
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

        /**
         * @summary DeleteTemplate
         *
         * @param request DeleteTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTemplateResponse
         */
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

        /**
         * @summary DeleteTemplate
         *
         * @param request DeleteTemplateRequest
         * @return DeleteTemplateResponse
         */
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateWithOptions(request, runtime);
        }

        /**
         * @summary DeleteTemplate
         *
         * @param request DeleteTemplateRequest
         * @return DeleteTemplateResponse
         */
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeMeterImsEditUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMeterImsEditUsageResponse
         */
        public DescribeMeterImsEditUsageResponse DescribeMeterImsEditUsageWithOptions(DescribeMeterImsEditUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterImsEditUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsEditUsageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeMeterImsEditUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMeterImsEditUsageResponse
         */
        public async Task<DescribeMeterImsEditUsageResponse> DescribeMeterImsEditUsageWithOptionsAsync(DescribeMeterImsEditUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterImsEditUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsEditUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeMeterImsEditUsageRequest
         * @return DescribeMeterImsEditUsageResponse
         */
        public DescribeMeterImsEditUsageResponse DescribeMeterImsEditUsage(DescribeMeterImsEditUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsEditUsageWithOptions(request, runtime);
        }

        /**
         * @param request DescribeMeterImsEditUsageRequest
         * @return DescribeMeterImsEditUsageResponse
         */
        public async Task<DescribeMeterImsEditUsageResponse> DescribeMeterImsEditUsageAsync(DescribeMeterImsEditUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsEditUsageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeMeterImsMediaConvertUHDUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMeterImsMediaConvertUHDUsageResponse
         */
        public DescribeMeterImsMediaConvertUHDUsageResponse DescribeMeterImsMediaConvertUHDUsageWithOptions(DescribeMeterImsMediaConvertUHDUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterImsMediaConvertUHDUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsMediaConvertUHDUsageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeMeterImsMediaConvertUHDUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMeterImsMediaConvertUHDUsageResponse
         */
        public async Task<DescribeMeterImsMediaConvertUHDUsageResponse> DescribeMeterImsMediaConvertUHDUsageWithOptionsAsync(DescribeMeterImsMediaConvertUHDUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterImsMediaConvertUHDUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsMediaConvertUHDUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeMeterImsMediaConvertUHDUsageRequest
         * @return DescribeMeterImsMediaConvertUHDUsageResponse
         */
        public DescribeMeterImsMediaConvertUHDUsageResponse DescribeMeterImsMediaConvertUHDUsage(DescribeMeterImsMediaConvertUHDUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsMediaConvertUHDUsageWithOptions(request, runtime);
        }

        /**
         * @param request DescribeMeterImsMediaConvertUHDUsageRequest
         * @return DescribeMeterImsMediaConvertUHDUsageResponse
         */
        public async Task<DescribeMeterImsMediaConvertUHDUsageResponse> DescribeMeterImsMediaConvertUHDUsageAsync(DescribeMeterImsMediaConvertUHDUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsMediaConvertUHDUsageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 智能媒体服务点播转码用量
         *
         * @param request DescribeMeterImsMediaConvertUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMeterImsMediaConvertUsageResponse
         */
        public DescribeMeterImsMediaConvertUsageResponse DescribeMeterImsMediaConvertUsageWithOptions(DescribeMeterImsMediaConvertUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterImsMediaConvertUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsMediaConvertUsageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 智能媒体服务点播转码用量
         *
         * @param request DescribeMeterImsMediaConvertUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMeterImsMediaConvertUsageResponse
         */
        public async Task<DescribeMeterImsMediaConvertUsageResponse> DescribeMeterImsMediaConvertUsageWithOptionsAsync(DescribeMeterImsMediaConvertUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterImsMediaConvertUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsMediaConvertUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 智能媒体服务点播转码用量
         *
         * @param request DescribeMeterImsMediaConvertUsageRequest
         * @return DescribeMeterImsMediaConvertUsageResponse
         */
        public DescribeMeterImsMediaConvertUsageResponse DescribeMeterImsMediaConvertUsage(DescribeMeterImsMediaConvertUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsMediaConvertUsageWithOptions(request, runtime);
        }

        /**
         * @summary 智能媒体服务点播转码用量
         *
         * @param request DescribeMeterImsMediaConvertUsageRequest
         * @return DescribeMeterImsMediaConvertUsageResponse
         */
        public async Task<DescribeMeterImsMediaConvertUsageResponse> DescribeMeterImsMediaConvertUsageAsync(DescribeMeterImsMediaConvertUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsMediaConvertUsageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeMeterImsMpsAiUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMeterImsMpsAiUsageResponse
         */
        public DescribeMeterImsMpsAiUsageResponse DescribeMeterImsMpsAiUsageWithOptions(DescribeMeterImsMpsAiUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterImsMpsAiUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsMpsAiUsageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeMeterImsMpsAiUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMeterImsMpsAiUsageResponse
         */
        public async Task<DescribeMeterImsMpsAiUsageResponse> DescribeMeterImsMpsAiUsageWithOptionsAsync(DescribeMeterImsMpsAiUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterImsMpsAiUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsMpsAiUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeMeterImsMpsAiUsageRequest
         * @return DescribeMeterImsMpsAiUsageResponse
         */
        public DescribeMeterImsMpsAiUsageResponse DescribeMeterImsMpsAiUsage(DescribeMeterImsMpsAiUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsMpsAiUsageWithOptions(request, runtime);
        }

        /**
         * @param request DescribeMeterImsMpsAiUsageRequest
         * @return DescribeMeterImsMpsAiUsageResponse
         */
        public async Task<DescribeMeterImsMpsAiUsageResponse> DescribeMeterImsMpsAiUsageAsync(DescribeMeterImsMpsAiUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsMpsAiUsageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeMeterImsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMeterImsSummaryResponse
         */
        public DescribeMeterImsSummaryResponse DescribeMeterImsSummaryWithOptions(DescribeMeterImsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterImsSummary",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeMeterImsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMeterImsSummaryResponse
         */
        public async Task<DescribeMeterImsSummaryResponse> DescribeMeterImsSummaryWithOptionsAsync(DescribeMeterImsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterImsSummary",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeMeterImsSummaryRequest
         * @return DescribeMeterImsSummaryResponse
         */
        public DescribeMeterImsSummaryResponse DescribeMeterImsSummary(DescribeMeterImsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsSummaryWithOptions(request, runtime);
        }

        /**
         * @param request DescribeMeterImsSummaryRequest
         * @return DescribeMeterImsSummaryResponse
         */
        public async Task<DescribeMeterImsSummaryResponse> DescribeMeterImsSummaryAsync(DescribeMeterImsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribePlayListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlayListResponse
         */
        public DescribePlayListResponse DescribePlayListWithOptions(DescribePlayListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTs))
            {
                query["BeginTs"] = request.BeginTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderName))
            {
                query["OrderName"] = request.OrderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayType))
            {
                query["PlayType"] = request.PlayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                query["TraceId"] = request.TraceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribePlayListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlayListResponse
         */
        public async Task<DescribePlayListResponse> DescribePlayListWithOptionsAsync(DescribePlayListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTs))
            {
                query["BeginTs"] = request.BeginTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderName))
            {
                query["OrderName"] = request.OrderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayType))
            {
                query["PlayType"] = request.PlayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                query["TraceId"] = request.TraceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribePlayListRequest
         * @return DescribePlayListResponse
         */
        public DescribePlayListResponse DescribePlayList(DescribePlayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayListWithOptions(request, runtime);
        }

        /**
         * @param request DescribePlayListRequest
         * @return DescribePlayListResponse
         */
        public async Task<DescribePlayListResponse> DescribePlayListAsync(DescribePlayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 本接口用来检测用户的朗读是否有明显的发音错误、嘈杂的环境等
         *
         * @param request DetectAudioForCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectAudioForCustomizedVoiceJobResponse
         */
        public DetectAudioForCustomizedVoiceJobResponse DetectAudioForCustomizedVoiceJobWithOptions(DetectAudioForCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioRecordId))
            {
                query["AudioRecordId"] = request.AudioRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordUrl))
            {
                query["RecordUrl"] = request.RecordUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                query["VoiceId"] = request.VoiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectAudioForCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectAudioForCustomizedVoiceJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 本接口用来检测用户的朗读是否有明显的发音错误、嘈杂的环境等
         *
         * @param request DetectAudioForCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectAudioForCustomizedVoiceJobResponse
         */
        public async Task<DetectAudioForCustomizedVoiceJobResponse> DetectAudioForCustomizedVoiceJobWithOptionsAsync(DetectAudioForCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AudioRecordId))
            {
                query["AudioRecordId"] = request.AudioRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordUrl))
            {
                query["RecordUrl"] = request.RecordUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                query["VoiceId"] = request.VoiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectAudioForCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectAudioForCustomizedVoiceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 本接口用来检测用户的朗读是否有明显的发音错误、嘈杂的环境等
         *
         * @param request DetectAudioForCustomizedVoiceJobRequest
         * @return DetectAudioForCustomizedVoiceJobResponse
         */
        public DetectAudioForCustomizedVoiceJobResponse DetectAudioForCustomizedVoiceJob(DetectAudioForCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectAudioForCustomizedVoiceJobWithOptions(request, runtime);
        }

        /**
         * @summary 本接口用来检测用户的朗读是否有明显的发音错误、嘈杂的环境等
         *
         * @param request DetectAudioForCustomizedVoiceJobRequest
         * @return DetectAudioForCustomizedVoiceJobResponse
         */
        public async Task<DetectAudioForCustomizedVoiceJobResponse> DetectAudioForCustomizedVoiceJobAsync(DetectAudioForCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectAudioForCustomizedVoiceJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除搜索索引
         *
         * @param request DropSearchIndexRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DropSearchIndexResponse
         */
        public DropSearchIndexResponse DropSearchIndexWithOptions(DropSearchIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexType))
            {
                query["IndexType"] = request.IndexType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropSearchIndex",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DropSearchIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除搜索索引
         *
         * @param request DropSearchIndexRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DropSearchIndexResponse
         */
        public async Task<DropSearchIndexResponse> DropSearchIndexWithOptionsAsync(DropSearchIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexType))
            {
                query["IndexType"] = request.IndexType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropSearchIndex",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DropSearchIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除搜索索引
         *
         * @param request DropSearchIndexRequest
         * @return DropSearchIndexResponse
         */
        public DropSearchIndexResponse DropSearchIndex(DropSearchIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DropSearchIndexWithOptions(request, runtime);
        }

        /**
         * @summary 删除搜索索引
         *
         * @param request DropSearchIndexRequest
         * @return DropSearchIndexResponse
         */
        public async Task<DropSearchIndexResponse> DropSearchIndexAsync(DropSearchIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DropSearchIndexWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除库
         *
         * @param request DropSearchLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DropSearchLibResponse
         */
        public DropSearchLibResponse DropSearchLibWithOptions(DropSearchLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropSearchLib",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DropSearchLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除库
         *
         * @param request DropSearchLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DropSearchLibResponse
         */
        public async Task<DropSearchLibResponse> DropSearchLibWithOptionsAsync(DropSearchLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropSearchLib",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DropSearchLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除库
         *
         * @param request DropSearchLibRequest
         * @return DropSearchLibResponse
         */
        public DropSearchLibResponse DropSearchLib(DropSearchLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DropSearchLibWithOptions(request, runtime);
        }

        /**
         * @summary 删除库
         *
         * @param request DropSearchLibRequest
         * @return DropSearchLibResponse
         */
        public async Task<DropSearchLibResponse> DropSearchLibAsync(DropSearchLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DropSearchLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 生成KMS密钥DataKey
         *
         * @param request GenerateKMSDataKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateKMSDataKeyResponse
         */
        public GenerateKMSDataKeyResponse GenerateKMSDataKeyWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateKMSDataKey",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateKMSDataKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 生成KMS密钥DataKey
         *
         * @param request GenerateKMSDataKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateKMSDataKeyResponse
         */
        public async Task<GenerateKMSDataKeyResponse> GenerateKMSDataKeyWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateKMSDataKey",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateKMSDataKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 生成KMS密钥DataKey
         *
         * @return GenerateKMSDataKeyResponse
         */
        public GenerateKMSDataKeyResponse GenerateKMSDataKey()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateKMSDataKeyWithOptions(runtime);
        }

        /**
         * @summary 生成KMS密钥DataKey
         *
         * @return GenerateKMSDataKeyResponse
         */
        public async Task<GenerateKMSDataKeyResponse> GenerateKMSDataKeyAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateKMSDataKeyWithOptionsAsync(runtime);
        }

        /**
         * @summary 查询单个数字人
         *
         * @param request GetAvatarRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAvatarResponse
         */
        public GetAvatarResponse GetAvatarWithOptions(GetAvatarRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarId))
            {
                query["AvatarId"] = request.AvatarId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAvatar",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvatarResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询单个数字人
         *
         * @param request GetAvatarRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAvatarResponse
         */
        public async Task<GetAvatarResponse> GetAvatarWithOptionsAsync(GetAvatarRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarId))
            {
                query["AvatarId"] = request.AvatarId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAvatar",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvatarResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询单个数字人
         *
         * @param request GetAvatarRequest
         * @return GetAvatarResponse
         */
        public GetAvatarResponse GetAvatar(GetAvatarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAvatarWithOptions(request, runtime);
        }

        /**
         * @summary 查询单个数字人
         *
         * @param request GetAvatarRequest
         * @return GetAvatarResponse
         */
        public async Task<GetAvatarResponse> GetAvatarAsync(GetAvatarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAvatarWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询单个数字人训练任务
         *
         * @param request GetAvatarTrainingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAvatarTrainingJobResponse
         */
        public GetAvatarTrainingJobResponse GetAvatarTrainingJobWithOptions(GetAvatarTrainingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAvatarTrainingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvatarTrainingJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询单个数字人训练任务
         *
         * @param request GetAvatarTrainingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAvatarTrainingJobResponse
         */
        public async Task<GetAvatarTrainingJobResponse> GetAvatarTrainingJobWithOptionsAsync(GetAvatarTrainingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAvatarTrainingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvatarTrainingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询单个数字人训练任务
         *
         * @param request GetAvatarTrainingJobRequest
         * @return GetAvatarTrainingJobResponse
         */
        public GetAvatarTrainingJobResponse GetAvatarTrainingJob(GetAvatarTrainingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAvatarTrainingJobWithOptions(request, runtime);
        }

        /**
         * @summary 查询单个数字人训练任务
         *
         * @param request GetAvatarTrainingJobRequest
         * @return GetAvatarTrainingJobResponse
         */
        public async Task<GetAvatarTrainingJobResponse> GetAvatarTrainingJobAsync(GetAvatarTrainingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAvatarTrainingJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 一键成片-批量获取剪辑任务
         *
         * @param request GetBatchMediaProducingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBatchMediaProducingJobResponse
         */
        public GetBatchMediaProducingJobResponse GetBatchMediaProducingJobWithOptions(GetBatchMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["Signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureMehtod))
            {
                query["SignatureMehtod"] = request.SignatureMehtod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureNonce))
            {
                query["SignatureNonce"] = request.SignatureNonce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureType))
            {
                query["SignatureType"] = request.SignatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureVersion))
            {
                query["SignatureVersion"] = request.SignatureVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBatchMediaProducingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchMediaProducingJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 一键成片-批量获取剪辑任务
         *
         * @param request GetBatchMediaProducingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBatchMediaProducingJobResponse
         */
        public async Task<GetBatchMediaProducingJobResponse> GetBatchMediaProducingJobWithOptionsAsync(GetBatchMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["Signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureMehtod))
            {
                query["SignatureMehtod"] = request.SignatureMehtod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureNonce))
            {
                query["SignatureNonce"] = request.SignatureNonce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureType))
            {
                query["SignatureType"] = request.SignatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureVersion))
            {
                query["SignatureVersion"] = request.SignatureVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBatchMediaProducingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchMediaProducingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 一键成片-批量获取剪辑任务
         *
         * @param request GetBatchMediaProducingJobRequest
         * @return GetBatchMediaProducingJobResponse
         */
        public GetBatchMediaProducingJobResponse GetBatchMediaProducingJob(GetBatchMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBatchMediaProducingJobWithOptions(request, runtime);
        }

        /**
         * @summary 一键成片-批量获取剪辑任务
         *
         * @param request GetBatchMediaProducingJobRequest
         * @return GetBatchMediaProducingJobResponse
         */
        public async Task<GetBatchMediaProducingJobResponse> GetBatchMediaProducingJobAsync(GetBatchMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBatchMediaProducingJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询媒资分类
         *
         * @param request GetCategoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCategoriesResponse
         */
        public GetCategoriesResponse GetCategoriesWithOptions(GetCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
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
                Action = "GetCategories",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCategoriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询媒资分类
         *
         * @param request GetCategoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCategoriesResponse
         */
        public async Task<GetCategoriesResponse> GetCategoriesWithOptionsAsync(GetCategoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
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
                Action = "GetCategories",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCategoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询媒资分类
         *
         * @param request GetCategoriesRequest
         * @return GetCategoriesResponse
         */
        public GetCategoriesResponse GetCategories(GetCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCategoriesWithOptions(request, runtime);
        }

        /**
         * @summary 查询媒资分类
         *
         * @param request GetCategoriesRequest
         * @return GetCategoriesResponse
         */
        public async Task<GetCategoriesResponse> GetCategoriesAsync(GetCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCategoriesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取内容分析搜索配置
         *
         * @param request GetContentAnalyzeConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetContentAnalyzeConfigResponse
         */
        public GetContentAnalyzeConfigResponse GetContentAnalyzeConfigWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContentAnalyzeConfig",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContentAnalyzeConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取内容分析搜索配置
         *
         * @param request GetContentAnalyzeConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetContentAnalyzeConfigResponse
         */
        public async Task<GetContentAnalyzeConfigResponse> GetContentAnalyzeConfigWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContentAnalyzeConfig",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContentAnalyzeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取内容分析搜索配置
         *
         * @return GetContentAnalyzeConfigResponse
         */
        public GetContentAnalyzeConfigResponse GetContentAnalyzeConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContentAnalyzeConfigWithOptions(runtime);
        }

        /**
         * @summary 获取内容分析搜索配置
         *
         * @return GetContentAnalyzeConfigResponse
         */
        public async Task<GetContentAnalyzeConfigResponse> GetContentAnalyzeConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContentAnalyzeConfigWithOptionsAsync(runtime);
        }

        /**
         * @summary 获取单个媒体处理自定义模板
         *
         * @param request GetCustomTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomTemplateResponse
         */
        public GetCustomTemplateResponse GetCustomTemplateWithOptions(GetCustomTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subtype))
            {
                query["Subtype"] = request.Subtype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "GetCustomTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取单个媒体处理自定义模板
         *
         * @param request GetCustomTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomTemplateResponse
         */
        public async Task<GetCustomTemplateResponse> GetCustomTemplateWithOptionsAsync(GetCustomTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subtype))
            {
                query["Subtype"] = request.Subtype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "GetCustomTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取单个媒体处理自定义模板
         *
         * @param request GetCustomTemplateRequest
         * @return GetCustomTemplateResponse
         */
        public GetCustomTemplateResponse GetCustomTemplate(GetCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 获取单个媒体处理自定义模板
         *
         * @param request GetCustomTemplateRequest
         * @return GetCustomTemplateResponse
         */
        public async Task<GetCustomTemplateResponse> GetCustomTemplateAsync(GetCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取用户的专属人声
         *
         * @param request GetCustomizedVoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomizedVoiceResponse
         */
        public GetCustomizedVoiceResponse GetCustomizedVoiceWithOptions(GetCustomizedVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                query["VoiceId"] = request.VoiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomizedVoice",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomizedVoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用户的专属人声
         *
         * @param request GetCustomizedVoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomizedVoiceResponse
         */
        public async Task<GetCustomizedVoiceResponse> GetCustomizedVoiceWithOptionsAsync(GetCustomizedVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                query["VoiceId"] = request.VoiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomizedVoice",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomizedVoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户的专属人声
         *
         * @param request GetCustomizedVoiceRequest
         * @return GetCustomizedVoiceResponse
         */
        public GetCustomizedVoiceResponse GetCustomizedVoice(GetCustomizedVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomizedVoiceWithOptions(request, runtime);
        }

        /**
         * @summary 获取用户的专属人声
         *
         * @param request GetCustomizedVoiceRequest
         * @return GetCustomizedVoiceResponse
         */
        public async Task<GetCustomizedVoiceResponse> GetCustomizedVoiceAsync(GetCustomizedVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomizedVoiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询单个人声克隆训练任务
         *
         * @param request GetCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomizedVoiceJobResponse
         */
        public GetCustomizedVoiceJobResponse GetCustomizedVoiceJobWithOptions(GetCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomizedVoiceJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询单个人声克隆训练任务
         *
         * @param request GetCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomizedVoiceJobResponse
         */
        public async Task<GetCustomizedVoiceJobResponse> GetCustomizedVoiceJobWithOptionsAsync(GetCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomizedVoiceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询单个人声克隆训练任务
         *
         * @param request GetCustomizedVoiceJobRequest
         * @return GetCustomizedVoiceJobResponse
         */
        public GetCustomizedVoiceJobResponse GetCustomizedVoiceJob(GetCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomizedVoiceJobWithOptions(request, runtime);
        }

        /**
         * @summary 查询单个人声克隆训练任务
         *
         * @param request GetCustomizedVoiceJobRequest
         * @return GetCustomizedVoiceJobResponse
         */
        public async Task<GetCustomizedVoiceJobResponse> GetCustomizedVoiceJobAsync(GetCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomizedVoiceJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取用户默认存储地址
         *
         * @param request GetDefaultStorageLocationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDefaultStorageLocationResponse
         */
        public GetDefaultStorageLocationResponse GetDefaultStorageLocationWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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

        /**
         * @summary 获取用户默认存储地址
         *
         * @param request GetDefaultStorageLocationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDefaultStorageLocationResponse
         */
        public async Task<GetDefaultStorageLocationResponse> GetDefaultStorageLocationWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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

        /**
         * @summary 获取用户默认存储地址
         *
         * @return GetDefaultStorageLocationResponse
         */
        public GetDefaultStorageLocationResponse GetDefaultStorageLocation()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDefaultStorageLocationWithOptions(runtime);
        }

        /**
         * @summary 获取用户默认存储地址
         *
         * @return GetDefaultStorageLocationResponse
         */
        public async Task<GetDefaultStorageLocationResponse> GetDefaultStorageLocationAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDefaultStorageLocationWithOptionsAsync(runtime);
        }

        /**
         * @summary 通过本接口来获取需要给用户朗读的文本及示例音频
         *
         * @param request GetDemonstrationForCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDemonstrationForCustomizedVoiceJobResponse
         */
        public GetDemonstrationForCustomizedVoiceJobResponse GetDemonstrationForCustomizedVoiceJobWithOptions(GetDemonstrationForCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                query["Scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDemonstrationForCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDemonstrationForCustomizedVoiceJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 通过本接口来获取需要给用户朗读的文本及示例音频
         *
         * @param request GetDemonstrationForCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDemonstrationForCustomizedVoiceJobResponse
         */
        public async Task<GetDemonstrationForCustomizedVoiceJobResponse> GetDemonstrationForCustomizedVoiceJobWithOptionsAsync(GetDemonstrationForCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                query["Scenario"] = request.Scenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDemonstrationForCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDemonstrationForCustomizedVoiceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 通过本接口来获取需要给用户朗读的文本及示例音频
         *
         * @param request GetDemonstrationForCustomizedVoiceJobRequest
         * @return GetDemonstrationForCustomizedVoiceJobResponse
         */
        public GetDemonstrationForCustomizedVoiceJobResponse GetDemonstrationForCustomizedVoiceJob(GetDemonstrationForCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDemonstrationForCustomizedVoiceJobWithOptions(request, runtime);
        }

        /**
         * @summary 通过本接口来获取需要给用户朗读的文本及示例音频
         *
         * @param request GetDemonstrationForCustomizedVoiceJobRequest
         * @return GetDemonstrationForCustomizedVoiceJobResponse
         */
        public async Task<GetDemonstrationForCustomizedVoiceJobResponse> GetDemonstrationForCustomizedVoiceJobAsync(GetDemonstrationForCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDemonstrationForCustomizedVoiceJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询动图任务详情接口
         *
         * @param request GetDynamicImageJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDynamicImageJobResponse
         */
        public GetDynamicImageJobResponse GetDynamicImageJobWithOptions(GetDynamicImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDynamicImageJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDynamicImageJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询动图任务详情接口
         *
         * @param request GetDynamicImageJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDynamicImageJobResponse
         */
        public async Task<GetDynamicImageJobResponse> GetDynamicImageJobWithOptionsAsync(GetDynamicImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDynamicImageJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDynamicImageJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询动图任务详情接口
         *
         * @param request GetDynamicImageJobRequest
         * @return GetDynamicImageJobResponse
         */
        public GetDynamicImageJobResponse GetDynamicImageJob(GetDynamicImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDynamicImageJobWithOptions(request, runtime);
        }

        /**
         * @summary 查询动图任务详情接口
         *
         * @param request GetDynamicImageJobRequest
         * @return GetDynamicImageJobResponse
         */
        public async Task<GetDynamicImageJobResponse> GetDynamicImageJobAsync(GetDynamicImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDynamicImageJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取单个云剪辑工程
         *
         * @param request GetEditingProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEditingProjectResponse
         */
        public GetEditingProjectResponse GetEditingProjectWithOptions(GetEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestSource))
            {
                query["RequestSource"] = request.RequestSource;
            }
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

        /**
         * @summary 获取单个云剪辑工程
         *
         * @param request GetEditingProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEditingProjectResponse
         */
        public async Task<GetEditingProjectResponse> GetEditingProjectWithOptionsAsync(GetEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestSource))
            {
                query["RequestSource"] = request.RequestSource;
            }
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

        /**
         * @summary 获取单个云剪辑工程
         *
         * @param request GetEditingProjectRequest
         * @return GetEditingProjectResponse
         */
        public GetEditingProjectResponse GetEditingProject(GetEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEditingProjectWithOptions(request, runtime);
        }

        /**
         * @summary 获取单个云剪辑工程
         *
         * @param request GetEditingProjectRequest
         * @return GetEditingProjectResponse
         */
        public async Task<GetEditingProjectResponse> GetEditingProjectAsync(GetEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEditingProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取剪辑工程关联素材
         *
         * @param request GetEditingProjectMaterialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEditingProjectMaterialsResponse
         */
        public GetEditingProjectMaterialsResponse GetEditingProjectMaterialsWithOptions(GetEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary 获取剪辑工程关联素材
         *
         * @param request GetEditingProjectMaterialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEditingProjectMaterialsResponse
         */
        public async Task<GetEditingProjectMaterialsResponse> GetEditingProjectMaterialsWithOptionsAsync(GetEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary 获取剪辑工程关联素材
         *
         * @param request GetEditingProjectMaterialsRequest
         * @return GetEditingProjectMaterialsResponse
         */
        public GetEditingProjectMaterialsResponse GetEditingProjectMaterials(GetEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEditingProjectMaterialsWithOptions(request, runtime);
        }

        /**
         * @summary 获取剪辑工程关联素材
         *
         * @param request GetEditingProjectMaterialsRequest
         * @return GetEditingProjectMaterialsResponse
         */
        public async Task<GetEditingProjectMaterialsResponse> GetEditingProjectMaterialsAsync(GetEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEditingProjectMaterialsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取事件回调地址
         *
         * @param request GetEventCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEventCallbackResponse
         */
        public GetEventCallbackResponse GetEventCallbackWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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

        /**
         * @summary 获取事件回调地址
         *
         * @param request GetEventCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEventCallbackResponse
         */
        public async Task<GetEventCallbackResponse> GetEventCallbackWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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

        /**
         * @summary 获取事件回调地址
         *
         * @return GetEventCallbackResponse
         */
        public GetEventCallbackResponse GetEventCallback()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEventCallbackWithOptions(runtime);
        }

        /**
         * @summary 获取事件回调地址
         *
         * @return GetEventCallbackResponse
         */
        public async Task<GetEventCallbackResponse> GetEventCallbackAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEventCallbackWithOptionsAsync(runtime);
        }

        /**
         * @summary 获取直播剪辑m3u8索引文件
         *
         * @param request GetLiveEditingIndexFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveEditingIndexFileResponse
         */
        public GetLiveEditingIndexFileResponse GetLiveEditingIndexFileWithOptions(GetLiveEditingIndexFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamName))
            {
                query["StreamName"] = request.StreamName;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveEditingIndexFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取直播剪辑m3u8索引文件
         *
         * @param request GetLiveEditingIndexFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveEditingIndexFileResponse
         */
        public async Task<GetLiveEditingIndexFileResponse> GetLiveEditingIndexFileWithOptionsAsync(GetLiveEditingIndexFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamName))
            {
                query["StreamName"] = request.StreamName;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveEditingIndexFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取直播剪辑m3u8索引文件
         *
         * @param request GetLiveEditingIndexFileRequest
         * @return GetLiveEditingIndexFileResponse
         */
        public GetLiveEditingIndexFileResponse GetLiveEditingIndexFile(GetLiveEditingIndexFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveEditingIndexFileWithOptions(request, runtime);
        }

        /**
         * @summary 获取直播剪辑m3u8索引文件
         *
         * @param request GetLiveEditingIndexFileRequest
         * @return GetLiveEditingIndexFileResponse
         */
        public async Task<GetLiveEditingIndexFileResponse> GetLiveEditingIndexFileAsync(GetLiveEditingIndexFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveEditingIndexFileWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取直播剪辑任务
         *
         * @param request GetLiveEditingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveEditingJobResponse
         */
        public GetLiveEditingJobResponse GetLiveEditingJobWithOptions(GetLiveEditingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary 获取直播剪辑任务
         *
         * @param request GetLiveEditingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveEditingJobResponse
         */
        public async Task<GetLiveEditingJobResponse> GetLiveEditingJobWithOptionsAsync(GetLiveEditingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary 获取直播剪辑任务
         *
         * @param request GetLiveEditingJobRequest
         * @return GetLiveEditingJobResponse
         */
        public GetLiveEditingJobResponse GetLiveEditingJob(GetLiveEditingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveEditingJobWithOptions(request, runtime);
        }

        /**
         * @summary 获取直播剪辑任务
         *
         * @param request GetLiveEditingJobRequest
         * @return GetLiveEditingJobResponse
         */
        public async Task<GetLiveEditingJobResponse> GetLiveEditingJobAsync(GetLiveEditingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveEditingJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询录制任务明细
         *
         * @param request GetLiveRecordJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveRecordJobResponse
         */
        public GetLiveRecordJobResponse GetLiveRecordJobWithOptions(GetLiveRecordJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveRecordJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveRecordJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询录制任务明细
         *
         * @param request GetLiveRecordJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveRecordJobResponse
         */
        public async Task<GetLiveRecordJobResponse> GetLiveRecordJobWithOptionsAsync(GetLiveRecordJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveRecordJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveRecordJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询录制任务明细
         *
         * @param request GetLiveRecordJobRequest
         * @return GetLiveRecordJobResponse
         */
        public GetLiveRecordJobResponse GetLiveRecordJob(GetLiveRecordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveRecordJobWithOptions(request, runtime);
        }

        /**
         * @summary 查询录制任务明细
         *
         * @param request GetLiveRecordJobRequest
         * @return GetLiveRecordJobResponse
         */
        public async Task<GetLiveRecordJobResponse> GetLiveRecordJobAsync(GetLiveRecordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveRecordJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询直播录制模板详情
         *
         * @param request GetLiveRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveRecordTemplateResponse
         */
        public GetLiveRecordTemplateResponse GetLiveRecordTemplateWithOptions(GetLiveRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveRecordTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveRecordTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询直播录制模板详情
         *
         * @param request GetLiveRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveRecordTemplateResponse
         */
        public async Task<GetLiveRecordTemplateResponse> GetLiveRecordTemplateWithOptionsAsync(GetLiveRecordTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveRecordTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveRecordTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询直播录制模板详情
         *
         * @param request GetLiveRecordTemplateRequest
         * @return GetLiveRecordTemplateResponse
         */
        public GetLiveRecordTemplateResponse GetLiveRecordTemplate(GetLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveRecordTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 查询直播录制模板详情
         *
         * @param request GetLiveRecordTemplateRequest
         * @return GetLiveRecordTemplateResponse
         */
        public async Task<GetLiveRecordTemplateResponse> GetLiveRecordTemplateAsync(GetLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveRecordTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询直播截图任务
         *
         * @param request GetLiveSnapshotJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveSnapshotJobResponse
         */
        public GetLiveSnapshotJobResponse GetLiveSnapshotJobWithOptions(GetLiveSnapshotJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveSnapshotJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveSnapshotJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询直播截图任务
         *
         * @param request GetLiveSnapshotJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveSnapshotJobResponse
         */
        public async Task<GetLiveSnapshotJobResponse> GetLiveSnapshotJobWithOptionsAsync(GetLiveSnapshotJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveSnapshotJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveSnapshotJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询直播截图任务
         *
         * @param request GetLiveSnapshotJobRequest
         * @return GetLiveSnapshotJobResponse
         */
        public GetLiveSnapshotJobResponse GetLiveSnapshotJob(GetLiveSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveSnapshotJobWithOptions(request, runtime);
        }

        /**
         * @summary 查询直播截图任务
         *
         * @param request GetLiveSnapshotJobRequest
         * @return GetLiveSnapshotJobResponse
         */
        public async Task<GetLiveSnapshotJobResponse> GetLiveSnapshotJobAsync(GetLiveSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveSnapshotJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询直播截图模板
         *
         * @param request GetLiveSnapshotTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveSnapshotTemplateResponse
         */
        public GetLiveSnapshotTemplateResponse GetLiveSnapshotTemplateWithOptions(GetLiveSnapshotTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveSnapshotTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveSnapshotTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询直播截图模板
         *
         * @param request GetLiveSnapshotTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveSnapshotTemplateResponse
         */
        public async Task<GetLiveSnapshotTemplateResponse> GetLiveSnapshotTemplateWithOptionsAsync(GetLiveSnapshotTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveSnapshotTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveSnapshotTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询直播截图模板
         *
         * @param request GetLiveSnapshotTemplateRequest
         * @return GetLiveSnapshotTemplateResponse
         */
        public GetLiveSnapshotTemplateResponse GetLiveSnapshotTemplate(GetLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveSnapshotTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 查询直播截图模板
         *
         * @param request GetLiveSnapshotTemplateRequest
         * @return GetLiveSnapshotTemplateResponse
         */
        public async Task<GetLiveSnapshotTemplateResponse> GetLiveSnapshotTemplateAsync(GetLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveSnapshotTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询转码任务详情
         *
         * @param request GetLiveTranscodeJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveTranscodeJobResponse
         */
        public GetLiveTranscodeJobResponse GetLiveTranscodeJobWithOptions(GetLiveTranscodeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetLiveTranscodeJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveTranscodeJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询转码任务详情
         *
         * @param request GetLiveTranscodeJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveTranscodeJobResponse
         */
        public async Task<GetLiveTranscodeJobResponse> GetLiveTranscodeJobWithOptionsAsync(GetLiveTranscodeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetLiveTranscodeJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveTranscodeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询转码任务详情
         *
         * @param request GetLiveTranscodeJobRequest
         * @return GetLiveTranscodeJobResponse
         */
        public GetLiveTranscodeJobResponse GetLiveTranscodeJob(GetLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveTranscodeJobWithOptions(request, runtime);
        }

        /**
         * @summary 查询转码任务详情
         *
         * @param request GetLiveTranscodeJobRequest
         * @return GetLiveTranscodeJobResponse
         */
        public async Task<GetLiveTranscodeJobResponse> GetLiveTranscodeJobAsync(GetLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveTranscodeJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询转码模版详情
         *
         * @param request GetLiveTranscodeTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveTranscodeTemplateResponse
         */
        public GetLiveTranscodeTemplateResponse GetLiveTranscodeTemplateWithOptions(GetLiveTranscodeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveTranscodeTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveTranscodeTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询转码模版详情
         *
         * @param request GetLiveTranscodeTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLiveTranscodeTemplateResponse
         */
        public async Task<GetLiveTranscodeTemplateResponse> GetLiveTranscodeTemplateWithOptionsAsync(GetLiveTranscodeTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLiveTranscodeTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLiveTranscodeTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询转码模版详情
         *
         * @param request GetLiveTranscodeTemplateRequest
         * @return GetLiveTranscodeTemplateResponse
         */
        public GetLiveTranscodeTemplateResponse GetLiveTranscodeTemplate(GetLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveTranscodeTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 查询转码模版详情
         *
         * @param request GetLiveTranscodeTemplateRequest
         * @return GetLiveTranscodeTemplateResponse
         */
        public async Task<GetLiveTranscodeTemplateResponse> GetLiveTranscodeTemplateAsync(GetLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveTranscodeTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取媒资内容信息
         *
         * @param request GetMediaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaInfoResponse
         */
        public GetMediaInfoResponse GetMediaInfoWithOptions(GetMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputType))
            {
                query["OutputType"] = request.OutputType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnDetailedInfo))
            {
                query["ReturnDetailedInfo"] = request.ReturnDetailedInfo;
            }
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

        /**
         * @summary 获取媒资内容信息
         *
         * @param request GetMediaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaInfoResponse
         */
        public async Task<GetMediaInfoResponse> GetMediaInfoWithOptionsAsync(GetMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputType))
            {
                query["OutputType"] = request.OutputType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnDetailedInfo))
            {
                query["ReturnDetailedInfo"] = request.ReturnDetailedInfo;
            }
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

        /**
         * @summary 获取媒资内容信息
         *
         * @param request GetMediaInfoRequest
         * @return GetMediaInfoResponse
         */
        public GetMediaInfoResponse GetMediaInfo(GetMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaInfoWithOptions(request, runtime);
        }

        /**
         * @summary 获取媒资内容信息
         *
         * @param request GetMediaInfoRequest
         * @return GetMediaInfoResponse
         */
        public async Task<GetMediaInfoResponse> GetMediaInfoAsync(GetMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetMediaInfoJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaInfoJobResponse
         */
        public GetMediaInfoJobResponse GetMediaInfoJobWithOptions(GetMediaInfoJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMediaInfoJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaInfoJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetMediaInfoJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaInfoJobResponse
         */
        public async Task<GetMediaInfoJobResponse> GetMediaInfoJobWithOptionsAsync(GetMediaInfoJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMediaInfoJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaInfoJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetMediaInfoJobRequest
         * @return GetMediaInfoJobResponse
         */
        public GetMediaInfoJobResponse GetMediaInfoJob(GetMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaInfoJobWithOptions(request, runtime);
        }

        /**
         * @param request GetMediaInfoJobRequest
         * @return GetMediaInfoJobResponse
         */
        public async Task<GetMediaInfoJobResponse> GetMediaInfoJobAsync(GetMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaInfoJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取媒资标注信息
         *
         * @param request GetMediaMarksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaMarksResponse
         */
        public GetMediaMarksResponse GetMediaMarksWithOptions(GetMediaMarksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMarkIds))
            {
                query["MediaMarkIds"] = request.MediaMarkIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaMarks",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaMarksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取媒资标注信息
         *
         * @param request GetMediaMarksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaMarksResponse
         */
        public async Task<GetMediaMarksResponse> GetMediaMarksWithOptionsAsync(GetMediaMarksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMarkIds))
            {
                query["MediaMarkIds"] = request.MediaMarkIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaMarks",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaMarksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取媒资标注信息
         *
         * @param request GetMediaMarksRequest
         * @return GetMediaMarksResponse
         */
        public GetMediaMarksResponse GetMediaMarks(GetMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaMarksWithOptions(request, runtime);
        }

        /**
         * @summary 获取媒资标注信息
         *
         * @param request GetMediaMarksRequest
         * @return GetMediaMarksResponse
         */
        public async Task<GetMediaMarksResponse> GetMediaMarksAsync(GetMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaMarksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary GetMediaProducingJob
         *
         * @param request GetMediaProducingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaProducingJobResponse
         */
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

        /**
         * @summary GetMediaProducingJob
         *
         * @param request GetMediaProducingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMediaProducingJobResponse
         */
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

        /**
         * @summary GetMediaProducingJob
         *
         * @param request GetMediaProducingJobRequest
         * @return GetMediaProducingJobResponse
         */
        public GetMediaProducingJobResponse GetMediaProducingJob(GetMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaProducingJobWithOptions(request, runtime);
        }

        /**
         * @summary GetMediaProducingJob
         *
         * @param request GetMediaProducingJobRequest
         * @return GetMediaProducingJobResponse
         */
        public async Task<GetMediaProducingJobResponse> GetMediaProducingJobAsync(GetMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaProducingJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取单个打包任务信息
         *
         * @param request GetPackageJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPackageJobResponse
         */
        public GetPackageJobResponse GetPackageJobWithOptions(GetPackageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPackageJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPackageJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取单个打包任务信息
         *
         * @param request GetPackageJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPackageJobResponse
         */
        public async Task<GetPackageJobResponse> GetPackageJobWithOptionsAsync(GetPackageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPackageJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPackageJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取单个打包任务信息
         *
         * @param request GetPackageJobRequest
         * @return GetPackageJobResponse
         */
        public GetPackageJobResponse GetPackageJob(GetPackageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPackageJobWithOptions(request, runtime);
        }

        /**
         * @summary 获取单个打包任务信息
         *
         * @param request GetPackageJobRequest
         * @return GetPackageJobResponse
         */
        public async Task<GetPackageJobResponse> GetPackageJobAsync(GetPackageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPackageJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取单个管道配置
         *
         * @param request GetPipelineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPipelineResponse
         */
        public GetPipelineResponse GetPipelineWithOptions(GetPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取单个管道配置
         *
         * @param request GetPipelineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPipelineResponse
         */
        public async Task<GetPipelineResponse> GetPipelineWithOptionsAsync(GetPipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取单个管道配置
         *
         * @param request GetPipelineRequest
         * @return GetPipelineResponse
         */
        public GetPipelineResponse GetPipeline(GetPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPipelineWithOptions(request, runtime);
        }

        /**
         * @summary 获取单个管道配置
         *
         * @param request GetPipelineRequest
         * @return GetPipelineResponse
         */
        public async Task<GetPipelineResponse> GetPipelineAsync(GetPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPipelineWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取播放信息
         *
         * @param request GetPlayInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPlayInfoResponse
         */
        public GetPlayInfoResponse GetPlayInfoWithOptions(GetPlayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetPlayInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPlayInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取播放信息
         *
         * @param request GetPlayInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPlayInfoResponse
         */
        public async Task<GetPlayInfoResponse> GetPlayInfoWithOptionsAsync(GetPlayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetPlayInfo",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPlayInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取播放信息
         *
         * @param request GetPlayInfoRequest
         * @return GetPlayInfoResponse
         */
        public GetPlayInfoResponse GetPlayInfo(GetPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPlayInfoWithOptions(request, runtime);
        }

        /**
         * @summary 获取播放信息
         *
         * @param request GetPlayInfoRequest
         * @return GetPlayInfoResponse
         */
        public async Task<GetPlayInfoResponse> GetPlayInfoAsync(GetPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPlayInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取公共媒资内容信息
         *
         * @param request GetPublicMediaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublicMediaInfoResponse
         */
        public GetPublicMediaInfoResponse GetPublicMediaInfoWithOptions(GetPublicMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary 获取公共媒资内容信息
         *
         * @param request GetPublicMediaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublicMediaInfoResponse
         */
        public async Task<GetPublicMediaInfoResponse> GetPublicMediaInfoWithOptionsAsync(GetPublicMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary 获取公共媒资内容信息
         *
         * @param request GetPublicMediaInfoRequest
         * @return GetPublicMediaInfoResponse
         */
        public GetPublicMediaInfoResponse GetPublicMediaInfo(GetPublicMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPublicMediaInfoWithOptions(request, runtime);
        }

        /**
         * @summary 获取公共媒资内容信息
         *
         * @param request GetPublicMediaInfoRequest
         * @return GetPublicMediaInfoResponse
         */
        public async Task<GetPublicMediaInfoResponse> GetPublicMediaInfoAsync(GetPublicMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPublicMediaInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary GetSmartHandleJob
         *
         * @param request GetSmartHandleJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSmartHandleJobResponse
         */
        public GetSmartHandleJobResponse GetSmartHandleJobWithOptions(GetSmartHandleJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSmartHandleJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmartHandleJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary GetSmartHandleJob
         *
         * @param request GetSmartHandleJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSmartHandleJobResponse
         */
        public async Task<GetSmartHandleJobResponse> GetSmartHandleJobWithOptionsAsync(GetSmartHandleJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSmartHandleJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSmartHandleJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary GetSmartHandleJob
         *
         * @param request GetSmartHandleJobRequest
         * @return GetSmartHandleJobResponse
         */
        public GetSmartHandleJobResponse GetSmartHandleJob(GetSmartHandleJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmartHandleJobWithOptions(request, runtime);
        }

        /**
         * @summary GetSmartHandleJob
         *
         * @param request GetSmartHandleJobRequest
         * @return GetSmartHandleJobResponse
         */
        public async Task<GetSmartHandleJobResponse> GetSmartHandleJobAsync(GetSmartHandleJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmartHandleJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询单个截图任务
         *
         * @param request GetSnapshotJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSnapshotJobResponse
         */
        public GetSnapshotJobResponse GetSnapshotJobWithOptions(GetSnapshotJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSnapshotJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSnapshotJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询单个截图任务
         *
         * @param request GetSnapshotJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSnapshotJobResponse
         */
        public async Task<GetSnapshotJobResponse> GetSnapshotJobWithOptionsAsync(GetSnapshotJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSnapshotJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSnapshotJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询单个截图任务
         *
         * @param request GetSnapshotJobRequest
         * @return GetSnapshotJobResponse
         */
        public GetSnapshotJobResponse GetSnapshotJob(GetSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSnapshotJobWithOptions(request, runtime);
        }

        /**
         * @summary 查询单个截图任务
         *
         * @param request GetSnapshotJobRequest
         * @return GetSnapshotJobResponse
         */
        public async Task<GetSnapshotJobResponse> GetSnapshotJobAsync(GetSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSnapshotJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取截图文件URL
         *
         * @param request GetSnapshotUrlsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSnapshotUrlsResponse
         */
        public GetSnapshotUrlsResponse GetSnapshotUrlsWithOptions(GetSnapshotUrlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSnapshotUrls",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSnapshotUrlsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取截图文件URL
         *
         * @param request GetSnapshotUrlsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSnapshotUrlsResponse
         */
        public async Task<GetSnapshotUrlsResponse> GetSnapshotUrlsWithOptionsAsync(GetSnapshotUrlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSnapshotUrls",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSnapshotUrlsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取截图文件URL
         *
         * @param request GetSnapshotUrlsRequest
         * @return GetSnapshotUrlsResponse
         */
        public GetSnapshotUrlsResponse GetSnapshotUrls(GetSnapshotUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSnapshotUrlsWithOptions(request, runtime);
        }

        /**
         * @summary 获取截图文件URL
         *
         * @param request GetSnapshotUrlsRequest
         * @return GetSnapshotUrlsResponse
         */
        public async Task<GetSnapshotUrlsResponse> GetSnapshotUrlsAsync(GetSnapshotUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSnapshotUrlsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取单个媒体处理系统模板
         *
         * @param request GetSystemTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSystemTemplateResponse
         */
        public GetSystemTemplateResponse GetSystemTemplateWithOptions(GetSystemTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSystemTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSystemTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取单个媒体处理系统模板
         *
         * @param request GetSystemTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSystemTemplateResponse
         */
        public async Task<GetSystemTemplateResponse> GetSystemTemplateWithOptionsAsync(GetSystemTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSystemTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSystemTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取单个媒体处理系统模板
         *
         * @param request GetSystemTemplateRequest
         * @return GetSystemTemplateResponse
         */
        public GetSystemTemplateResponse GetSystemTemplate(GetSystemTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSystemTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 获取单个媒体处理系统模板
         *
         * @param request GetSystemTemplateRequest
         * @return GetSystemTemplateResponse
         */
        public async Task<GetSystemTemplateResponse> GetSystemTemplateAsync(GetSystemTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSystemTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary GetTemplate
         *
         * @param request GetTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateResponse
         */
        public GetTemplateResponse GetTemplateWithOptions(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedMediaidFlag))
            {
                query["RelatedMediaidFlag"] = request.RelatedMediaidFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary GetTemplate
         *
         * @param request GetTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateResponse
         */
        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedMediaidFlag))
            {
                query["RelatedMediaidFlag"] = request.RelatedMediaidFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary GetTemplate
         *
         * @param request GetTemplateRequest
         * @return GetTemplateResponse
         */
        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateWithOptions(request, runtime);
        }

        /**
         * @summary GetTemplate
         *
         * @param request GetTemplateRequest
         * @return GetTemplateResponse
         */
        public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取模板关联素材信息
         *
         * @param request GetTemplateMaterialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateMaterialsResponse
         */
        public GetTemplateMaterialsResponse GetTemplateMaterialsWithOptions(GetTemplateMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileList))
            {
                query["FileList"] = request.FileList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateMaterialsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取模板关联素材信息
         *
         * @param request GetTemplateMaterialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateMaterialsResponse
         */
        public async Task<GetTemplateMaterialsResponse> GetTemplateMaterialsWithOptionsAsync(GetTemplateMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileList))
            {
                query["FileList"] = request.FileList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
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
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateMaterialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取模板关联素材信息
         *
         * @param request GetTemplateMaterialsRequest
         * @return GetTemplateMaterialsResponse
         */
        public GetTemplateMaterialsResponse GetTemplateMaterials(GetTemplateMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateMaterialsWithOptions(request, runtime);
        }

        /**
         * @summary 获取模板关联素材信息
         *
         * @param request GetTemplateMaterialsRequest
         * @return GetTemplateMaterialsResponse
         */
        public async Task<GetTemplateMaterialsResponse> GetTemplateMaterialsAsync(GetTemplateMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateMaterialsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取模板参数信息
         *
         * @param request GetTemplateParamsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateParamsResponse
         */
        public GetTemplateParamsResponse GetTemplateParamsWithOptions(GetTemplateParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateParams",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateParamsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取模板参数信息
         *
         * @param request GetTemplateParamsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTemplateParamsResponse
         */
        public async Task<GetTemplateParamsResponse> GetTemplateParamsWithOptionsAsync(GetTemplateParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplateParams",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateParamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取模板参数信息
         *
         * @param request GetTemplateParamsRequest
         * @return GetTemplateParamsResponse
         */
        public GetTemplateParamsResponse GetTemplateParams(GetTemplateParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateParamsWithOptions(request, runtime);
        }

        /**
         * @summary 获取模板参数信息
         *
         * @param request GetTemplateParamsRequest
         * @return GetTemplateParamsResponse
         */
        public async Task<GetTemplateParamsResponse> GetTemplateParamsAsync(GetTemplateParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateParamsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetTranscodeJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTranscodeJobResponse
         */
        public GetTranscodeJobResponse GetTranscodeJobWithOptions(GetTranscodeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentJobId))
            {
                query["ParentJobId"] = request.ParentJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranscodeJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranscodeJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetTranscodeJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTranscodeJobResponse
         */
        public async Task<GetTranscodeJobResponse> GetTranscodeJobWithOptionsAsync(GetTranscodeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentJobId))
            {
                query["ParentJobId"] = request.ParentJobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranscodeJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranscodeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetTranscodeJobRequest
         * @return GetTranscodeJobResponse
         */
        public GetTranscodeJobResponse GetTranscodeJob(GetTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTranscodeJobWithOptions(request, runtime);
        }

        /**
         * @param request GetTranscodeJobRequest
         * @return GetTranscodeJobResponse
         */
        public async Task<GetTranscodeJobResponse> GetTranscodeJobAsync(GetTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTranscodeJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取URL上传信息
         *
         * @param request GetUrlUploadInfosRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUrlUploadInfosResponse
         */
        public GetUrlUploadInfosResponse GetUrlUploadInfosWithOptions(GetUrlUploadInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadURLs))
            {
                query["UploadURLs"] = request.UploadURLs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUrlUploadInfos",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUrlUploadInfosResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取URL上传信息
         *
         * @param request GetUrlUploadInfosRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUrlUploadInfosResponse
         */
        public async Task<GetUrlUploadInfosResponse> GetUrlUploadInfosWithOptionsAsync(GetUrlUploadInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadURLs))
            {
                query["UploadURLs"] = request.UploadURLs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUrlUploadInfos",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUrlUploadInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取URL上传信息
         *
         * @param request GetUrlUploadInfosRequest
         * @return GetUrlUploadInfosResponse
         */
        public GetUrlUploadInfosResponse GetUrlUploadInfos(GetUrlUploadInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUrlUploadInfosWithOptions(request, runtime);
        }

        /**
         * @summary 获取URL上传信息
         *
         * @param request GetUrlUploadInfosRequest
         * @return GetUrlUploadInfosResponse
         */
        public async Task<GetUrlUploadInfosResponse> GetUrlUploadInfosAsync(GetUrlUploadInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUrlUploadInfosWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取媒资新增列表
         *
         * @param request GetVideoListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVideoListResponse
         */
        public GetVideoListResponse GetVideoListWithOptions(GetVideoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "GetVideoList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取媒资新增列表
         *
         * @param request GetVideoListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVideoListResponse
         */
        public async Task<GetVideoListResponse> GetVideoListWithOptionsAsync(GetVideoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "GetVideoList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取媒资新增列表
         *
         * @param request GetVideoListRequest
         * @return GetVideoListResponse
         */
        public GetVideoListResponse GetVideoList(GetVideoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoListWithOptions(request, runtime);
        }

        /**
         * @summary 获取媒资新增列表
         *
         * @param request GetVideoListRequest
         * @return GetVideoListResponse
         */
        public async Task<GetVideoListResponse> GetVideoListAsync(GetVideoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取工作流任务
         *
         * @param request GetWorkflowTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkflowTaskResponse
         */
        public GetWorkflowTaskResponse GetWorkflowTaskWithOptions(GetWorkflowTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkflowTask",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkflowTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取工作流任务
         *
         * @param request GetWorkflowTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWorkflowTaskResponse
         */
        public async Task<GetWorkflowTaskResponse> GetWorkflowTaskWithOptionsAsync(GetWorkflowTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkflowTask",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkflowTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取工作流任务
         *
         * @param request GetWorkflowTaskRequest
         * @return GetWorkflowTaskResponse
         */
        public GetWorkflowTaskResponse GetWorkflowTask(GetWorkflowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkflowTaskWithOptions(request, runtime);
        }

        /**
         * @summary 获取工作流任务
         *
         * @param request GetWorkflowTaskRequest
         * @return GetWorkflowTaskResponse
         */
        public async Task<GetWorkflowTaskResponse> GetWorkflowTaskAsync(GetWorkflowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkflowTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 插入媒资到搜索
         *
         * @param request InsertMediaToSearchLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertMediaToSearchLibResponse
         */
        public InsertMediaToSearchLibResponse InsertMediaToSearchLibWithOptions(InsertMediaToSearchLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgBody))
            {
                query["MsgBody"] = request.MsgBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertMediaToSearchLib",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertMediaToSearchLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 插入媒资到搜索
         *
         * @param request InsertMediaToSearchLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertMediaToSearchLibResponse
         */
        public async Task<InsertMediaToSearchLibResponse> InsertMediaToSearchLibWithOptionsAsync(InsertMediaToSearchLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgBody))
            {
                query["MsgBody"] = request.MsgBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertMediaToSearchLib",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertMediaToSearchLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 插入媒资到搜索
         *
         * @param request InsertMediaToSearchLibRequest
         * @return InsertMediaToSearchLibResponse
         */
        public InsertMediaToSearchLibResponse InsertMediaToSearchLib(InsertMediaToSearchLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertMediaToSearchLibWithOptions(request, runtime);
        }

        /**
         * @summary 插入媒资到搜索
         *
         * @param request InsertMediaToSearchLibRequest
         * @return InsertMediaToSearchLibResponse
         */
        public async Task<InsertMediaToSearchLibResponse> InsertMediaToSearchLibAsync(InsertMediaToSearchLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertMediaToSearchLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出公共素材库所有标签
         *
         * @param request ListAllPublicMediaTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAllPublicMediaTagsResponse
         */
        public ListAllPublicMediaTagsResponse ListAllPublicMediaTagsWithOptions(ListAllPublicMediaTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
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
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllPublicMediaTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列出公共素材库所有标签
         *
         * @param request ListAllPublicMediaTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAllPublicMediaTagsResponse
         */
        public async Task<ListAllPublicMediaTagsResponse> ListAllPublicMediaTagsWithOptionsAsync(ListAllPublicMediaTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
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
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllPublicMediaTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列出公共素材库所有标签
         *
         * @param request ListAllPublicMediaTagsRequest
         * @return ListAllPublicMediaTagsResponse
         */
        public ListAllPublicMediaTagsResponse ListAllPublicMediaTags(ListAllPublicMediaTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAllPublicMediaTagsWithOptions(request, runtime);
        }

        /**
         * @summary 列出公共素材库所有标签
         *
         * @param request ListAllPublicMediaTagsRequest
         * @return ListAllPublicMediaTagsResponse
         */
        public async Task<ListAllPublicMediaTagsResponse> ListAllPublicMediaTagsAsync(ListAllPublicMediaTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAllPublicMediaTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询数字人训练任务列表，列出当前用户的所有数字人训练任务
         *
         * @param request ListAvatarTrainingJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAvatarTrainingJobsResponse
         */
        public ListAvatarTrainingJobsResponse ListAvatarTrainingJobsWithOptions(ListAvatarTrainingJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAvatarTrainingJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvatarTrainingJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询数字人训练任务列表，列出当前用户的所有数字人训练任务
         *
         * @param request ListAvatarTrainingJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAvatarTrainingJobsResponse
         */
        public async Task<ListAvatarTrainingJobsResponse> ListAvatarTrainingJobsWithOptionsAsync(ListAvatarTrainingJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAvatarTrainingJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvatarTrainingJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询数字人训练任务列表，列出当前用户的所有数字人训练任务
         *
         * @param request ListAvatarTrainingJobsRequest
         * @return ListAvatarTrainingJobsResponse
         */
        public ListAvatarTrainingJobsResponse ListAvatarTrainingJobs(ListAvatarTrainingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAvatarTrainingJobsWithOptions(request, runtime);
        }

        /**
         * @summary 查询数字人训练任务列表，列出当前用户的所有数字人训练任务
         *
         * @param request ListAvatarTrainingJobsRequest
         * @return ListAvatarTrainingJobsResponse
         */
        public async Task<ListAvatarTrainingJobsResponse> ListAvatarTrainingJobsAsync(ListAvatarTrainingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAvatarTrainingJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询数字人列表，列出当前用户的所有数字人
         *
         * @param request ListAvatarsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAvatarsResponse
         */
        public ListAvatarsResponse ListAvatarsWithOptions(ListAvatarsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarType))
            {
                query["AvatarType"] = request.AvatarType;
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
                Action = "ListAvatars",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvatarsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询数字人列表，列出当前用户的所有数字人
         *
         * @param request ListAvatarsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAvatarsResponse
         */
        public async Task<ListAvatarsResponse> ListAvatarsWithOptionsAsync(ListAvatarsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarType))
            {
                query["AvatarType"] = request.AvatarType;
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
                Action = "ListAvatars",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvatarsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询数字人列表，列出当前用户的所有数字人
         *
         * @param request ListAvatarsRequest
         * @return ListAvatarsResponse
         */
        public ListAvatarsResponse ListAvatars(ListAvatarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAvatarsWithOptions(request, runtime);
        }

        /**
         * @summary 查询数字人列表，列出当前用户的所有数字人
         *
         * @param request ListAvatarsRequest
         * @return ListAvatarsResponse
         */
        public async Task<ListAvatarsResponse> ListAvatarsAsync(ListAvatarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAvatarsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取一键成片任务列表
         *
         * @param request ListBatchMediaProducingJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBatchMediaProducingJobsResponse
         */
        public ListBatchMediaProducingJobsResponse ListBatchMediaProducingJobsWithOptions(ListBatchMediaProducingJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "ListBatchMediaProducingJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBatchMediaProducingJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取一键成片任务列表
         *
         * @param request ListBatchMediaProducingJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBatchMediaProducingJobsResponse
         */
        public async Task<ListBatchMediaProducingJobsResponse> ListBatchMediaProducingJobsWithOptionsAsync(ListBatchMediaProducingJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "ListBatchMediaProducingJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBatchMediaProducingJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取一键成片任务列表
         *
         * @param request ListBatchMediaProducingJobsRequest
         * @return ListBatchMediaProducingJobsResponse
         */
        public ListBatchMediaProducingJobsResponse ListBatchMediaProducingJobs(ListBatchMediaProducingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBatchMediaProducingJobsWithOptions(request, runtime);
        }

        /**
         * @summary 获取一键成片任务列表
         *
         * @param request ListBatchMediaProducingJobsRequest
         * @return ListBatchMediaProducingJobsResponse
         */
        public async Task<ListBatchMediaProducingJobsResponse> ListBatchMediaProducingJobsAsync(ListBatchMediaProducingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBatchMediaProducingJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取媒体处理自定义模板列表
         *
         * @param request ListCustomTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomTemplatesResponse
         */
        public ListCustomTemplatesResponse ListCustomTemplatesWithOptions(ListCustomTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subtype))
            {
                query["Subtype"] = request.Subtype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "ListCustomTemplates",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取媒体处理自定义模板列表
         *
         * @param request ListCustomTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomTemplatesResponse
         */
        public async Task<ListCustomTemplatesResponse> ListCustomTemplatesWithOptionsAsync(ListCustomTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subtype))
            {
                query["Subtype"] = request.Subtype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "ListCustomTemplates",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取媒体处理自定义模板列表
         *
         * @param request ListCustomTemplatesRequest
         * @return ListCustomTemplatesResponse
         */
        public ListCustomTemplatesResponse ListCustomTemplates(ListCustomTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary 获取媒体处理自定义模板列表
         *
         * @param request ListCustomTemplatesRequest
         * @return ListCustomTemplatesResponse
         */
        public async Task<ListCustomTemplatesResponse> ListCustomTemplatesAsync(ListCustomTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询人声克隆训练任务列表，列出当前用户的所有人声克隆训练任务
         *
         * @param request ListCustomizedVoiceJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomizedVoiceJobsResponse
         */
        public ListCustomizedVoiceJobsResponse ListCustomizedVoiceJobsWithOptions(ListCustomizedVoiceJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListCustomizedVoiceJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomizedVoiceJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询人声克隆训练任务列表，列出当前用户的所有人声克隆训练任务
         *
         * @param request ListCustomizedVoiceJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomizedVoiceJobsResponse
         */
        public async Task<ListCustomizedVoiceJobsResponse> ListCustomizedVoiceJobsWithOptionsAsync(ListCustomizedVoiceJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListCustomizedVoiceJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomizedVoiceJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询人声克隆训练任务列表，列出当前用户的所有人声克隆训练任务
         *
         * @param request ListCustomizedVoiceJobsRequest
         * @return ListCustomizedVoiceJobsResponse
         */
        public ListCustomizedVoiceJobsResponse ListCustomizedVoiceJobs(ListCustomizedVoiceJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomizedVoiceJobsWithOptions(request, runtime);
        }

        /**
         * @summary 查询人声克隆训练任务列表，列出当前用户的所有人声克隆训练任务
         *
         * @param request ListCustomizedVoiceJobsRequest
         * @return ListCustomizedVoiceJobsResponse
         */
        public async Task<ListCustomizedVoiceJobsResponse> ListCustomizedVoiceJobsAsync(ListCustomizedVoiceJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomizedVoiceJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取用户的专属人声列表
         *
         * @param request ListCustomizedVoicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomizedVoicesResponse
         */
        public ListCustomizedVoicesResponse ListCustomizedVoicesWithOptions(ListCustomizedVoicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListCustomizedVoices",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomizedVoicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用户的专属人声列表
         *
         * @param request ListCustomizedVoicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCustomizedVoicesResponse
         */
        public async Task<ListCustomizedVoicesResponse> ListCustomizedVoicesWithOptionsAsync(ListCustomizedVoicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListCustomizedVoices",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomizedVoicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户的专属人声列表
         *
         * @param request ListCustomizedVoicesRequest
         * @return ListCustomizedVoicesResponse
         */
        public ListCustomizedVoicesResponse ListCustomizedVoices(ListCustomizedVoicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomizedVoicesWithOptions(request, runtime);
        }

        /**
         * @summary 获取用户的专属人声列表
         *
         * @param request ListCustomizedVoicesRequest
         * @return ListCustomizedVoicesResponse
         */
        public async Task<ListCustomizedVoicesResponse> ListCustomizedVoicesAsync(ListCustomizedVoicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomizedVoicesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询DNA库
         *
         * @param request ListDNADBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDNADBResponse
         */
        public ListDNADBResponse ListDNADBWithOptions(ListDNADBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBIds))
            {
                query["DBIds"] = request.DBIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDNADB",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDNADBResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询DNA库
         *
         * @param request ListDNADBRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDNADBResponse
         */
        public async Task<ListDNADBResponse> ListDNADBWithOptionsAsync(ListDNADBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBIds))
            {
                query["DBIds"] = request.DBIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDNADB",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDNADBResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询DNA库
         *
         * @param request ListDNADBRequest
         * @return ListDNADBResponse
         */
        public ListDNADBResponse ListDNADB(ListDNADBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDNADBWithOptions(request, runtime);
        }

        /**
         * @summary 查询DNA库
         *
         * @param request ListDNADBRequest
         * @return ListDNADBResponse
         */
        public async Task<ListDNADBResponse> ListDNADBAsync(ListDNADBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDNADBWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询DNA文件
         *
         * @param request ListDNAFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDNAFilesResponse
         */
        public ListDNAFilesResponse ListDNAFilesWithOptions(ListDNAFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBId))
            {
                query["DBId"] = request.DBId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDNAFiles",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDNAFilesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询DNA文件
         *
         * @param request ListDNAFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDNAFilesResponse
         */
        public async Task<ListDNAFilesResponse> ListDNAFilesWithOptionsAsync(ListDNAFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBId))
            {
                query["DBId"] = request.DBId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDNAFiles",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDNAFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询DNA文件
         *
         * @param request ListDNAFilesRequest
         * @return ListDNAFilesResponse
         */
        public ListDNAFilesResponse ListDNAFiles(ListDNAFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDNAFilesWithOptions(request, runtime);
        }

        /**
         * @summary 查询DNA文件
         *
         * @param request ListDNAFilesRequest
         * @return ListDNAFilesResponse
         */
        public async Task<ListDNAFilesResponse> ListDNAFilesAsync(ListDNAFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDNAFilesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询截图任务列表接口
         *
         * @param request ListDynamicImageJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDynamicImageJobsResponse
         */
        public ListDynamicImageJobsResponse ListDynamicImageJobsWithOptions(ListDynamicImageJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOfCreateTime))
            {
                query["EndOfCreateTime"] = request.EndOfCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOfCreateTime))
            {
                query["StartOfCreateTime"] = request.StartOfCreateTime;
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
                Action = "ListDynamicImageJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDynamicImageJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询截图任务列表接口
         *
         * @param request ListDynamicImageJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDynamicImageJobsResponse
         */
        public async Task<ListDynamicImageJobsResponse> ListDynamicImageJobsWithOptionsAsync(ListDynamicImageJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOfCreateTime))
            {
                query["EndOfCreateTime"] = request.EndOfCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOfCreateTime))
            {
                query["StartOfCreateTime"] = request.StartOfCreateTime;
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
                Action = "ListDynamicImageJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDynamicImageJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询截图任务列表接口
         *
         * @param request ListDynamicImageJobsRequest
         * @return ListDynamicImageJobsResponse
         */
        public ListDynamicImageJobsResponse ListDynamicImageJobs(ListDynamicImageJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDynamicImageJobsWithOptions(request, runtime);
        }

        /**
         * @summary 查询截图任务列表接口
         *
         * @param request ListDynamicImageJobsRequest
         * @return ListDynamicImageJobsResponse
         */
        public async Task<ListDynamicImageJobsResponse> ListDynamicImageJobsAsync(ListDynamicImageJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDynamicImageJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询录制文件
         *
         * @param request ListLiveRecordFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveRecordFilesResponse
         */
        public ListLiveRecordFilesResponse ListLiveRecordFilesWithOptions(ListLiveRecordFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveRecordFiles",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveRecordFilesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询录制文件
         *
         * @param request ListLiveRecordFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveRecordFilesResponse
         */
        public async Task<ListLiveRecordFilesResponse> ListLiveRecordFilesWithOptionsAsync(ListLiveRecordFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveRecordFiles",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveRecordFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询录制文件
         *
         * @param request ListLiveRecordFilesRequest
         * @return ListLiveRecordFilesResponse
         */
        public ListLiveRecordFilesResponse ListLiveRecordFiles(ListLiveRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveRecordFilesWithOptions(request, runtime);
        }

        /**
         * @summary 查询录制文件
         *
         * @param request ListLiveRecordFilesRequest
         * @return ListLiveRecordFilesResponse
         */
        public async Task<ListLiveRecordFilesResponse> ListLiveRecordFilesAsync(ListLiveRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveRecordFilesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询录制任务
         *
         * @param request ListLiveRecordJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveRecordJobsResponse
         */
        public ListLiveRecordJobsResponse ListLiveRecordJobsWithOptions(ListLiveRecordJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveRecordJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveRecordJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询录制任务
         *
         * @param request ListLiveRecordJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveRecordJobsResponse
         */
        public async Task<ListLiveRecordJobsResponse> ListLiveRecordJobsWithOptionsAsync(ListLiveRecordJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveRecordJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveRecordJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询录制任务
         *
         * @param request ListLiveRecordJobsRequest
         * @return ListLiveRecordJobsResponse
         */
        public ListLiveRecordJobsResponse ListLiveRecordJobs(ListLiveRecordJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveRecordJobsWithOptions(request, runtime);
        }

        /**
         * @summary 查询录制任务
         *
         * @param request ListLiveRecordJobsRequest
         * @return ListLiveRecordJobsResponse
         */
        public async Task<ListLiveRecordJobsResponse> ListLiveRecordJobsAsync(ListLiveRecordJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveRecordJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询直播录制模板
         *
         * @param request ListLiveRecordTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveRecordTemplatesResponse
         */
        public ListLiveRecordTemplatesResponse ListLiveRecordTemplatesWithOptions(ListLiveRecordTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveRecordTemplates",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveRecordTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询直播录制模板
         *
         * @param request ListLiveRecordTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveRecordTemplatesResponse
         */
        public async Task<ListLiveRecordTemplatesResponse> ListLiveRecordTemplatesWithOptionsAsync(ListLiveRecordTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveRecordTemplates",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveRecordTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询直播录制模板
         *
         * @param request ListLiveRecordTemplatesRequest
         * @return ListLiveRecordTemplatesResponse
         */
        public ListLiveRecordTemplatesResponse ListLiveRecordTemplates(ListLiveRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveRecordTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary 查询直播录制模板
         *
         * @param request ListLiveRecordTemplatesRequest
         * @return ListLiveRecordTemplatesResponse
         */
        public async Task<ListLiveRecordTemplatesResponse> ListLiveRecordTemplatesAsync(ListLiveRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveRecordTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询直播截图文件列表
         *
         * @param request ListLiveSnapshotFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveSnapshotFilesResponse
         */
        public ListLiveSnapshotFilesResponse ListLiveSnapshotFilesWithOptions(ListLiveSnapshotFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveSnapshotFiles",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveSnapshotFilesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询直播截图文件列表
         *
         * @param request ListLiveSnapshotFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveSnapshotFilesResponse
         */
        public async Task<ListLiveSnapshotFilesResponse> ListLiveSnapshotFilesWithOptionsAsync(ListLiveSnapshotFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveSnapshotFiles",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveSnapshotFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询直播截图文件列表
         *
         * @param request ListLiveSnapshotFilesRequest
         * @return ListLiveSnapshotFilesResponse
         */
        public ListLiveSnapshotFilesResponse ListLiveSnapshotFiles(ListLiveSnapshotFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveSnapshotFilesWithOptions(request, runtime);
        }

        /**
         * @summary 查询直播截图文件列表
         *
         * @param request ListLiveSnapshotFilesRequest
         * @return ListLiveSnapshotFilesResponse
         */
        public async Task<ListLiveSnapshotFilesResponse> ListLiveSnapshotFilesAsync(ListLiveSnapshotFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveSnapshotFilesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询直播截图任务列表
         *
         * @param request ListLiveSnapshotJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveSnapshotJobsResponse
         */
        public ListLiveSnapshotJobsResponse ListLiveSnapshotJobsWithOptions(ListLiveSnapshotJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveSnapshotJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveSnapshotJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询直播截图任务列表
         *
         * @param request ListLiveSnapshotJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveSnapshotJobsResponse
         */
        public async Task<ListLiveSnapshotJobsResponse> ListLiveSnapshotJobsWithOptionsAsync(ListLiveSnapshotJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveSnapshotJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveSnapshotJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询直播截图任务列表
         *
         * @param request ListLiveSnapshotJobsRequest
         * @return ListLiveSnapshotJobsResponse
         */
        public ListLiveSnapshotJobsResponse ListLiveSnapshotJobs(ListLiveSnapshotJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveSnapshotJobsWithOptions(request, runtime);
        }

        /**
         * @summary 查询直播截图任务列表
         *
         * @param request ListLiveSnapshotJobsRequest
         * @return ListLiveSnapshotJobsResponse
         */
        public async Task<ListLiveSnapshotJobsResponse> ListLiveSnapshotJobsAsync(ListLiveSnapshotJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveSnapshotJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询直播截图模板列表
         *
         * @param request ListLiveSnapshotTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveSnapshotTemplatesResponse
         */
        public ListLiveSnapshotTemplatesResponse ListLiveSnapshotTemplatesWithOptions(ListLiveSnapshotTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveSnapshotTemplates",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveSnapshotTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询直播截图模板列表
         *
         * @param request ListLiveSnapshotTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveSnapshotTemplatesResponse
         */
        public async Task<ListLiveSnapshotTemplatesResponse> ListLiveSnapshotTemplatesWithOptionsAsync(ListLiveSnapshotTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveSnapshotTemplates",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveSnapshotTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询直播截图模板列表
         *
         * @param request ListLiveSnapshotTemplatesRequest
         * @return ListLiveSnapshotTemplatesResponse
         */
        public ListLiveSnapshotTemplatesResponse ListLiveSnapshotTemplates(ListLiveSnapshotTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveSnapshotTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary 查询直播截图模板列表
         *
         * @param request ListLiveSnapshotTemplatesRequest
         * @return ListLiveSnapshotTemplatesResponse
         */
        public async Task<ListLiveSnapshotTemplatesResponse> ListLiveSnapshotTemplatesAsync(ListLiveSnapshotTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveSnapshotTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询转码任务列表
         *
         * @param request ListLiveTranscodeJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveTranscodeJobsResponse
         */
        public ListLiveTranscodeJobsResponse ListLiveTranscodeJobsWithOptions(ListLiveTranscodeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartMode))
            {
                query["StartMode"] = request.StartMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListLiveTranscodeJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveTranscodeJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询转码任务列表
         *
         * @param request ListLiveTranscodeJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveTranscodeJobsResponse
         */
        public async Task<ListLiveTranscodeJobsResponse> ListLiveTranscodeJobsWithOptionsAsync(ListLiveTranscodeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartMode))
            {
                query["StartMode"] = request.StartMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListLiveTranscodeJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveTranscodeJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询转码任务列表
         *
         * @param request ListLiveTranscodeJobsRequest
         * @return ListLiveTranscodeJobsResponse
         */
        public ListLiveTranscodeJobsResponse ListLiveTranscodeJobs(ListLiveTranscodeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveTranscodeJobsWithOptions(request, runtime);
        }

        /**
         * @summary 查询转码任务列表
         *
         * @param request ListLiveTranscodeJobsRequest
         * @return ListLiveTranscodeJobsResponse
         */
        public async Task<ListLiveTranscodeJobsResponse> ListLiveTranscodeJobsAsync(ListLiveTranscodeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveTranscodeJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询转码模版列表
         *
         * @param request ListLiveTranscodeTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveTranscodeTemplatesResponse
         */
        public ListLiveTranscodeTemplatesResponse ListLiveTranscodeTemplatesWithOptions(ListLiveTranscodeTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoCodec))
            {
                query["VideoCodec"] = request.VideoCodec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveTranscodeTemplates",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveTranscodeTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询转码模版列表
         *
         * @param request ListLiveTranscodeTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLiveTranscodeTemplatesResponse
         */
        public async Task<ListLiveTranscodeTemplatesResponse> ListLiveTranscodeTemplatesWithOptionsAsync(ListLiveTranscodeTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoCodec))
            {
                query["VideoCodec"] = request.VideoCodec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLiveTranscodeTemplates",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveTranscodeTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询转码模版列表
         *
         * @param request ListLiveTranscodeTemplatesRequest
         * @return ListLiveTranscodeTemplatesResponse
         */
        public ListLiveTranscodeTemplatesResponse ListLiveTranscodeTemplates(ListLiveTranscodeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveTranscodeTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary 查询转码模版列表
         *
         * @param request ListLiveTranscodeTemplatesRequest
         * @return ListLiveTranscodeTemplatesResponse
         */
        public async Task<ListLiveTranscodeTemplatesResponse> ListLiveTranscodeTemplatesAsync(ListLiveTranscodeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveTranscodeTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出符合条件的媒资基础信息
         *
         * @param request ListMediaBasicInfosRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMediaBasicInfosResponse
         */
        public ListMediaBasicInfosResponse ListMediaBasicInfosWithOptions(ListMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeFileBasicInfo))
            {
                query["IncludeFileBasicInfo"] = request.IncludeFileBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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

        /**
         * @summary 列出符合条件的媒资基础信息
         *
         * @param request ListMediaBasicInfosRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMediaBasicInfosResponse
         */
        public async Task<ListMediaBasicInfosResponse> ListMediaBasicInfosWithOptionsAsync(ListMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeFileBasicInfo))
            {
                query["IncludeFileBasicInfo"] = request.IncludeFileBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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

        /**
         * @summary 列出符合条件的媒资基础信息
         *
         * @param request ListMediaBasicInfosRequest
         * @return ListMediaBasicInfosResponse
         */
        public ListMediaBasicInfosResponse ListMediaBasicInfos(ListMediaBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaBasicInfosWithOptions(request, runtime);
        }

        /**
         * @summary 列出符合条件的媒资基础信息
         *
         * @param request ListMediaBasicInfosRequest
         * @return ListMediaBasicInfosResponse
         */
        public async Task<ListMediaBasicInfosResponse> ListMediaBasicInfosAsync(ListMediaBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaBasicInfosWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListMediaInfoJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMediaInfoJobsResponse
         */
        public ListMediaInfoJobsResponse ListMediaInfoJobsWithOptions(ListMediaInfoJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOfCreateTime))
            {
                query["EndOfCreateTime"] = request.EndOfCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOfCreateTime))
            {
                query["StartOfCreateTime"] = request.StartOfCreateTime;
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
                Action = "ListMediaInfoJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaInfoJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListMediaInfoJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMediaInfoJobsResponse
         */
        public async Task<ListMediaInfoJobsResponse> ListMediaInfoJobsWithOptionsAsync(ListMediaInfoJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOfCreateTime))
            {
                query["EndOfCreateTime"] = request.EndOfCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOfCreateTime))
            {
                query["StartOfCreateTime"] = request.StartOfCreateTime;
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
                Action = "ListMediaInfoJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaInfoJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListMediaInfoJobsRequest
         * @return ListMediaInfoJobsResponse
         */
        public ListMediaInfoJobsResponse ListMediaInfoJobs(ListMediaInfoJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaInfoJobsWithOptions(request, runtime);
        }

        /**
         * @param request ListMediaInfoJobsRequest
         * @return ListMediaInfoJobsResponse
         */
        public async Task<ListMediaInfoJobsResponse> ListMediaInfoJobsAsync(ListMediaInfoJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaInfoJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取媒资的标注信息
         *
         * @param request ListMediaMarksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMediaMarksResponse
         */
        public ListMediaMarksResponse ListMediaMarksWithOptions(ListMediaMarksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMarkIds))
            {
                query["MediaMarkIds"] = request.MediaMarkIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMediaMarks",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaMarksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取媒资的标注信息
         *
         * @param request ListMediaMarksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMediaMarksResponse
         */
        public async Task<ListMediaMarksResponse> ListMediaMarksWithOptionsAsync(ListMediaMarksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMarkIds))
            {
                query["MediaMarkIds"] = request.MediaMarkIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMediaMarks",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaMarksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取媒资的标注信息
         *
         * @param request ListMediaMarksRequest
         * @return ListMediaMarksResponse
         */
        public ListMediaMarksResponse ListMediaMarks(ListMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaMarksWithOptions(request, runtime);
        }

        /**
         * @summary 获取媒资的标注信息
         *
         * @param request ListMediaMarksRequest
         * @return ListMediaMarksResponse
         */
        public async Task<ListMediaMarksResponse> ListMediaMarksAsync(ListMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaMarksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出合成任务列表
         *
         * @param request ListMediaProducingJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMediaProducingJobsResponse
         */
        public ListMediaProducingJobsResponse ListMediaProducingJobsWithOptions(ListMediaProducingJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterJobId))
            {
                query["MasterJobId"] = request.MasterJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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

        /**
         * @summary 列出合成任务列表
         *
         * @param request ListMediaProducingJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMediaProducingJobsResponse
         */
        public async Task<ListMediaProducingJobsResponse> ListMediaProducingJobsWithOptionsAsync(ListMediaProducingJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterJobId))
            {
                query["MasterJobId"] = request.MasterJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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

        /**
         * @summary 列出合成任务列表
         *
         * @param request ListMediaProducingJobsRequest
         * @return ListMediaProducingJobsResponse
         */
        public ListMediaProducingJobsResponse ListMediaProducingJobs(ListMediaProducingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaProducingJobsWithOptions(request, runtime);
        }

        /**
         * @summary 列出合成任务列表
         *
         * @param request ListMediaProducingJobsRequest
         * @return ListMediaProducingJobsResponse
         */
        public async Task<ListMediaProducingJobsResponse> ListMediaProducingJobsAsync(ListMediaProducingJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaProducingJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取打包任务列表
         *
         * @param request ListPackageJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPackageJobsResponse
         */
        public ListPackageJobsResponse ListPackageJobsWithOptions(ListPackageJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOfCreateTime))
            {
                query["EndOfCreateTime"] = request.EndOfCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOfCreateTime))
            {
                query["StartOfCreateTime"] = request.StartOfCreateTime;
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
                Action = "ListPackageJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPackageJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取打包任务列表
         *
         * @param request ListPackageJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPackageJobsResponse
         */
        public async Task<ListPackageJobsResponse> ListPackageJobsWithOptionsAsync(ListPackageJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOfCreateTime))
            {
                query["EndOfCreateTime"] = request.EndOfCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOfCreateTime))
            {
                query["StartOfCreateTime"] = request.StartOfCreateTime;
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
                Action = "ListPackageJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPackageJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取打包任务列表
         *
         * @param request ListPackageJobsRequest
         * @return ListPackageJobsResponse
         */
        public ListPackageJobsResponse ListPackageJobs(ListPackageJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPackageJobsWithOptions(request, runtime);
        }

        /**
         * @summary 获取打包任务列表
         *
         * @param request ListPackageJobsRequest
         * @return ListPackageJobsResponse
         */
        public async Task<ListPackageJobsResponse> ListPackageJobsAsync(ListPackageJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPackageJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取管道配置列表
         *
         * @param request ListPipelinesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPipelinesResponse
         */
        public ListPipelinesResponse ListPipelinesWithOptions(ListPipelinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelines",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelinesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取管道配置列表
         *
         * @param request ListPipelinesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPipelinesResponse
         */
        public async Task<ListPipelinesResponse> ListPipelinesWithOptionsAsync(ListPipelinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelines",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取管道配置列表
         *
         * @param request ListPipelinesRequest
         * @return ListPipelinesResponse
         */
        public ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPipelinesWithOptions(request, runtime);
        }

        /**
         * @summary 获取管道配置列表
         *
         * @param request ListPipelinesRequest
         * @return ListPipelinesResponse
         */
        public async Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPipelinesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出公共素材库素材的基础信息
         *
         * @param request ListPublicMediaBasicInfosRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublicMediaBasicInfosResponse
         */
        public ListPublicMediaBasicInfosResponse ListPublicMediaBasicInfosWithOptions(ListPublicMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeFileBasicInfo))
            {
                query["IncludeFileBasicInfo"] = request.IncludeFileBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTagId))
            {
                query["MediaTagId"] = request.MediaTagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListPublicMediaBasicInfos",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublicMediaBasicInfosResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列出公共素材库素材的基础信息
         *
         * @param request ListPublicMediaBasicInfosRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublicMediaBasicInfosResponse
         */
        public async Task<ListPublicMediaBasicInfosResponse> ListPublicMediaBasicInfosWithOptionsAsync(ListPublicMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeFileBasicInfo))
            {
                query["IncludeFileBasicInfo"] = request.IncludeFileBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTagId))
            {
                query["MediaTagId"] = request.MediaTagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListPublicMediaBasicInfos",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublicMediaBasicInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列出公共素材库素材的基础信息
         *
         * @param request ListPublicMediaBasicInfosRequest
         * @return ListPublicMediaBasicInfosResponse
         */
        public ListPublicMediaBasicInfosResponse ListPublicMediaBasicInfos(ListPublicMediaBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPublicMediaBasicInfosWithOptions(request, runtime);
        }

        /**
         * @summary 列出公共素材库素材的基础信息
         *
         * @param request ListPublicMediaBasicInfosRequest
         * @return ListPublicMediaBasicInfosResponse
         */
        public async Task<ListPublicMediaBasicInfosResponse> ListPublicMediaBasicInfosAsync(ListPublicMediaBasicInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPublicMediaBasicInfosWithOptionsAsync(request, runtime);
        }

        /**
         * @summary ListSmartJobs
         *
         * @param request ListSmartJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSmartJobsResponse
         */
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

        /**
         * @summary ListSmartJobs
         *
         * @param request ListSmartJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSmartJobsResponse
         */
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

        /**
         * @summary ListSmartJobs
         *
         * @param request ListSmartJobsRequest
         * @return ListSmartJobsResponse
         */
        public ListSmartJobsResponse ListSmartJobs(ListSmartJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSmartJobsWithOptions(request, runtime);
        }

        /**
         * @summary ListSmartJobs
         *
         * @param request ListSmartJobsRequest
         * @return ListSmartJobsResponse
         */
        public async Task<ListSmartJobsResponse> ListSmartJobsAsync(ListSmartJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSmartJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出虚拟人官方模特配置
         *
         * @param request ListSmartSysAvatarModelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSmartSysAvatarModelsResponse
         */
        public ListSmartSysAvatarModelsResponse ListSmartSysAvatarModelsWithOptions(ListSmartSysAvatarModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkVersion))
            {
                query["SdkVersion"] = request.SdkVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSmartSysAvatarModels",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSmartSysAvatarModelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列出虚拟人官方模特配置
         *
         * @param request ListSmartSysAvatarModelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSmartSysAvatarModelsResponse
         */
        public async Task<ListSmartSysAvatarModelsResponse> ListSmartSysAvatarModelsWithOptionsAsync(ListSmartSysAvatarModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkVersion))
            {
                query["SdkVersion"] = request.SdkVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSmartSysAvatarModels",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSmartSysAvatarModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列出虚拟人官方模特配置
         *
         * @param request ListSmartSysAvatarModelsRequest
         * @return ListSmartSysAvatarModelsResponse
         */
        public ListSmartSysAvatarModelsResponse ListSmartSysAvatarModels(ListSmartSysAvatarModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSmartSysAvatarModelsWithOptions(request, runtime);
        }

        /**
         * @summary 列出虚拟人官方模特配置
         *
         * @param request ListSmartSysAvatarModelsRequest
         * @return ListSmartSysAvatarModelsResponse
         */
        public async Task<ListSmartSysAvatarModelsResponse> ListSmartSysAvatarModelsAsync(ListSmartSysAvatarModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSmartSysAvatarModelsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出智能语音发音人信息
         *
         * @param request ListSmartVoiceGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSmartVoiceGroupsResponse
         */
        public ListSmartVoiceGroupsResponse ListSmartVoiceGroupsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSmartVoiceGroups",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSmartVoiceGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列出智能语音发音人信息
         *
         * @param request ListSmartVoiceGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSmartVoiceGroupsResponse
         */
        public async Task<ListSmartVoiceGroupsResponse> ListSmartVoiceGroupsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSmartVoiceGroups",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSmartVoiceGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列出智能语音发音人信息
         *
         * @return ListSmartVoiceGroupsResponse
         */
        public ListSmartVoiceGroupsResponse ListSmartVoiceGroups()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSmartVoiceGroupsWithOptions(runtime);
        }

        /**
         * @summary 列出智能语音发音人信息
         *
         * @return ListSmartVoiceGroupsResponse
         */
        public async Task<ListSmartVoiceGroupsResponse> ListSmartVoiceGroupsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSmartVoiceGroupsWithOptionsAsync(runtime);
        }

        /**
         * @summary 查询截图任务列表接口
         *
         * @param request ListSnapshotJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSnapshotJobsResponse
         */
        public ListSnapshotJobsResponse ListSnapshotJobsWithOptions(ListSnapshotJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOfCreateTime))
            {
                query["EndOfCreateTime"] = request.EndOfCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOfCreateTime))
            {
                query["StartOfCreateTime"] = request.StartOfCreateTime;
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
                Action = "ListSnapshotJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询截图任务列表接口
         *
         * @param request ListSnapshotJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSnapshotJobsResponse
         */
        public async Task<ListSnapshotJobsResponse> ListSnapshotJobsWithOptionsAsync(ListSnapshotJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOfCreateTime))
            {
                query["EndOfCreateTime"] = request.EndOfCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOfCreateTime))
            {
                query["StartOfCreateTime"] = request.StartOfCreateTime;
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
                Action = "ListSnapshotJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询截图任务列表接口
         *
         * @param request ListSnapshotJobsRequest
         * @return ListSnapshotJobsResponse
         */
        public ListSnapshotJobsResponse ListSnapshotJobs(ListSnapshotJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSnapshotJobsWithOptions(request, runtime);
        }

        /**
         * @summary 查询截图任务列表接口
         *
         * @param request ListSnapshotJobsRequest
         * @return ListSnapshotJobsResponse
         */
        public async Task<ListSnapshotJobsResponse> ListSnapshotJobsAsync(ListSnapshotJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSnapshotJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取媒体处理系统模板列表
         *
         * @param request ListSystemTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSystemTemplatesResponse
         */
        public ListSystemTemplatesResponse ListSystemTemplatesWithOptions(ListSystemTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subtype))
            {
                query["Subtype"] = request.Subtype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "ListSystemTemplates",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSystemTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取媒体处理系统模板列表
         *
         * @param request ListSystemTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSystemTemplatesResponse
         */
        public async Task<ListSystemTemplatesResponse> ListSystemTemplatesWithOptionsAsync(ListSystemTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subtype))
            {
                query["Subtype"] = request.Subtype;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "ListSystemTemplates",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSystemTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取媒体处理系统模板列表
         *
         * @param request ListSystemTemplatesRequest
         * @return ListSystemTemplatesResponse
         */
        public ListSystemTemplatesResponse ListSystemTemplates(ListSystemTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSystemTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary 获取媒体处理系统模板列表
         *
         * @param request ListSystemTemplatesRequest
         * @return ListSystemTemplatesResponse
         */
        public async Task<ListSystemTemplatesResponse> ListSystemTemplatesAsync(ListSystemTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSystemTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary ListTemplates
         *
         * @param request ListTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTemplatesResponse
         */
        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateSource))
            {
                query["CreateSource"] = request.CreateSource;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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

        /**
         * @summary ListTemplates
         *
         * @param request ListTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTemplatesResponse
         */
        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateSource))
            {
                query["CreateSource"] = request.CreateSource;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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

        /**
         * @summary ListTemplates
         *
         * @param request ListTemplatesRequest
         * @return ListTemplatesResponse
         */
        public ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary ListTemplates
         *
         * @param request ListTemplatesRequest
         * @return ListTemplatesResponse
         */
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListTranscodeJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTranscodeJobsResponse
         */
        public ListTranscodeJobsResponse ListTranscodeJobsWithOptions(ListTranscodeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOfCreateTime))
            {
                query["EndOfCreateTime"] = request.EndOfCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentJobId))
            {
                query["ParentJobId"] = request.ParentJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOfCreateTime))
            {
                query["StartOfCreateTime"] = request.StartOfCreateTime;
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
                Action = "ListTranscodeJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTranscodeJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListTranscodeJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTranscodeJobsResponse
         */
        public async Task<ListTranscodeJobsResponse> ListTranscodeJobsWithOptionsAsync(ListTranscodeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOfCreateTime))
            {
                query["EndOfCreateTime"] = request.EndOfCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentJobId))
            {
                query["ParentJobId"] = request.ParentJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOfCreateTime))
            {
                query["StartOfCreateTime"] = request.StartOfCreateTime;
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
                Action = "ListTranscodeJobs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTranscodeJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListTranscodeJobsRequest
         * @return ListTranscodeJobsResponse
         */
        public ListTranscodeJobsResponse ListTranscodeJobs(ListTranscodeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTranscodeJobsWithOptions(request, runtime);
        }

        /**
         * @param request ListTranscodeJobsRequest
         * @return ListTranscodeJobsResponse
         */
        public async Task<ListTranscodeJobsResponse> ListTranscodeJobsAsync(ListTranscodeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTranscodeJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询DNA作业
         *
         * @param request QueryDNAJobListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDNAJobListResponse
         */
        public QueryDNAJobListResponse QueryDNAJobListWithOptions(QueryDNAJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDNAJobList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDNAJobListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询DNA作业
         *
         * @param request QueryDNAJobListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDNAJobListResponse
         */
        public async Task<QueryDNAJobListResponse> QueryDNAJobListWithOptionsAsync(QueryDNAJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDNAJobList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDNAJobListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询DNA作业
         *
         * @param request QueryDNAJobListRequest
         * @return QueryDNAJobListResponse
         */
        public QueryDNAJobListResponse QueryDNAJobList(QueryDNAJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDNAJobListWithOptions(request, runtime);
        }

        /**
         * @summary 查询DNA作业
         *
         * @param request QueryDNAJobListRequest
         * @return QueryDNAJobListResponse
         */
        public async Task<QueryDNAJobListResponse> QueryDNAJobListAsync(QueryDNAJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDNAJobListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询智能生产作业
         *
         * @param request QueryIProductionJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryIProductionJobResponse
         */
        public QueryIProductionJobResponse QueryIProductionJobWithOptions(QueryIProductionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryIProductionJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIProductionJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询智能生产作业
         *
         * @param request QueryIProductionJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryIProductionJobResponse
         */
        public async Task<QueryIProductionJobResponse> QueryIProductionJobWithOptionsAsync(QueryIProductionJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryIProductionJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIProductionJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询智能生产作业
         *
         * @param request QueryIProductionJobRequest
         * @return QueryIProductionJobResponse
         */
        public QueryIProductionJobResponse QueryIProductionJob(QueryIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIProductionJobWithOptions(request, runtime);
        }

        /**
         * @summary 查询智能生产作业
         *
         * @param request QueryIProductionJobRequest
         * @return QueryIProductionJobResponse
         */
        public async Task<QueryIProductionJobResponse> QueryIProductionJobAsync(QueryIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIProductionJobWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryMediaCensorJobDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMediaCensorJobDetailResponse
         */
        public QueryMediaCensorJobDetailResponse QueryMediaCensorJobDetailWithOptions(QueryMediaCensorJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumPageSize))
            {
                query["MaximumPageSize"] = request.MaximumPageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMediaCensorJobDetail",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMediaCensorJobDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryMediaCensorJobDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMediaCensorJobDetailResponse
         */
        public async Task<QueryMediaCensorJobDetailResponse> QueryMediaCensorJobDetailWithOptionsAsync(QueryMediaCensorJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumPageSize))
            {
                query["MaximumPageSize"] = request.MaximumPageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMediaCensorJobDetail",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMediaCensorJobDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryMediaCensorJobDetailRequest
         * @return QueryMediaCensorJobDetailResponse
         */
        public QueryMediaCensorJobDetailResponse QueryMediaCensorJobDetail(QueryMediaCensorJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaCensorJobDetailWithOptions(request, runtime);
        }

        /**
         * @param request QueryMediaCensorJobDetailRequest
         * @return QueryMediaCensorJobDetailResponse
         */
        public async Task<QueryMediaCensorJobDetailResponse> QueryMediaCensorJobDetailAsync(QueryMediaCensorJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaCensorJobDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryMediaCensorJobListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMediaCensorJobListResponse
         */
        public QueryMediaCensorJobListResponse QueryMediaCensorJobListWithOptions(QueryMediaCensorJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOfJobCreatedTimeRange))
            {
                query["EndOfJobCreatedTimeRange"] = request.EndOfJobCreatedTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumPageSize))
            {
                query["MaximumPageSize"] = request.MaximumPageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOfJobCreatedTimeRange))
            {
                query["StartOfJobCreatedTimeRange"] = request.StartOfJobCreatedTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMediaCensorJobList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMediaCensorJobListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryMediaCensorJobListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMediaCensorJobListResponse
         */
        public async Task<QueryMediaCensorJobListResponse> QueryMediaCensorJobListWithOptionsAsync(QueryMediaCensorJobListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOfJobCreatedTimeRange))
            {
                query["EndOfJobCreatedTimeRange"] = request.EndOfJobCreatedTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumPageSize))
            {
                query["MaximumPageSize"] = request.MaximumPageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPageToken))
            {
                query["NextPageToken"] = request.NextPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOfJobCreatedTimeRange))
            {
                query["StartOfJobCreatedTimeRange"] = request.StartOfJobCreatedTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMediaCensorJobList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMediaCensorJobListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryMediaCensorJobListRequest
         * @return QueryMediaCensorJobListResponse
         */
        public QueryMediaCensorJobListResponse QueryMediaCensorJobList(QueryMediaCensorJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaCensorJobListWithOptions(request, runtime);
        }

        /**
         * @param request QueryMediaCensorJobListRequest
         * @return QueryMediaCensorJobListResponse
         */
        public async Task<QueryMediaCensorJobListResponse> QueryMediaCensorJobListAsync(QueryMediaCensorJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaCensorJobListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询索引任务
         *
         * @param request QueryMediaIndexJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMediaIndexJobResponse
         */
        public QueryMediaIndexJobResponse QueryMediaIndexJobWithOptions(QueryMediaIndexJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMediaIndexJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMediaIndexJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询索引任务
         *
         * @param request QueryMediaIndexJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMediaIndexJobResponse
         */
        public async Task<QueryMediaIndexJobResponse> QueryMediaIndexJobWithOptionsAsync(QueryMediaIndexJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMediaIndexJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMediaIndexJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询索引任务
         *
         * @param request QueryMediaIndexJobRequest
         * @return QueryMediaIndexJobResponse
         */
        public QueryMediaIndexJobResponse QueryMediaIndexJob(QueryMediaIndexJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaIndexJobWithOptions(request, runtime);
        }

        /**
         * @summary 查询索引任务
         *
         * @param request QueryMediaIndexJobRequest
         * @return QueryMediaIndexJobResponse
         */
        public async Task<QueryMediaIndexJobResponse> QueryMediaIndexJobAsync(QueryMediaIndexJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaIndexJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询搜索索引
         *
         * @param request QuerySearchIndexRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySearchIndexResponse
         */
        public QuerySearchIndexResponse QuerySearchIndexWithOptions(QuerySearchIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexType))
            {
                query["IndexType"] = request.IndexType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySearchIndex",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySearchIndexResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询搜索索引
         *
         * @param request QuerySearchIndexRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySearchIndexResponse
         */
        public async Task<QuerySearchIndexResponse> QuerySearchIndexWithOptionsAsync(QuerySearchIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexType))
            {
                query["IndexType"] = request.IndexType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySearchIndex",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySearchIndexResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询搜索索引
         *
         * @param request QuerySearchIndexRequest
         * @return QuerySearchIndexResponse
         */
        public QuerySearchIndexResponse QuerySearchIndex(QuerySearchIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySearchIndexWithOptions(request, runtime);
        }

        /**
         * @summary 查询搜索索引
         *
         * @param request QuerySearchIndexRequest
         * @return QuerySearchIndexResponse
         */
        public async Task<QuerySearchIndexResponse> QuerySearchIndexAsync(QuerySearchIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySearchIndexWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询库
         *
         * @param request QuerySearchLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySearchLibResponse
         */
        public QuerySearchLibResponse QuerySearchLibWithOptions(QuerySearchLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySearchLib",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySearchLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询库
         *
         * @param request QuerySearchLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySearchLibResponse
         */
        public async Task<QuerySearchLibResponse> QuerySearchLibWithOptionsAsync(QuerySearchLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySearchLib",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySearchLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询库
         *
         * @param request QuerySearchLibRequest
         * @return QuerySearchLibResponse
         */
        public QuerySearchLibResponse QuerySearchLib(QuerySearchLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySearchLibWithOptions(request, runtime);
        }

        /**
         * @summary 查询库
         *
         * @param request QuerySearchLibRequest
         * @return QuerySearchLibResponse
         */
        public async Task<QuerySearchLibResponse> QuerySearchLibAsync(QuerySearchLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySearchLibWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QuerySmarttagJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySmarttagJobResponse
         */
        public QuerySmarttagJobResponse QuerySmarttagJobWithOptions(QuerySmarttagJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmarttagJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmarttagJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QuerySmarttagJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySmarttagJobResponse
         */
        public async Task<QuerySmarttagJobResponse> QuerySmarttagJobWithOptionsAsync(QuerySmarttagJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySmarttagJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySmarttagJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QuerySmarttagJobRequest
         * @return QuerySmarttagJobResponse
         */
        public QuerySmarttagJobResponse QuerySmarttagJob(QuerySmarttagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmarttagJobWithOptions(request, runtime);
        }

        /**
         * @param request QuerySmarttagJobRequest
         * @return QuerySmarttagJobResponse
         */
        public async Task<QuerySmarttagJobResponse> QuerySmarttagJobAsync(QuerySmarttagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmarttagJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 刷新媒资上传凭证
         *
         * @param request RefreshUploadMediaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshUploadMediaResponse
         */
        public RefreshUploadMediaResponse RefreshUploadMediaWithOptions(RefreshUploadMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "RefreshUploadMedia",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshUploadMediaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 刷新媒资上传凭证
         *
         * @param request RefreshUploadMediaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshUploadMediaResponse
         */
        public async Task<RefreshUploadMediaResponse> RefreshUploadMediaWithOptionsAsync(RefreshUploadMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "RefreshUploadMedia",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshUploadMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 刷新媒资上传凭证
         *
         * @param request RefreshUploadMediaRequest
         * @return RefreshUploadMediaResponse
         */
        public RefreshUploadMediaResponse RefreshUploadMedia(RefreshUploadMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshUploadMediaWithOptions(request, runtime);
        }

        /**
         * @summary 刷新媒资上传凭证
         *
         * @param request RefreshUploadMediaRequest
         * @return RefreshUploadMediaResponse
         */
        public async Task<RefreshUploadMediaResponse> RefreshUploadMediaAsync(RefreshUploadMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshUploadMediaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 注册内容库资源
         *
         * @param request RegisterMediaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterMediaInfoResponse
         */
        public RegisterMediaInfoResponse RegisterMediaInfoWithOptions(RegisterMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceId))
            {
                query["ReferenceId"] = request.ReferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterConfig))
            {
                query["RegisterConfig"] = request.RegisterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmartTagTemplateId))
            {
                query["SmartTagTemplateId"] = request.SmartTagTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                query["WorkflowId"] = request.WorkflowId;
            }
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

        /**
         * @summary 注册内容库资源
         *
         * @param request RegisterMediaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterMediaInfoResponse
         */
        public async Task<RegisterMediaInfoResponse> RegisterMediaInfoWithOptionsAsync(RegisterMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceId))
            {
                query["ReferenceId"] = request.ReferenceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterConfig))
            {
                query["RegisterConfig"] = request.RegisterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmartTagTemplateId))
            {
                query["SmartTagTemplateId"] = request.SmartTagTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                query["WorkflowId"] = request.WorkflowId;
            }
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

        /**
         * @summary 注册内容库资源
         *
         * @param request RegisterMediaInfoRequest
         * @return RegisterMediaInfoResponse
         */
        public RegisterMediaInfoResponse RegisterMediaInfo(RegisterMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterMediaInfoWithOptions(request, runtime);
        }

        /**
         * @summary 注册内容库资源
         *
         * @param request RegisterMediaInfoRequest
         * @return RegisterMediaInfoResponse
         */
        public async Task<RegisterMediaInfoResponse> RegisterMediaInfoAsync(RegisterMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterMediaInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 注册媒体流
         *
         * @param request RegisterMediaStreamRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterMediaStreamResponse
         */
        public RegisterMediaStreamResponse RegisterMediaStreamWithOptions(RegisterMediaStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "RegisterMediaStream",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterMediaStreamResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 注册媒体流
         *
         * @param request RegisterMediaStreamRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterMediaStreamResponse
         */
        public async Task<RegisterMediaStreamResponse> RegisterMediaStreamWithOptionsAsync(RegisterMediaStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputURL))
            {
                query["InputURL"] = request.InputURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "RegisterMediaStream",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterMediaStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 注册媒体流
         *
         * @param request RegisterMediaStreamRequest
         * @return RegisterMediaStreamResponse
         */
        public RegisterMediaStreamResponse RegisterMediaStream(RegisterMediaStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterMediaStreamWithOptions(request, runtime);
        }

        /**
         * @summary 注册媒体流
         *
         * @param request RegisterMediaStreamRequest
         * @return RegisterMediaStreamResponse
         */
        public async Task<RegisterMediaStreamResponse> RegisterMediaStreamAsync(RegisterMediaStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterMediaStreamWithOptionsAsync(request, runtime);
        }

        /**
         * @summary SearchEditingProject
         *
         * @param request SearchEditingProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchEditingProjectResponse
         */
        public SearchEditingProjectResponse SearchEditingProjectWithOptions(SearchEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateSource))
            {
                query["CreateSource"] = request.CreateSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectType))
            {
                query["ProjectType"] = request.ProjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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

        /**
         * @summary SearchEditingProject
         *
         * @param request SearchEditingProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchEditingProjectResponse
         */
        public async Task<SearchEditingProjectResponse> SearchEditingProjectWithOptionsAsync(SearchEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateSource))
            {
                query["CreateSource"] = request.CreateSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectType))
            {
                query["ProjectType"] = request.ProjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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

        /**
         * @summary SearchEditingProject
         *
         * @param request SearchEditingProjectRequest
         * @return SearchEditingProjectResponse
         */
        public SearchEditingProjectResponse SearchEditingProject(SearchEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchEditingProjectWithOptions(request, runtime);
        }

        /**
         * @summary SearchEditingProject
         *
         * @param request SearchEditingProjectRequest
         * @return SearchEditingProjectResponse
         */
        public async Task<SearchEditingProjectResponse> SearchEditingProjectAsync(SearchEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchEditingProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 媒资搜索
         *
         * @param request SearchMediaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchMediaResponse
         */
        public SearchMediaResponse SearchMediaWithOptions(SearchMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScrollToken))
            {
                query["ScrollToken"] = request.ScrollToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
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
                Version = "2020-11-09",
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

        /**
         * @summary 媒资搜索
         *
         * @param request SearchMediaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchMediaResponse
         */
        public async Task<SearchMediaResponse> SearchMediaWithOptionsAsync(SearchMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScrollToken))
            {
                query["ScrollToken"] = request.ScrollToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
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
                Version = "2020-11-09",
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

        /**
         * @summary 媒资搜索
         *
         * @param request SearchMediaRequest
         * @return SearchMediaResponse
         */
        public SearchMediaResponse SearchMedia(SearchMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchMediaWithOptions(request, runtime);
        }

        /**
         * @summary 媒资搜索
         *
         * @param request SearchMediaRequest
         * @return SearchMediaResponse
         */
        public async Task<SearchMediaResponse> SearchMediaAsync(SearchMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchMediaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 智能标签搜索
         *
         * @param request SearchMediaByAILabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchMediaByAILabelResponse
         */
        public SearchMediaByAILabelResponse SearchMediaByAILabelWithOptions(SearchMediaByAILabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultimodalSearchType))
            {
                query["MultimodalSearchType"] = request.MultimodalSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificSearch))
            {
                query["SpecificSearch"] = request.SpecificSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMediaByAILabel",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMediaByAILabelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 智能标签搜索
         *
         * @param request SearchMediaByAILabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchMediaByAILabelResponse
         */
        public async Task<SearchMediaByAILabelResponse> SearchMediaByAILabelWithOptionsAsync(SearchMediaByAILabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultimodalSearchType))
            {
                query["MultimodalSearchType"] = request.MultimodalSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificSearch))
            {
                query["SpecificSearch"] = request.SpecificSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMediaByAILabel",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMediaByAILabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 智能标签搜索
         *
         * @param request SearchMediaByAILabelRequest
         * @return SearchMediaByAILabelResponse
         */
        public SearchMediaByAILabelResponse SearchMediaByAILabel(SearchMediaByAILabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchMediaByAILabelWithOptions(request, runtime);
        }

        /**
         * @summary 智能标签搜索
         *
         * @param request SearchMediaByAILabelRequest
         * @return SearchMediaByAILabelResponse
         */
        public async Task<SearchMediaByAILabelResponse> SearchMediaByAILabelAsync(SearchMediaByAILabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchMediaByAILabelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 人脸搜粗搜接口，输入一张人脸图片，搜索该人物所在媒资的相关信息
         *
         * @param request SearchMediaByFaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchMediaByFaceResponse
         */
        public SearchMediaByFaceResponse SearchMediaByFaceWithOptions(SearchMediaByFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceSearchToken))
            {
                query["FaceSearchToken"] = request.FaceSearchToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonImageUrl))
            {
                query["PersonImageUrl"] = request.PersonImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMediaByFace",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMediaByFaceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 人脸搜粗搜接口，输入一张人脸图片，搜索该人物所在媒资的相关信息
         *
         * @param request SearchMediaByFaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchMediaByFaceResponse
         */
        public async Task<SearchMediaByFaceResponse> SearchMediaByFaceWithOptionsAsync(SearchMediaByFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceSearchToken))
            {
                query["FaceSearchToken"] = request.FaceSearchToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonImageUrl))
            {
                query["PersonImageUrl"] = request.PersonImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMediaByFace",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMediaByFaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 人脸搜粗搜接口，输入一张人脸图片，搜索该人物所在媒资的相关信息
         *
         * @param request SearchMediaByFaceRequest
         * @return SearchMediaByFaceResponse
         */
        public SearchMediaByFaceResponse SearchMediaByFace(SearchMediaByFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchMediaByFaceWithOptions(request, runtime);
        }

        /**
         * @summary 人脸搜粗搜接口，输入一张人脸图片，搜索该人物所在媒资的相关信息
         *
         * @param request SearchMediaByFaceRequest
         * @return SearchMediaByFaceResponse
         */
        public async Task<SearchMediaByFaceResponse> SearchMediaByFaceAsync(SearchMediaByFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchMediaByFaceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 多模态搜索
         *
         * @param request SearchMediaByMultimodalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchMediaByMultimodalResponse
         */
        public SearchMediaByMultimodalResponse SearchMediaByMultimodalWithOptions(SearchMediaByMultimodalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMediaByMultimodal",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMediaByMultimodalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 多模态搜索
         *
         * @param request SearchMediaByMultimodalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchMediaByMultimodalResponse
         */
        public async Task<SearchMediaByMultimodalResponse> SearchMediaByMultimodalWithOptionsAsync(SearchMediaByMultimodalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMediaByMultimodal",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMediaByMultimodalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 多模态搜索
         *
         * @param request SearchMediaByMultimodalRequest
         * @return SearchMediaByMultimodalResponse
         */
        public SearchMediaByMultimodalResponse SearchMediaByMultimodal(SearchMediaByMultimodalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchMediaByMultimodalWithOptions(request, runtime);
        }

        /**
         * @summary 多模态搜索
         *
         * @param request SearchMediaByMultimodalRequest
         * @return SearchMediaByMultimodalResponse
         */
        public async Task<SearchMediaByMultimodalResponse> SearchMediaByMultimodalAsync(SearchMediaByMultimodalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchMediaByMultimodalWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 人脸搜精搜接口，基于粗搜结果返回该人物所在媒资的相关人物片段信息
         *
         * @param request SearchMediaClipByFaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchMediaClipByFaceResponse
         */
        public SearchMediaClipByFaceResponse SearchMediaClipByFaceWithOptions(SearchMediaClipByFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceSearchToken))
            {
                query["FaceSearchToken"] = request.FaceSearchToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMediaClipByFace",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMediaClipByFaceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 人脸搜精搜接口，基于粗搜结果返回该人物所在媒资的相关人物片段信息
         *
         * @param request SearchMediaClipByFaceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchMediaClipByFaceResponse
         */
        public async Task<SearchMediaClipByFaceResponse> SearchMediaClipByFaceWithOptionsAsync(SearchMediaClipByFaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceSearchToken))
            {
                query["FaceSearchToken"] = request.FaceSearchToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMediaClipByFace",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMediaClipByFaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 人脸搜精搜接口，基于粗搜结果返回该人物所在媒资的相关人物片段信息
         *
         * @param request SearchMediaClipByFaceRequest
         * @return SearchMediaClipByFaceResponse
         */
        public SearchMediaClipByFaceResponse SearchMediaClipByFace(SearchMediaClipByFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchMediaClipByFaceWithOptions(request, runtime);
        }

        /**
         * @summary 人脸搜精搜接口，基于粗搜结果返回该人物所在媒资的相关人物片段信息
         *
         * @param request SearchMediaClipByFaceRequest
         * @return SearchMediaClipByFaceResponse
         */
        public async Task<SearchMediaClipByFaceResponse> SearchMediaClipByFaceAsync(SearchMediaClipByFaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchMediaClipByFaceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 搜索公共媒资信息
         *
         * @param request SearchPublicMediaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchPublicMediaInfoResponse
         */
        public SearchPublicMediaInfoResponse SearchPublicMediaInfoWithOptions(SearchPublicMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorized))
            {
                query["Authorized"] = request.Authorized;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicMetaDataMatchFields))
            {
                query["DynamicMetaDataMatchFields"] = request.DynamicMetaDataMatchFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Favorite))
            {
                query["Favorite"] = request.Favorite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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

        /**
         * @summary 搜索公共媒资信息
         *
         * @param request SearchPublicMediaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchPublicMediaInfoResponse
         */
        public async Task<SearchPublicMediaInfoResponse> SearchPublicMediaInfoWithOptionsAsync(SearchPublicMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authorized))
            {
                query["Authorized"] = request.Authorized;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicMetaDataMatchFields))
            {
                query["DynamicMetaDataMatchFields"] = request.DynamicMetaDataMatchFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Favorite))
            {
                query["Favorite"] = request.Favorite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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

        /**
         * @summary 搜索公共媒资信息
         *
         * @param request SearchPublicMediaInfoRequest
         * @return SearchPublicMediaInfoResponse
         */
        public SearchPublicMediaInfoResponse SearchPublicMediaInfo(SearchPublicMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchPublicMediaInfoWithOptions(request, runtime);
        }

        /**
         * @summary 搜索公共媒资信息
         *
         * @param request SearchPublicMediaInfoRequest
         * @return SearchPublicMediaInfoResponse
         */
        public async Task<SearchPublicMediaInfoResponse> SearchPublicMediaInfoAsync(SearchPublicMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchPublicMediaInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 发送实时截图任务指令
         *
         * @param request SendLiveSnapshotJobCommandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendLiveSnapshotJobCommandResponse
         */
        public SendLiveSnapshotJobCommandResponse SendLiveSnapshotJobCommandWithOptions(SendLiveSnapshotJobCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                body["Command"] = request.Command;
            }
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
                Action = "SendLiveSnapshotJobCommand",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendLiveSnapshotJobCommandResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 发送实时截图任务指令
         *
         * @param request SendLiveSnapshotJobCommandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendLiveSnapshotJobCommandResponse
         */
        public async Task<SendLiveSnapshotJobCommandResponse> SendLiveSnapshotJobCommandWithOptionsAsync(SendLiveSnapshotJobCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                body["Command"] = request.Command;
            }
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
                Action = "SendLiveSnapshotJobCommand",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendLiveSnapshotJobCommandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 发送实时截图任务指令
         *
         * @param request SendLiveSnapshotJobCommandRequest
         * @return SendLiveSnapshotJobCommandResponse
         */
        public SendLiveSnapshotJobCommandResponse SendLiveSnapshotJobCommand(SendLiveSnapshotJobCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendLiveSnapshotJobCommandWithOptions(request, runtime);
        }

        /**
         * @summary 发送实时截图任务指令
         *
         * @param request SendLiveSnapshotJobCommandRequest
         * @return SendLiveSnapshotJobCommandResponse
         */
        public async Task<SendLiveSnapshotJobCommandResponse> SendLiveSnapshotJobCommandAsync(SendLiveSnapshotJobCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendLiveSnapshotJobCommandWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 给指定转码任务发实时命令
         *
         * @param request SendLiveTranscodeJobCommandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendLiveTranscodeJobCommandResponse
         */
        public SendLiveTranscodeJobCommandResponse SendLiveTranscodeJobCommandWithOptions(SendLiveTranscodeJobCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
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
                Action = "SendLiveTranscodeJobCommand",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendLiveTranscodeJobCommandResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 给指定转码任务发实时命令
         *
         * @param request SendLiveTranscodeJobCommandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendLiveTranscodeJobCommandResponse
         */
        public async Task<SendLiveTranscodeJobCommandResponse> SendLiveTranscodeJobCommandWithOptionsAsync(SendLiveTranscodeJobCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
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
                Action = "SendLiveTranscodeJobCommand",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendLiveTranscodeJobCommandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 给指定转码任务发实时命令
         *
         * @param request SendLiveTranscodeJobCommandRequest
         * @return SendLiveTranscodeJobCommandResponse
         */
        public SendLiveTranscodeJobCommandResponse SendLiveTranscodeJobCommand(SendLiveTranscodeJobCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendLiveTranscodeJobCommandWithOptions(request, runtime);
        }

        /**
         * @summary 给指定转码任务发实时命令
         *
         * @param request SendLiveTranscodeJobCommandRequest
         * @return SendLiveTranscodeJobCommandResponse
         */
        public async Task<SendLiveTranscodeJobCommandResponse> SendLiveTranscodeJobCommandAsync(SendLiveTranscodeJobCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendLiveTranscodeJobCommandWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设置内容分析搜索配置
         *
         * @param request SetContentAnalyzeConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetContentAnalyzeConfigResponse
         */
        public SetContentAnalyzeConfigResponse SetContentAnalyzeConfigWithOptions(SetContentAnalyzeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Auto))
            {
                query["Auto"] = request.Auto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveType))
            {
                query["SaveType"] = request.SaveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetContentAnalyzeConfig",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetContentAnalyzeConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设置内容分析搜索配置
         *
         * @param request SetContentAnalyzeConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetContentAnalyzeConfigResponse
         */
        public async Task<SetContentAnalyzeConfigResponse> SetContentAnalyzeConfigWithOptionsAsync(SetContentAnalyzeConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Auto))
            {
                query["Auto"] = request.Auto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaveType))
            {
                query["SaveType"] = request.SaveType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetContentAnalyzeConfig",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetContentAnalyzeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设置内容分析搜索配置
         *
         * @param request SetContentAnalyzeConfigRequest
         * @return SetContentAnalyzeConfigResponse
         */
        public SetContentAnalyzeConfigResponse SetContentAnalyzeConfig(SetContentAnalyzeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetContentAnalyzeConfigWithOptions(request, runtime);
        }

        /**
         * @summary 设置内容分析搜索配置
         *
         * @param request SetContentAnalyzeConfigRequest
         * @return SetContentAnalyzeConfigResponse
         */
        public async Task<SetContentAnalyzeConfigResponse> SetContentAnalyzeConfigAsync(SetContentAnalyzeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetContentAnalyzeConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设置默认媒体处理模板
         *
         * @param request SetDefaultCustomTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDefaultCustomTemplateResponse
         */
        public SetDefaultCustomTemplateResponse SetDefaultCustomTemplateWithOptions(SetDefaultCustomTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultCustomTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultCustomTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设置默认媒体处理模板
         *
         * @param request SetDefaultCustomTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDefaultCustomTemplateResponse
         */
        public async Task<SetDefaultCustomTemplateResponse> SetDefaultCustomTemplateWithOptionsAsync(SetDefaultCustomTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultCustomTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultCustomTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设置默认媒体处理模板
         *
         * @param request SetDefaultCustomTemplateRequest
         * @return SetDefaultCustomTemplateResponse
         */
        public SetDefaultCustomTemplateResponse SetDefaultCustomTemplate(SetDefaultCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultCustomTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 设置默认媒体处理模板
         *
         * @param request SetDefaultCustomTemplateRequest
         * @return SetDefaultCustomTemplateResponse
         */
        public async Task<SetDefaultCustomTemplateResponse> SetDefaultCustomTemplateAsync(SetDefaultCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultCustomTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设置默认存储路径
         *
         * @param request SetDefaultStorageLocationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDefaultStorageLocationResponse
         */
        public SetDefaultStorageLocationResponse SetDefaultStorageLocationWithOptions(SetDefaultStorageLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
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

        /**
         * @summary 设置默认存储路径
         *
         * @param request SetDefaultStorageLocationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDefaultStorageLocationResponse
         */
        public async Task<SetDefaultStorageLocationResponse> SetDefaultStorageLocationWithOptionsAsync(SetDefaultStorageLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageType))
            {
                query["StorageType"] = request.StorageType;
            }
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

        /**
         * @summary 设置默认存储路径
         *
         * @param request SetDefaultStorageLocationRequest
         * @return SetDefaultStorageLocationResponse
         */
        public SetDefaultStorageLocationResponse SetDefaultStorageLocation(SetDefaultStorageLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultStorageLocationWithOptions(request, runtime);
        }

        /**
         * @summary 设置默认存储路径
         *
         * @param request SetDefaultStorageLocationRequest
         * @return SetDefaultStorageLocationResponse
         */
        public async Task<SetDefaultStorageLocationResponse> SetDefaultStorageLocationAsync(SetDefaultStorageLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultStorageLocationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 配置事件回调地址
         *
         * @param request SetEventCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetEventCallbackResponse
         */
        public SetEventCallbackResponse SetEventCallbackWithOptions(SetEventCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSwitch))
            {
                query["AuthSwitch"] = request.AuthSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackQueueName))
            {
                query["CallbackQueueName"] = request.CallbackQueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackType))
            {
                query["CallbackType"] = request.CallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackURL))
            {
                query["CallbackURL"] = request.CallbackURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTypeList))
            {
                query["EventTypeList"] = request.EventTypeList;
            }
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

        /**
         * @summary 配置事件回调地址
         *
         * @param request SetEventCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetEventCallbackResponse
         */
        public async Task<SetEventCallbackResponse> SetEventCallbackWithOptionsAsync(SetEventCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSwitch))
            {
                query["AuthSwitch"] = request.AuthSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackQueueName))
            {
                query["CallbackQueueName"] = request.CallbackQueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackType))
            {
                query["CallbackType"] = request.CallbackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackURL))
            {
                query["CallbackURL"] = request.CallbackURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTypeList))
            {
                query["EventTypeList"] = request.EventTypeList;
            }
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

        /**
         * @summary 配置事件回调地址
         *
         * @param request SetEventCallbackRequest
         * @return SetEventCallbackResponse
         */
        public SetEventCallbackResponse SetEventCallback(SetEventCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetEventCallbackWithOptions(request, runtime);
        }

        /**
         * @summary 配置事件回调地址
         *
         * @param request SetEventCallbackRequest
         * @return SetEventCallbackResponse
         */
        public async Task<SetEventCallbackResponse> SetEventCallbackAsync(SetEventCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetEventCallbackWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 启动工作流
         *
         * @param request StartWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartWorkflowResponse
         */
        public StartWorkflowResponse StartWorkflowWithOptions(StartWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskInput))
            {
                query["TaskInput"] = request.TaskInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                query["WorkflowId"] = request.WorkflowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartWorkflow",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartWorkflowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启动工作流
         *
         * @param request StartWorkflowRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartWorkflowResponse
         */
        public async Task<StartWorkflowResponse> StartWorkflowWithOptionsAsync(StartWorkflowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskInput))
            {
                query["TaskInput"] = request.TaskInput;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowId))
            {
                query["WorkflowId"] = request.WorkflowId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartWorkflow",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启动工作流
         *
         * @param request StartWorkflowRequest
         * @return StartWorkflowResponse
         */
        public StartWorkflowResponse StartWorkflow(StartWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartWorkflowWithOptions(request, runtime);
        }

        /**
         * @summary 启动工作流
         *
         * @param request StartWorkflowRequest
         * @return StartWorkflowResponse
         */
        public async Task<StartWorkflowResponse> StartWorkflowAsync(StartWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartWorkflowWithOptionsAsync(request, runtime);
        }

        /**
         * @summary SubmitASRJob
         *
         * @param request SubmitASRJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitASRJobResponse
         */
        public SubmitASRJobResponse SubmitASRJobWithOptions(SubmitASRJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputFile))
            {
                query["InputFile"] = request.InputFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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

        /**
         * @summary SubmitASRJob
         *
         * @param request SubmitASRJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitASRJobResponse
         */
        public async Task<SubmitASRJobResponse> SubmitASRJobWithOptionsAsync(SubmitASRJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputFile))
            {
                query["InputFile"] = request.InputFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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

        /**
         * @summary SubmitASRJob
         *
         * @param request SubmitASRJobRequest
         * @return SubmitASRJobResponse
         */
        public SubmitASRJobResponse SubmitASRJob(SubmitASRJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitASRJobWithOptions(request, runtime);
        }

        /**
         * @summary SubmitASRJob
         *
         * @param request SubmitASRJobRequest
         * @return SubmitASRJobResponse
         */
        public async Task<SubmitASRJobResponse> SubmitASRJobAsync(SubmitASRJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitASRJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary SubmitAudioProduceJob
         *
         * @param request SubmitAudioProduceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitAudioProduceJobResponse
         */
        public SubmitAudioProduceJobResponse SubmitAudioProduceJobWithOptions(SubmitAudioProduceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditingConfig))
            {
                query["EditingConfig"] = request.EditingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputConfig))
            {
                query["InputConfig"] = request.InputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                query["OutputConfig"] = request.OutputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                query["Overwrite"] = request.Overwrite;
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

        /**
         * @summary SubmitAudioProduceJob
         *
         * @param request SubmitAudioProduceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitAudioProduceJobResponse
         */
        public async Task<SubmitAudioProduceJobResponse> SubmitAudioProduceJobWithOptionsAsync(SubmitAudioProduceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditingConfig))
            {
                query["EditingConfig"] = request.EditingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputConfig))
            {
                query["InputConfig"] = request.InputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                query["OutputConfig"] = request.OutputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                query["Overwrite"] = request.Overwrite;
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

        /**
         * @summary SubmitAudioProduceJob
         *
         * @param request SubmitAudioProduceJobRequest
         * @return SubmitAudioProduceJobResponse
         */
        public SubmitAudioProduceJobResponse SubmitAudioProduceJob(SubmitAudioProduceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAudioProduceJobWithOptions(request, runtime);
        }

        /**
         * @summary SubmitAudioProduceJob
         *
         * @param request SubmitAudioProduceJobRequest
         * @return SubmitAudioProduceJobResponse
         */
        public async Task<SubmitAudioProduceJobResponse> SubmitAudioProduceJobAsync(SubmitAudioProduceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAudioProduceJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交数字人训练任务
         *
         * @param request SubmitAvatarTrainingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitAvatarTrainingJobResponse
         */
        public SubmitAvatarTrainingJobResponse SubmitAvatarTrainingJobWithOptions(SubmitAvatarTrainingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SubmitAvatarTrainingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAvatarTrainingJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交数字人训练任务
         *
         * @param request SubmitAvatarTrainingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitAvatarTrainingJobResponse
         */
        public async Task<SubmitAvatarTrainingJobResponse> SubmitAvatarTrainingJobWithOptionsAsync(SubmitAvatarTrainingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SubmitAvatarTrainingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAvatarTrainingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交数字人训练任务
         *
         * @param request SubmitAvatarTrainingJobRequest
         * @return SubmitAvatarTrainingJobResponse
         */
        public SubmitAvatarTrainingJobResponse SubmitAvatarTrainingJob(SubmitAvatarTrainingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAvatarTrainingJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交数字人训练任务
         *
         * @param request SubmitAvatarTrainingJobRequest
         * @return SubmitAvatarTrainingJobResponse
         */
        public async Task<SubmitAvatarTrainingJobResponse> SubmitAvatarTrainingJobAsync(SubmitAvatarTrainingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAvatarTrainingJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交虚拟人视频合成任务
         *
         * @param request SubmitAvatarVideoJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitAvatarVideoJobResponse
         */
        public SubmitAvatarVideoJobResponse SubmitAvatarVideoJobWithOptions(SubmitAvatarVideoJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditingConfig))
            {
                query["EditingConfig"] = request.EditingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputConfig))
            {
                query["InputConfig"] = request.InputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                query["OutputConfig"] = request.OutputConfig;
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
                Action = "SubmitAvatarVideoJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAvatarVideoJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交虚拟人视频合成任务
         *
         * @param request SubmitAvatarVideoJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitAvatarVideoJobResponse
         */
        public async Task<SubmitAvatarVideoJobResponse> SubmitAvatarVideoJobWithOptionsAsync(SubmitAvatarVideoJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditingConfig))
            {
                query["EditingConfig"] = request.EditingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputConfig))
            {
                query["InputConfig"] = request.InputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                query["OutputConfig"] = request.OutputConfig;
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
                Action = "SubmitAvatarVideoJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAvatarVideoJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交虚拟人视频合成任务
         *
         * @param request SubmitAvatarVideoJobRequest
         * @return SubmitAvatarVideoJobResponse
         */
        public SubmitAvatarVideoJobResponse SubmitAvatarVideoJob(SubmitAvatarVideoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAvatarVideoJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交虚拟人视频合成任务
         *
         * @param request SubmitAvatarVideoJobRequest
         * @return SubmitAvatarVideoJobResponse
         */
        public async Task<SubmitAvatarVideoJobResponse> SubmitAvatarVideoJobAsync(SubmitAvatarVideoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAvatarVideoJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary SubmitBatchMediaProducingJob
         *
         * @param request SubmitBatchMediaProducingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitBatchMediaProducingJobResponse
         */
        public SubmitBatchMediaProducingJobResponse SubmitBatchMediaProducingJobWithOptions(SubmitBatchMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                query["OutputConfig"] = request.OutputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditingConfig))
            {
                body["EditingConfig"] = request.EditingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputConfig))
            {
                body["InputConfig"] = request.InputConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitBatchMediaProducingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitBatchMediaProducingJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary SubmitBatchMediaProducingJob
         *
         * @param request SubmitBatchMediaProducingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitBatchMediaProducingJobResponse
         */
        public async Task<SubmitBatchMediaProducingJobResponse> SubmitBatchMediaProducingJobWithOptionsAsync(SubmitBatchMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                query["OutputConfig"] = request.OutputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditingConfig))
            {
                body["EditingConfig"] = request.EditingConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputConfig))
            {
                body["InputConfig"] = request.InputConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitBatchMediaProducingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitBatchMediaProducingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary SubmitBatchMediaProducingJob
         *
         * @param request SubmitBatchMediaProducingJobRequest
         * @return SubmitBatchMediaProducingJobResponse
         */
        public SubmitBatchMediaProducingJobResponse SubmitBatchMediaProducingJob(SubmitBatchMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitBatchMediaProducingJobWithOptions(request, runtime);
        }

        /**
         * @summary SubmitBatchMediaProducingJob
         *
         * @param request SubmitBatchMediaProducingJobRequest
         * @return SubmitBatchMediaProducingJobResponse
         */
        public async Task<SubmitBatchMediaProducingJobResponse> SubmitBatchMediaProducingJobAsync(SubmitBatchMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitBatchMediaProducingJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交人声克隆训练任务
         *
         * @param request SubmitCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitCustomizedVoiceJobResponse
         */
        public SubmitCustomizedVoiceJobResponse SubmitCustomizedVoiceJobWithOptions(SubmitCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DemoAudioMediaURL))
            {
                query["DemoAudioMediaURL"] = request.DemoAudioMediaURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                query["VoiceId"] = request.VoiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitCustomizedVoiceJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交人声克隆训练任务
         *
         * @param request SubmitCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitCustomizedVoiceJobResponse
         */
        public async Task<SubmitCustomizedVoiceJobResponse> SubmitCustomizedVoiceJobWithOptionsAsync(SubmitCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DemoAudioMediaURL))
            {
                query["DemoAudioMediaURL"] = request.DemoAudioMediaURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                query["VoiceId"] = request.VoiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitCustomizedVoiceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交人声克隆训练任务
         *
         * @param request SubmitCustomizedVoiceJobRequest
         * @return SubmitCustomizedVoiceJobResponse
         */
        public SubmitCustomizedVoiceJobResponse SubmitCustomizedVoiceJob(SubmitCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitCustomizedVoiceJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交人声克隆训练任务
         *
         * @param request SubmitCustomizedVoiceJobRequest
         * @return SubmitCustomizedVoiceJobResponse
         */
        public async Task<SubmitCustomizedVoiceJobResponse> SubmitCustomizedVoiceJobAsync(SubmitCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitCustomizedVoiceJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交DNA作业
         *
         * @param tmpReq SubmitDNAJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDNAJobResponse
         */
        public SubmitDNAJobResponse SubmitDNAJobWithOptions(SubmitDNAJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitDNAJobShrinkRequest request = new SubmitDNAJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBId))
            {
                query["DBId"] = request.DBId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                query["PrimaryKey"] = request.PrimaryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "SubmitDNAJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDNAJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交DNA作业
         *
         * @param tmpReq SubmitDNAJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDNAJobResponse
         */
        public async Task<SubmitDNAJobResponse> SubmitDNAJobWithOptionsAsync(SubmitDNAJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitDNAJobShrinkRequest request = new SubmitDNAJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBId))
            {
                query["DBId"] = request.DBId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                query["PrimaryKey"] = request.PrimaryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "SubmitDNAJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDNAJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交DNA作业
         *
         * @param request SubmitDNAJobRequest
         * @return SubmitDNAJobResponse
         */
        public SubmitDNAJobResponse SubmitDNAJob(SubmitDNAJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDNAJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交DNA作业
         *
         * @param request SubmitDNAJobRequest
         * @return SubmitDNAJobResponse
         */
        public async Task<SubmitDNAJobResponse> SubmitDNAJobAsync(SubmitDNAJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDNAJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交动态图表任务
         *
         * @param request SubmitDynamicChartJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDynamicChartJobResponse
         */
        public SubmitDynamicChartJobResponse SubmitDynamicChartJobWithOptions(SubmitDynamicChartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AxisParams))
            {
                query["AxisParams"] = request.AxisParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Background))
            {
                query["Background"] = request.Background;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChartConfig))
            {
                query["ChartConfig"] = request.ChartConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChartTitle))
            {
                query["ChartTitle"] = request.ChartTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChartType))
            {
                query["ChartType"] = request.ChartType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["DataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                query["OutputConfig"] = request.OutputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subtitle))
            {
                query["Subtitle"] = request.Subtitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                query["Unit"] = request.Unit;
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

        /**
         * @summary 提交动态图表任务
         *
         * @param request SubmitDynamicChartJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDynamicChartJobResponse
         */
        public async Task<SubmitDynamicChartJobResponse> SubmitDynamicChartJobWithOptionsAsync(SubmitDynamicChartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AxisParams))
            {
                query["AxisParams"] = request.AxisParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Background))
            {
                query["Background"] = request.Background;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChartConfig))
            {
                query["ChartConfig"] = request.ChartConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChartTitle))
            {
                query["ChartTitle"] = request.ChartTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChartType))
            {
                query["ChartType"] = request.ChartType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["DataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                query["Input"] = request.Input;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                query["OutputConfig"] = request.OutputConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subtitle))
            {
                query["Subtitle"] = request.Subtitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                query["Unit"] = request.Unit;
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

        /**
         * @summary 提交动态图表任务
         *
         * @param request SubmitDynamicChartJobRequest
         * @return SubmitDynamicChartJobResponse
         */
        public SubmitDynamicChartJobResponse SubmitDynamicChartJob(SubmitDynamicChartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDynamicChartJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交动态图表任务
         *
         * @param request SubmitDynamicChartJobRequest
         * @return SubmitDynamicChartJobResponse
         */
        public async Task<SubmitDynamicChartJobResponse> SubmitDynamicChartJobAsync(SubmitDynamicChartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDynamicChartJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交异步动图任务接口
         *
         * @param tmpReq SubmitDynamicImageJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDynamicImageJobResponse
         */
        public SubmitDynamicImageJobResponse SubmitDynamicImageJobWithOptions(SubmitDynamicImageJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitDynamicImageJobShrinkRequest request = new SubmitDynamicImageJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Output))
            {
                request.OutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Output, "Output", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateConfig))
            {
                request.TemplateConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateConfig, "TemplateConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputShrink))
            {
                query["Output"] = request.OutputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfigShrink))
            {
                query["TemplateConfig"] = request.TemplateConfigShrink;
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
                Action = "SubmitDynamicImageJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDynamicImageJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交异步动图任务接口
         *
         * @param tmpReq SubmitDynamicImageJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDynamicImageJobResponse
         */
        public async Task<SubmitDynamicImageJobResponse> SubmitDynamicImageJobWithOptionsAsync(SubmitDynamicImageJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitDynamicImageJobShrinkRequest request = new SubmitDynamicImageJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Output))
            {
                request.OutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Output, "Output", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateConfig))
            {
                request.TemplateConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateConfig, "TemplateConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputShrink))
            {
                query["Output"] = request.OutputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfigShrink))
            {
                query["TemplateConfig"] = request.TemplateConfigShrink;
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
                Action = "SubmitDynamicImageJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDynamicImageJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交异步动图任务接口
         *
         * @param request SubmitDynamicImageJobRequest
         * @return SubmitDynamicImageJobResponse
         */
        public SubmitDynamicImageJobResponse SubmitDynamicImageJob(SubmitDynamicImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDynamicImageJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交异步动图任务接口
         *
         * @param request SubmitDynamicImageJobRequest
         * @return SubmitDynamicImageJobResponse
         */
        public async Task<SubmitDynamicImageJobResponse> SubmitDynamicImageJobAsync(SubmitDynamicImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDynamicImageJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交智能生产作业
         *
         * @param tmpReq SubmitIProductionJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitIProductionJobResponse
         */
        public SubmitIProductionJobResponse SubmitIProductionJobWithOptions(SubmitIProductionJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitIProductionJobShrinkRequest request = new SubmitIProductionJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Output))
            {
                request.OutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Output, "Output", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParams))
            {
                query["JobParams"] = request.JobParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputShrink))
            {
                query["Output"] = request.OutputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "SubmitIProductionJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIProductionJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交智能生产作业
         *
         * @param tmpReq SubmitIProductionJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitIProductionJobResponse
         */
        public async Task<SubmitIProductionJobResponse> SubmitIProductionJobWithOptionsAsync(SubmitIProductionJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitIProductionJobShrinkRequest request = new SubmitIProductionJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Output))
            {
                request.OutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Output, "Output", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionName))
            {
                query["FunctionName"] = request.FunctionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobParams))
            {
                query["JobParams"] = request.JobParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputShrink))
            {
                query["Output"] = request.OutputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "SubmitIProductionJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIProductionJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交智能生产作业
         *
         * @param request SubmitIProductionJobRequest
         * @return SubmitIProductionJobResponse
         */
        public SubmitIProductionJobResponse SubmitIProductionJob(SubmitIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitIProductionJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交智能生产作业
         *
         * @param request SubmitIProductionJobRequest
         * @return SubmitIProductionJobResponse
         */
        public async Task<SubmitIProductionJobResponse> SubmitIProductionJobAsync(SubmitIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitIProductionJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交直播剪辑任务
         *
         * @param request SubmitLiveEditingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitLiveEditingJobResponse
         */
        public SubmitLiveEditingJobResponse SubmitLiveEditingJobWithOptions(SubmitLiveEditingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clips))
            {
                query["Clips"] = request.Clips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveStreamConfig))
            {
                query["LiveStreamConfig"] = request.LiveStreamConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaProduceConfig))
            {
                query["MediaProduceConfig"] = request.MediaProduceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputMediaConfig))
            {
                query["OutputMediaConfig"] = request.OutputMediaConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputMediaTarget))
            {
                query["OutputMediaTarget"] = request.OutputMediaTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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

        /**
         * @summary 提交直播剪辑任务
         *
         * @param request SubmitLiveEditingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitLiveEditingJobResponse
         */
        public async Task<SubmitLiveEditingJobResponse> SubmitLiveEditingJobWithOptionsAsync(SubmitLiveEditingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clips))
            {
                query["Clips"] = request.Clips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LiveStreamConfig))
            {
                query["LiveStreamConfig"] = request.LiveStreamConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaProduceConfig))
            {
                query["MediaProduceConfig"] = request.MediaProduceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputMediaConfig))
            {
                query["OutputMediaConfig"] = request.OutputMediaConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputMediaTarget))
            {
                query["OutputMediaTarget"] = request.OutputMediaTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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

        /**
         * @summary 提交直播剪辑任务
         *
         * @param request SubmitLiveEditingJobRequest
         * @return SubmitLiveEditingJobResponse
         */
        public SubmitLiveEditingJobResponse SubmitLiveEditingJob(SubmitLiveEditingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitLiveEditingJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交直播剪辑任务
         *
         * @param request SubmitLiveEditingJobRequest
         * @return SubmitLiveEditingJobResponse
         */
        public async Task<SubmitLiveEditingJobResponse> SubmitLiveEditingJobAsync(SubmitLiveEditingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitLiveEditingJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交录制任务
         *
         * @param tmpReq SubmitLiveRecordJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitLiveRecordJobResponse
         */
        public SubmitLiveRecordJobResponse SubmitLiveRecordJobWithOptions(SubmitLiveRecordJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitLiveRecordJobShrinkRequest request = new SubmitLiveRecordJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordOutput))
            {
                request.RecordOutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordOutput, "RecordOutput", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamInput))
            {
                request.StreamInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamInput, "StreamInput", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyUrl))
            {
                body["NotifyUrl"] = request.NotifyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordOutputShrink))
            {
                body["RecordOutput"] = request.RecordOutputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamInputShrink))
            {
                body["StreamInput"] = request.StreamInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitLiveRecordJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitLiveRecordJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交录制任务
         *
         * @param tmpReq SubmitLiveRecordJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitLiveRecordJobResponse
         */
        public async Task<SubmitLiveRecordJobResponse> SubmitLiveRecordJobWithOptionsAsync(SubmitLiveRecordJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitLiveRecordJobShrinkRequest request = new SubmitLiveRecordJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordOutput))
            {
                request.RecordOutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordOutput, "RecordOutput", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamInput))
            {
                request.StreamInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamInput, "StreamInput", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyUrl))
            {
                body["NotifyUrl"] = request.NotifyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordOutputShrink))
            {
                body["RecordOutput"] = request.RecordOutputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamInputShrink))
            {
                body["StreamInput"] = request.StreamInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitLiveRecordJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitLiveRecordJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交录制任务
         *
         * @param request SubmitLiveRecordJobRequest
         * @return SubmitLiveRecordJobResponse
         */
        public SubmitLiveRecordJobResponse SubmitLiveRecordJob(SubmitLiveRecordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitLiveRecordJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交录制任务
         *
         * @param request SubmitLiveRecordJobRequest
         * @return SubmitLiveRecordJobResponse
         */
        public async Task<SubmitLiveRecordJobResponse> SubmitLiveRecordJobAsync(SubmitLiveRecordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitLiveRecordJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建直播截图任务
         *
         * @param tmpReq SubmitLiveSnapshotJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitLiveSnapshotJobResponse
         */
        public SubmitLiveSnapshotJobResponse SubmitLiveSnapshotJobWithOptions(SubmitLiveSnapshotJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitLiveSnapshotJobShrinkRequest request = new SubmitLiveSnapshotJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SnapshotOutput))
            {
                request.SnapshotOutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SnapshotOutput, "SnapshotOutput", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamInput))
            {
                request.StreamInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamInput, "StreamInput", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                body["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotOutputShrink))
            {
                body["SnapshotOutput"] = request.SnapshotOutputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamInputShrink))
            {
                body["StreamInput"] = request.StreamInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitLiveSnapshotJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitLiveSnapshotJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建直播截图任务
         *
         * @param tmpReq SubmitLiveSnapshotJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitLiveSnapshotJobResponse
         */
        public async Task<SubmitLiveSnapshotJobResponse> SubmitLiveSnapshotJobWithOptionsAsync(SubmitLiveSnapshotJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitLiveSnapshotJobShrinkRequest request = new SubmitLiveSnapshotJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SnapshotOutput))
            {
                request.SnapshotOutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SnapshotOutput, "SnapshotOutput", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamInput))
            {
                request.StreamInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamInput, "StreamInput", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                body["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotOutputShrink))
            {
                body["SnapshotOutput"] = request.SnapshotOutputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamInputShrink))
            {
                body["StreamInput"] = request.StreamInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitLiveSnapshotJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitLiveSnapshotJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建直播截图任务
         *
         * @param request SubmitLiveSnapshotJobRequest
         * @return SubmitLiveSnapshotJobResponse
         */
        public SubmitLiveSnapshotJobResponse SubmitLiveSnapshotJob(SubmitLiveSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitLiveSnapshotJobWithOptions(request, runtime);
        }

        /**
         * @summary 创建直播截图任务
         *
         * @param request SubmitLiveSnapshotJobRequest
         * @return SubmitLiveSnapshotJobResponse
         */
        public async Task<SubmitLiveSnapshotJobResponse> SubmitLiveSnapshotJobAsync(SubmitLiveSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitLiveSnapshotJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交转码任务
         *
         * @param tmpReq SubmitLiveTranscodeJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitLiveTranscodeJobResponse
         */
        public SubmitLiveTranscodeJobResponse SubmitLiveTranscodeJobWithOptions(SubmitLiveTranscodeJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitLiveTranscodeJobShrinkRequest request = new SubmitLiveTranscodeJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamInput))
            {
                request.StreamInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamInput, "StreamInput", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TimedConfig))
            {
                request.TimedConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TimedConfig, "TimedConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TranscodeOutput))
            {
                request.TranscodeOutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TranscodeOutput, "TranscodeOutput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartMode))
            {
                query["StartMode"] = request.StartMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamInputShrink))
            {
                query["StreamInput"] = request.StreamInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimedConfigShrink))
            {
                query["TimedConfig"] = request.TimedConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeOutputShrink))
            {
                query["TranscodeOutput"] = request.TranscodeOutputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitLiveTranscodeJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitLiveTranscodeJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交转码任务
         *
         * @param tmpReq SubmitLiveTranscodeJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitLiveTranscodeJobResponse
         */
        public async Task<SubmitLiveTranscodeJobResponse> SubmitLiveTranscodeJobWithOptionsAsync(SubmitLiveTranscodeJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitLiveTranscodeJobShrinkRequest request = new SubmitLiveTranscodeJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamInput))
            {
                request.StreamInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamInput, "StreamInput", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TimedConfig))
            {
                request.TimedConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TimedConfig, "TimedConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TranscodeOutput))
            {
                request.TranscodeOutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TranscodeOutput, "TranscodeOutput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartMode))
            {
                query["StartMode"] = request.StartMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamInputShrink))
            {
                query["StreamInput"] = request.StreamInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimedConfigShrink))
            {
                query["TimedConfig"] = request.TimedConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeOutputShrink))
            {
                query["TranscodeOutput"] = request.TranscodeOutputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitLiveTranscodeJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitLiveTranscodeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交转码任务
         *
         * @param request SubmitLiveTranscodeJobRequest
         * @return SubmitLiveTranscodeJobResponse
         */
        public SubmitLiveTranscodeJobResponse SubmitLiveTranscodeJob(SubmitLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitLiveTranscodeJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交转码任务
         *
         * @param request SubmitLiveTranscodeJobRequest
         * @return SubmitLiveTranscodeJobResponse
         */
        public async Task<SubmitLiveTranscodeJobResponse> SubmitLiveTranscodeJobAsync(SubmitLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitLiveTranscodeJobWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq SubmitMediaCensorJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitMediaCensorJobResponse
         */
        public SubmitMediaCensorJobResponse SubmitMediaCensorJobWithOptions(SubmitMediaCensorJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitMediaCensorJobShrinkRequest request = new SubmitMediaCensorJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Barrages))
            {
                query["Barrages"] = request.Barrages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverImages))
            {
                query["CoverImages"] = request.CoverImages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyUrl))
            {
                query["NotifyUrl"] = request.NotifyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                query["Output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "SubmitMediaCensorJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMediaCensorJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq SubmitMediaCensorJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitMediaCensorJobResponse
         */
        public async Task<SubmitMediaCensorJobResponse> SubmitMediaCensorJobWithOptionsAsync(SubmitMediaCensorJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitMediaCensorJobShrinkRequest request = new SubmitMediaCensorJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Barrages))
            {
                query["Barrages"] = request.Barrages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverImages))
            {
                query["CoverImages"] = request.CoverImages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyUrl))
            {
                query["NotifyUrl"] = request.NotifyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Output))
            {
                query["Output"] = request.Output;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "SubmitMediaCensorJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMediaCensorJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SubmitMediaCensorJobRequest
         * @return SubmitMediaCensorJobResponse
         */
        public SubmitMediaCensorJobResponse SubmitMediaCensorJob(SubmitMediaCensorJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaCensorJobWithOptions(request, runtime);
        }

        /**
         * @param request SubmitMediaCensorJobRequest
         * @return SubmitMediaCensorJobResponse
         */
        public async Task<SubmitMediaCensorJobResponse> SubmitMediaCensorJobAsync(SubmitMediaCensorJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaCensorJobWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq SubmitMediaInfoJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitMediaInfoJobResponse
         */
        public SubmitMediaInfoJobResponse SubmitMediaInfoJobWithOptions(SubmitMediaInfoJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitMediaInfoJobShrinkRequest request = new SubmitMediaInfoJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
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
                Action = "SubmitMediaInfoJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMediaInfoJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq SubmitMediaInfoJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitMediaInfoJobResponse
         */
        public async Task<SubmitMediaInfoJobResponse> SubmitMediaInfoJobWithOptionsAsync(SubmitMediaInfoJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitMediaInfoJobShrinkRequest request = new SubmitMediaInfoJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
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
                Action = "SubmitMediaInfoJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMediaInfoJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SubmitMediaInfoJobRequest
         * @return SubmitMediaInfoJobResponse
         */
        public SubmitMediaInfoJobResponse SubmitMediaInfoJob(SubmitMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaInfoJobWithOptions(request, runtime);
        }

        /**
         * @param request SubmitMediaInfoJobRequest
         * @return SubmitMediaInfoJobResponse
         */
        public async Task<SubmitMediaInfoJobResponse> SubmitMediaInfoJobAsync(SubmitMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaInfoJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary SubmitMediaProducingJob
         *
         * @param request SubmitMediaProducingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitMediaProducingJobResponse
         */
        public SubmitMediaProducingJobResponse SubmitMediaProducingJobWithOptions(SubmitMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClipsParam))
            {
                query["ClipsParam"] = request.ClipsParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditingProduceConfig))
            {
                query["EditingProduceConfig"] = request.EditingProduceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMetadata))
            {
                query["MediaMetadata"] = request.MediaMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputMediaConfig))
            {
                query["OutputMediaConfig"] = request.OutputMediaConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputMediaTarget))
            {
                query["OutputMediaTarget"] = request.OutputMediaTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectMetadata))
            {
                query["ProjectMetadata"] = request.ProjectMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                body["Timeline"] = request.Timeline;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /**
         * @summary SubmitMediaProducingJob
         *
         * @param request SubmitMediaProducingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitMediaProducingJobResponse
         */
        public async Task<SubmitMediaProducingJobResponse> SubmitMediaProducingJobWithOptionsAsync(SubmitMediaProducingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClipsParam))
            {
                query["ClipsParam"] = request.ClipsParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EditingProduceConfig))
            {
                query["EditingProduceConfig"] = request.EditingProduceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMetadata))
            {
                query["MediaMetadata"] = request.MediaMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputMediaConfig))
            {
                query["OutputMediaConfig"] = request.OutputMediaConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputMediaTarget))
            {
                query["OutputMediaTarget"] = request.OutputMediaTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectMetadata))
            {
                query["ProjectMetadata"] = request.ProjectMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                body["Timeline"] = request.Timeline;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /**
         * @summary SubmitMediaProducingJob
         *
         * @param request SubmitMediaProducingJobRequest
         * @return SubmitMediaProducingJobResponse
         */
        public SubmitMediaProducingJobResponse SubmitMediaProducingJob(SubmitMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaProducingJobWithOptions(request, runtime);
        }

        /**
         * @summary SubmitMediaProducingJob
         *
         * @param request SubmitMediaProducingJobRequest
         * @return SubmitMediaProducingJobResponse
         */
        public async Task<SubmitMediaProducingJobResponse> SubmitMediaProducingJobAsync(SubmitMediaProducingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaProducingJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交打包任务
         *
         * @param tmpReq SubmitPackageJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitPackageJobResponse
         */
        public SubmitPackageJobResponse SubmitPackageJobWithOptions(SubmitPackageJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitPackageJobShrinkRequest request = new SubmitPackageJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Inputs))
            {
                request.InputsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Inputs, "Inputs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Output))
            {
                request.OutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Output, "Output", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputsShrink))
            {
                query["Inputs"] = request.InputsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputShrink))
            {
                query["Output"] = request.OutputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
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
                Action = "SubmitPackageJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitPackageJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交打包任务
         *
         * @param tmpReq SubmitPackageJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitPackageJobResponse
         */
        public async Task<SubmitPackageJobResponse> SubmitPackageJobWithOptionsAsync(SubmitPackageJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitPackageJobShrinkRequest request = new SubmitPackageJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Inputs))
            {
                request.InputsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Inputs, "Inputs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Output))
            {
                request.OutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Output, "Output", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputsShrink))
            {
                query["Inputs"] = request.InputsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputShrink))
            {
                query["Output"] = request.OutputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
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
                Action = "SubmitPackageJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitPackageJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交打包任务
         *
         * @param request SubmitPackageJobRequest
         * @return SubmitPackageJobResponse
         */
        public SubmitPackageJobResponse SubmitPackageJob(SubmitPackageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitPackageJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交打包任务
         *
         * @param request SubmitPackageJobRequest
         * @return SubmitPackageJobResponse
         */
        public async Task<SubmitPackageJobResponse> SubmitPackageJobAsync(SubmitPackageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitPackageJobWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq SubmitSmarttagJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitSmarttagJobResponse
         */
        public SubmitSmarttagJobResponse SubmitSmarttagJobWithOptions(SubmitSmarttagJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSmarttagJobShrinkRequest request = new SubmitSmarttagJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentAddr))
            {
                query["ContentAddr"] = request.ContentAddr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["ContentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyUrl))
            {
                query["NotifyUrl"] = request.NotifyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "SubmitSmarttagJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSmarttagJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq SubmitSmarttagJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitSmarttagJobResponse
         */
        public async Task<SubmitSmarttagJobResponse> SubmitSmarttagJobWithOptionsAsync(SubmitSmarttagJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSmarttagJobShrinkRequest request = new SubmitSmarttagJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentAddr))
            {
                query["ContentAddr"] = request.ContentAddr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["ContentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyUrl))
            {
                query["NotifyUrl"] = request.NotifyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "SubmitSmarttagJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSmarttagJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SubmitSmarttagJobRequest
         * @return SubmitSmarttagJobResponse
         */
        public SubmitSmarttagJobResponse SubmitSmarttagJob(SubmitSmarttagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSmarttagJobWithOptions(request, runtime);
        }

        /**
         * @param request SubmitSmarttagJobRequest
         * @return SubmitSmarttagJobResponse
         */
        public async Task<SubmitSmarttagJobResponse> SubmitSmarttagJobAsync(SubmitSmarttagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSmarttagJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交异步截图任务
         *
         * @param tmpReq SubmitSnapshotJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitSnapshotJobResponse
         */
        public SubmitSnapshotJobResponse SubmitSnapshotJobWithOptions(SubmitSnapshotJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSnapshotJobShrinkRequest request = new SubmitSnapshotJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Output))
            {
                request.OutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Output, "Output", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateConfig))
            {
                request.TemplateConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateConfig, "TemplateConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputShrink))
            {
                query["Output"] = request.OutputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfigShrink))
            {
                query["TemplateConfig"] = request.TemplateConfigShrink;
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
                Action = "SubmitSnapshotJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSnapshotJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交异步截图任务
         *
         * @param tmpReq SubmitSnapshotJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitSnapshotJobResponse
         */
        public async Task<SubmitSnapshotJobResponse> SubmitSnapshotJobWithOptionsAsync(SubmitSnapshotJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSnapshotJobShrinkRequest request = new SubmitSnapshotJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Output))
            {
                request.OutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Output, "Output", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateConfig))
            {
                request.TemplateConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateConfig, "TemplateConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputShrink))
            {
                query["Output"] = request.OutputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfigShrink))
            {
                query["TemplateConfig"] = request.TemplateConfigShrink;
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
                Action = "SubmitSnapshotJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSnapshotJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交异步截图任务
         *
         * @param request SubmitSnapshotJobRequest
         * @return SubmitSnapshotJobResponse
         */
        public SubmitSnapshotJobResponse SubmitSnapshotJob(SubmitSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSnapshotJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交异步截图任务
         *
         * @param request SubmitSnapshotJobRequest
         * @return SubmitSnapshotJobResponse
         */
        public async Task<SubmitSnapshotJobResponse> SubmitSnapshotJobAsync(SubmitSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSnapshotJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交标准版人声克隆训练任务
         *
         * @param request SubmitStandardCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitStandardCustomizedVoiceJobResponse
         */
        public SubmitStandardCustomizedVoiceJobResponse SubmitStandardCustomizedVoiceJobWithOptions(SubmitStandardCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Audios))
            {
                query["Audios"] = request.Audios;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authentication))
            {
                query["Authentication"] = request.Authentication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DemoAudioMediaURL))
            {
                query["DemoAudioMediaURL"] = request.DemoAudioMediaURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                query["Gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceName))
            {
                query["VoiceName"] = request.VoiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitStandardCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitStandardCustomizedVoiceJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交标准版人声克隆训练任务
         *
         * @param request SubmitStandardCustomizedVoiceJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitStandardCustomizedVoiceJobResponse
         */
        public async Task<SubmitStandardCustomizedVoiceJobResponse> SubmitStandardCustomizedVoiceJobWithOptionsAsync(SubmitStandardCustomizedVoiceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Audios))
            {
                query["Audios"] = request.Audios;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Authentication))
            {
                query["Authentication"] = request.Authentication;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DemoAudioMediaURL))
            {
                query["DemoAudioMediaURL"] = request.DemoAudioMediaURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                query["Gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceName))
            {
                query["VoiceName"] = request.VoiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitStandardCustomizedVoiceJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitStandardCustomizedVoiceJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交标准版人声克隆训练任务
         *
         * @param request SubmitStandardCustomizedVoiceJobRequest
         * @return SubmitStandardCustomizedVoiceJobResponse
         */
        public SubmitStandardCustomizedVoiceJobResponse SubmitStandardCustomizedVoiceJob(SubmitStandardCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitStandardCustomizedVoiceJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交标准版人声克隆训练任务
         *
         * @param request SubmitStandardCustomizedVoiceJobRequest
         * @return SubmitStandardCustomizedVoiceJobResponse
         */
        public async Task<SubmitStandardCustomizedVoiceJobResponse> SubmitStandardCustomizedVoiceJobAsync(SubmitStandardCustomizedVoiceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitStandardCustomizedVoiceJobWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq SubmitSyncMediaInfoJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitSyncMediaInfoJobResponse
         */
        public SubmitSyncMediaInfoJobResponse SubmitSyncMediaInfoJobWithOptions(SubmitSyncMediaInfoJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSyncMediaInfoJobShrinkRequest request = new SubmitSyncMediaInfoJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
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
                Action = "SubmitSyncMediaInfoJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSyncMediaInfoJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq SubmitSyncMediaInfoJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitSyncMediaInfoJobResponse
         */
        public async Task<SubmitSyncMediaInfoJobResponse> SubmitSyncMediaInfoJobWithOptionsAsync(SubmitSyncMediaInfoJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitSyncMediaInfoJobShrinkRequest request = new SubmitSyncMediaInfoJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
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
                Action = "SubmitSyncMediaInfoJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSyncMediaInfoJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SubmitSyncMediaInfoJobRequest
         * @return SubmitSyncMediaInfoJobResponse
         */
        public SubmitSyncMediaInfoJobResponse SubmitSyncMediaInfoJob(SubmitSyncMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSyncMediaInfoJobWithOptions(request, runtime);
        }

        /**
         * @param request SubmitSyncMediaInfoJobRequest
         * @return SubmitSyncMediaInfoJobResponse
         */
        public async Task<SubmitSyncMediaInfoJobResponse> SubmitSyncMediaInfoJobAsync(SubmitSyncMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSyncMediaInfoJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交文本生成任务
         *
         * @param request SubmitTextGenerateJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitTextGenerateJobResponse
         */
        public SubmitTextGenerateJobResponse SubmitTextGenerateJobWithOptions(SubmitTextGenerateJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateConfig))
            {
                query["GenerateConfig"] = request.GenerateConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Action = "SubmitTextGenerateJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTextGenerateJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交文本生成任务
         *
         * @param request SubmitTextGenerateJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitTextGenerateJobResponse
         */
        public async Task<SubmitTextGenerateJobResponse> SubmitTextGenerateJobWithOptionsAsync(SubmitTextGenerateJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateConfig))
            {
                query["GenerateConfig"] = request.GenerateConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
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
                Action = "SubmitTextGenerateJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTextGenerateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交文本生成任务
         *
         * @param request SubmitTextGenerateJobRequest
         * @return SubmitTextGenerateJobResponse
         */
        public SubmitTextGenerateJobResponse SubmitTextGenerateJob(SubmitTextGenerateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTextGenerateJobWithOptions(request, runtime);
        }

        /**
         * @summary 提交文本生成任务
         *
         * @param request SubmitTextGenerateJobRequest
         * @return SubmitTextGenerateJobResponse
         */
        public async Task<SubmitTextGenerateJobResponse> SubmitTextGenerateJobAsync(SubmitTextGenerateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitTextGenerateJobWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq SubmitTranscodeJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitTranscodeJobResponse
         */
        public SubmitTranscodeJobResponse SubmitTranscodeJobWithOptions(SubmitTranscodeJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitTranscodeJobShrinkRequest request = new SubmitTranscodeJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputGroup))
            {
                request.InputGroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputGroup, "InputGroup", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutputGroup))
            {
                request.OutputGroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutputGroup, "OutputGroup", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputGroupShrink))
            {
                query["InputGroup"] = request.InputGroupShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputGroupShrink))
            {
                query["OutputGroup"] = request.OutputGroupShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
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
                Action = "SubmitTranscodeJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTranscodeJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq SubmitTranscodeJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitTranscodeJobResponse
         */
        public async Task<SubmitTranscodeJobResponse> SubmitTranscodeJobWithOptionsAsync(SubmitTranscodeJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitTranscodeJobShrinkRequest request = new SubmitTranscodeJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputGroup))
            {
                request.InputGroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputGroup, "InputGroup", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutputGroup))
            {
                request.OutputGroupShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutputGroup, "OutputGroup", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ScheduleConfig))
            {
                request.ScheduleConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ScheduleConfig, "ScheduleConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputGroupShrink))
            {
                query["InputGroup"] = request.InputGroupShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputGroupShrink))
            {
                query["OutputGroup"] = request.OutputGroupShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleConfigShrink))
            {
                query["ScheduleConfig"] = request.ScheduleConfigShrink;
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
                Action = "SubmitTranscodeJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTranscodeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SubmitTranscodeJobRequest
         * @return SubmitTranscodeJobResponse
         */
        public SubmitTranscodeJobResponse SubmitTranscodeJob(SubmitTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTranscodeJobWithOptions(request, runtime);
        }

        /**
         * @param request SubmitTranscodeJobRequest
         * @return SubmitTranscodeJobResponse
         */
        public async Task<SubmitTranscodeJobResponse> SubmitTranscodeJobAsync(SubmitTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitTranscodeJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新数字人训练任务信息
         *
         * @param request UpdateAvatarTrainingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAvatarTrainingJobResponse
         */
        public UpdateAvatarTrainingJobResponse UpdateAvatarTrainingJobWithOptions(UpdateAvatarTrainingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarDescription))
            {
                query["AvatarDescription"] = request.AvatarDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarName))
            {
                query["AvatarName"] = request.AvatarName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Portrait))
            {
                query["Portrait"] = request.Portrait;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Thumbnail))
            {
                query["Thumbnail"] = request.Thumbnail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transparent))
            {
                query["Transparent"] = request.Transparent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Video))
            {
                query["Video"] = request.Video;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAvatarTrainingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAvatarTrainingJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新数字人训练任务信息
         *
         * @param request UpdateAvatarTrainingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAvatarTrainingJobResponse
         */
        public async Task<UpdateAvatarTrainingJobResponse> UpdateAvatarTrainingJobWithOptionsAsync(UpdateAvatarTrainingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarDescription))
            {
                query["AvatarDescription"] = request.AvatarDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarName))
            {
                query["AvatarName"] = request.AvatarName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Portrait))
            {
                query["Portrait"] = request.Portrait;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Thumbnail))
            {
                query["Thumbnail"] = request.Thumbnail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transparent))
            {
                query["Transparent"] = request.Transparent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Video))
            {
                query["Video"] = request.Video;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAvatarTrainingJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAvatarTrainingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新数字人训练任务信息
         *
         * @param request UpdateAvatarTrainingJobRequest
         * @return UpdateAvatarTrainingJobResponse
         */
        public UpdateAvatarTrainingJobResponse UpdateAvatarTrainingJob(UpdateAvatarTrainingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAvatarTrainingJobWithOptions(request, runtime);
        }

        /**
         * @summary 更新数字人训练任务信息
         *
         * @param request UpdateAvatarTrainingJobRequest
         * @return UpdateAvatarTrainingJobResponse
         */
        public async Task<UpdateAvatarTrainingJobResponse> UpdateAvatarTrainingJobAsync(UpdateAvatarTrainingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAvatarTrainingJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新媒资分类
         *
         * @param request UpdateCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCategoryResponse
         */
        public UpdateCategoryResponse UpdateCategoryWithOptions(UpdateCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateName))
            {
                query["CateName"] = request.CateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCategory",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCategoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新媒资分类
         *
         * @param request UpdateCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCategoryResponse
         */
        public async Task<UpdateCategoryResponse> UpdateCategoryWithOptionsAsync(UpdateCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateName))
            {
                query["CateName"] = request.CateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCategory",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新媒资分类
         *
         * @param request UpdateCategoryRequest
         * @return UpdateCategoryResponse
         */
        public UpdateCategoryResponse UpdateCategory(UpdateCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCategoryWithOptions(request, runtime);
        }

        /**
         * @summary 更新媒资分类
         *
         * @param request UpdateCategoryRequest
         * @return UpdateCategoryResponse
         */
        public async Task<UpdateCategoryResponse> UpdateCategoryAsync(UpdateCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCategoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新媒体处理自定义模板
         *
         * @param request UpdateCustomTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomTemplateResponse
         */
        public UpdateCustomTemplateResponse UpdateCustomTemplateWithOptions(UpdateCustomTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                query["TemplateConfig"] = request.TemplateConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新媒体处理自定义模板
         *
         * @param request UpdateCustomTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomTemplateResponse
         */
        public async Task<UpdateCustomTemplateResponse> UpdateCustomTemplateWithOptionsAsync(UpdateCustomTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                query["TemplateConfig"] = request.TemplateConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新媒体处理自定义模板
         *
         * @param request UpdateCustomTemplateRequest
         * @return UpdateCustomTemplateResponse
         */
        public UpdateCustomTemplateResponse UpdateCustomTemplate(UpdateCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 更新媒体处理自定义模板
         *
         * @param request UpdateCustomTemplateRequest
         * @return UpdateCustomTemplateResponse
         */
        public async Task<UpdateCustomTemplateResponse> UpdateCustomTemplateAsync(UpdateCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新用户的专属人声
         *
         * @param request UpdateCustomizedVoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomizedVoiceResponse
         */
        public UpdateCustomizedVoiceResponse UpdateCustomizedVoiceWithOptions(UpdateCustomizedVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DemoAudioMediaId))
            {
                query["DemoAudioMediaId"] = request.DemoAudioMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                query["VoiceId"] = request.VoiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomizedVoice",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomizedVoiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新用户的专属人声
         *
         * @param request UpdateCustomizedVoiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomizedVoiceResponse
         */
        public async Task<UpdateCustomizedVoiceResponse> UpdateCustomizedVoiceWithOptionsAsync(UpdateCustomizedVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DemoAudioMediaId))
            {
                query["DemoAudioMediaId"] = request.DemoAudioMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceId))
            {
                query["VoiceId"] = request.VoiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomizedVoice",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomizedVoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新用户的专属人声
         *
         * @param request UpdateCustomizedVoiceRequest
         * @return UpdateCustomizedVoiceResponse
         */
        public UpdateCustomizedVoiceResponse UpdateCustomizedVoice(UpdateCustomizedVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomizedVoiceWithOptions(request, runtime);
        }

        /**
         * @summary 更新用户的专属人声
         *
         * @param request UpdateCustomizedVoiceRequest
         * @return UpdateCustomizedVoiceResponse
         */
        public async Task<UpdateCustomizedVoiceResponse> UpdateCustomizedVoiceAsync(UpdateCustomizedVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomizedVoiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改云剪辑工程
         *
         * @param request UpdateEditingProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEditingProjectResponse
         */
        public UpdateEditingProjectResponse UpdateEditingProjectWithOptions(UpdateEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessStatus))
            {
                query["BusinessStatus"] = request.BusinessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClipsParam))
            {
                query["ClipsParam"] = request.ClipsParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                body["Timeline"] = request.Timeline;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /**
         * @summary 修改云剪辑工程
         *
         * @param request UpdateEditingProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateEditingProjectResponse
         */
        public async Task<UpdateEditingProjectResponse> UpdateEditingProjectWithOptionsAsync(UpdateEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessStatus))
            {
                query["BusinessStatus"] = request.BusinessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClipsParam))
            {
                query["ClipsParam"] = request.ClipsParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                body["Timeline"] = request.Timeline;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /**
         * @summary 修改云剪辑工程
         *
         * @param request UpdateEditingProjectRequest
         * @return UpdateEditingProjectResponse
         */
        public UpdateEditingProjectResponse UpdateEditingProject(UpdateEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEditingProjectWithOptions(request, runtime);
        }

        /**
         * @summary 修改云剪辑工程
         *
         * @param request UpdateEditingProjectRequest
         * @return UpdateEditingProjectResponse
         */
        public async Task<UpdateEditingProjectResponse> UpdateEditingProjectAsync(UpdateEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEditingProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改直播录制模板
         *
         * @param tmpReq UpdateLiveRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLiveRecordTemplateResponse
         */
        public UpdateLiveRecordTemplateResponse UpdateLiveRecordTemplateWithOptions(UpdateLiveRecordTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateLiveRecordTemplateShrinkRequest request = new UpdateLiveRecordTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordFormat))
            {
                request.RecordFormatShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordFormat, "RecordFormat", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFormatShrink))
            {
                body["RecordFormat"] = request.RecordFormatShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLiveRecordTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveRecordTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改直播录制模板
         *
         * @param tmpReq UpdateLiveRecordTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLiveRecordTemplateResponse
         */
        public async Task<UpdateLiveRecordTemplateResponse> UpdateLiveRecordTemplateWithOptionsAsync(UpdateLiveRecordTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateLiveRecordTemplateShrinkRequest request = new UpdateLiveRecordTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RecordFormat))
            {
                request.RecordFormatShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RecordFormat, "RecordFormat", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFormatShrink))
            {
                body["RecordFormat"] = request.RecordFormatShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLiveRecordTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveRecordTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改直播录制模板
         *
         * @param request UpdateLiveRecordTemplateRequest
         * @return UpdateLiveRecordTemplateResponse
         */
        public UpdateLiveRecordTemplateResponse UpdateLiveRecordTemplate(UpdateLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveRecordTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 修改直播录制模板
         *
         * @param request UpdateLiveRecordTemplateRequest
         * @return UpdateLiveRecordTemplateResponse
         */
        public async Task<UpdateLiveRecordTemplateResponse> UpdateLiveRecordTemplateAsync(UpdateLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveRecordTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新直播截图模板
         *
         * @param request UpdateLiveSnapshotTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLiveSnapshotTemplateResponse
         */
        public UpdateLiveSnapshotTemplateResponse UpdateLiveSnapshotTemplateWithOptions(UpdateLiveSnapshotTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverwriteFormat))
            {
                body["OverwriteFormat"] = request.OverwriteFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceFormat))
            {
                body["SequenceFormat"] = request.SequenceFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeInterval))
            {
                body["TimeInterval"] = request.TimeInterval;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLiveSnapshotTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveSnapshotTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新直播截图模板
         *
         * @param request UpdateLiveSnapshotTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLiveSnapshotTemplateResponse
         */
        public async Task<UpdateLiveSnapshotTemplateResponse> UpdateLiveSnapshotTemplateWithOptionsAsync(UpdateLiveSnapshotTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverwriteFormat))
            {
                body["OverwriteFormat"] = request.OverwriteFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SequenceFormat))
            {
                body["SequenceFormat"] = request.SequenceFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeInterval))
            {
                body["TimeInterval"] = request.TimeInterval;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLiveSnapshotTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveSnapshotTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新直播截图模板
         *
         * @param request UpdateLiveSnapshotTemplateRequest
         * @return UpdateLiveSnapshotTemplateResponse
         */
        public UpdateLiveSnapshotTemplateResponse UpdateLiveSnapshotTemplate(UpdateLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveSnapshotTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 更新直播截图模板
         *
         * @param request UpdateLiveSnapshotTemplateRequest
         * @return UpdateLiveSnapshotTemplateResponse
         */
        public async Task<UpdateLiveSnapshotTemplateResponse> UpdateLiveSnapshotTemplateAsync(UpdateLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveSnapshotTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新转码任务配置
         *
         * @param tmpReq UpdateLiveTranscodeJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLiveTranscodeJobResponse
         */
        public UpdateLiveTranscodeJobResponse UpdateLiveTranscodeJobWithOptions(UpdateLiveTranscodeJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateLiveTranscodeJobShrinkRequest request = new UpdateLiveTranscodeJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamInput))
            {
                request.StreamInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamInput, "StreamInput", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TimedConfig))
            {
                request.TimedConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TimedConfig, "TimedConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TranscodeOutput))
            {
                request.TranscodeOutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TranscodeOutput, "TranscodeOutput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamInputShrink))
            {
                query["StreamInput"] = request.StreamInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimedConfigShrink))
            {
                query["TimedConfig"] = request.TimedConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeOutputShrink))
            {
                query["TranscodeOutput"] = request.TranscodeOutputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLiveTranscodeJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveTranscodeJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新转码任务配置
         *
         * @param tmpReq UpdateLiveTranscodeJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLiveTranscodeJobResponse
         */
        public async Task<UpdateLiveTranscodeJobResponse> UpdateLiveTranscodeJobWithOptionsAsync(UpdateLiveTranscodeJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateLiveTranscodeJobShrinkRequest request = new UpdateLiveTranscodeJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StreamInput))
            {
                request.StreamInputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StreamInput, "StreamInput", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TimedConfig))
            {
                request.TimedConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TimedConfig, "TimedConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TranscodeOutput))
            {
                request.TranscodeOutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TranscodeOutput, "TranscodeOutput", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamInputShrink))
            {
                query["StreamInput"] = request.StreamInputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimedConfigShrink))
            {
                query["TimedConfig"] = request.TimedConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeOutputShrink))
            {
                query["TranscodeOutput"] = request.TranscodeOutputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLiveTranscodeJob",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveTranscodeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新转码任务配置
         *
         * @param request UpdateLiveTranscodeJobRequest
         * @return UpdateLiveTranscodeJobResponse
         */
        public UpdateLiveTranscodeJobResponse UpdateLiveTranscodeJob(UpdateLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveTranscodeJobWithOptions(request, runtime);
        }

        /**
         * @summary 更新转码任务配置
         *
         * @param request UpdateLiveTranscodeJobRequest
         * @return UpdateLiveTranscodeJobResponse
         */
        public async Task<UpdateLiveTranscodeJobResponse> UpdateLiveTranscodeJobAsync(UpdateLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveTranscodeJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新转码模版
         *
         * @param tmpReq UpdateLiveTranscodeTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLiveTranscodeTemplateResponse
         */
        public UpdateLiveTranscodeTemplateResponse UpdateLiveTranscodeTemplateWithOptions(UpdateLiveTranscodeTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateLiveTranscodeTemplateShrinkRequest request = new UpdateLiveTranscodeTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateConfig))
            {
                request.TemplateConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateConfig, "TemplateConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfigShrink))
            {
                query["TemplateConfig"] = request.TemplateConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLiveTranscodeTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveTranscodeTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新转码模版
         *
         * @param tmpReq UpdateLiveTranscodeTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLiveTranscodeTemplateResponse
         */
        public async Task<UpdateLiveTranscodeTemplateResponse> UpdateLiveTranscodeTemplateWithOptionsAsync(UpdateLiveTranscodeTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateLiveTranscodeTemplateShrinkRequest request = new UpdateLiveTranscodeTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TemplateConfig))
            {
                request.TemplateConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TemplateConfig, "TemplateConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfigShrink))
            {
                query["TemplateConfig"] = request.TemplateConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLiveTranscodeTemplate",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLiveTranscodeTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新转码模版
         *
         * @param request UpdateLiveTranscodeTemplateRequest
         * @return UpdateLiveTranscodeTemplateResponse
         */
        public UpdateLiveTranscodeTemplateResponse UpdateLiveTranscodeTemplate(UpdateLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveTranscodeTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 更新转码模版
         *
         * @param request UpdateLiveTranscodeTemplateRequest
         * @return UpdateLiveTranscodeTemplateResponse
         */
        public async Task<UpdateLiveTranscodeTemplateResponse> UpdateLiveTranscodeTemplateAsync(UpdateLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveTranscodeTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary UpdateMediaInfo
         *
         * @param request UpdateMediaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMediaInfoResponse
         */
        public UpdateMediaInfoResponse UpdateMediaInfoWithOptions(UpdateMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppendTags))
            {
                query["AppendTags"] = request.AppendTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceId))
            {
                query["ReferenceId"] = request.ReferenceId;
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

        /**
         * @summary UpdateMediaInfo
         *
         * @param request UpdateMediaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMediaInfoResponse
         */
        public async Task<UpdateMediaInfoResponse> UpdateMediaInfoWithOptionsAsync(UpdateMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppendTags))
            {
                query["AppendTags"] = request.AppendTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceId))
            {
                query["ReferenceId"] = request.ReferenceId;
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

        /**
         * @summary UpdateMediaInfo
         *
         * @param request UpdateMediaInfoRequest
         * @return UpdateMediaInfoResponse
         */
        public UpdateMediaInfoResponse UpdateMediaInfo(UpdateMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaInfoWithOptions(request, runtime);
        }

        /**
         * @summary UpdateMediaInfo
         *
         * @param request UpdateMediaInfoRequest
         * @return UpdateMediaInfoResponse
         */
        public async Task<UpdateMediaInfoResponse> UpdateMediaInfoAsync(UpdateMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 为媒资修改标注信息
         *
         * @param request UpdateMediaMarksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMediaMarksResponse
         */
        public UpdateMediaMarksResponse UpdateMediaMarksWithOptions(UpdateMediaMarksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMarks))
            {
                query["MediaMarks"] = request.MediaMarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMediaMarks",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMediaMarksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 为媒资修改标注信息
         *
         * @param request UpdateMediaMarksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMediaMarksResponse
         */
        public async Task<UpdateMediaMarksResponse> UpdateMediaMarksWithOptionsAsync(UpdateMediaMarksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMarks))
            {
                query["MediaMarks"] = request.MediaMarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMediaMarks",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMediaMarksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 为媒资修改标注信息
         *
         * @param request UpdateMediaMarksRequest
         * @return UpdateMediaMarksResponse
         */
        public UpdateMediaMarksResponse UpdateMediaMarks(UpdateMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaMarksWithOptions(request, runtime);
        }

        /**
         * @summary 为媒资修改标注信息
         *
         * @param request UpdateMediaMarksRequest
         * @return UpdateMediaMarksResponse
         */
        public async Task<UpdateMediaMarksResponse> UpdateMediaMarksAsync(UpdateMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaMarksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新媒资到搜索
         *
         * @param request UpdateMediaToSearchLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMediaToSearchLibResponse
         */
        public UpdateMediaToSearchLibResponse UpdateMediaToSearchLibWithOptions(UpdateMediaToSearchLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgBody))
            {
                query["MsgBody"] = request.MsgBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMediaToSearchLib",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMediaToSearchLibResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新媒资到搜索
         *
         * @param request UpdateMediaToSearchLibRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMediaToSearchLibResponse
         */
        public async Task<UpdateMediaToSearchLibResponse> UpdateMediaToSearchLibWithOptionsAsync(UpdateMediaToSearchLibRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgBody))
            {
                query["MsgBody"] = request.MsgBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchLibName))
            {
                query["SearchLibName"] = request.SearchLibName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMediaToSearchLib",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMediaToSearchLibResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新媒资到搜索
         *
         * @param request UpdateMediaToSearchLibRequest
         * @return UpdateMediaToSearchLibResponse
         */
        public UpdateMediaToSearchLibResponse UpdateMediaToSearchLib(UpdateMediaToSearchLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaToSearchLibWithOptions(request, runtime);
        }

        /**
         * @summary 更新媒资到搜索
         *
         * @param request UpdateMediaToSearchLibRequest
         * @return UpdateMediaToSearchLibResponse
         */
        public async Task<UpdateMediaToSearchLibResponse> UpdateMediaToSearchLibAsync(UpdateMediaToSearchLibRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaToSearchLibWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新管道配置
         *
         * @param request UpdatePipelineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePipelineResponse
         */
        public UpdatePipelineResponse UpdatePipelineWithOptions(UpdatePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
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
                Action = "UpdatePipeline",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePipelineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新管道配置
         *
         * @param request UpdatePipelineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePipelineResponse
         */
        public async Task<UpdatePipelineResponse> UpdatePipelineWithOptionsAsync(UpdatePipelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
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
                Action = "UpdatePipeline",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新管道配置
         *
         * @param request UpdatePipelineRequest
         * @return UpdatePipelineResponse
         */
        public UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePipelineWithOptions(request, runtime);
        }

        /**
         * @summary 更新管道配置
         *
         * @param request UpdatePipelineRequest
         * @return UpdatePipelineResponse
         */
        public async Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePipelineWithOptionsAsync(request, runtime);
        }

        /**
         * @summary UpdateTemplate
         *
         * @param request UpdateTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTemplateResponse
         */
        public UpdateTemplateResponse UpdateTemplateWithOptions(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                query["CoverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewMedia))
            {
                query["PreviewMedia"] = request.PreviewMedia;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedMediaids))
            {
                query["RelatedMediaids"] = request.RelatedMediaids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /**
         * @summary UpdateTemplate
         *
         * @param request UpdateTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTemplateResponse
         */
        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                query["CoverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewMedia))
            {
                query["PreviewMedia"] = request.PreviewMedia;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedMediaids))
            {
                query["RelatedMediaids"] = request.RelatedMediaids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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

        /**
         * @summary UpdateTemplate
         *
         * @param request UpdateTemplateRequest
         * @return UpdateTemplateResponse
         */
        public UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTemplateWithOptions(request, runtime);
        }

        /**
         * @summary UpdateTemplate
         *
         * @param request UpdateTemplateRequest
         * @return UpdateTemplateResponse
         */
        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary URL拉取上传
         *
         * @param request UploadMediaByURLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadMediaByURLResponse
         */
        public UploadMediaByURLResponse UploadMediaByURLWithOptions(UploadMediaByURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMetaData))
            {
                query["MediaMetaData"] = request.MediaMetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostProcessConfig))
            {
                query["PostProcessConfig"] = request.PostProcessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadTargetConfig))
            {
                query["UploadTargetConfig"] = request.UploadTargetConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadURLs))
            {
                query["UploadURLs"] = request.UploadURLs;
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
                Action = "UploadMediaByURL",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMediaByURLResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary URL拉取上传
         *
         * @param request UploadMediaByURLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadMediaByURLResponse
         */
        public async Task<UploadMediaByURLResponse> UploadMediaByURLWithOptionsAsync(UploadMediaByURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityId))
            {
                query["EntityId"] = request.EntityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMetaData))
            {
                query["MediaMetaData"] = request.MediaMetaData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostProcessConfig))
            {
                query["PostProcessConfig"] = request.PostProcessConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadTargetConfig))
            {
                query["UploadTargetConfig"] = request.UploadTargetConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadURLs))
            {
                query["UploadURLs"] = request.UploadURLs;
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
                Action = "UploadMediaByURL",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadMediaByURLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary URL拉取上传
         *
         * @param request UploadMediaByURLRequest
         * @return UploadMediaByURLResponse
         */
        public UploadMediaByURLResponse UploadMediaByURL(UploadMediaByURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadMediaByURLWithOptions(request, runtime);
        }

        /**
         * @summary URL拉取上传
         *
         * @param request UploadMediaByURLRequest
         * @return UploadMediaByURLResponse
         */
        public async Task<UploadMediaByURLResponse> UploadMediaByURLAsync(UploadMediaByURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadMediaByURLWithOptionsAsync(request, runtime);
        }

        /**
         * @summary URL拉取上传媒体流
         *
         * @param request UploadStreamByURLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadStreamByURLResponse
         */
        public UploadStreamByURLResponse UploadStreamByURLWithOptions(UploadStreamByURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                query["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileExtension))
            {
                query["FileExtension"] = request.FileExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HDRType))
            {
                query["HDRType"] = request.HDRType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamURL))
            {
                query["StreamURL"] = request.StreamURL;
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
                Action = "UploadStreamByURL",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadStreamByURLResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary URL拉取上传媒体流
         *
         * @param request UploadStreamByURLRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadStreamByURLResponse
         */
        public async Task<UploadStreamByURLResponse> UploadStreamByURLWithOptionsAsync(UploadStreamByURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                query["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileExtension))
            {
                query["FileExtension"] = request.FileExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HDRType))
            {
                query["HDRType"] = request.HDRType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamURL))
            {
                query["StreamURL"] = request.StreamURL;
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
                Action = "UploadStreamByURL",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadStreamByURLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary URL拉取上传媒体流
         *
         * @param request UploadStreamByURLRequest
         * @return UploadStreamByURLResponse
         */
        public UploadStreamByURLResponse UploadStreamByURL(UploadStreamByURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadStreamByURLWithOptions(request, runtime);
        }

        /**
         * @summary URL拉取上传媒体流
         *
         * @param request UploadStreamByURLRequest
         * @return UploadStreamByURLResponse
         */
        public async Task<UploadStreamByURLResponse> UploadStreamByURLAsync(UploadStreamByURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadStreamByURLWithOptionsAsync(request, runtime);
        }

    }
}
