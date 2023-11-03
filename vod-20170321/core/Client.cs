// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Vod20170321.Models;

namespace AlibabaCloud.SDK.Vod20170321
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "vod.cn-shanghai.aliyuncs.com"},
                {"ap-northeast-2-pop", "vod.aliyuncs.com"},
                {"ap-southeast-2", "vod.aliyuncs.com"},
                {"ap-southeast-3", "vod.aliyuncs.com"},
                {"cn-beijing-finance-1", "vod.aliyuncs.com"},
                {"cn-beijing-finance-pop", "vod.aliyuncs.com"},
                {"cn-beijing-gov-1", "vod.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "vod.aliyuncs.com"},
                {"cn-chengdu", "vod.aliyuncs.com"},
                {"cn-edge-1", "vod.aliyuncs.com"},
                {"cn-fujian", "vod.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "vod.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "vod.aliyuncs.com"},
                {"cn-hangzhou-finance", "vod.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "vod.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "vod.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "vod.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "vod.aliyuncs.com"},
                {"cn-hangzhou-test-306", "vod.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "vod.aliyuncs.com"},
                {"cn-huhehaote", "vod.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "vod.aliyuncs.com"},
                {"cn-qingdao", "vod.aliyuncs.com"},
                {"cn-qingdao-nebula", "vod.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "vod.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "vod.aliyuncs.com"},
                {"cn-shanghai-finance-1", "vod.aliyuncs.com"},
                {"cn-shanghai-inner", "vod.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "vod.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "vod.aliyuncs.com"},
                {"cn-shenzhen-inner", "vod.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "vod.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "vod.aliyuncs.com"},
                {"cn-wuhan", "vod.aliyuncs.com"},
                {"cn-wulanchabu", "vod.aliyuncs.com"},
                {"cn-yushanfang", "vod.aliyuncs.com"},
                {"cn-zhangbei", "vod.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "vod.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "vod.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "vod.aliyuncs.com"},
                {"eu-west-1-oxs", "vod.aliyuncs.com"},
                {"me-east-1", "vod.aliyuncs.com"},
                {"rus-west-1-pop", "vod.aliyuncs.com"},
                {"us-east-1", "vod.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("vod", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   Before you add an AI template for automated review and smart thumbnail tasks, make sure that [automated review](https://ai.aliyun.com/vi/censor) and [smart thumbnail](https://ai.aliyun.com/vi/cover) are enabled.
          *
          * @param request AddAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddAITemplateResponse
         */
        public AddAITemplateResponse AddAITemplateWithOptions(AddAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                query["TemplateConfig"] = request.TemplateConfig;
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
                Action = "AddAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAITemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   Before you add an AI template for automated review and smart thumbnail tasks, make sure that [automated review](https://ai.aliyun.com/vi/censor) and [smart thumbnail](https://ai.aliyun.com/vi/cover) are enabled.
          *
          * @param request AddAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddAITemplateResponse
         */
        public async Task<AddAITemplateResponse> AddAITemplateWithOptionsAsync(AddAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                query["TemplateConfig"] = request.TemplateConfig;
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
                Action = "AddAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAITemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   Before you add an AI template for automated review and smart thumbnail tasks, make sure that [automated review](https://ai.aliyun.com/vi/censor) and [smart thumbnail](https://ai.aliyun.com/vi/cover) are enabled.
          *
          * @param request AddAITemplateRequest
          * @return AddAITemplateResponse
         */
        public AddAITemplateResponse AddAITemplate(AddAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAITemplateWithOptions(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   Before you add an AI template for automated review and smart thumbnail tasks, make sure that [automated review](https://ai.aliyun.com/vi/censor) and [smart thumbnail](https://ai.aliyun.com/vi/cover) are enabled.
          *
          * @param request AddAITemplateRequest
          * @return AddAITemplateResponse
         */
        public async Task<AddAITemplateResponse> AddAITemplateAsync(AddAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAITemplateWithOptionsAsync(request, runtime);
        }

        /**
          * A maximum of three category levels can be created. Each category can contain up to 100 subcategories.
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
                Version = "2017-03-21",
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
          * A maximum of three category levels can be created. Each category can contain up to 100 subcategories.
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
                Version = "2017-03-21",
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
          * A maximum of three category levels can be created. Each category can contain up to 100 subcategories.
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
          * A maximum of three category levels can be created. Each category can contain up to 100 subcategories.
          *
          * @param request AddCategoryRequest
          * @return AddCategoryResponse
         */
        public async Task<AddCategoryResponse> AddCategoryAsync(AddCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCategoryWithOptionsAsync(request, runtime);
        }

        public AddEditingProjectResponse AddEditingProjectWithOptions(AddEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Division))
            {
                query["Division"] = request.Division;
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
                Action = "AddEditingProject",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEditingProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddEditingProjectResponse> AddEditingProjectWithOptionsAsync(AddEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Division))
            {
                query["Division"] = request.Division;
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
                Action = "AddEditingProject",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEditingProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddEditingProjectResponse AddEditingProject(AddEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddEditingProjectWithOptions(request, runtime);
        }

        public async Task<AddEditingProjectResponse> AddEditingProjectAsync(AddEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddEditingProjectWithOptionsAsync(request, runtime);
        }

        public AddEditingProjectMaterialsResponse AddEditingProjectMaterialsWithOptions(AddEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "AddEditingProjectMaterials",
                Version = "2017-03-21",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialIds))
            {
                query["MaterialIds"] = request.MaterialIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialType))
            {
                query["MaterialType"] = request.MaterialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "AddEditingProjectMaterials",
                Version = "2017-03-21",
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

        /**
          * *   You cannot perform custom operations on transcoding template groups that are **locked** in the ApsaraVideo VOD console. You can call the [GetTranscodeTemplateGroup](~~GetTranscodeTemplateGroup~~) operation to query the information about a transcoding template group and check whether the transcoding template group is locked based on the value of the Locked parameter. You can call the [UpdateTranscodeTemplateGroup](~~UpdateTranscodeTemplateGroup~~) operation to unlock a transcoding template group if it is locked. Then, you can perform custom operations on the transcoding template group.
          * *   An Object Storage Service (OSS) bucket is required to store files that are used for transcoding. You cannot create a transcoding template group if no bucket is available. To activate a bucket, perform the following operations: Log on to the ApsaraVideo VOD console. In the left-side navigation pane, choose **Configuration Management > Media Management > Storage**. On the **Storage** page, activate the bucket that is allocated by ApsaraVideo VOD.
          * *   You cannot add transcoding templates to the **No Transcoding** template group.
          * *   You can create a maximum of 20 transcoding template groups.
          * *   You can add a maximum of 20 transcoding templates to a transcoding template group.
          * *   If you want to generate a URL for adaptive bitrate streaming, you can add video packaging templates to a transcoding template group. You can add a maximum of 10 video packaging templates to a transcoding template group. If you add more than 10 video packaging templates, URLs of the video transcoded based on the video packaging templates are generated but the URL for adaptive bitrate streaming is not generated.
          * ### QPS limits
          * You can call this operation up to five times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits](~~342790~~).
          *
          * @param request AddTranscodeTemplateGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddTranscodeTemplateGroupResponse
         */
        public AddTranscodeTemplateGroupResponse AddTranscodeTemplateGroupWithOptions(AddTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateGroupId))
            {
                query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateList))
            {
                query["TranscodeTemplateList"] = request.TranscodeTemplateList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTranscodeTemplateGroup",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTranscodeTemplateGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You cannot perform custom operations on transcoding template groups that are **locked** in the ApsaraVideo VOD console. You can call the [GetTranscodeTemplateGroup](~~GetTranscodeTemplateGroup~~) operation to query the information about a transcoding template group and check whether the transcoding template group is locked based on the value of the Locked parameter. You can call the [UpdateTranscodeTemplateGroup](~~UpdateTranscodeTemplateGroup~~) operation to unlock a transcoding template group if it is locked. Then, you can perform custom operations on the transcoding template group.
          * *   An Object Storage Service (OSS) bucket is required to store files that are used for transcoding. You cannot create a transcoding template group if no bucket is available. To activate a bucket, perform the following operations: Log on to the ApsaraVideo VOD console. In the left-side navigation pane, choose **Configuration Management > Media Management > Storage**. On the **Storage** page, activate the bucket that is allocated by ApsaraVideo VOD.
          * *   You cannot add transcoding templates to the **No Transcoding** template group.
          * *   You can create a maximum of 20 transcoding template groups.
          * *   You can add a maximum of 20 transcoding templates to a transcoding template group.
          * *   If you want to generate a URL for adaptive bitrate streaming, you can add video packaging templates to a transcoding template group. You can add a maximum of 10 video packaging templates to a transcoding template group. If you add more than 10 video packaging templates, URLs of the video transcoded based on the video packaging templates are generated but the URL for adaptive bitrate streaming is not generated.
          * ### QPS limits
          * You can call this operation up to five times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits](~~342790~~).
          *
          * @param request AddTranscodeTemplateGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddTranscodeTemplateGroupResponse
         */
        public async Task<AddTranscodeTemplateGroupResponse> AddTranscodeTemplateGroupWithOptionsAsync(AddTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateGroupId))
            {
                query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateList))
            {
                query["TranscodeTemplateList"] = request.TranscodeTemplateList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTranscodeTemplateGroup",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTranscodeTemplateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You cannot perform custom operations on transcoding template groups that are **locked** in the ApsaraVideo VOD console. You can call the [GetTranscodeTemplateGroup](~~GetTranscodeTemplateGroup~~) operation to query the information about a transcoding template group and check whether the transcoding template group is locked based on the value of the Locked parameter. You can call the [UpdateTranscodeTemplateGroup](~~UpdateTranscodeTemplateGroup~~) operation to unlock a transcoding template group if it is locked. Then, you can perform custom operations on the transcoding template group.
          * *   An Object Storage Service (OSS) bucket is required to store files that are used for transcoding. You cannot create a transcoding template group if no bucket is available. To activate a bucket, perform the following operations: Log on to the ApsaraVideo VOD console. In the left-side navigation pane, choose **Configuration Management > Media Management > Storage**. On the **Storage** page, activate the bucket that is allocated by ApsaraVideo VOD.
          * *   You cannot add transcoding templates to the **No Transcoding** template group.
          * *   You can create a maximum of 20 transcoding template groups.
          * *   You can add a maximum of 20 transcoding templates to a transcoding template group.
          * *   If you want to generate a URL for adaptive bitrate streaming, you can add video packaging templates to a transcoding template group. You can add a maximum of 10 video packaging templates to a transcoding template group. If you add more than 10 video packaging templates, URLs of the video transcoded based on the video packaging templates are generated but the URL for adaptive bitrate streaming is not generated.
          * ### QPS limits
          * You can call this operation up to five times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits](~~342790~~).
          *
          * @param request AddTranscodeTemplateGroupRequest
          * @return AddTranscodeTemplateGroupResponse
         */
        public AddTranscodeTemplateGroupResponse AddTranscodeTemplateGroup(AddTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTranscodeTemplateGroupWithOptions(request, runtime);
        }

        /**
          * *   You cannot perform custom operations on transcoding template groups that are **locked** in the ApsaraVideo VOD console. You can call the [GetTranscodeTemplateGroup](~~GetTranscodeTemplateGroup~~) operation to query the information about a transcoding template group and check whether the transcoding template group is locked based on the value of the Locked parameter. You can call the [UpdateTranscodeTemplateGroup](~~UpdateTranscodeTemplateGroup~~) operation to unlock a transcoding template group if it is locked. Then, you can perform custom operations on the transcoding template group.
          * *   An Object Storage Service (OSS) bucket is required to store files that are used for transcoding. You cannot create a transcoding template group if no bucket is available. To activate a bucket, perform the following operations: Log on to the ApsaraVideo VOD console. In the left-side navigation pane, choose **Configuration Management > Media Management > Storage**. On the **Storage** page, activate the bucket that is allocated by ApsaraVideo VOD.
          * *   You cannot add transcoding templates to the **No Transcoding** template group.
          * *   You can create a maximum of 20 transcoding template groups.
          * *   You can add a maximum of 20 transcoding templates to a transcoding template group.
          * *   If you want to generate a URL for adaptive bitrate streaming, you can add video packaging templates to a transcoding template group. You can add a maximum of 10 video packaging templates to a transcoding template group. If you add more than 10 video packaging templates, URLs of the video transcoded based on the video packaging templates are generated but the URL for adaptive bitrate streaming is not generated.
          * ### QPS limits
          * You can call this operation up to five times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits](~~342790~~).
          *
          * @param request AddTranscodeTemplateGroupRequest
          * @return AddTranscodeTemplateGroupResponse
         */
        public async Task<AddTranscodeTemplateGroupResponse> AddTranscodeTemplateGroupAsync(AddTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTranscodeTemplateGroupWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   Before you add a domain name to accelerate, you must activate ApsaraVideo VOD and apply for an Internet content provider (ICP) filing for the domain name. For more information about how to activate ApsaraVideo VOD, see [Activate ApsaraVideo VOD](~~51512~~).
          * *   If the content on the origin server is not stored on Alibaba Cloud, the content must be reviewed by Alibaba Cloud. The review will be complete by the end of the next business day after you submit an application.
          * *   You can add only one domain name to accelerate in a request. You can add a maximum of 20 accelerated domain names within an Alibaba Cloud account.
          *
          * @param request AddVodDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddVodDomainResponse
         */
        public AddVodDomainResponse AddVodDomainWithOptions(AddVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddVodDomain",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVodDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   Before you add a domain name to accelerate, you must activate ApsaraVideo VOD and apply for an Internet content provider (ICP) filing for the domain name. For more information about how to activate ApsaraVideo VOD, see [Activate ApsaraVideo VOD](~~51512~~).
          * *   If the content on the origin server is not stored on Alibaba Cloud, the content must be reviewed by Alibaba Cloud. The review will be complete by the end of the next business day after you submit an application.
          * *   You can add only one domain name to accelerate in a request. You can add a maximum of 20 accelerated domain names within an Alibaba Cloud account.
          *
          * @param request AddVodDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddVodDomainResponse
         */
        public async Task<AddVodDomainResponse> AddVodDomainWithOptionsAsync(AddVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckUrl))
            {
                query["CheckUrl"] = request.CheckUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddVodDomain",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVodDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   Before you add a domain name to accelerate, you must activate ApsaraVideo VOD and apply for an Internet content provider (ICP) filing for the domain name. For more information about how to activate ApsaraVideo VOD, see [Activate ApsaraVideo VOD](~~51512~~).
          * *   If the content on the origin server is not stored on Alibaba Cloud, the content must be reviewed by Alibaba Cloud. The review will be complete by the end of the next business day after you submit an application.
          * *   You can add only one domain name to accelerate in a request. You can add a maximum of 20 accelerated domain names within an Alibaba Cloud account.
          *
          * @param request AddVodDomainRequest
          * @return AddVodDomainResponse
         */
        public AddVodDomainResponse AddVodDomain(AddVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVodDomainWithOptions(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   Before you add a domain name to accelerate, you must activate ApsaraVideo VOD and apply for an Internet content provider (ICP) filing for the domain name. For more information about how to activate ApsaraVideo VOD, see [Activate ApsaraVideo VOD](~~51512~~).
          * *   If the content on the origin server is not stored on Alibaba Cloud, the content must be reviewed by Alibaba Cloud. The review will be complete by the end of the next business day after you submit an application.
          * *   You can add only one domain name to accelerate in a request. You can add a maximum of 20 accelerated domain names within an Alibaba Cloud account.
          *
          * @param request AddVodDomainRequest
          * @return AddVodDomainResponse
         */
        public async Task<AddVodDomainResponse> AddVodDomainAsync(AddVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVodDomainWithOptionsAsync(request, runtime);
        }

        /**
          * > *   After you create a snapshot template, you can specify the ID of the snapshot template in the request of the [SubmitSnapshotJob](~~72213~~) operation to take snapshots.
          * > *   You can receive the [SnapshotComplete](~~57337~~) event notification by using an HTTP or HTTPS URL or in Message Service (MNS). For more information, see [Overview](~~55627~~).
          *
          * @param request AddVodTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddVodTemplateResponse
         */
        public AddVodTemplateResponse AddVodTemplateWithOptions(AddVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                query["TemplateConfig"] = request.TemplateConfig;
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
                Action = "AddVodTemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVodTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > *   After you create a snapshot template, you can specify the ID of the snapshot template in the request of the [SubmitSnapshotJob](~~72213~~) operation to take snapshots.
          * > *   You can receive the [SnapshotComplete](~~57337~~) event notification by using an HTTP or HTTPS URL or in Message Service (MNS). For more information, see [Overview](~~55627~~).
          *
          * @param request AddVodTemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddVodTemplateResponse
         */
        public async Task<AddVodTemplateResponse> AddVodTemplateWithOptionsAsync(AddVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                query["TemplateConfig"] = request.TemplateConfig;
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
                Action = "AddVodTemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVodTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > *   After you create a snapshot template, you can specify the ID of the snapshot template in the request of the [SubmitSnapshotJob](~~72213~~) operation to take snapshots.
          * > *   You can receive the [SnapshotComplete](~~57337~~) event notification by using an HTTP or HTTPS URL or in Message Service (MNS). For more information, see [Overview](~~55627~~).
          *
          * @param request AddVodTemplateRequest
          * @return AddVodTemplateResponse
         */
        public AddVodTemplateResponse AddVodTemplate(AddVodTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVodTemplateWithOptions(request, runtime);
        }

        /**
          * > *   After you create a snapshot template, you can specify the ID of the snapshot template in the request of the [SubmitSnapshotJob](~~72213~~) operation to take snapshots.
          * > *   You can receive the [SnapshotComplete](~~57337~~) event notification by using an HTTP or HTTPS URL or in Message Service (MNS). For more information, see [Overview](~~55627~~).
          *
          * @param request AddVodTemplateRequest
          * @return AddVodTemplateResponse
         */
        public async Task<AddVodTemplateResponse> AddVodTemplateAsync(AddVodTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVodTemplateWithOptionsAsync(request, runtime);
        }

        /**
          * > ApsaraVideo VOD supports static image watermarks such as PNG files and dynamic image watermarks such as GIF, APNG, and MOV files.
          *
          * @param request AddWatermarkRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddWatermarkResponse
         */
        public AddWatermarkResponse AddWatermarkWithOptions(AddWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkConfig))
            {
                query["WatermarkConfig"] = request.WatermarkConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWatermark",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWatermarkResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > ApsaraVideo VOD supports static image watermarks such as PNG files and dynamic image watermarks such as GIF, APNG, and MOV files.
          *
          * @param request AddWatermarkRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AddWatermarkResponse
         */
        public async Task<AddWatermarkResponse> AddWatermarkWithOptionsAsync(AddWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkConfig))
            {
                query["WatermarkConfig"] = request.WatermarkConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWatermark",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWatermarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > ApsaraVideo VOD supports static image watermarks such as PNG files and dynamic image watermarks such as GIF, APNG, and MOV files.
          *
          * @param request AddWatermarkRequest
          * @return AddWatermarkResponse
         */
        public AddWatermarkResponse AddWatermark(AddWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddWatermarkWithOptions(request, runtime);
        }

        /**
          * > ApsaraVideo VOD supports static image watermarks such as PNG files and dynamic image watermarks such as GIF, APNG, and MOV files.
          *
          * @param request AddWatermarkRequest
          * @return AddWatermarkResponse
         */
        public async Task<AddWatermarkResponse> AddWatermarkAsync(AddWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddWatermarkWithOptionsAsync(request, runtime);
        }

        /**
          * > You can grant a RAM user or RAM role permissions to access up to 10 applications.
          *
          * @param request AttachAppPolicyToIdentityRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AttachAppPolicyToIdentityResponse
         */
        public AttachAppPolicyToIdentityResponse AttachAppPolicyToIdentityWithOptions(AttachAppPolicyToIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityName))
            {
                query["IdentityName"] = request.IdentityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyNames))
            {
                query["PolicyNames"] = request.PolicyNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachAppPolicyToIdentity",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachAppPolicyToIdentityResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can grant a RAM user or RAM role permissions to access up to 10 applications.
          *
          * @param request AttachAppPolicyToIdentityRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AttachAppPolicyToIdentityResponse
         */
        public async Task<AttachAppPolicyToIdentityResponse> AttachAppPolicyToIdentityWithOptionsAsync(AttachAppPolicyToIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityName))
            {
                query["IdentityName"] = request.IdentityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyNames))
            {
                query["PolicyNames"] = request.PolicyNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachAppPolicyToIdentity",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachAppPolicyToIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can grant a RAM user or RAM role permissions to access up to 10 applications.
          *
          * @param request AttachAppPolicyToIdentityRequest
          * @return AttachAppPolicyToIdentityResponse
         */
        public AttachAppPolicyToIdentityResponse AttachAppPolicyToIdentity(AttachAppPolicyToIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachAppPolicyToIdentityWithOptions(request, runtime);
        }

        /**
          * > You can grant a RAM user or RAM role permissions to access up to 10 applications.
          *
          * @param request AttachAppPolicyToIdentityRequest
          * @return AttachAppPolicyToIdentityResponse
         */
        public async Task<AttachAppPolicyToIdentityResponse> AttachAppPolicyToIdentityAsync(AttachAppPolicyToIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachAppPolicyToIdentityWithOptionsAsync(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request BatchSetVodDomainConfigsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchSetVodDomainConfigsResponse
         */
        public BatchSetVodDomainConfigsResponse BatchSetVodDomainConfigsWithOptions(BatchSetVodDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Functions))
            {
                query["Functions"] = request.Functions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSetVodDomainConfigs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetVodDomainConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request BatchSetVodDomainConfigsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchSetVodDomainConfigsResponse
         */
        public async Task<BatchSetVodDomainConfigsResponse> BatchSetVodDomainConfigsWithOptionsAsync(BatchSetVodDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Functions))
            {
                query["Functions"] = request.Functions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSetVodDomainConfigs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSetVodDomainConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request BatchSetVodDomainConfigsRequest
          * @return BatchSetVodDomainConfigsResponse
         */
        public BatchSetVodDomainConfigsResponse BatchSetVodDomainConfigs(BatchSetVodDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetVodDomainConfigsWithOptions(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request BatchSetVodDomainConfigsRequest
          * @return BatchSetVodDomainConfigsResponse
         */
        public async Task<BatchSetVodDomainConfigsResponse> BatchSetVodDomainConfigsAsync(BatchSetVodDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetVodDomainConfigsWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   If the domain name that you want to enable is invalid or your Alibaba Cloud account has overdue payments, you cannot call this operation to enable the domain name.
          *
          * @param request BatchStartVodDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchStartVodDomainResponse
         */
        public BatchStartVodDomainResponse BatchStartVodDomainWithOptions(BatchStartVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStartVodDomain",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStartVodDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   If the domain name that you want to enable is invalid or your Alibaba Cloud account has overdue payments, you cannot call this operation to enable the domain name.
          *
          * @param request BatchStartVodDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchStartVodDomainResponse
         */
        public async Task<BatchStartVodDomainResponse> BatchStartVodDomainWithOptionsAsync(BatchStartVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStartVodDomain",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStartVodDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   If the domain name that you want to enable is invalid or your Alibaba Cloud account has overdue payments, you cannot call this operation to enable the domain name.
          *
          * @param request BatchStartVodDomainRequest
          * @return BatchStartVodDomainResponse
         */
        public BatchStartVodDomainResponse BatchStartVodDomain(BatchStartVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStartVodDomainWithOptions(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   If the domain name that you want to enable is invalid or your Alibaba Cloud account has overdue payments, you cannot call this operation to enable the domain name.
          *
          * @param request BatchStartVodDomainRequest
          * @return BatchStartVodDomainResponse
         */
        public async Task<BatchStartVodDomainResponse> BatchStartVodDomainAsync(BatchStartVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStartVodDomainWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   After you disable an accelerated domain name, the information about the domain name is retained. The system automatically reroutes all the requests that are destined for the domain name to the origin server.
          *
          * @param request BatchStopVodDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchStopVodDomainResponse
         */
        public BatchStopVodDomainResponse BatchStopVodDomainWithOptions(BatchStopVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStopVodDomain",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStopVodDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   After you disable an accelerated domain name, the information about the domain name is retained. The system automatically reroutes all the requests that are destined for the domain name to the origin server.
          *
          * @param request BatchStopVodDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return BatchStopVodDomainResponse
         */
        public async Task<BatchStopVodDomainResponse> BatchStopVodDomainWithOptionsAsync(BatchStopVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStopVodDomain",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStopVodDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   After you disable an accelerated domain name, the information about the domain name is retained. The system automatically reroutes all the requests that are destined for the domain name to the origin server.
          *
          * @param request BatchStopVodDomainRequest
          * @return BatchStopVodDomainResponse
         */
        public BatchStopVodDomainResponse BatchStopVodDomain(BatchStopVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStopVodDomainWithOptions(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   After you disable an accelerated domain name, the information about the domain name is retained. The system automatically reroutes all the requests that are destined for the domain name to the origin server.
          *
          * @param request BatchStopVodDomainRequest
          * @return BatchStopVodDomainResponse
         */
        public async Task<BatchStopVodDomainResponse> BatchStopVodDomainAsync(BatchStopVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStopVodDomainWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can cancel only a URL-based upload job in the **Pending** state. You can query the status of a URL-based upload job by calling the [GetURLUploadInfos](~~106830~~) operation.
          * *   You cannot cancel an upload job that already starts.
          *
          * @param request CancelUrlUploadJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CancelUrlUploadJobsResponse
         */
        public CancelUrlUploadJobsResponse CancelUrlUploadJobsWithOptions(CancelUrlUploadJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadUrls))
            {
                query["UploadUrls"] = request.UploadUrls;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelUrlUploadJobs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelUrlUploadJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can cancel only a URL-based upload job in the **Pending** state. You can query the status of a URL-based upload job by calling the [GetURLUploadInfos](~~106830~~) operation.
          * *   You cannot cancel an upload job that already starts.
          *
          * @param request CancelUrlUploadJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CancelUrlUploadJobsResponse
         */
        public async Task<CancelUrlUploadJobsResponse> CancelUrlUploadJobsWithOptionsAsync(CancelUrlUploadJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadUrls))
            {
                query["UploadUrls"] = request.UploadUrls;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelUrlUploadJobs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelUrlUploadJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can cancel only a URL-based upload job in the **Pending** state. You can query the status of a URL-based upload job by calling the [GetURLUploadInfos](~~106830~~) operation.
          * *   You cannot cancel an upload job that already starts.
          *
          * @param request CancelUrlUploadJobsRequest
          * @return CancelUrlUploadJobsResponse
         */
        public CancelUrlUploadJobsResponse CancelUrlUploadJobs(CancelUrlUploadJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelUrlUploadJobsWithOptions(request, runtime);
        }

        /**
          * *   You can cancel only a URL-based upload job in the **Pending** state. You can query the status of a URL-based upload job by calling the [GetURLUploadInfos](~~106830~~) operation.
          * *   You cannot cancel an upload job that already starts.
          *
          * @param request CancelUrlUploadJobsRequest
          * @return CancelUrlUploadJobsResponse
         */
        public async Task<CancelUrlUploadJobsResponse> CancelUrlUploadJobsAsync(CancelUrlUploadJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelUrlUploadJobsWithOptionsAsync(request, runtime);
        }

        /**
          * You can create up to 10 applications within an Alibaba Cloud account. For more information, see [Multi-application service](~~113600~~).
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request CreateAppInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAppInfoResponse
         */
        public CreateAppInfoResponse CreateAppInfoWithOptions(CreateAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can create up to 10 applications within an Alibaba Cloud account. For more information, see [Multi-application service](~~113600~~).
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request CreateAppInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateAppInfoResponse
         */
        public async Task<CreateAppInfoResponse> CreateAppInfoWithOptionsAsync(CreateAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can create up to 10 applications within an Alibaba Cloud account. For more information, see [Multi-application service](~~113600~~).
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request CreateAppInfoRequest
          * @return CreateAppInfoResponse
         */
        public CreateAppInfoResponse CreateAppInfo(CreateAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppInfoWithOptions(request, runtime);
        }

        /**
          * You can create up to 10 applications within an Alibaba Cloud account. For more information, see [Multi-application service](~~113600~~).
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request CreateAppInfoRequest
          * @return CreateAppInfoResponse
         */
        public async Task<CreateAppInfoResponse> CreateAppInfoAsync(CreateAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppInfoWithOptionsAsync(request, runtime);
        }

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
                Version = "2017-03-21",
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
                Version = "2017-03-21",
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

        /**
          * *   The process of obtaining upload URLs and credentials is a core process in ApsaraVideo VOD and is required for each upload operation. ApsaraVideo VOD provides multiple upload methods. You can upload auxiliary media assets by using server upload SDKs, client upload SDKs, URLs of auxiliary media assets, Object Storage Service (OSS) API, or native OSS SDKs. Each upload method has different requirements for obtaining upload URLs and credentials. For more information, see the "Usage notes" section of the [Upload URLs and credentials](~~55397~~) topic.
          * *   If the upload credential expires, you can call this operation to obtain a new upload URL and credential. The default validity period of an upload credential is 3,000 seconds.
          * *   You can configure a callback to receive an [AttachedMediaUploadComplete](~~103250~~) event notification to determine whether the upload is successful.
          *
          * @param request CreateUploadAttachedMediaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateUploadAttachedMediaResponse
         */
        public CreateUploadAttachedMediaResponse CreateUploadAttachedMediaWithOptions(CreateUploadAttachedMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateIds))
            {
                query["CateIds"] = request.CateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                query["FileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaExt))
            {
                query["MediaExt"] = request.MediaExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageLocation))
            {
                query["StorageLocation"] = request.StorageLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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
                Action = "CreateUploadAttachedMedia",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUploadAttachedMediaResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   The process of obtaining upload URLs and credentials is a core process in ApsaraVideo VOD and is required for each upload operation. ApsaraVideo VOD provides multiple upload methods. You can upload auxiliary media assets by using server upload SDKs, client upload SDKs, URLs of auxiliary media assets, Object Storage Service (OSS) API, or native OSS SDKs. Each upload method has different requirements for obtaining upload URLs and credentials. For more information, see the "Usage notes" section of the [Upload URLs and credentials](~~55397~~) topic.
          * *   If the upload credential expires, you can call this operation to obtain a new upload URL and credential. The default validity period of an upload credential is 3,000 seconds.
          * *   You can configure a callback to receive an [AttachedMediaUploadComplete](~~103250~~) event notification to determine whether the upload is successful.
          *
          * @param request CreateUploadAttachedMediaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateUploadAttachedMediaResponse
         */
        public async Task<CreateUploadAttachedMediaResponse> CreateUploadAttachedMediaWithOptionsAsync(CreateUploadAttachedMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateIds))
            {
                query["CateIds"] = request.CateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                query["FileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaExt))
            {
                query["MediaExt"] = request.MediaExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageLocation))
            {
                query["StorageLocation"] = request.StorageLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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
                Action = "CreateUploadAttachedMedia",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUploadAttachedMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   The process of obtaining upload URLs and credentials is a core process in ApsaraVideo VOD and is required for each upload operation. ApsaraVideo VOD provides multiple upload methods. You can upload auxiliary media assets by using server upload SDKs, client upload SDKs, URLs of auxiliary media assets, Object Storage Service (OSS) API, or native OSS SDKs. Each upload method has different requirements for obtaining upload URLs and credentials. For more information, see the "Usage notes" section of the [Upload URLs and credentials](~~55397~~) topic.
          * *   If the upload credential expires, you can call this operation to obtain a new upload URL and credential. The default validity period of an upload credential is 3,000 seconds.
          * *   You can configure a callback to receive an [AttachedMediaUploadComplete](~~103250~~) event notification to determine whether the upload is successful.
          *
          * @param request CreateUploadAttachedMediaRequest
          * @return CreateUploadAttachedMediaResponse
         */
        public CreateUploadAttachedMediaResponse CreateUploadAttachedMedia(CreateUploadAttachedMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUploadAttachedMediaWithOptions(request, runtime);
        }

        /**
          * *   The process of obtaining upload URLs and credentials is a core process in ApsaraVideo VOD and is required for each upload operation. ApsaraVideo VOD provides multiple upload methods. You can upload auxiliary media assets by using server upload SDKs, client upload SDKs, URLs of auxiliary media assets, Object Storage Service (OSS) API, or native OSS SDKs. Each upload method has different requirements for obtaining upload URLs and credentials. For more information, see the "Usage notes" section of the [Upload URLs and credentials](~~55397~~) topic.
          * *   If the upload credential expires, you can call this operation to obtain a new upload URL and credential. The default validity period of an upload credential is 3,000 seconds.
          * *   You can configure a callback to receive an [AttachedMediaUploadComplete](~~103250~~) event notification to determine whether the upload is successful.
          *
          * @param request CreateUploadAttachedMediaRequest
          * @return CreateUploadAttachedMediaResponse
         */
        public async Task<CreateUploadAttachedMediaResponse> CreateUploadAttachedMediaAsync(CreateUploadAttachedMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUploadAttachedMediaWithOptionsAsync(request, runtime);
        }

        /**
          * *   You must obtain a URL and a credential before you upload an image to ApsaraVideo VOD. ApsaraVideo VOD provides multiple upload methods. You can upload files by using server upload SDKs, client upload SDKs, URLs, Object Storage Service (OSS) API, or OSS SDKs. Each upload method has different requirements for obtaining upload URLs and credentials. For more information, see the "Usage notes" section of the [Upload URLs and credentials](~~55397~~) topic.
          * *   You cannot refresh the upload URL or credential when you upload images. If the image upload credential expires, you can call this operation to obtain a new upload URL and credential. By default, the validity period of an image upload credential is 3,000 seconds.
          * *   You can call the [CreateUploadAttachedMedia](~~98467~~) operation to upload image watermarks.
          * *   You can configure a callback for [ImageUploadComplete](~~91968~~) to receive notifications about the image upload status.
          *
          * @param request CreateUploadImageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateUploadImageResponse
         */
        public CreateUploadImageResponse CreateUploadImageWithOptions(CreateUploadImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageExt))
            {
                query["ImageExt"] = request.ImageExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalFileName))
            {
                query["OriginalFileName"] = request.OriginalFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageLocation))
            {
                query["StorageLocation"] = request.StorageLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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
                Action = "CreateUploadImage",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUploadImageResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You must obtain a URL and a credential before you upload an image to ApsaraVideo VOD. ApsaraVideo VOD provides multiple upload methods. You can upload files by using server upload SDKs, client upload SDKs, URLs, Object Storage Service (OSS) API, or OSS SDKs. Each upload method has different requirements for obtaining upload URLs and credentials. For more information, see the "Usage notes" section of the [Upload URLs and credentials](~~55397~~) topic.
          * *   You cannot refresh the upload URL or credential when you upload images. If the image upload credential expires, you can call this operation to obtain a new upload URL and credential. By default, the validity period of an image upload credential is 3,000 seconds.
          * *   You can call the [CreateUploadAttachedMedia](~~98467~~) operation to upload image watermarks.
          * *   You can configure a callback for [ImageUploadComplete](~~91968~~) to receive notifications about the image upload status.
          *
          * @param request CreateUploadImageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateUploadImageResponse
         */
        public async Task<CreateUploadImageResponse> CreateUploadImageWithOptionsAsync(CreateUploadImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageExt))
            {
                query["ImageExt"] = request.ImageExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalFileName))
            {
                query["OriginalFileName"] = request.OriginalFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageLocation))
            {
                query["StorageLocation"] = request.StorageLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
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
                Action = "CreateUploadImage",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUploadImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You must obtain a URL and a credential before you upload an image to ApsaraVideo VOD. ApsaraVideo VOD provides multiple upload methods. You can upload files by using server upload SDKs, client upload SDKs, URLs, Object Storage Service (OSS) API, or OSS SDKs. Each upload method has different requirements for obtaining upload URLs and credentials. For more information, see the "Usage notes" section of the [Upload URLs and credentials](~~55397~~) topic.
          * *   You cannot refresh the upload URL or credential when you upload images. If the image upload credential expires, you can call this operation to obtain a new upload URL and credential. By default, the validity period of an image upload credential is 3,000 seconds.
          * *   You can call the [CreateUploadAttachedMedia](~~98467~~) operation to upload image watermarks.
          * *   You can configure a callback for [ImageUploadComplete](~~91968~~) to receive notifications about the image upload status.
          *
          * @param request CreateUploadImageRequest
          * @return CreateUploadImageResponse
         */
        public CreateUploadImageResponse CreateUploadImage(CreateUploadImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUploadImageWithOptions(request, runtime);
        }

        /**
          * *   You must obtain a URL and a credential before you upload an image to ApsaraVideo VOD. ApsaraVideo VOD provides multiple upload methods. You can upload files by using server upload SDKs, client upload SDKs, URLs, Object Storage Service (OSS) API, or OSS SDKs. Each upload method has different requirements for obtaining upload URLs and credentials. For more information, see the "Usage notes" section of the [Upload URLs and credentials](~~55397~~) topic.
          * *   You cannot refresh the upload URL or credential when you upload images. If the image upload credential expires, you can call this operation to obtain a new upload URL and credential. By default, the validity period of an image upload credential is 3,000 seconds.
          * *   You can call the [CreateUploadAttachedMedia](~~98467~~) operation to upload image watermarks.
          * *   You can configure a callback for [ImageUploadComplete](~~91968~~) to receive notifications about the image upload status.
          *
          * @param request CreateUploadImageRequest
          * @return CreateUploadImageResponse
         */
        public async Task<CreateUploadImageResponse> CreateUploadImageAsync(CreateUploadImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUploadImageWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation to obtain upload URLs and credentials for video and audio files. For more information, see [Upload URLs and credentials](~~55397~~).
          * *   You can call this operation only to obtain the upload URLs and credentials for media files and create media assets in ApsaraVideo VOD. You cannot call this operation to upload media files. For more information about how to upload media files by calling API operations, see [Upload media files by calling API operations](~~476208~~).
          * *   If the upload credential expires, call the [RefreshUploadVideo](~~55408~~) operation to obtain a new upload credential. The default validity period of an upload credential is 3,000 seconds.
          * *   You can configure a callback to receive an [event notification](~~55396~~) when an audio or video file is uploaded. Alternatively, after you upload an audio or video file, you can call the [GetMezzanineInfo](~~59624~~) operation to determine whether the upload is successful based on the value of the Status response parameter.
          * *   The VideoId parameter that is returned after you call this operation can be used for media processing or lifecycle management of media assets.
          * *   You must obtain a URL and a credential before you upload a media file to ApsaraVideo VOD. ApsaraVideo VOD supports multiple upload methods. Each method has different requirements on upload URLs and credentials. For more information, see [Upload URLs and credentials](~~55397~~).
          *
          * @param request CreateUploadVideoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateUploadVideoResponse
         */
        public CreateUploadVideoResponse CreateUploadVideoWithOptions(CreateUploadVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                query["FileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageLocation))
            {
                query["StorageLocation"] = request.StorageLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateGroupId))
            {
                query["TemplateGroupId"] = request.TemplateGroupId;
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
                Action = "CreateUploadVideo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUploadVideoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation to obtain upload URLs and credentials for video and audio files. For more information, see [Upload URLs and credentials](~~55397~~).
          * *   You can call this operation only to obtain the upload URLs and credentials for media files and create media assets in ApsaraVideo VOD. You cannot call this operation to upload media files. For more information about how to upload media files by calling API operations, see [Upload media files by calling API operations](~~476208~~).
          * *   If the upload credential expires, call the [RefreshUploadVideo](~~55408~~) operation to obtain a new upload credential. The default validity period of an upload credential is 3,000 seconds.
          * *   You can configure a callback to receive an [event notification](~~55396~~) when an audio or video file is uploaded. Alternatively, after you upload an audio or video file, you can call the [GetMezzanineInfo](~~59624~~) operation to determine whether the upload is successful based on the value of the Status response parameter.
          * *   The VideoId parameter that is returned after you call this operation can be used for media processing or lifecycle management of media assets.
          * *   You must obtain a URL and a credential before you upload a media file to ApsaraVideo VOD. ApsaraVideo VOD supports multiple upload methods. Each method has different requirements on upload URLs and credentials. For more information, see [Upload URLs and credentials](~~55397~~).
          *
          * @param request CreateUploadVideoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateUploadVideoResponse
         */
        public async Task<CreateUploadVideoResponse> CreateUploadVideoWithOptionsAsync(CreateUploadVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                query["FileSize"] = request.FileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageLocation))
            {
                query["StorageLocation"] = request.StorageLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateGroupId))
            {
                query["TemplateGroupId"] = request.TemplateGroupId;
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
                Action = "CreateUploadVideo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUploadVideoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation to obtain upload URLs and credentials for video and audio files. For more information, see [Upload URLs and credentials](~~55397~~).
          * *   You can call this operation only to obtain the upload URLs and credentials for media files and create media assets in ApsaraVideo VOD. You cannot call this operation to upload media files. For more information about how to upload media files by calling API operations, see [Upload media files by calling API operations](~~476208~~).
          * *   If the upload credential expires, call the [RefreshUploadVideo](~~55408~~) operation to obtain a new upload credential. The default validity period of an upload credential is 3,000 seconds.
          * *   You can configure a callback to receive an [event notification](~~55396~~) when an audio or video file is uploaded. Alternatively, after you upload an audio or video file, you can call the [GetMezzanineInfo](~~59624~~) operation to determine whether the upload is successful based on the value of the Status response parameter.
          * *   The VideoId parameter that is returned after you call this operation can be used for media processing or lifecycle management of media assets.
          * *   You must obtain a URL and a credential before you upload a media file to ApsaraVideo VOD. ApsaraVideo VOD supports multiple upload methods. Each method has different requirements on upload URLs and credentials. For more information, see [Upload URLs and credentials](~~55397~~).
          *
          * @param request CreateUploadVideoRequest
          * @return CreateUploadVideoResponse
         */
        public CreateUploadVideoResponse CreateUploadVideo(CreateUploadVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUploadVideoWithOptions(request, runtime);
        }

        /**
          * *   You can call this operation to obtain upload URLs and credentials for video and audio files. For more information, see [Upload URLs and credentials](~~55397~~).
          * *   You can call this operation only to obtain the upload URLs and credentials for media files and create media assets in ApsaraVideo VOD. You cannot call this operation to upload media files. For more information about how to upload media files by calling API operations, see [Upload media files by calling API operations](~~476208~~).
          * *   If the upload credential expires, call the [RefreshUploadVideo](~~55408~~) operation to obtain a new upload credential. The default validity period of an upload credential is 3,000 seconds.
          * *   You can configure a callback to receive an [event notification](~~55396~~) when an audio or video file is uploaded. Alternatively, after you upload an audio or video file, you can call the [GetMezzanineInfo](~~59624~~) operation to determine whether the upload is successful based on the value of the Status response parameter.
          * *   The VideoId parameter that is returned after you call this operation can be used for media processing or lifecycle management of media assets.
          * *   You must obtain a URL and a credential before you upload a media file to ApsaraVideo VOD. ApsaraVideo VOD supports multiple upload methods. Each method has different requirements on upload URLs and credentials. For more information, see [Upload URLs and credentials](~~55397~~).
          *
          * @param request CreateUploadVideoRequest
          * @return CreateUploadVideoResponse
         */
        public async Task<CreateUploadVideoResponse> CreateUploadVideoAsync(CreateUploadVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUploadVideoWithOptionsAsync(request, runtime);
        }

        public DecryptKMSDataKeyResponse DecryptKMSDataKeyWithOptions(DecryptKMSDataKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CipherText))
            {
                query["CipherText"] = request.CipherText;
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
                Action = "DecryptKMSDataKey",
                Version = "2017-03-21",
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

        public async Task<DecryptKMSDataKeyResponse> DecryptKMSDataKeyWithOptionsAsync(DecryptKMSDataKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CipherText))
            {
                query["CipherText"] = request.CipherText;
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
                Action = "DecryptKMSDataKey",
                Version = "2017-03-21",
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

        public DecryptKMSDataKeyResponse DecryptKMSDataKey(DecryptKMSDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DecryptKMSDataKeyWithOptions(request, runtime);
        }

        public async Task<DecryptKMSDataKeyResponse> DecryptKMSDataKeyAsync(DecryptKMSDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DecryptKMSDataKeyWithOptionsAsync(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   This operation deletes only information about images that are submitted for AI processing. The image files are not deleted.
          *
          * @param request DeleteAIImageInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAIImageInfosResponse
         */
        public DeleteAIImageInfosResponse DeleteAIImageInfosWithOptions(DeleteAIImageInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AIImageInfoIds))
            {
                query["AIImageInfoIds"] = request.AIImageInfoIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAIImageInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAIImageInfosResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   This operation deletes only information about images that are submitted for AI processing. The image files are not deleted.
          *
          * @param request DeleteAIImageInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAIImageInfosResponse
         */
        public async Task<DeleteAIImageInfosResponse> DeleteAIImageInfosWithOptionsAsync(DeleteAIImageInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AIImageInfoIds))
            {
                query["AIImageInfoIds"] = request.AIImageInfoIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAIImageInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAIImageInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   This operation deletes only information about images that are submitted for AI processing. The image files are not deleted.
          *
          * @param request DeleteAIImageInfosRequest
          * @return DeleteAIImageInfosResponse
         */
        public DeleteAIImageInfosResponse DeleteAIImageInfos(DeleteAIImageInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAIImageInfosWithOptions(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   This operation deletes only information about images that are submitted for AI processing. The image files are not deleted.
          *
          * @param request DeleteAIImageInfosRequest
          * @return DeleteAIImageInfosResponse
         */
        public async Task<DeleteAIImageInfosResponse> DeleteAIImageInfosAsync(DeleteAIImageInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAIImageInfosWithOptionsAsync(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You cannot delete an AI template that is set as the default template.
          *
          * @param request DeleteAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAITemplateResponse
         */
        public DeleteAITemplateResponse DeleteAITemplateWithOptions(DeleteAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAITemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You cannot delete an AI template that is set as the default template.
          *
          * @param request DeleteAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAITemplateResponse
         */
        public async Task<DeleteAITemplateResponse> DeleteAITemplateWithOptionsAsync(DeleteAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAITemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You cannot delete an AI template that is set as the default template.
          *
          * @param request DeleteAITemplateRequest
          * @return DeleteAITemplateResponse
         */
        public DeleteAITemplateResponse DeleteAITemplate(DeleteAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAITemplateWithOptions(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You cannot delete an AI template that is set as the default template.
          *
          * @param request DeleteAITemplateRequest
          * @return DeleteAITemplateResponse
         */
        public async Task<DeleteAITemplateResponse> DeleteAITemplateAsync(DeleteAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAITemplateWithOptionsAsync(request, runtime);
        }

        /**
          * ## Usage note
          * Application with resources can not be deleted.
          *
          * @param request DeleteAppInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAppInfoResponse
         */
        public DeleteAppInfoResponse DeleteAppInfoWithOptions(DeleteAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Usage note
          * Application with resources can not be deleted.
          *
          * @param request DeleteAppInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAppInfoResponse
         */
        public async Task<DeleteAppInfoResponse> DeleteAppInfoWithOptionsAsync(DeleteAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Usage note
          * Application with resources can not be deleted.
          *
          * @param request DeleteAppInfoRequest
          * @return DeleteAppInfoResponse
         */
        public DeleteAppInfoResponse DeleteAppInfo(DeleteAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppInfoWithOptions(request, runtime);
        }

        /**
          * ## Usage note
          * Application with resources can not be deleted.
          *
          * @param request DeleteAppInfoRequest
          * @return DeleteAppInfoResponse
         */
        public async Task<DeleteAppInfoResponse> DeleteAppInfoAsync(DeleteAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppInfoWithOptionsAsync(request, runtime);
        }

        /**
          * This operation physically deletes auxiliary media assets. Deleted auxiliary media assets cannot be recovered. Exercise caution when you call this operation.
          *
          * @param request DeleteAttachedMediaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAttachedMediaResponse
         */
        public DeleteAttachedMediaResponse DeleteAttachedMediaWithOptions(DeleteAttachedMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAttachedMedia",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAttachedMediaResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This operation physically deletes auxiliary media assets. Deleted auxiliary media assets cannot be recovered. Exercise caution when you call this operation.
          *
          * @param request DeleteAttachedMediaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteAttachedMediaResponse
         */
        public async Task<DeleteAttachedMediaResponse> DeleteAttachedMediaWithOptionsAsync(DeleteAttachedMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAttachedMedia",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAttachedMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This operation physically deletes auxiliary media assets. Deleted auxiliary media assets cannot be recovered. Exercise caution when you call this operation.
          *
          * @param request DeleteAttachedMediaRequest
          * @return DeleteAttachedMediaResponse
         */
        public DeleteAttachedMediaResponse DeleteAttachedMedia(DeleteAttachedMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAttachedMediaWithOptions(request, runtime);
        }

        /**
          * This operation physically deletes auxiliary media assets. Deleted auxiliary media assets cannot be recovered. Exercise caution when you call this operation.
          *
          * @param request DeleteAttachedMediaRequest
          * @return DeleteAttachedMediaResponse
         */
        public async Task<DeleteAttachedMediaResponse> DeleteAttachedMediaAsync(DeleteAttachedMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAttachedMediaWithOptionsAsync(request, runtime);
        }

        /**
          * > If a video category is deleted, its subcategories, including level 2 and level 3 categories, are also deleted. Exercise caution when you call this operation.
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
                Version = "2017-03-21",
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
          * > If a video category is deleted, its subcategories, including level 2 and level 3 categories, are also deleted. Exercise caution when you call this operation.
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
                Version = "2017-03-21",
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
          * > If a video category is deleted, its subcategories, including level 2 and level 3 categories, are also deleted. Exercise caution when you call this operation.
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
          * > If a video category is deleted, its subcategories, including level 2 and level 3 categories, are also deleted. Exercise caution when you call this operation.
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
          * > This operation deletes only the information about animated stickers, but not the animated stickers themselves.
          *
          * @param request DeleteDynamicImageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteDynamicImageResponse
         */
        public DeleteDynamicImageResponse DeleteDynamicImageWithOptions(DeleteDynamicImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicImageIds))
            {
                query["DynamicImageIds"] = request.DynamicImageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDynamicImage",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDynamicImageResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > This operation deletes only the information about animated stickers, but not the animated stickers themselves.
          *
          * @param request DeleteDynamicImageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteDynamicImageResponse
         */
        public async Task<DeleteDynamicImageResponse> DeleteDynamicImageWithOptionsAsync(DeleteDynamicImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicImageIds))
            {
                query["DynamicImageIds"] = request.DynamicImageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDynamicImage",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDynamicImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > This operation deletes only the information about animated stickers, but not the animated stickers themselves.
          *
          * @param request DeleteDynamicImageRequest
          * @return DeleteDynamicImageResponse
         */
        public DeleteDynamicImageResponse DeleteDynamicImage(DeleteDynamicImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDynamicImageWithOptions(request, runtime);
        }

        /**
          * > This operation deletes only the information about animated stickers, but not the animated stickers themselves.
          *
          * @param request DeleteDynamicImageRequest
          * @return DeleteDynamicImageResponse
         */
        public async Task<DeleteDynamicImageResponse> DeleteDynamicImageAsync(DeleteDynamicImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDynamicImageWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to delete multiple online editing projects at a time.
          * ### QPS limits
          * You can call this operation up to 20 times per second per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request DeleteEditingProjectRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteEditingProjectResponse
         */
        public DeleteEditingProjectResponse DeleteEditingProjectWithOptions(DeleteEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                query["ProjectIds"] = request.ProjectIds;
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
                Action = "DeleteEditingProject",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEditingProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to delete multiple online editing projects at a time.
          * ### QPS limits
          * You can call this operation up to 20 times per second per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request DeleteEditingProjectRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteEditingProjectResponse
         */
        public async Task<DeleteEditingProjectResponse> DeleteEditingProjectWithOptionsAsync(DeleteEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                query["ProjectIds"] = request.ProjectIds;
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
                Action = "DeleteEditingProject",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEditingProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to delete multiple online editing projects at a time.
          * ### QPS limits
          * You can call this operation up to 20 times per second per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request DeleteEditingProjectRequest
          * @return DeleteEditingProjectResponse
         */
        public DeleteEditingProjectResponse DeleteEditingProject(DeleteEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEditingProjectWithOptions(request, runtime);
        }

        /**
          * You can call this operation to delete multiple online editing projects at a time.
          * ### QPS limits
          * You can call this operation up to 20 times per second per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request DeleteEditingProjectRequest
          * @return DeleteEditingProjectResponse
         */
        public async Task<DeleteEditingProjectResponse> DeleteEditingProjectAsync(DeleteEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEditingProjectWithOptionsAsync(request, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "DeleteEditingProjectMaterials",
                Version = "2017-03-21",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "DeleteEditingProjectMaterials",
                Version = "2017-03-21",
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

        /**
          * *   After you call this operation to delete an image, the source file is permanently deleted and cannot be recovered. If some images are cached on Alibaba Cloud CDN points of presence (POPs), the image URLs do not immediately become invalid.
          * *   You can call this operation to delete uploaded images and video snapshots.
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request DeleteImageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteImageResponse
         */
        public DeleteImageResponse DeleteImageWithOptions(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteImageType))
            {
                query["DeleteImageType"] = request.DeleteImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIds))
            {
                query["ImageIds"] = request.ImageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLs))
            {
                query["ImageURLs"] = request.ImageURLs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImage",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImageResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   After you call this operation to delete an image, the source file is permanently deleted and cannot be recovered. If some images are cached on Alibaba Cloud CDN points of presence (POPs), the image URLs do not immediately become invalid.
          * *   You can call this operation to delete uploaded images and video snapshots.
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request DeleteImageRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteImageResponse
         */
        public async Task<DeleteImageResponse> DeleteImageWithOptionsAsync(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteImageType))
            {
                query["DeleteImageType"] = request.DeleteImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIds))
            {
                query["ImageIds"] = request.ImageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLs))
            {
                query["ImageURLs"] = request.ImageURLs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImage",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   After you call this operation to delete an image, the source file is permanently deleted and cannot be recovered. If some images are cached on Alibaba Cloud CDN points of presence (POPs), the image URLs do not immediately become invalid.
          * *   You can call this operation to delete uploaded images and video snapshots.
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request DeleteImageRequest
          * @return DeleteImageResponse
         */
        public DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImageWithOptions(request, runtime);
        }

        /**
          * *   After you call this operation to delete an image, the source file is permanently deleted and cannot be recovered. If some images are cached on Alibaba Cloud CDN points of presence (POPs), the image URLs do not immediately become invalid.
          * *   You can call this operation to delete uploaded images and video snapshots.
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request DeleteImageRequest
          * @return DeleteImageResponse
         */
        public async Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImageWithOptionsAsync(request, runtime);
        }

        /**
          * > For more information, see [Overview](~~55627~~).
          *
          * @param request DeleteMessageCallbackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteMessageCallbackResponse
         */
        public DeleteMessageCallbackResponse DeleteMessageCallbackWithOptions(DeleteMessageCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMessageCallback",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMessageCallbackResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > For more information, see [Overview](~~55627~~).
          *
          * @param request DeleteMessageCallbackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteMessageCallbackResponse
         */
        public async Task<DeleteMessageCallbackResponse> DeleteMessageCallbackWithOptionsAsync(DeleteMessageCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMessageCallback",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMessageCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > For more information, see [Overview](~~55627~~).
          *
          * @param request DeleteMessageCallbackRequest
          * @return DeleteMessageCallbackResponse
         */
        public DeleteMessageCallbackResponse DeleteMessageCallback(DeleteMessageCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMessageCallbackWithOptions(request, runtime);
        }

        /**
          * > For more information, see [Overview](~~55627~~).
          *
          * @param request DeleteMessageCallbackRequest
          * @return DeleteMessageCallbackResponse
         */
        public async Task<DeleteMessageCallbackResponse> DeleteMessageCallbackAsync(DeleteMessageCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMessageCallbackWithOptionsAsync(request, runtime);
        }

        /**
          * All media processing operations in ApsaraVideo VOD, such as transcoding, snapshot capture, and content moderation, are performed on mezzanine files. If you delete the mezzanine files, you cannot perform follow-up media processing operations. Exercise caution when you call this operation.
          *
          * @param request DeleteMezzaninesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteMezzaninesResponse
         */
        public DeleteMezzaninesResponse DeleteMezzaninesWithOptions(DeleteMezzaninesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIds))
            {
                query["VideoIds"] = request.VideoIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMezzanines",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMezzaninesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * All media processing operations in ApsaraVideo VOD, such as transcoding, snapshot capture, and content moderation, are performed on mezzanine files. If you delete the mezzanine files, you cannot perform follow-up media processing operations. Exercise caution when you call this operation.
          *
          * @param request DeleteMezzaninesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteMezzaninesResponse
         */
        public async Task<DeleteMezzaninesResponse> DeleteMezzaninesWithOptionsAsync(DeleteMezzaninesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIds))
            {
                query["VideoIds"] = request.VideoIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMezzanines",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMezzaninesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * All media processing operations in ApsaraVideo VOD, such as transcoding, snapshot capture, and content moderation, are performed on mezzanine files. If you delete the mezzanine files, you cannot perform follow-up media processing operations. Exercise caution when you call this operation.
          *
          * @param request DeleteMezzaninesRequest
          * @return DeleteMezzaninesResponse
         */
        public DeleteMezzaninesResponse DeleteMezzanines(DeleteMezzaninesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMezzaninesWithOptions(request, runtime);
        }

        /**
          * All media processing operations in ApsaraVideo VOD, such as transcoding, snapshot capture, and content moderation, are performed on mezzanine files. If you delete the mezzanine files, you cannot perform follow-up media processing operations. Exercise caution when you call this operation.
          *
          * @param request DeleteMezzaninesRequest
          * @return DeleteMezzaninesResponse
         */
        public async Task<DeleteMezzaninesResponse> DeleteMezzaninesAsync(DeleteMezzaninesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMezzaninesWithOptionsAsync(request, runtime);
        }

        /**
          * * In a multipart upload, fragments may be generated if the upload fails. In most cases, the fragments are automatically deleted after seven days. You can call this operation to delete the generated fragments after the upload is successful or fails.
          * * This operation does not delete the source file or transcoded file, but deletes only the fragments generated during the upload.
          * * If you call the [DeleteVideo](~~52837~~) operation, the entire video file is deleted, including the generated fragments.
          *
          * @param request DeleteMultipartUploadRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteMultipartUploadResponse
         */
        public DeleteMultipartUploadResponse DeleteMultipartUploadWithOptions(DeleteMultipartUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMultipartUpload",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMultipartUploadResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * In a multipart upload, fragments may be generated if the upload fails. In most cases, the fragments are automatically deleted after seven days. You can call this operation to delete the generated fragments after the upload is successful or fails.
          * * This operation does not delete the source file or transcoded file, but deletes only the fragments generated during the upload.
          * * If you call the [DeleteVideo](~~52837~~) operation, the entire video file is deleted, including the generated fragments.
          *
          * @param request DeleteMultipartUploadRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteMultipartUploadResponse
         */
        public async Task<DeleteMultipartUploadResponse> DeleteMultipartUploadWithOptionsAsync(DeleteMultipartUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMultipartUpload",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMultipartUploadResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * In a multipart upload, fragments may be generated if the upload fails. In most cases, the fragments are automatically deleted after seven days. You can call this operation to delete the generated fragments after the upload is successful or fails.
          * * This operation does not delete the source file or transcoded file, but deletes only the fragments generated during the upload.
          * * If you call the [DeleteVideo](~~52837~~) operation, the entire video file is deleted, including the generated fragments.
          *
          * @param request DeleteMultipartUploadRequest
          * @return DeleteMultipartUploadResponse
         */
        public DeleteMultipartUploadResponse DeleteMultipartUpload(DeleteMultipartUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMultipartUploadWithOptions(request, runtime);
        }

        /**
          * * In a multipart upload, fragments may be generated if the upload fails. In most cases, the fragments are automatically deleted after seven days. You can call this operation to delete the generated fragments after the upload is successful or fails.
          * * This operation does not delete the source file or transcoded file, but deletes only the fragments generated during the upload.
          * * If you call the [DeleteVideo](~~52837~~) operation, the entire video file is deleted, including the generated fragments.
          *
          * @param request DeleteMultipartUploadRequest
          * @return DeleteMultipartUploadResponse
         */
        public async Task<DeleteMultipartUploadResponse> DeleteMultipartUploadAsync(DeleteMultipartUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMultipartUploadWithOptionsAsync(request, runtime);
        }

        public DeleteStreamResponse DeleteStreamWithOptions(DeleteStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStream",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStreamResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteStreamResponse> DeleteStreamWithOptionsAsync(DeleteStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIds))
            {
                query["JobIds"] = request.JobIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStream",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStreamResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteStreamResponse DeleteStream(DeleteStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStreamWithOptions(request, runtime);
        }

        public async Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStreamWithOptionsAsync(request, runtime);
        }

        /**
          * *   You cannot call this operation to delete the default transcoding template. You can delete the transcoding template when it is no longer specified as the default one.
          * *   For security purposes, you cannot add, modify, or delete transcoding templates in a transcoding template group that is locked. To check whether a transcoding template group is locked, call the [GetTranscodeTemplateGroup](~~GetTranscodeTemplateGroup~~) operation and obtain the Locked parameter from the response. To modify transcoding templates within a locked transcoding template group, you must call the [UpdateTranscodeTemplateGroup](~~UpdateTranscodeTemplateGroup~~) operation to unlock the transcoding template group first.
          *
          * @param request DeleteTranscodeTemplateGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteTranscodeTemplateGroupResponse
         */
        public DeleteTranscodeTemplateGroupResponse DeleteTranscodeTemplateGroupWithOptions(DeleteTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDelGroup))
            {
                query["ForceDelGroup"] = request.ForceDelGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateGroupId))
            {
                query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateIds))
            {
                query["TranscodeTemplateIds"] = request.TranscodeTemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTranscodeTemplateGroup",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTranscodeTemplateGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You cannot call this operation to delete the default transcoding template. You can delete the transcoding template when it is no longer specified as the default one.
          * *   For security purposes, you cannot add, modify, or delete transcoding templates in a transcoding template group that is locked. To check whether a transcoding template group is locked, call the [GetTranscodeTemplateGroup](~~GetTranscodeTemplateGroup~~) operation and obtain the Locked parameter from the response. To modify transcoding templates within a locked transcoding template group, you must call the [UpdateTranscodeTemplateGroup](~~UpdateTranscodeTemplateGroup~~) operation to unlock the transcoding template group first.
          *
          * @param request DeleteTranscodeTemplateGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteTranscodeTemplateGroupResponse
         */
        public async Task<DeleteTranscodeTemplateGroupResponse> DeleteTranscodeTemplateGroupWithOptionsAsync(DeleteTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDelGroup))
            {
                query["ForceDelGroup"] = request.ForceDelGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateGroupId))
            {
                query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateIds))
            {
                query["TranscodeTemplateIds"] = request.TranscodeTemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTranscodeTemplateGroup",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTranscodeTemplateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You cannot call this operation to delete the default transcoding template. You can delete the transcoding template when it is no longer specified as the default one.
          * *   For security purposes, you cannot add, modify, or delete transcoding templates in a transcoding template group that is locked. To check whether a transcoding template group is locked, call the [GetTranscodeTemplateGroup](~~GetTranscodeTemplateGroup~~) operation and obtain the Locked parameter from the response. To modify transcoding templates within a locked transcoding template group, you must call the [UpdateTranscodeTemplateGroup](~~UpdateTranscodeTemplateGroup~~) operation to unlock the transcoding template group first.
          *
          * @param request DeleteTranscodeTemplateGroupRequest
          * @return DeleteTranscodeTemplateGroupResponse
         */
        public DeleteTranscodeTemplateGroupResponse DeleteTranscodeTemplateGroup(DeleteTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTranscodeTemplateGroupWithOptions(request, runtime);
        }

        /**
          * *   You cannot call this operation to delete the default transcoding template. You can delete the transcoding template when it is no longer specified as the default one.
          * *   For security purposes, you cannot add, modify, or delete transcoding templates in a transcoding template group that is locked. To check whether a transcoding template group is locked, call the [GetTranscodeTemplateGroup](~~GetTranscodeTemplateGroup~~) operation and obtain the Locked parameter from the response. To modify transcoding templates within a locked transcoding template group, you must call the [UpdateTranscodeTemplateGroup](~~UpdateTranscodeTemplateGroup~~) operation to unlock the transcoding template group first.
          *
          * @param request DeleteTranscodeTemplateGroupRequest
          * @return DeleteTranscodeTemplateGroupResponse
         */
        public async Task<DeleteTranscodeTemplateGroupResponse> DeleteTranscodeTemplateGroupAsync(DeleteTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTranscodeTemplateGroupWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation physically deletes videos. Deleted videos cannot be recovered. Exercise caution when you call this operation.
          * *   You can call this operation to delete multiple videos at a time.
          * *   When you delete a video, its source file, transcoded stream file, and thumbnail screenshot are also deleted. However, the Alibaba Cloud Content Delivery Network (CDN) cache is not refreshed simultaneously. You can use the refresh feature in the ApsaraVideo VOD console to clear garbage data on CDN nodes. For more information, see [Refresh and prefetch](~~86098~~).
          *
          * @param request DeleteVideoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteVideoResponse
         */
        public DeleteVideoResponse DeleteVideoWithOptions(DeleteVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIds))
            {
                query["VideoIds"] = request.VideoIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVideo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVideoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation physically deletes videos. Deleted videos cannot be recovered. Exercise caution when you call this operation.
          * *   You can call this operation to delete multiple videos at a time.
          * *   When you delete a video, its source file, transcoded stream file, and thumbnail screenshot are also deleted. However, the Alibaba Cloud Content Delivery Network (CDN) cache is not refreshed simultaneously. You can use the refresh feature in the ApsaraVideo VOD console to clear garbage data on CDN nodes. For more information, see [Refresh and prefetch](~~86098~~).
          *
          * @param request DeleteVideoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteVideoResponse
         */
        public async Task<DeleteVideoResponse> DeleteVideoWithOptionsAsync(DeleteVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIds))
            {
                query["VideoIds"] = request.VideoIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVideo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVideoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation physically deletes videos. Deleted videos cannot be recovered. Exercise caution when you call this operation.
          * *   You can call this operation to delete multiple videos at a time.
          * *   When you delete a video, its source file, transcoded stream file, and thumbnail screenshot are also deleted. However, the Alibaba Cloud Content Delivery Network (CDN) cache is not refreshed simultaneously. You can use the refresh feature in the ApsaraVideo VOD console to clear garbage data on CDN nodes. For more information, see [Refresh and prefetch](~~86098~~).
          *
          * @param request DeleteVideoRequest
          * @return DeleteVideoResponse
         */
        public DeleteVideoResponse DeleteVideo(DeleteVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVideoWithOptions(request, runtime);
        }

        /**
          * *   This operation physically deletes videos. Deleted videos cannot be recovered. Exercise caution when you call this operation.
          * *   You can call this operation to delete multiple videos at a time.
          * *   When you delete a video, its source file, transcoded stream file, and thumbnail screenshot are also deleted. However, the Alibaba Cloud Content Delivery Network (CDN) cache is not refreshed simultaneously. You can use the refresh feature in the ApsaraVideo VOD console to clear garbage data on CDN nodes. For more information, see [Refresh and prefetch](~~86098~~).
          *
          * @param request DeleteVideoRequest
          * @return DeleteVideoResponse
         */
        public async Task<DeleteVideoResponse> DeleteVideoAsync(DeleteVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVideoWithOptionsAsync(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   After a domain name for CDN is removed from ApsaraVideo VOD, the domain name becomes unavailable. Proceed with caution. We recommend that you restore the A record at your DNS service provider before you remove the domain name for CDN.
          * > *   After you call this operation to remove a domain name for CDN from ApsaraVideo VOD, all records that are related to the domain name are deleted. If you only want to disable a domain name for CDN, call the [BatchStopVodDomain](~~120208~~) operation.
          *
          * @param request DeleteVodDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteVodDomainResponse
         */
        public DeleteVodDomainResponse DeleteVodDomainWithOptions(DeleteVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVodDomain",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVodDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   After a domain name for CDN is removed from ApsaraVideo VOD, the domain name becomes unavailable. Proceed with caution. We recommend that you restore the A record at your DNS service provider before you remove the domain name for CDN.
          * > *   After you call this operation to remove a domain name for CDN from ApsaraVideo VOD, all records that are related to the domain name are deleted. If you only want to disable a domain name for CDN, call the [BatchStopVodDomain](~~120208~~) operation.
          *
          * @param request DeleteVodDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteVodDomainResponse
         */
        public async Task<DeleteVodDomainResponse> DeleteVodDomainWithOptionsAsync(DeleteVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVodDomain",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVodDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   After a domain name for CDN is removed from ApsaraVideo VOD, the domain name becomes unavailable. Proceed with caution. We recommend that you restore the A record at your DNS service provider before you remove the domain name for CDN.
          * > *   After you call this operation to remove a domain name for CDN from ApsaraVideo VOD, all records that are related to the domain name are deleted. If you only want to disable a domain name for CDN, call the [BatchStopVodDomain](~~120208~~) operation.
          *
          * @param request DeleteVodDomainRequest
          * @return DeleteVodDomainResponse
         */
        public DeleteVodDomainResponse DeleteVodDomain(DeleteVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVodDomainWithOptions(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   After a domain name for CDN is removed from ApsaraVideo VOD, the domain name becomes unavailable. Proceed with caution. We recommend that you restore the A record at your DNS service provider before you remove the domain name for CDN.
          * > *   After you call this operation to remove a domain name for CDN from ApsaraVideo VOD, all records that are related to the domain name are deleted. If you only want to disable a domain name for CDN, call the [BatchStopVodDomain](~~120208~~) operation.
          *
          * @param request DeleteVodDomainRequest
          * @return DeleteVodDomainResponse
         */
        public async Task<DeleteVodDomainResponse> DeleteVodDomainAsync(DeleteVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVodDomainWithOptionsAsync(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   After the configurations of a domain name for CDN are deleted, the domain name becomes unavailable. We recommend that you restore the A record at your DNS service provider before you delete the configurations of the domain name for CDN.
          * > *   After you call this operation to delete the configurations of a domain name for CDN, all records that are related to the domain name are deleted. If you only want to disable a domain name for CDN, call the [BatchStopVodDomain](~~120208~~) operation.
          *
          * @param request DeleteVodSpecificConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteVodSpecificConfigResponse
         */
        public DeleteVodSpecificConfigResponse DeleteVodSpecificConfigWithOptions(DeleteVodSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVodSpecificConfig",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVodSpecificConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   After the configurations of a domain name for CDN are deleted, the domain name becomes unavailable. We recommend that you restore the A record at your DNS service provider before you delete the configurations of the domain name for CDN.
          * > *   After you call this operation to delete the configurations of a domain name for CDN, all records that are related to the domain name are deleted. If you only want to disable a domain name for CDN, call the [BatchStopVodDomain](~~120208~~) operation.
          *
          * @param request DeleteVodSpecificConfigRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteVodSpecificConfigResponse
         */
        public async Task<DeleteVodSpecificConfigResponse> DeleteVodSpecificConfigWithOptionsAsync(DeleteVodSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigId))
            {
                query["ConfigId"] = request.ConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Env))
            {
                query["Env"] = request.Env;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVodSpecificConfig",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVodSpecificConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   After the configurations of a domain name for CDN are deleted, the domain name becomes unavailable. We recommend that you restore the A record at your DNS service provider before you delete the configurations of the domain name for CDN.
          * > *   After you call this operation to delete the configurations of a domain name for CDN, all records that are related to the domain name are deleted. If you only want to disable a domain name for CDN, call the [BatchStopVodDomain](~~120208~~) operation.
          *
          * @param request DeleteVodSpecificConfigRequest
          * @return DeleteVodSpecificConfigResponse
         */
        public DeleteVodSpecificConfigResponse DeleteVodSpecificConfig(DeleteVodSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVodSpecificConfigWithOptions(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   After the configurations of a domain name for CDN are deleted, the domain name becomes unavailable. We recommend that you restore the A record at your DNS service provider before you delete the configurations of the domain name for CDN.
          * > *   After you call this operation to delete the configurations of a domain name for CDN, all records that are related to the domain name are deleted. If you only want to disable a domain name for CDN, call the [BatchStopVodDomain](~~120208~~) operation.
          *
          * @param request DeleteVodSpecificConfigRequest
          * @return DeleteVodSpecificConfigResponse
         */
        public async Task<DeleteVodSpecificConfigResponse> DeleteVodSpecificConfigAsync(DeleteVodSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVodSpecificConfigWithOptionsAsync(request, runtime);
        }

        public DeleteVodTemplateResponse DeleteVodTemplateWithOptions(DeleteVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VodTemplateId))
            {
                query["VodTemplateId"] = request.VodTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVodTemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVodTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteVodTemplateResponse> DeleteVodTemplateWithOptionsAsync(DeleteVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VodTemplateId))
            {
                query["VodTemplateId"] = request.VodTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVodTemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVodTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteVodTemplateResponse DeleteVodTemplate(DeleteVodTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVodTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteVodTemplateResponse> DeleteVodTemplateAsync(DeleteVodTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVodTemplateWithOptionsAsync(request, runtime);
        }

        /**
          * > *   The default watermark cannot be deleted.
          * > *   If you delete a watermark, its mezzanine file is also physically deleted and cannot be recovered.
          *
          * @param request DeleteWatermarkRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteWatermarkResponse
         */
        public DeleteWatermarkResponse DeleteWatermarkWithOptions(DeleteWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkId))
            {
                query["WatermarkId"] = request.WatermarkId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWatermark",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWatermarkResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > *   The default watermark cannot be deleted.
          * > *   If you delete a watermark, its mezzanine file is also physically deleted and cannot be recovered.
          *
          * @param request DeleteWatermarkRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteWatermarkResponse
         */
        public async Task<DeleteWatermarkResponse> DeleteWatermarkWithOptionsAsync(DeleteWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkId))
            {
                query["WatermarkId"] = request.WatermarkId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWatermark",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWatermarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > *   The default watermark cannot be deleted.
          * > *   If you delete a watermark, its mezzanine file is also physically deleted and cannot be recovered.
          *
          * @param request DeleteWatermarkRequest
          * @return DeleteWatermarkResponse
         */
        public DeleteWatermarkResponse DeleteWatermark(DeleteWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWatermarkWithOptions(request, runtime);
        }

        /**
          * > *   The default watermark cannot be deleted.
          * > *   If you delete a watermark, its mezzanine file is also physically deleted and cannot be recovered.
          *
          * @param request DeleteWatermarkRequest
          * @return DeleteWatermarkResponse
         */
        public async Task<DeleteWatermarkResponse> DeleteWatermarkAsync(DeleteWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWatermarkWithOptionsAsync(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can query playback statistics on top 1,000 videos at most on a specified day. By default, top videos are sorted in descending order based on video views.
          * > *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * > *   Playback statistics for the previous day are generated at 09:00 on the current day, in UTC+8.
          * > *   You can query data that is generated since January 1, 2018. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayTopVideosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribePlayTopVideosResponse
         */
        public DescribePlayTopVideosResponse DescribePlayTopVideosWithOptions(DescribePlayTopVideosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDate))
            {
                query["BizDate"] = request.BizDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribePlayTopVideos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayTopVideosResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can query playback statistics on top 1,000 videos at most on a specified day. By default, top videos are sorted in descending order based on video views.
          * > *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * > *   Playback statistics for the previous day are generated at 09:00 on the current day, in UTC+8.
          * > *   You can query data that is generated since January 1, 2018. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayTopVideosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribePlayTopVideosResponse
         */
        public async Task<DescribePlayTopVideosResponse> DescribePlayTopVideosWithOptionsAsync(DescribePlayTopVideosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDate))
            {
                query["BizDate"] = request.BizDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
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
                Action = "DescribePlayTopVideos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayTopVideosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can query playback statistics on top 1,000 videos at most on a specified day. By default, top videos are sorted in descending order based on video views.
          * > *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * > *   Playback statistics for the previous day are generated at 09:00 on the current day, in UTC+8.
          * > *   You can query data that is generated since January 1, 2018. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayTopVideosRequest
          * @return DescribePlayTopVideosResponse
         */
        public DescribePlayTopVideosResponse DescribePlayTopVideos(DescribePlayTopVideosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayTopVideosWithOptions(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can query playback statistics on top 1,000 videos at most on a specified day. By default, top videos are sorted in descending order based on video views.
          * > *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * > *   Playback statistics for the previous day are generated at 09:00 on the current day, in UTC+8.
          * > *   You can query data that is generated since January 1, 2018. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayTopVideosRequest
          * @return DescribePlayTopVideosResponse
         */
        public async Task<DescribePlayTopVideosResponse> DescribePlayTopVideosAsync(DescribePlayTopVideosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayTopVideosWithOptionsAsync(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * > *   Playback statistics for the previous day are generated at 09:00 on the current day, in UTC+8.
          * > *   You can query data that is generated since January 1, 2018. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayUserAvgRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribePlayUserAvgResponse
         */
        public DescribePlayUserAvgResponse DescribePlayUserAvgWithOptions(DescribePlayUserAvgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayUserAvg",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayUserAvgResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * > *   Playback statistics for the previous day are generated at 09:00 on the current day, in UTC+8.
          * > *   You can query data that is generated since January 1, 2018. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayUserAvgRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribePlayUserAvgResponse
         */
        public async Task<DescribePlayUserAvgResponse> DescribePlayUserAvgWithOptionsAsync(DescribePlayUserAvgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayUserAvg",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayUserAvgResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * > *   Playback statistics for the previous day are generated at 09:00 on the current day, in UTC+8.
          * > *   You can query data that is generated since January 1, 2018. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayUserAvgRequest
          * @return DescribePlayUserAvgResponse
         */
        public DescribePlayUserAvgResponse DescribePlayUserAvg(DescribePlayUserAvgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayUserAvgWithOptions(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * > *   Playback statistics for the previous day are generated at 09:00 on the current day, in UTC+8.
          * > *   You can query data that is generated since January 1, 2018. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayUserAvgRequest
          * @return DescribePlayUserAvgResponse
         */
        public async Task<DescribePlayUserAvgResponse> DescribePlayUserAvgAsync(DescribePlayUserAvgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayUserAvgWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * *   Playback statistics for the current day are generated at 09:00 (UTC+8) on the next day.
          * *   You can query data that is generated since January 1, 2018. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayUserTotalRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribePlayUserTotalResponse
         */
        public DescribePlayUserTotalResponse DescribePlayUserTotalWithOptions(DescribePlayUserTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayUserTotal",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayUserTotalResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * *   Playback statistics for the current day are generated at 09:00 (UTC+8) on the next day.
          * *   You can query data that is generated since January 1, 2018. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayUserTotalRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribePlayUserTotalResponse
         */
        public async Task<DescribePlayUserTotalResponse> DescribePlayUserTotalWithOptionsAsync(DescribePlayUserTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayUserTotal",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayUserTotalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * *   Playback statistics for the current day are generated at 09:00 (UTC+8) on the next day.
          * *   You can query data that is generated since January 1, 2018. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayUserTotalRequest
          * @return DescribePlayUserTotalResponse
         */
        public DescribePlayUserTotalResponse DescribePlayUserTotal(DescribePlayUserTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayUserTotalWithOptions(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * *   Playback statistics for the current day are generated at 09:00 (UTC+8) on the next day.
          * *   You can query data that is generated since January 1, 2018. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayUserTotalRequest
          * @return DescribePlayUserTotalResponse
         */
        public async Task<DescribePlayUserTotalResponse> DescribePlayUserTotalAsync(DescribePlayUserTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayUserTotalWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * *   Playback statistics for the current day are generated at 09:00 (UTC+8) on the next day.
          * *   You can query only data in the last 730 days. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayVideoStatisRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribePlayVideoStatisResponse
         */
        public DescribePlayVideoStatisResponse DescribePlayVideoStatisWithOptions(DescribePlayVideoStatisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayVideoStatis",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayVideoStatisResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * *   Playback statistics for the current day are generated at 09:00 (UTC+8) on the next day.
          * *   You can query only data in the last 730 days. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayVideoStatisRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribePlayVideoStatisResponse
         */
        public async Task<DescribePlayVideoStatisResponse> DescribePlayVideoStatisWithOptionsAsync(DescribePlayVideoStatisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlayVideoStatis",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlayVideoStatisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * *   Playback statistics for the current day are generated at 09:00 (UTC+8) on the next day.
          * *   You can query only data in the last 730 days. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayVideoStatisRequest
          * @return DescribePlayVideoStatisResponse
         */
        public DescribePlayVideoStatisResponse DescribePlayVideoStatis(DescribePlayVideoStatisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayVideoStatisWithOptions(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can call this operation to query only playback statistics collected on videos that are played by using ApsaraVideo Player SDKs.
          * *   Playback statistics for the current day are generated at 09:00 (UTC+8) on the next day.
          * *   You can query only data in the last 730 days. The maximum time range to query is 180 days.
          *
          * @param request DescribePlayVideoStatisRequest
          * @return DescribePlayVideoStatisResponse
         */
        public async Task<DescribePlayVideoStatisResponse> DescribePlayVideoStatisAsync(DescribePlayVideoStatisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayVideoStatisWithOptionsAsync(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * >*   If the time range to query is less than or equal to seven days, the system returns the statistics collected on an hourly basis. If the time range to query is greater than seven days, the system returns the statistics collected on a daily basis. The maximum time range that you can specify to query is 31 days.
          *
          * @param request DescribeVodAIDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodAIDataResponse
         */
        public DescribeVodAIDataResponse DescribeVodAIDataWithOptions(DescribeVodAIDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AIType))
            {
                query["AIType"] = request.AIType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodAIData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodAIDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * >*   If the time range to query is less than or equal to seven days, the system returns the statistics collected on an hourly basis. If the time range to query is greater than seven days, the system returns the statistics collected on a daily basis. The maximum time range that you can specify to query is 31 days.
          *
          * @param request DescribeVodAIDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodAIDataResponse
         */
        public async Task<DescribeVodAIDataResponse> DescribeVodAIDataWithOptionsAsync(DescribeVodAIDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AIType))
            {
                query["AIType"] = request.AIType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodAIData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodAIDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * >*   If the time range to query is less than or equal to seven days, the system returns the statistics collected on an hourly basis. If the time range to query is greater than seven days, the system returns the statistics collected on a daily basis. The maximum time range that you can specify to query is 31 days.
          *
          * @param request DescribeVodAIDataRequest
          * @return DescribeVodAIDataResponse
         */
        public DescribeVodAIDataResponse DescribeVodAIData(DescribeVodAIDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodAIDataWithOptions(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * >*   If the time range to query is less than or equal to seven days, the system returns the statistics collected on an hourly basis. If the time range to query is greater than seven days, the system returns the statistics collected on a daily basis. The maximum time range that you can specify to query is 31 days.
          *
          * @param request DescribeVodAIDataRequest
          * @return DescribeVodAIDataResponse
         */
        public async Task<DescribeVodAIDataResponse> DescribeVodAIDataAsync(DescribeVodAIDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodAIDataWithOptionsAsync(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodCertificateListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodCertificateListResponse
         */
        public DescribeVodCertificateListResponse DescribeVodCertificateListWithOptions(DescribeVodCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodCertificateList",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodCertificateListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodCertificateListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodCertificateListResponse
         */
        public async Task<DescribeVodCertificateListResponse> DescribeVodCertificateListWithOptionsAsync(DescribeVodCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodCertificateList",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodCertificateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodCertificateListRequest
          * @return DescribeVodCertificateListResponse
         */
        public DescribeVodCertificateListResponse DescribeVodCertificateList(DescribeVodCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodCertificateListWithOptions(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodCertificateListRequest
          * @return DescribeVodCertificateListResponse
         */
        public async Task<DescribeVodCertificateListResponse> DescribeVodCertificateListAsync(DescribeVodCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodCertificateListWithOptionsAsync(request, runtime);
        }

        /**
          * If you specify neither the StartTime parameter nor the EndTime parameter, the data in the last 24 hours is queried. Alternatively, you can specify both the StartTime and EndTime parameters to query data that is generated in the specified duration. You can query data for the last 90 days at most.
          *
          * @param request DescribeVodDomainBpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainBpsDataResponse
         */
        public DescribeVodDomainBpsDataResponse DescribeVodDomainBpsDataWithOptions(DescribeVodDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainBpsData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainBpsDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If you specify neither the StartTime parameter nor the EndTime parameter, the data in the last 24 hours is queried. Alternatively, you can specify both the StartTime and EndTime parameters to query data that is generated in the specified duration. You can query data for the last 90 days at most.
          *
          * @param request DescribeVodDomainBpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainBpsDataResponse
         */
        public async Task<DescribeVodDomainBpsDataResponse> DescribeVodDomainBpsDataWithOptionsAsync(DescribeVodDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainBpsData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainBpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If you specify neither the StartTime parameter nor the EndTime parameter, the data in the last 24 hours is queried. Alternatively, you can specify both the StartTime and EndTime parameters to query data that is generated in the specified duration. You can query data for the last 90 days at most.
          *
          * @param request DescribeVodDomainBpsDataRequest
          * @return DescribeVodDomainBpsDataResponse
         */
        public DescribeVodDomainBpsDataResponse DescribeVodDomainBpsData(DescribeVodDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainBpsDataWithOptions(request, runtime);
        }

        /**
          * If you specify neither the StartTime parameter nor the EndTime parameter, the data in the last 24 hours is queried. Alternatively, you can specify both the StartTime and EndTime parameters to query data that is generated in the specified duration. You can query data for the last 90 days at most.
          *
          * @param request DescribeVodDomainBpsDataRequest
          * @return DescribeVodDomainBpsDataResponse
         */
        public async Task<DescribeVodDomainBpsDataResponse> DescribeVodDomainBpsDataAsync(DescribeVodDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainBpsDataWithOptionsAsync(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodDomainCertificateInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainCertificateInfoResponse
         */
        public DescribeVodDomainCertificateInfoResponse DescribeVodDomainCertificateInfoWithOptions(DescribeVodDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainCertificateInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainCertificateInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodDomainCertificateInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainCertificateInfoResponse
         */
        public async Task<DescribeVodDomainCertificateInfoResponse> DescribeVodDomainCertificateInfoWithOptionsAsync(DescribeVodDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainCertificateInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainCertificateInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodDomainCertificateInfoRequest
          * @return DescribeVodDomainCertificateInfoResponse
         */
        public DescribeVodDomainCertificateInfoResponse DescribeVodDomainCertificateInfo(DescribeVodDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainCertificateInfoWithOptions(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodDomainCertificateInfoRequest
          * @return DescribeVodDomainCertificateInfoResponse
         */
        public async Task<DescribeVodDomainCertificateInfoResponse> DescribeVodDomainCertificateInfoAsync(DescribeVodDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainCertificateInfoWithOptionsAsync(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodDomainConfigsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainConfigsResponse
         */
        public DescribeVodDomainConfigsResponse DescribeVodDomainConfigsWithOptions(DescribeVodDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNames))
            {
                query["FunctionNames"] = request.FunctionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainConfigs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodDomainConfigsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainConfigsResponse
         */
        public async Task<DescribeVodDomainConfigsResponse> DescribeVodDomainConfigsWithOptionsAsync(DescribeVodDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNames))
            {
                query["FunctionNames"] = request.FunctionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainConfigs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodDomainConfigsRequest
          * @return DescribeVodDomainConfigsResponse
         */
        public DescribeVodDomainConfigsResponse DescribeVodDomainConfigs(DescribeVodDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainConfigsWithOptions(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodDomainConfigsRequest
          * @return DescribeVodDomainConfigsResponse
         */
        public async Task<DescribeVodDomainConfigsResponse> DescribeVodDomainConfigsAsync(DescribeVodDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainConfigsWithOptionsAsync(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodDomainDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainDetailResponse
         */
        public DescribeVodDomainDetailResponse DescribeVodDomainDetailWithOptions(DescribeVodDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainDetail",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodDomainDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainDetailResponse
         */
        public async Task<DescribeVodDomainDetailResponse> DescribeVodDomainDetailWithOptionsAsync(DescribeVodDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainDetail",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodDomainDetailRequest
          * @return DescribeVodDomainDetailResponse
         */
        public DescribeVodDomainDetailResponse DescribeVodDomainDetail(DescribeVodDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainDetailWithOptions(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request DescribeVodDomainDetailRequest
          * @return DescribeVodDomainDetailResponse
         */
        public async Task<DescribeVodDomainDetailResponse> DescribeVodDomainDetailAsync(DescribeVodDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainDetailWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   For more information about the log format and latency, see [Download logs](~~86099~~).
          * *   If you specify neither StartTime nor EndTime, the log data in the previous 24 hours is queried.
          * *   You can specify both StartTime and EndTime to query the log data that is generated in the specified time range.
          * ### [](#qps)QPS limits
          * You can call this operation up to 100 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations](~~342790~~).
          *
          * @param request DescribeVodDomainLogRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainLogResponse
         */
        public DescribeVodDomainLogResponse DescribeVodDomainLogWithOptions(DescribeVodDomainLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainLog",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainLogResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   For more information about the log format and latency, see [Download logs](~~86099~~).
          * *   If you specify neither StartTime nor EndTime, the log data in the previous 24 hours is queried.
          * *   You can specify both StartTime and EndTime to query the log data that is generated in the specified time range.
          * ### [](#qps)QPS limits
          * You can call this operation up to 100 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations](~~342790~~).
          *
          * @param request DescribeVodDomainLogRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainLogResponse
         */
        public async Task<DescribeVodDomainLogResponse> DescribeVodDomainLogWithOptionsAsync(DescribeVodDomainLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainLog",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   For more information about the log format and latency, see [Download logs](~~86099~~).
          * *   If you specify neither StartTime nor EndTime, the log data in the previous 24 hours is queried.
          * *   You can specify both StartTime and EndTime to query the log data that is generated in the specified time range.
          * ### [](#qps)QPS limits
          * You can call this operation up to 100 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations](~~342790~~).
          *
          * @param request DescribeVodDomainLogRequest
          * @return DescribeVodDomainLogResponse
         */
        public DescribeVodDomainLogResponse DescribeVodDomainLog(DescribeVodDomainLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainLogWithOptions(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   For more information about the log format and latency, see [Download logs](~~86099~~).
          * *   If you specify neither StartTime nor EndTime, the log data in the previous 24 hours is queried.
          * *   You can specify both StartTime and EndTime to query the log data that is generated in the specified time range.
          * ### [](#qps)QPS limits
          * You can call this operation up to 100 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations](~~342790~~).
          *
          * @param request DescribeVodDomainLogRequest
          * @return DescribeVodDomainLogResponse
         */
        public async Task<DescribeVodDomainLogResponse> DescribeVodDomainLogAsync(DescribeVodDomainLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainLogWithOptionsAsync(request, runtime);
        }

        /**
          * * This operation is available only in the **China (Shanghai)** region.
          * * ApsaraVideo VOD stores the origin bandwidth data for 90 days before the data is deleted.
          * * If you do not set the `StartTime` or `EndTime` parameter, the request returns the data collected in the last 24 hours. If you set both the `StartTime` and `EndTime` parameters, the request returns the data collected within the specified time range.
          * * You can specify a maximum of 500 domain names in a request. Separate multiple domain names with commas (,). If you specify multiple domain names in a request, aggregation results are returned.
          * ### Time granularity
          * The time granularity supported by the Interval parameter varies based on the time range per query specified by using `StartTime` and `EndTime`. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Time range per query (days)|Historical data available (days)|Data delay|
          * |---|---|---|---|
          * |5 minutes|(0, 3\\]|93|15 minutes|
          * |1 hour|(3, 31\\]|186|4 hours|
          * |1 day|(31, 366\\]|366|04:00 on the next day|
          *
          * @param request DescribeVodDomainSrcBpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainSrcBpsDataResponse
         */
        public DescribeVodDomainSrcBpsDataResponse DescribeVodDomainSrcBpsDataWithOptions(DescribeVodDomainSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainSrcBpsData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainSrcBpsDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * This operation is available only in the **China (Shanghai)** region.
          * * ApsaraVideo VOD stores the origin bandwidth data for 90 days before the data is deleted.
          * * If you do not set the `StartTime` or `EndTime` parameter, the request returns the data collected in the last 24 hours. If you set both the `StartTime` and `EndTime` parameters, the request returns the data collected within the specified time range.
          * * You can specify a maximum of 500 domain names in a request. Separate multiple domain names with commas (,). If you specify multiple domain names in a request, aggregation results are returned.
          * ### Time granularity
          * The time granularity supported by the Interval parameter varies based on the time range per query specified by using `StartTime` and `EndTime`. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Time range per query (days)|Historical data available (days)|Data delay|
          * |---|---|---|---|
          * |5 minutes|(0, 3\\]|93|15 minutes|
          * |1 hour|(3, 31\\]|186|4 hours|
          * |1 day|(31, 366\\]|366|04:00 on the next day|
          *
          * @param request DescribeVodDomainSrcBpsDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainSrcBpsDataResponse
         */
        public async Task<DescribeVodDomainSrcBpsDataResponse> DescribeVodDomainSrcBpsDataWithOptionsAsync(DescribeVodDomainSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainSrcBpsData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainSrcBpsDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * This operation is available only in the **China (Shanghai)** region.
          * * ApsaraVideo VOD stores the origin bandwidth data for 90 days before the data is deleted.
          * * If you do not set the `StartTime` or `EndTime` parameter, the request returns the data collected in the last 24 hours. If you set both the `StartTime` and `EndTime` parameters, the request returns the data collected within the specified time range.
          * * You can specify a maximum of 500 domain names in a request. Separate multiple domain names with commas (,). If you specify multiple domain names in a request, aggregation results are returned.
          * ### Time granularity
          * The time granularity supported by the Interval parameter varies based on the time range per query specified by using `StartTime` and `EndTime`. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Time range per query (days)|Historical data available (days)|Data delay|
          * |---|---|---|---|
          * |5 minutes|(0, 3\\]|93|15 minutes|
          * |1 hour|(3, 31\\]|186|4 hours|
          * |1 day|(31, 366\\]|366|04:00 on the next day|
          *
          * @param request DescribeVodDomainSrcBpsDataRequest
          * @return DescribeVodDomainSrcBpsDataResponse
         */
        public DescribeVodDomainSrcBpsDataResponse DescribeVodDomainSrcBpsData(DescribeVodDomainSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainSrcBpsDataWithOptions(request, runtime);
        }

        /**
          * * This operation is available only in the **China (Shanghai)** region.
          * * ApsaraVideo VOD stores the origin bandwidth data for 90 days before the data is deleted.
          * * If you do not set the `StartTime` or `EndTime` parameter, the request returns the data collected in the last 24 hours. If you set both the `StartTime` and `EndTime` parameters, the request returns the data collected within the specified time range.
          * * You can specify a maximum of 500 domain names in a request. Separate multiple domain names with commas (,). If you specify multiple domain names in a request, aggregation results are returned.
          * ### Time granularity
          * The time granularity supported by the Interval parameter varies based on the time range per query specified by using `StartTime` and `EndTime`. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Time range per query (days)|Historical data available (days)|Data delay|
          * |---|---|---|---|
          * |5 minutes|(0, 3\\]|93|15 minutes|
          * |1 hour|(3, 31\\]|186|4 hours|
          * |1 day|(31, 366\\]|366|04:00 on the next day|
          *
          * @param request DescribeVodDomainSrcBpsDataRequest
          * @return DescribeVodDomainSrcBpsDataResponse
         */
        public async Task<DescribeVodDomainSrcBpsDataResponse> DescribeVodDomainSrcBpsDataAsync(DescribeVodDomainSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainSrcBpsDataWithOptionsAsync(request, runtime);
        }

        /**
          * * This operation is available only in the **China (Shanghai)** region.
          * * ApsaraVideo VOD stores the origin traffic data for 90 days before the data is deleted.
          * * If you do not set the `StartTime` or `EndTime` parameter, the request returns the data collected in the last 24 hours. If you set both the `StartTime` and `EndTime` parameters, the request returns the data collected within the specified time range.
          * * You can specify a maximum of 500 domain names in a request. Separate multiple domain names with commas (,). If you specify multiple domain names in a request, aggregation results are returned.
          * ### Time granularity
          * The time granularity supported by the Interval parameter varies based on the time range per query specified by using `StartTime` and `EndTime`. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Time range per query (days)|Historical data available (days)|Data delay|
          * |---|---|---|---|
          * |5 minutes|(0, 3\\]|93|15 minutes|
          * |1 hour|(3, 31\\]|186|4 hours|
          * |1 day|(31, 366\\]|366|04:00 on the next day|
          *
          * @param request DescribeVodDomainSrcTrafficDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainSrcTrafficDataResponse
         */
        public DescribeVodDomainSrcTrafficDataResponse DescribeVodDomainSrcTrafficDataWithOptions(DescribeVodDomainSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainSrcTrafficData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainSrcTrafficDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * * This operation is available only in the **China (Shanghai)** region.
          * * ApsaraVideo VOD stores the origin traffic data for 90 days before the data is deleted.
          * * If you do not set the `StartTime` or `EndTime` parameter, the request returns the data collected in the last 24 hours. If you set both the `StartTime` and `EndTime` parameters, the request returns the data collected within the specified time range.
          * * You can specify a maximum of 500 domain names in a request. Separate multiple domain names with commas (,). If you specify multiple domain names in a request, aggregation results are returned.
          * ### Time granularity
          * The time granularity supported by the Interval parameter varies based on the time range per query specified by using `StartTime` and `EndTime`. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Time range per query (days)|Historical data available (days)|Data delay|
          * |---|---|---|---|
          * |5 minutes|(0, 3\\]|93|15 minutes|
          * |1 hour|(3, 31\\]|186|4 hours|
          * |1 day|(31, 366\\]|366|04:00 on the next day|
          *
          * @param request DescribeVodDomainSrcTrafficDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainSrcTrafficDataResponse
         */
        public async Task<DescribeVodDomainSrcTrafficDataResponse> DescribeVodDomainSrcTrafficDataWithOptionsAsync(DescribeVodDomainSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainSrcTrafficData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainSrcTrafficDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * * This operation is available only in the **China (Shanghai)** region.
          * * ApsaraVideo VOD stores the origin traffic data for 90 days before the data is deleted.
          * * If you do not set the `StartTime` or `EndTime` parameter, the request returns the data collected in the last 24 hours. If you set both the `StartTime` and `EndTime` parameters, the request returns the data collected within the specified time range.
          * * You can specify a maximum of 500 domain names in a request. Separate multiple domain names with commas (,). If you specify multiple domain names in a request, aggregation results are returned.
          * ### Time granularity
          * The time granularity supported by the Interval parameter varies based on the time range per query specified by using `StartTime` and `EndTime`. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Time range per query (days)|Historical data available (days)|Data delay|
          * |---|---|---|---|
          * |5 minutes|(0, 3\\]|93|15 minutes|
          * |1 hour|(3, 31\\]|186|4 hours|
          * |1 day|(31, 366\\]|366|04:00 on the next day|
          *
          * @param request DescribeVodDomainSrcTrafficDataRequest
          * @return DescribeVodDomainSrcTrafficDataResponse
         */
        public DescribeVodDomainSrcTrafficDataResponse DescribeVodDomainSrcTrafficData(DescribeVodDomainSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainSrcTrafficDataWithOptions(request, runtime);
        }

        /**
          * * This operation is available only in the **China (Shanghai)** region.
          * * ApsaraVideo VOD stores the origin traffic data for 90 days before the data is deleted.
          * * If you do not set the `StartTime` or `EndTime` parameter, the request returns the data collected in the last 24 hours. If you set both the `StartTime` and `EndTime` parameters, the request returns the data collected within the specified time range.
          * * You can specify a maximum of 500 domain names in a request. Separate multiple domain names with commas (,). If you specify multiple domain names in a request, aggregation results are returned.
          * ### Time granularity
          * The time granularity supported by the Interval parameter varies based on the time range per query specified by using `StartTime` and `EndTime`. The following table describes the time period within which historical data is available and the data delay.
          * |Time granularity|Time range per query (days)|Historical data available (days)|Data delay|
          * |---|---|---|---|
          * |5 minutes|(0, 3\\]|93|15 minutes|
          * |1 hour|(3, 31\\]|186|4 hours|
          * |1 day|(31, 366\\]|366|04:00 on the next day|
          *
          * @param request DescribeVodDomainSrcTrafficDataRequest
          * @return DescribeVodDomainSrcTrafficDataResponse
         */
        public async Task<DescribeVodDomainSrcTrafficDataResponse> DescribeVodDomainSrcTrafficDataAsync(DescribeVodDomainSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainSrcTrafficDataWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can specify multiple accelerated domain names in a request.
          * *   If you do not specify the StartTime or EndTime parameter, data of the last 24 hours is returned. You can specify the StartTime and EndTime parameters to query data that is generated in the specified time range. You can query data of the last 90 days.
          * ### QPS limit
          * You can call this operation up to 100 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on API operations](~~342790~~).
          *
          * @param request DescribeVodDomainTrafficDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainTrafficDataResponse
         */
        public DescribeVodDomainTrafficDataResponse DescribeVodDomainTrafficDataWithOptions(DescribeVodDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainTrafficData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainTrafficDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can specify multiple accelerated domain names in a request.
          * *   If you do not specify the StartTime or EndTime parameter, data of the last 24 hours is returned. You can specify the StartTime and EndTime parameters to query data that is generated in the specified time range. You can query data of the last 90 days.
          * ### QPS limit
          * You can call this operation up to 100 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on API operations](~~342790~~).
          *
          * @param request DescribeVodDomainTrafficDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainTrafficDataResponse
         */
        public async Task<DescribeVodDomainTrafficDataResponse> DescribeVodDomainTrafficDataWithOptionsAsync(DescribeVodDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspNameEn))
            {
                query["IspNameEn"] = request.IspNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationNameEn))
            {
                query["LocationNameEn"] = request.LocationNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainTrafficData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainTrafficDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can specify multiple accelerated domain names in a request.
          * *   If you do not specify the StartTime or EndTime parameter, data of the last 24 hours is returned. You can specify the StartTime and EndTime parameters to query data that is generated in the specified time range. You can query data of the last 90 days.
          * ### QPS limit
          * You can call this operation up to 100 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on API operations](~~342790~~).
          *
          * @param request DescribeVodDomainTrafficDataRequest
          * @return DescribeVodDomainTrafficDataResponse
         */
        public DescribeVodDomainTrafficDataResponse DescribeVodDomainTrafficData(DescribeVodDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainTrafficDataWithOptions(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can specify multiple accelerated domain names in a request.
          * *   If you do not specify the StartTime or EndTime parameter, data of the last 24 hours is returned. You can specify the StartTime and EndTime parameters to query data that is generated in the specified time range. You can query data of the last 90 days.
          * ### QPS limit
          * You can call this operation up to 100 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on API operations](~~342790~~).
          *
          * @param request DescribeVodDomainTrafficDataRequest
          * @return DescribeVodDomainTrafficDataResponse
         */
        public async Task<DescribeVodDomainTrafficDataResponse> DescribeVodDomainTrafficDataAsync(DescribeVodDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainTrafficDataWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can specify up to 100 accelerated domain names in a request. Separate multiple domain names with commas (,). If you do not specify an accelerated domain name, the data of all accelerated domain names within your Alibaba Cloud account is returned.
          * *   You can query data in the last year. The maximum time range that can be queried is three months. If you specify a time range of one to three days, the system returns data on an hourly basis. If you specify a time range of four days or more, the system returns data on a daily basis.
          *
          * @param request DescribeVodDomainUsageDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainUsageDataResponse
         */
        public DescribeVodDomainUsageDataResponse DescribeVodDomainUsageDataWithOptions(DescribeVodDomainUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Field))
            {
                query["Field"] = request.Field;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeVodDomainUsageData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainUsageDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can specify up to 100 accelerated domain names in a request. Separate multiple domain names with commas (,). If you do not specify an accelerated domain name, the data of all accelerated domain names within your Alibaba Cloud account is returned.
          * *   You can query data in the last year. The maximum time range that can be queried is three months. If you specify a time range of one to three days, the system returns data on an hourly basis. If you specify a time range of four days or more, the system returns data on a daily basis.
          *
          * @param request DescribeVodDomainUsageDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodDomainUsageDataResponse
         */
        public async Task<DescribeVodDomainUsageDataResponse> DescribeVodDomainUsageDataWithOptionsAsync(DescribeVodDomainUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Field))
            {
                query["Field"] = request.Field;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
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
                Action = "DescribeVodDomainUsageData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainUsageDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can specify up to 100 accelerated domain names in a request. Separate multiple domain names with commas (,). If you do not specify an accelerated domain name, the data of all accelerated domain names within your Alibaba Cloud account is returned.
          * *   You can query data in the last year. The maximum time range that can be queried is three months. If you specify a time range of one to three days, the system returns data on an hourly basis. If you specify a time range of four days or more, the system returns data on a daily basis.
          *
          * @param request DescribeVodDomainUsageDataRequest
          * @return DescribeVodDomainUsageDataResponse
         */
        public DescribeVodDomainUsageDataResponse DescribeVodDomainUsageData(DescribeVodDomainUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainUsageDataWithOptions(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can specify up to 100 accelerated domain names in a request. Separate multiple domain names with commas (,). If you do not specify an accelerated domain name, the data of all accelerated domain names within your Alibaba Cloud account is returned.
          * *   You can query data in the last year. The maximum time range that can be queried is three months. If you specify a time range of one to three days, the system returns data on an hourly basis. If you specify a time range of four days or more, the system returns data on a daily basis.
          *
          * @param request DescribeVodDomainUsageDataRequest
          * @return DescribeVodDomainUsageDataResponse
         */
        public async Task<DescribeVodDomainUsageDataResponse> DescribeVodDomainUsageDataAsync(DescribeVodDomainUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainUsageDataWithOptionsAsync(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh content and the [PreloadVodObjectCaches](~~69211~~) operation to prefetch content.
          *
          * @param request DescribeVodRefreshQuotaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodRefreshQuotaResponse
         */
        public DescribeVodRefreshQuotaResponse DescribeVodRefreshQuotaWithOptions(DescribeVodRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodRefreshQuota",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodRefreshQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh content and the [PreloadVodObjectCaches](~~69211~~) operation to prefetch content.
          *
          * @param request DescribeVodRefreshQuotaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodRefreshQuotaResponse
         */
        public async Task<DescribeVodRefreshQuotaResponse> DescribeVodRefreshQuotaWithOptionsAsync(DescribeVodRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodRefreshQuota",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodRefreshQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh content and the [PreloadVodObjectCaches](~~69211~~) operation to prefetch content.
          *
          * @param request DescribeVodRefreshQuotaRequest
          * @return DescribeVodRefreshQuotaResponse
         */
        public DescribeVodRefreshQuotaResponse DescribeVodRefreshQuota(DescribeVodRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodRefreshQuotaWithOptions(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh content and the [PreloadVodObjectCaches](~~69211~~) operation to prefetch content.
          *
          * @param request DescribeVodRefreshQuotaRequest
          * @return DescribeVodRefreshQuotaResponse
         */
        public async Task<DescribeVodRefreshQuotaResponse> DescribeVodRefreshQuotaAsync(DescribeVodRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodRefreshQuotaWithOptionsAsync(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * >*   If you do not specify the TaskId or ObjectPath parameter, the data in the last three days is returned on the first page. By default, one page displays a maximum of 20 entries. You can specify the TaskId and ObjectPath parameters at the same time.
          *
          * @param request DescribeVodRefreshTasksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodRefreshTasksResponse
         */
        public DescribeVodRefreshTasksResponse DescribeVodRefreshTasksWithOptions(DescribeVodRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectPath))
            {
                query["ObjectPath"] = request.ObjectPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
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
                Action = "DescribeVodRefreshTasks",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodRefreshTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * >*   If you do not specify the TaskId or ObjectPath parameter, the data in the last three days is returned on the first page. By default, one page displays a maximum of 20 entries. You can specify the TaskId and ObjectPath parameters at the same time.
          *
          * @param request DescribeVodRefreshTasksRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodRefreshTasksResponse
         */
        public async Task<DescribeVodRefreshTasksResponse> DescribeVodRefreshTasksWithOptionsAsync(DescribeVodRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectPath))
            {
                query["ObjectPath"] = request.ObjectPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
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
                Action = "DescribeVodRefreshTasks",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodRefreshTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * >*   If you do not specify the TaskId or ObjectPath parameter, the data in the last three days is returned on the first page. By default, one page displays a maximum of 20 entries. You can specify the TaskId and ObjectPath parameters at the same time.
          *
          * @param request DescribeVodRefreshTasksRequest
          * @return DescribeVodRefreshTasksResponse
         */
        public DescribeVodRefreshTasksResponse DescribeVodRefreshTasks(DescribeVodRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodRefreshTasksWithOptions(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * >*   If you do not specify the TaskId or ObjectPath parameter, the data in the last three days is returned on the first page. By default, one page displays a maximum of 20 entries. You can specify the TaskId and ObjectPath parameters at the same time.
          *
          * @param request DescribeVodRefreshTasksRequest
          * @return DescribeVodRefreshTasksResponse
         */
        public async Task<DescribeVodRefreshTasksResponse> DescribeVodRefreshTasksAsync(DescribeVodRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodRefreshTasksWithOptionsAsync(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * >*   If the time range to query is less than or equal to seven days, the system returns the statistics collected on an hourly basis. If the time range to query is greater than seven days, the system returns the statistics collected on a daily basis. The maximum time range that you can specify to query is 31 days.
          *
          * @param request DescribeVodStorageDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodStorageDataResponse
         */
        public DescribeVodStorageDataResponse DescribeVodStorageDataWithOptions(DescribeVodStorageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                query["Storage"] = request.Storage;
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
                Action = "DescribeVodStorageData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodStorageDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * >*   If the time range to query is less than or equal to seven days, the system returns the statistics collected on an hourly basis. If the time range to query is greater than seven days, the system returns the statistics collected on a daily basis. The maximum time range that you can specify to query is 31 days.
          *
          * @param request DescribeVodStorageDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodStorageDataResponse
         */
        public async Task<DescribeVodStorageDataResponse> DescribeVodStorageDataWithOptionsAsync(DescribeVodStorageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                query["Storage"] = request.Storage;
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
                Action = "DescribeVodStorageData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodStorageDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * >*   If the time range to query is less than or equal to seven days, the system returns the statistics collected on an hourly basis. If the time range to query is greater than seven days, the system returns the statistics collected on a daily basis. The maximum time range that you can specify to query is 31 days.
          *
          * @param request DescribeVodStorageDataRequest
          * @return DescribeVodStorageDataResponse
         */
        public DescribeVodStorageDataResponse DescribeVodStorageData(DescribeVodStorageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodStorageDataWithOptions(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * >*   If the time range to query is less than or equal to seven days, the system returns the statistics collected on an hourly basis. If the time range to query is greater than seven days, the system returns the statistics collected on a daily basis. The maximum time range that you can specify to query is 31 days.
          *
          * @param request DescribeVodStorageDataRequest
          * @return DescribeVodStorageDataResponse
         */
        public async Task<DescribeVodStorageDataResponse> DescribeVodStorageDataAsync(DescribeVodStorageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodStorageDataWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   If the time range to query is less than or equal to seven days, the system returns the statistics collected on an hourly basis. If the time range to query is greater than seven days, the system returns the statistics collected on a daily basis. The maximum time range that you can specify to query is 31 days.
          *
          * @param request DescribeVodTranscodeDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodTranscodeDataResponse
         */
        public DescribeVodTranscodeDataResponse DescribeVodTranscodeDataWithOptions(DescribeVodTranscodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                query["Storage"] = request.Storage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodTranscodeData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodTranscodeDataResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   If the time range to query is less than or equal to seven days, the system returns the statistics collected on an hourly basis. If the time range to query is greater than seven days, the system returns the statistics collected on a daily basis. The maximum time range that you can specify to query is 31 days.
          *
          * @param request DescribeVodTranscodeDataRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeVodTranscodeDataResponse
         */
        public async Task<DescribeVodTranscodeDataResponse> DescribeVodTranscodeDataWithOptionsAsync(DescribeVodTranscodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Specification))
            {
                query["Specification"] = request.Specification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                query["Storage"] = request.Storage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodTranscodeData",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodTranscodeDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   If the time range to query is less than or equal to seven days, the system returns the statistics collected on an hourly basis. If the time range to query is greater than seven days, the system returns the statistics collected on a daily basis. The maximum time range that you can specify to query is 31 days.
          *
          * @param request DescribeVodTranscodeDataRequest
          * @return DescribeVodTranscodeDataResponse
         */
        public DescribeVodTranscodeDataResponse DescribeVodTranscodeData(DescribeVodTranscodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodTranscodeDataWithOptions(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   If the time range to query is less than or equal to seven days, the system returns the statistics collected on an hourly basis. If the time range to query is greater than seven days, the system returns the statistics collected on a daily basis. The maximum time range that you can specify to query is 31 days.
          *
          * @param request DescribeVodTranscodeDataRequest
          * @return DescribeVodTranscodeDataResponse
         */
        public async Task<DescribeVodTranscodeDataResponse> DescribeVodTranscodeDataAsync(DescribeVodTranscodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodTranscodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeVodUserDomainsResponse DescribeVodUserDomainsWithOptions(DescribeVodUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainSearchType))
            {
                query["DomainSearchType"] = request.DomainSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainStatus))
            {
                query["DomainStatus"] = request.DomainStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Action = "DescribeVodUserDomains",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodUserDomainsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVodUserDomainsResponse> DescribeVodUserDomainsWithOptionsAsync(DescribeVodUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainSearchType))
            {
                query["DomainSearchType"] = request.DomainSearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainStatus))
            {
                query["DomainStatus"] = request.DomainStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
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
                Action = "DescribeVodUserDomains",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodUserDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVodUserDomainsResponse DescribeVodUserDomains(DescribeVodUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodUserDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeVodUserDomainsResponse> DescribeVodUserDomainsAsync(DescribeVodUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodUserDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeVodVerifyContentResponse DescribeVodVerifyContentWithOptions(DescribeVodVerifyContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodVerifyContent",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodVerifyContentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVodVerifyContentResponse> DescribeVodVerifyContentWithOptionsAsync(DescribeVodVerifyContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodVerifyContent",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodVerifyContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVodVerifyContentResponse DescribeVodVerifyContent(DescribeVodVerifyContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodVerifyContentWithOptions(request, runtime);
        }

        public async Task<DescribeVodVerifyContentResponse> DescribeVodVerifyContentAsync(DescribeVodVerifyContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodVerifyContentWithOptionsAsync(request, runtime);
        }

        /**
          * You can grant a maximum of 10 application permissions to a RAM user or RAM role.
          *
          * @param request DetachAppPolicyFromIdentityRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DetachAppPolicyFromIdentityResponse
         */
        public DetachAppPolicyFromIdentityResponse DetachAppPolicyFromIdentityWithOptions(DetachAppPolicyFromIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityName))
            {
                query["IdentityName"] = request.IdentityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyNames))
            {
                query["PolicyNames"] = request.PolicyNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachAppPolicyFromIdentity",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachAppPolicyFromIdentityResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can grant a maximum of 10 application permissions to a RAM user or RAM role.
          *
          * @param request DetachAppPolicyFromIdentityRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DetachAppPolicyFromIdentityResponse
         */
        public async Task<DetachAppPolicyFromIdentityResponse> DetachAppPolicyFromIdentityWithOptionsAsync(DetachAppPolicyFromIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityName))
            {
                query["IdentityName"] = request.IdentityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyNames))
            {
                query["PolicyNames"] = request.PolicyNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachAppPolicyFromIdentity",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachAppPolicyFromIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can grant a maximum of 10 application permissions to a RAM user or RAM role.
          *
          * @param request DetachAppPolicyFromIdentityRequest
          * @return DetachAppPolicyFromIdentityResponse
         */
        public DetachAppPolicyFromIdentityResponse DetachAppPolicyFromIdentity(DetachAppPolicyFromIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachAppPolicyFromIdentityWithOptions(request, runtime);
        }

        /**
          * You can grant a maximum of 10 application permissions to a RAM user or RAM role.
          *
          * @param request DetachAppPolicyFromIdentityRequest
          * @return DetachAppPolicyFromIdentityResponse
         */
        public async Task<DetachAppPolicyFromIdentityResponse> DetachAppPolicyFromIdentityAsync(DetachAppPolicyFromIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachAppPolicyFromIdentityWithOptionsAsync(request, runtime);
        }

        public GenerateKMSDataKeyResponse GenerateKMSDataKeyWithOptions(GenerateKMSDataKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GenerateKMSDataKey",
                Version = "2017-03-21",
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

        public async Task<GenerateKMSDataKeyResponse> GenerateKMSDataKeyWithOptionsAsync(GenerateKMSDataKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GenerateKMSDataKey",
                Version = "2017-03-21",
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

        public GenerateKMSDataKeyResponse GenerateKMSDataKey(GenerateKMSDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateKMSDataKeyWithOptions(request, runtime);
        }

        public async Task<GenerateKMSDataKeyResponse> GenerateKMSDataKeyAsync(GenerateKMSDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateKMSDataKeyWithOptionsAsync(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   Call the [SubmitAIImageJob](~~SubmitAIImageJob~~) operation to submit image AI processing jobs before you call this operation to query image AI processing jobs.
          * *   You can query a maximum of 10 jobs of image AI processing in one request.
          *
          * @param request GetAIImageJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAIImageJobsResponse
         */
        public GetAIImageJobsResponse GetAIImageJobsWithOptions(GetAIImageJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAIImageJobs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAIImageJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   Call the [SubmitAIImageJob](~~SubmitAIImageJob~~) operation to submit image AI processing jobs before you call this operation to query image AI processing jobs.
          * *   You can query a maximum of 10 jobs of image AI processing in one request.
          *
          * @param request GetAIImageJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAIImageJobsResponse
         */
        public async Task<GetAIImageJobsResponse> GetAIImageJobsWithOptionsAsync(GetAIImageJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAIImageJobs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAIImageJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   Call the [SubmitAIImageJob](~~SubmitAIImageJob~~) operation to submit image AI processing jobs before you call this operation to query image AI processing jobs.
          * *   You can query a maximum of 10 jobs of image AI processing in one request.
          *
          * @param request GetAIImageJobsRequest
          * @return GetAIImageJobsResponse
         */
        public GetAIImageJobsResponse GetAIImageJobs(GetAIImageJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAIImageJobsWithOptions(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   Call the [SubmitAIImageJob](~~SubmitAIImageJob~~) operation to submit image AI processing jobs before you call this operation to query image AI processing jobs.
          * *   You can query a maximum of 10 jobs of image AI processing in one request.
          *
          * @param request GetAIImageJobsRequest
          * @return GetAIImageJobsResponse
         */
        public async Task<GetAIImageJobsResponse> GetAIImageJobsAsync(GetAIImageJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAIImageJobsWithOptionsAsync(request, runtime);
        }

        /**
          * ApsaraVideo VOD stores the snapshots of the intelligent review results free of charge for two weeks. After this period, the snapshots are automatically deleted.
          *
          * @param request GetAIMediaAuditJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAIMediaAuditJobResponse
         */
        public GetAIMediaAuditJobResponse GetAIMediaAuditJobWithOptions(GetAIMediaAuditJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAIMediaAuditJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAIMediaAuditJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ApsaraVideo VOD stores the snapshots of the intelligent review results free of charge for two weeks. After this period, the snapshots are automatically deleted.
          *
          * @param request GetAIMediaAuditJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAIMediaAuditJobResponse
         */
        public async Task<GetAIMediaAuditJobResponse> GetAIMediaAuditJobWithOptionsAsync(GetAIMediaAuditJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAIMediaAuditJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAIMediaAuditJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ApsaraVideo VOD stores the snapshots of the intelligent review results free of charge for two weeks. After this period, the snapshots are automatically deleted.
          *
          * @param request GetAIMediaAuditJobRequest
          * @return GetAIMediaAuditJobResponse
         */
        public GetAIMediaAuditJobResponse GetAIMediaAuditJob(GetAIMediaAuditJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAIMediaAuditJobWithOptions(request, runtime);
        }

        /**
          * ApsaraVideo VOD stores the snapshots of the intelligent review results free of charge for two weeks. After this period, the snapshots are automatically deleted.
          *
          * @param request GetAIMediaAuditJobRequest
          * @return GetAIMediaAuditJobResponse
         */
        public async Task<GetAIMediaAuditJobResponse> GetAIMediaAuditJobAsync(GetAIMediaAuditJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAIMediaAuditJobWithOptionsAsync(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   Before you call this operation to query details of an AI template, you must obtain the ID of the AI template.
          *
          * @param request GetAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAITemplateResponse
         */
        public GetAITemplateResponse GetAITemplateWithOptions(GetAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAITemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   Before you call this operation to query details of an AI template, you must obtain the ID of the AI template.
          *
          * @param request GetAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAITemplateResponse
         */
        public async Task<GetAITemplateResponse> GetAITemplateWithOptionsAsync(GetAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAITemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   Before you call this operation to query details of an AI template, you must obtain the ID of the AI template.
          *
          * @param request GetAITemplateRequest
          * @return GetAITemplateResponse
         */
        public GetAITemplateResponse GetAITemplate(GetAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAITemplateWithOptions(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   Before you call this operation to query details of an AI template, you must obtain the ID of the AI template.
          *
          * @param request GetAITemplateRequest
          * @return GetAITemplateResponse
         */
        public async Task<GetAITemplateResponse> GetAITemplateAsync(GetAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAITemplateWithOptionsAsync(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can obtain the smart tagging results by using the video ID.
          *
          * @param request GetAIVideoTagResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAIVideoTagResultResponse
         */
        public GetAIVideoTagResultResponse GetAIVideoTagResultWithOptions(GetAIVideoTagResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "GetAIVideoTagResult",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAIVideoTagResultResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can obtain the smart tagging results by using the video ID.
          *
          * @param request GetAIVideoTagResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAIVideoTagResultResponse
         */
        public async Task<GetAIVideoTagResultResponse> GetAIVideoTagResultWithOptionsAsync(GetAIVideoTagResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "GetAIVideoTagResult",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAIVideoTagResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can obtain the smart tagging results by using the video ID.
          *
          * @param request GetAIVideoTagResultRequest
          * @return GetAIVideoTagResultResponse
         */
        public GetAIVideoTagResultResponse GetAIVideoTagResult(GetAIVideoTagResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAIVideoTagResultWithOptions(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can obtain the smart tagging results by using the video ID.
          *
          * @param request GetAIVideoTagResultRequest
          * @return GetAIVideoTagResultResponse
         */
        public async Task<GetAIVideoTagResultResponse> GetAIVideoTagResultAsync(GetAIVideoTagResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAIVideoTagResultWithOptionsAsync(request, runtime);
        }

        /**
          * Supports batch query.
          *
          * @param request GetAppInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAppInfosResponse
         */
        public GetAppInfosResponse GetAppInfosWithOptions(GetAppInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppInfosResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Supports batch query.
          *
          * @param request GetAppInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAppInfosResponse
         */
        public async Task<GetAppInfosResponse> GetAppInfosWithOptionsAsync(GetAppInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Supports batch query.
          *
          * @param request GetAppInfosRequest
          * @return GetAppInfosResponse
         */
        public GetAppInfosResponse GetAppInfos(GetAppInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppInfosWithOptions(request, runtime);
        }

        /**
          * Supports batch query.
          *
          * @param request GetAppInfosRequest
          * @return GetAppInfosResponse
         */
        public async Task<GetAppInfosResponse> GetAppInfosAsync(GetAppInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppInfosWithOptionsAsync(request, runtime);
        }

        public GetAttachedMediaInfoResponse GetAttachedMediaInfoWithOptions(GetAttachedMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
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
                Action = "GetAttachedMediaInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttachedMediaInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAttachedMediaInfoResponse> GetAttachedMediaInfoWithOptionsAsync(GetAttachedMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
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
                Action = "GetAttachedMediaInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttachedMediaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAttachedMediaInfoResponse GetAttachedMediaInfo(GetAttachedMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAttachedMediaInfoWithOptions(request, runtime);
        }

        public async Task<GetAttachedMediaInfoResponse> GetAttachedMediaInfoAsync(GetAttachedMediaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAttachedMediaInfoWithOptionsAsync(request, runtime);
        }

        public GetAuditHistoryResponse GetAuditHistoryWithOptions(GetAuditHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuditHistory",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuditHistoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAuditHistoryResponse> GetAuditHistoryWithOptionsAsync(GetAuditHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAuditHistory",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuditHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAuditHistoryResponse GetAuditHistory(GetAuditHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAuditHistoryWithOptions(request, runtime);
        }

        public async Task<GetAuditHistoryResponse> GetAuditHistoryAsync(GetAuditHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAuditHistoryWithOptionsAsync(request, runtime);
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
                Version = "2017-03-21",
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
                Version = "2017-03-21",
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

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can query information only about the default AI template for automated review.
          *
          * @param request GetDefaultAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDefaultAITemplateResponse
         */
        public GetDefaultAITemplateResponse GetDefaultAITemplateWithOptions(GetDefaultAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetDefaultAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultAITemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can query information only about the default AI template for automated review.
          *
          * @param request GetDefaultAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDefaultAITemplateResponse
         */
        public async Task<GetDefaultAITemplateResponse> GetDefaultAITemplateWithOptionsAsync(GetDefaultAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetDefaultAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultAITemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can query information only about the default AI template for automated review.
          *
          * @param request GetDefaultAITemplateRequest
          * @return GetDefaultAITemplateResponse
         */
        public GetDefaultAITemplateResponse GetDefaultAITemplate(GetDefaultAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDefaultAITemplateWithOptions(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can query information only about the default AI template for automated review.
          *
          * @param request GetDefaultAITemplateRequest
          * @return GetDefaultAITemplateResponse
         */
        public async Task<GetDefaultAITemplateResponse> GetDefaultAITemplateAsync(GetDefaultAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDefaultAITemplateWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation to query the results of digital watermark extraction jobs that are created in the last two years.
          *
          * @param request GetDigitalWatermarkExtractResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDigitalWatermarkExtractResultResponse
         */
        public GetDigitalWatermarkExtractResultResponse GetDigitalWatermarkExtractResultWithOptions(GetDigitalWatermarkExtractResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractType))
            {
                query["ExtractType"] = request.ExtractType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "GetDigitalWatermarkExtractResult",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDigitalWatermarkExtractResultResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation to query the results of digital watermark extraction jobs that are created in the last two years.
          *
          * @param request GetDigitalWatermarkExtractResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetDigitalWatermarkExtractResultResponse
         */
        public async Task<GetDigitalWatermarkExtractResultResponse> GetDigitalWatermarkExtractResultWithOptionsAsync(GetDigitalWatermarkExtractResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractType))
            {
                query["ExtractType"] = request.ExtractType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "GetDigitalWatermarkExtractResult",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDigitalWatermarkExtractResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation to query the results of digital watermark extraction jobs that are created in the last two years.
          *
          * @param request GetDigitalWatermarkExtractResultRequest
          * @return GetDigitalWatermarkExtractResultResponse
         */
        public GetDigitalWatermarkExtractResultResponse GetDigitalWatermarkExtractResult(GetDigitalWatermarkExtractResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDigitalWatermarkExtractResultWithOptions(request, runtime);
        }

        /**
          * *   You can call this operation to query the results of digital watermark extraction jobs that are created in the last two years.
          *
          * @param request GetDigitalWatermarkExtractResultRequest
          * @return GetDigitalWatermarkExtractResultResponse
         */
        public async Task<GetDigitalWatermarkExtractResultResponse> GetDigitalWatermarkExtractResultAsync(GetDigitalWatermarkExtractResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDigitalWatermarkExtractResultWithOptionsAsync(request, runtime);
        }

        public GetEditingProjectResponse GetEditingProjectWithOptions(GetEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "GetEditingProject",
                Version = "2017-03-21",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "GetEditingProject",
                Version = "2017-03-21",
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

        /**
          * During editing, you can add materials to the timeline, but some of them may not be used.
          *
          * @param request GetEditingProjectMaterialsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetEditingProjectMaterialsResponse
         */
        public GetEditingProjectMaterialsResponse GetEditingProjectMaterialsWithOptions(GetEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialType))
            {
                query["MaterialType"] = request.MaterialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "GetEditingProjectMaterials",
                Version = "2017-03-21",
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
          * During editing, you can add materials to the timeline, but some of them may not be used.
          *
          * @param request GetEditingProjectMaterialsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetEditingProjectMaterialsResponse
         */
        public async Task<GetEditingProjectMaterialsResponse> GetEditingProjectMaterialsWithOptionsAsync(GetEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialType))
            {
                query["MaterialType"] = request.MaterialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "GetEditingProjectMaterials",
                Version = "2017-03-21",
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
          * During editing, you can add materials to the timeline, but some of them may not be used.
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
          * During editing, you can add materials to the timeline, but some of them may not be used.
          *
          * @param request GetEditingProjectMaterialsRequest
          * @return GetEditingProjectMaterialsResponse
         */
        public async Task<GetEditingProjectMaterialsResponse> GetEditingProjectMaterialsAsync(GetEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEditingProjectMaterialsWithOptionsAsync(request, runtime);
        }

        public GetImageInfoResponse GetImageInfoWithOptions(GetImageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
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
                Action = "GetImageInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetImageInfoResponse> GetImageInfoWithOptionsAsync(GetImageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
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
                Action = "GetImageInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetImageInfoResponse GetImageInfo(GetImageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageInfoWithOptions(request, runtime);
        }

        public async Task<GetImageInfoResponse> GetImageInfoAsync(GetImageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageInfoWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to query the basic information about multiple images at a time, such as the image title, type, creation time, tags, and URL.
          * ### Limits
          * You can call this operation up to 10 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on an API operation in ApsaraVideo Live](~~342790~~).
          *
          * @param request GetImageInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetImageInfosResponse
         */
        public GetImageInfosResponse GetImageInfosWithOptions(GetImageInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIds))
            {
                query["ImageIds"] = request.ImageIds;
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
                Action = "GetImageInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageInfosResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to query the basic information about multiple images at a time, such as the image title, type, creation time, tags, and URL.
          * ### Limits
          * You can call this operation up to 10 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on an API operation in ApsaraVideo Live](~~342790~~).
          *
          * @param request GetImageInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetImageInfosResponse
         */
        public async Task<GetImageInfosResponse> GetImageInfosWithOptionsAsync(GetImageInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIds))
            {
                query["ImageIds"] = request.ImageIds;
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
                Action = "GetImageInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to query the basic information about multiple images at a time, such as the image title, type, creation time, tags, and URL.
          * ### Limits
          * You can call this operation up to 10 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on an API operation in ApsaraVideo Live](~~342790~~).
          *
          * @param request GetImageInfosRequest
          * @return GetImageInfosResponse
         */
        public GetImageInfosResponse GetImageInfos(GetImageInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageInfosWithOptions(request, runtime);
        }

        /**
          * You can call this operation to query the basic information about multiple images at a time, such as the image title, type, creation time, tags, and URL.
          * ### Limits
          * You can call this operation up to 10 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on an API operation in ApsaraVideo Live](~~342790~~).
          *
          * @param request GetImageInfosRequest
          * @return GetImageInfosResponse
         */
        public async Task<GetImageInfosResponse> GetImageInfosAsync(GetImageInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageInfosWithOptionsAsync(request, runtime);
        }

        /**
          * If notifications for the [CreateAuditComplete](~~89576~~) event are configured, event notifications are sent to the callback URL after automated review is complete. You can call this operation to query the details of audio review results.
          *
          * @param request GetMediaAuditAudioResultDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMediaAuditAudioResultDetailResponse
         */
        public GetMediaAuditAudioResultDetailResponse GetMediaAuditAudioResultDetailWithOptions(GetMediaAuditAudioResultDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "GetMediaAuditAudioResultDetail",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaAuditAudioResultDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If notifications for the [CreateAuditComplete](~~89576~~) event are configured, event notifications are sent to the callback URL after automated review is complete. You can call this operation to query the details of audio review results.
          *
          * @param request GetMediaAuditAudioResultDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMediaAuditAudioResultDetailResponse
         */
        public async Task<GetMediaAuditAudioResultDetailResponse> GetMediaAuditAudioResultDetailWithOptionsAsync(GetMediaAuditAudioResultDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "GetMediaAuditAudioResultDetail",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaAuditAudioResultDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If notifications for the [CreateAuditComplete](~~89576~~) event are configured, event notifications are sent to the callback URL after automated review is complete. You can call this operation to query the details of audio review results.
          *
          * @param request GetMediaAuditAudioResultDetailRequest
          * @return GetMediaAuditAudioResultDetailResponse
         */
        public GetMediaAuditAudioResultDetailResponse GetMediaAuditAudioResultDetail(GetMediaAuditAudioResultDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaAuditAudioResultDetailWithOptions(request, runtime);
        }

        /**
          * If notifications for the [CreateAuditComplete](~~89576~~) event are configured, event notifications are sent to the callback URL after automated review is complete. You can call this operation to query the details of audio review results.
          *
          * @param request GetMediaAuditAudioResultDetailRequest
          * @return GetMediaAuditAudioResultDetailResponse
         */
        public async Task<GetMediaAuditAudioResultDetailResponse> GetMediaAuditAudioResultDetailAsync(GetMediaAuditAudioResultDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaAuditAudioResultDetailWithOptionsAsync(request, runtime);
        }

        public GetMediaAuditResultResponse GetMediaAuditResultWithOptions(GetMediaAuditResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMediaAuditResult",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaAuditResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMediaAuditResultResponse> GetMediaAuditResultWithOptionsAsync(GetMediaAuditResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMediaAuditResult",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaAuditResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMediaAuditResultResponse GetMediaAuditResult(GetMediaAuditResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaAuditResultWithOptions(request, runtime);
        }

        public async Task<GetMediaAuditResultResponse> GetMediaAuditResultAsync(GetMediaAuditResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaAuditResultWithOptionsAsync(request, runtime);
        }

        /**
          * - By default, only details of snapshots that violate content regulations and potentially violate content regulations are returned.
          * - ApsaraVideo VOD stores the snapshots in the automated review results free of charge for two weeks. After this period, the snapshots are automatically deleted.
          *
          * @param request GetMediaAuditResultDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMediaAuditResultDetailResponse
         */
        public GetMediaAuditResultDetailResponse GetMediaAuditResultDetailWithOptions(GetMediaAuditResultDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaAuditResultDetail",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaAuditResultDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
          * - By default, only details of snapshots that violate content regulations and potentially violate content regulations are returned.
          * - ApsaraVideo VOD stores the snapshots in the automated review results free of charge for two weeks. After this period, the snapshots are automatically deleted.
          *
          * @param request GetMediaAuditResultDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMediaAuditResultDetailResponse
         */
        public async Task<GetMediaAuditResultDetailResponse> GetMediaAuditResultDetailWithOptionsAsync(GetMediaAuditResultDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaAuditResultDetail",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaAuditResultDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * - By default, only details of snapshots that violate content regulations and potentially violate content regulations are returned.
          * - ApsaraVideo VOD stores the snapshots in the automated review results free of charge for two weeks. After this period, the snapshots are automatically deleted.
          *
          * @param request GetMediaAuditResultDetailRequest
          * @return GetMediaAuditResultDetailResponse
         */
        public GetMediaAuditResultDetailResponse GetMediaAuditResultDetail(GetMediaAuditResultDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaAuditResultDetailWithOptions(request, runtime);
        }

        /**
          * - By default, only details of snapshots that violate content regulations and potentially violate content regulations are returned.
          * - ApsaraVideo VOD stores the snapshots in the automated review results free of charge for two weeks. After this period, the snapshots are automatically deleted.
          *
          * @param request GetMediaAuditResultDetailRequest
          * @return GetMediaAuditResultDetailResponse
         */
        public async Task<GetMediaAuditResultDetailResponse> GetMediaAuditResultDetailAsync(GetMediaAuditResultDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaAuditResultDetailWithOptionsAsync(request, runtime);
        }

        public GetMediaAuditResultTimelineResponse GetMediaAuditResultTimelineWithOptions(GetMediaAuditResultTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMediaAuditResultTimeline",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaAuditResultTimelineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMediaAuditResultTimelineResponse> GetMediaAuditResultTimelineWithOptionsAsync(GetMediaAuditResultTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMediaAuditResultTimeline",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaAuditResultTimelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMediaAuditResultTimelineResponse GetMediaAuditResultTimeline(GetMediaAuditResultTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaAuditResultTimelineWithOptions(request, runtime);
        }

        public async Task<GetMediaAuditResultTimelineResponse> GetMediaAuditResultTimelineAsync(GetMediaAuditResultTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaAuditResultTimelineWithOptionsAsync(request, runtime);
        }

        /**
          * Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          *
          * @param request GetMediaDNAResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMediaDNAResultResponse
         */
        public GetMediaDNAResultResponse GetMediaDNAResultWithOptions(GetMediaDNAResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "GetMediaDNAResult",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaDNAResultResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          *
          * @param request GetMediaDNAResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMediaDNAResultResponse
         */
        public async Task<GetMediaDNAResultResponse> GetMediaDNAResultWithOptionsAsync(GetMediaDNAResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "GetMediaDNAResult",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaDNAResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          *
          * @param request GetMediaDNAResultRequest
          * @return GetMediaDNAResultResponse
         */
        public GetMediaDNAResultResponse GetMediaDNAResult(GetMediaDNAResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaDNAResultWithOptions(request, runtime);
        }

        /**
          * Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          *
          * @param request GetMediaDNAResultRequest
          * @return GetMediaDNAResultResponse
         */
        public async Task<GetMediaDNAResultResponse> GetMediaDNAResultAsync(GetMediaDNAResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaDNAResultWithOptionsAsync(request, runtime);
        }

        /**
          * You can query the information about all media files or a specific media file in a refresh or prefetch job.
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VoD](~~342790~~).
          *
          * @param request GetMediaRefreshJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMediaRefreshJobsResponse
         */
        public GetMediaRefreshJobsResponse GetMediaRefreshJobsWithOptions(GetMediaRefreshJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaRefreshJobs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaRefreshJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can query the information about all media files or a specific media file in a refresh or prefetch job.
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VoD](~~342790~~).
          *
          * @param request GetMediaRefreshJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMediaRefreshJobsResponse
         */
        public async Task<GetMediaRefreshJobsResponse> GetMediaRefreshJobsWithOptionsAsync(GetMediaRefreshJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaRefreshJobs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaRefreshJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can query the information about all media files or a specific media file in a refresh or prefetch job.
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VoD](~~342790~~).
          *
          * @param request GetMediaRefreshJobsRequest
          * @return GetMediaRefreshJobsResponse
         */
        public GetMediaRefreshJobsResponse GetMediaRefreshJobs(GetMediaRefreshJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaRefreshJobsWithOptions(request, runtime);
        }

        /**
          * You can query the information about all media files or a specific media file in a refresh or prefetch job.
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VoD](~~342790~~).
          *
          * @param request GetMediaRefreshJobsRequest
          * @return GetMediaRefreshJobsResponse
         */
        public async Task<GetMediaRefreshJobsResponse> GetMediaRefreshJobsAsync(GetMediaRefreshJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaRefreshJobsWithOptionsAsync(request, runtime);
        }

        /**
          * > For more information, see [Event notification](~~55627~~).
          *
          * @param request GetMessageCallbackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMessageCallbackResponse
         */
        public GetMessageCallbackResponse GetMessageCallbackWithOptions(GetMessageCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessageCallback",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessageCallbackResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > For more information, see [Event notification](~~55627~~).
          *
          * @param request GetMessageCallbackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMessageCallbackResponse
         */
        public async Task<GetMessageCallbackResponse> GetMessageCallbackWithOptionsAsync(GetMessageCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessageCallback",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessageCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > For more information, see [Event notification](~~55627~~).
          *
          * @param request GetMessageCallbackRequest
          * @return GetMessageCallbackResponse
         */
        public GetMessageCallbackResponse GetMessageCallback(GetMessageCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMessageCallbackWithOptions(request, runtime);
        }

        /**
          * > For more information, see [Event notification](~~55627~~).
          *
          * @param request GetMessageCallbackRequest
          * @return GetMessageCallbackResponse
         */
        public async Task<GetMessageCallbackResponse> GetMessageCallbackAsync(GetMessageCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMessageCallbackWithOptionsAsync(request, runtime);
        }

        /**
          * > You can obtain the complete mezzanine file information only after a stream is transcoded.
          *
          * @param request GetMezzanineInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMezzanineInfoResponse
         */
        public GetMezzanineInfoResponse GetMezzanineInfoWithOptions(GetMezzanineInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionType))
            {
                query["AdditionType"] = request.AdditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputType))
            {
                query["OutputType"] = request.OutputType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMezzanineInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMezzanineInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can obtain the complete mezzanine file information only after a stream is transcoded.
          *
          * @param request GetMezzanineInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMezzanineInfoResponse
         */
        public async Task<GetMezzanineInfoResponse> GetMezzanineInfoWithOptionsAsync(GetMezzanineInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionType))
            {
                query["AdditionType"] = request.AdditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputType))
            {
                query["OutputType"] = request.OutputType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMezzanineInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMezzanineInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can obtain the complete mezzanine file information only after a stream is transcoded.
          *
          * @param request GetMezzanineInfoRequest
          * @return GetMezzanineInfoResponse
         */
        public GetMezzanineInfoResponse GetMezzanineInfo(GetMezzanineInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMezzanineInfoWithOptions(request, runtime);
        }

        /**
          * > You can obtain the complete mezzanine file information only after a stream is transcoded.
          *
          * @param request GetMezzanineInfoRequest
          * @return GetMezzanineInfoResponse
         */
        public async Task<GetMezzanineInfoResponse> GetMezzanineInfoAsync(GetMezzanineInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMezzanineInfoWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can use the ID of a media file to query the playback URL of the file. After you integrate ApsaraVideo Player SDK for URL-based playback or a third-party player, you can use the obtained playback URLs to play audio and video files.
          * *   Only videos whose Status is Normal can be played. The Status parameter in the response indicates the status of the video. For more information, see [Overview](~~57290~~).
          * *   If video playback fails, you can call the [GetMezzanineInfo](~~GetMezzanineInfo~~) operation to check whether the video source information is correct.
          *
          * @param request GetPlayInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPlayInfoResponse
         */
        public GetPlayInfoResponse GetPlayInfoWithOptions(GetPlayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionType))
            {
                query["AdditionType"] = request.AdditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                query["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalWatermarkType))
            {
                query["DigitalWatermarkType"] = request.DigitalWatermarkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Formats))
            {
                query["Formats"] = request.Formats;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputType))
            {
                query["OutputType"] = request.OutputType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayConfig))
            {
                query["PlayConfig"] = request.PlayConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReAuthInfo))
            {
                query["ReAuthInfo"] = request.ReAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultType))
            {
                query["ResultType"] = request.ResultType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trace))
            {
                query["Trace"] = request.Trace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPlayInfo",
                Version = "2017-03-21",
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
          * *   You can use the ID of a media file to query the playback URL of the file. After you integrate ApsaraVideo Player SDK for URL-based playback or a third-party player, you can use the obtained playback URLs to play audio and video files.
          * *   Only videos whose Status is Normal can be played. The Status parameter in the response indicates the status of the video. For more information, see [Overview](~~57290~~).
          * *   If video playback fails, you can call the [GetMezzanineInfo](~~GetMezzanineInfo~~) operation to check whether the video source information is correct.
          *
          * @param request GetPlayInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPlayInfoResponse
         */
        public async Task<GetPlayInfoResponse> GetPlayInfoWithOptionsAsync(GetPlayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionType))
            {
                query["AdditionType"] = request.AdditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                query["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalWatermarkType))
            {
                query["DigitalWatermarkType"] = request.DigitalWatermarkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Formats))
            {
                query["Formats"] = request.Formats;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputType))
            {
                query["OutputType"] = request.OutputType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayConfig))
            {
                query["PlayConfig"] = request.PlayConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReAuthInfo))
            {
                query["ReAuthInfo"] = request.ReAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultType))
            {
                query["ResultType"] = request.ResultType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trace))
            {
                query["Trace"] = request.Trace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPlayInfo",
                Version = "2017-03-21",
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
          * *   You can use the ID of a media file to query the playback URL of the file. After you integrate ApsaraVideo Player SDK for URL-based playback or a third-party player, you can use the obtained playback URLs to play audio and video files.
          * *   Only videos whose Status is Normal can be played. The Status parameter in the response indicates the status of the video. For more information, see [Overview](~~57290~~).
          * *   If video playback fails, you can call the [GetMezzanineInfo](~~GetMezzanineInfo~~) operation to check whether the video source information is correct.
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
          * *   You can use the ID of a media file to query the playback URL of the file. After you integrate ApsaraVideo Player SDK for URL-based playback or a third-party player, you can use the obtained playback URLs to play audio and video files.
          * *   Only videos whose Status is Normal can be played. The Status parameter in the response indicates the status of the video. For more information, see [Overview](~~57290~~).
          * *   If video playback fails, you can call the [GetMezzanineInfo](~~GetMezzanineInfo~~) operation to check whether the video source information is correct.
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
          * *   A media file may be transcoded multiple times. This operation returns only the latest transcoding summary.
          * *   You can query transcoding summaries for a maximum of 10 media files in one request.
          * *   You can call the [ListTranscodeTask](~~109120~~) operation to query historical transcoding tasks.
          * *   **You can call this operation to query information only about transcoding tasks created within the past year.**
          *
          * @param request GetTranscodeSummaryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTranscodeSummaryResponse
         */
        public GetTranscodeSummaryResponse GetTranscodeSummaryWithOptions(GetTranscodeSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIds))
            {
                query["VideoIds"] = request.VideoIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranscodeSummary",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranscodeSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   A media file may be transcoded multiple times. This operation returns only the latest transcoding summary.
          * *   You can query transcoding summaries for a maximum of 10 media files in one request.
          * *   You can call the [ListTranscodeTask](~~109120~~) operation to query historical transcoding tasks.
          * *   **You can call this operation to query information only about transcoding tasks created within the past year.**
          *
          * @param request GetTranscodeSummaryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTranscodeSummaryResponse
         */
        public async Task<GetTranscodeSummaryResponse> GetTranscodeSummaryWithOptionsAsync(GetTranscodeSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIds))
            {
                query["VideoIds"] = request.VideoIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranscodeSummary",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranscodeSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   A media file may be transcoded multiple times. This operation returns only the latest transcoding summary.
          * *   You can query transcoding summaries for a maximum of 10 media files in one request.
          * *   You can call the [ListTranscodeTask](~~109120~~) operation to query historical transcoding tasks.
          * *   **You can call this operation to query information only about transcoding tasks created within the past year.**
          *
          * @param request GetTranscodeSummaryRequest
          * @return GetTranscodeSummaryResponse
         */
        public GetTranscodeSummaryResponse GetTranscodeSummary(GetTranscodeSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTranscodeSummaryWithOptions(request, runtime);
        }

        /**
          * *   A media file may be transcoded multiple times. This operation returns only the latest transcoding summary.
          * *   You can query transcoding summaries for a maximum of 10 media files in one request.
          * *   You can call the [ListTranscodeTask](~~109120~~) operation to query historical transcoding tasks.
          * *   **You can call this operation to query information only about transcoding tasks created within the past year.**
          *
          * @param request GetTranscodeSummaryRequest
          * @return GetTranscodeSummaryResponse
         */
        public async Task<GetTranscodeSummaryResponse> GetTranscodeSummaryAsync(GetTranscodeSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTranscodeSummaryWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to query only transcoding tasks created within the past year.
          *
          * @param request GetTranscodeTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTranscodeTaskResponse
         */
        public GetTranscodeTaskResponse GetTranscodeTaskWithOptions(GetTranscodeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTaskId))
            {
                query["TranscodeTaskId"] = request.TranscodeTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranscodeTask",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranscodeTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to query only transcoding tasks created within the past year.
          *
          * @param request GetTranscodeTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTranscodeTaskResponse
         */
        public async Task<GetTranscodeTaskResponse> GetTranscodeTaskWithOptionsAsync(GetTranscodeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTaskId))
            {
                query["TranscodeTaskId"] = request.TranscodeTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranscodeTask",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranscodeTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to query only transcoding tasks created within the past year.
          *
          * @param request GetTranscodeTaskRequest
          * @return GetTranscodeTaskResponse
         */
        public GetTranscodeTaskResponse GetTranscodeTask(GetTranscodeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTranscodeTaskWithOptions(request, runtime);
        }

        /**
          * You can call this operation to query only transcoding tasks created within the past year.
          *
          * @param request GetTranscodeTaskRequest
          * @return GetTranscodeTaskResponse
         */
        public async Task<GetTranscodeTaskResponse> GetTranscodeTaskAsync(GetTranscodeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTranscodeTaskWithOptionsAsync(request, runtime);
        }

        /**
          * >  This operation returns the information about the specified transcoding template group and the configurations of all the transcoding templates in the group.
          *
          * @param request GetTranscodeTemplateGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTranscodeTemplateGroupResponse
         */
        public GetTranscodeTemplateGroupResponse GetTranscodeTemplateGroupWithOptions(GetTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateGroupId))
            {
                query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranscodeTemplateGroup",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranscodeTemplateGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  This operation returns the information about the specified transcoding template group and the configurations of all the transcoding templates in the group.
          *
          * @param request GetTranscodeTemplateGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetTranscodeTemplateGroupResponse
         */
        public async Task<GetTranscodeTemplateGroupResponse> GetTranscodeTemplateGroupWithOptionsAsync(GetTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateGroupId))
            {
                query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTranscodeTemplateGroup",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranscodeTemplateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  This operation returns the information about the specified transcoding template group and the configurations of all the transcoding templates in the group.
          *
          * @param request GetTranscodeTemplateGroupRequest
          * @return GetTranscodeTemplateGroupResponse
         */
        public GetTranscodeTemplateGroupResponse GetTranscodeTemplateGroup(GetTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTranscodeTemplateGroupWithOptions(request, runtime);
        }

        /**
          * >  This operation returns the information about the specified transcoding template group and the configurations of all the transcoding templates in the group.
          *
          * @param request GetTranscodeTemplateGroupRequest
          * @return GetTranscodeTemplateGroupResponse
         */
        public async Task<GetTranscodeTemplateGroupResponse> GetTranscodeTemplateGroupAsync(GetTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTranscodeTemplateGroupWithOptionsAsync(request, runtime);
        }

        /**
          * You can query the information about a URL-based upload job by specifying the upload URL or using the job ID returned when you upload media files. The information includes the status of the upload job, custom configurations, the time when the job was created, and the time when the job was complete.
          * If the upload fails, you can view the error code and error message. If the upload is successful, you can obtain the video ID.
          *
          * @param request GetURLUploadInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetURLUploadInfosResponse
         */
        public GetURLUploadInfosResponse GetURLUploadInfosWithOptions(GetURLUploadInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetURLUploadInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetURLUploadInfosResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can query the information about a URL-based upload job by specifying the upload URL or using the job ID returned when you upload media files. The information includes the status of the upload job, custom configurations, the time when the job was created, and the time when the job was complete.
          * If the upload fails, you can view the error code and error message. If the upload is successful, you can obtain the video ID.
          *
          * @param request GetURLUploadInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetURLUploadInfosResponse
         */
        public async Task<GetURLUploadInfosResponse> GetURLUploadInfosWithOptionsAsync(GetURLUploadInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetURLUploadInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetURLUploadInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can query the information about a URL-based upload job by specifying the upload URL or using the job ID returned when you upload media files. The information includes the status of the upload job, custom configurations, the time when the job was created, and the time when the job was complete.
          * If the upload fails, you can view the error code and error message. If the upload is successful, you can obtain the video ID.
          *
          * @param request GetURLUploadInfosRequest
          * @return GetURLUploadInfosResponse
         */
        public GetURLUploadInfosResponse GetURLUploadInfos(GetURLUploadInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetURLUploadInfosWithOptions(request, runtime);
        }

        /**
          * You can query the information about a URL-based upload job by specifying the upload URL or using the job ID returned when you upload media files. The information includes the status of the upload job, custom configurations, the time when the job was created, and the time when the job was complete.
          * If the upload fails, you can view the error code and error message. If the upload is successful, you can obtain the video ID.
          *
          * @param request GetURLUploadInfosRequest
          * @return GetURLUploadInfosResponse
         */
        public async Task<GetURLUploadInfosResponse> GetURLUploadInfosAsync(GetURLUploadInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetURLUploadInfosWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation to obtain the upload details only about audio and video files.
          * *   If you use the ApsaraVideo VOD console to upload audio and video files, you can call this operation to query information such as the upload ratio. If you use an upload SDK to upload audio and video files, make sure that the version of the [upload SDK](~~52200~~) meets one of the following requirements:
          *     *   The version of the upload SDK for Java is 1.4.4 or later.
          *     *   The version of the upload SDK for C++ is 1.0.0 or later.
          *     *   The version of the upload SDK for PHP is 1.0.2 or later.
          *     *   The version of the upload SDK for Python is 1.3.0 or later.
          *     *   The version of the upload SDK for JavaScript is 1.4.0 or later.
          *     *   The version of the upload SDK for Android is 1.5.0 or later.
          *     *   The version of the upload SDK for iOS is 1.5.0 or later.
          *
          * @param request GetUploadDetailsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetUploadDetailsResponse
         */
        public GetUploadDetailsResponse GetUploadDetailsWithOptions(GetUploadDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadDetails",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadDetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call this operation to obtain the upload details only about audio and video files.
          * *   If you use the ApsaraVideo VOD console to upload audio and video files, you can call this operation to query information such as the upload ratio. If you use an upload SDK to upload audio and video files, make sure that the version of the [upload SDK](~~52200~~) meets one of the following requirements:
          *     *   The version of the upload SDK for Java is 1.4.4 or later.
          *     *   The version of the upload SDK for C++ is 1.0.0 or later.
          *     *   The version of the upload SDK for PHP is 1.0.2 or later.
          *     *   The version of the upload SDK for Python is 1.3.0 or later.
          *     *   The version of the upload SDK for JavaScript is 1.4.0 or later.
          *     *   The version of the upload SDK for Android is 1.5.0 or later.
          *     *   The version of the upload SDK for iOS is 1.5.0 or later.
          *
          * @param request GetUploadDetailsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetUploadDetailsResponse
         */
        public async Task<GetUploadDetailsResponse> GetUploadDetailsWithOptionsAsync(GetUploadDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadDetails",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call this operation to obtain the upload details only about audio and video files.
          * *   If you use the ApsaraVideo VOD console to upload audio and video files, you can call this operation to query information such as the upload ratio. If you use an upload SDK to upload audio and video files, make sure that the version of the [upload SDK](~~52200~~) meets one of the following requirements:
          *     *   The version of the upload SDK for Java is 1.4.4 or later.
          *     *   The version of the upload SDK for C++ is 1.0.0 or later.
          *     *   The version of the upload SDK for PHP is 1.0.2 or later.
          *     *   The version of the upload SDK for Python is 1.3.0 or later.
          *     *   The version of the upload SDK for JavaScript is 1.4.0 or later.
          *     *   The version of the upload SDK for Android is 1.5.0 or later.
          *     *   The version of the upload SDK for iOS is 1.5.0 or later.
          *
          * @param request GetUploadDetailsRequest
          * @return GetUploadDetailsResponse
         */
        public GetUploadDetailsResponse GetUploadDetails(GetUploadDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUploadDetailsWithOptions(request, runtime);
        }

        /**
          * *   You can call this operation to obtain the upload details only about audio and video files.
          * *   If you use the ApsaraVideo VOD console to upload audio and video files, you can call this operation to query information such as the upload ratio. If you use an upload SDK to upload audio and video files, make sure that the version of the [upload SDK](~~52200~~) meets one of the following requirements:
          *     *   The version of the upload SDK for Java is 1.4.4 or later.
          *     *   The version of the upload SDK for C++ is 1.0.0 or later.
          *     *   The version of the upload SDK for PHP is 1.0.2 or later.
          *     *   The version of the upload SDK for Python is 1.3.0 or later.
          *     *   The version of the upload SDK for JavaScript is 1.4.0 or later.
          *     *   The version of the upload SDK for Android is 1.5.0 or later.
          *     *   The version of the upload SDK for iOS is 1.5.0 or later.
          *
          * @param request GetUploadDetailsRequest
          * @return GetUploadDetailsResponse
         */
        public async Task<GetUploadDetailsResponse> GetUploadDetailsAsync(GetUploadDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUploadDetailsWithOptionsAsync(request, runtime);
        }

        /**
          * The video snapshot URLs.
          * > This operation returns only data about the snapshots that are captured when you upload a video. The snapshot data includes data of the thumbnail and snapshot data that is generated based on the workflow setting. To query the snapshot data that is generated after the video is uploaded, call the [ListSnapshots](~~ListSnapshots~~) operation. For more information, see [Video snapshots](~~99368~~).
          *
          * @param request GetVideoInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetVideoInfoResponse
         */
        public GetVideoInfoResponse GetVideoInfoWithOptions(GetVideoInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The video snapshot URLs.
          * > This operation returns only data about the snapshots that are captured when you upload a video. The snapshot data includes data of the thumbnail and snapshot data that is generated based on the workflow setting. To query the snapshot data that is generated after the video is uploaded, call the [ListSnapshots](~~ListSnapshots~~) operation. For more information, see [Video snapshots](~~99368~~).
          *
          * @param request GetVideoInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetVideoInfoResponse
         */
        public async Task<GetVideoInfoResponse> GetVideoInfoWithOptionsAsync(GetVideoInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The video snapshot URLs.
          * > This operation returns only data about the snapshots that are captured when you upload a video. The snapshot data includes data of the thumbnail and snapshot data that is generated based on the workflow setting. To query the snapshot data that is generated after the video is uploaded, call the [ListSnapshots](~~ListSnapshots~~) operation. For more information, see [Video snapshots](~~99368~~).
          *
          * @param request GetVideoInfoRequest
          * @return GetVideoInfoResponse
         */
        public GetVideoInfoResponse GetVideoInfo(GetVideoInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoInfoWithOptions(request, runtime);
        }

        /**
          * The video snapshot URLs.
          * > This operation returns only data about the snapshots that are captured when you upload a video. The snapshot data includes data of the thumbnail and snapshot data that is generated based on the workflow setting. To query the snapshot data that is generated after the video is uploaded, call the [ListSnapshots](~~ListSnapshots~~) operation. For more information, see [Video snapshots](~~99368~~).
          *
          * @param request GetVideoInfoRequest
          * @return GetVideoInfoResponse
         */
        public async Task<GetVideoInfoResponse> GetVideoInfoAsync(GetVideoInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoInfoWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to obtain the basic information about multiple videos at a time based on video IDs. The basic information includes the title, description, duration, thumbnail URL, status, creation time, size, snapshots, category, and tags of each video.
          *
          * @param request GetVideoInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetVideoInfosResponse
         */
        public GetVideoInfosResponse GetVideoInfosWithOptions(GetVideoInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIds))
            {
                query["VideoIds"] = request.VideoIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoInfosResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to obtain the basic information about multiple videos at a time based on video IDs. The basic information includes the title, description, duration, thumbnail URL, status, creation time, size, snapshots, category, and tags of each video.
          *
          * @param request GetVideoInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetVideoInfosResponse
         */
        public async Task<GetVideoInfosResponse> GetVideoInfosWithOptionsAsync(GetVideoInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIds))
            {
                query["VideoIds"] = request.VideoIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to obtain the basic information about multiple videos at a time based on video IDs. The basic information includes the title, description, duration, thumbnail URL, status, creation time, size, snapshots, category, and tags of each video.
          *
          * @param request GetVideoInfosRequest
          * @return GetVideoInfosResponse
         */
        public GetVideoInfosResponse GetVideoInfos(GetVideoInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoInfosWithOptions(request, runtime);
        }

        /**
          * You can call this operation to obtain the basic information about multiple videos at a time based on video IDs. The basic information includes the title, description, duration, thumbnail URL, status, creation time, size, snapshots, category, and tags of each video.
          *
          * @param request GetVideoInfosRequest
          * @return GetVideoInfosResponse
         */
        public async Task<GetVideoInfosResponse> GetVideoInfosAsync(GetVideoInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoInfosWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to query information about media files based on the filter conditions that you specify, such as video status and category ID. Information about a maximum of **5,000** media files can be returned for each request. We recommend that you set the StartTime and EndTime parameters to specify a time range for each request. For more information about how to query information about more media files or even all media files, see [SearchMedia](~~86044~~).
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageLocation))
            {
                query["StorageLocation"] = request.StorageLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoList",
                Version = "2017-03-21",
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
          * You can call this operation to query information about media files based on the filter conditions that you specify, such as video status and category ID. Information about a maximum of **5,000** media files can be returned for each request. We recommend that you set the StartTime and EndTime parameters to specify a time range for each request. For more information about how to query information about more media files or even all media files, see [SearchMedia](~~86044~~).
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageLocation))
            {
                query["StorageLocation"] = request.StorageLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoList",
                Version = "2017-03-21",
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
          * You can call this operation to query information about media files based on the filter conditions that you specify, such as video status and category ID. Information about a maximum of **5,000** media files can be returned for each request. We recommend that you set the StartTime and EndTime parameters to specify a time range for each request. For more information about how to query information about more media files or even all media files, see [SearchMedia](~~86044~~).
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
          * You can call this operation to query information about media files based on the filter conditions that you specify, such as video status and category ID. Information about a maximum of **5,000** media files can be returned for each request. We recommend that you set the StartTime and EndTime parameters to specify a time range for each request. For more information about how to query information about more media files or even all media files, see [SearchMedia](~~86044~~).
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
          * ###
          * *   You can call this operation to obtain a playback credential when you use ApsaraVideo Player SDK to play a media file based on PlayAuth. The credential is used to obtain the playback URL.
          * *   You cannot obtain the playback URL of a video by using a credential that has expired. A new credential is required.
          * ### QPS limit
          * You can call this operation up to 360 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on API operations](~~342790~~).
          *
          * @param request GetVideoPlayAuthRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetVideoPlayAuthResponse
         */
        public GetVideoPlayAuthResponse GetVideoPlayAuthWithOptions(GetVideoPlayAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthInfoTimeout))
            {
                query["AuthInfoTimeout"] = request.AuthInfoTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoPlayAuth",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoPlayAuthResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ###
          * *   You can call this operation to obtain a playback credential when you use ApsaraVideo Player SDK to play a media file based on PlayAuth. The credential is used to obtain the playback URL.
          * *   You cannot obtain the playback URL of a video by using a credential that has expired. A new credential is required.
          * ### QPS limit
          * You can call this operation up to 360 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on API operations](~~342790~~).
          *
          * @param request GetVideoPlayAuthRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetVideoPlayAuthResponse
         */
        public async Task<GetVideoPlayAuthResponse> GetVideoPlayAuthWithOptionsAsync(GetVideoPlayAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiVersion))
            {
                query["ApiVersion"] = request.ApiVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthInfoTimeout))
            {
                query["AuthInfoTimeout"] = request.AuthInfoTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoPlayAuth",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoPlayAuthResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ###
          * *   You can call this operation to obtain a playback credential when you use ApsaraVideo Player SDK to play a media file based on PlayAuth. The credential is used to obtain the playback URL.
          * *   You cannot obtain the playback URL of a video by using a credential that has expired. A new credential is required.
          * ### QPS limit
          * You can call this operation up to 360 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on API operations](~~342790~~).
          *
          * @param request GetVideoPlayAuthRequest
          * @return GetVideoPlayAuthResponse
         */
        public GetVideoPlayAuthResponse GetVideoPlayAuth(GetVideoPlayAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoPlayAuthWithOptions(request, runtime);
        }

        /**
          * ###
          * *   You can call this operation to obtain a playback credential when you use ApsaraVideo Player SDK to play a media file based on PlayAuth. The credential is used to obtain the playback URL.
          * *   You cannot obtain the playback URL of a video by using a credential that has expired. A new credential is required.
          * ### QPS limit
          * You can call this operation up to 360 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on API operations](~~342790~~).
          *
          * @param request GetVideoPlayAuthRequest
          * @return GetVideoPlayAuthResponse
         */
        public async Task<GetVideoPlayAuthResponse> GetVideoPlayAuthAsync(GetVideoPlayAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoPlayAuthWithOptionsAsync(request, runtime);
        }

        public GetVodTemplateResponse GetVodTemplateWithOptions(GetVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VodTemplateId))
            {
                query["VodTemplateId"] = request.VodTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVodTemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVodTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetVodTemplateResponse> GetVodTemplateWithOptionsAsync(GetVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VodTemplateId))
            {
                query["VodTemplateId"] = request.VodTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVodTemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVodTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetVodTemplateResponse GetVodTemplate(GetVodTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVodTemplateWithOptions(request, runtime);
        }

        public async Task<GetVodTemplateResponse> GetVodTemplateAsync(GetVodTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVodTemplateWithOptionsAsync(request, runtime);
        }

        public GetWatermarkResponse GetWatermarkWithOptions(GetWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkId))
            {
                query["WatermarkId"] = request.WatermarkId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWatermark",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWatermarkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWatermarkResponse> GetWatermarkWithOptionsAsync(GetWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkId))
            {
                query["WatermarkId"] = request.WatermarkId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWatermark",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWatermarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWatermarkResponse GetWatermark(GetWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWatermarkWithOptions(request, runtime);
        }

        public async Task<GetWatermarkResponse> GetWatermarkAsync(GetWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWatermarkWithOptionsAsync(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   You can call this operation to query AI processing results about images of a specified video. Images of different videos cannot be queried in one request.
          *
          * @param request ListAIImageInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAIImageInfoResponse
         */
        public ListAIImageInfoResponse ListAIImageInfoWithOptions(ListAIImageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAIImageInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAIImageInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   You can call this operation to query AI processing results about images of a specified video. Images of different videos cannot be queried in one request.
          *
          * @param request ListAIImageInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAIImageInfoResponse
         */
        public async Task<ListAIImageInfoResponse> ListAIImageInfoWithOptionsAsync(ListAIImageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAIImageInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAIImageInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   You can call this operation to query AI processing results about images of a specified video. Images of different videos cannot be queried in one request.
          *
          * @param request ListAIImageInfoRequest
          * @return ListAIImageInfoResponse
         */
        public ListAIImageInfoResponse ListAIImageInfo(ListAIImageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAIImageInfoWithOptions(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   You can call this operation to query AI processing results about images of a specified video. Images of different videos cannot be queried in one request.
          *
          * @param request ListAIImageInfoRequest
          * @return ListAIImageInfoResponse
         */
        public async Task<ListAIImageInfoResponse> ListAIImageInfoAsync(ListAIImageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAIImageInfoWithOptionsAsync(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can call this operation to query video fingerprinting jobs and smart tagging jobs.
          *
          * @param request ListAIJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAIJobResponse
         */
        public ListAIJobResponse ListAIJobWithOptions(ListAIJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAIJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAIJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can call this operation to query video fingerprinting jobs and smart tagging jobs.
          *
          * @param request ListAIJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAIJobResponse
         */
        public async Task<ListAIJobResponse> ListAIJobWithOptionsAsync(ListAIJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAIJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAIJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can call this operation to query video fingerprinting jobs and smart tagging jobs.
          *
          * @param request ListAIJobRequest
          * @return ListAIJobResponse
         */
        public ListAIJobResponse ListAIJob(ListAIJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAIJobWithOptions(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can call this operation to query video fingerprinting jobs and smart tagging jobs.
          *
          * @param request ListAIJobRequest
          * @return ListAIJobResponse
         */
        public async Task<ListAIJobResponse> ListAIJobAsync(ListAIJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAIJobWithOptionsAsync(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can call this operation to query AI templates of a specified type.
          *
          * @param request ListAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAITemplateResponse
         */
        public ListAITemplateResponse ListAITemplateWithOptions(ListAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAITemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can call this operation to query AI templates of a specified type.
          *
          * @param request ListAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAITemplateResponse
         */
        public async Task<ListAITemplateResponse> ListAITemplateWithOptionsAsync(ListAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAITemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can call this operation to query AI templates of a specified type.
          *
          * @param request ListAITemplateRequest
          * @return ListAITemplateResponse
         */
        public ListAITemplateResponse ListAITemplate(ListAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAITemplateWithOptions(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   You can call this operation to query AI templates of a specified type.
          *
          * @param request ListAITemplateRequest
          * @return ListAITemplateResponse
         */
        public async Task<ListAITemplateResponse> ListAITemplateAsync(ListAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAITemplateWithOptionsAsync(request, runtime);
        }

        /**
          * Supports filtering queries by application status.
          *
          * @param request ListAppInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAppInfoResponse
         */
        public ListAppInfoResponse ListAppInfoWithOptions(ListAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAppInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Supports filtering queries by application status.
          *
          * @param request ListAppInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAppInfoResponse
         */
        public async Task<ListAppInfoResponse> ListAppInfoWithOptionsAsync(ListAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAppInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Supports filtering queries by application status.
          *
          * @param request ListAppInfoRequest
          * @return ListAppInfoResponse
         */
        public ListAppInfoResponse ListAppInfo(ListAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppInfoWithOptions(request, runtime);
        }

        /**
          * Supports filtering queries by application status.
          *
          * @param request ListAppInfoRequest
          * @return ListAppInfoResponse
         */
        public async Task<ListAppInfoResponse> ListAppInfoAsync(ListAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppInfoWithOptionsAsync(request, runtime);
        }

        /**
          * > The IdentityType and IdentityName parameters take effect only when an identity assumes the application administrator role to call this operation. Otherwise, only application policies that are attached to the current identity are returned.
          *
          * @param request ListAppPoliciesForIdentityRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAppPoliciesForIdentityResponse
         */
        public ListAppPoliciesForIdentityResponse ListAppPoliciesForIdentityWithOptions(ListAppPoliciesForIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityName))
            {
                query["IdentityName"] = request.IdentityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppPoliciesForIdentity",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppPoliciesForIdentityResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > The IdentityType and IdentityName parameters take effect only when an identity assumes the application administrator role to call this operation. Otherwise, only application policies that are attached to the current identity are returned.
          *
          * @param request ListAppPoliciesForIdentityRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAppPoliciesForIdentityResponse
         */
        public async Task<ListAppPoliciesForIdentityResponse> ListAppPoliciesForIdentityWithOptionsAsync(ListAppPoliciesForIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityName))
            {
                query["IdentityName"] = request.IdentityName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityType))
            {
                query["IdentityType"] = request.IdentityType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppPoliciesForIdentity",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppPoliciesForIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > The IdentityType and IdentityName parameters take effect only when an identity assumes the application administrator role to call this operation. Otherwise, only application policies that are attached to the current identity are returned.
          *
          * @param request ListAppPoliciesForIdentityRequest
          * @return ListAppPoliciesForIdentityResponse
         */
        public ListAppPoliciesForIdentityResponse ListAppPoliciesForIdentity(ListAppPoliciesForIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppPoliciesForIdentityWithOptions(request, runtime);
        }

        /**
          * > The IdentityType and IdentityName parameters take effect only when an identity assumes the application administrator role to call this operation. Otherwise, only application policies that are attached to the current identity are returned.
          *
          * @param request ListAppPoliciesForIdentityRequest
          * @return ListAppPoliciesForIdentityResponse
         */
        public async Task<ListAppPoliciesForIdentityResponse> ListAppPoliciesForIdentityAsync(ListAppPoliciesForIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppPoliciesForIdentityWithOptionsAsync(request, runtime);
        }

        public ListAuditSecurityIpResponse ListAuditSecurityIpWithOptions(ListAuditSecurityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupName))
            {
                query["SecurityGroupName"] = request.SecurityGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuditSecurityIp",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuditSecurityIpResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAuditSecurityIpResponse> ListAuditSecurityIpWithOptionsAsync(ListAuditSecurityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupName))
            {
                query["SecurityGroupName"] = request.SecurityGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuditSecurityIp",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuditSecurityIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAuditSecurityIpResponse ListAuditSecurityIp(ListAuditSecurityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuditSecurityIpWithOptions(request, runtime);
        }

        public async Task<ListAuditSecurityIpResponse> ListAuditSecurityIpAsync(ListAuditSecurityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuditSecurityIpWithOptionsAsync(request, runtime);
        }

        public ListDynamicImageResponse ListDynamicImageWithOptions(ListDynamicImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDynamicImage",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDynamicImageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDynamicImageResponse> ListDynamicImageWithOptionsAsync(ListDynamicImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDynamicImage",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDynamicImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDynamicImageResponse ListDynamicImage(ListDynamicImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDynamicImageWithOptions(request, runtime);
        }

        public async Task<ListDynamicImageResponse> ListDynamicImageAsync(ListDynamicImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDynamicImageWithOptionsAsync(request, runtime);
        }

        /**
          * You can query a maximum of 5,000 videos based on the specified filter condition.
          *
          * @param request ListLiveRecordVideoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListLiveRecordVideoResponse
         */
        public ListLiveRecordVideoResponse ListLiveRecordVideoWithOptions(ListLiveRecordVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListLiveRecordVideo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveRecordVideoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can query a maximum of 5,000 videos based on the specified filter condition.
          *
          * @param request ListLiveRecordVideoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListLiveRecordVideoResponse
         */
        public async Task<ListLiveRecordVideoResponse> ListLiveRecordVideoWithOptionsAsync(ListLiveRecordVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListLiveRecordVideo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLiveRecordVideoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can query a maximum of 5,000 videos based on the specified filter condition.
          *
          * @param request ListLiveRecordVideoRequest
          * @return ListLiveRecordVideoResponse
         */
        public ListLiveRecordVideoResponse ListLiveRecordVideo(ListLiveRecordVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveRecordVideoWithOptions(request, runtime);
        }

        /**
          * You can query a maximum of 5,000 videos based on the specified filter condition.
          *
          * @param request ListLiveRecordVideoRequest
          * @return ListLiveRecordVideoResponse
         */
        public async Task<ListLiveRecordVideoResponse> ListLiveRecordVideoAsync(ListLiveRecordVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveRecordVideoWithOptionsAsync(request, runtime);
        }

        /**
          * If multiple snapshots of a video exist, the data of the latest snapshot is returned.
          *
          * @param request ListSnapshotsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListSnapshotsResponse
         */
        public ListSnapshotsResponse ListSnapshotsWithOptions(ListSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotType))
            {
                query["SnapshotType"] = request.SnapshotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSnapshots",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If multiple snapshots of a video exist, the data of the latest snapshot is returned.
          *
          * @param request ListSnapshotsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListSnapshotsResponse
         */
        public async Task<ListSnapshotsResponse> ListSnapshotsWithOptionsAsync(ListSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthTimeout))
            {
                query["AuthTimeout"] = request.AuthTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotType))
            {
                query["SnapshotType"] = request.SnapshotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSnapshots",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If multiple snapshots of a video exist, the data of the latest snapshot is returned.
          *
          * @param request ListSnapshotsRequest
          * @return ListSnapshotsResponse
         */
        public ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSnapshotsWithOptions(request, runtime);
        }

        /**
          * If multiple snapshots of a video exist, the data of the latest snapshot is returned.
          *
          * @param request ListSnapshotsRequest
          * @return ListSnapshotsResponse
         */
        public async Task<ListSnapshotsResponse> ListSnapshotsAsync(ListSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSnapshotsWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call the [GetTranscodeTask](~~109121~~) operation to query details about transcoding jobs.
          * *   **You can call this operation to query only transcoding tasks created within the past year.**
          *
          * @param request ListTranscodeTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTranscodeTaskResponse
         */
        public ListTranscodeTaskResponse ListTranscodeTaskWithOptions(ListTranscodeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTranscodeTask",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTranscodeTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can call the [GetTranscodeTask](~~109121~~) operation to query details about transcoding jobs.
          * *   **You can call this operation to query only transcoding tasks created within the past year.**
          *
          * @param request ListTranscodeTaskRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTranscodeTaskResponse
         */
        public async Task<ListTranscodeTaskResponse> ListTranscodeTaskWithOptionsAsync(ListTranscodeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTranscodeTask",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTranscodeTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can call the [GetTranscodeTask](~~109121~~) operation to query details about transcoding jobs.
          * *   **You can call this operation to query only transcoding tasks created within the past year.**
          *
          * @param request ListTranscodeTaskRequest
          * @return ListTranscodeTaskResponse
         */
        public ListTranscodeTaskResponse ListTranscodeTask(ListTranscodeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTranscodeTaskWithOptions(request, runtime);
        }

        /**
          * *   You can call the [GetTranscodeTask](~~109121~~) operation to query details about transcoding jobs.
          * *   **You can call this operation to query only transcoding tasks created within the past year.**
          *
          * @param request ListTranscodeTaskRequest
          * @return ListTranscodeTaskResponse
         */
        public async Task<ListTranscodeTaskResponse> ListTranscodeTaskAsync(ListTranscodeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTranscodeTaskWithOptionsAsync(request, runtime);
        }

        /**
          * > This operation does not return the configurations of transcoding templates in each transcoding template group. To query the configurations of transcoding templates in a specific transcoding template group, call the [GetTranscodeTemplateGroup](~~102670~~) operation.
          *
          * @param request ListTranscodeTemplateGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTranscodeTemplateGroupResponse
         */
        public ListTranscodeTemplateGroupResponse ListTranscodeTemplateGroupWithOptions(ListTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTranscodeTemplateGroup",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTranscodeTemplateGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > This operation does not return the configurations of transcoding templates in each transcoding template group. To query the configurations of transcoding templates in a specific transcoding template group, call the [GetTranscodeTemplateGroup](~~102670~~) operation.
          *
          * @param request ListTranscodeTemplateGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTranscodeTemplateGroupResponse
         */
        public async Task<ListTranscodeTemplateGroupResponse> ListTranscodeTemplateGroupWithOptionsAsync(ListTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTranscodeTemplateGroup",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTranscodeTemplateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > This operation does not return the configurations of transcoding templates in each transcoding template group. To query the configurations of transcoding templates in a specific transcoding template group, call the [GetTranscodeTemplateGroup](~~102670~~) operation.
          *
          * @param request ListTranscodeTemplateGroupRequest
          * @return ListTranscodeTemplateGroupResponse
         */
        public ListTranscodeTemplateGroupResponse ListTranscodeTemplateGroup(ListTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTranscodeTemplateGroupWithOptions(request, runtime);
        }

        /**
          * > This operation does not return the configurations of transcoding templates in each transcoding template group. To query the configurations of transcoding templates in a specific transcoding template group, call the [GetTranscodeTemplateGroup](~~102670~~) operation.
          *
          * @param request ListTranscodeTemplateGroupRequest
          * @return ListTranscodeTemplateGroupResponse
         */
        public async Task<ListTranscodeTemplateGroupResponse> ListTranscodeTemplateGroupAsync(ListTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTranscodeTemplateGroupWithOptionsAsync(request, runtime);
        }

        public ListVodTemplateResponse ListVodTemplateWithOptions(ListVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
                Action = "ListVodTemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVodTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListVodTemplateResponse> ListVodTemplateWithOptionsAsync(ListVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
                Action = "ListVodTemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVodTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListVodTemplateResponse ListVodTemplate(ListVodTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVodTemplateWithOptions(request, runtime);
        }

        public async Task<ListVodTemplateResponse> ListVodTemplateAsync(ListVodTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVodTemplateWithOptionsAsync(request, runtime);
        }

        public ListWatermarkResponse ListWatermarkWithOptions(ListWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWatermark",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWatermarkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListWatermarkResponse> ListWatermarkWithOptionsAsync(ListWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWatermark",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWatermarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListWatermarkResponse ListWatermark(ListWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWatermarkWithOptions(request, runtime);
        }

        public async Task<ListWatermarkResponse> ListWatermarkAsync(ListWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWatermarkWithOptionsAsync(request, runtime);
        }

        public MoveAppResourceResponse MoveAppResourceWithOptions(MoveAppResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetAppId))
            {
                query["TargetAppId"] = request.TargetAppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveAppResource",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveAppResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MoveAppResourceResponse> MoveAppResourceWithOptionsAsync(MoveAppResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetAppId))
            {
                query["TargetAppId"] = request.TargetAppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveAppResource",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveAppResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MoveAppResourceResponse MoveAppResource(MoveAppResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveAppResourceWithOptions(request, runtime);
        }

        public async Task<MoveAppResourceResponse> MoveAppResourceAsync(MoveAppResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveAppResourceWithOptionsAsync(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can submit a maximum of 500 requests to prefetch resources based on URLs each day by using an Alibaba Cloud account. You cannot prefetch resources based on directories.
          * > *   You can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh content and the [PreloadVodObjectCaches](~~69211~~l) operation to prefetch content.
          *
          * @param request PreloadVodObjectCachesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PreloadVodObjectCachesResponse
         */
        public PreloadVodObjectCachesResponse PreloadVodObjectCachesWithOptions(PreloadVodObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectPath))
            {
                query["ObjectPath"] = request.ObjectPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreloadVodObjectCaches",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreloadVodObjectCachesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can submit a maximum of 500 requests to prefetch resources based on URLs each day by using an Alibaba Cloud account. You cannot prefetch resources based on directories.
          * > *   You can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh content and the [PreloadVodObjectCaches](~~69211~~l) operation to prefetch content.
          *
          * @param request PreloadVodObjectCachesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PreloadVodObjectCachesResponse
         */
        public async Task<PreloadVodObjectCachesResponse> PreloadVodObjectCachesWithOptionsAsync(PreloadVodObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectPath))
            {
                query["ObjectPath"] = request.ObjectPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreloadVodObjectCaches",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreloadVodObjectCachesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can submit a maximum of 500 requests to prefetch resources based on URLs each day by using an Alibaba Cloud account. You cannot prefetch resources based on directories.
          * > *   You can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh content and the [PreloadVodObjectCaches](~~69211~~l) operation to prefetch content.
          *
          * @param request PreloadVodObjectCachesRequest
          * @return PreloadVodObjectCachesResponse
         */
        public PreloadVodObjectCachesResponse PreloadVodObjectCaches(PreloadVodObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreloadVodObjectCachesWithOptions(request, runtime);
        }

        /**
          * > *   This operation is available only in the **China (Shanghai)** region.
          * > *   You can submit a maximum of 500 requests to prefetch resources based on URLs each day by using an Alibaba Cloud account. You cannot prefetch resources based on directories.
          * > *   You can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh content and the [PreloadVodObjectCaches](~~69211~~l) operation to prefetch content.
          *
          * @param request PreloadVodObjectCachesRequest
          * @return PreloadVodObjectCachesResponse
         */
        public async Task<PreloadVodObjectCachesResponse> PreloadVodObjectCachesAsync(PreloadVodObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreloadVodObjectCachesWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation returns only the submission result of a video production task. When the submission result is returned, video production may still be in progress. After a video production task is submitted, the task is queued in the background for asynchronous processing.
          * *   The source files that are used in the timeline of an online editing project can be materials directly uploaded to the online project or selected from the media asset library.
          * *   Videos are produced based on ProjectId and Timeline. The following rules apply when you specify the parameters:
          *     *   You must specify at least one of the ProjectId and Timeline parameters. Otherwise, video production fails.
          *     *   If you specify only the Timeline parameter, the system automatically creates an online editing project based on the specified timeline. Then, the system uses the source files specified in the timeline to produce videos.
          *     *   If you specify only the ProjectId parameter, the system obtains the latest timeline data of the specified project to produce videos.
          *     *   If you specify both the ProjectId and Timeline parameters, the system produces videos based on the specified timeline and updates the timeline data for the specified online editing project. You can also specify other parameters to update the corresponding information about the online editing project.
          * *   After a video is produced, the video is automatically uploaded to ApsaraVideo VOD. Then, the **ProduceMediaComplete** and **FileUploadComplete** event notifications are sent to you. After the produced video is transcoded, the **StreamTranscodeComplete** and **TranscodeComplete** event notifications are sent to you.
          * *   You can add special effects to the video. For more information, see [Special effects](~~69082~~).
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request ProduceEditingProjectVideoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ProduceEditingProjectVideoResponse
         */
        public ProduceEditingProjectVideoResponse ProduceEditingProjectVideoWithOptions(ProduceEditingProjectVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMetadata))
            {
                query["MediaMetadata"] = request.MediaMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceConfig))
            {
                query["ProduceConfig"] = request.ProduceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                query["Timeline"] = request.Timeline;
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
                Action = "ProduceEditingProjectVideo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProduceEditingProjectVideoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation returns only the submission result of a video production task. When the submission result is returned, video production may still be in progress. After a video production task is submitted, the task is queued in the background for asynchronous processing.
          * *   The source files that are used in the timeline of an online editing project can be materials directly uploaded to the online project or selected from the media asset library.
          * *   Videos are produced based on ProjectId and Timeline. The following rules apply when you specify the parameters:
          *     *   You must specify at least one of the ProjectId and Timeline parameters. Otherwise, video production fails.
          *     *   If you specify only the Timeline parameter, the system automatically creates an online editing project based on the specified timeline. Then, the system uses the source files specified in the timeline to produce videos.
          *     *   If you specify only the ProjectId parameter, the system obtains the latest timeline data of the specified project to produce videos.
          *     *   If you specify both the ProjectId and Timeline parameters, the system produces videos based on the specified timeline and updates the timeline data for the specified online editing project. You can also specify other parameters to update the corresponding information about the online editing project.
          * *   After a video is produced, the video is automatically uploaded to ApsaraVideo VOD. Then, the **ProduceMediaComplete** and **FileUploadComplete** event notifications are sent to you. After the produced video is transcoded, the **StreamTranscodeComplete** and **TranscodeComplete** event notifications are sent to you.
          * *   You can add special effects to the video. For more information, see [Special effects](~~69082~~).
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request ProduceEditingProjectVideoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ProduceEditingProjectVideoResponse
         */
        public async Task<ProduceEditingProjectVideoResponse> ProduceEditingProjectVideoWithOptionsAsync(ProduceEditingProjectVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaMetadata))
            {
                query["MediaMetadata"] = request.MediaMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceConfig))
            {
                query["ProduceConfig"] = request.ProduceConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeline))
            {
                query["Timeline"] = request.Timeline;
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
                Action = "ProduceEditingProjectVideo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProduceEditingProjectVideoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation returns only the submission result of a video production task. When the submission result is returned, video production may still be in progress. After a video production task is submitted, the task is queued in the background for asynchronous processing.
          * *   The source files that are used in the timeline of an online editing project can be materials directly uploaded to the online project or selected from the media asset library.
          * *   Videos are produced based on ProjectId and Timeline. The following rules apply when you specify the parameters:
          *     *   You must specify at least one of the ProjectId and Timeline parameters. Otherwise, video production fails.
          *     *   If you specify only the Timeline parameter, the system automatically creates an online editing project based on the specified timeline. Then, the system uses the source files specified in the timeline to produce videos.
          *     *   If you specify only the ProjectId parameter, the system obtains the latest timeline data of the specified project to produce videos.
          *     *   If you specify both the ProjectId and Timeline parameters, the system produces videos based on the specified timeline and updates the timeline data for the specified online editing project. You can also specify other parameters to update the corresponding information about the online editing project.
          * *   After a video is produced, the video is automatically uploaded to ApsaraVideo VOD. Then, the **ProduceMediaComplete** and **FileUploadComplete** event notifications are sent to you. After the produced video is transcoded, the **StreamTranscodeComplete** and **TranscodeComplete** event notifications are sent to you.
          * *   You can add special effects to the video. For more information, see [Special effects](~~69082~~).
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request ProduceEditingProjectVideoRequest
          * @return ProduceEditingProjectVideoResponse
         */
        public ProduceEditingProjectVideoResponse ProduceEditingProjectVideo(ProduceEditingProjectVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProduceEditingProjectVideoWithOptions(request, runtime);
        }

        /**
          * *   This operation returns only the submission result of a video production task. When the submission result is returned, video production may still be in progress. After a video production task is submitted, the task is queued in the background for asynchronous processing.
          * *   The source files that are used in the timeline of an online editing project can be materials directly uploaded to the online project or selected from the media asset library.
          * *   Videos are produced based on ProjectId and Timeline. The following rules apply when you specify the parameters:
          *     *   You must specify at least one of the ProjectId and Timeline parameters. Otherwise, video production fails.
          *     *   If you specify only the Timeline parameter, the system automatically creates an online editing project based on the specified timeline. Then, the system uses the source files specified in the timeline to produce videos.
          *     *   If you specify only the ProjectId parameter, the system obtains the latest timeline data of the specified project to produce videos.
          *     *   If you specify both the ProjectId and Timeline parameters, the system produces videos based on the specified timeline and updates the timeline data for the specified online editing project. You can also specify other parameters to update the corresponding information about the online editing project.
          * *   After a video is produced, the video is automatically uploaded to ApsaraVideo VOD. Then, the **ProduceMediaComplete** and **FileUploadComplete** event notifications are sent to you. After the produced video is transcoded, the **StreamTranscodeComplete** and **TranscodeComplete** event notifications are sent to you.
          * *   You can add special effects to the video. For more information, see [Special effects](~~69082~~).
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VOD](~~342790~~).
          *
          * @param request ProduceEditingProjectVideoRequest
          * @return ProduceEditingProjectVideoResponse
         */
        public async Task<ProduceEditingProjectVideoResponse> ProduceEditingProjectVideoAsync(ProduceEditingProjectVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProduceEditingProjectVideoWithOptionsAsync(request, runtime);
        }

        /**
          * - ApsaraVideo VOD allows you to refresh and prefetch resources. The refresh feature forces the point of presence (POP) to clear cached resources and retrieve the latest resources from origin servers. The prefetch feature allows the POP to retrieve frequently accessed resources from origin servers during off-peak hours. This increases the cache hit ratio.
          * - You can call this operation to submit refresh or prefetch tasks based on the media ID. You can also specify the format and resolution of the media streams to refresh or prefetch based on your business requirements.
          * - You can submit a maximum of 20 refresh or prefetch tasks at a time.
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VoD](~~342790~~).
          *
          * @param request RefreshMediaPlayUrlsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RefreshMediaPlayUrlsResponse
         */
        public RefreshMediaPlayUrlsResponse RefreshMediaPlayUrlsWithOptions(RefreshMediaPlayUrlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definitions))
            {
                query["Definitions"] = request.Definitions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Formats))
            {
                query["Formats"] = request.Formats;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultType))
            {
                query["ResultType"] = request.ResultType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceCount))
            {
                query["SliceCount"] = request.SliceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceFlag))
            {
                query["SliceFlag"] = request.SliceFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
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
                Action = "RefreshMediaPlayUrls",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshMediaPlayUrlsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * - ApsaraVideo VOD allows you to refresh and prefetch resources. The refresh feature forces the point of presence (POP) to clear cached resources and retrieve the latest resources from origin servers. The prefetch feature allows the POP to retrieve frequently accessed resources from origin servers during off-peak hours. This increases the cache hit ratio.
          * - You can call this operation to submit refresh or prefetch tasks based on the media ID. You can also specify the format and resolution of the media streams to refresh or prefetch based on your business requirements.
          * - You can submit a maximum of 20 refresh or prefetch tasks at a time.
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VoD](~~342790~~).
          *
          * @param request RefreshMediaPlayUrlsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RefreshMediaPlayUrlsResponse
         */
        public async Task<RefreshMediaPlayUrlsResponse> RefreshMediaPlayUrlsWithOptionsAsync(RefreshMediaPlayUrlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definitions))
            {
                query["Definitions"] = request.Definitions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Formats))
            {
                query["Formats"] = request.Formats;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultType))
            {
                query["ResultType"] = request.ResultType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceCount))
            {
                query["SliceCount"] = request.SliceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceFlag))
            {
                query["SliceFlag"] = request.SliceFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamType))
            {
                query["StreamType"] = request.StreamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
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
                Action = "RefreshMediaPlayUrls",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshMediaPlayUrlsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * - ApsaraVideo VOD allows you to refresh and prefetch resources. The refresh feature forces the point of presence (POP) to clear cached resources and retrieve the latest resources from origin servers. The prefetch feature allows the POP to retrieve frequently accessed resources from origin servers during off-peak hours. This increases the cache hit ratio.
          * - You can call this operation to submit refresh or prefetch tasks based on the media ID. You can also specify the format and resolution of the media streams to refresh or prefetch based on your business requirements.
          * - You can submit a maximum of 20 refresh or prefetch tasks at a time.
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VoD](~~342790~~).
          *
          * @param request RefreshMediaPlayUrlsRequest
          * @return RefreshMediaPlayUrlsResponse
         */
        public RefreshMediaPlayUrlsResponse RefreshMediaPlayUrls(RefreshMediaPlayUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshMediaPlayUrlsWithOptions(request, runtime);
        }

        /**
          * - ApsaraVideo VOD allows you to refresh and prefetch resources. The refresh feature forces the point of presence (POP) to clear cached resources and retrieve the latest resources from origin servers. The prefetch feature allows the POP to retrieve frequently accessed resources from origin servers during off-peak hours. This increases the cache hit ratio.
          * - You can call this operation to submit refresh or prefetch tasks based on the media ID. You can also specify the format and resolution of the media streams to refresh or prefetch based on your business requirements.
          * - You can submit a maximum of 20 refresh or prefetch tasks at a time.
          * ### QPS limits
          * You can call this operation up to 50 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limits on API operations in ApsaraVideo VoD](~~342790~~).
          *
          * @param request RefreshMediaPlayUrlsRequest
          * @return RefreshMediaPlayUrlsResponse
         */
        public async Task<RefreshMediaPlayUrlsResponse> RefreshMediaPlayUrlsAsync(RefreshMediaPlayUrlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshMediaPlayUrlsWithOptionsAsync(request, runtime);
        }

        /**
          * If you want to overwrite a video or audio source file, you can obtain the upload URL of the source file by calling this operation. Then, you can upload a new source file without changing the video or audio ID. However, the file overwriting may automatically trigger transcoding and snapshot jobs if these jobs are configured. For more information, see [Upload URLs and credentials](~~55397~~).
          *
          * @param request RefreshUploadVideoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RefreshUploadVideoResponse
         */
        public RefreshUploadVideoResponse RefreshUploadVideoWithOptions(RefreshUploadVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshUploadVideo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshUploadVideoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If you want to overwrite a video or audio source file, you can obtain the upload URL of the source file by calling this operation. Then, you can upload a new source file without changing the video or audio ID. However, the file overwriting may automatically trigger transcoding and snapshot jobs if these jobs are configured. For more information, see [Upload URLs and credentials](~~55397~~).
          *
          * @param request RefreshUploadVideoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RefreshUploadVideoResponse
         */
        public async Task<RefreshUploadVideoResponse> RefreshUploadVideoWithOptionsAsync(RefreshUploadVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshUploadVideo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshUploadVideoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If you want to overwrite a video or audio source file, you can obtain the upload URL of the source file by calling this operation. Then, you can upload a new source file without changing the video or audio ID. However, the file overwriting may automatically trigger transcoding and snapshot jobs if these jobs are configured. For more information, see [Upload URLs and credentials](~~55397~~).
          *
          * @param request RefreshUploadVideoRequest
          * @return RefreshUploadVideoResponse
         */
        public RefreshUploadVideoResponse RefreshUploadVideo(RefreshUploadVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshUploadVideoWithOptions(request, runtime);
        }

        /**
          * If you want to overwrite a video or audio source file, you can obtain the upload URL of the source file by calling this operation. Then, you can upload a new source file without changing the video or audio ID. However, the file overwriting may automatically trigger transcoding and snapshot jobs if these jobs are configured. For more information, see [Upload URLs and credentials](~~55397~~).
          *
          * @param request RefreshUploadVideoRequest
          * @return RefreshUploadVideoResponse
         */
        public async Task<RefreshUploadVideoResponse> RefreshUploadVideoAsync(RefreshUploadVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshUploadVideoWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can submit a maximum of 2,000 requests to refresh resources based on URLs and 100 requests to refresh resources based on directories each day by using an Alibaba Cloud account.
          * *   You can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh content and the [PreloadVodObjectCaches](~~69211~~) operation to prefetch content.
          *
          * @param request RefreshVodObjectCachesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RefreshVodObjectCachesResponse
         */
        public RefreshVodObjectCachesResponse RefreshVodObjectCachesWithOptions(RefreshVodObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectPath))
            {
                query["ObjectPath"] = request.ObjectPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshVodObjectCaches",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshVodObjectCachesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can submit a maximum of 2,000 requests to refresh resources based on URLs and 100 requests to refresh resources based on directories each day by using an Alibaba Cloud account.
          * *   You can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh content and the [PreloadVodObjectCaches](~~69211~~) operation to prefetch content.
          *
          * @param request RefreshVodObjectCachesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RefreshVodObjectCachesResponse
         */
        public async Task<RefreshVodObjectCachesResponse> RefreshVodObjectCachesWithOptionsAsync(RefreshVodObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectPath))
            {
                query["ObjectPath"] = request.ObjectPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshVodObjectCaches",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshVodObjectCachesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can submit a maximum of 2,000 requests to refresh resources based on URLs and 100 requests to refresh resources based on directories each day by using an Alibaba Cloud account.
          * *   You can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh content and the [PreloadVodObjectCaches](~~69211~~) operation to prefetch content.
          *
          * @param request RefreshVodObjectCachesRequest
          * @return RefreshVodObjectCachesResponse
         */
        public RefreshVodObjectCachesResponse RefreshVodObjectCaches(RefreshVodObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshVodObjectCachesWithOptions(request, runtime);
        }

        /**
          * *   This operation is available only in the **China (Shanghai)** region.
          * *   You can submit a maximum of 2,000 requests to refresh resources based on URLs and 100 requests to refresh resources based on directories each day by using an Alibaba Cloud account.
          * *   You can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh content and the [PreloadVodObjectCaches](~~69211~~) operation to prefetch content.
          *
          * @param request RefreshVodObjectCachesRequest
          * @return RefreshVodObjectCachesResponse
         */
        public async Task<RefreshVodObjectCachesResponse> RefreshVodObjectCachesAsync(RefreshVodObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshVodObjectCachesWithOptionsAsync(request, runtime);
        }

        /**
          * After you store an audio or video file in an Object Storage Service (OSS) bucket that is used for ApsaraVideo VOD, you can call the RegisterMedia operation to register the media file. After the media file is registered, you can use the media ID associated with the media file to submit transcoding jobs and snapshot jobs in ApsaraVideo VOD. For more information, see [SubmitTranscodeJobs](~~68570~~) and [SubmitSnapshotJob](~~72213~~).
          * > *   You can register up to 10 OSS media files that have the same storage location at a time.
          * > *   If you use the ApsaraVideo VOD console to upload a media file and do not specify a transcoding template group ID, ApsaraVideo VOD uses the default transcoding template group to transcode the media file. However, if you do not specify a transcoding template group ID when you call the RegisterMedia operation, ApsaraVideo VOD does not automatically transcode the media file after the media file is registered. If you specify a transcoding template group ID, ApsaraVideo VOD uses the specified transcoding template group to transcode the media file.
          * > *   If the media file that you want to register is registered before, this operation returns only the unique media ID that is associated with the media file. No further processing is performed.
          *
          * @param request RegisterMediaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RegisterMediaResponse
         */
        public RegisterMediaResponse RegisterMediaWithOptions(RegisterMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterMetadatas))
            {
                query["RegisterMetadatas"] = request.RegisterMetadatas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateGroupId))
            {
                query["TemplateGroupId"] = request.TemplateGroupId;
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
                Action = "RegisterMedia",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterMediaResponse>(CallApi(params_, req, runtime));
        }

        /**
          * After you store an audio or video file in an Object Storage Service (OSS) bucket that is used for ApsaraVideo VOD, you can call the RegisterMedia operation to register the media file. After the media file is registered, you can use the media ID associated with the media file to submit transcoding jobs and snapshot jobs in ApsaraVideo VOD. For more information, see [SubmitTranscodeJobs](~~68570~~) and [SubmitSnapshotJob](~~72213~~).
          * > *   You can register up to 10 OSS media files that have the same storage location at a time.
          * > *   If you use the ApsaraVideo VOD console to upload a media file and do not specify a transcoding template group ID, ApsaraVideo VOD uses the default transcoding template group to transcode the media file. However, if you do not specify a transcoding template group ID when you call the RegisterMedia operation, ApsaraVideo VOD does not automatically transcode the media file after the media file is registered. If you specify a transcoding template group ID, ApsaraVideo VOD uses the specified transcoding template group to transcode the media file.
          * > *   If the media file that you want to register is registered before, this operation returns only the unique media ID that is associated with the media file. No further processing is performed.
          *
          * @param request RegisterMediaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RegisterMediaResponse
         */
        public async Task<RegisterMediaResponse> RegisterMediaWithOptionsAsync(RegisterMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterMetadatas))
            {
                query["RegisterMetadatas"] = request.RegisterMetadatas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateGroupId))
            {
                query["TemplateGroupId"] = request.TemplateGroupId;
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
                Action = "RegisterMedia",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * After you store an audio or video file in an Object Storage Service (OSS) bucket that is used for ApsaraVideo VOD, you can call the RegisterMedia operation to register the media file. After the media file is registered, you can use the media ID associated with the media file to submit transcoding jobs and snapshot jobs in ApsaraVideo VOD. For more information, see [SubmitTranscodeJobs](~~68570~~) and [SubmitSnapshotJob](~~72213~~).
          * > *   You can register up to 10 OSS media files that have the same storage location at a time.
          * > *   If you use the ApsaraVideo VOD console to upload a media file and do not specify a transcoding template group ID, ApsaraVideo VOD uses the default transcoding template group to transcode the media file. However, if you do not specify a transcoding template group ID when you call the RegisterMedia operation, ApsaraVideo VOD does not automatically transcode the media file after the media file is registered. If you specify a transcoding template group ID, ApsaraVideo VOD uses the specified transcoding template group to transcode the media file.
          * > *   If the media file that you want to register is registered before, this operation returns only the unique media ID that is associated with the media file. No further processing is performed.
          *
          * @param request RegisterMediaRequest
          * @return RegisterMediaResponse
         */
        public RegisterMediaResponse RegisterMedia(RegisterMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterMediaWithOptions(request, runtime);
        }

        /**
          * After you store an audio or video file in an Object Storage Service (OSS) bucket that is used for ApsaraVideo VOD, you can call the RegisterMedia operation to register the media file. After the media file is registered, you can use the media ID associated with the media file to submit transcoding jobs and snapshot jobs in ApsaraVideo VOD. For more information, see [SubmitTranscodeJobs](~~68570~~) and [SubmitSnapshotJob](~~72213~~).
          * > *   You can register up to 10 OSS media files that have the same storage location at a time.
          * > *   If you use the ApsaraVideo VOD console to upload a media file and do not specify a transcoding template group ID, ApsaraVideo VOD uses the default transcoding template group to transcode the media file. However, if you do not specify a transcoding template group ID when you call the RegisterMedia operation, ApsaraVideo VOD does not automatically transcode the media file after the media file is registered. If you specify a transcoding template group ID, ApsaraVideo VOD uses the specified transcoding template group to transcode the media file.
          * > *   If the media file that you want to register is registered before, this operation returns only the unique media ID that is associated with the media file. No further processing is performed.
          *
          * @param request RegisterMediaRequest
          * @return RegisterMediaResponse
         */
        public async Task<RegisterMediaResponse> RegisterMediaAsync(RegisterMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterMediaWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to restore only Archive and Cold Archive audio and video files. You can access the audio and video files after the files are restored. You cannot change the storage class of an audio or video file that is being restored. You are charged for the retrieval traffic generated during restoration. After a Cold Archive audio or video file is restored, a Standard replica of the file is generated for access. You are charged for the storage of the replica before the file returns to the frozen state.
          *
          * @param request RestoreMediaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RestoreMediaResponse
         */
        public RestoreMediaResponse RestoreMediaWithOptions(RestoreMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreDays))
            {
                query["RestoreDays"] = request.RestoreDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTier))
            {
                query["RestoreTier"] = request.RestoreTier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreMedia",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreMediaResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to restore only Archive and Cold Archive audio and video files. You can access the audio and video files after the files are restored. You cannot change the storage class of an audio or video file that is being restored. You are charged for the retrieval traffic generated during restoration. After a Cold Archive audio or video file is restored, a Standard replica of the file is generated for access. You are charged for the storage of the replica before the file returns to the frozen state.
          *
          * @param request RestoreMediaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RestoreMediaResponse
         */
        public async Task<RestoreMediaResponse> RestoreMediaWithOptionsAsync(RestoreMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreDays))
            {
                query["RestoreDays"] = request.RestoreDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTier))
            {
                query["RestoreTier"] = request.RestoreTier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreMedia",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestoreMediaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to restore only Archive and Cold Archive audio and video files. You can access the audio and video files after the files are restored. You cannot change the storage class of an audio or video file that is being restored. You are charged for the retrieval traffic generated during restoration. After a Cold Archive audio or video file is restored, a Standard replica of the file is generated for access. You are charged for the storage of the replica before the file returns to the frozen state.
          *
          * @param request RestoreMediaRequest
          * @return RestoreMediaResponse
         */
        public RestoreMediaResponse RestoreMedia(RestoreMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreMediaWithOptions(request, runtime);
        }

        /**
          * You can call this operation to restore only Archive and Cold Archive audio and video files. You can access the audio and video files after the files are restored. You cannot change the storage class of an audio or video file that is being restored. You are charged for the retrieval traffic generated during restoration. After a Cold Archive audio or video file is restored, a Standard replica of the file is generated for access. You are charged for the storage of the replica before the file returns to the frozen state.
          *
          * @param request RestoreMediaRequest
          * @return RestoreMediaResponse
         */
        public async Task<RestoreMediaResponse> RestoreMediaAsync(RestoreMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreMediaWithOptionsAsync(request, runtime);
        }

        public SearchEditingProjectResponse SearchEditingProjectWithOptions(SearchEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "SearchEditingProject",
                Version = "2017-03-21",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
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
                Action = "SearchEditingProject",
                Version = "2017-03-21",
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

        /**
          * The maximum number of data records that you can query is limited based on the method used to query the data. You can use the following methods to query data:
          * *   Method 1: You must use the PageNo and PageSize parameters for the first 5,000 data records that meet the specified filter condition. This allows you to traverse data page by page. If the number of data records that meet the specified filter condition exceeds 5,000, use Method 2.
          * *   Method 2: This method applies only to the data of video and audio files. To traverse all the data records that meet the specified filter condition, you must set the PageNo, PageSize, and ScrollToken parameters to traverse data page by page. The total number of data records from the current page to the target page cannot exceed 1,200. Assume that the PageSize parameter is set to **20**:
          *     *   When the PageNo parameter is set to **1**, you can scroll forward to traverse data records from page 1 to page **60** at most.
          *     *   When the PageNo parameter is set to **2**, you can scroll forward to traverse data records from page 2 to page **61** at most.
          *     *   When the PageNo parameter is set to **61**, you can scroll backward to traverse data records from page 61 to page **2** at most or scroll forward to traverse data records from page 61 to page **120** at most.
          *
          * @param request SearchMediaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SearchMediaResponse
         */
        public SearchMediaResponse SearchMediaWithOptions(SearchMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                query["Fields"] = request.Fields;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["SearchType"] = request.SearchType;
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
                Version = "2017-03-21",
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
          * The maximum number of data records that you can query is limited based on the method used to query the data. You can use the following methods to query data:
          * *   Method 1: You must use the PageNo and PageSize parameters for the first 5,000 data records that meet the specified filter condition. This allows you to traverse data page by page. If the number of data records that meet the specified filter condition exceeds 5,000, use Method 2.
          * *   Method 2: This method applies only to the data of video and audio files. To traverse all the data records that meet the specified filter condition, you must set the PageNo, PageSize, and ScrollToken parameters to traverse data page by page. The total number of data records from the current page to the target page cannot exceed 1,200. Assume that the PageSize parameter is set to **20**:
          *     *   When the PageNo parameter is set to **1**, you can scroll forward to traverse data records from page 1 to page **60** at most.
          *     *   When the PageNo parameter is set to **2**, you can scroll forward to traverse data records from page 2 to page **61** at most.
          *     *   When the PageNo parameter is set to **61**, you can scroll backward to traverse data records from page 61 to page **2** at most or scroll forward to traverse data records from page 61 to page **120** at most.
          *
          * @param request SearchMediaRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SearchMediaResponse
         */
        public async Task<SearchMediaResponse> SearchMediaWithOptionsAsync(SearchMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                query["Fields"] = request.Fields;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["SearchType"] = request.SearchType;
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
                Version = "2017-03-21",
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
          * The maximum number of data records that you can query is limited based on the method used to query the data. You can use the following methods to query data:
          * *   Method 1: You must use the PageNo and PageSize parameters for the first 5,000 data records that meet the specified filter condition. This allows you to traverse data page by page. If the number of data records that meet the specified filter condition exceeds 5,000, use Method 2.
          * *   Method 2: This method applies only to the data of video and audio files. To traverse all the data records that meet the specified filter condition, you must set the PageNo, PageSize, and ScrollToken parameters to traverse data page by page. The total number of data records from the current page to the target page cannot exceed 1,200. Assume that the PageSize parameter is set to **20**:
          *     *   When the PageNo parameter is set to **1**, you can scroll forward to traverse data records from page 1 to page **60** at most.
          *     *   When the PageNo parameter is set to **2**, you can scroll forward to traverse data records from page 2 to page **61** at most.
          *     *   When the PageNo parameter is set to **61**, you can scroll backward to traverse data records from page 61 to page **2** at most or scroll forward to traverse data records from page 61 to page **120** at most.
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
          * The maximum number of data records that you can query is limited based on the method used to query the data. You can use the following methods to query data:
          * *   Method 1: You must use the PageNo and PageSize parameters for the first 5,000 data records that meet the specified filter condition. This allows you to traverse data page by page. If the number of data records that meet the specified filter condition exceeds 5,000, use Method 2.
          * *   Method 2: This method applies only to the data of video and audio files. To traverse all the data records that meet the specified filter condition, you must set the PageNo, PageSize, and ScrollToken parameters to traverse data page by page. The total number of data records from the current page to the target page cannot exceed 1,200. Assume that the PageSize parameter is set to **20**:
          *     *   When the PageNo parameter is set to **1**, you can scroll forward to traverse data records from page 1 to page **60** at most.
          *     *   When the PageNo parameter is set to **2**, you can scroll forward to traverse data records from page 2 to page **61** at most.
          *     *   When the PageNo parameter is set to **61**, you can scroll backward to traverse data records from page 61 to page **2** at most or scroll forward to traverse data records from page 61 to page **120** at most.
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
          * > You can play videos in the Checking or Blocked state only from the IP addresses that are added to review security groups.
          *
          * @param request SetAuditSecurityIpRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetAuditSecurityIpResponse
         */
        public SetAuditSecurityIpResponse SetAuditSecurityIpWithOptions(SetAuditSecurityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ips))
            {
                query["Ips"] = request.Ips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateMode))
            {
                query["OperateMode"] = request.OperateMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupName))
            {
                query["SecurityGroupName"] = request.SecurityGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAuditSecurityIp",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAuditSecurityIpResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > You can play videos in the Checking or Blocked state only from the IP addresses that are added to review security groups.
          *
          * @param request SetAuditSecurityIpRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetAuditSecurityIpResponse
         */
        public async Task<SetAuditSecurityIpResponse> SetAuditSecurityIpWithOptionsAsync(SetAuditSecurityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ips))
            {
                query["Ips"] = request.Ips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateMode))
            {
                query["OperateMode"] = request.OperateMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupName))
            {
                query["SecurityGroupName"] = request.SecurityGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAuditSecurityIp",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAuditSecurityIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > You can play videos in the Checking or Blocked state only from the IP addresses that are added to review security groups.
          *
          * @param request SetAuditSecurityIpRequest
          * @return SetAuditSecurityIpResponse
         */
        public SetAuditSecurityIpResponse SetAuditSecurityIp(SetAuditSecurityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAuditSecurityIpWithOptions(request, runtime);
        }

        /**
          * > You can play videos in the Checking or Blocked state only from the IP addresses that are added to review security groups.
          *
          * @param request SetAuditSecurityIpRequest
          * @return SetAuditSecurityIpResponse
         */
        public async Task<SetAuditSecurityIpResponse> SetAuditSecurityIpAsync(SetAuditSecurityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAuditSecurityIpWithOptionsAsync(request, runtime);
        }

        /**
          * > After you use the cross-domain policy file to update the resources on the origin server, you must refresh the resources that are cached on Alibaba Cloud CDN nodes. You can use the ApsaraVideo VOD console to refresh resources. For more information, see [Refresh and prefetch](~~86098~~). Alternatively, you can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh resources.
          *
          * @param request SetCrossdomainContentRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetCrossdomainContentResponse
         */
        public SetCrossdomainContentResponse SetCrossdomainContentWithOptions(SetCrossdomainContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRealOwnerId))
            {
                query["ResourceRealOwnerId"] = request.ResourceRealOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageLocation))
            {
                query["StorageLocation"] = request.StorageLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCrossdomainContent",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCrossdomainContentResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > After you use the cross-domain policy file to update the resources on the origin server, you must refresh the resources that are cached on Alibaba Cloud CDN nodes. You can use the ApsaraVideo VOD console to refresh resources. For more information, see [Refresh and prefetch](~~86098~~). Alternatively, you can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh resources.
          *
          * @param request SetCrossdomainContentRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetCrossdomainContentResponse
         */
        public async Task<SetCrossdomainContentResponse> SetCrossdomainContentWithOptionsAsync(SetCrossdomainContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRealOwnerId))
            {
                query["ResourceRealOwnerId"] = request.ResourceRealOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageLocation))
            {
                query["StorageLocation"] = request.StorageLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCrossdomainContent",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCrossdomainContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > After you use the cross-domain policy file to update the resources on the origin server, you must refresh the resources that are cached on Alibaba Cloud CDN nodes. You can use the ApsaraVideo VOD console to refresh resources. For more information, see [Refresh and prefetch](~~86098~~). Alternatively, you can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh resources.
          *
          * @param request SetCrossdomainContentRequest
          * @return SetCrossdomainContentResponse
         */
        public SetCrossdomainContentResponse SetCrossdomainContent(SetCrossdomainContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCrossdomainContentWithOptions(request, runtime);
        }

        /**
          * > After you use the cross-domain policy file to update the resources on the origin server, you must refresh the resources that are cached on Alibaba Cloud CDN nodes. You can use the ApsaraVideo VOD console to refresh resources. For more information, see [Refresh and prefetch](~~86098~~). Alternatively, you can call the [RefreshVodObjectCaches](~~69215~~) operation to refresh resources.
          *
          * @param request SetCrossdomainContentRequest
          * @return SetCrossdomainContentResponse
         */
        public async Task<SetCrossdomainContentResponse> SetCrossdomainContentAsync(SetCrossdomainContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCrossdomainContentWithOptionsAsync(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   Before you can call this operation to specify an AI template as the default template, you must obtain the ID of the AI template. You cannot delete an AI template that is set as the default template.
          *
          * @param request SetDefaultAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetDefaultAITemplateResponse
         */
        public SetDefaultAITemplateResponse SetDefaultAITemplateWithOptions(SetDefaultAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SetDefaultAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultAITemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   Before you can call this operation to specify an AI template as the default template, you must obtain the ID of the AI template. You cannot delete an AI template that is set as the default template.
          *
          * @param request SetDefaultAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetDefaultAITemplateResponse
         */
        public async Task<SetDefaultAITemplateResponse> SetDefaultAITemplateWithOptionsAsync(SetDefaultAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SetDefaultAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultAITemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   Before you can call this operation to specify an AI template as the default template, you must obtain the ID of the AI template. You cannot delete an AI template that is set as the default template.
          *
          * @param request SetDefaultAITemplateRequest
          * @return SetDefaultAITemplateResponse
         */
        public SetDefaultAITemplateResponse SetDefaultAITemplate(SetDefaultAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultAITemplateWithOptions(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   Before you can call this operation to specify an AI template as the default template, you must obtain the ID of the AI template. You cannot delete an AI template that is set as the default template.
          *
          * @param request SetDefaultAITemplateRequest
          * @return SetDefaultAITemplateResponse
         */
        public async Task<SetDefaultAITemplateResponse> SetDefaultAITemplateAsync(SetDefaultAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultAITemplateWithOptionsAsync(request, runtime);
        }

        public SetDefaultTranscodeTemplateGroupResponse SetDefaultTranscodeTemplateGroupWithOptions(SetDefaultTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateGroupId))
            {
                query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultTranscodeTemplateGroup",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultTranscodeTemplateGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDefaultTranscodeTemplateGroupResponse> SetDefaultTranscodeTemplateGroupWithOptionsAsync(SetDefaultTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateGroupId))
            {
                query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultTranscodeTemplateGroup",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultTranscodeTemplateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDefaultTranscodeTemplateGroupResponse SetDefaultTranscodeTemplateGroup(SetDefaultTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultTranscodeTemplateGroupWithOptions(request, runtime);
        }

        public async Task<SetDefaultTranscodeTemplateGroupResponse> SetDefaultTranscodeTemplateGroupAsync(SetDefaultTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultTranscodeTemplateGroupWithOptionsAsync(request, runtime);
        }

        public SetDefaultWatermarkResponse SetDefaultWatermarkWithOptions(SetDefaultWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkId))
            {
                query["WatermarkId"] = request.WatermarkId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultWatermark",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultWatermarkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetDefaultWatermarkResponse> SetDefaultWatermarkWithOptionsAsync(SetDefaultWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkId))
            {
                query["WatermarkId"] = request.WatermarkId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultWatermark",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultWatermarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetDefaultWatermarkResponse SetDefaultWatermark(SetDefaultWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultWatermarkWithOptions(request, runtime);
        }

        public async Task<SetDefaultWatermarkResponse> SetDefaultWatermarkAsync(SetDefaultWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultWatermarkWithOptionsAsync(request, runtime);
        }

        public SetEditingProjectMaterialsResponse SetEditingProjectMaterialsWithOptions(SetEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialIds))
            {
                query["MaterialIds"] = request.MaterialIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "SetEditingProjectMaterials",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetEditingProjectMaterialsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetEditingProjectMaterialsResponse> SetEditingProjectMaterialsWithOptionsAsync(SetEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialIds))
            {
                query["MaterialIds"] = request.MaterialIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
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
                Action = "SetEditingProjectMaterials",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetEditingProjectMaterialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetEditingProjectMaterialsResponse SetEditingProjectMaterials(SetEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetEditingProjectMaterialsWithOptions(request, runtime);
        }

        public async Task<SetEditingProjectMaterialsResponse> SetEditingProjectMaterialsAsync(SetEditingProjectMaterialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetEditingProjectMaterialsWithOptionsAsync(request, runtime);
        }

        /**
          * ## Usage note
          * ApsaraVideo VOD supports the HTTP and MNS callback methods. For more information, see [Event notification](~~55627~~).
          *
          * @param request SetMessageCallbackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetMessageCallbackResponse
         */
        public SetMessageCallbackResponse SetMessageCallbackWithOptions(SetMessageCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSwitch))
            {
                query["AuthSwitch"] = request.AuthSwitch;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MnsEndpoint))
            {
                query["MnsEndpoint"] = request.MnsEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MnsQueueName))
            {
                query["MnsQueueName"] = request.MnsQueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetMessageCallback",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetMessageCallbackResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Usage note
          * ApsaraVideo VOD supports the HTTP and MNS callback methods. For more information, see [Event notification](~~55627~~).
          *
          * @param request SetMessageCallbackRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetMessageCallbackResponse
         */
        public async Task<SetMessageCallbackResponse> SetMessageCallbackWithOptionsAsync(SetMessageCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSwitch))
            {
                query["AuthSwitch"] = request.AuthSwitch;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MnsEndpoint))
            {
                query["MnsEndpoint"] = request.MnsEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MnsQueueName))
            {
                query["MnsQueueName"] = request.MnsQueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetMessageCallback",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetMessageCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Usage note
          * ApsaraVideo VOD supports the HTTP and MNS callback methods. For more information, see [Event notification](~~55627~~).
          *
          * @param request SetMessageCallbackRequest
          * @return SetMessageCallbackResponse
         */
        public SetMessageCallbackResponse SetMessageCallback(SetMessageCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetMessageCallbackWithOptions(request, runtime);
        }

        /**
          * ## Usage note
          * ApsaraVideo VOD supports the HTTP and MNS callback methods. For more information, see [Event notification](~~55627~~).
          *
          * @param request SetMessageCallbackRequest
          * @return SetMessageCallbackResponse
         */
        public async Task<SetMessageCallbackResponse> SetMessageCallbackAsync(SetMessageCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetMessageCallbackWithOptionsAsync(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request SetVodDomainCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetVodDomainCertificateResponse
         */
        public SetVodDomainCertificateResponse SetVodDomainCertificateWithOptions(SetVodDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPri))
            {
                query["SSLPri"] = request.SSLPri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLProtocol))
            {
                query["SSLProtocol"] = request.SSLProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPub))
            {
                query["SSLPub"] = request.SSLPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetVodDomainCertificate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetVodDomainCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request SetVodDomainCertificateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SetVodDomainCertificateResponse
         */
        public async Task<SetVodDomainCertificateResponse> SetVodDomainCertificateWithOptionsAsync(SetVodDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPri))
            {
                query["SSLPri"] = request.SSLPri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLProtocol))
            {
                query["SSLProtocol"] = request.SSLProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLPub))
            {
                query["SSLPub"] = request.SSLPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetVodDomainCertificate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetVodDomainCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request SetVodDomainCertificateRequest
          * @return SetVodDomainCertificateResponse
         */
        public SetVodDomainCertificateResponse SetVodDomainCertificate(SetVodDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetVodDomainCertificateWithOptions(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request SetVodDomainCertificateRequest
          * @return SetVodDomainCertificateResponse
         */
        public async Task<SetVodDomainCertificateResponse> SetVodDomainCertificateAsync(SetVodDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetVodDomainCertificateWithOptionsAsync(request, runtime);
        }

        public SubmitAIImageAuditJobResponse SubmitAIImageAuditJobWithOptions(SubmitAIImageAuditJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaAuditConfiguration))
            {
                query["MediaAuditConfiguration"] = request.MediaAuditConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "SubmitAIImageAuditJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAIImageAuditJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitAIImageAuditJobResponse> SubmitAIImageAuditJobWithOptionsAsync(SubmitAIImageAuditJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaAuditConfiguration))
            {
                query["MediaAuditConfiguration"] = request.MediaAuditConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "SubmitAIImageAuditJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAIImageAuditJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitAIImageAuditJobResponse SubmitAIImageAuditJob(SubmitAIImageAuditJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAIImageAuditJobWithOptions(request, runtime);
        }

        public async Task<SubmitAIImageAuditJobResponse> SubmitAIImageAuditJobAsync(SubmitAIImageAuditJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAIImageAuditJobWithOptionsAsync(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   After you call this operation, you can call the [GetAIImageJobs](~~186923~~) operation to query the job execution result.
          *
          * @param request SubmitAIImageJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitAIImageJobResponse
         */
        public SubmitAIImageJobResponse SubmitAIImageJobWithOptions(SubmitAIImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AIPipelineId))
            {
                query["AIPipelineId"] = request.AIPipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AITemplateId))
            {
                query["AITemplateId"] = request.AITemplateId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAIImageJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAIImageJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   After you call this operation, you can call the [GetAIImageJobs](~~186923~~) operation to query the job execution result.
          *
          * @param request SubmitAIImageJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitAIImageJobResponse
         */
        public async Task<SubmitAIImageJobResponse> SubmitAIImageJobWithOptionsAsync(SubmitAIImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AIPipelineId))
            {
                query["AIPipelineId"] = request.AIPipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AITemplateId))
            {
                query["AITemplateId"] = request.AITemplateId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitAIImageJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAIImageJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   After you call this operation, you can call the [GetAIImageJobs](~~186923~~) operation to query the job execution result.
          *
          * @param request SubmitAIImageJobRequest
          * @return SubmitAIImageJobResponse
         */
        public SubmitAIImageJobResponse SubmitAIImageJob(SubmitAIImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAIImageJobWithOptions(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)** and **China (Shanghai)**.
          * *   After you call this operation, you can call the [GetAIImageJobs](~~186923~~) operation to query the job execution result.
          *
          * @param request SubmitAIImageJobRequest
          * @return SubmitAIImageJobResponse
         */
        public async Task<SubmitAIImageJobResponse> SubmitAIImageJobAsync(SubmitAIImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAIImageJobWithOptionsAsync(request, runtime);
        }

        /**
          * *   Regions that support the video fingerprinting feature: **China (Beijing)**, **China (Shanghai)**, and **Singapore**. Regions that support the smart tagging feature: **China (Beijing)** and **China (Shanghai)**.
          * *   You need to enable the video fingerprinting feature or the smart tagging feature before you can call this operation to submit jobs. For more information, see [Video AI](~~101148~~).
          * *   If this is the first time you use the video fingerprinting feature, you must [submit a ticket](https://yida.alibaba-inc.com/o/ticketapply) to apply for using the media fingerprint library for free. Otherwise, the video fingerprinting feature will be affected.
          * *   After you submit an AI job, ApsaraVideo VOD asynchronously processes the job. The operation may return a response before the job is complete. You can configure the [Event Notification](~~55627~~) feature and set the callback event to **AI Processing Completed**. After you receive the event notification, you can query the execution result of the AI job.
          *
          * @param request SubmitAIJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitAIJobResponse
         */
        public SubmitAIJobResponse SubmitAIJobWithOptions(SubmitAIJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
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
                Action = "SubmitAIJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAIJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support the video fingerprinting feature: **China (Beijing)**, **China (Shanghai)**, and **Singapore**. Regions that support the smart tagging feature: **China (Beijing)** and **China (Shanghai)**.
          * *   You need to enable the video fingerprinting feature or the smart tagging feature before you can call this operation to submit jobs. For more information, see [Video AI](~~101148~~).
          * *   If this is the first time you use the video fingerprinting feature, you must [submit a ticket](https://yida.alibaba-inc.com/o/ticketapply) to apply for using the media fingerprint library for free. Otherwise, the video fingerprinting feature will be affected.
          * *   After you submit an AI job, ApsaraVideo VOD asynchronously processes the job. The operation may return a response before the job is complete. You can configure the [Event Notification](~~55627~~) feature and set the callback event to **AI Processing Completed**. After you receive the event notification, you can query the execution result of the AI job.
          *
          * @param request SubmitAIJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitAIJobResponse
         */
        public async Task<SubmitAIJobResponse> SubmitAIJobWithOptionsAsync(SubmitAIJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
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
                Action = "SubmitAIJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAIJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support the video fingerprinting feature: **China (Beijing)**, **China (Shanghai)**, and **Singapore**. Regions that support the smart tagging feature: **China (Beijing)** and **China (Shanghai)**.
          * *   You need to enable the video fingerprinting feature or the smart tagging feature before you can call this operation to submit jobs. For more information, see [Video AI](~~101148~~).
          * *   If this is the first time you use the video fingerprinting feature, you must [submit a ticket](https://yida.alibaba-inc.com/o/ticketapply) to apply for using the media fingerprint library for free. Otherwise, the video fingerprinting feature will be affected.
          * *   After you submit an AI job, ApsaraVideo VOD asynchronously processes the job. The operation may return a response before the job is complete. You can configure the [Event Notification](~~55627~~) feature and set the callback event to **AI Processing Completed**. After you receive the event notification, you can query the execution result of the AI job.
          *
          * @param request SubmitAIJobRequest
          * @return SubmitAIJobResponse
         */
        public SubmitAIJobResponse SubmitAIJob(SubmitAIJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAIJobWithOptions(request, runtime);
        }

        /**
          * *   Regions that support the video fingerprinting feature: **China (Beijing)**, **China (Shanghai)**, and **Singapore**. Regions that support the smart tagging feature: **China (Beijing)** and **China (Shanghai)**.
          * *   You need to enable the video fingerprinting feature or the smart tagging feature before you can call this operation to submit jobs. For more information, see [Video AI](~~101148~~).
          * *   If this is the first time you use the video fingerprinting feature, you must [submit a ticket](https://yida.alibaba-inc.com/o/ticketapply) to apply for using the media fingerprint library for free. Otherwise, the video fingerprinting feature will be affected.
          * *   After you submit an AI job, ApsaraVideo VOD asynchronously processes the job. The operation may return a response before the job is complete. You can configure the [Event Notification](~~55627~~) feature and set the callback event to **AI Processing Completed**. After you receive the event notification, you can query the execution result of the AI job.
          *
          * @param request SubmitAIJobRequest
          * @return SubmitAIJobResponse
         */
        public async Task<SubmitAIJobResponse> SubmitAIJobAsync(SubmitAIJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAIJobWithOptionsAsync(request, runtime);
        }

        public SubmitAIMediaAuditJobResponse SubmitAIMediaAuditJobWithOptions(SubmitAIMediaAuditJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaAuditConfiguration))
            {
                query["MediaAuditConfiguration"] = request.MediaAuditConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
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
                Action = "SubmitAIMediaAuditJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAIMediaAuditJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitAIMediaAuditJobResponse> SubmitAIMediaAuditJobWithOptionsAsync(SubmitAIMediaAuditJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaAuditConfiguration))
            {
                query["MediaAuditConfiguration"] = request.MediaAuditConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
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
                Action = "SubmitAIMediaAuditJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitAIMediaAuditJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitAIMediaAuditJobResponse SubmitAIMediaAuditJob(SubmitAIMediaAuditJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAIMediaAuditJobWithOptions(request, runtime);
        }

        public async Task<SubmitAIMediaAuditJobResponse> SubmitAIMediaAuditJobAsync(SubmitAIMediaAuditJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAIMediaAuditJobWithOptionsAsync(request, runtime);
        }

        /**
          * *   You must upload the video from which you want to extract the digital watermark to ApsaraVideo VOD.
          * *   The duration of the video from which you want to extract the digital watermark must exceed 3 minutes.
          *
          * @param request SubmitDigitalWatermarkExtractJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitDigitalWatermarkExtractJobResponse
         */
        public SubmitDigitalWatermarkExtractJobResponse SubmitDigitalWatermarkExtractJobWithOptions(SubmitDigitalWatermarkExtractJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractType))
            {
                query["ExtractType"] = request.ExtractType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "SubmitDigitalWatermarkExtractJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDigitalWatermarkExtractJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You must upload the video from which you want to extract the digital watermark to ApsaraVideo VOD.
          * *   The duration of the video from which you want to extract the digital watermark must exceed 3 minutes.
          *
          * @param request SubmitDigitalWatermarkExtractJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitDigitalWatermarkExtractJobResponse
         */
        public async Task<SubmitDigitalWatermarkExtractJobResponse> SubmitDigitalWatermarkExtractJobWithOptionsAsync(SubmitDigitalWatermarkExtractJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractType))
            {
                query["ExtractType"] = request.ExtractType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "SubmitDigitalWatermarkExtractJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDigitalWatermarkExtractJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You must upload the video from which you want to extract the digital watermark to ApsaraVideo VOD.
          * *   The duration of the video from which you want to extract the digital watermark must exceed 3 minutes.
          *
          * @param request SubmitDigitalWatermarkExtractJobRequest
          * @return SubmitDigitalWatermarkExtractJobResponse
         */
        public SubmitDigitalWatermarkExtractJobResponse SubmitDigitalWatermarkExtractJob(SubmitDigitalWatermarkExtractJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDigitalWatermarkExtractJobWithOptions(request, runtime);
        }

        /**
          * *   You must upload the video from which you want to extract the digital watermark to ApsaraVideo VOD.
          * *   The duration of the video from which you want to extract the digital watermark must exceed 3 minutes.
          *
          * @param request SubmitDigitalWatermarkExtractJobRequest
          * @return SubmitDigitalWatermarkExtractJobResponse
         */
        public async Task<SubmitDigitalWatermarkExtractJobResponse> SubmitDigitalWatermarkExtractJobAsync(SubmitDigitalWatermarkExtractJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDigitalWatermarkExtractJobWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can capture a part of a video and generate animated images only when the video is in the **Uploaded**, **Transcoding**, **Normal**, **Reviewing**, or **Flagged** state.
          * *   The fees for frame animation are included in your video transcoding bill. You are charged based on the output resolution and the duration. For more information, see [Billing of basic services](~~188308~~).
          * ### QPS limits
          * You can call this operation up to 30 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on API operations](~~342790~~).
          *
          * @param request SubmitDynamicImageJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitDynamicImageJobResponse
         */
        public SubmitDynamicImageJobResponse SubmitDynamicImageJobWithOptions(SubmitDynamicImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicImageTemplateId))
            {
                query["DynamicImageTemplateId"] = request.DynamicImageTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverrideParams))
            {
                query["OverrideParams"] = request.OverrideParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDynamicImageJob",
                Version = "2017-03-21",
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
          * *   You can capture a part of a video and generate animated images only when the video is in the **Uploaded**, **Transcoding**, **Normal**, **Reviewing**, or **Flagged** state.
          * *   The fees for frame animation are included in your video transcoding bill. You are charged based on the output resolution and the duration. For more information, see [Billing of basic services](~~188308~~).
          * ### QPS limits
          * You can call this operation up to 30 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on API operations](~~342790~~).
          *
          * @param request SubmitDynamicImageJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitDynamicImageJobResponse
         */
        public async Task<SubmitDynamicImageJobResponse> SubmitDynamicImageJobWithOptionsAsync(SubmitDynamicImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicImageTemplateId))
            {
                query["DynamicImageTemplateId"] = request.DynamicImageTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverrideParams))
            {
                query["OverrideParams"] = request.OverrideParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDynamicImageJob",
                Version = "2017-03-21",
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
          * *   You can capture a part of a video and generate animated images only when the video is in the **Uploaded**, **Transcoding**, **Normal**, **Reviewing**, or **Flagged** state.
          * *   The fees for frame animation are included in your video transcoding bill. You are charged based on the output resolution and the duration. For more information, see [Billing of basic services](~~188308~~).
          * ### QPS limits
          * You can call this operation up to 30 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on API operations](~~342790~~).
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
          * *   You can capture a part of a video and generate animated images only when the video is in the **Uploaded**, **Transcoding**, **Normal**, **Reviewing**, or **Flagged** state.
          * *   The fees for frame animation are included in your video transcoding bill. You are charged based on the output resolution and the duration. For more information, see [Billing of basic services](~~188308~~).
          * ### QPS limits
          * You can call this operation up to 30 times per second per account. Requests that exceed this limit are dropped and you will experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see [QPS limit on API operations](~~342790~~).
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
          * Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          *
          * @param request SubmitMediaDNADeleteJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitMediaDNADeleteJobResponse
         */
        public SubmitMediaDNADeleteJobResponse SubmitMediaDNADeleteJobWithOptions(SubmitMediaDNADeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "SubmitMediaDNADeleteJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMediaDNADeleteJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          *
          * @param request SubmitMediaDNADeleteJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitMediaDNADeleteJobResponse
         */
        public async Task<SubmitMediaDNADeleteJobResponse> SubmitMediaDNADeleteJobWithOptionsAsync(SubmitMediaDNADeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "SubmitMediaDNADeleteJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMediaDNADeleteJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          *
          * @param request SubmitMediaDNADeleteJobRequest
          * @return SubmitMediaDNADeleteJobResponse
         */
        public SubmitMediaDNADeleteJobResponse SubmitMediaDNADeleteJob(SubmitMediaDNADeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaDNADeleteJobWithOptions(request, runtime);
        }

        /**
          * Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          *
          * @param request SubmitMediaDNADeleteJobRequest
          * @return SubmitMediaDNADeleteJobResponse
         */
        public async Task<SubmitMediaDNADeleteJobResponse> SubmitMediaDNADeleteJobAsync(SubmitMediaDNADeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaDNADeleteJobWithOptionsAsync(request, runtime);
        }

        /**
          * *   During video preprocessing, videos are transcoded to meet the playback requirements of the production studio. Therefore, you are **charged** for video preprocessing. You can submit a ticket for information about the **production studio** service.
          *  *   You can obtain the preprocessing result in the [TranscodeComplete](~~55638~~) event notification. If the value of the **Preprocess** parameter is true in the event notification, the video is preprocessed.
          *
          * @param request SubmitPreprocessJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitPreprocessJobsResponse
         */
        public SubmitPreprocessJobsResponse SubmitPreprocessJobsWithOptions(SubmitPreprocessJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreprocessType))
            {
                query["PreprocessType"] = request.PreprocessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitPreprocessJobs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitPreprocessJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   During video preprocessing, videos are transcoded to meet the playback requirements of the production studio. Therefore, you are **charged** for video preprocessing. You can submit a ticket for information about the **production studio** service.
          *  *   You can obtain the preprocessing result in the [TranscodeComplete](~~55638~~) event notification. If the value of the **Preprocess** parameter is true in the event notification, the video is preprocessed.
          *
          * @param request SubmitPreprocessJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitPreprocessJobsResponse
         */
        public async Task<SubmitPreprocessJobsResponse> SubmitPreprocessJobsWithOptionsAsync(SubmitPreprocessJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreprocessType))
            {
                query["PreprocessType"] = request.PreprocessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitPreprocessJobs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitPreprocessJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   During video preprocessing, videos are transcoded to meet the playback requirements of the production studio. Therefore, you are **charged** for video preprocessing. You can submit a ticket for information about the **production studio** service.
          *  *   You can obtain the preprocessing result in the [TranscodeComplete](~~55638~~) event notification. If the value of the **Preprocess** parameter is true in the event notification, the video is preprocessed.
          *
          * @param request SubmitPreprocessJobsRequest
          * @return SubmitPreprocessJobsResponse
         */
        public SubmitPreprocessJobsResponse SubmitPreprocessJobs(SubmitPreprocessJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitPreprocessJobsWithOptions(request, runtime);
        }

        /**
          * *   During video preprocessing, videos are transcoded to meet the playback requirements of the production studio. Therefore, you are **charged** for video preprocessing. You can submit a ticket for information about the **production studio** service.
          *  *   You can obtain the preprocessing result in the [TranscodeComplete](~~55638~~) event notification. If the value of the **Preprocess** parameter is true in the event notification, the video is preprocessed.
          *
          * @param request SubmitPreprocessJobsRequest
          * @return SubmitPreprocessJobsResponse
         */
        public async Task<SubmitPreprocessJobsResponse> SubmitPreprocessJobsAsync(SubmitPreprocessJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitPreprocessJobsWithOptionsAsync(request, runtime);
        }

        /**
          * > *   Only snapshots in the JPG format are generated.
          * > *   After a snapshot job is complete, ApsaraVideo VOD sends a [SnapshotComplete](~~57337~~) event notification that contains EventType=SnapshotComplete and SubType=SpecifiedTime.
          *
          * @param request SubmitSnapshotJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitSnapshotJobResponse
         */
        public SubmitSnapshotJobResponse SubmitSnapshotJobWithOptions(SubmitSnapshotJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                query["Height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotTemplateId))
            {
                query["SnapshotTemplateId"] = request.SnapshotTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecifiedOffsetTime))
            {
                query["SpecifiedOffsetTime"] = request.SpecifiedOffsetTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpriteSnapshotConfig))
            {
                query["SpriteSnapshotConfig"] = request.SpriteSnapshotConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                query["Width"] = request.Width;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSnapshotJob",
                Version = "2017-03-21",
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
          * > *   Only snapshots in the JPG format are generated.
          * > *   After a snapshot job is complete, ApsaraVideo VOD sends a [SnapshotComplete](~~57337~~) event notification that contains EventType=SnapshotComplete and SubType=SpecifiedTime.
          *
          * @param request SubmitSnapshotJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitSnapshotJobResponse
         */
        public async Task<SubmitSnapshotJobResponse> SubmitSnapshotJobWithOptionsAsync(SubmitSnapshotJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                query["Height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotTemplateId))
            {
                query["SnapshotTemplateId"] = request.SnapshotTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecifiedOffsetTime))
            {
                query["SpecifiedOffsetTime"] = request.SpecifiedOffsetTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpriteSnapshotConfig))
            {
                query["SpriteSnapshotConfig"] = request.SpriteSnapshotConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                query["Width"] = request.Width;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitSnapshotJob",
                Version = "2017-03-21",
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
          * > *   Only snapshots in the JPG format are generated.
          * > *   After a snapshot job is complete, ApsaraVideo VOD sends a [SnapshotComplete](~~57337~~) event notification that contains EventType=SnapshotComplete and SubType=SpecifiedTime.
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
          * > *   Only snapshots in the JPG format are generated.
          * > *   After a snapshot job is complete, ApsaraVideo VOD sends a [SnapshotComplete](~~57337~~) event notification that contains EventType=SnapshotComplete and SubType=SpecifiedTime.
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
          * *   You can transcode a video only in the UploadSucc, Normal, or Checking state.
          *  *   You can obtain the transcoding result in the [StreamTranscodeComplete](~~55636~~) or [TranscodeComplete](~~55638~~) event notification.
          *  *   If you initiate an HTTP Live Streaming (HLS) packaging task, you can call this operation to dynamically override the subtitle. If the packaging task does not contain subtitles, we recommend that you do not call this operation to initiate the packaging task. Instead, you can specify the ID of the specific template group when you upload the video. The packaging process is automatically initiated.
          *
          * @param request SubmitTranscodeJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitTranscodeJobsResponse
         */
        public SubmitTranscodeJobsResponse SubmitTranscodeJobsWithOptions(SubmitTranscodeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptConfig))
            {
                query["EncryptConfig"] = request.EncryptConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverrideParams))
            {
                query["OverrideParams"] = request.OverrideParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateGroupId))
            {
                query["TemplateGroupId"] = request.TemplateGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitTranscodeJobs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTranscodeJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can transcode a video only in the UploadSucc, Normal, or Checking state.
          *  *   You can obtain the transcoding result in the [StreamTranscodeComplete](~~55636~~) or [TranscodeComplete](~~55638~~) event notification.
          *  *   If you initiate an HTTP Live Streaming (HLS) packaging task, you can call this operation to dynamically override the subtitle. If the packaging task does not contain subtitles, we recommend that you do not call this operation to initiate the packaging task. Instead, you can specify the ID of the specific template group when you upload the video. The packaging process is automatically initiated.
          *
          * @param request SubmitTranscodeJobsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SubmitTranscodeJobsResponse
         */
        public async Task<SubmitTranscodeJobsResponse> SubmitTranscodeJobsWithOptionsAsync(SubmitTranscodeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptConfig))
            {
                query["EncryptConfig"] = request.EncryptConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverrideParams))
            {
                query["OverrideParams"] = request.OverrideParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateGroupId))
            {
                query["TemplateGroupId"] = request.TemplateGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitTranscodeJobs",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTranscodeJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can transcode a video only in the UploadSucc, Normal, or Checking state.
          *  *   You can obtain the transcoding result in the [StreamTranscodeComplete](~~55636~~) or [TranscodeComplete](~~55638~~) event notification.
          *  *   If you initiate an HTTP Live Streaming (HLS) packaging task, you can call this operation to dynamically override the subtitle. If the packaging task does not contain subtitles, we recommend that you do not call this operation to initiate the packaging task. Instead, you can specify the ID of the specific template group when you upload the video. The packaging process is automatically initiated.
          *
          * @param request SubmitTranscodeJobsRequest
          * @return SubmitTranscodeJobsResponse
         */
        public SubmitTranscodeJobsResponse SubmitTranscodeJobs(SubmitTranscodeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTranscodeJobsWithOptions(request, runtime);
        }

        /**
          * *   You can transcode a video only in the UploadSucc, Normal, or Checking state.
          *  *   You can obtain the transcoding result in the [StreamTranscodeComplete](~~55636~~) or [TranscodeComplete](~~55638~~) event notification.
          *  *   If you initiate an HTTP Live Streaming (HLS) packaging task, you can call this operation to dynamically override the subtitle. If the packaging task does not contain subtitles, we recommend that you do not call this operation to initiate the packaging task. Instead, you can specify the ID of the specific template group when you upload the video. The packaging process is automatically initiated.
          *
          * @param request SubmitTranscodeJobsRequest
          * @return SubmitTranscodeJobsResponse
         */
        public async Task<SubmitTranscodeJobsResponse> SubmitTranscodeJobsAsync(SubmitTranscodeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitTranscodeJobsWithOptionsAsync(request, runtime);
        }

        public SubmitWorkflowJobResponse SubmitWorkflowJobWithOptions(SubmitWorkflowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "SubmitWorkflowJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitWorkflowJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitWorkflowJobResponse> SubmitWorkflowJobWithOptionsAsync(SubmitWorkflowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                query["MediaId"] = request.MediaId;
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
                Action = "SubmitWorkflowJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitWorkflowJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitWorkflowJobResponse SubmitWorkflowJob(SubmitWorkflowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitWorkflowJobWithOptions(request, runtime);
        }

        public async Task<SubmitWorkflowJobResponse> SubmitWorkflowJobAsync(SubmitWorkflowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitWorkflowJobWithOptionsAsync(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   After you call the [AddAITemplate](~~102930~~) operation to add an AI template, you can call this operation to modify the AI template.
          *
          * @param request UpdateAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAITemplateResponse
         */
        public UpdateAITemplateResponse UpdateAITemplateWithOptions(UpdateAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                query["TemplateConfig"] = request.TemplateConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "UpdateAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAITemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   After you call the [AddAITemplate](~~102930~~) operation to add an AI template, you can call this operation to modify the AI template.
          *
          * @param request UpdateAITemplateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAITemplateResponse
         */
        public async Task<UpdateAITemplateResponse> UpdateAITemplateWithOptionsAsync(UpdateAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateConfig))
            {
                query["TemplateConfig"] = request.TemplateConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "UpdateAITemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAITemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   After you call the [AddAITemplate](~~102930~~) operation to add an AI template, you can call this operation to modify the AI template.
          *
          * @param request UpdateAITemplateRequest
          * @return UpdateAITemplateResponse
         */
        public UpdateAITemplateResponse UpdateAITemplate(UpdateAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAITemplateWithOptions(request, runtime);
        }

        /**
          * *   Regions that support this operation: **China (Beijing)**, **China (Shanghai)**, and **Singapore**.
          * *   After you call the [AddAITemplate](~~102930~~) operation to add an AI template, you can call this operation to modify the AI template.
          *
          * @param request UpdateAITemplateRequest
          * @return UpdateAITemplateResponse
         */
        public async Task<UpdateAITemplateResponse> UpdateAITemplateAsync(UpdateAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAITemplateWithOptionsAsync(request, runtime);
        }

        /**
          * ## QPS limit
          * A single user can perform a maximum of 30 queries per second (QPS). Throttling is triggered when the number of calls per second exceeds the QPS limit. The throttling may affect your business. Thus, we recommend that you observe the QPS limit on this operation.
          *
          * @param request UpdateAppInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAppInfoResponse
         */
        public UpdateAppInfoResponse UpdateAppInfoWithOptions(UpdateAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
                Action = "UpdateAppInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## QPS limit
          * A single user can perform a maximum of 30 queries per second (QPS). Throttling is triggered when the number of calls per second exceeds the QPS limit. The throttling may affect your business. Thus, we recommend that you observe the QPS limit on this operation.
          *
          * @param request UpdateAppInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAppInfoResponse
         */
        public async Task<UpdateAppInfoResponse> UpdateAppInfoWithOptionsAsync(UpdateAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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
                Action = "UpdateAppInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## QPS limit
          * A single user can perform a maximum of 30 queries per second (QPS). Throttling is triggered when the number of calls per second exceeds the QPS limit. The throttling may affect your business. Thus, we recommend that you observe the QPS limit on this operation.
          *
          * @param request UpdateAppInfoRequest
          * @return UpdateAppInfoResponse
         */
        public UpdateAppInfoResponse UpdateAppInfo(UpdateAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppInfoWithOptions(request, runtime);
        }

        /**
          * ## QPS limit
          * A single user can perform a maximum of 30 queries per second (QPS). Throttling is triggered when the number of calls per second exceeds the QPS limit. The throttling may affect your business. Thus, we recommend that you observe the QPS limit on this operation.
          *
          * @param request UpdateAppInfoRequest
          * @return UpdateAppInfoResponse
         */
        public async Task<UpdateAppInfoResponse> UpdateAppInfoAsync(UpdateAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppInfoWithOptionsAsync(request, runtime);
        }

        /**
          * The specific parameter of an auxiliary media asset is updated only when a new value is passed in the parameter.
          *
          * @param request UpdateAttachedMediaInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAttachedMediaInfosResponse
         */
        public UpdateAttachedMediaInfosResponse UpdateAttachedMediaInfosWithOptions(UpdateAttachedMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateContent))
            {
                query["UpdateContent"] = request.UpdateContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAttachedMediaInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAttachedMediaInfosResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The specific parameter of an auxiliary media asset is updated only when a new value is passed in the parameter.
          *
          * @param request UpdateAttachedMediaInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateAttachedMediaInfosResponse
         */
        public async Task<UpdateAttachedMediaInfosResponse> UpdateAttachedMediaInfosWithOptionsAsync(UpdateAttachedMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateContent))
            {
                query["UpdateContent"] = request.UpdateContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAttachedMediaInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAttachedMediaInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The specific parameter of an auxiliary media asset is updated only when a new value is passed in the parameter.
          *
          * @param request UpdateAttachedMediaInfosRequest
          * @return UpdateAttachedMediaInfosResponse
         */
        public UpdateAttachedMediaInfosResponse UpdateAttachedMediaInfos(UpdateAttachedMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAttachedMediaInfosWithOptions(request, runtime);
        }

        /**
          * The specific parameter of an auxiliary media asset is updated only when a new value is passed in the parameter.
          *
          * @param request UpdateAttachedMediaInfosRequest
          * @return UpdateAttachedMediaInfosResponse
         */
        public async Task<UpdateAttachedMediaInfosResponse> UpdateAttachedMediaInfosAsync(UpdateAttachedMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAttachedMediaInfosWithOptionsAsync(request, runtime);
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
                Version = "2017-03-21",
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
                Version = "2017-03-21",
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

        public UpdateEditingProjectResponse UpdateEditingProjectWithOptions(UpdateEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2017-03-21",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Version = "2017-03-21",
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

        public UpdateImageInfosResponse UpdateImageInfosWithOptions(UpdateImageInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateContent))
            {
                query["UpdateContent"] = request.UpdateContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateImageInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateImageInfosResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateImageInfosResponse> UpdateImageInfosWithOptionsAsync(UpdateImageInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateContent))
            {
                query["UpdateContent"] = request.UpdateContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateImageInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateImageInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateImageInfosResponse UpdateImageInfos(UpdateImageInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateImageInfosWithOptions(request, runtime);
        }

        public async Task<UpdateImageInfosResponse> UpdateImageInfosAsync(UpdateImageInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateImageInfosWithOptionsAsync(request, runtime);
        }

        /**
          * UpdateMediaStorageClass is an asynchronous operation. You can call this operation to modify the storage classes of media assets. After the storage class is modified, a callback notification is sent.
          * If the storage class of a media asset is Archive or Cold Archive, the media asset is automatically restored when you call this operation. After the media asset is restored, the storage class is modified. To restore the media asset, you do not need to call the RestoreMedia operation. To modify the storage class of a Cold Archive media asset, you must specify the restoration priority. By default, the restoration priority is set to Standard.
          * Media assets whose storage classes are being modified cannot be used or processed.
          * The media assets that are not of the Standard storage class have a limit on storage duration. If the storage duration does not meet the following requirements, you cannot change the storage classes: Infrequent Access (IA) media assets or source files are stored for at least 30 days, Archive media assets or source files are stored for at least 60 days, and Cold Archive media assets or source files are stored for at least 180 days.
          *
          * @param request UpdateMediaStorageClassRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateMediaStorageClassResponse
         */
        public UpdateMediaStorageClassResponse UpdateMediaStorageClassWithOptions(UpdateMediaStorageClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTier))
            {
                query["RestoreTier"] = request.RestoreTier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageClass))
            {
                query["StorageClass"] = request.StorageClass;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMediaStorageClass",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMediaStorageClassResponse>(CallApi(params_, req, runtime));
        }

        /**
          * UpdateMediaStorageClass is an asynchronous operation. You can call this operation to modify the storage classes of media assets. After the storage class is modified, a callback notification is sent.
          * If the storage class of a media asset is Archive or Cold Archive, the media asset is automatically restored when you call this operation. After the media asset is restored, the storage class is modified. To restore the media asset, you do not need to call the RestoreMedia operation. To modify the storage class of a Cold Archive media asset, you must specify the restoration priority. By default, the restoration priority is set to Standard.
          * Media assets whose storage classes are being modified cannot be used or processed.
          * The media assets that are not of the Standard storage class have a limit on storage duration. If the storage duration does not meet the following requirements, you cannot change the storage classes: Infrequent Access (IA) media assets or source files are stored for at least 30 days, Archive media assets or source files are stored for at least 60 days, and Cold Archive media assets or source files are stored for at least 180 days.
          *
          * @param request UpdateMediaStorageClassRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateMediaStorageClassResponse
         */
        public async Task<UpdateMediaStorageClassResponse> UpdateMediaStorageClassWithOptionsAsync(UpdateMediaStorageClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaIds))
            {
                query["MediaIds"] = request.MediaIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreTier))
            {
                query["RestoreTier"] = request.RestoreTier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageClass))
            {
                query["StorageClass"] = request.StorageClass;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMediaStorageClass",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMediaStorageClassResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * UpdateMediaStorageClass is an asynchronous operation. You can call this operation to modify the storage classes of media assets. After the storage class is modified, a callback notification is sent.
          * If the storage class of a media asset is Archive or Cold Archive, the media asset is automatically restored when you call this operation. After the media asset is restored, the storage class is modified. To restore the media asset, you do not need to call the RestoreMedia operation. To modify the storage class of a Cold Archive media asset, you must specify the restoration priority. By default, the restoration priority is set to Standard.
          * Media assets whose storage classes are being modified cannot be used or processed.
          * The media assets that are not of the Standard storage class have a limit on storage duration. If the storage duration does not meet the following requirements, you cannot change the storage classes: Infrequent Access (IA) media assets or source files are stored for at least 30 days, Archive media assets or source files are stored for at least 60 days, and Cold Archive media assets or source files are stored for at least 180 days.
          *
          * @param request UpdateMediaStorageClassRequest
          * @return UpdateMediaStorageClassResponse
         */
        public UpdateMediaStorageClassResponse UpdateMediaStorageClass(UpdateMediaStorageClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMediaStorageClassWithOptions(request, runtime);
        }

        /**
          * UpdateMediaStorageClass is an asynchronous operation. You can call this operation to modify the storage classes of media assets. After the storage class is modified, a callback notification is sent.
          * If the storage class of a media asset is Archive or Cold Archive, the media asset is automatically restored when you call this operation. After the media asset is restored, the storage class is modified. To restore the media asset, you do not need to call the RestoreMedia operation. To modify the storage class of a Cold Archive media asset, you must specify the restoration priority. By default, the restoration priority is set to Standard.
          * Media assets whose storage classes are being modified cannot be used or processed.
          * The media assets that are not of the Standard storage class have a limit on storage duration. If the storage duration does not meet the following requirements, you cannot change the storage classes: Infrequent Access (IA) media assets or source files are stored for at least 30 days, Archive media assets or source files are stored for at least 60 days, and Cold Archive media assets or source files are stored for at least 180 days.
          *
          * @param request UpdateMediaStorageClassRequest
          * @return UpdateMediaStorageClassResponse
         */
        public async Task<UpdateMediaStorageClassResponse> UpdateMediaStorageClassAsync(UpdateMediaStorageClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMediaStorageClassWithOptionsAsync(request, runtime);
        }

        /**
          * > *   You cannot add, modify, or remove transcoding templates in a transcoding template group that is locked in the ApsaraVideo VOD console. To manage such transcoding template groups, contact the ApsaraVideo VOD technical support.
          * > *   You can call the GetTranscodeTemplateGroup operation to query the configurations of a transcoding template group and check whether the transcoding template group is locked by using the response parameter Locked.
          *
          * @param request UpdateTranscodeTemplateGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateTranscodeTemplateGroupResponse
         */
        public UpdateTranscodeTemplateGroupResponse UpdateTranscodeTemplateGroupWithOptions(UpdateTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locked))
            {
                query["Locked"] = request.Locked;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateGroupId))
            {
                query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateList))
            {
                query["TranscodeTemplateList"] = request.TranscodeTemplateList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTranscodeTemplateGroup",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTranscodeTemplateGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > *   You cannot add, modify, or remove transcoding templates in a transcoding template group that is locked in the ApsaraVideo VOD console. To manage such transcoding template groups, contact the ApsaraVideo VOD technical support.
          * > *   You can call the GetTranscodeTemplateGroup operation to query the configurations of a transcoding template group and check whether the transcoding template group is locked by using the response parameter Locked.
          *
          * @param request UpdateTranscodeTemplateGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateTranscodeTemplateGroupResponse
         */
        public async Task<UpdateTranscodeTemplateGroupResponse> UpdateTranscodeTemplateGroupWithOptionsAsync(UpdateTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Locked))
            {
                query["Locked"] = request.Locked;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateGroupId))
            {
                query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranscodeTemplateList))
            {
                query["TranscodeTemplateList"] = request.TranscodeTemplateList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTranscodeTemplateGroup",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTranscodeTemplateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > *   You cannot add, modify, or remove transcoding templates in a transcoding template group that is locked in the ApsaraVideo VOD console. To manage such transcoding template groups, contact the ApsaraVideo VOD technical support.
          * > *   You can call the GetTranscodeTemplateGroup operation to query the configurations of a transcoding template group and check whether the transcoding template group is locked by using the response parameter Locked.
          *
          * @param request UpdateTranscodeTemplateGroupRequest
          * @return UpdateTranscodeTemplateGroupResponse
         */
        public UpdateTranscodeTemplateGroupResponse UpdateTranscodeTemplateGroup(UpdateTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTranscodeTemplateGroupWithOptions(request, runtime);
        }

        /**
          * > *   You cannot add, modify, or remove transcoding templates in a transcoding template group that is locked in the ApsaraVideo VOD console. To manage such transcoding template groups, contact the ApsaraVideo VOD technical support.
          * > *   You can call the GetTranscodeTemplateGroup operation to query the configurations of a transcoding template group and check whether the transcoding template group is locked by using the response parameter Locked.
          *
          * @param request UpdateTranscodeTemplateGroupRequest
          * @return UpdateTranscodeTemplateGroupResponse
         */
        public async Task<UpdateTranscodeTemplateGroupResponse> UpdateTranscodeTemplateGroupAsync(UpdateTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTranscodeTemplateGroupWithOptionsAsync(request, runtime);
        }

        /**
          * The specific parameter of a video is updated only when a new value is passed in the parameter.
          *
          * @param request UpdateVideoInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateVideoInfoResponse
         */
        public UpdateVideoInfoResponse UpdateVideoInfoWithOptions(UpdateVideoInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVideoInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The specific parameter of a video is updated only when a new value is passed in the parameter.
          *
          * @param request UpdateVideoInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateVideoInfoResponse
         */
        public async Task<UpdateVideoInfoResponse> UpdateVideoInfoWithOptionsAsync(UpdateVideoInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CateId))
            {
                query["CateId"] = request.CateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverURL))
            {
                query["CoverURL"] = request.CoverURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVideoInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The specific parameter of a video is updated only when a new value is passed in the parameter.
          *
          * @param request UpdateVideoInfoRequest
          * @return UpdateVideoInfoResponse
         */
        public UpdateVideoInfoResponse UpdateVideoInfo(UpdateVideoInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVideoInfoWithOptions(request, runtime);
        }

        /**
          * The specific parameter of a video is updated only when a new value is passed in the parameter.
          *
          * @param request UpdateVideoInfoRequest
          * @return UpdateVideoInfoResponse
         */
        public async Task<UpdateVideoInfoResponse> UpdateVideoInfoAsync(UpdateVideoInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVideoInfoWithOptionsAsync(request, runtime);
        }

        /**
          * The specific parameter of a video is updated only when a new value is passed in the parameter.
          *
          * @param request UpdateVideoInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateVideoInfosResponse
         */
        public UpdateVideoInfosResponse UpdateVideoInfosWithOptions(UpdateVideoInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateContent))
            {
                query["UpdateContent"] = request.UpdateContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVideoInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoInfosResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The specific parameter of a video is updated only when a new value is passed in the parameter.
          *
          * @param request UpdateVideoInfosRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateVideoInfosResponse
         */
        public async Task<UpdateVideoInfosResponse> UpdateVideoInfosWithOptionsAsync(UpdateVideoInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateContent))
            {
                query["UpdateContent"] = request.UpdateContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVideoInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVideoInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The specific parameter of a video is updated only when a new value is passed in the parameter.
          *
          * @param request UpdateVideoInfosRequest
          * @return UpdateVideoInfosResponse
         */
        public UpdateVideoInfosResponse UpdateVideoInfos(UpdateVideoInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVideoInfosWithOptions(request, runtime);
        }

        /**
          * The specific parameter of a video is updated only when a new value is passed in the parameter.
          *
          * @param request UpdateVideoInfosRequest
          * @return UpdateVideoInfosResponse
         */
        public async Task<UpdateVideoInfosResponse> UpdateVideoInfosAsync(UpdateVideoInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVideoInfosWithOptionsAsync(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request UpdateVodDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateVodDomainResponse
         */
        public UpdateVodDomainResponse UpdateVodDomainWithOptions(UpdateVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVodDomain",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVodDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request UpdateVodDomainRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateVodDomainResponse
         */
        public async Task<UpdateVodDomainResponse> UpdateVodDomainWithOptionsAsync(UpdateVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sources))
            {
                query["Sources"] = request.Sources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopLevelDomain))
            {
                query["TopLevelDomain"] = request.TopLevelDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVodDomain",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVodDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request UpdateVodDomainRequest
          * @return UpdateVodDomainResponse
         */
        public UpdateVodDomainResponse UpdateVodDomain(UpdateVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVodDomainWithOptions(request, runtime);
        }

        /**
          * > This operation is available only in the **China (Shanghai)** region.
          *
          * @param request UpdateVodDomainRequest
          * @return UpdateVodDomainResponse
         */
        public async Task<UpdateVodDomainResponse> UpdateVodDomainAsync(UpdateVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVodDomainWithOptionsAsync(request, runtime);
        }

        public UpdateVodTemplateResponse UpdateVodTemplateWithOptions(UpdateVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VodTemplateId))
            {
                query["VodTemplateId"] = request.VodTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVodTemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVodTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateVodTemplateResponse> UpdateVodTemplateWithOptionsAsync(UpdateVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VodTemplateId))
            {
                query["VodTemplateId"] = request.VodTemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVodTemplate",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVodTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateVodTemplateResponse UpdateVodTemplate(UpdateVodTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVodTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateVodTemplateResponse> UpdateVodTemplateAsync(UpdateVodTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVodTemplateWithOptionsAsync(request, runtime);
        }

        /**
          * You can modify only the name and configurations of a watermark.
          *
          * @param request UpdateWatermarkRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateWatermarkResponse
         */
        public UpdateWatermarkResponse UpdateWatermarkWithOptions(UpdateWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkConfig))
            {
                query["WatermarkConfig"] = request.WatermarkConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkId))
            {
                query["WatermarkId"] = request.WatermarkId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWatermark",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWatermarkResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can modify only the name and configurations of a watermark.
          *
          * @param request UpdateWatermarkRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateWatermarkResponse
         */
        public async Task<UpdateWatermarkResponse> UpdateWatermarkWithOptionsAsync(UpdateWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkConfig))
            {
                query["WatermarkConfig"] = request.WatermarkConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkId))
            {
                query["WatermarkId"] = request.WatermarkId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWatermark",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWatermarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can modify only the name and configurations of a watermark.
          *
          * @param request UpdateWatermarkRequest
          * @return UpdateWatermarkResponse
         */
        public UpdateWatermarkResponse UpdateWatermark(UpdateWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWatermarkWithOptions(request, runtime);
        }

        /**
          * You can modify only the name and configurations of a watermark.
          *
          * @param request UpdateWatermarkRequest
          * @return UpdateWatermarkResponse
         */
        public async Task<UpdateWatermarkResponse> UpdateWatermarkAsync(UpdateWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWatermarkWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can call this operation to upload media files that are not stored on a local server or device and must be uploaded based on URLs over the Internet.
          * *   The URL-based upload jobs are asynchronous. After you submit a URL-based upload job by calling this operation, it may take hours, even days to complete. If you require high timeliness, we recommend that you use the upload SDK.
          * *   If you configure callbacks, you can receive an [UploadByURLComplete](~~86326~~) event notification after the media file is uploaded. You can query the upload status by calling the [GetURLUploadInfos](~~106830~~) operation.
          * *   After you submit an upload job, the job is asynchronously processed on the cloud. All URL-based upload jobs that are submitted in each region are queued. The waiting time for the upload job depends on the number of queued jobs. After the upload job is complete, you can associate the playback URL included in the callback with the media ID.
          * *   You can call this operation only in the **China (Shanghai)** and **Singapore** regions.
          * *   Every time you submit a URL-based upload job, a new media ID is generated in ApsaraVideo VOD.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageLocation))
            {
                query["StorageLocation"] = request.StorageLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateGroupId))
            {
                query["TemplateGroupId"] = request.TemplateGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadMetadatas))
            {
                query["UploadMetadatas"] = request.UploadMetadatas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadURLs))
            {
                query["UploadURLs"] = request.UploadURLs;
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
                Action = "UploadMediaByURL",
                Version = "2017-03-21",
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
          * *   You can call this operation to upload media files that are not stored on a local server or device and must be uploaded based on URLs over the Internet.
          * *   The URL-based upload jobs are asynchronous. After you submit a URL-based upload job by calling this operation, it may take hours, even days to complete. If you require high timeliness, we recommend that you use the upload SDK.
          * *   If you configure callbacks, you can receive an [UploadByURLComplete](~~86326~~) event notification after the media file is uploaded. You can query the upload status by calling the [GetURLUploadInfos](~~106830~~) operation.
          * *   After you submit an upload job, the job is asynchronously processed on the cloud. All URL-based upload jobs that are submitted in each region are queued. The waiting time for the upload job depends on the number of queued jobs. After the upload job is complete, you can associate the playback URL included in the callback with the media ID.
          * *   You can call this operation only in the **China (Shanghai)** and **Singapore** regions.
          * *   Every time you submit a URL-based upload job, a new media ID is generated in ApsaraVideo VOD.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                query["SessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageLocation))
            {
                query["StorageLocation"] = request.StorageLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateGroupId))
            {
                query["TemplateGroupId"] = request.TemplateGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadMetadatas))
            {
                query["UploadMetadatas"] = request.UploadMetadatas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadURLs))
            {
                query["UploadURLs"] = request.UploadURLs;
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
                Action = "UploadMediaByURL",
                Version = "2017-03-21",
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
          * *   You can call this operation to upload media files that are not stored on a local server or device and must be uploaded based on URLs over the Internet.
          * *   The URL-based upload jobs are asynchronous. After you submit a URL-based upload job by calling this operation, it may take hours, even days to complete. If you require high timeliness, we recommend that you use the upload SDK.
          * *   If you configure callbacks, you can receive an [UploadByURLComplete](~~86326~~) event notification after the media file is uploaded. You can query the upload status by calling the [GetURLUploadInfos](~~106830~~) operation.
          * *   After you submit an upload job, the job is asynchronously processed on the cloud. All URL-based upload jobs that are submitted in each region are queued. The waiting time for the upload job depends on the number of queued jobs. After the upload job is complete, you can associate the playback URL included in the callback with the media ID.
          * *   You can call this operation only in the **China (Shanghai)** and **Singapore** regions.
          * *   Every time you submit a URL-based upload job, a new media ID is generated in ApsaraVideo VOD.
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
          * *   You can call this operation to upload media files that are not stored on a local server or device and must be uploaded based on URLs over the Internet.
          * *   The URL-based upload jobs are asynchronous. After you submit a URL-based upload job by calling this operation, it may take hours, even days to complete. If you require high timeliness, we recommend that you use the upload SDK.
          * *   If you configure callbacks, you can receive an [UploadByURLComplete](~~86326~~) event notification after the media file is uploaded. You can query the upload status by calling the [GetURLUploadInfos](~~106830~~) operation.
          * *   After you submit an upload job, the job is asynchronously processed on the cloud. All URL-based upload jobs that are submitted in each region are queued. The waiting time for the upload job depends on the number of queued jobs. After the upload job is complete, you can associate the playback URL included in the callback with the media ID.
          * *   You can call this operation only in the **China (Shanghai)** and **Singapore** regions.
          * *   Every time you submit a URL-based upload job, a new media ID is generated in ApsaraVideo VOD.
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
          * You can call this operation to upload transcoded streams to ApsaraVideo VOD from external storage. The following HDR types of transcoded streams are supported: HDR, HDR 10, HLG, Dolby Vision, HDR Vivid, and SDR+. You can call the [GetURLUploadInfos](~~106830~~) operation to query the upload status. After the upload is complete, the callback of the UploadByURLComplete event is returned.
          * >  This operation is available only in the Singapore (Singapore) region.
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
                Version = "2017-03-21",
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
          * You can call this operation to upload transcoded streams to ApsaraVideo VOD from external storage. The following HDR types of transcoded streams are supported: HDR, HDR 10, HLG, Dolby Vision, HDR Vivid, and SDR+. You can call the [GetURLUploadInfos](~~106830~~) operation to query the upload status. After the upload is complete, the callback of the UploadByURLComplete event is returned.
          * >  This operation is available only in the Singapore (Singapore) region.
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
                Version = "2017-03-21",
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
          * You can call this operation to upload transcoded streams to ApsaraVideo VOD from external storage. The following HDR types of transcoded streams are supported: HDR, HDR 10, HLG, Dolby Vision, HDR Vivid, and SDR+. You can call the [GetURLUploadInfos](~~106830~~) operation to query the upload status. After the upload is complete, the callback of the UploadByURLComplete event is returned.
          * >  This operation is available only in the Singapore (Singapore) region.
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
          * You can call this operation to upload transcoded streams to ApsaraVideo VOD from external storage. The following HDR types of transcoded streams are supported: HDR, HDR 10, HLG, Dolby Vision, HDR Vivid, and SDR+. You can call the [GetURLUploadInfos](~~106830~~) operation to query the upload status. After the upload is complete, the callback of the UploadByURLComplete event is returned.
          * >  This operation is available only in the Singapore (Singapore) region.
          *
          * @param request UploadStreamByURLRequest
          * @return UploadStreamByURLResponse
         */
        public async Task<UploadStreamByURLResponse> UploadStreamByURLAsync(UploadStreamByURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadStreamByURLWithOptionsAsync(request, runtime);
        }

        public VerifyVodDomainOwnerResponse VerifyVodDomainOwnerWithOptions(VerifyVodDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyVodDomainOwner",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyVodDomainOwnerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<VerifyVodDomainOwnerResponse> VerifyVodDomainOwnerWithOptionsAsync(VerifyVodDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyVodDomainOwner",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyVodDomainOwnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public VerifyVodDomainOwnerResponse VerifyVodDomainOwner(VerifyVodDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyVodDomainOwnerWithOptions(request, runtime);
        }

        public async Task<VerifyVodDomainOwnerResponse> VerifyVodDomainOwnerAsync(VerifyVodDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyVodDomainOwnerWithOptionsAsync(request, runtime);
        }

    }
}
