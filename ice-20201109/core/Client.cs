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

        public AddCategoryResponse AddCategory(AddCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCategoryWithOptions(request, runtime);
        }

        public async Task<AddCategoryResponse> AddCategoryAsync(AddCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCategoryWithOptionsAsync(request, runtime);
        }

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

        public AddMediaMarksResponse AddMediaMarks(AddMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMediaMarksWithOptions(request, runtime);
        }

        public async Task<AddMediaMarksResponse> AddMediaMarksAsync(AddMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMediaMarksWithOptionsAsync(request, runtime);
        }

        public AddTemplateResponse AddTemplateWithOptions(AddTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
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

        public CancelDNAJobResponse CancelDNAJob(CancelDNAJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelDNAJobWithOptions(request, runtime);
        }

        public async Task<CancelDNAJobResponse> CancelDNAJobAsync(CancelDNAJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelDNAJobWithOptionsAsync(request, runtime);
        }

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

        public CreateAuditResponse CreateAuditWithOptions(CreateAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
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

        public async Task<CreateAuditResponse> CreateAuditWithOptionsAsync(CreateAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
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

        public CreateAuditResponse CreateAudit(CreateAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAuditWithOptions(request, runtime);
        }

        public async Task<CreateAuditResponse> CreateAuditAsync(CreateAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAuditWithOptionsAsync(request, runtime);
        }

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

        public CreateCustomTemplateResponse CreateCustomTemplate(CreateCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomTemplateWithOptions(request, runtime);
        }

        public async Task<CreateCustomTemplateResponse> CreateCustomTemplateAsync(CreateCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomTemplateWithOptionsAsync(request, runtime);
        }

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

        public CreateDNADBResponse CreateDNADB(CreateDNADBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDNADBWithOptions(request, runtime);
        }

        public async Task<CreateDNADBResponse> CreateDNADBAsync(CreateDNADBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDNADBWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                query["Timeline"] = request.Timeline;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                query["Timeline"] = request.Timeline;
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

        public CreateLiveRecordTemplateResponse CreateLiveRecordTemplate(CreateLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLiveRecordTemplateWithOptions(request, runtime);
        }

        public async Task<CreateLiveRecordTemplateResponse> CreateLiveRecordTemplateAsync(CreateLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLiveRecordTemplateWithOptionsAsync(request, runtime);
        }

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

        public CreateLiveSnapshotTemplateResponse CreateLiveSnapshotTemplate(CreateLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLiveSnapshotTemplateWithOptions(request, runtime);
        }

        public async Task<CreateLiveSnapshotTemplateResponse> CreateLiveSnapshotTemplateAsync(CreateLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLiveSnapshotTemplateWithOptionsAsync(request, runtime);
        }

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

        public CreateLiveTranscodeTemplateResponse CreateLiveTranscodeTemplate(CreateLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLiveTranscodeTemplateWithOptions(request, runtime);
        }

        public async Task<CreateLiveTranscodeTemplateResponse> CreateLiveTranscodeTemplateAsync(CreateLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLiveTranscodeTemplateWithOptionsAsync(request, runtime);
        }

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

        public CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePipelineWithOptions(request, runtime);
        }

        public async Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePipelineWithOptionsAsync(request, runtime);
        }

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

        public CreateUploadMediaResponse CreateUploadMedia(CreateUploadMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUploadMediaWithOptions(request, runtime);
        }

        public async Task<CreateUploadMediaResponse> CreateUploadMediaAsync(CreateUploadMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUploadMediaWithOptionsAsync(request, runtime);
        }

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

        public CreateUploadStreamResponse CreateUploadStream(CreateUploadStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUploadStreamWithOptions(request, runtime);
        }

        public async Task<CreateUploadStreamResponse> CreateUploadStreamAsync(CreateUploadStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUploadStreamWithOptionsAsync(request, runtime);
        }

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

        public DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCategoryWithOptions(request, runtime);
        }

        public async Task<DeleteCategoryResponse> DeleteCategoryAsync(DeleteCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCategoryWithOptionsAsync(request, runtime);
        }

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

        public DeleteCustomTemplateResponse DeleteCustomTemplate(DeleteCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteCustomTemplateResponse> DeleteCustomTemplateAsync(DeleteCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomTemplateWithOptionsAsync(request, runtime);
        }

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

        public DeleteDNADBResponse DeleteDNADB(DeleteDNADBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDNADBWithOptions(request, runtime);
        }

        public async Task<DeleteDNADBResponse> DeleteDNADBAsync(DeleteDNADBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDNADBWithOptionsAsync(request, runtime);
        }

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

        public DeleteDNAFilesResponse DeleteDNAFiles(DeleteDNAFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDNAFilesWithOptions(request, runtime);
        }

        public async Task<DeleteDNAFilesResponse> DeleteDNAFilesAsync(DeleteDNAFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDNAFilesWithOptionsAsync(request, runtime);
        }

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

        public DeleteLiveRecordFilesResponse DeleteLiveRecordFiles(DeleteLiveRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveRecordFilesWithOptions(request, runtime);
        }

        public async Task<DeleteLiveRecordFilesResponse> DeleteLiveRecordFilesAsync(DeleteLiveRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveRecordFilesWithOptionsAsync(request, runtime);
        }

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

        public DeleteLiveRecordTemplateResponse DeleteLiveRecordTemplate(DeleteLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveRecordTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteLiveRecordTemplateResponse> DeleteLiveRecordTemplateAsync(DeleteLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveRecordTemplateWithOptionsAsync(request, runtime);
        }

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

        public DeleteLiveSnapshotFilesResponse DeleteLiveSnapshotFiles(DeleteLiveSnapshotFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveSnapshotFilesWithOptions(request, runtime);
        }

        public async Task<DeleteLiveSnapshotFilesResponse> DeleteLiveSnapshotFilesAsync(DeleteLiveSnapshotFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveSnapshotFilesWithOptionsAsync(request, runtime);
        }

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

        public DeleteLiveSnapshotTemplateResponse DeleteLiveSnapshotTemplate(DeleteLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveSnapshotTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteLiveSnapshotTemplateResponse> DeleteLiveSnapshotTemplateAsync(DeleteLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveSnapshotTemplateWithOptionsAsync(request, runtime);
        }

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

        public DeleteLiveTranscodeJobResponse DeleteLiveTranscodeJob(DeleteLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveTranscodeJobWithOptions(request, runtime);
        }

        public async Task<DeleteLiveTranscodeJobResponse> DeleteLiveTranscodeJobAsync(DeleteLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveTranscodeJobWithOptionsAsync(request, runtime);
        }

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

        public DeleteLiveTranscodeTemplateResponse DeleteLiveTranscodeTemplate(DeleteLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveTranscodeTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteLiveTranscodeTemplateResponse> DeleteLiveTranscodeTemplateAsync(DeleteLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveTranscodeTemplateWithOptionsAsync(request, runtime);
        }

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

        public DeleteMediaMarksResponse DeleteMediaMarks(DeleteMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMediaMarksWithOptions(request, runtime);
        }

        public async Task<DeleteMediaMarksResponse> DeleteMediaMarksAsync(DeleteMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMediaMarksWithOptionsAsync(request, runtime);
        }

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

        public DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePipelineWithOptions(request, runtime);
        }

        public async Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePipelineWithOptionsAsync(request, runtime);
        }

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

        public DeletePlayInfoResponse DeletePlayInfo(DeletePlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePlayInfoWithOptions(request, runtime);
        }

        public async Task<DeletePlayInfoResponse> DeletePlayInfoAsync(DeletePlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePlayInfoWithOptionsAsync(request, runtime);
        }

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

        public DescribeFilterConfigsResponse DescribeFilterConfigsWithOptions(DescribeFilterConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeFilterConfigs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFilterConfigsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFilterConfigsResponse> DescribeFilterConfigsWithOptionsAsync(DescribeFilterConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeFilterConfigs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFilterConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFilterConfigsResponse DescribeFilterConfigs(DescribeFilterConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFilterConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeFilterConfigsResponse> DescribeFilterConfigsAsync(DescribeFilterConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFilterConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeMeterIceEditUsageResponse DescribeMeterIceEditUsageWithOptions(DescribeMeterIceEditUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterIceEditUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterIceEditUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterIceEditUsageResponse> DescribeMeterIceEditUsageWithOptionsAsync(DescribeMeterIceEditUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterIceEditUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterIceEditUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterIceEditUsageResponse DescribeMeterIceEditUsage(DescribeMeterIceEditUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterIceEditUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterIceEditUsageResponse> DescribeMeterIceEditUsageAsync(DescribeMeterIceEditUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterIceEditUsageWithOptionsAsync(request, runtime);
        }

        public DescribeMeterIceLiveMediaConvertUsageResponse DescribeMeterIceLiveMediaConvertUsageWithOptions(DescribeMeterIceLiveMediaConvertUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterIceLiveMediaConvertUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterIceLiveMediaConvertUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterIceLiveMediaConvertUsageResponse> DescribeMeterIceLiveMediaConvertUsageWithOptionsAsync(DescribeMeterIceLiveMediaConvertUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterIceLiveMediaConvertUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterIceLiveMediaConvertUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterIceLiveMediaConvertUsageResponse DescribeMeterIceLiveMediaConvertUsage(DescribeMeterIceLiveMediaConvertUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterIceLiveMediaConvertUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterIceLiveMediaConvertUsageResponse> DescribeMeterIceLiveMediaConvertUsageAsync(DescribeMeterIceLiveMediaConvertUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterIceLiveMediaConvertUsageWithOptionsAsync(request, runtime);
        }

        public DescribeMeterIceMediaConvertUHDUsageResponse DescribeMeterIceMediaConvertUHDUsageWithOptions(DescribeMeterIceMediaConvertUHDUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterIceMediaConvertUHDUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterIceMediaConvertUHDUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterIceMediaConvertUHDUsageResponse> DescribeMeterIceMediaConvertUHDUsageWithOptionsAsync(DescribeMeterIceMediaConvertUHDUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterIceMediaConvertUHDUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterIceMediaConvertUHDUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterIceMediaConvertUHDUsageResponse DescribeMeterIceMediaConvertUHDUsage(DescribeMeterIceMediaConvertUHDUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterIceMediaConvertUHDUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterIceMediaConvertUHDUsageResponse> DescribeMeterIceMediaConvertUHDUsageAsync(DescribeMeterIceMediaConvertUHDUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterIceMediaConvertUHDUsageWithOptionsAsync(request, runtime);
        }

        public DescribeMeterIceMediaConvertUsageResponse DescribeMeterIceMediaConvertUsageWithOptions(DescribeMeterIceMediaConvertUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterIceMediaConvertUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterIceMediaConvertUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterIceMediaConvertUsageResponse> DescribeMeterIceMediaConvertUsageWithOptionsAsync(DescribeMeterIceMediaConvertUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterIceMediaConvertUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterIceMediaConvertUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterIceMediaConvertUsageResponse DescribeMeterIceMediaConvertUsage(DescribeMeterIceMediaConvertUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterIceMediaConvertUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterIceMediaConvertUsageResponse> DescribeMeterIceMediaConvertUsageAsync(DescribeMeterIceMediaConvertUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterIceMediaConvertUsageWithOptionsAsync(request, runtime);
        }

        public DescribeMeterIceMpsAiUsageResponse DescribeMeterIceMpsAiUsageWithOptions(DescribeMeterIceMpsAiUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterIceMpsAiUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterIceMpsAiUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterIceMpsAiUsageResponse> DescribeMeterIceMpsAiUsageWithOptionsAsync(DescribeMeterIceMpsAiUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterIceMpsAiUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterIceMpsAiUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterIceMpsAiUsageResponse DescribeMeterIceMpsAiUsage(DescribeMeterIceMpsAiUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterIceMpsAiUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterIceMpsAiUsageResponse> DescribeMeterIceMpsAiUsageAsync(DescribeMeterIceMpsAiUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterIceMpsAiUsageWithOptionsAsync(request, runtime);
        }

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

        public DescribeMeterImsEditUsageResponse DescribeMeterImsEditUsage(DescribeMeterImsEditUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsEditUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterImsEditUsageResponse> DescribeMeterImsEditUsageAsync(DescribeMeterImsEditUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsEditUsageWithOptionsAsync(request, runtime);
        }

        public DescribeMeterImsLiveEditUsageResponse DescribeMeterImsLiveEditUsageWithOptions(DescribeMeterImsLiveEditUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterImsLiveEditUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsLiveEditUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterImsLiveEditUsageResponse> DescribeMeterImsLiveEditUsageWithOptionsAsync(DescribeMeterImsLiveEditUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterImsLiveEditUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsLiveEditUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterImsLiveEditUsageResponse DescribeMeterImsLiveEditUsage(DescribeMeterImsLiveEditUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsLiveEditUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterImsLiveEditUsageResponse> DescribeMeterImsLiveEditUsageAsync(DescribeMeterImsLiveEditUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsLiveEditUsageWithOptionsAsync(request, runtime);
        }

        public DescribeMeterImsLiveMediaConvertUsageResponse DescribeMeterImsLiveMediaConvertUsageWithOptions(DescribeMeterImsLiveMediaConvertUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterImsLiveMediaConvertUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsLiveMediaConvertUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterImsLiveMediaConvertUsageResponse> DescribeMeterImsLiveMediaConvertUsageWithOptionsAsync(DescribeMeterImsLiveMediaConvertUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterImsLiveMediaConvertUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsLiveMediaConvertUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterImsLiveMediaConvertUsageResponse DescribeMeterImsLiveMediaConvertUsage(DescribeMeterImsLiveMediaConvertUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsLiveMediaConvertUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterImsLiveMediaConvertUsageResponse> DescribeMeterImsLiveMediaConvertUsageAsync(DescribeMeterImsLiveMediaConvertUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsLiveMediaConvertUsageWithOptionsAsync(request, runtime);
        }

        public DescribeMeterImsLiveRecordUsageResponse DescribeMeterImsLiveRecordUsageWithOptions(DescribeMeterImsLiveRecordUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterImsLiveRecordUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsLiveRecordUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterImsLiveRecordUsageResponse> DescribeMeterImsLiveRecordUsageWithOptionsAsync(DescribeMeterImsLiveRecordUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterImsLiveRecordUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsLiveRecordUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterImsLiveRecordUsageResponse DescribeMeterImsLiveRecordUsage(DescribeMeterImsLiveRecordUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsLiveRecordUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterImsLiveRecordUsageResponse> DescribeMeterImsLiveRecordUsageAsync(DescribeMeterImsLiveRecordUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsLiveRecordUsageWithOptionsAsync(request, runtime);
        }

        public DescribeMeterImsLiveSnapshotUsageResponse DescribeMeterImsLiveSnapshotUsageWithOptions(DescribeMeterImsLiveSnapshotUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterImsLiveSnapshotUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsLiveSnapshotUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterImsLiveSnapshotUsageResponse> DescribeMeterImsLiveSnapshotUsageWithOptionsAsync(DescribeMeterImsLiveSnapshotUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeMeterImsLiveSnapshotUsage",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterImsLiveSnapshotUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterImsLiveSnapshotUsageResponse DescribeMeterImsLiveSnapshotUsage(DescribeMeterImsLiveSnapshotUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsLiveSnapshotUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterImsLiveSnapshotUsageResponse> DescribeMeterImsLiveSnapshotUsageAsync(DescribeMeterImsLiveSnapshotUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsLiveSnapshotUsageWithOptionsAsync(request, runtime);
        }

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

        public DescribeMeterImsMediaConvertUHDUsageResponse DescribeMeterImsMediaConvertUHDUsage(DescribeMeterImsMediaConvertUHDUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsMediaConvertUHDUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterImsMediaConvertUHDUsageResponse> DescribeMeterImsMediaConvertUHDUsageAsync(DescribeMeterImsMediaConvertUHDUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsMediaConvertUHDUsageWithOptionsAsync(request, runtime);
        }

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

        public DescribeMeterImsMediaConvertUsageResponse DescribeMeterImsMediaConvertUsage(DescribeMeterImsMediaConvertUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsMediaConvertUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterImsMediaConvertUsageResponse> DescribeMeterImsMediaConvertUsageAsync(DescribeMeterImsMediaConvertUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsMediaConvertUsageWithOptionsAsync(request, runtime);
        }

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

        public DescribeMeterImsMpsAiUsageResponse DescribeMeterImsMpsAiUsage(DescribeMeterImsMpsAiUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsMpsAiUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterImsMpsAiUsageResponse> DescribeMeterImsMpsAiUsageAsync(DescribeMeterImsMpsAiUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsMpsAiUsageWithOptionsAsync(request, runtime);
        }

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

        public DescribeMeterImsSummaryResponse DescribeMeterImsSummary(DescribeMeterImsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterImsSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeMeterImsSummaryResponse> DescribeMeterImsSummaryAsync(DescribeMeterImsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterImsSummaryWithOptionsAsync(request, runtime);
        }

        public DescribePlayDetailResponse DescribePlayDetailWithOptions(DescribePlayDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTs))
            {
                query["PlayTs"] = request.PlayTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayDetail",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePlayDetailResponse> DescribePlayDetailWithOptionsAsync(DescribePlayDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTs))
            {
                query["PlayTs"] = request.PlayTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayDetail",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePlayDetailResponse DescribePlayDetail(DescribePlayDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayDetailWithOptions(request, runtime);
        }

        public async Task<DescribePlayDetailResponse> DescribePlayDetailAsync(DescribePlayDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayDetailWithOptionsAsync(request, runtime);
        }

        public DescribePlayEventListResponse DescribePlayEventListWithOptions(DescribePlayEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTs))
            {
                query["PlayTs"] = request.PlayTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayEventList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayEventListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePlayEventListResponse> DescribePlayEventListWithOptionsAsync(DescribePlayEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTs))
            {
                query["PlayTs"] = request.PlayTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayEventList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayEventListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePlayEventListResponse DescribePlayEventList(DescribePlayEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayEventListWithOptions(request, runtime);
        }

        public async Task<DescribePlayEventListResponse> DescribePlayEventListAsync(DescribePlayEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayEventListWithOptionsAsync(request, runtime);
        }

        public DescribePlayFirstFrameDurationMetricDataResponse DescribePlayFirstFrameDurationMetricDataWithOptions(DescribePlayFirstFrameDurationMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribePlayFirstFrameDurationMetricData",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayFirstFrameDurationMetricDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePlayFirstFrameDurationMetricDataResponse> DescribePlayFirstFrameDurationMetricDataWithOptionsAsync(DescribePlayFirstFrameDurationMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribePlayFirstFrameDurationMetricData",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayFirstFrameDurationMetricDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePlayFirstFrameDurationMetricDataResponse DescribePlayFirstFrameDurationMetricData(DescribePlayFirstFrameDurationMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayFirstFrameDurationMetricDataWithOptions(request, runtime);
        }

        public async Task<DescribePlayFirstFrameDurationMetricDataResponse> DescribePlayFirstFrameDurationMetricDataAsync(DescribePlayFirstFrameDurationMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayFirstFrameDurationMetricDataWithOptionsAsync(request, runtime);
        }

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

        public DescribePlayListResponse DescribePlayList(DescribePlayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayListWithOptions(request, runtime);
        }

        public async Task<DescribePlayListResponse> DescribePlayListAsync(DescribePlayListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayListWithOptionsAsync(request, runtime);
        }

        public DescribePlayMetricDataResponse DescribePlayMetricDataWithOptions(DescribePlayMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTs))
            {
                query["BeginTs"] = request.BeginTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                query["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperienceLevel))
            {
                query["ExperienceLevel"] = request.ExperienceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConfigs))
            {
                query["ItemConfigs"] = request.ItemConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                query["Os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkVersion))
            {
                query["SdkVersion"] = request.SdkVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalType))
            {
                query["TerminalType"] = request.TerminalType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayMetricData",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayMetricDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePlayMetricDataResponse> DescribePlayMetricDataWithOptionsAsync(DescribePlayMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTs))
            {
                query["BeginTs"] = request.BeginTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                query["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperienceLevel))
            {
                query["ExperienceLevel"] = request.ExperienceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConfigs))
            {
                query["ItemConfigs"] = request.ItemConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                query["Os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkVersion))
            {
                query["SdkVersion"] = request.SdkVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalType))
            {
                query["TerminalType"] = request.TerminalType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayMetricData",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayMetricDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePlayMetricDataResponse DescribePlayMetricData(DescribePlayMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayMetricDataWithOptions(request, runtime);
        }

        public async Task<DescribePlayMetricDataResponse> DescribePlayMetricDataAsync(DescribePlayMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayMetricDataWithOptionsAsync(request, runtime);
        }

        public DescribePlayQoeListResponse DescribePlayQoeListWithOptions(DescribePlayQoeListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePlayQoeListShrinkRequest request = new DescribePlayQoeListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MetricTypes))
            {
                request.MetricTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MetricTypes, "MetricTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTs))
            {
                query["BeginTs"] = request.BeginTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                query["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConfigs))
            {
                query["ItemConfigs"] = request.ItemConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricTypesShrink))
            {
                query["MetricTypes"] = request.MetricTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderName))
            {
                query["OrderName"] = request.OrderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                query["Os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalType))
            {
                query["TerminalType"] = request.TerminalType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayQoeList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayQoeListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePlayQoeListResponse> DescribePlayQoeListWithOptionsAsync(DescribePlayQoeListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePlayQoeListShrinkRequest request = new DescribePlayQoeListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MetricTypes))
            {
                request.MetricTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MetricTypes, "MetricTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTs))
            {
                query["BeginTs"] = request.BeginTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                query["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConfigs))
            {
                query["ItemConfigs"] = request.ItemConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricTypesShrink))
            {
                query["MetricTypes"] = request.MetricTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderName))
            {
                query["OrderName"] = request.OrderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                query["Os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalType))
            {
                query["TerminalType"] = request.TerminalType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayQoeList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayQoeListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePlayQoeListResponse DescribePlayQoeList(DescribePlayQoeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayQoeListWithOptions(request, runtime);
        }

        public async Task<DescribePlayQoeListResponse> DescribePlayQoeListAsync(DescribePlayQoeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayQoeListWithOptionsAsync(request, runtime);
        }

        public DescribePlayQosListResponse DescribePlayQosListWithOptions(DescribePlayQosListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePlayQosListShrinkRequest request = new DescribePlayQosListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MetricTypes))
            {
                request.MetricTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MetricTypes, "MetricTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTs))
            {
                query["BeginTs"] = request.BeginTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                query["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConfigs))
            {
                query["ItemConfigs"] = request.ItemConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricTypesShrink))
            {
                query["MetricTypes"] = request.MetricTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderName))
            {
                query["OrderName"] = request.OrderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                query["Os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalType))
            {
                query["TerminalType"] = request.TerminalType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayQosList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayQosListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePlayQosListResponse> DescribePlayQosListWithOptionsAsync(DescribePlayQosListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePlayQosListShrinkRequest request = new DescribePlayQosListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MetricTypes))
            {
                request.MetricTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MetricTypes, "MetricTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTs))
            {
                query["BeginTs"] = request.BeginTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                query["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConfigs))
            {
                query["ItemConfigs"] = request.ItemConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricTypesShrink))
            {
                query["MetricTypes"] = request.MetricTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderName))
            {
                query["OrderName"] = request.OrderName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                query["Os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalType))
            {
                query["TerminalType"] = request.TerminalType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayQosList",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayQosListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePlayQosListResponse DescribePlayQosList(DescribePlayQosListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayQosListWithOptions(request, runtime);
        }

        public async Task<DescribePlayQosListResponse> DescribePlayQosListAsync(DescribePlayQosListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayQosListWithOptionsAsync(request, runtime);
        }

        public DescribeQueryConfigsResponse DescribeQueryConfigsWithOptions(DescribeQueryConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeQueryConfigs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQueryConfigsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeQueryConfigsResponse> DescribeQueryConfigsWithOptionsAsync(DescribeQueryConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeQueryConfigs",
                Version = "2020-11-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeQueryConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeQueryConfigsResponse DescribeQueryConfigs(DescribeQueryConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQueryConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeQueryConfigsResponse> DescribeQueryConfigsAsync(DescribeQueryConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQueryConfigsWithOptionsAsync(request, runtime);
        }

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

        public GetCategoriesResponse GetCategories(GetCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCategoriesWithOptions(request, runtime);
        }

        public async Task<GetCategoriesResponse> GetCategoriesAsync(GetCategoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCategoriesWithOptionsAsync(request, runtime);
        }

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

        public GetCustomTemplateResponse GetCustomTemplate(GetCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomTemplateWithOptions(request, runtime);
        }

        public async Task<GetCustomTemplateResponse> GetCustomTemplateAsync(GetCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomTemplateWithOptionsAsync(request, runtime);
        }

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

        public GetDefaultStorageLocationResponse GetDefaultStorageLocation()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDefaultStorageLocationWithOptions(runtime);
        }

        public async Task<GetDefaultStorageLocationResponse> GetDefaultStorageLocationAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDefaultStorageLocationWithOptionsAsync(runtime);
        }

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

        public GetDynamicImageJobResponse GetDynamicImageJob(GetDynamicImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDynamicImageJobWithOptions(request, runtime);
        }

        public async Task<GetDynamicImageJobResponse> GetDynamicImageJobAsync(GetDynamicImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDynamicImageJobWithOptionsAsync(request, runtime);
        }

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

        public GetEventCallbackResponse GetEventCallback()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEventCallbackWithOptions(runtime);
        }

        public async Task<GetEventCallbackResponse> GetEventCallbackAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEventCallbackWithOptionsAsync(runtime);
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

        public GetLiveRecordJobResponse GetLiveRecordJob(GetLiveRecordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveRecordJobWithOptions(request, runtime);
        }

        public async Task<GetLiveRecordJobResponse> GetLiveRecordJobAsync(GetLiveRecordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveRecordJobWithOptionsAsync(request, runtime);
        }

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

        public GetLiveRecordTemplateResponse GetLiveRecordTemplate(GetLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveRecordTemplateWithOptions(request, runtime);
        }

        public async Task<GetLiveRecordTemplateResponse> GetLiveRecordTemplateAsync(GetLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveRecordTemplateWithOptionsAsync(request, runtime);
        }

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

        public GetLiveSnapshotJobResponse GetLiveSnapshotJob(GetLiveSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveSnapshotJobWithOptions(request, runtime);
        }

        public async Task<GetLiveSnapshotJobResponse> GetLiveSnapshotJobAsync(GetLiveSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveSnapshotJobWithOptionsAsync(request, runtime);
        }

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

        public GetLiveSnapshotTemplateResponse GetLiveSnapshotTemplate(GetLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveSnapshotTemplateWithOptions(request, runtime);
        }

        public async Task<GetLiveSnapshotTemplateResponse> GetLiveSnapshotTemplateAsync(GetLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveSnapshotTemplateWithOptionsAsync(request, runtime);
        }

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

        public GetLiveTranscodeJobResponse GetLiveTranscodeJob(GetLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveTranscodeJobWithOptions(request, runtime);
        }

        public async Task<GetLiveTranscodeJobResponse> GetLiveTranscodeJobAsync(GetLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveTranscodeJobWithOptionsAsync(request, runtime);
        }

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

        public GetLiveTranscodeTemplateResponse GetLiveTranscodeTemplate(GetLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLiveTranscodeTemplateWithOptions(request, runtime);
        }

        public async Task<GetLiveTranscodeTemplateResponse> GetLiveTranscodeTemplateAsync(GetLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLiveTranscodeTemplateWithOptionsAsync(request, runtime);
        }

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

        public GetMediaInfoJobResponse GetMediaInfoJob(GetMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaInfoJobWithOptions(request, runtime);
        }

        public async Task<GetMediaInfoJobResponse> GetMediaInfoJobAsync(GetMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaInfoJobWithOptionsAsync(request, runtime);
        }

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

        public GetMediaMarksResponse GetMediaMarks(GetMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaMarksWithOptions(request, runtime);
        }

        public async Task<GetMediaMarksResponse> GetMediaMarksAsync(GetMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaMarksWithOptionsAsync(request, runtime);
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

        public GetPackageJobResponse GetPackageJob(GetPackageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPackageJobWithOptions(request, runtime);
        }

        public async Task<GetPackageJobResponse> GetPackageJobAsync(GetPackageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPackageJobWithOptionsAsync(request, runtime);
        }

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

        public GetPipelineResponse GetPipeline(GetPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPipelineWithOptions(request, runtime);
        }

        public async Task<GetPipelineResponse> GetPipelineAsync(GetPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPipelineWithOptionsAsync(request, runtime);
        }

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

        public GetPlayInfoResponse GetPlayInfo(GetPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPlayInfoWithOptions(request, runtime);
        }

        public async Task<GetPlayInfoResponse> GetPlayInfoAsync(GetPlayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPlayInfoWithOptionsAsync(request, runtime);
        }

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

        public GetSnapshotJobResponse GetSnapshotJob(GetSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSnapshotJobWithOptions(request, runtime);
        }

        public async Task<GetSnapshotJobResponse> GetSnapshotJobAsync(GetSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSnapshotJobWithOptionsAsync(request, runtime);
        }

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

        public GetSnapshotUrlsResponse GetSnapshotUrls(GetSnapshotUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSnapshotUrlsWithOptions(request, runtime);
        }

        public async Task<GetSnapshotUrlsResponse> GetSnapshotUrlsAsync(GetSnapshotUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSnapshotUrlsWithOptionsAsync(request, runtime);
        }

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

        public GetSystemTemplateResponse GetSystemTemplate(GetSystemTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSystemTemplateWithOptions(request, runtime);
        }

        public async Task<GetSystemTemplateResponse> GetSystemTemplateAsync(GetSystemTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSystemTemplateWithOptionsAsync(request, runtime);
        }

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

        public GetTemplateParamsResponse GetTemplateParams(GetTemplateParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateParamsWithOptions(request, runtime);
        }

        public async Task<GetTemplateParamsResponse> GetTemplateParamsAsync(GetTemplateParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateParamsWithOptionsAsync(request, runtime);
        }

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

        public GetTranscodeJobResponse GetTranscodeJob(GetTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTranscodeJobWithOptions(request, runtime);
        }

        public async Task<GetTranscodeJobResponse> GetTranscodeJobAsync(GetTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTranscodeJobWithOptionsAsync(request, runtime);
        }

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

        public GetUrlUploadInfosResponse GetUrlUploadInfos(GetUrlUploadInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUrlUploadInfosWithOptions(request, runtime);
        }

        public async Task<GetUrlUploadInfosResponse> GetUrlUploadInfosAsync(GetUrlUploadInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUrlUploadInfosWithOptionsAsync(request, runtime);
        }

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

        public GetWorkflowTaskResponse GetWorkflowTask(GetWorkflowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkflowTaskWithOptions(request, runtime);
        }

        public async Task<GetWorkflowTaskResponse> GetWorkflowTaskAsync(GetWorkflowTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkflowTaskWithOptionsAsync(request, runtime);
        }

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

        public ListCustomTemplatesResponse ListCustomTemplates(ListCustomTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomTemplatesWithOptions(request, runtime);
        }

        public async Task<ListCustomTemplatesResponse> ListCustomTemplatesAsync(ListCustomTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomTemplatesWithOptionsAsync(request, runtime);
        }

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

        public ListDNADBResponse ListDNADB(ListDNADBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDNADBWithOptions(request, runtime);
        }

        public async Task<ListDNADBResponse> ListDNADBAsync(ListDNADBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDNADBWithOptionsAsync(request, runtime);
        }

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

        public ListDNAFilesResponse ListDNAFiles(ListDNAFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDNAFilesWithOptions(request, runtime);
        }

        public async Task<ListDNAFilesResponse> ListDNAFilesAsync(ListDNAFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDNAFilesWithOptionsAsync(request, runtime);
        }

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

        public ListDynamicImageJobsResponse ListDynamicImageJobs(ListDynamicImageJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDynamicImageJobsWithOptions(request, runtime);
        }

        public async Task<ListDynamicImageJobsResponse> ListDynamicImageJobsAsync(ListDynamicImageJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDynamicImageJobsWithOptionsAsync(request, runtime);
        }

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

        public ListLiveRecordFilesResponse ListLiveRecordFiles(ListLiveRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveRecordFilesWithOptions(request, runtime);
        }

        public async Task<ListLiveRecordFilesResponse> ListLiveRecordFilesAsync(ListLiveRecordFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveRecordFilesWithOptionsAsync(request, runtime);
        }

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

        public ListLiveRecordJobsResponse ListLiveRecordJobs(ListLiveRecordJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveRecordJobsWithOptions(request, runtime);
        }

        public async Task<ListLiveRecordJobsResponse> ListLiveRecordJobsAsync(ListLiveRecordJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveRecordJobsWithOptionsAsync(request, runtime);
        }

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

        public ListLiveRecordTemplatesResponse ListLiveRecordTemplates(ListLiveRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveRecordTemplatesWithOptions(request, runtime);
        }

        public async Task<ListLiveRecordTemplatesResponse> ListLiveRecordTemplatesAsync(ListLiveRecordTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveRecordTemplatesWithOptionsAsync(request, runtime);
        }

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

        public ListLiveSnapshotFilesResponse ListLiveSnapshotFiles(ListLiveSnapshotFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveSnapshotFilesWithOptions(request, runtime);
        }

        public async Task<ListLiveSnapshotFilesResponse> ListLiveSnapshotFilesAsync(ListLiveSnapshotFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveSnapshotFilesWithOptionsAsync(request, runtime);
        }

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

        public ListLiveSnapshotJobsResponse ListLiveSnapshotJobs(ListLiveSnapshotJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveSnapshotJobsWithOptions(request, runtime);
        }

        public async Task<ListLiveSnapshotJobsResponse> ListLiveSnapshotJobsAsync(ListLiveSnapshotJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveSnapshotJobsWithOptionsAsync(request, runtime);
        }

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

        public ListLiveSnapshotTemplatesResponse ListLiveSnapshotTemplates(ListLiveSnapshotTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveSnapshotTemplatesWithOptions(request, runtime);
        }

        public async Task<ListLiveSnapshotTemplatesResponse> ListLiveSnapshotTemplatesAsync(ListLiveSnapshotTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveSnapshotTemplatesWithOptionsAsync(request, runtime);
        }

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

        public ListLiveTranscodeJobsResponse ListLiveTranscodeJobs(ListLiveTranscodeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveTranscodeJobsWithOptions(request, runtime);
        }

        public async Task<ListLiveTranscodeJobsResponse> ListLiveTranscodeJobsAsync(ListLiveTranscodeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveTranscodeJobsWithOptionsAsync(request, runtime);
        }

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

        public ListLiveTranscodeTemplatesResponse ListLiveTranscodeTemplates(ListLiveTranscodeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveTranscodeTemplatesWithOptions(request, runtime);
        }

        public async Task<ListLiveTranscodeTemplatesResponse> ListLiveTranscodeTemplatesAsync(ListLiveTranscodeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveTranscodeTemplatesWithOptionsAsync(request, runtime);
        }

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

        public ListMediaInfoJobsResponse ListMediaInfoJobs(ListMediaInfoJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaInfoJobsWithOptions(request, runtime);
        }

        public async Task<ListMediaInfoJobsResponse> ListMediaInfoJobsAsync(ListMediaInfoJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaInfoJobsWithOptionsAsync(request, runtime);
        }

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

        public ListMediaMarksResponse ListMediaMarks(ListMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaMarksWithOptions(request, runtime);
        }

        public async Task<ListMediaMarksResponse> ListMediaMarksAsync(ListMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaMarksWithOptionsAsync(request, runtime);
        }

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

        public ListPackageJobsResponse ListPackageJobs(ListPackageJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPackageJobsWithOptions(request, runtime);
        }

        public async Task<ListPackageJobsResponse> ListPackageJobsAsync(ListPackageJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPackageJobsWithOptionsAsync(request, runtime);
        }

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

        public ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPipelinesWithOptions(request, runtime);
        }

        public async Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPipelinesWithOptionsAsync(request, runtime);
        }

        public ListPublicMediaBasicInfosResponse ListPublicMediaBasicInfosWithOptions(ListPublicMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        public async Task<ListPublicMediaBasicInfosResponse> ListPublicMediaBasicInfosWithOptionsAsync(ListPublicMediaBasicInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        public ListSnapshotJobsResponse ListSnapshotJobs(ListSnapshotJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSnapshotJobsWithOptions(request, runtime);
        }

        public async Task<ListSnapshotJobsResponse> ListSnapshotJobsAsync(ListSnapshotJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSnapshotJobsWithOptionsAsync(request, runtime);
        }

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

        public ListSystemTemplatesResponse ListSystemTemplates(ListSystemTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSystemTemplatesWithOptions(request, runtime);
        }

        public async Task<ListSystemTemplatesResponse> ListSystemTemplatesAsync(ListSystemTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSystemTemplatesWithOptionsAsync(request, runtime);
        }

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

        public ListTranscodeJobsResponse ListTranscodeJobs(ListTranscodeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTranscodeJobsWithOptions(request, runtime);
        }

        public async Task<ListTranscodeJobsResponse> ListTranscodeJobsAsync(ListTranscodeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTranscodeJobsWithOptionsAsync(request, runtime);
        }

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

        public QueryDNAJobListResponse QueryDNAJobList(QueryDNAJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDNAJobListWithOptions(request, runtime);
        }

        public async Task<QueryDNAJobListResponse> QueryDNAJobListAsync(QueryDNAJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDNAJobListWithOptionsAsync(request, runtime);
        }

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

        public QueryIProductionJobResponse QueryIProductionJob(QueryIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIProductionJobWithOptions(request, runtime);
        }

        public async Task<QueryIProductionJobResponse> QueryIProductionJobAsync(QueryIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIProductionJobWithOptionsAsync(request, runtime);
        }

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

        public QueryMediaCensorJobDetailResponse QueryMediaCensorJobDetail(QueryMediaCensorJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaCensorJobDetailWithOptions(request, runtime);
        }

        public async Task<QueryMediaCensorJobDetailResponse> QueryMediaCensorJobDetailAsync(QueryMediaCensorJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaCensorJobDetailWithOptionsAsync(request, runtime);
        }

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

        public QueryMediaCensorJobListResponse QueryMediaCensorJobList(QueryMediaCensorJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMediaCensorJobListWithOptions(request, runtime);
        }

        public async Task<QueryMediaCensorJobListResponse> QueryMediaCensorJobListAsync(QueryMediaCensorJobListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMediaCensorJobListWithOptionsAsync(request, runtime);
        }

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

        public QuerySmarttagJobResponse QuerySmarttagJob(QuerySmarttagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySmarttagJobWithOptions(request, runtime);
        }

        public async Task<QuerySmarttagJobResponse> QuerySmarttagJobAsync(QuerySmarttagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySmarttagJobWithOptionsAsync(request, runtime);
        }

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

        public RefreshUploadMediaResponse RefreshUploadMedia(RefreshUploadMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshUploadMediaWithOptions(request, runtime);
        }

        public async Task<RefreshUploadMediaResponse> RefreshUploadMediaAsync(RefreshUploadMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshUploadMediaWithOptionsAsync(request, runtime);
        }

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

        public RegisterMediaStreamResponse RegisterMediaStream(RegisterMediaStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterMediaStreamWithOptions(request, runtime);
        }

        public async Task<RegisterMediaStreamResponse> RegisterMediaStreamAsync(RegisterMediaStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterMediaStreamWithOptionsAsync(request, runtime);
        }

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

        public SearchMediaResponse SearchMedia(SearchMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchMediaWithOptions(request, runtime);
        }

        public async Task<SearchMediaResponse> SearchMediaAsync(SearchMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchMediaWithOptionsAsync(request, runtime);
        }

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

        public SendLiveSnapshotJobCommandResponse SendLiveSnapshotJobCommand(SendLiveSnapshotJobCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendLiveSnapshotJobCommandWithOptions(request, runtime);
        }

        public async Task<SendLiveSnapshotJobCommandResponse> SendLiveSnapshotJobCommandAsync(SendLiveSnapshotJobCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendLiveSnapshotJobCommandWithOptionsAsync(request, runtime);
        }

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

        public SendLiveTranscodeJobCommandResponse SendLiveTranscodeJobCommand(SendLiveTranscodeJobCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendLiveTranscodeJobCommandWithOptions(request, runtime);
        }

        public async Task<SendLiveTranscodeJobCommandResponse> SendLiveTranscodeJobCommandAsync(SendLiveTranscodeJobCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendLiveTranscodeJobCommandWithOptionsAsync(request, runtime);
        }

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

        public SetDefaultCustomTemplateResponse SetDefaultCustomTemplate(SetDefaultCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultCustomTemplateWithOptions(request, runtime);
        }

        public async Task<SetDefaultCustomTemplateResponse> SetDefaultCustomTemplateAsync(SetDefaultCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultCustomTemplateWithOptionsAsync(request, runtime);
        }

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

        public StartWorkflowResponse StartWorkflow(StartWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartWorkflowWithOptions(request, runtime);
        }

        public async Task<StartWorkflowResponse> StartWorkflowAsync(StartWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartWorkflowWithOptionsAsync(request, runtime);
        }

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

        public SubmitDNAJobResponse SubmitDNAJob(SubmitDNAJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDNAJobWithOptions(request, runtime);
        }

        public async Task<SubmitDNAJobResponse> SubmitDNAJobAsync(SubmitDNAJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDNAJobWithOptionsAsync(request, runtime);
        }

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

        public SubmitDynamicImageJobResponse SubmitDynamicImageJob(SubmitDynamicImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDynamicImageJobWithOptions(request, runtime);
        }

        public async Task<SubmitDynamicImageJobResponse> SubmitDynamicImageJobAsync(SubmitDynamicImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDynamicImageJobWithOptionsAsync(request, runtime);
        }

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

        public SubmitIProductionJobResponse SubmitIProductionJob(SubmitIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitIProductionJobWithOptions(request, runtime);
        }

        public async Task<SubmitIProductionJobResponse> SubmitIProductionJobAsync(SubmitIProductionJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitIProductionJobWithOptionsAsync(request, runtime);
        }

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

        public SubmitLiveRecordJobResponse SubmitLiveRecordJob(SubmitLiveRecordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitLiveRecordJobWithOptions(request, runtime);
        }

        public async Task<SubmitLiveRecordJobResponse> SubmitLiveRecordJobAsync(SubmitLiveRecordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitLiveRecordJobWithOptionsAsync(request, runtime);
        }

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

        public SubmitLiveSnapshotJobResponse SubmitLiveSnapshotJob(SubmitLiveSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitLiveSnapshotJobWithOptions(request, runtime);
        }

        public async Task<SubmitLiveSnapshotJobResponse> SubmitLiveSnapshotJobAsync(SubmitLiveSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitLiveSnapshotJobWithOptionsAsync(request, runtime);
        }

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

        public SubmitLiveTranscodeJobResponse SubmitLiveTranscodeJob(SubmitLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitLiveTranscodeJobWithOptions(request, runtime);
        }

        public async Task<SubmitLiveTranscodeJobResponse> SubmitLiveTranscodeJobAsync(SubmitLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitLiveTranscodeJobWithOptionsAsync(request, runtime);
        }

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

        public SubmitMediaCensorJobResponse SubmitMediaCensorJob(SubmitMediaCensorJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaCensorJobWithOptions(request, runtime);
        }

        public async Task<SubmitMediaCensorJobResponse> SubmitMediaCensorJobAsync(SubmitMediaCensorJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaCensorJobWithOptionsAsync(request, runtime);
        }

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

        public SubmitMediaInfoJobResponse SubmitMediaInfoJob(SubmitMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaInfoJobWithOptions(request, runtime);
        }

        public async Task<SubmitMediaInfoJobResponse> SubmitMediaInfoJobAsync(SubmitMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaInfoJobWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                query["Timeline"] = request.Timeline;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                query["Timeline"] = request.Timeline;
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

        public SubmitPackageJobResponse SubmitPackageJob(SubmitPackageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitPackageJobWithOptions(request, runtime);
        }

        public async Task<SubmitPackageJobResponse> SubmitPackageJobAsync(SubmitPackageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitPackageJobWithOptionsAsync(request, runtime);
        }

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

        public SubmitSmarttagJobResponse SubmitSmarttagJob(SubmitSmarttagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSmarttagJobWithOptions(request, runtime);
        }

        public async Task<SubmitSmarttagJobResponse> SubmitSmarttagJobAsync(SubmitSmarttagJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSmarttagJobWithOptionsAsync(request, runtime);
        }

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

        public SubmitSnapshotJobResponse SubmitSnapshotJob(SubmitSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSnapshotJobWithOptions(request, runtime);
        }

        public async Task<SubmitSnapshotJobResponse> SubmitSnapshotJobAsync(SubmitSnapshotJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSnapshotJobWithOptionsAsync(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request SubmitSubtitleProduceJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitSubtitleProduceJobResponse
         */
        // Deprecated
        public SubmitSubtitleProduceJobResponse SubmitSubtitleProduceJobWithOptions(SubmitSubtitleProduceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsync))
            {
                query["IsAsync"] = request.IsAsync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                query["OutputConfig"] = request.OutputConfig;
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

        /**
          * @deprecated
          *
          * @param request SubmitSubtitleProduceJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitSubtitleProduceJobResponse
         */
        // Deprecated
        public async Task<SubmitSubtitleProduceJobResponse> SubmitSubtitleProduceJobWithOptionsAsync(SubmitSubtitleProduceJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsync))
            {
                query["IsAsync"] = request.IsAsync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputConfig))
            {
                query["OutputConfig"] = request.OutputConfig;
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

        /**
          * @deprecated
          *
          * @param request SubmitSubtitleProduceJobRequest
          * @return SubmitSubtitleProduceJobResponse
         */
        // Deprecated
        public SubmitSubtitleProduceJobResponse SubmitSubtitleProduceJob(SubmitSubtitleProduceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSubtitleProduceJobWithOptions(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request SubmitSubtitleProduceJobRequest
          * @return SubmitSubtitleProduceJobResponse
         */
        // Deprecated
        public async Task<SubmitSubtitleProduceJobResponse> SubmitSubtitleProduceJobAsync(SubmitSubtitleProduceJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSubtitleProduceJobWithOptionsAsync(request, runtime);
        }

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

        public SubmitSyncMediaInfoJobResponse SubmitSyncMediaInfoJob(SubmitSyncMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSyncMediaInfoJobWithOptions(request, runtime);
        }

        public async Task<SubmitSyncMediaInfoJobResponse> SubmitSyncMediaInfoJobAsync(SubmitSyncMediaInfoJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSyncMediaInfoJobWithOptionsAsync(request, runtime);
        }

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

        public SubmitTranscodeJobResponse SubmitTranscodeJob(SubmitTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTranscodeJobWithOptions(request, runtime);
        }

        public async Task<SubmitTranscodeJobResponse> SubmitTranscodeJobAsync(SubmitTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitTranscodeJobWithOptionsAsync(request, runtime);
        }

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

        public UpdateCategoryResponse UpdateCategory(UpdateCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCategoryWithOptions(request, runtime);
        }

        public async Task<UpdateCategoryResponse> UpdateCategoryAsync(UpdateCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCategoryWithOptionsAsync(request, runtime);
        }

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

        public UpdateCustomTemplateResponse UpdateCustomTemplate(UpdateCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateCustomTemplateResponse> UpdateCustomTemplateAsync(UpdateCustomTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomTemplateWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                query["Timeline"] = request.Timeline;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                query["Timeline"] = request.Timeline;
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

        public UpdateLiveRecordTemplateResponse UpdateLiveRecordTemplate(UpdateLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveRecordTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateLiveRecordTemplateResponse> UpdateLiveRecordTemplateAsync(UpdateLiveRecordTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveRecordTemplateWithOptionsAsync(request, runtime);
        }

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

        public UpdateLiveSnapshotTemplateResponse UpdateLiveSnapshotTemplate(UpdateLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveSnapshotTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateLiveSnapshotTemplateResponse> UpdateLiveSnapshotTemplateAsync(UpdateLiveSnapshotTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveSnapshotTemplateWithOptionsAsync(request, runtime);
        }

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

        public UpdateLiveTranscodeJobResponse UpdateLiveTranscodeJob(UpdateLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveTranscodeJobWithOptions(request, runtime);
        }

        public async Task<UpdateLiveTranscodeJobResponse> UpdateLiveTranscodeJobAsync(UpdateLiveTranscodeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveTranscodeJobWithOptionsAsync(request, runtime);
        }

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

        public UpdateLiveTranscodeTemplateResponse UpdateLiveTranscodeTemplate(UpdateLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveTranscodeTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateLiveTranscodeTemplateResponse> UpdateLiveTranscodeTemplateAsync(UpdateLiveTranscodeTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveTranscodeTemplateWithOptionsAsync(request, runtime);
        }

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

        public UpdateMediaMarksResponse UpdateMediaMarks(UpdateMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaMarksWithOptions(request, runtime);
        }

        public async Task<UpdateMediaMarksResponse> UpdateMediaMarksAsync(UpdateMediaMarksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaMarksWithOptionsAsync(request, runtime);
        }

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

        public UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePipelineWithOptions(request, runtime);
        }

        public async Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePipelineWithOptionsAsync(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request UpdateSmartJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateSmartJobResponse
         */
        // Deprecated
        public UpdateSmartJobResponse UpdateSmartJobWithOptions(UpdateSmartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FEExtend))
            {
                query["FEExtend"] = request.FEExtend;
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

        /**
          * @deprecated
          *
          * @param request UpdateSmartJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateSmartJobResponse
         */
        // Deprecated
        public async Task<UpdateSmartJobResponse> UpdateSmartJobWithOptionsAsync(UpdateSmartJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FEExtend))
            {
                query["FEExtend"] = request.FEExtend;
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

        /**
          * @deprecated
          *
          * @param request UpdateSmartJobRequest
          * @return UpdateSmartJobResponse
         */
        // Deprecated
        public UpdateSmartJobResponse UpdateSmartJob(UpdateSmartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSmartJobWithOptions(request, runtime);
        }

        /**
          * @deprecated
          *
          * @param request UpdateSmartJobRequest
          * @return UpdateSmartJobResponse
         */
        // Deprecated
        public async Task<UpdateSmartJobResponse> UpdateSmartJobAsync(UpdateSmartJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSmartJobWithOptionsAsync(request, runtime);
        }

        public UpdateTemplateResponse UpdateTemplateWithOptions(UpdateTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
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

        public UploadMediaByURLResponse UploadMediaByURL(UploadMediaByURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadMediaByURLWithOptions(request, runtime);
        }

        public async Task<UploadMediaByURLResponse> UploadMediaByURLAsync(UploadMediaByURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadMediaByURLWithOptionsAsync(request, runtime);
        }

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

        public UploadStreamByURLResponse UploadStreamByURL(UploadStreamByURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadStreamByURLWithOptions(request, runtime);
        }

        public async Task<UploadStreamByURLResponse> UploadStreamByURLAsync(UploadStreamByURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadStreamByURLWithOptionsAsync(request, runtime);
        }

    }
}
