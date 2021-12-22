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
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
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
                {"cn-hangzhou", "vod.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "vod.aliyuncs.com"},
                {"cn-hangzhou-finance", "vod.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "vod.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "vod.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "vod.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "vod.aliyuncs.com"},
                {"cn-hangzhou-test-306", "vod.aliyuncs.com"},
                {"cn-hongkong", "vod.aliyuncs.com"},
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
                {"cn-zhangjiakou", "vod.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "vod.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "vod.aliyuncs.com"},
                {"eu-west-1", "vod.aliyuncs.com"},
                {"eu-west-1-oxs", "vod.aliyuncs.com"},
                {"me-east-1", "vod.aliyuncs.com"},
                {"rus-west-1-pop", "vod.aliyuncs.com"},
                {"us-east-1", "vod.aliyuncs.com"},
                {"us-west-1", "vod.aliyuncs.com"},
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

        public AddAITemplateResponse AddAITemplateWithOptions(AddAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateConfig"] = request.TemplateConfig;
            query["TemplateName"] = request.TemplateName;
            query["TemplateType"] = request.TemplateType;
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

        public async Task<AddAITemplateResponse> AddAITemplateWithOptionsAsync(AddAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateConfig"] = request.TemplateConfig;
            query["TemplateName"] = request.TemplateName;
            query["TemplateType"] = request.TemplateType;
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

        public AddAITemplateResponse AddAITemplate(AddAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAITemplateWithOptions(request, runtime);
        }

        public async Task<AddAITemplateResponse> AddAITemplateAsync(AddAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAITemplateWithOptionsAsync(request, runtime);
        }

        public AddCategoryResponse AddCategoryWithOptions(AddCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CateName"] = request.CateName;
            query["ParentId"] = request.ParentId;
            query["Type"] = request.Type;
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

        public async Task<AddCategoryResponse> AddCategoryWithOptionsAsync(AddCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CateName"] = request.CateName;
            query["ParentId"] = request.ParentId;
            query["Type"] = request.Type;
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

        public AddEditingProjectResponse AddEditingProjectWithOptions(AddEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["Division"] = request.Division;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Timeline"] = request.Timeline;
            query["Title"] = request.Title;
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
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["Division"] = request.Division;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Timeline"] = request.Timeline;
            query["Title"] = request.Title;
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

        public AddTranscodeTemplateGroupResponse AddTranscodeTemplateGroupWithOptions(AddTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["Name"] = request.Name;
            query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            query["TranscodeTemplateList"] = request.TranscodeTemplateList;
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

        public async Task<AddTranscodeTemplateGroupResponse> AddTranscodeTemplateGroupWithOptionsAsync(AddTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["Name"] = request.Name;
            query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            query["TranscodeTemplateList"] = request.TranscodeTemplateList;
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

        public AddTranscodeTemplateGroupResponse AddTranscodeTemplateGroup(AddTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTranscodeTemplateGroupWithOptions(request, runtime);
        }

        public async Task<AddTranscodeTemplateGroupResponse> AddTranscodeTemplateGroupAsync(AddTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTranscodeTemplateGroupWithOptionsAsync(request, runtime);
        }

        public AddVodDomainResponse AddVodDomainWithOptions(AddVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CheckUrl"] = request.CheckUrl;
            query["DomainName"] = request.DomainName;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["Scope"] = request.Scope;
            query["SecurityToken"] = request.SecurityToken;
            query["Sources"] = request.Sources;
            query["TopLevelDomain"] = request.TopLevelDomain;
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

        public async Task<AddVodDomainResponse> AddVodDomainWithOptionsAsync(AddVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CheckUrl"] = request.CheckUrl;
            query["DomainName"] = request.DomainName;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["Scope"] = request.Scope;
            query["SecurityToken"] = request.SecurityToken;
            query["Sources"] = request.Sources;
            query["TopLevelDomain"] = request.TopLevelDomain;
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

        public AddVodDomainResponse AddVodDomain(AddVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVodDomainWithOptions(request, runtime);
        }

        public async Task<AddVodDomainResponse> AddVodDomainAsync(AddVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVodDomainWithOptionsAsync(request, runtime);
        }

        public AddVodTemplateResponse AddVodTemplateWithOptions(AddVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["Name"] = request.Name;
            query["TemplateConfig"] = request.TemplateConfig;
            query["TemplateType"] = request.TemplateType;
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

        public async Task<AddVodTemplateResponse> AddVodTemplateWithOptionsAsync(AddVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["Name"] = request.Name;
            query["TemplateConfig"] = request.TemplateConfig;
            query["TemplateType"] = request.TemplateType;
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

        public AddVodTemplateResponse AddVodTemplate(AddVodTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVodTemplateWithOptions(request, runtime);
        }

        public async Task<AddVodTemplateResponse> AddVodTemplateAsync(AddVodTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVodTemplateWithOptionsAsync(request, runtime);
        }

        public AddWatermarkResponse AddWatermarkWithOptions(AddWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["FileUrl"] = request.FileUrl;
            query["Name"] = request.Name;
            query["Type"] = request.Type;
            query["WatermarkConfig"] = request.WatermarkConfig;
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

        public async Task<AddWatermarkResponse> AddWatermarkWithOptionsAsync(AddWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["FileUrl"] = request.FileUrl;
            query["Name"] = request.Name;
            query["Type"] = request.Type;
            query["WatermarkConfig"] = request.WatermarkConfig;
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

        public AddWatermarkResponse AddWatermark(AddWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddWatermarkWithOptions(request, runtime);
        }

        public async Task<AddWatermarkResponse> AddWatermarkAsync(AddWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddWatermarkWithOptionsAsync(request, runtime);
        }

        public AttachAppPolicyToIdentityResponse AttachAppPolicyToIdentityWithOptions(AttachAppPolicyToIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["IdentityName"] = request.IdentityName;
            query["IdentityType"] = request.IdentityType;
            query["PolicyNames"] = request.PolicyNames;
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

        public async Task<AttachAppPolicyToIdentityResponse> AttachAppPolicyToIdentityWithOptionsAsync(AttachAppPolicyToIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["IdentityName"] = request.IdentityName;
            query["IdentityType"] = request.IdentityType;
            query["PolicyNames"] = request.PolicyNames;
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

        public AttachAppPolicyToIdentityResponse AttachAppPolicyToIdentity(AttachAppPolicyToIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachAppPolicyToIdentityWithOptions(request, runtime);
        }

        public async Task<AttachAppPolicyToIdentityResponse> AttachAppPolicyToIdentityAsync(AttachAppPolicyToIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachAppPolicyToIdentityWithOptionsAsync(request, runtime);
        }

        public BatchSetVodDomainConfigsResponse BatchSetVodDomainConfigsWithOptions(BatchSetVodDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainNames"] = request.DomainNames;
            query["Functions"] = request.Functions;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public async Task<BatchSetVodDomainConfigsResponse> BatchSetVodDomainConfigsWithOptionsAsync(BatchSetVodDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainNames"] = request.DomainNames;
            query["Functions"] = request.Functions;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public BatchSetVodDomainConfigsResponse BatchSetVodDomainConfigs(BatchSetVodDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetVodDomainConfigsWithOptions(request, runtime);
        }

        public async Task<BatchSetVodDomainConfigsResponse> BatchSetVodDomainConfigsAsync(BatchSetVodDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetVodDomainConfigsWithOptionsAsync(request, runtime);
        }

        public BatchStartVodDomainResponse BatchStartVodDomainWithOptions(BatchStartVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainNames"] = request.DomainNames;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public async Task<BatchStartVodDomainResponse> BatchStartVodDomainWithOptionsAsync(BatchStartVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainNames"] = request.DomainNames;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public BatchStartVodDomainResponse BatchStartVodDomain(BatchStartVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStartVodDomainWithOptions(request, runtime);
        }

        public async Task<BatchStartVodDomainResponse> BatchStartVodDomainAsync(BatchStartVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStartVodDomainWithOptionsAsync(request, runtime);
        }

        public BatchStopVodDomainResponse BatchStopVodDomainWithOptions(BatchStopVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainNames"] = request.DomainNames;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public async Task<BatchStopVodDomainResponse> BatchStopVodDomainWithOptionsAsync(BatchStopVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainNames"] = request.DomainNames;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public BatchStopVodDomainResponse BatchStopVodDomain(BatchStopVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStopVodDomainWithOptions(request, runtime);
        }

        public async Task<BatchStopVodDomainResponse> BatchStopVodDomainAsync(BatchStopVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStopVodDomainWithOptionsAsync(request, runtime);
        }

        public CancelUrlUploadJobsResponse CancelUrlUploadJobsWithOptions(CancelUrlUploadJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobIds"] = request.JobIds;
            query["UploadUrls"] = request.UploadUrls;
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

        public async Task<CancelUrlUploadJobsResponse> CancelUrlUploadJobsWithOptionsAsync(CancelUrlUploadJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobIds"] = request.JobIds;
            query["UploadUrls"] = request.UploadUrls;
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

        public CancelUrlUploadJobsResponse CancelUrlUploadJobs(CancelUrlUploadJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelUrlUploadJobsWithOptions(request, runtime);
        }

        public async Task<CancelUrlUploadJobsResponse> CancelUrlUploadJobsAsync(CancelUrlUploadJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelUrlUploadJobsWithOptionsAsync(request, runtime);
        }

        public CreateAppInfoResponse CreateAppInfoWithOptions(CreateAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppName"] = request.AppName;
            query["Description"] = request.Description;
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

        public async Task<CreateAppInfoResponse> CreateAppInfoWithOptionsAsync(CreateAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppName"] = request.AppName;
            query["Description"] = request.Description;
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

        public CreateAppInfoResponse CreateAppInfo(CreateAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppInfoWithOptions(request, runtime);
        }

        public async Task<CreateAppInfoResponse> CreateAppInfoAsync(CreateAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppInfoWithOptionsAsync(request, runtime);
        }

        public CreateAuditResponse CreateAuditWithOptions(CreateAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AuditContent"] = request.AuditContent;
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
            query["AuditContent"] = request.AuditContent;
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

        public CreateUploadAttachedMediaResponse CreateUploadAttachedMediaWithOptions(CreateUploadAttachedMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["BusinessType"] = request.BusinessType;
            query["CateIds"] = request.CateIds;
            query["Description"] = request.Description;
            query["FileName"] = request.FileName;
            query["FileSize"] = request.FileSize;
            query["MediaExt"] = request.MediaExt;
            query["StorageLocation"] = request.StorageLocation;
            query["Tags"] = request.Tags;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
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

        public async Task<CreateUploadAttachedMediaResponse> CreateUploadAttachedMediaWithOptionsAsync(CreateUploadAttachedMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["BusinessType"] = request.BusinessType;
            query["CateIds"] = request.CateIds;
            query["Description"] = request.Description;
            query["FileName"] = request.FileName;
            query["FileSize"] = request.FileSize;
            query["MediaExt"] = request.MediaExt;
            query["StorageLocation"] = request.StorageLocation;
            query["Tags"] = request.Tags;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
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

        public CreateUploadAttachedMediaResponse CreateUploadAttachedMedia(CreateUploadAttachedMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUploadAttachedMediaWithOptions(request, runtime);
        }

        public async Task<CreateUploadAttachedMediaResponse> CreateUploadAttachedMediaAsync(CreateUploadAttachedMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUploadAttachedMediaWithOptionsAsync(request, runtime);
        }

        public CreateUploadImageResponse CreateUploadImageWithOptions(CreateUploadImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["CateId"] = request.CateId;
            query["Description"] = request.Description;
            query["ImageExt"] = request.ImageExt;
            query["ImageType"] = request.ImageType;
            query["StorageLocation"] = request.StorageLocation;
            query["Tags"] = request.Tags;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
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

        public async Task<CreateUploadImageResponse> CreateUploadImageWithOptionsAsync(CreateUploadImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["CateId"] = request.CateId;
            query["Description"] = request.Description;
            query["ImageExt"] = request.ImageExt;
            query["ImageType"] = request.ImageType;
            query["StorageLocation"] = request.StorageLocation;
            query["Tags"] = request.Tags;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
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

        public CreateUploadImageResponse CreateUploadImage(CreateUploadImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUploadImageWithOptions(request, runtime);
        }

        public async Task<CreateUploadImageResponse> CreateUploadImageAsync(CreateUploadImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUploadImageWithOptionsAsync(request, runtime);
        }

        public CreateUploadVideoResponse CreateUploadVideoWithOptions(CreateUploadVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["CateId"] = request.CateId;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["FileName"] = request.FileName;
            query["FileSize"] = request.FileSize;
            query["StorageLocation"] = request.StorageLocation;
            query["Tags"] = request.Tags;
            query["TemplateGroupId"] = request.TemplateGroupId;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            query["WorkflowId"] = request.WorkflowId;
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

        public async Task<CreateUploadVideoResponse> CreateUploadVideoWithOptionsAsync(CreateUploadVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["CateId"] = request.CateId;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["FileName"] = request.FileName;
            query["FileSize"] = request.FileSize;
            query["StorageLocation"] = request.StorageLocation;
            query["Tags"] = request.Tags;
            query["TemplateGroupId"] = request.TemplateGroupId;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            query["WorkflowId"] = request.WorkflowId;
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

        public CreateUploadVideoResponse CreateUploadVideo(CreateUploadVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUploadVideoWithOptions(request, runtime);
        }

        public async Task<CreateUploadVideoResponse> CreateUploadVideoAsync(CreateUploadVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUploadVideoWithOptionsAsync(request, runtime);
        }

        public CreateVodRealTimeLogDeliveryResponse CreateVodRealTimeLogDeliveryWithOptions(CreateVodRealTimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVodRealTimeLogDelivery",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVodRealTimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateVodRealTimeLogDeliveryResponse> CreateVodRealTimeLogDeliveryWithOptionsAsync(CreateVodRealTimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVodRealTimeLogDelivery",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVodRealTimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateVodRealTimeLogDeliveryResponse CreateVodRealTimeLogDelivery(CreateVodRealTimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVodRealTimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<CreateVodRealTimeLogDeliveryResponse> CreateVodRealTimeLogDeliveryAsync(CreateVodRealTimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVodRealTimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public DeleteAIImageInfosResponse DeleteAIImageInfosWithOptions(DeleteAIImageInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AIImageInfoIds"] = request.AIImageInfoIds;
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

        public async Task<DeleteAIImageInfosResponse> DeleteAIImageInfosWithOptionsAsync(DeleteAIImageInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AIImageInfoIds"] = request.AIImageInfoIds;
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

        public DeleteAIImageInfosResponse DeleteAIImageInfos(DeleteAIImageInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAIImageInfosWithOptions(request, runtime);
        }

        public async Task<DeleteAIImageInfosResponse> DeleteAIImageInfosAsync(DeleteAIImageInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAIImageInfosWithOptionsAsync(request, runtime);
        }

        public DeleteAITemplateResponse DeleteAITemplateWithOptions(DeleteAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateId"] = request.TemplateId;
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

        public async Task<DeleteAITemplateResponse> DeleteAITemplateWithOptionsAsync(DeleteAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateId"] = request.TemplateId;
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

        public DeleteAITemplateResponse DeleteAITemplate(DeleteAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAITemplateWithOptions(request, runtime);
        }

        public async Task<DeleteAITemplateResponse> DeleteAITemplateAsync(DeleteAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAITemplateWithOptionsAsync(request, runtime);
        }

        public DeleteAppInfoResponse DeleteAppInfoWithOptions(DeleteAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
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

        public async Task<DeleteAppInfoResponse> DeleteAppInfoWithOptionsAsync(DeleteAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
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

        public DeleteAppInfoResponse DeleteAppInfo(DeleteAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppInfoWithOptions(request, runtime);
        }

        public async Task<DeleteAppInfoResponse> DeleteAppInfoAsync(DeleteAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppInfoWithOptionsAsync(request, runtime);
        }

        public DeleteAttachedMediaResponse DeleteAttachedMediaWithOptions(DeleteAttachedMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public async Task<DeleteAttachedMediaResponse> DeleteAttachedMediaWithOptionsAsync(DeleteAttachedMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public DeleteAttachedMediaResponse DeleteAttachedMedia(DeleteAttachedMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAttachedMediaWithOptions(request, runtime);
        }

        public async Task<DeleteAttachedMediaResponse> DeleteAttachedMediaAsync(DeleteAttachedMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAttachedMediaWithOptionsAsync(request, runtime);
        }

        public DeleteCategoryResponse DeleteCategoryWithOptions(DeleteCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CateId"] = request.CateId;
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

        public async Task<DeleteCategoryResponse> DeleteCategoryWithOptionsAsync(DeleteCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CateId"] = request.CateId;
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

        public DeleteDynamicImageResponse DeleteDynamicImageWithOptions(DeleteDynamicImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DynamicImageIds"] = request.DynamicImageIds;
            query["VideoId"] = request.VideoId;
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

        public async Task<DeleteDynamicImageResponse> DeleteDynamicImageWithOptionsAsync(DeleteDynamicImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DynamicImageIds"] = request.DynamicImageIds;
            query["VideoId"] = request.VideoId;
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

        public DeleteDynamicImageResponse DeleteDynamicImage(DeleteDynamicImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDynamicImageWithOptions(request, runtime);
        }

        public async Task<DeleteDynamicImageResponse> DeleteDynamicImageAsync(DeleteDynamicImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDynamicImageWithOptionsAsync(request, runtime);
        }

        public DeleteEditingProjectResponse DeleteEditingProjectWithOptions(DeleteEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProjectIds"] = request.ProjectIds;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public async Task<DeleteEditingProjectResponse> DeleteEditingProjectWithOptionsAsync(DeleteEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProjectIds"] = request.ProjectIds;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public DeleteEditingProjectResponse DeleteEditingProject(DeleteEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEditingProjectWithOptions(request, runtime);
        }

        public async Task<DeleteEditingProjectResponse> DeleteEditingProjectAsync(DeleteEditingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEditingProjectWithOptionsAsync(request, runtime);
        }

        public DeleteImageResponse DeleteImageWithOptions(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeleteImageType"] = request.DeleteImageType;
            query["ImageIds"] = request.ImageIds;
            query["ImageType"] = request.ImageType;
            query["ImageURLs"] = request.ImageURLs;
            query["VideoId"] = request.VideoId;
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

        public async Task<DeleteImageResponse> DeleteImageWithOptionsAsync(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DeleteImageType"] = request.DeleteImageType;
            query["ImageIds"] = request.ImageIds;
            query["ImageType"] = request.ImageType;
            query["ImageURLs"] = request.ImageURLs;
            query["VideoId"] = request.VideoId;
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

        public DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImageWithOptions(request, runtime);
        }

        public async Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImageWithOptionsAsync(request, runtime);
        }

        public DeleteMessageCallbackResponse DeleteMessageCallbackWithOptions(DeleteMessageCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["OwnerAccount"] = request.OwnerAccount;
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

        public async Task<DeleteMessageCallbackResponse> DeleteMessageCallbackWithOptionsAsync(DeleteMessageCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["OwnerAccount"] = request.OwnerAccount;
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

        public DeleteMessageCallbackResponse DeleteMessageCallback(DeleteMessageCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMessageCallbackWithOptions(request, runtime);
        }

        public async Task<DeleteMessageCallbackResponse> DeleteMessageCallbackAsync(DeleteMessageCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMessageCallbackWithOptionsAsync(request, runtime);
        }

        public DeleteMezzaninesResponse DeleteMezzaninesWithOptions(DeleteMezzaninesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Force"] = request.Force;
            query["VideoIds"] = request.VideoIds;
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

        public async Task<DeleteMezzaninesResponse> DeleteMezzaninesWithOptionsAsync(DeleteMezzaninesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Force"] = request.Force;
            query["VideoIds"] = request.VideoIds;
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

        public DeleteMezzaninesResponse DeleteMezzanines(DeleteMezzaninesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMezzaninesWithOptions(request, runtime);
        }

        public async Task<DeleteMezzaninesResponse> DeleteMezzaninesAsync(DeleteMezzaninesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMezzaninesWithOptionsAsync(request, runtime);
        }

        public DeleteMultipartUploadResponse DeleteMultipartUploadWithOptions(DeleteMultipartUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            query["MediaType"] = request.MediaType;
            query["OwnerAccount"] = request.OwnerAccount;
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

        public async Task<DeleteMultipartUploadResponse> DeleteMultipartUploadWithOptionsAsync(DeleteMultipartUploadRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            query["MediaType"] = request.MediaType;
            query["OwnerAccount"] = request.OwnerAccount;
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

        public DeleteMultipartUploadResponse DeleteMultipartUpload(DeleteMultipartUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMultipartUploadWithOptions(request, runtime);
        }

        public async Task<DeleteMultipartUploadResponse> DeleteMultipartUploadAsync(DeleteMultipartUploadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMultipartUploadWithOptionsAsync(request, runtime);
        }

        public DeleteStreamResponse DeleteStreamWithOptions(DeleteStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobIds"] = request.JobIds;
            query["VideoId"] = request.VideoId;
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
            query["JobIds"] = request.JobIds;
            query["VideoId"] = request.VideoId;
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

        public DeleteTranscodeTemplateGroupResponse DeleteTranscodeTemplateGroupWithOptions(DeleteTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ForceDelGroup"] = request.ForceDelGroup;
            query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            query["TranscodeTemplateIds"] = request.TranscodeTemplateIds;
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

        public async Task<DeleteTranscodeTemplateGroupResponse> DeleteTranscodeTemplateGroupWithOptionsAsync(DeleteTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ForceDelGroup"] = request.ForceDelGroup;
            query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            query["TranscodeTemplateIds"] = request.TranscodeTemplateIds;
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

        public DeleteTranscodeTemplateGroupResponse DeleteTranscodeTemplateGroup(DeleteTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTranscodeTemplateGroupWithOptions(request, runtime);
        }

        public async Task<DeleteTranscodeTemplateGroupResponse> DeleteTranscodeTemplateGroupAsync(DeleteTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTranscodeTemplateGroupWithOptionsAsync(request, runtime);
        }

        public DeleteVideoResponse DeleteVideoWithOptions(DeleteVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["VideoIds"] = request.VideoIds;
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

        public async Task<DeleteVideoResponse> DeleteVideoWithOptionsAsync(DeleteVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["VideoIds"] = request.VideoIds;
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

        public DeleteVideoResponse DeleteVideo(DeleteVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVideoWithOptions(request, runtime);
        }

        public async Task<DeleteVideoResponse> DeleteVideoAsync(DeleteVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVideoWithOptionsAsync(request, runtime);
        }

        public DeleteVodDomainResponse DeleteVodDomainWithOptions(DeleteVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public async Task<DeleteVodDomainResponse> DeleteVodDomainWithOptionsAsync(DeleteVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public DeleteVodDomainResponse DeleteVodDomain(DeleteVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVodDomainWithOptions(request, runtime);
        }

        public async Task<DeleteVodDomainResponse> DeleteVodDomainAsync(DeleteVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVodDomainWithOptionsAsync(request, runtime);
        }

        public DeleteVodRealtimeLogDeliveryResponse DeleteVodRealtimeLogDeliveryWithOptions(DeleteVodRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVodRealtimeLogDelivery",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVodRealtimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteVodRealtimeLogDeliveryResponse> DeleteVodRealtimeLogDeliveryWithOptionsAsync(DeleteVodRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVodRealtimeLogDelivery",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVodRealtimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteVodRealtimeLogDeliveryResponse DeleteVodRealtimeLogDelivery(DeleteVodRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVodRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<DeleteVodRealtimeLogDeliveryResponse> DeleteVodRealtimeLogDeliveryAsync(DeleteVodRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVodRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public DeleteVodSpecificConfigResponse DeleteVodSpecificConfigWithOptions(DeleteVodSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigId"] = request.ConfigId;
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public async Task<DeleteVodSpecificConfigResponse> DeleteVodSpecificConfigWithOptionsAsync(DeleteVodSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ConfigId"] = request.ConfigId;
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public DeleteVodSpecificConfigResponse DeleteVodSpecificConfig(DeleteVodSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVodSpecificConfigWithOptions(request, runtime);
        }

        public async Task<DeleteVodSpecificConfigResponse> DeleteVodSpecificConfigAsync(DeleteVodSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVodSpecificConfigWithOptionsAsync(request, runtime);
        }

        public DeleteVodTemplateResponse DeleteVodTemplateWithOptions(DeleteVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["VodTemplateId"] = request.VodTemplateId;
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
            query["VodTemplateId"] = request.VodTemplateId;
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

        public DeleteWatermarkResponse DeleteWatermarkWithOptions(DeleteWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["WatermarkId"] = request.WatermarkId;
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

        public async Task<DeleteWatermarkResponse> DeleteWatermarkWithOptionsAsync(DeleteWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["WatermarkId"] = request.WatermarkId;
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

        public DeleteWatermarkResponse DeleteWatermark(DeleteWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWatermarkWithOptions(request, runtime);
        }

        public async Task<DeleteWatermarkResponse> DeleteWatermarkAsync(DeleteWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWatermarkWithOptionsAsync(request, runtime);
        }

        public DescribePlayTopVideosResponse DescribePlayTopVideosWithOptions(DescribePlayTopVideosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BizDate"] = request.BizDate;
            query["OwnerId"] = request.OwnerId;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
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

        public async Task<DescribePlayTopVideosResponse> DescribePlayTopVideosWithOptionsAsync(DescribePlayTopVideosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BizDate"] = request.BizDate;
            query["OwnerId"] = request.OwnerId;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
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

        public DescribePlayTopVideosResponse DescribePlayTopVideos(DescribePlayTopVideosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayTopVideosWithOptions(request, runtime);
        }

        public async Task<DescribePlayTopVideosResponse> DescribePlayTopVideosAsync(DescribePlayTopVideosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayTopVideosWithOptionsAsync(request, runtime);
        }

        public DescribePlayUserAvgResponse DescribePlayUserAvgWithOptions(DescribePlayUserAvgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
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

        public async Task<DescribePlayUserAvgResponse> DescribePlayUserAvgWithOptionsAsync(DescribePlayUserAvgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
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

        public DescribePlayUserAvgResponse DescribePlayUserAvg(DescribePlayUserAvgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayUserAvgWithOptions(request, runtime);
        }

        public async Task<DescribePlayUserAvgResponse> DescribePlayUserAvgAsync(DescribePlayUserAvgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayUserAvgWithOptionsAsync(request, runtime);
        }

        public DescribePlayUserTotalResponse DescribePlayUserTotalWithOptions(DescribePlayUserTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
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

        public async Task<DescribePlayUserTotalResponse> DescribePlayUserTotalWithOptionsAsync(DescribePlayUserTotalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
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

        public DescribePlayUserTotalResponse DescribePlayUserTotal(DescribePlayUserTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayUserTotalWithOptions(request, runtime);
        }

        public async Task<DescribePlayUserTotalResponse> DescribePlayUserTotalAsync(DescribePlayUserTotalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayUserTotalWithOptionsAsync(request, runtime);
        }

        public DescribePlayVideoStatisResponse DescribePlayVideoStatisWithOptions(DescribePlayVideoStatisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
            query["VideoId"] = request.VideoId;
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

        public async Task<DescribePlayVideoStatisResponse> DescribePlayVideoStatisWithOptionsAsync(DescribePlayVideoStatisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
            query["VideoId"] = request.VideoId;
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

        public DescribePlayVideoStatisResponse DescribePlayVideoStatis(DescribePlayVideoStatisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlayVideoStatisWithOptions(request, runtime);
        }

        public async Task<DescribePlayVideoStatisResponse> DescribePlayVideoStatisAsync(DescribePlayVideoStatisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlayVideoStatisWithOptionsAsync(request, runtime);
        }

        public DescribeVodAIDataResponse DescribeVodAIDataWithOptions(DescribeVodAIDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AIType"] = request.AIType;
            query["EndTime"] = request.EndTime;
            query["OwnerId"] = request.OwnerId;
            query["Region"] = request.Region;
            query["StartTime"] = request.StartTime;
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

        public async Task<DescribeVodAIDataResponse> DescribeVodAIDataWithOptionsAsync(DescribeVodAIDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AIType"] = request.AIType;
            query["EndTime"] = request.EndTime;
            query["OwnerId"] = request.OwnerId;
            query["Region"] = request.Region;
            query["StartTime"] = request.StartTime;
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

        public DescribeVodAIDataResponse DescribeVodAIData(DescribeVodAIDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodAIDataWithOptions(request, runtime);
        }

        public async Task<DescribeVodAIDataResponse> DescribeVodAIDataAsync(DescribeVodAIDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodAIDataWithOptionsAsync(request, runtime);
        }

        public DescribeVodCertificateListResponse DescribeVodCertificateListWithOptions(DescribeVodCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public async Task<DescribeVodCertificateListResponse> DescribeVodCertificateListWithOptionsAsync(DescribeVodCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public DescribeVodCertificateListResponse DescribeVodCertificateList(DescribeVodCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodCertificateListWithOptions(request, runtime);
        }

        public async Task<DescribeVodCertificateListResponse> DescribeVodCertificateListAsync(DescribeVodCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodCertificateListWithOptionsAsync(request, runtime);
        }

        public DescribeVodDomainBpsDataResponse DescribeVodDomainBpsDataWithOptions(DescribeVodDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["Interval"] = request.Interval;
            query["IspNameEn"] = request.IspNameEn;
            query["LocationNameEn"] = request.LocationNameEn;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
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

        public async Task<DescribeVodDomainBpsDataResponse> DescribeVodDomainBpsDataWithOptionsAsync(DescribeVodDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["Interval"] = request.Interval;
            query["IspNameEn"] = request.IspNameEn;
            query["LocationNameEn"] = request.LocationNameEn;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
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

        public DescribeVodDomainBpsDataResponse DescribeVodDomainBpsData(DescribeVodDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeVodDomainBpsDataResponse> DescribeVodDomainBpsDataAsync(DescribeVodDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeVodDomainCertificateInfoResponse DescribeVodDomainCertificateInfoWithOptions(DescribeVodDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
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

        public async Task<DescribeVodDomainCertificateInfoResponse> DescribeVodDomainCertificateInfoWithOptionsAsync(DescribeVodDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
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

        public DescribeVodDomainCertificateInfoResponse DescribeVodDomainCertificateInfo(DescribeVodDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainCertificateInfoWithOptions(request, runtime);
        }

        public async Task<DescribeVodDomainCertificateInfoResponse> DescribeVodDomainCertificateInfoAsync(DescribeVodDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainCertificateInfoWithOptionsAsync(request, runtime);
        }

        public DescribeVodDomainConfigsResponse DescribeVodDomainConfigsWithOptions(DescribeVodDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["FunctionNames"] = request.FunctionNames;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public async Task<DescribeVodDomainConfigsResponse> DescribeVodDomainConfigsWithOptionsAsync(DescribeVodDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["FunctionNames"] = request.FunctionNames;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public DescribeVodDomainConfigsResponse DescribeVodDomainConfigs(DescribeVodDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeVodDomainConfigsResponse> DescribeVodDomainConfigsAsync(DescribeVodDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeVodDomainDetailResponse DescribeVodDomainDetailWithOptions(DescribeVodDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public async Task<DescribeVodDomainDetailResponse> DescribeVodDomainDetailWithOptionsAsync(DescribeVodDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public DescribeVodDomainDetailResponse DescribeVodDomainDetail(DescribeVodDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainDetailWithOptions(request, runtime);
        }

        public async Task<DescribeVodDomainDetailResponse> DescribeVodDomainDetailAsync(DescribeVodDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainDetailWithOptionsAsync(request, runtime);
        }

        public DescribeVodDomainLogResponse DescribeVodDomainLogWithOptions(DescribeVodDomainLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["StartTime"] = request.StartTime;
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

        public async Task<DescribeVodDomainLogResponse> DescribeVodDomainLogWithOptionsAsync(DescribeVodDomainLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["StartTime"] = request.StartTime;
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

        public DescribeVodDomainLogResponse DescribeVodDomainLog(DescribeVodDomainLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainLogWithOptions(request, runtime);
        }

        public async Task<DescribeVodDomainLogResponse> DescribeVodDomainLogAsync(DescribeVodDomainLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainLogWithOptionsAsync(request, runtime);
        }

        public DescribeVodDomainRealtimeLogDeliveryResponse DescribeVodDomainRealtimeLogDeliveryWithOptions(DescribeVodDomainRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainRealtimeLogDelivery",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainRealtimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVodDomainRealtimeLogDeliveryResponse> DescribeVodDomainRealtimeLogDeliveryWithOptionsAsync(DescribeVodDomainRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodDomainRealtimeLogDelivery",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodDomainRealtimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVodDomainRealtimeLogDeliveryResponse DescribeVodDomainRealtimeLogDelivery(DescribeVodDomainRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<DescribeVodDomainRealtimeLogDeliveryResponse> DescribeVodDomainRealtimeLogDeliveryAsync(DescribeVodDomainRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public DescribeVodDomainSrcBpsDataResponse DescribeVodDomainSrcBpsDataWithOptions(DescribeVodDomainSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["Interval"] = request.Interval;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
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

        public async Task<DescribeVodDomainSrcBpsDataResponse> DescribeVodDomainSrcBpsDataWithOptionsAsync(DescribeVodDomainSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["Interval"] = request.Interval;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
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

        public DescribeVodDomainSrcBpsDataResponse DescribeVodDomainSrcBpsData(DescribeVodDomainSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainSrcBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeVodDomainSrcBpsDataResponse> DescribeVodDomainSrcBpsDataAsync(DescribeVodDomainSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainSrcBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeVodDomainSrcTrafficDataResponse DescribeVodDomainSrcTrafficDataWithOptions(DescribeVodDomainSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["Interval"] = request.Interval;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
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

        public async Task<DescribeVodDomainSrcTrafficDataResponse> DescribeVodDomainSrcTrafficDataWithOptionsAsync(DescribeVodDomainSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["Interval"] = request.Interval;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
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

        public DescribeVodDomainSrcTrafficDataResponse DescribeVodDomainSrcTrafficData(DescribeVodDomainSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainSrcTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeVodDomainSrcTrafficDataResponse> DescribeVodDomainSrcTrafficDataAsync(DescribeVodDomainSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainSrcTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeVodDomainTrafficDataResponse DescribeVodDomainTrafficDataWithOptions(DescribeVodDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["Interval"] = request.Interval;
            query["IspNameEn"] = request.IspNameEn;
            query["LocationNameEn"] = request.LocationNameEn;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
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

        public async Task<DescribeVodDomainTrafficDataResponse> DescribeVodDomainTrafficDataWithOptionsAsync(DescribeVodDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["Interval"] = request.Interval;
            query["IspNameEn"] = request.IspNameEn;
            query["LocationNameEn"] = request.LocationNameEn;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
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

        public DescribeVodDomainTrafficDataResponse DescribeVodDomainTrafficData(DescribeVodDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeVodDomainTrafficDataResponse> DescribeVodDomainTrafficDataAsync(DescribeVodDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeVodDomainUsageDataResponse DescribeVodDomainUsageDataWithOptions(DescribeVodDomainUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Area"] = request.Area;
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["Field"] = request.Field;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
            query["Type"] = request.Type;
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

        public async Task<DescribeVodDomainUsageDataResponse> DescribeVodDomainUsageDataWithOptionsAsync(DescribeVodDomainUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Area"] = request.Area;
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["Field"] = request.Field;
            query["OwnerId"] = request.OwnerId;
            query["StartTime"] = request.StartTime;
            query["Type"] = request.Type;
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

        public DescribeVodDomainUsageDataResponse DescribeVodDomainUsageData(DescribeVodDomainUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodDomainUsageDataWithOptions(request, runtime);
        }

        public async Task<DescribeVodDomainUsageDataResponse> DescribeVodDomainUsageDataAsync(DescribeVodDomainUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodDomainUsageDataWithOptionsAsync(request, runtime);
        }

        public DescribeVodRefreshQuotaResponse DescribeVodRefreshQuotaWithOptions(DescribeVodRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public async Task<DescribeVodRefreshQuotaResponse> DescribeVodRefreshQuotaWithOptionsAsync(DescribeVodRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public DescribeVodRefreshQuotaResponse DescribeVodRefreshQuota(DescribeVodRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodRefreshQuotaWithOptions(request, runtime);
        }

        public async Task<DescribeVodRefreshQuotaResponse> DescribeVodRefreshQuotaAsync(DescribeVodRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodRefreshQuotaWithOptionsAsync(request, runtime);
        }

        public DescribeVodRefreshTasksResponse DescribeVodRefreshTasksWithOptions(DescribeVodRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["ObjectPath"] = request.ObjectPath;
            query["ObjectType"] = request.ObjectType;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            query["StartTime"] = request.StartTime;
            query["Status"] = request.Status;
            query["TaskId"] = request.TaskId;
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

        public async Task<DescribeVodRefreshTasksResponse> DescribeVodRefreshTasksWithOptionsAsync(DescribeVodRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["ObjectPath"] = request.ObjectPath;
            query["ObjectType"] = request.ObjectType;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            query["StartTime"] = request.StartTime;
            query["Status"] = request.Status;
            query["TaskId"] = request.TaskId;
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

        public DescribeVodRefreshTasksResponse DescribeVodRefreshTasks(DescribeVodRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodRefreshTasksWithOptions(request, runtime);
        }

        public async Task<DescribeVodRefreshTasksResponse> DescribeVodRefreshTasksAsync(DescribeVodRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodRefreshTasksWithOptionsAsync(request, runtime);
        }

        public DescribeVodStorageDataResponse DescribeVodStorageDataWithOptions(DescribeVodStorageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["OwnerId"] = request.OwnerId;
            query["Region"] = request.Region;
            query["StartTime"] = request.StartTime;
            query["Storage"] = request.Storage;
            query["StorageType"] = request.StorageType;
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

        public async Task<DescribeVodStorageDataResponse> DescribeVodStorageDataWithOptionsAsync(DescribeVodStorageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["OwnerId"] = request.OwnerId;
            query["Region"] = request.Region;
            query["StartTime"] = request.StartTime;
            query["Storage"] = request.Storage;
            query["StorageType"] = request.StorageType;
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

        public DescribeVodStorageDataResponse DescribeVodStorageData(DescribeVodStorageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodStorageDataWithOptions(request, runtime);
        }

        public async Task<DescribeVodStorageDataResponse> DescribeVodStorageDataAsync(DescribeVodStorageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodStorageDataWithOptionsAsync(request, runtime);
        }

        public DescribeVodTagResourcesResponse DescribeVodTagResourcesWithOptions(DescribeVodTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodTagResources",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVodTagResourcesResponse> DescribeVodTagResourcesWithOptionsAsync(DescribeVodTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodTagResources",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVodTagResourcesResponse DescribeVodTagResources(DescribeVodTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodTagResourcesWithOptions(request, runtime);
        }

        public async Task<DescribeVodTagResourcesResponse> DescribeVodTagResourcesAsync(DescribeVodTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodTagResourcesWithOptionsAsync(request, runtime);
        }

        public DescribeVodTranscodeDataResponse DescribeVodTranscodeDataWithOptions(DescribeVodTranscodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["Interval"] = request.Interval;
            query["OwnerId"] = request.OwnerId;
            query["Region"] = request.Region;
            query["Specification"] = request.Specification;
            query["StartTime"] = request.StartTime;
            query["Storage"] = request.Storage;
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

        public async Task<DescribeVodTranscodeDataResponse> DescribeVodTranscodeDataWithOptionsAsync(DescribeVodTranscodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["Interval"] = request.Interval;
            query["OwnerId"] = request.OwnerId;
            query["Region"] = request.Region;
            query["Specification"] = request.Specification;
            query["StartTime"] = request.StartTime;
            query["Storage"] = request.Storage;
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

        public DescribeVodTranscodeDataResponse DescribeVodTranscodeData(DescribeVodTranscodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodTranscodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeVodTranscodeDataResponse> DescribeVodTranscodeDataAsync(DescribeVodTranscodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodTranscodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeVodUserDomainsResponse DescribeVodUserDomainsWithOptions(DescribeVodUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["DomainSearchType"] = request.DomainSearchType;
            query["DomainStatus"] = request.DomainStatus;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            query["Tag"] = request.Tag;
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
            query["DomainName"] = request.DomainName;
            query["DomainSearchType"] = request.DomainSearchType;
            query["DomainStatus"] = request.DomainStatus;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["SecurityToken"] = request.SecurityToken;
            query["Tag"] = request.Tag;
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

        public DescribeVodUserTagsResponse DescribeVodUserTagsWithOptions(DescribeVodUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodUserTags",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodUserTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVodUserTagsResponse> DescribeVodUserTagsWithOptionsAsync(DescribeVodUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVodUserTags",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVodUserTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVodUserTagsResponse DescribeVodUserTags(DescribeVodUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVodUserTagsWithOptions(request, runtime);
        }

        public async Task<DescribeVodUserTagsResponse> DescribeVodUserTagsAsync(DescribeVodUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVodUserTagsWithOptionsAsync(request, runtime);
        }

        public DescribeVodVerifyContentResponse DescribeVodVerifyContentWithOptions(DescribeVodVerifyContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
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
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
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

        public DetachAppPolicyFromIdentityResponse DetachAppPolicyFromIdentityWithOptions(DetachAppPolicyFromIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["IdentityName"] = request.IdentityName;
            query["IdentityType"] = request.IdentityType;
            query["PolicyNames"] = request.PolicyNames;
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

        public async Task<DetachAppPolicyFromIdentityResponse> DetachAppPolicyFromIdentityWithOptionsAsync(DetachAppPolicyFromIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["IdentityName"] = request.IdentityName;
            query["IdentityType"] = request.IdentityType;
            query["PolicyNames"] = request.PolicyNames;
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

        public DetachAppPolicyFromIdentityResponse DetachAppPolicyFromIdentity(DetachAppPolicyFromIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachAppPolicyFromIdentityWithOptions(request, runtime);
        }

        public async Task<DetachAppPolicyFromIdentityResponse> DetachAppPolicyFromIdentityAsync(DetachAppPolicyFromIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachAppPolicyFromIdentityWithOptionsAsync(request, runtime);
        }

        public DisableVodRealtimeLogDeliveryResponse DisableVodRealtimeLogDeliveryWithOptions(DisableVodRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableVodRealtimeLogDelivery",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableVodRealtimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableVodRealtimeLogDeliveryResponse> DisableVodRealtimeLogDeliveryWithOptionsAsync(DisableVodRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableVodRealtimeLogDelivery",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableVodRealtimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableVodRealtimeLogDeliveryResponse DisableVodRealtimeLogDelivery(DisableVodRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableVodRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<DisableVodRealtimeLogDeliveryResponse> DisableVodRealtimeLogDeliveryAsync(DisableVodRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableVodRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public EnableVodRealtimeLogDeliveryResponse EnableVodRealtimeLogDeliveryWithOptions(EnableVodRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableVodRealtimeLogDelivery",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableVodRealtimeLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableVodRealtimeLogDeliveryResponse> EnableVodRealtimeLogDeliveryWithOptionsAsync(EnableVodRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableVodRealtimeLogDelivery",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableVodRealtimeLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableVodRealtimeLogDeliveryResponse EnableVodRealtimeLogDelivery(EnableVodRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableVodRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<EnableVodRealtimeLogDeliveryResponse> EnableVodRealtimeLogDeliveryAsync(EnableVodRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableVodRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public GetAIImageJobsResponse GetAIImageJobsWithOptions(GetAIImageJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobIds"] = request.JobIds;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public async Task<GetAIImageJobsResponse> GetAIImageJobsWithOptionsAsync(GetAIImageJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobIds"] = request.JobIds;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public GetAIImageJobsResponse GetAIImageJobs(GetAIImageJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAIImageJobsWithOptions(request, runtime);
        }

        public async Task<GetAIImageJobsResponse> GetAIImageJobsAsync(GetAIImageJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAIImageJobsWithOptionsAsync(request, runtime);
        }

        public GetAIMediaAuditJobResponse GetAIMediaAuditJobWithOptions(GetAIMediaAuditJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public async Task<GetAIMediaAuditJobResponse> GetAIMediaAuditJobWithOptionsAsync(GetAIMediaAuditJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public GetAIMediaAuditJobResponse GetAIMediaAuditJob(GetAIMediaAuditJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAIMediaAuditJobWithOptions(request, runtime);
        }

        public async Task<GetAIMediaAuditJobResponse> GetAIMediaAuditJobAsync(GetAIMediaAuditJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAIMediaAuditJobWithOptionsAsync(request, runtime);
        }

        public GetAITemplateResponse GetAITemplateWithOptions(GetAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateId"] = request.TemplateId;
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

        public async Task<GetAITemplateResponse> GetAITemplateWithOptionsAsync(GetAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateId"] = request.TemplateId;
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

        public GetAITemplateResponse GetAITemplate(GetAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAITemplateWithOptions(request, runtime);
        }

        public async Task<GetAITemplateResponse> GetAITemplateAsync(GetAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAITemplateWithOptionsAsync(request, runtime);
        }

        public GetAIVideoTagResultResponse GetAIVideoTagResultWithOptions(GetAIVideoTagResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public async Task<GetAIVideoTagResultResponse> GetAIVideoTagResultWithOptionsAsync(GetAIVideoTagResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public GetAIVideoTagResultResponse GetAIVideoTagResult(GetAIVideoTagResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAIVideoTagResultWithOptions(request, runtime);
        }

        public async Task<GetAIVideoTagResultResponse> GetAIVideoTagResultAsync(GetAIVideoTagResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAIVideoTagResultWithOptionsAsync(request, runtime);
        }

        public GetAppInfosResponse GetAppInfosWithOptions(GetAppInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppIds"] = request.AppIds;
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

        public async Task<GetAppInfosResponse> GetAppInfosWithOptionsAsync(GetAppInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppIds"] = request.AppIds;
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

        public GetAppInfosResponse GetAppInfos(GetAppInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppInfosWithOptions(request, runtime);
        }

        public async Task<GetAppInfosResponse> GetAppInfosAsync(GetAppInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppInfosWithOptionsAsync(request, runtime);
        }

        public GetAttachedMediaInfoResponse GetAttachedMediaInfoWithOptions(GetAttachedMediaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AuthTimeout"] = request.AuthTimeout;
            query["MediaIds"] = request.MediaIds;
            query["OutputType"] = request.OutputType;
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
            query["AuthTimeout"] = request.AuthTimeout;
            query["MediaIds"] = request.MediaIds;
            query["OutputType"] = request.OutputType;
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
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["SortBy"] = request.SortBy;
            query["VideoId"] = request.VideoId;
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
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["SortBy"] = request.SortBy;
            query["VideoId"] = request.VideoId;
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
            query["CateId"] = request.CateId;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["SortBy"] = request.SortBy;
            query["Type"] = request.Type;
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
            query["CateId"] = request.CateId;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["SortBy"] = request.SortBy;
            query["Type"] = request.Type;
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

        public GetDefaultAITemplateResponse GetDefaultAITemplateWithOptions(GetDefaultAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateType"] = request.TemplateType;
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

        public async Task<GetDefaultAITemplateResponse> GetDefaultAITemplateWithOptionsAsync(GetDefaultAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateType"] = request.TemplateType;
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

        public GetDefaultAITemplateResponse GetDefaultAITemplate(GetDefaultAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDefaultAITemplateWithOptions(request, runtime);
        }

        public async Task<GetDefaultAITemplateResponse> GetDefaultAITemplateAsync(GetDefaultAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDefaultAITemplateWithOptionsAsync(request, runtime);
        }

        public GetEditingProjectResponse GetEditingProjectWithOptions(GetEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProjectId"] = request.ProjectId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProjectId"] = request.ProjectId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public GetEditingProjectMaterialsResponse GetEditingProjectMaterialsWithOptions(GetEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaterialType"] = request.MaterialType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProjectId"] = request.ProjectId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Type"] = request.Type;
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

        public async Task<GetEditingProjectMaterialsResponse> GetEditingProjectMaterialsWithOptionsAsync(GetEditingProjectMaterialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaterialType"] = request.MaterialType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProjectId"] = request.ProjectId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Type"] = request.Type;
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

        public GetImageInfoResponse GetImageInfoWithOptions(GetImageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AuthTimeout"] = request.AuthTimeout;
            query["ImageId"] = request.ImageId;
            query["OutputType"] = request.OutputType;
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
            query["AuthTimeout"] = request.AuthTimeout;
            query["ImageId"] = request.ImageId;
            query["OutputType"] = request.OutputType;
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

        public GetMediaAuditAudioResultDetailResponse GetMediaAuditAudioResultDetailWithOptions(GetMediaAuditAudioResultDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNo"] = request.PageNo;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public async Task<GetMediaAuditAudioResultDetailResponse> GetMediaAuditAudioResultDetailWithOptionsAsync(GetMediaAuditAudioResultDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNo"] = request.PageNo;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public GetMediaAuditAudioResultDetailResponse GetMediaAuditAudioResultDetail(GetMediaAuditAudioResultDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaAuditAudioResultDetailWithOptions(request, runtime);
        }

        public async Task<GetMediaAuditAudioResultDetailResponse> GetMediaAuditAudioResultDetailAsync(GetMediaAuditAudioResultDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaAuditAudioResultDetailWithOptionsAsync(request, runtime);
        }

        public GetMediaAuditResultResponse GetMediaAuditResultWithOptions(GetMediaAuditResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            query["MediaId"] = request.MediaId;
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

        public GetMediaAuditResultDetailResponse GetMediaAuditResultDetailWithOptions(GetMediaAuditResultDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            query["PageNo"] = request.PageNo;
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

        public async Task<GetMediaAuditResultDetailResponse> GetMediaAuditResultDetailWithOptionsAsync(GetMediaAuditResultDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            query["PageNo"] = request.PageNo;
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

        public GetMediaAuditResultDetailResponse GetMediaAuditResultDetail(GetMediaAuditResultDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaAuditResultDetailWithOptions(request, runtime);
        }

        public async Task<GetMediaAuditResultDetailResponse> GetMediaAuditResultDetailAsync(GetMediaAuditResultDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaAuditResultDetailWithOptionsAsync(request, runtime);
        }

        public GetMediaAuditResultTimelineResponse GetMediaAuditResultTimelineWithOptions(GetMediaAuditResultTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            query["MediaId"] = request.MediaId;
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

        public GetMediaDNAResultResponse GetMediaDNAResultWithOptions(GetMediaDNAResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public async Task<GetMediaDNAResultResponse> GetMediaDNAResultWithOptionsAsync(GetMediaDNAResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public GetMediaDNAResultResponse GetMediaDNAResult(GetMediaDNAResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaDNAResultWithOptions(request, runtime);
        }

        public async Task<GetMediaDNAResultResponse> GetMediaDNAResultAsync(GetMediaDNAResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaDNAResultWithOptionsAsync(request, runtime);
        }

        public GetMessageCallbackResponse GetMessageCallbackWithOptions(GetMessageCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["OwnerAccount"] = request.OwnerAccount;
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

        public async Task<GetMessageCallbackResponse> GetMessageCallbackWithOptionsAsync(GetMessageCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["OwnerAccount"] = request.OwnerAccount;
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

        public GetMessageCallbackResponse GetMessageCallback(GetMessageCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMessageCallbackWithOptions(request, runtime);
        }

        public async Task<GetMessageCallbackResponse> GetMessageCallbackAsync(GetMessageCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMessageCallbackWithOptionsAsync(request, runtime);
        }

        public GetMezzanineInfoResponse GetMezzanineInfoWithOptions(GetMezzanineInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdditionType"] = request.AdditionType;
            query["AuthTimeout"] = request.AuthTimeout;
            query["OutputType"] = request.OutputType;
            query["VideoId"] = request.VideoId;
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

        public async Task<GetMezzanineInfoResponse> GetMezzanineInfoWithOptionsAsync(GetMezzanineInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdditionType"] = request.AdditionType;
            query["AuthTimeout"] = request.AuthTimeout;
            query["OutputType"] = request.OutputType;
            query["VideoId"] = request.VideoId;
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

        public GetMezzanineInfoResponse GetMezzanineInfo(GetMezzanineInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMezzanineInfoWithOptions(request, runtime);
        }

        public async Task<GetMezzanineInfoResponse> GetMezzanineInfoAsync(GetMezzanineInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMezzanineInfoWithOptionsAsync(request, runtime);
        }

        public GetPlayInfoResponse GetPlayInfoWithOptions(GetPlayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdditionType"] = request.AdditionType;
            query["AuthTimeout"] = request.AuthTimeout;
            query["Definition"] = request.Definition;
            query["Formats"] = request.Formats;
            query["OutputType"] = request.OutputType;
            query["PlayConfig"] = request.PlayConfig;
            query["ReAuthInfo"] = request.ReAuthInfo;
            query["ResultType"] = request.ResultType;
            query["StreamType"] = request.StreamType;
            query["VideoId"] = request.VideoId;
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

        public async Task<GetPlayInfoResponse> GetPlayInfoWithOptionsAsync(GetPlayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AdditionType"] = request.AdditionType;
            query["AuthTimeout"] = request.AuthTimeout;
            query["Definition"] = request.Definition;
            query["Formats"] = request.Formats;
            query["OutputType"] = request.OutputType;
            query["PlayConfig"] = request.PlayConfig;
            query["ReAuthInfo"] = request.ReAuthInfo;
            query["ResultType"] = request.ResultType;
            query["StreamType"] = request.StreamType;
            query["VideoId"] = request.VideoId;
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

        public GetTranscodeSummaryResponse GetTranscodeSummaryWithOptions(GetTranscodeSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["VideoIds"] = request.VideoIds;
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

        public async Task<GetTranscodeSummaryResponse> GetTranscodeSummaryWithOptionsAsync(GetTranscodeSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["VideoIds"] = request.VideoIds;
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

        public GetTranscodeSummaryResponse GetTranscodeSummary(GetTranscodeSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTranscodeSummaryWithOptions(request, runtime);
        }

        public async Task<GetTranscodeSummaryResponse> GetTranscodeSummaryAsync(GetTranscodeSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTranscodeSummaryWithOptionsAsync(request, runtime);
        }

        public GetTranscodeTaskResponse GetTranscodeTaskWithOptions(GetTranscodeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TranscodeTaskId"] = request.TranscodeTaskId;
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

        public async Task<GetTranscodeTaskResponse> GetTranscodeTaskWithOptionsAsync(GetTranscodeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TranscodeTaskId"] = request.TranscodeTaskId;
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

        public GetTranscodeTaskResponse GetTranscodeTask(GetTranscodeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTranscodeTaskWithOptions(request, runtime);
        }

        public async Task<GetTranscodeTaskResponse> GetTranscodeTaskAsync(GetTranscodeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTranscodeTaskWithOptionsAsync(request, runtime);
        }

        public GetTranscodeTemplateGroupResponse GetTranscodeTemplateGroupWithOptions(GetTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
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

        public async Task<GetTranscodeTemplateGroupResponse> GetTranscodeTemplateGroupWithOptionsAsync(GetTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
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

        public GetTranscodeTemplateGroupResponse GetTranscodeTemplateGroup(GetTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTranscodeTemplateGroupWithOptions(request, runtime);
        }

        public async Task<GetTranscodeTemplateGroupResponse> GetTranscodeTemplateGroupAsync(GetTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTranscodeTemplateGroupWithOptionsAsync(request, runtime);
        }

        public GetURLUploadInfosResponse GetURLUploadInfosWithOptions(GetURLUploadInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobIds"] = request.JobIds;
            query["UploadURLs"] = request.UploadURLs;
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

        public async Task<GetURLUploadInfosResponse> GetURLUploadInfosWithOptionsAsync(GetURLUploadInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobIds"] = request.JobIds;
            query["UploadURLs"] = request.UploadURLs;
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

        public GetURLUploadInfosResponse GetURLUploadInfos(GetURLUploadInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetURLUploadInfosWithOptions(request, runtime);
        }

        public async Task<GetURLUploadInfosResponse> GetURLUploadInfosAsync(GetURLUploadInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetURLUploadInfosWithOptionsAsync(request, runtime);
        }

        public GetUploadDetailsResponse GetUploadDetailsWithOptions(GetUploadDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaIds"] = request.MediaIds;
            query["MediaType"] = request.MediaType;
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

        public async Task<GetUploadDetailsResponse> GetUploadDetailsWithOptionsAsync(GetUploadDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaIds"] = request.MediaIds;
            query["MediaType"] = request.MediaType;
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

        public GetUploadDetailsResponse GetUploadDetails(GetUploadDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUploadDetailsWithOptions(request, runtime);
        }

        public async Task<GetUploadDetailsResponse> GetUploadDetailsAsync(GetUploadDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUploadDetailsWithOptionsAsync(request, runtime);
        }

        public GetVideoInfoResponse GetVideoInfoWithOptions(GetVideoInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["VideoId"] = request.VideoId;
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

        public async Task<GetVideoInfoResponse> GetVideoInfoWithOptionsAsync(GetVideoInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["VideoId"] = request.VideoId;
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

        public GetVideoInfoResponse GetVideoInfo(GetVideoInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoInfoWithOptions(request, runtime);
        }

        public async Task<GetVideoInfoResponse> GetVideoInfoAsync(GetVideoInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoInfoWithOptionsAsync(request, runtime);
        }

        public GetVideoInfosResponse GetVideoInfosWithOptions(GetVideoInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["VideoIds"] = request.VideoIds;
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

        public async Task<GetVideoInfosResponse> GetVideoInfosWithOptionsAsync(GetVideoInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["VideoIds"] = request.VideoIds;
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

        public GetVideoInfosResponse GetVideoInfos(GetVideoInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoInfosWithOptions(request, runtime);
        }

        public async Task<GetVideoInfosResponse> GetVideoInfosAsync(GetVideoInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoInfosWithOptionsAsync(request, runtime);
        }

        public GetVideoListResponse GetVideoListWithOptions(GetVideoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CateId"] = request.CateId;
            query["EndTime"] = request.EndTime;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["SortBy"] = request.SortBy;
            query["StartTime"] = request.StartTime;
            query["Status"] = request.Status;
            query["StorageLocation"] = request.StorageLocation;
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

        public async Task<GetVideoListResponse> GetVideoListWithOptionsAsync(GetVideoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CateId"] = request.CateId;
            query["EndTime"] = request.EndTime;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["SortBy"] = request.SortBy;
            query["StartTime"] = request.StartTime;
            query["Status"] = request.Status;
            query["StorageLocation"] = request.StorageLocation;
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

        public GetVideoListResponse GetVideoList(GetVideoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoListWithOptions(request, runtime);
        }

        public async Task<GetVideoListResponse> GetVideoListAsync(GetVideoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoListWithOptionsAsync(request, runtime);
        }

        public GetVideoPlayAuthResponse GetVideoPlayAuthWithOptions(GetVideoPlayAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ApiVersion"] = request.ApiVersion;
            query["AuthInfoTimeout"] = request.AuthInfoTimeout;
            query["VideoId"] = request.VideoId;
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

        public async Task<GetVideoPlayAuthResponse> GetVideoPlayAuthWithOptionsAsync(GetVideoPlayAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ApiVersion"] = request.ApiVersion;
            query["AuthInfoTimeout"] = request.AuthInfoTimeout;
            query["VideoId"] = request.VideoId;
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

        public GetVideoPlayAuthResponse GetVideoPlayAuth(GetVideoPlayAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoPlayAuthWithOptions(request, runtime);
        }

        public async Task<GetVideoPlayAuthResponse> GetVideoPlayAuthAsync(GetVideoPlayAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoPlayAuthWithOptionsAsync(request, runtime);
        }

        public GetVodTemplateResponse GetVodTemplateWithOptions(GetVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["VodTemplateId"] = request.VodTemplateId;
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
            query["VodTemplateId"] = request.VodTemplateId;
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
            query["WatermarkId"] = request.WatermarkId;
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
            query["WatermarkId"] = request.WatermarkId;
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

        public ListAIImageInfoResponse ListAIImageInfoWithOptions(ListAIImageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["VideoId"] = request.VideoId;
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

        public async Task<ListAIImageInfoResponse> ListAIImageInfoWithOptionsAsync(ListAIImageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["VideoId"] = request.VideoId;
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

        public ListAIImageInfoResponse ListAIImageInfo(ListAIImageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAIImageInfoWithOptions(request, runtime);
        }

        public async Task<ListAIImageInfoResponse> ListAIImageInfoAsync(ListAIImageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAIImageInfoWithOptionsAsync(request, runtime);
        }

        public ListAIJobResponse ListAIJobWithOptions(ListAIJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobIds"] = request.JobIds;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public async Task<ListAIJobResponse> ListAIJobWithOptionsAsync(ListAIJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobIds"] = request.JobIds;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public ListAIJobResponse ListAIJob(ListAIJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAIJobWithOptions(request, runtime);
        }

        public async Task<ListAIJobResponse> ListAIJobAsync(ListAIJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAIJobWithOptionsAsync(request, runtime);
        }

        public ListAITemplateResponse ListAITemplateWithOptions(ListAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateType"] = request.TemplateType;
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

        public async Task<ListAITemplateResponse> ListAITemplateWithOptionsAsync(ListAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateType"] = request.TemplateType;
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

        public ListAITemplateResponse ListAITemplate(ListAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAITemplateWithOptions(request, runtime);
        }

        public async Task<ListAITemplateResponse> ListAITemplateAsync(ListAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAITemplateWithOptionsAsync(request, runtime);
        }

        public ListAppInfoResponse ListAppInfoWithOptions(ListAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["Status"] = request.Status;
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

        public async Task<ListAppInfoResponse> ListAppInfoWithOptionsAsync(ListAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["Status"] = request.Status;
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

        public ListAppInfoResponse ListAppInfo(ListAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppInfoWithOptions(request, runtime);
        }

        public async Task<ListAppInfoResponse> ListAppInfoAsync(ListAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppInfoWithOptionsAsync(request, runtime);
        }

        public ListAppPoliciesForIdentityResponse ListAppPoliciesForIdentityWithOptions(ListAppPoliciesForIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["IdentityName"] = request.IdentityName;
            query["IdentityType"] = request.IdentityType;
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

        public async Task<ListAppPoliciesForIdentityResponse> ListAppPoliciesForIdentityWithOptionsAsync(ListAppPoliciesForIdentityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["IdentityName"] = request.IdentityName;
            query["IdentityType"] = request.IdentityType;
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

        public ListAppPoliciesForIdentityResponse ListAppPoliciesForIdentity(ListAppPoliciesForIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppPoliciesForIdentityWithOptions(request, runtime);
        }

        public async Task<ListAppPoliciesForIdentityResponse> ListAppPoliciesForIdentityAsync(ListAppPoliciesForIdentityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppPoliciesForIdentityWithOptionsAsync(request, runtime);
        }

        public ListAuditSecurityIpResponse ListAuditSecurityIpWithOptions(ListAuditSecurityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["SecurityGroupName"] = request.SecurityGroupName;
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
            query["SecurityGroupName"] = request.SecurityGroupName;
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
            query["VideoId"] = request.VideoId;
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
            query["VideoId"] = request.VideoId;
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

        public ListLiveRecordVideoResponse ListLiveRecordVideoWithOptions(ListLiveRecordVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppName"] = request.AppName;
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["SortBy"] = request.SortBy;
            query["StartTime"] = request.StartTime;
            query["StreamName"] = request.StreamName;
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

        public async Task<ListLiveRecordVideoResponse> ListLiveRecordVideoWithOptionsAsync(ListLiveRecordVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppName"] = request.AppName;
            query["DomainName"] = request.DomainName;
            query["EndTime"] = request.EndTime;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["SortBy"] = request.SortBy;
            query["StartTime"] = request.StartTime;
            query["StreamName"] = request.StreamName;
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

        public ListLiveRecordVideoResponse ListLiveRecordVideo(ListLiveRecordVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveRecordVideoWithOptions(request, runtime);
        }

        public async Task<ListLiveRecordVideoResponse> ListLiveRecordVideoAsync(ListLiveRecordVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveRecordVideoWithOptionsAsync(request, runtime);
        }

        public ListMediaDNADeleteJobResponse ListMediaDNADeleteJobWithOptions(ListMediaDNADeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobIds"] = request.JobIds;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMediaDNADeleteJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaDNADeleteJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMediaDNADeleteJobResponse> ListMediaDNADeleteJobWithOptionsAsync(ListMediaDNADeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobIds"] = request.JobIds;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMediaDNADeleteJob",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMediaDNADeleteJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMediaDNADeleteJobResponse ListMediaDNADeleteJob(ListMediaDNADeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMediaDNADeleteJobWithOptions(request, runtime);
        }

        public async Task<ListMediaDNADeleteJobResponse> ListMediaDNADeleteJobAsync(ListMediaDNADeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMediaDNADeleteJobWithOptionsAsync(request, runtime);
        }

        public ListSnapshotsResponse ListSnapshotsWithOptions(ListSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AuthTimeout"] = request.AuthTimeout;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["SnapshotType"] = request.SnapshotType;
            query["VideoId"] = request.VideoId;
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

        public async Task<ListSnapshotsResponse> ListSnapshotsWithOptionsAsync(ListSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AuthTimeout"] = request.AuthTimeout;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["SnapshotType"] = request.SnapshotType;
            query["VideoId"] = request.VideoId;
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

        public ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSnapshotsWithOptions(request, runtime);
        }

        public async Task<ListSnapshotsResponse> ListSnapshotsAsync(ListSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSnapshotsWithOptionsAsync(request, runtime);
        }

        public ListTranscodeTaskResponse ListTranscodeTaskWithOptions(ListTranscodeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["StartTime"] = request.StartTime;
            query["VideoId"] = request.VideoId;
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

        public async Task<ListTranscodeTaskResponse> ListTranscodeTaskWithOptionsAsync(ListTranscodeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["StartTime"] = request.StartTime;
            query["VideoId"] = request.VideoId;
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

        public ListTranscodeTaskResponse ListTranscodeTask(ListTranscodeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTranscodeTaskWithOptions(request, runtime);
        }

        public async Task<ListTranscodeTaskResponse> ListTranscodeTaskAsync(ListTranscodeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTranscodeTaskWithOptionsAsync(request, runtime);
        }

        public ListTranscodeTemplateGroupResponse ListTranscodeTemplateGroupWithOptions(ListTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
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

        public async Task<ListTranscodeTemplateGroupResponse> ListTranscodeTemplateGroupWithOptionsAsync(ListTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
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

        public ListTranscodeTemplateGroupResponse ListTranscodeTemplateGroup(ListTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTranscodeTemplateGroupWithOptions(request, runtime);
        }

        public async Task<ListTranscodeTemplateGroupResponse> ListTranscodeTemplateGroupAsync(ListTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTranscodeTemplateGroupWithOptionsAsync(request, runtime);
        }

        public ListVodRealtimeLogDeliveryDomainsResponse ListVodRealtimeLogDeliveryDomainsWithOptions(ListVodRealtimeLogDeliveryDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVodRealtimeLogDeliveryDomains",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVodRealtimeLogDeliveryDomainsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListVodRealtimeLogDeliveryDomainsResponse> ListVodRealtimeLogDeliveryDomainsWithOptionsAsync(ListVodRealtimeLogDeliveryDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVodRealtimeLogDeliveryDomains",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVodRealtimeLogDeliveryDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListVodRealtimeLogDeliveryDomainsResponse ListVodRealtimeLogDeliveryDomains(ListVodRealtimeLogDeliveryDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVodRealtimeLogDeliveryDomainsWithOptions(request, runtime);
        }

        public async Task<ListVodRealtimeLogDeliveryDomainsResponse> ListVodRealtimeLogDeliveryDomainsAsync(ListVodRealtimeLogDeliveryDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVodRealtimeLogDeliveryDomainsWithOptionsAsync(request, runtime);
        }

        public ListVodRealtimeLogDeliveryInfosResponse ListVodRealtimeLogDeliveryInfosWithOptions(ListVodRealtimeLogDeliveryInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVodRealtimeLogDeliveryInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVodRealtimeLogDeliveryInfosResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListVodRealtimeLogDeliveryInfosResponse> ListVodRealtimeLogDeliveryInfosWithOptionsAsync(ListVodRealtimeLogDeliveryInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVodRealtimeLogDeliveryInfos",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVodRealtimeLogDeliveryInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListVodRealtimeLogDeliveryInfosResponse ListVodRealtimeLogDeliveryInfos(ListVodRealtimeLogDeliveryInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVodRealtimeLogDeliveryInfosWithOptions(request, runtime);
        }

        public async Task<ListVodRealtimeLogDeliveryInfosResponse> ListVodRealtimeLogDeliveryInfosAsync(ListVodRealtimeLogDeliveryInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVodRealtimeLogDeliveryInfosWithOptionsAsync(request, runtime);
        }

        public ListVodTemplateResponse ListVodTemplateWithOptions(ListVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["TemplateType"] = request.TemplateType;
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
            query["AppId"] = request.AppId;
            query["TemplateType"] = request.TemplateType;
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
            query["AppId"] = request.AppId;
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
            query["AppId"] = request.AppId;
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
            query["ResourceIds"] = request.ResourceIds;
            query["ResourceType"] = request.ResourceType;
            query["TargetAppId"] = request.TargetAppId;
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
            query["ResourceIds"] = request.ResourceIds;
            query["ResourceType"] = request.ResourceType;
            query["TargetAppId"] = request.TargetAppId;
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

        public PreloadVodObjectCachesResponse PreloadVodObjectCachesWithOptions(PreloadVodObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ObjectPath"] = request.ObjectPath;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public async Task<PreloadVodObjectCachesResponse> PreloadVodObjectCachesWithOptionsAsync(PreloadVodObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ObjectPath"] = request.ObjectPath;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public PreloadVodObjectCachesResponse PreloadVodObjectCaches(PreloadVodObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreloadVodObjectCachesWithOptions(request, runtime);
        }

        public async Task<PreloadVodObjectCachesResponse> PreloadVodObjectCachesAsync(PreloadVodObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreloadVodObjectCachesWithOptionsAsync(request, runtime);
        }

        public ProduceEditingProjectVideoResponse ProduceEditingProjectVideoWithOptions(ProduceEditingProjectVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["MediaMetadata"] = request.MediaMetadata;
            query["OwnerId"] = request.OwnerId;
            query["ProduceConfig"] = request.ProduceConfig;
            query["ProjectId"] = request.ProjectId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Timeline"] = request.Timeline;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
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

        public async Task<ProduceEditingProjectVideoResponse> ProduceEditingProjectVideoWithOptionsAsync(ProduceEditingProjectVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["MediaMetadata"] = request.MediaMetadata;
            query["OwnerId"] = request.OwnerId;
            query["ProduceConfig"] = request.ProduceConfig;
            query["ProjectId"] = request.ProjectId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Timeline"] = request.Timeline;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
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

        public ProduceEditingProjectVideoResponse ProduceEditingProjectVideo(ProduceEditingProjectVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProduceEditingProjectVideoWithOptions(request, runtime);
        }

        public async Task<ProduceEditingProjectVideoResponse> ProduceEditingProjectVideoAsync(ProduceEditingProjectVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProduceEditingProjectVideoWithOptionsAsync(request, runtime);
        }

        public RefreshUploadVideoResponse RefreshUploadVideoWithOptions(RefreshUploadVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VideoId"] = request.VideoId;
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

        public async Task<RefreshUploadVideoResponse> RefreshUploadVideoWithOptionsAsync(RefreshUploadVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VideoId"] = request.VideoId;
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

        public RefreshUploadVideoResponse RefreshUploadVideo(RefreshUploadVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshUploadVideoWithOptions(request, runtime);
        }

        public async Task<RefreshUploadVideoResponse> RefreshUploadVideoAsync(RefreshUploadVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshUploadVideoWithOptionsAsync(request, runtime);
        }

        public RefreshVodObjectCachesResponse RefreshVodObjectCachesWithOptions(RefreshVodObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ObjectPath"] = request.ObjectPath;
            query["ObjectType"] = request.ObjectType;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public async Task<RefreshVodObjectCachesResponse> RefreshVodObjectCachesWithOptionsAsync(RefreshVodObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ObjectPath"] = request.ObjectPath;
            query["ObjectType"] = request.ObjectType;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
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

        public RefreshVodObjectCachesResponse RefreshVodObjectCaches(RefreshVodObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshVodObjectCachesWithOptions(request, runtime);
        }

        public async Task<RefreshVodObjectCachesResponse> RefreshVodObjectCachesAsync(RefreshVodObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshVodObjectCachesWithOptionsAsync(request, runtime);
        }

        public RegisterMediaResponse RegisterMediaWithOptions(RegisterMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegisterMetadatas"] = request.RegisterMetadatas;
            query["TemplateGroupId"] = request.TemplateGroupId;
            query["UserData"] = request.UserData;
            query["WorkflowId"] = request.WorkflowId;
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

        public async Task<RegisterMediaResponse> RegisterMediaWithOptionsAsync(RegisterMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegisterMetadatas"] = request.RegisterMetadatas;
            query["TemplateGroupId"] = request.TemplateGroupId;
            query["UserData"] = request.UserData;
            query["WorkflowId"] = request.WorkflowId;
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

        public RegisterMediaResponse RegisterMedia(RegisterMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterMediaWithOptions(request, runtime);
        }

        public async Task<RegisterMediaResponse> RegisterMediaAsync(RegisterMediaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterMediaWithOptionsAsync(request, runtime);
        }

        public SearchEditingProjectResponse SearchEditingProjectWithOptions(SearchEditingProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndTime"] = request.EndTime;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SortBy"] = request.SortBy;
            query["StartTime"] = request.StartTime;
            query["Status"] = request.Status;
            query["Title"] = request.Title;
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
            query["EndTime"] = request.EndTime;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["SortBy"] = request.SortBy;
            query["StartTime"] = request.StartTime;
            query["Status"] = request.Status;
            query["Title"] = request.Title;
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

        public SearchMediaResponse SearchMediaWithOptions(SearchMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Fields"] = request.Fields;
            query["Match"] = request.Match;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["ScrollToken"] = request.ScrollToken;
            query["SearchType"] = request.SearchType;
            query["SortBy"] = request.SortBy;
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

        public async Task<SearchMediaResponse> SearchMediaWithOptionsAsync(SearchMediaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Fields"] = request.Fields;
            query["Match"] = request.Match;
            query["PageNo"] = request.PageNo;
            query["PageSize"] = request.PageSize;
            query["ScrollToken"] = request.ScrollToken;
            query["SearchType"] = request.SearchType;
            query["SortBy"] = request.SortBy;
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

        public SetAuditSecurityIpResponse SetAuditSecurityIpWithOptions(SetAuditSecurityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Ips"] = request.Ips;
            query["OperateMode"] = request.OperateMode;
            query["SecurityGroupName"] = request.SecurityGroupName;
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

        public async Task<SetAuditSecurityIpResponse> SetAuditSecurityIpWithOptionsAsync(SetAuditSecurityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Ips"] = request.Ips;
            query["OperateMode"] = request.OperateMode;
            query["SecurityGroupName"] = request.SecurityGroupName;
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

        public SetAuditSecurityIpResponse SetAuditSecurityIp(SetAuditSecurityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAuditSecurityIpWithOptions(request, runtime);
        }

        public async Task<SetAuditSecurityIpResponse> SetAuditSecurityIpAsync(SetAuditSecurityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAuditSecurityIpWithOptionsAsync(request, runtime);
        }

        public SetCrossdomainContentResponse SetCrossdomainContentWithOptions(SetCrossdomainContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Content"] = request.Content;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceRealOwnerId"] = request.ResourceRealOwnerId;
            query["StorageLocation"] = request.StorageLocation;
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

        public async Task<SetCrossdomainContentResponse> SetCrossdomainContentWithOptionsAsync(SetCrossdomainContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Content"] = request.Content;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceRealOwnerId"] = request.ResourceRealOwnerId;
            query["StorageLocation"] = request.StorageLocation;
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

        public SetCrossdomainContentResponse SetCrossdomainContent(SetCrossdomainContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCrossdomainContentWithOptions(request, runtime);
        }

        public async Task<SetCrossdomainContentResponse> SetCrossdomainContentAsync(SetCrossdomainContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCrossdomainContentWithOptionsAsync(request, runtime);
        }

        public SetDefaultAITemplateResponse SetDefaultAITemplateWithOptions(SetDefaultAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateId"] = request.TemplateId;
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

        public async Task<SetDefaultAITemplateResponse> SetDefaultAITemplateWithOptionsAsync(SetDefaultAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateId"] = request.TemplateId;
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

        public SetDefaultAITemplateResponse SetDefaultAITemplate(SetDefaultAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultAITemplateWithOptions(request, runtime);
        }

        public async Task<SetDefaultAITemplateResponse> SetDefaultAITemplateAsync(SetDefaultAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultAITemplateWithOptionsAsync(request, runtime);
        }

        public SetDefaultTranscodeTemplateGroupResponse SetDefaultTranscodeTemplateGroupWithOptions(SetDefaultTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
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
            query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
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
            query["WatermarkId"] = request.WatermarkId;
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
            query["WatermarkId"] = request.WatermarkId;
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
            query["MaterialIds"] = request.MaterialIds;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProjectId"] = request.ProjectId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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
            query["MaterialIds"] = request.MaterialIds;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProjectId"] = request.ProjectId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public SetMessageCallbackResponse SetMessageCallbackWithOptions(SetMessageCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["AuthKey"] = request.AuthKey;
            query["AuthSwitch"] = request.AuthSwitch;
            query["CallbackType"] = request.CallbackType;
            query["CallbackURL"] = request.CallbackURL;
            query["EventTypeList"] = request.EventTypeList;
            query["MnsEndpoint"] = request.MnsEndpoint;
            query["MnsQueueName"] = request.MnsQueueName;
            query["OwnerAccount"] = request.OwnerAccount;
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

        public async Task<SetMessageCallbackResponse> SetMessageCallbackWithOptionsAsync(SetMessageCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["AuthKey"] = request.AuthKey;
            query["AuthSwitch"] = request.AuthSwitch;
            query["CallbackType"] = request.CallbackType;
            query["CallbackURL"] = request.CallbackURL;
            query["EventTypeList"] = request.EventTypeList;
            query["MnsEndpoint"] = request.MnsEndpoint;
            query["MnsQueueName"] = request.MnsQueueName;
            query["OwnerAccount"] = request.OwnerAccount;
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

        public SetMessageCallbackResponse SetMessageCallback(SetMessageCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetMessageCallbackWithOptions(request, runtime);
        }

        public async Task<SetMessageCallbackResponse> SetMessageCallbackAsync(SetMessageCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetMessageCallbackWithOptionsAsync(request, runtime);
        }

        public SetVodDomainCertificateResponse SetVodDomainCertificateWithOptions(SetVodDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CertName"] = request.CertName;
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
            query["SSLPri"] = request.SSLPri;
            query["SSLProtocol"] = request.SSLProtocol;
            query["SSLPub"] = request.SSLPub;
            query["SecurityToken"] = request.SecurityToken;
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

        public async Task<SetVodDomainCertificateResponse> SetVodDomainCertificateWithOptionsAsync(SetVodDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CertName"] = request.CertName;
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
            query["SSLPri"] = request.SSLPri;
            query["SSLProtocol"] = request.SSLProtocol;
            query["SSLPub"] = request.SSLPub;
            query["SecurityToken"] = request.SecurityToken;
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

        public SetVodDomainCertificateResponse SetVodDomainCertificate(SetVodDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetVodDomainCertificateWithOptions(request, runtime);
        }

        public async Task<SetVodDomainCertificateResponse> SetVodDomainCertificateAsync(SetVodDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetVodDomainCertificateWithOptionsAsync(request, runtime);
        }

        public SubmitAIImageAuditJobResponse SubmitAIImageAuditJobWithOptions(SubmitAIImageAuditJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaAuditConfiguration"] = request.MediaAuditConfiguration;
            query["MediaId"] = request.MediaId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TemplateId"] = request.TemplateId;
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
            query["MediaAuditConfiguration"] = request.MediaAuditConfiguration;
            query["MediaId"] = request.MediaId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TemplateId"] = request.TemplateId;
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

        public SubmitAIImageJobResponse SubmitAIImageJobWithOptions(SubmitAIImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AIPipelineId"] = request.AIPipelineId;
            query["AITemplateId"] = request.AITemplateId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["UserData"] = request.UserData;
            query["VideoId"] = request.VideoId;
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

        public async Task<SubmitAIImageJobResponse> SubmitAIImageJobWithOptionsAsync(SubmitAIImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AIPipelineId"] = request.AIPipelineId;
            query["AITemplateId"] = request.AITemplateId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["UserData"] = request.UserData;
            query["VideoId"] = request.VideoId;
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

        public SubmitAIImageJobResponse SubmitAIImageJob(SubmitAIImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAIImageJobWithOptions(request, runtime);
        }

        public async Task<SubmitAIImageJobResponse> SubmitAIImageJobAsync(SubmitAIImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAIImageJobWithOptionsAsync(request, runtime);
        }

        public SubmitAIJobResponse SubmitAIJobWithOptions(SubmitAIJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Config"] = request.Config;
            query["MediaId"] = request.MediaId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Types"] = request.Types;
            query["UserData"] = request.UserData;
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

        public async Task<SubmitAIJobResponse> SubmitAIJobWithOptionsAsync(SubmitAIJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Config"] = request.Config;
            query["MediaId"] = request.MediaId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Types"] = request.Types;
            query["UserData"] = request.UserData;
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

        public SubmitAIJobResponse SubmitAIJob(SubmitAIJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitAIJobWithOptions(request, runtime);
        }

        public async Task<SubmitAIJobResponse> SubmitAIJobAsync(SubmitAIJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitAIJobWithOptionsAsync(request, runtime);
        }

        public SubmitAIMediaAuditJobResponse SubmitAIMediaAuditJobWithOptions(SubmitAIMediaAuditJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaAuditConfiguration"] = request.MediaAuditConfiguration;
            query["MediaId"] = request.MediaId;
            query["MediaType"] = request.MediaType;
            query["TemplateId"] = request.TemplateId;
            query["UserData"] = request.UserData;
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
            query["MediaAuditConfiguration"] = request.MediaAuditConfiguration;
            query["MediaId"] = request.MediaId;
            query["MediaType"] = request.MediaType;
            query["TemplateId"] = request.TemplateId;
            query["UserData"] = request.UserData;
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

        public SubmitDynamicImageJobResponse SubmitDynamicImageJobWithOptions(SubmitDynamicImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DynamicImageTemplateId"] = request.DynamicImageTemplateId;
            query["OverrideParams"] = request.OverrideParams;
            query["VideoId"] = request.VideoId;
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

        public async Task<SubmitDynamicImageJobResponse> SubmitDynamicImageJobWithOptionsAsync(SubmitDynamicImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DynamicImageTemplateId"] = request.DynamicImageTemplateId;
            query["OverrideParams"] = request.OverrideParams;
            query["VideoId"] = request.VideoId;
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

        public SubmitLiveEditingResponse SubmitLiveEditingWithOptions(SubmitLiveEditingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppName"] = request.AppName;
            query["Clips"] = request.Clips;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["DomainName"] = request.DomainName;
            query["MediaMetadata"] = request.MediaMetadata;
            query["OwnerId"] = request.OwnerId;
            query["ProduceConfig"] = request.ProduceConfig;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StreamName"] = request.StreamName;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitLiveEditing",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitLiveEditingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitLiveEditingResponse> SubmitLiveEditingWithOptionsAsync(SubmitLiveEditingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppName"] = request.AppName;
            query["Clips"] = request.Clips;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["DomainName"] = request.DomainName;
            query["MediaMetadata"] = request.MediaMetadata;
            query["OwnerId"] = request.OwnerId;
            query["ProduceConfig"] = request.ProduceConfig;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["StreamName"] = request.StreamName;
            query["Title"] = request.Title;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitLiveEditing",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitLiveEditingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitLiveEditingResponse SubmitLiveEditing(SubmitLiveEditingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitLiveEditingWithOptions(request, runtime);
        }

        public async Task<SubmitLiveEditingResponse> SubmitLiveEditingAsync(SubmitLiveEditingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitLiveEditingWithOptionsAsync(request, runtime);
        }

        public SubmitMediaDNADeleteJobResponse SubmitMediaDNADeleteJobWithOptions(SubmitMediaDNADeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public async Task<SubmitMediaDNADeleteJobResponse> SubmitMediaDNADeleteJobWithOptionsAsync(SubmitMediaDNADeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
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

        public SubmitMediaDNADeleteJobResponse SubmitMediaDNADeleteJob(SubmitMediaDNADeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitMediaDNADeleteJobWithOptions(request, runtime);
        }

        public async Task<SubmitMediaDNADeleteJobResponse> SubmitMediaDNADeleteJobAsync(SubmitMediaDNADeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitMediaDNADeleteJobWithOptionsAsync(request, runtime);
        }

        public SubmitPreprocessJobsResponse SubmitPreprocessJobsWithOptions(SubmitPreprocessJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PreprocessType"] = request.PreprocessType;
            query["VideoId"] = request.VideoId;
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

        public async Task<SubmitPreprocessJobsResponse> SubmitPreprocessJobsWithOptionsAsync(SubmitPreprocessJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PreprocessType"] = request.PreprocessType;
            query["VideoId"] = request.VideoId;
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

        public SubmitPreprocessJobsResponse SubmitPreprocessJobs(SubmitPreprocessJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitPreprocessJobsWithOptions(request, runtime);
        }

        public async Task<SubmitPreprocessJobsResponse> SubmitPreprocessJobsAsync(SubmitPreprocessJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitPreprocessJobsWithOptionsAsync(request, runtime);
        }

        public SubmitSnapshotJobResponse SubmitSnapshotJobWithOptions(SubmitSnapshotJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Count"] = request.Count;
            query["Height"] = request.Height;
            query["Interval"] = request.Interval;
            query["SnapshotTemplateId"] = request.SnapshotTemplateId;
            query["SpecifiedOffsetTime"] = request.SpecifiedOffsetTime;
            query["SpriteSnapshotConfig"] = request.SpriteSnapshotConfig;
            query["UserData"] = request.UserData;
            query["VideoId"] = request.VideoId;
            query["Width"] = request.Width;
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

        public async Task<SubmitSnapshotJobResponse> SubmitSnapshotJobWithOptionsAsync(SubmitSnapshotJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Count"] = request.Count;
            query["Height"] = request.Height;
            query["Interval"] = request.Interval;
            query["SnapshotTemplateId"] = request.SnapshotTemplateId;
            query["SpecifiedOffsetTime"] = request.SpecifiedOffsetTime;
            query["SpriteSnapshotConfig"] = request.SpriteSnapshotConfig;
            query["UserData"] = request.UserData;
            query["VideoId"] = request.VideoId;
            query["Width"] = request.Width;
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

        public SubmitTranscodeJobsResponse SubmitTranscodeJobsWithOptions(SubmitTranscodeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EncryptConfig"] = request.EncryptConfig;
            query["OverrideParams"] = request.OverrideParams;
            query["PipelineId"] = request.PipelineId;
            query["Priority"] = request.Priority;
            query["TemplateGroupId"] = request.TemplateGroupId;
            query["UserData"] = request.UserData;
            query["VideoId"] = request.VideoId;
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

        public async Task<SubmitTranscodeJobsResponse> SubmitTranscodeJobsWithOptionsAsync(SubmitTranscodeJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EncryptConfig"] = request.EncryptConfig;
            query["OverrideParams"] = request.OverrideParams;
            query["PipelineId"] = request.PipelineId;
            query["Priority"] = request.Priority;
            query["TemplateGroupId"] = request.TemplateGroupId;
            query["UserData"] = request.UserData;
            query["VideoId"] = request.VideoId;
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

        public SubmitTranscodeJobsResponse SubmitTranscodeJobs(SubmitTranscodeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTranscodeJobsWithOptions(request, runtime);
        }

        public async Task<SubmitTranscodeJobsResponse> SubmitTranscodeJobsAsync(SubmitTranscodeJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitTranscodeJobsWithOptionsAsync(request, runtime);
        }

        public SubmitWorkflowJobResponse SubmitWorkflowJobWithOptions(SubmitWorkflowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MediaId"] = request.MediaId;
            query["WorkflowId"] = request.WorkflowId;
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
            query["MediaId"] = request.MediaId;
            query["WorkflowId"] = request.WorkflowId;
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

        public TagVodResourcesResponse TagVodResourcesWithOptions(TagVodResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagVodResources",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagVodResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TagVodResourcesResponse> TagVodResourcesWithOptionsAsync(TagVodResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerId"] = request.OwnerId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagVodResources",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagVodResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TagVodResourcesResponse TagVodResources(TagVodResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagVodResourcesWithOptions(request, runtime);
        }

        public async Task<TagVodResourcesResponse> TagVodResourcesAsync(TagVodResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagVodResourcesWithOptionsAsync(request, runtime);
        }

        public UnTagVodResourcesResponse UnTagVodResourcesWithOptions(UnTagVodResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["All"] = request.All;
            query["OwnerId"] = request.OwnerId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceType"] = request.ResourceType;
            query["TagKey"] = request.TagKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnTagVodResources",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnTagVodResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnTagVodResourcesResponse> UnTagVodResourcesWithOptionsAsync(UnTagVodResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["All"] = request.All;
            query["OwnerId"] = request.OwnerId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceType"] = request.ResourceType;
            query["TagKey"] = request.TagKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnTagVodResources",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnTagVodResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnTagVodResourcesResponse UnTagVodResources(UnTagVodResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnTagVodResourcesWithOptions(request, runtime);
        }

        public async Task<UnTagVodResourcesResponse> UnTagVodResourcesAsync(UnTagVodResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnTagVodResourcesWithOptionsAsync(request, runtime);
        }

        public UpdateAITemplateResponse UpdateAITemplateWithOptions(UpdateAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateConfig"] = request.TemplateConfig;
            query["TemplateId"] = request.TemplateId;
            query["TemplateName"] = request.TemplateName;
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

        public async Task<UpdateAITemplateResponse> UpdateAITemplateWithOptionsAsync(UpdateAITemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["TemplateConfig"] = request.TemplateConfig;
            query["TemplateId"] = request.TemplateId;
            query["TemplateName"] = request.TemplateName;
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

        public UpdateAITemplateResponse UpdateAITemplate(UpdateAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAITemplateWithOptions(request, runtime);
        }

        public async Task<UpdateAITemplateResponse> UpdateAITemplateAsync(UpdateAITemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAITemplateWithOptionsAsync(request, runtime);
        }

        public UpdateAppInfoResponse UpdateAppInfoWithOptions(UpdateAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["AppName"] = request.AppName;
            query["Description"] = request.Description;
            query["Status"] = request.Status;
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

        public async Task<UpdateAppInfoResponse> UpdateAppInfoWithOptionsAsync(UpdateAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["AppName"] = request.AppName;
            query["Description"] = request.Description;
            query["Status"] = request.Status;
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

        public UpdateAppInfoResponse UpdateAppInfo(UpdateAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppInfoWithOptions(request, runtime);
        }

        public async Task<UpdateAppInfoResponse> UpdateAppInfoAsync(UpdateAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppInfoWithOptionsAsync(request, runtime);
        }

        public UpdateAttachedMediaInfosResponse UpdateAttachedMediaInfosWithOptions(UpdateAttachedMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["UpdateContent"] = request.UpdateContent;
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

        public async Task<UpdateAttachedMediaInfosResponse> UpdateAttachedMediaInfosWithOptionsAsync(UpdateAttachedMediaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["UpdateContent"] = request.UpdateContent;
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

        public UpdateAttachedMediaInfosResponse UpdateAttachedMediaInfos(UpdateAttachedMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAttachedMediaInfosWithOptions(request, runtime);
        }

        public async Task<UpdateAttachedMediaInfosResponse> UpdateAttachedMediaInfosAsync(UpdateAttachedMediaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAttachedMediaInfosWithOptionsAsync(request, runtime);
        }

        public UpdateCategoryResponse UpdateCategoryWithOptions(UpdateCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CateId"] = request.CateId;
            query["CateName"] = request.CateName;
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
            query["CateId"] = request.CateId;
            query["CateName"] = request.CateName;
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
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProjectId"] = request.ProjectId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Timeline"] = request.Timeline;
            query["Title"] = request.Title;
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
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProjectId"] = request.ProjectId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Timeline"] = request.Timeline;
            query["Title"] = request.Title;
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
            query["UpdateContent"] = request.UpdateContent;
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
            query["UpdateContent"] = request.UpdateContent;
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

        public UpdateStreamInfoResponse UpdateStreamInfoWithOptions(UpdateStreamInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobId"] = request.JobId;
            query["MediaId"] = request.MediaId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStreamInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStreamInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateStreamInfoResponse> UpdateStreamInfoWithOptionsAsync(UpdateStreamInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["JobId"] = request.JobId;
            query["MediaId"] = request.MediaId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStreamInfo",
                Version = "2017-03-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStreamInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateStreamInfoResponse UpdateStreamInfo(UpdateStreamInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStreamInfoWithOptions(request, runtime);
        }

        public async Task<UpdateStreamInfoResponse> UpdateStreamInfoAsync(UpdateStreamInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStreamInfoWithOptionsAsync(request, runtime);
        }

        public UpdateTranscodeTemplateGroupResponse UpdateTranscodeTemplateGroupWithOptions(UpdateTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Locked"] = request.Locked;
            query["Name"] = request.Name;
            query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            query["TranscodeTemplateList"] = request.TranscodeTemplateList;
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

        public async Task<UpdateTranscodeTemplateGroupResponse> UpdateTranscodeTemplateGroupWithOptionsAsync(UpdateTranscodeTemplateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Locked"] = request.Locked;
            query["Name"] = request.Name;
            query["TranscodeTemplateGroupId"] = request.TranscodeTemplateGroupId;
            query["TranscodeTemplateList"] = request.TranscodeTemplateList;
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

        public UpdateTranscodeTemplateGroupResponse UpdateTranscodeTemplateGroup(UpdateTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTranscodeTemplateGroupWithOptions(request, runtime);
        }

        public async Task<UpdateTranscodeTemplateGroupResponse> UpdateTranscodeTemplateGroupAsync(UpdateTranscodeTemplateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTranscodeTemplateGroupWithOptionsAsync(request, runtime);
        }

        public UpdateVideoInfoResponse UpdateVideoInfoWithOptions(UpdateVideoInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CateId"] = request.CateId;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["Tags"] = request.Tags;
            query["Title"] = request.Title;
            query["VideoId"] = request.VideoId;
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

        public async Task<UpdateVideoInfoResponse> UpdateVideoInfoWithOptionsAsync(UpdateVideoInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CateId"] = request.CateId;
            query["CoverURL"] = request.CoverURL;
            query["Description"] = request.Description;
            query["Tags"] = request.Tags;
            query["Title"] = request.Title;
            query["VideoId"] = request.VideoId;
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

        public UpdateVideoInfoResponse UpdateVideoInfo(UpdateVideoInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVideoInfoWithOptions(request, runtime);
        }

        public async Task<UpdateVideoInfoResponse> UpdateVideoInfoAsync(UpdateVideoInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVideoInfoWithOptionsAsync(request, runtime);
        }

        public UpdateVideoInfosResponse UpdateVideoInfosWithOptions(UpdateVideoInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["UpdateContent"] = request.UpdateContent;
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

        public async Task<UpdateVideoInfosResponse> UpdateVideoInfosWithOptionsAsync(UpdateVideoInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["UpdateContent"] = request.UpdateContent;
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

        public UpdateVideoInfosResponse UpdateVideoInfos(UpdateVideoInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVideoInfosWithOptions(request, runtime);
        }

        public async Task<UpdateVideoInfosResponse> UpdateVideoInfosAsync(UpdateVideoInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVideoInfosWithOptionsAsync(request, runtime);
        }

        public UpdateVodDomainResponse UpdateVodDomainWithOptions(UpdateVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
            query["Sources"] = request.Sources;
            query["TopLevelDomain"] = request.TopLevelDomain;
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

        public async Task<UpdateVodDomainResponse> UpdateVodDomainWithOptionsAsync(UpdateVodDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
            query["SecurityToken"] = request.SecurityToken;
            query["Sources"] = request.Sources;
            query["TopLevelDomain"] = request.TopLevelDomain;
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

        public UpdateVodDomainResponse UpdateVodDomain(UpdateVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVodDomainWithOptions(request, runtime);
        }

        public async Task<UpdateVodDomainResponse> UpdateVodDomainAsync(UpdateVodDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVodDomainWithOptionsAsync(request, runtime);
        }

        public UpdateVodTemplateResponse UpdateVodTemplateWithOptions(UpdateVodTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Name"] = request.Name;
            query["TemplateConfig"] = request.TemplateConfig;
            query["VodTemplateId"] = request.VodTemplateId;
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
            query["Name"] = request.Name;
            query["TemplateConfig"] = request.TemplateConfig;
            query["VodTemplateId"] = request.VodTemplateId;
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

        public UpdateWatermarkResponse UpdateWatermarkWithOptions(UpdateWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Name"] = request.Name;
            query["WatermarkConfig"] = request.WatermarkConfig;
            query["WatermarkId"] = request.WatermarkId;
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

        public async Task<UpdateWatermarkResponse> UpdateWatermarkWithOptionsAsync(UpdateWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Name"] = request.Name;
            query["WatermarkConfig"] = request.WatermarkConfig;
            query["WatermarkId"] = request.WatermarkId;
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

        public UpdateWatermarkResponse UpdateWatermark(UpdateWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWatermarkWithOptions(request, runtime);
        }

        public async Task<UpdateWatermarkResponse> UpdateWatermarkAsync(UpdateWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWatermarkWithOptionsAsync(request, runtime);
        }

        public UploadMediaByURLResponse UploadMediaByURLWithOptions(UploadMediaByURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["StorageLocation"] = request.StorageLocation;
            query["TemplateGroupId"] = request.TemplateGroupId;
            query["UploadMetadatas"] = request.UploadMetadatas;
            query["UploadURLs"] = request.UploadURLs;
            query["UserData"] = request.UserData;
            query["WorkflowId"] = request.WorkflowId;
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

        public async Task<UploadMediaByURLResponse> UploadMediaByURLWithOptionsAsync(UploadMediaByURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AppId"] = request.AppId;
            query["StorageLocation"] = request.StorageLocation;
            query["TemplateGroupId"] = request.TemplateGroupId;
            query["UploadMetadatas"] = request.UploadMetadatas;
            query["UploadURLs"] = request.UploadURLs;
            query["UserData"] = request.UserData;
            query["WorkflowId"] = request.WorkflowId;
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
            query["Definition"] = request.Definition;
            query["FileExtension"] = request.FileExtension;
            query["HDRType"] = request.HDRType;
            query["MediaId"] = request.MediaId;
            query["StreamURL"] = request.StreamURL;
            query["UserData"] = request.UserData;
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

        public async Task<UploadStreamByURLResponse> UploadStreamByURLWithOptionsAsync(UploadStreamByURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Definition"] = request.Definition;
            query["FileExtension"] = request.FileExtension;
            query["HDRType"] = request.HDRType;
            query["MediaId"] = request.MediaId;
            query["StreamURL"] = request.StreamURL;
            query["UserData"] = request.UserData;
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

        public VerifyVodDomainOwnerResponse VerifyVodDomainOwnerWithOptions(VerifyVodDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
            query["VerifyType"] = request.VerifyType;
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
            query["DomainName"] = request.DomainName;
            query["OwnerId"] = request.OwnerId;
            query["VerifyType"] = request.VerifyType;
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
