// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Waf_openapi20211001.Models;

namespace AlibabaCloud.SDK.Waf_openapi20211001
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-beijing", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-chengdu", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-zhangjiakou", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-huhehaote", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-heyuan", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-wulanchabu", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-hongkong", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"eu-central-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "wafopenapi.ap-southeast-1.aliyuncs.com"},
                {"cn-shanghai-finance-1", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "wafopenapi.cn-hangzhou.aliyuncs.com"},
                {"cn-north-2-gov-1", "wafopenapi.cn-hangzhou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("waf-openapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Clears an IP address blacklist for major event protection.
         *
         * @param request ClearMajorProtectionBlackIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearMajorProtectionBlackIpResponse
         */
        public ClearMajorProtectionBlackIpResponse ClearMajorProtectionBlackIpWithOptions(ClearMajorProtectionBlackIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "ClearMajorProtectionBlackIp",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearMajorProtectionBlackIpResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Clears an IP address blacklist for major event protection.
         *
         * @param request ClearMajorProtectionBlackIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearMajorProtectionBlackIpResponse
         */
        public async Task<ClearMajorProtectionBlackIpResponse> ClearMajorProtectionBlackIpWithOptionsAsync(ClearMajorProtectionBlackIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "ClearMajorProtectionBlackIp",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearMajorProtectionBlackIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Clears an IP address blacklist for major event protection.
         *
         * @param request ClearMajorProtectionBlackIpRequest
         * @return ClearMajorProtectionBlackIpResponse
         */
        public ClearMajorProtectionBlackIpResponse ClearMajorProtectionBlackIp(ClearMajorProtectionBlackIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearMajorProtectionBlackIpWithOptions(request, runtime);
        }

        /**
         * @summary Clears an IP address blacklist for major event protection.
         *
         * @param request ClearMajorProtectionBlackIpRequest
         * @return ClearMajorProtectionBlackIpResponse
         */
        public async Task<ClearMajorProtectionBlackIpResponse> ClearMajorProtectionBlackIpAsync(ClearMajorProtectionBlackIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearMajorProtectionBlackIpWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a new protection template from the copy.
         *
         * @param request CopyDefenseTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyDefenseTemplateResponse
         */
        public CopyDefenseTemplateResponse CopyDefenseTemplateWithOptions(CopyDefenseTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "CopyDefenseTemplate",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDefenseTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a new protection template from the copy.
         *
         * @param request CopyDefenseTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyDefenseTemplateResponse
         */
        public async Task<CopyDefenseTemplateResponse> CopyDefenseTemplateWithOptionsAsync(CopyDefenseTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "CopyDefenseTemplate",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDefenseTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a new protection template from the copy.
         *
         * @param request CopyDefenseTemplateRequest
         * @return CopyDefenseTemplateResponse
         */
        public CopyDefenseTemplateResponse CopyDefenseTemplate(CopyDefenseTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyDefenseTemplateWithOptions(request, runtime);
        }

        /**
         * @summary Creates a new protection template from the copy.
         *
         * @param request CopyDefenseTemplateRequest
         * @return CopyDefenseTemplateResponse
         */
        public async Task<CopyDefenseTemplateResponse> CopyDefenseTemplateAsync(CopyDefenseTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyDefenseTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a protected object group.
         *
         * @param request CreateDefenseResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDefenseResourceGroupResponse
         */
        public CreateDefenseResourceGroupResponse CreateDefenseResourceGroupWithOptions(CreateDefenseResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddList))
            {
                query["AddList"] = request.AddList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDefenseResourceGroup",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDefenseResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a protected object group.
         *
         * @param request CreateDefenseResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDefenseResourceGroupResponse
         */
        public async Task<CreateDefenseResourceGroupResponse> CreateDefenseResourceGroupWithOptionsAsync(CreateDefenseResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddList))
            {
                query["AddList"] = request.AddList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDefenseResourceGroup",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDefenseResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a protected object group.
         *
         * @param request CreateDefenseResourceGroupRequest
         * @return CreateDefenseResourceGroupResponse
         */
        public CreateDefenseResourceGroupResponse CreateDefenseResourceGroup(CreateDefenseResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDefenseResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates a protected object group.
         *
         * @param request CreateDefenseResourceGroupRequest
         * @return CreateDefenseResourceGroupResponse
         */
        public async Task<CreateDefenseResourceGroupResponse> CreateDefenseResourceGroupAsync(CreateDefenseResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDefenseResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a protection rule.
         *
         * @param request CreateDefenseRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDefenseRuleResponse
         */
        public CreateDefenseRuleResponse CreateDefenseRuleWithOptions(CreateDefenseRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseScene))
            {
                query["DefenseScene"] = request.DefenseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
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
                Action = "CreateDefenseRule",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDefenseRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a protection rule.
         *
         * @param request CreateDefenseRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDefenseRuleResponse
         */
        public async Task<CreateDefenseRuleResponse> CreateDefenseRuleWithOptionsAsync(CreateDefenseRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseScene))
            {
                query["DefenseScene"] = request.DefenseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
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
                Action = "CreateDefenseRule",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDefenseRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a protection rule.
         *
         * @param request CreateDefenseRuleRequest
         * @return CreateDefenseRuleResponse
         */
        public CreateDefenseRuleResponse CreateDefenseRule(CreateDefenseRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDefenseRuleWithOptions(request, runtime);
        }

        /**
         * @summary Creates a protection rule.
         *
         * @param request CreateDefenseRuleRequest
         * @return CreateDefenseRuleResponse
         */
        public async Task<CreateDefenseRuleResponse> CreateDefenseRuleAsync(CreateDefenseRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDefenseRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a protection rule template.
         *
         * @param request CreateDefenseTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDefenseTemplateResponse
         */
        public CreateDefenseTemplateResponse CreateDefenseTemplateWithOptions(CreateDefenseTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseScene))
            {
                query["DefenseScene"] = request.DefenseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateOrigin))
            {
                query["TemplateOrigin"] = request.TemplateOrigin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateStatus))
            {
                query["TemplateStatus"] = request.TemplateStatus;
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
                Action = "CreateDefenseTemplate",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDefenseTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a protection rule template.
         *
         * @param request CreateDefenseTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDefenseTemplateResponse
         */
        public async Task<CreateDefenseTemplateResponse> CreateDefenseTemplateWithOptionsAsync(CreateDefenseTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseScene))
            {
                query["DefenseScene"] = request.DefenseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateOrigin))
            {
                query["TemplateOrigin"] = request.TemplateOrigin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateStatus))
            {
                query["TemplateStatus"] = request.TemplateStatus;
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
                Action = "CreateDefenseTemplate",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDefenseTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a protection rule template.
         *
         * @param request CreateDefenseTemplateRequest
         * @return CreateDefenseTemplateResponse
         */
        public CreateDefenseTemplateResponse CreateDefenseTemplate(CreateDefenseTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDefenseTemplateWithOptions(request, runtime);
        }

        /**
         * @summary Creates a protection rule template.
         *
         * @param request CreateDefenseTemplateRequest
         * @return CreateDefenseTemplateResponse
         */
        public async Task<CreateDefenseTemplateResponse> CreateDefenseTemplateAsync(CreateDefenseTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDefenseTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds a domain name to Web Application Firewall (WAF).
         *
         * @param tmpReq CreateDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomainWithOptions(CreateDomainRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDomainShrinkRequest request = new CreateDomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Listen))
            {
                request.ListenShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Listen, "Listen", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Redirect))
            {
                request.RedirectShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Redirect, "Redirect", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenShrink))
            {
                query["Listen"] = request.ListenShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectShrink))
            {
                query["Redirect"] = request.RedirectShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds a domain name to Web Application Firewall (WAF).
         *
         * @param tmpReq CreateDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainWithOptionsAsync(CreateDomainRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDomainShrinkRequest request = new CreateDomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Listen))
            {
                request.ListenShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Listen, "Listen", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Redirect))
            {
                request.RedirectShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Redirect, "Redirect", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenShrink))
            {
                query["Listen"] = request.ListenShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectShrink))
            {
                query["Redirect"] = request.RedirectShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds a domain name to Web Application Firewall (WAF).
         *
         * @param request CreateDomainRequest
         * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDomainWithOptions(request, runtime);
        }

        /**
         * @summary Adds a domain name to Web Application Firewall (WAF).
         *
         * @param request CreateDomainRequest
         * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an IP address blacklist for major event protection.
         *
         * @description This operation is available only on the China site (aliyun.com).
         *
         * @param request CreateMajorProtectionBlackIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMajorProtectionBlackIpResponse
         */
        public CreateMajorProtectionBlackIpResponse CreateMajorProtectionBlackIpWithOptions(CreateMajorProtectionBlackIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTime))
            {
                query["ExpiredTime"] = request.ExpiredTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpList))
            {
                query["IpList"] = request.IpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "CreateMajorProtectionBlackIp",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMajorProtectionBlackIpResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an IP address blacklist for major event protection.
         *
         * @description This operation is available only on the China site (aliyun.com).
         *
         * @param request CreateMajorProtectionBlackIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMajorProtectionBlackIpResponse
         */
        public async Task<CreateMajorProtectionBlackIpResponse> CreateMajorProtectionBlackIpWithOptionsAsync(CreateMajorProtectionBlackIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTime))
            {
                query["ExpiredTime"] = request.ExpiredTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpList))
            {
                query["IpList"] = request.IpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "CreateMajorProtectionBlackIp",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMajorProtectionBlackIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an IP address blacklist for major event protection.
         *
         * @description This operation is available only on the China site (aliyun.com).
         *
         * @param request CreateMajorProtectionBlackIpRequest
         * @return CreateMajorProtectionBlackIpResponse
         */
        public CreateMajorProtectionBlackIpResponse CreateMajorProtectionBlackIp(CreateMajorProtectionBlackIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMajorProtectionBlackIpWithOptions(request, runtime);
        }

        /**
         * @summary Creates an IP address blacklist for major event protection.
         *
         * @description This operation is available only on the China site (aliyun.com).
         *
         * @param request CreateMajorProtectionBlackIpRequest
         * @return CreateMajorProtectionBlackIpResponse
         */
        public async Task<CreateMajorProtectionBlackIpResponse> CreateMajorProtectionBlackIpAsync(CreateMajorProtectionBlackIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMajorProtectionBlackIpWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds members to use the multi-account management feature of Web Application Firewall (WAF).
         *
         * @param request CreateMemberAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMemberAccountsResponse
         */
        public CreateMemberAccountsResponse CreateMemberAccountsWithOptions(CreateMemberAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccountIds))
            {
                query["MemberAccountIds"] = request.MemberAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemberAccounts",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemberAccountsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds members to use the multi-account management feature of Web Application Firewall (WAF).
         *
         * @param request CreateMemberAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMemberAccountsResponse
         */
        public async Task<CreateMemberAccountsResponse> CreateMemberAccountsWithOptionsAsync(CreateMemberAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccountIds))
            {
                query["MemberAccountIds"] = request.MemberAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMemberAccounts",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMemberAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds members to use the multi-account management feature of Web Application Firewall (WAF).
         *
         * @param request CreateMemberAccountsRequest
         * @return CreateMemberAccountsResponse
         */
        public CreateMemberAccountsResponse CreateMemberAccounts(CreateMemberAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMemberAccountsWithOptions(request, runtime);
        }

        /**
         * @summary Adds members to use the multi-account management feature of Web Application Firewall (WAF).
         *
         * @param request CreateMemberAccountsRequest
         * @return CreateMemberAccountsResponse
         */
        public async Task<CreateMemberAccountsResponse> CreateMemberAccountsAsync(CreateMemberAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMemberAccountsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a pay-as-you-go Web Application Firewall (WAF) 3.0 instance.
         *
         * @param request CreatePostpaidInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePostpaidInstanceResponse
         */
        public CreatePostpaidInstanceResponse CreatePostpaidInstanceWithOptions(CreatePostpaidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePostpaidInstance",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePostpaidInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a pay-as-you-go Web Application Firewall (WAF) 3.0 instance.
         *
         * @param request CreatePostpaidInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePostpaidInstanceResponse
         */
        public async Task<CreatePostpaidInstanceResponse> CreatePostpaidInstanceWithOptionsAsync(CreatePostpaidInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePostpaidInstance",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePostpaidInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a pay-as-you-go Web Application Firewall (WAF) 3.0 instance.
         *
         * @param request CreatePostpaidInstanceRequest
         * @return CreatePostpaidInstanceResponse
         */
        public CreatePostpaidInstanceResponse CreatePostpaidInstance(CreatePostpaidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePostpaidInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Creates a pay-as-you-go Web Application Firewall (WAF) 3.0 instance.
         *
         * @param request CreatePostpaidInstanceRequest
         * @return CreatePostpaidInstanceResponse
         */
        public async Task<CreatePostpaidInstanceResponse> CreatePostpaidInstanceAsync(CreatePostpaidInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePostpaidInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Uploads a ShangMi (SM) certificate for a domain name that is added to Web Application Firewall (WAF) in CNAME record mode.
         *
         * @param request CreateSM2CertRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSM2CertResponse
         */
        public CreateSM2CertResponse CreateSM2CertWithOptions(CreateSM2CertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptCertificate))
            {
                query["EncryptCertificate"] = request.EncryptCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptPrivateKey))
            {
                query["EncryptPrivateKey"] = request.EncryptPrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignCertificate))
            {
                query["SignCertificate"] = request.SignCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignPrivateKey))
            {
                query["SignPrivateKey"] = request.SignPrivateKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSM2Cert",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSM2CertResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Uploads a ShangMi (SM) certificate for a domain name that is added to Web Application Firewall (WAF) in CNAME record mode.
         *
         * @param request CreateSM2CertRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSM2CertResponse
         */
        public async Task<CreateSM2CertResponse> CreateSM2CertWithOptionsAsync(CreateSM2CertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertName))
            {
                query["CertName"] = request.CertName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptCertificate))
            {
                query["EncryptCertificate"] = request.EncryptCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptPrivateKey))
            {
                query["EncryptPrivateKey"] = request.EncryptPrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignCertificate))
            {
                query["SignCertificate"] = request.SignCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignPrivateKey))
            {
                query["SignPrivateKey"] = request.SignPrivateKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSM2Cert",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSM2CertResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Uploads a ShangMi (SM) certificate for a domain name that is added to Web Application Firewall (WAF) in CNAME record mode.
         *
         * @param request CreateSM2CertRequest
         * @return CreateSM2CertResponse
         */
        public CreateSM2CertResponse CreateSM2Cert(CreateSM2CertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSM2CertWithOptions(request, runtime);
        }

        /**
         * @summary Uploads a ShangMi (SM) certificate for a domain name that is added to Web Application Firewall (WAF) in CNAME record mode.
         *
         * @param request CreateSM2CertRequest
         * @return CreateSM2CertResponse
         */
        public async Task<CreateSM2CertResponse> CreateSM2CertAsync(CreateSM2CertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSM2CertWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除API安全风险
         *
         * @param request DeleteApisecAbnormalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApisecAbnormalResponse
         */
        public DeleteApisecAbnormalResponse DeleteApisecAbnormalWithOptions(DeleteApisecAbnormalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbnormalId))
            {
                query["AbnormalId"] = request.AbnormalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApisecAbnormal",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApisecAbnormalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除API安全风险
         *
         * @param request DeleteApisecAbnormalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApisecAbnormalResponse
         */
        public async Task<DeleteApisecAbnormalResponse> DeleteApisecAbnormalWithOptionsAsync(DeleteApisecAbnormalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbnormalId))
            {
                query["AbnormalId"] = request.AbnormalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApisecAbnormal",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApisecAbnormalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除API安全风险
         *
         * @param request DeleteApisecAbnormalRequest
         * @return DeleteApisecAbnormalResponse
         */
        public DeleteApisecAbnormalResponse DeleteApisecAbnormal(DeleteApisecAbnormalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApisecAbnormalWithOptions(request, runtime);
        }

        /**
         * @summary 删除API安全风险
         *
         * @param request DeleteApisecAbnormalRequest
         * @return DeleteApisecAbnormalResponse
         */
        public async Task<DeleteApisecAbnormalResponse> DeleteApisecAbnormalAsync(DeleteApisecAbnormalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApisecAbnormalWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除API安全事件
         *
         * @param request DeleteApisecEventRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApisecEventResponse
         */
        public DeleteApisecEventResponse DeleteApisecEventWithOptions(DeleteApisecEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApisecEvent",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApisecEventResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除API安全事件
         *
         * @param request DeleteApisecEventRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApisecEventResponse
         */
        public async Task<DeleteApisecEventResponse> DeleteApisecEventWithOptionsAsync(DeleteApisecEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApisecEvent",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApisecEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除API安全事件
         *
         * @param request DeleteApisecEventRequest
         * @return DeleteApisecEventResponse
         */
        public DeleteApisecEventResponse DeleteApisecEvent(DeleteApisecEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApisecEventWithOptions(request, runtime);
        }

        /**
         * @summary 删除API安全事件
         *
         * @param request DeleteApisecEventRequest
         * @return DeleteApisecEventResponse
         */
        public async Task<DeleteApisecEventResponse> DeleteApisecEventAsync(DeleteApisecEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApisecEventWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a protected object group.
         *
         * @param request DeleteDefenseResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDefenseResourceGroupResponse
         */
        public DeleteDefenseResourceGroupResponse DeleteDefenseResourceGroupWithOptions(DeleteDefenseResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDefenseResourceGroup",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDefenseResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a protected object group.
         *
         * @param request DeleteDefenseResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDefenseResourceGroupResponse
         */
        public async Task<DeleteDefenseResourceGroupResponse> DeleteDefenseResourceGroupWithOptionsAsync(DeleteDefenseResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDefenseResourceGroup",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDefenseResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a protected object group.
         *
         * @param request DeleteDefenseResourceGroupRequest
         * @return DeleteDefenseResourceGroupResponse
         */
        public DeleteDefenseResourceGroupResponse DeleteDefenseResourceGroup(DeleteDefenseResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDefenseResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a protected object group.
         *
         * @param request DeleteDefenseResourceGroupRequest
         * @return DeleteDefenseResourceGroupResponse
         */
        public async Task<DeleteDefenseResourceGroupResponse> DeleteDefenseResourceGroupAsync(DeleteDefenseResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDefenseResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a protection rule.
         *
         * @param request DeleteDefenseRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDefenseRuleResponse
         */
        public DeleteDefenseRuleResponse DeleteDefenseRuleWithOptions(DeleteDefenseRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIds))
            {
                query["RuleIds"] = request.RuleIds;
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
                Action = "DeleteDefenseRule",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDefenseRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a protection rule.
         *
         * @param request DeleteDefenseRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDefenseRuleResponse
         */
        public async Task<DeleteDefenseRuleResponse> DeleteDefenseRuleWithOptionsAsync(DeleteDefenseRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIds))
            {
                query["RuleIds"] = request.RuleIds;
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
                Action = "DeleteDefenseRule",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDefenseRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a protection rule.
         *
         * @param request DeleteDefenseRuleRequest
         * @return DeleteDefenseRuleResponse
         */
        public DeleteDefenseRuleResponse DeleteDefenseRule(DeleteDefenseRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDefenseRuleWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a protection rule.
         *
         * @param request DeleteDefenseRuleRequest
         * @return DeleteDefenseRuleResponse
         */
        public async Task<DeleteDefenseRuleResponse> DeleteDefenseRuleAsync(DeleteDefenseRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDefenseRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a protection rule template.
         *
         * @param request DeleteDefenseTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDefenseTemplateResponse
         */
        public DeleteDefenseTemplateResponse DeleteDefenseTemplateWithOptions(DeleteDefenseTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DeleteDefenseTemplate",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDefenseTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a protection rule template.
         *
         * @param request DeleteDefenseTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDefenseTemplateResponse
         */
        public async Task<DeleteDefenseTemplateResponse> DeleteDefenseTemplateWithOptionsAsync(DeleteDefenseTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DeleteDefenseTemplate",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDefenseTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a protection rule template.
         *
         * @param request DeleteDefenseTemplateRequest
         * @return DeleteDefenseTemplateResponse
         */
        public DeleteDefenseTemplateResponse DeleteDefenseTemplate(DeleteDefenseTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDefenseTemplateWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a protection rule template.
         *
         * @param request DeleteDefenseTemplateRequest
         * @return DeleteDefenseTemplateResponse
         */
        public async Task<DeleteDefenseTemplateResponse> DeleteDefenseTemplateAsync(DeleteDefenseTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDefenseTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a domain name that is added to Web Application Firewall (WAF).
         *
         * @param request DeleteDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomainWithOptions(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteDomain",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a domain name that is added to Web Application Firewall (WAF).
         *
         * @param request DeleteDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteDomain",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a domain name that is added to Web Application Firewall (WAF).
         *
         * @param request DeleteDomainRequest
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a domain name that is added to Web Application Firewall (WAF).
         *
         * @param request DeleteDomainRequest
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an IP address blacklist for major event protection.
         *
         * @param request DeleteMajorProtectionBlackIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMajorProtectionBlackIpResponse
         */
        public DeleteMajorProtectionBlackIpResponse DeleteMajorProtectionBlackIpWithOptions(DeleteMajorProtectionBlackIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpList))
            {
                query["IpList"] = request.IpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "DeleteMajorProtectionBlackIp",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMajorProtectionBlackIpResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an IP address blacklist for major event protection.
         *
         * @param request DeleteMajorProtectionBlackIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMajorProtectionBlackIpResponse
         */
        public async Task<DeleteMajorProtectionBlackIpResponse> DeleteMajorProtectionBlackIpWithOptionsAsync(DeleteMajorProtectionBlackIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpList))
            {
                query["IpList"] = request.IpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "DeleteMajorProtectionBlackIp",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMajorProtectionBlackIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an IP address blacklist for major event protection.
         *
         * @param request DeleteMajorProtectionBlackIpRequest
         * @return DeleteMajorProtectionBlackIpResponse
         */
        public DeleteMajorProtectionBlackIpResponse DeleteMajorProtectionBlackIp(DeleteMajorProtectionBlackIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMajorProtectionBlackIpWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an IP address blacklist for major event protection.
         *
         * @param request DeleteMajorProtectionBlackIpRequest
         * @return DeleteMajorProtectionBlackIpResponse
         */
        public async Task<DeleteMajorProtectionBlackIpResponse> DeleteMajorProtectionBlackIpAsync(DeleteMajorProtectionBlackIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMajorProtectionBlackIpWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes the members that are added for multi-account management in Web Application Firewall (WAF).
         *
         * @param request DeleteMemberAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMemberAccountResponse
         */
        public DeleteMemberAccountResponse DeleteMemberAccountWithOptions(DeleteMemberAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccountId))
            {
                query["MemberAccountId"] = request.MemberAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemberAccount",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemberAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes the members that are added for multi-account management in Web Application Firewall (WAF).
         *
         * @param request DeleteMemberAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteMemberAccountResponse
         */
        public async Task<DeleteMemberAccountResponse> DeleteMemberAccountWithOptionsAsync(DeleteMemberAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccountId))
            {
                query["MemberAccountId"] = request.MemberAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMemberAccount",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMemberAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes the members that are added for multi-account management in Web Application Firewall (WAF).
         *
         * @param request DeleteMemberAccountRequest
         * @return DeleteMemberAccountResponse
         */
        public DeleteMemberAccountResponse DeleteMemberAccount(DeleteMemberAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMemberAccountWithOptions(request, runtime);
        }

        /**
         * @summary Removes the members that are added for multi-account management in Web Application Firewall (WAF).
         *
         * @param request DeleteMemberAccountRequest
         * @return DeleteMemberAccountResponse
         */
        public async Task<DeleteMemberAccountResponse> DeleteMemberAccountAsync(DeleteMemberAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMemberAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether an Alibaba Cloud account is the delegated administrator account of a Web Application Firewall (WAF) instance.
         *
         * @param request DescribeAccountDelegatedStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountDelegatedStatusResponse
         */
        public DescribeAccountDelegatedStatusResponse DescribeAccountDelegatedStatusWithOptions(DescribeAccountDelegatedStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccountDelegatedStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountDelegatedStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether an Alibaba Cloud account is the delegated administrator account of a Web Application Firewall (WAF) instance.
         *
         * @param request DescribeAccountDelegatedStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountDelegatedStatusResponse
         */
        public async Task<DescribeAccountDelegatedStatusResponse> DescribeAccountDelegatedStatusWithOptionsAsync(DescribeAccountDelegatedStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccountDelegatedStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAccountDelegatedStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether an Alibaba Cloud account is the delegated administrator account of a Web Application Firewall (WAF) instance.
         *
         * @param request DescribeAccountDelegatedStatusRequest
         * @return DescribeAccountDelegatedStatusResponse
         */
        public DescribeAccountDelegatedStatusResponse DescribeAccountDelegatedStatus(DescribeAccountDelegatedStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountDelegatedStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether an Alibaba Cloud account is the delegated administrator account of a Web Application Firewall (WAF) instance.
         *
         * @param request DescribeAccountDelegatedStatusRequest
         * @return DescribeAccountDelegatedStatusResponse
         */
        public async Task<DescribeAccountDelegatedStatusResponse> DescribeAccountDelegatedStatusAsync(DescribeAccountDelegatedStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountDelegatedStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询API安全风险站点统计
         *
         * @param request DescribeApisecAbnormalDomainStatisticRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecAbnormalDomainStatisticResponse
         */
        public DescribeApisecAbnormalDomainStatisticResponse DescribeApisecAbnormalDomainStatisticWithOptions(DescribeApisecAbnormalDomainStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderWay))
            {
                query["OrderWay"] = request.OrderWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeApisecAbnormalDomainStatistic",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecAbnormalDomainStatisticResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询API安全风险站点统计
         *
         * @param request DescribeApisecAbnormalDomainStatisticRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecAbnormalDomainStatisticResponse
         */
        public async Task<DescribeApisecAbnormalDomainStatisticResponse> DescribeApisecAbnormalDomainStatisticWithOptionsAsync(DescribeApisecAbnormalDomainStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderWay))
            {
                query["OrderWay"] = request.OrderWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeApisecAbnormalDomainStatistic",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecAbnormalDomainStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询API安全风险站点统计
         *
         * @param request DescribeApisecAbnormalDomainStatisticRequest
         * @return DescribeApisecAbnormalDomainStatisticResponse
         */
        public DescribeApisecAbnormalDomainStatisticResponse DescribeApisecAbnormalDomainStatistic(DescribeApisecAbnormalDomainStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApisecAbnormalDomainStatisticWithOptions(request, runtime);
        }

        /**
         * @summary 查询API安全风险站点统计
         *
         * @param request DescribeApisecAbnormalDomainStatisticRequest
         * @return DescribeApisecAbnormalDomainStatisticResponse
         */
        public async Task<DescribeApisecAbnormalDomainStatisticResponse> DescribeApisecAbnormalDomainStatisticAsync(DescribeApisecAbnormalDomainStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApisecAbnormalDomainStatisticWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询API安全资产趋势图
         *
         * @param request DescribeApisecAssetTrendRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecAssetTrendResponse
         */
        public DescribeApisecAssetTrendResponse DescribeApisecAssetTrendWithOptions(DescribeApisecAssetTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeApisecAssetTrend",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecAssetTrendResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询API安全资产趋势图
         *
         * @param request DescribeApisecAssetTrendRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecAssetTrendResponse
         */
        public async Task<DescribeApisecAssetTrendResponse> DescribeApisecAssetTrendWithOptionsAsync(DescribeApisecAssetTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeApisecAssetTrend",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecAssetTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询API安全资产趋势图
         *
         * @param request DescribeApisecAssetTrendRequest
         * @return DescribeApisecAssetTrendResponse
         */
        public DescribeApisecAssetTrendResponse DescribeApisecAssetTrend(DescribeApisecAssetTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApisecAssetTrendWithOptions(request, runtime);
        }

        /**
         * @summary 查询API安全资产趋势图
         *
         * @param request DescribeApisecAssetTrendRequest
         * @return DescribeApisecAssetTrendResponse
         */
        public async Task<DescribeApisecAssetTrendResponse> DescribeApisecAssetTrendAsync(DescribeApisecAssetTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApisecAssetTrendWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询API安全事件站点统计
         *
         * @param request DescribeApisecEventDomainStatisticRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecEventDomainStatisticResponse
         */
        public DescribeApisecEventDomainStatisticResponse DescribeApisecEventDomainStatisticWithOptions(DescribeApisecEventDomainStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderWay))
            {
                query["OrderWay"] = request.OrderWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeApisecEventDomainStatistic",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecEventDomainStatisticResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询API安全事件站点统计
         *
         * @param request DescribeApisecEventDomainStatisticRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecEventDomainStatisticResponse
         */
        public async Task<DescribeApisecEventDomainStatisticResponse> DescribeApisecEventDomainStatisticWithOptionsAsync(DescribeApisecEventDomainStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderWay))
            {
                query["OrderWay"] = request.OrderWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeApisecEventDomainStatistic",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecEventDomainStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询API安全事件站点统计
         *
         * @param request DescribeApisecEventDomainStatisticRequest
         * @return DescribeApisecEventDomainStatisticResponse
         */
        public DescribeApisecEventDomainStatisticResponse DescribeApisecEventDomainStatistic(DescribeApisecEventDomainStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApisecEventDomainStatisticWithOptions(request, runtime);
        }

        /**
         * @summary 查询API安全事件站点统计
         *
         * @param request DescribeApisecEventDomainStatisticRequest
         * @return DescribeApisecEventDomainStatisticResponse
         */
        public async Task<DescribeApisecEventDomainStatisticResponse> DescribeApisecEventDomainStatisticAsync(DescribeApisecEventDomainStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApisecEventDomainStatisticWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the configurations of API security log subscription.
         *
         * @param request DescribeApisecLogDeliveriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecLogDeliveriesResponse
         */
        public DescribeApisecLogDeliveriesResponse DescribeApisecLogDeliveriesWithOptions(DescribeApisecLogDeliveriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApisecLogDeliveries",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecLogDeliveriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the configurations of API security log subscription.
         *
         * @param request DescribeApisecLogDeliveriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecLogDeliveriesResponse
         */
        public async Task<DescribeApisecLogDeliveriesResponse> DescribeApisecLogDeliveriesWithOptionsAsync(DescribeApisecLogDeliveriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApisecLogDeliveries",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecLogDeliveriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the configurations of API security log subscription.
         *
         * @param request DescribeApisecLogDeliveriesRequest
         * @return DescribeApisecLogDeliveriesResponse
         */
        public DescribeApisecLogDeliveriesResponse DescribeApisecLogDeliveries(DescribeApisecLogDeliveriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApisecLogDeliveriesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the configurations of API security log subscription.
         *
         * @param request DescribeApisecLogDeliveriesRequest
         * @return DescribeApisecLogDeliveriesResponse
         */
        public async Task<DescribeApisecLogDeliveriesResponse> DescribeApisecLogDeliveriesAsync(DescribeApisecLogDeliveriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApisecLogDeliveriesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询API安全敏感数据类型统计
         *
         * @param request DescribeApisecSensitiveDomainStatisticRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecSensitiveDomainStatisticResponse
         */
        public DescribeApisecSensitiveDomainStatisticResponse DescribeApisecSensitiveDomainStatisticWithOptions(DescribeApisecSensitiveDomainStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderWay))
            {
                query["OrderWay"] = request.OrderWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeApisecSensitiveDomainStatistic",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecSensitiveDomainStatisticResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询API安全敏感数据类型统计
         *
         * @param request DescribeApisecSensitiveDomainStatisticRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecSensitiveDomainStatisticResponse
         */
        public async Task<DescribeApisecSensitiveDomainStatisticResponse> DescribeApisecSensitiveDomainStatisticWithOptionsAsync(DescribeApisecSensitiveDomainStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderWay))
            {
                query["OrderWay"] = request.OrderWay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeApisecSensitiveDomainStatistic",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecSensitiveDomainStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询API安全敏感数据类型统计
         *
         * @param request DescribeApisecSensitiveDomainStatisticRequest
         * @return DescribeApisecSensitiveDomainStatisticResponse
         */
        public DescribeApisecSensitiveDomainStatisticResponse DescribeApisecSensitiveDomainStatistic(DescribeApisecSensitiveDomainStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApisecSensitiveDomainStatisticWithOptions(request, runtime);
        }

        /**
         * @summary 查询API安全敏感数据类型统计
         *
         * @param request DescribeApisecSensitiveDomainStatisticRequest
         * @return DescribeApisecSensitiveDomainStatisticResponse
         */
        public async Task<DescribeApisecSensitiveDomainStatisticResponse> DescribeApisecSensitiveDomainStatisticAsync(DescribeApisecSensitiveDomainStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApisecSensitiveDomainStatisticWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the Logstores whose names start with apisec- in Simple Log Service.
         *
         * @param request DescribeApisecSlsLogStoresRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecSlsLogStoresResponse
         */
        public DescribeApisecSlsLogStoresResponse DescribeApisecSlsLogStoresWithOptions(DescribeApisecSlsLogStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                query["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApisecSlsLogStores",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecSlsLogStoresResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the Logstores whose names start with apisec- in Simple Log Service.
         *
         * @param request DescribeApisecSlsLogStoresRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecSlsLogStoresResponse
         */
        public async Task<DescribeApisecSlsLogStoresResponse> DescribeApisecSlsLogStoresWithOptionsAsync(DescribeApisecSlsLogStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                query["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApisecSlsLogStores",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecSlsLogStoresResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the Logstores whose names start with apisec- in Simple Log Service.
         *
         * @param request DescribeApisecSlsLogStoresRequest
         * @return DescribeApisecSlsLogStoresResponse
         */
        public DescribeApisecSlsLogStoresResponse DescribeApisecSlsLogStores(DescribeApisecSlsLogStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApisecSlsLogStoresWithOptions(request, runtime);
        }

        /**
         * @summary Queries the Logstores whose names start with apisec- in Simple Log Service.
         *
         * @param request DescribeApisecSlsLogStoresRequest
         * @return DescribeApisecSlsLogStoresResponse
         */
        public async Task<DescribeApisecSlsLogStoresResponse> DescribeApisecSlsLogStoresAsync(DescribeApisecSlsLogStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApisecSlsLogStoresWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the projects whose names start with apisec- in Simple Log Service.
         *
         * @param request DescribeApisecSlsProjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecSlsProjectsResponse
         */
        public DescribeApisecSlsProjectsResponse DescribeApisecSlsProjectsWithOptions(DescribeApisecSlsProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                query["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApisecSlsProjects",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecSlsProjectsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the projects whose names start with apisec- in Simple Log Service.
         *
         * @param request DescribeApisecSlsProjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApisecSlsProjectsResponse
         */
        public async Task<DescribeApisecSlsProjectsResponse> DescribeApisecSlsProjectsWithOptionsAsync(DescribeApisecSlsProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                query["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApisecSlsProjects",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApisecSlsProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the projects whose names start with apisec- in Simple Log Service.
         *
         * @param request DescribeApisecSlsProjectsRequest
         * @return DescribeApisecSlsProjectsResponse
         */
        public DescribeApisecSlsProjectsResponse DescribeApisecSlsProjects(DescribeApisecSlsProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApisecSlsProjectsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the projects whose names start with apisec- in Simple Log Service.
         *
         * @param request DescribeApisecSlsProjectsRequest
         * @return DescribeApisecSlsProjectsResponse
         */
        public async Task<DescribeApisecSlsProjectsResponse> DescribeApisecSlsProjectsAsync(DescribeApisecSlsProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApisecSlsProjectsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a certificate, such as the certificate name, expiration time, issuance time, and associated domain name.
         *
         * @param request DescribeCertDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCertDetailResponse
         */
        public DescribeCertDetailResponse DescribeCertDetailWithOptions(DescribeCertDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCertDetail",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a certificate, such as the certificate name, expiration time, issuance time, and associated domain name.
         *
         * @param request DescribeCertDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCertDetailResponse
         */
        public async Task<DescribeCertDetailResponse> DescribeCertDetailWithOptionsAsync(DescribeCertDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIdentifier))
            {
                query["CertIdentifier"] = request.CertIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCertDetail",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a certificate, such as the certificate name, expiration time, issuance time, and associated domain name.
         *
         * @param request DescribeCertDetailRequest
         * @return DescribeCertDetailResponse
         */
        public DescribeCertDetailResponse DescribeCertDetail(DescribeCertDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a certificate, such as the certificate name, expiration time, issuance time, and associated domain name.
         *
         * @param request DescribeCertDetailRequest
         * @return DescribeCertDetailResponse
         */
        public async Task<DescribeCertDetailResponse> DescribeCertDetailAsync(DescribeCertDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the certificates issued for your domain names that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeCertsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCertsResponse
         */
        public DescribeCertsResponse DescribeCertsWithOptions(DescribeCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCerts",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the certificates issued for your domain names that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeCertsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCertsResponse
         */
        public async Task<DescribeCertsResponse> DescribeCertsWithOptionsAsync(DescribeCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCerts",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCertsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the certificates issued for your domain names that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeCertsRequest
         * @return DescribeCertsResponse
         */
        public DescribeCertsResponse DescribeCerts(DescribeCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the certificates issued for your domain names that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeCertsRequest
         * @return DescribeCertsResponse
         */
        public async Task<DescribeCertsResponse> DescribeCertsAsync(DescribeCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries cloud service resources that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeCloudResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCloudResourcesResponse
         */
        public DescribeCloudResourcesResponse DescribeCloudResourcesWithOptions(DescribeCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                query["OwnerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDomain))
            {
                query["ResourceDomain"] = request.ResourceDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceFunction))
            {
                query["ResourceFunction"] = request.ResourceFunction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceId))
            {
                query["ResourceInstanceId"] = request.ResourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceName))
            {
                query["ResourceInstanceName"] = request.ResourceInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceProduct))
            {
                query["ResourceProduct"] = request.ResourceProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRouteName))
            {
                query["ResourceRouteName"] = request.ResourceRouteName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudResources",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries cloud service resources that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeCloudResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCloudResourcesResponse
         */
        public async Task<DescribeCloudResourcesResponse> DescribeCloudResourcesWithOptionsAsync(DescribeCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                query["OwnerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDomain))
            {
                query["ResourceDomain"] = request.ResourceDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceFunction))
            {
                query["ResourceFunction"] = request.ResourceFunction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceId))
            {
                query["ResourceInstanceId"] = request.ResourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceName))
            {
                query["ResourceInstanceName"] = request.ResourceInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceProduct))
            {
                query["ResourceProduct"] = request.ResourceProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRouteName))
            {
                query["ResourceRouteName"] = request.ResourceRouteName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudResources",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries cloud service resources that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeCloudResourcesRequest
         * @return DescribeCloudResourcesResponse
         */
        public DescribeCloudResourcesResponse DescribeCloudResources(DescribeCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Queries cloud service resources that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeCloudResourcesRequest
         * @return DescribeCloudResourcesResponse
         */
        public async Task<DescribeCloudResourcesResponse> DescribeCloudResourcesAsync(DescribeCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询Cname接入的数量
         *
         * @param request DescribeCnameCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCnameCountResponse
         */
        public DescribeCnameCountResponse DescribeCnameCountWithOptions(DescribeCnameCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCnameCount",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCnameCountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询Cname接入的数量
         *
         * @param request DescribeCnameCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCnameCountResponse
         */
        public async Task<DescribeCnameCountResponse> DescribeCnameCountWithOptionsAsync(DescribeCnameCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCnameCount",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCnameCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询Cname接入的数量
         *
         * @param request DescribeCnameCountRequest
         * @return DescribeCnameCountResponse
         */
        public DescribeCnameCountResponse DescribeCnameCount(DescribeCnameCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCnameCountWithOptions(request, runtime);
        }

        /**
         * @summary 查询Cname接入的数量
         *
         * @param request DescribeCnameCountRequest
         * @return DescribeCnameCountResponse
         */
        public async Task<DescribeCnameCountResponse> DescribeCnameCountAsync(DescribeCnameCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCnameCountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Checks whether DDoS attacks occur on specific domain names protected by a Web Application Firewall (WAF) instance.
         *
         * @param request DescribeDDoSStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDDoSStatusResponse
         */
        public DescribeDDoSStatusResponse DescribeDDoSStatusWithOptions(DescribeDDoSStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDDoSStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDDoSStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Checks whether DDoS attacks occur on specific domain names protected by a Web Application Firewall (WAF) instance.
         *
         * @param request DescribeDDoSStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDDoSStatusResponse
         */
        public async Task<DescribeDDoSStatusResponse> DescribeDDoSStatusWithOptionsAsync(DescribeDDoSStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDDoSStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDDoSStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Checks whether DDoS attacks occur on specific domain names protected by a Web Application Firewall (WAF) instance.
         *
         * @param request DescribeDDoSStatusRequest
         * @return DescribeDDoSStatusResponse
         */
        public DescribeDDoSStatusResponse DescribeDDoSStatus(DescribeDDoSStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDDoSStatusWithOptions(request, runtime);
        }

        /**
         * @summary Checks whether DDoS attacks occur on specific domain names protected by a Web Application Firewall (WAF) instance.
         *
         * @param request DescribeDDoSStatusRequest
         * @return DescribeDDoSStatusResponse
         */
        public async Task<DescribeDDoSStatusResponse> DescribeDDoSStatusAsync(DescribeDDoSStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDDoSStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a protected object.
         *
         * @param request DescribeDefenseResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourceResponse
         */
        public DescribeDefenseResourceResponse DescribeDefenseResourceWithOptions(DescribeDefenseResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseResource",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a protected object.
         *
         * @param request DescribeDefenseResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourceResponse
         */
        public async Task<DescribeDefenseResourceResponse> DescribeDefenseResourceWithOptionsAsync(DescribeDefenseResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseResource",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a protected object.
         *
         * @param request DescribeDefenseResourceRequest
         * @return DescribeDefenseResourceResponse
         */
        public DescribeDefenseResourceResponse DescribeDefenseResource(DescribeDefenseResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseResourceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a protected object.
         *
         * @param request DescribeDefenseResourceRequest
         * @return DescribeDefenseResourceResponse
         */
        public async Task<DescribeDefenseResourceResponse> DescribeDefenseResourceAsync(DescribeDefenseResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a protected object group.
         *
         * @param request DescribeDefenseResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourceGroupResponse
         */
        public DescribeDefenseResourceGroupResponse DescribeDefenseResourceGroupWithOptions(DescribeDefenseResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseResourceGroup",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a protected object group.
         *
         * @param request DescribeDefenseResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourceGroupResponse
         */
        public async Task<DescribeDefenseResourceGroupResponse> DescribeDefenseResourceGroupWithOptionsAsync(DescribeDefenseResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseResourceGroup",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a protected object group.
         *
         * @param request DescribeDefenseResourceGroupRequest
         * @return DescribeDefenseResourceGroupResponse
         */
        public DescribeDefenseResourceGroupResponse DescribeDefenseResourceGroup(DescribeDefenseResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a protected object group.
         *
         * @param request DescribeDefenseResourceGroupRequest
         * @return DescribeDefenseResourceGroupResponse
         */
        public async Task<DescribeDefenseResourceGroupResponse> DescribeDefenseResourceGroupAsync(DescribeDefenseResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the names of protected object groups.
         *
         * @param request DescribeDefenseResourceGroupNamesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourceGroupNamesResponse
         */
        public DescribeDefenseResourceGroupNamesResponse DescribeDefenseResourceGroupNamesWithOptions(DescribeDefenseResourceGroupNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupNameLike))
            {
                query["GroupNameLike"] = request.GroupNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseResourceGroupNames",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourceGroupNamesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the names of protected object groups.
         *
         * @param request DescribeDefenseResourceGroupNamesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourceGroupNamesResponse
         */
        public async Task<DescribeDefenseResourceGroupNamesResponse> DescribeDefenseResourceGroupNamesWithOptionsAsync(DescribeDefenseResourceGroupNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupNameLike))
            {
                query["GroupNameLike"] = request.GroupNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseResourceGroupNames",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourceGroupNamesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the names of protected object groups.
         *
         * @param request DescribeDefenseResourceGroupNamesRequest
         * @return DescribeDefenseResourceGroupNamesResponse
         */
        public DescribeDefenseResourceGroupNamesResponse DescribeDefenseResourceGroupNames(DescribeDefenseResourceGroupNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseResourceGroupNamesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the names of protected object groups.
         *
         * @param request DescribeDefenseResourceGroupNamesRequest
         * @return DescribeDefenseResourceGroupNamesResponse
         */
        public async Task<DescribeDefenseResourceGroupNamesResponse> DescribeDefenseResourceGroupNamesAsync(DescribeDefenseResourceGroupNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseResourceGroupNamesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Performs a pagination query to retrieve the information about protected object groups.
         *
         * @param request DescribeDefenseResourceGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourceGroupsResponse
         */
        public DescribeDefenseResourceGroupsResponse DescribeDefenseResourceGroupsWithOptions(DescribeDefenseResourceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupNameLike))
            {
                query["GroupNameLike"] = request.GroupNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupNames))
            {
                query["GroupNames"] = request.GroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseResourceGroups",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourceGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Performs a pagination query to retrieve the information about protected object groups.
         *
         * @param request DescribeDefenseResourceGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourceGroupsResponse
         */
        public async Task<DescribeDefenseResourceGroupsResponse> DescribeDefenseResourceGroupsWithOptionsAsync(DescribeDefenseResourceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupNameLike))
            {
                query["GroupNameLike"] = request.GroupNameLike;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupNames))
            {
                query["GroupNames"] = request.GroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseResourceGroups",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourceGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Performs a pagination query to retrieve the information about protected object groups.
         *
         * @param request DescribeDefenseResourceGroupsRequest
         * @return DescribeDefenseResourceGroupsResponse
         */
        public DescribeDefenseResourceGroupsResponse DescribeDefenseResourceGroups(DescribeDefenseResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseResourceGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Performs a pagination query to retrieve the information about protected object groups.
         *
         * @param request DescribeDefenseResourceGroupsRequest
         * @return DescribeDefenseResourceGroupsResponse
         */
        public async Task<DescribeDefenseResourceGroupsResponse> DescribeDefenseResourceGroupsAsync(DescribeDefenseResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseResourceGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Performs a pagination query to retrieve the names of protected objects.
         *
         * @param request DescribeDefenseResourceNamesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourceNamesResponse
         */
        public DescribeDefenseResourceNamesResponse DescribeDefenseResourceNamesWithOptions(DescribeDefenseResourceNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseResourceNames",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourceNamesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Performs a pagination query to retrieve the names of protected objects.
         *
         * @param request DescribeDefenseResourceNamesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourceNamesResponse
         */
        public async Task<DescribeDefenseResourceNamesResponse> DescribeDefenseResourceNamesWithOptionsAsync(DescribeDefenseResourceNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseResourceNames",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourceNamesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Performs a pagination query to retrieve the names of protected objects.
         *
         * @param request DescribeDefenseResourceNamesRequest
         * @return DescribeDefenseResourceNamesResponse
         */
        public DescribeDefenseResourceNamesResponse DescribeDefenseResourceNames(DescribeDefenseResourceNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseResourceNamesWithOptions(request, runtime);
        }

        /**
         * @summary Performs a pagination query to retrieve the names of protected objects.
         *
         * @param request DescribeDefenseResourceNamesRequest
         * @return DescribeDefenseResourceNamesResponse
         */
        public async Task<DescribeDefenseResourceNamesResponse> DescribeDefenseResourceNamesAsync(DescribeDefenseResourceNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseResourceNamesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the protection templates that are associated with a protected object or protected object group.
         *
         * @param request DescribeDefenseResourceTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourceTemplatesResponse
         */
        public DescribeDefenseResourceTemplatesResponse DescribeDefenseResourceTemplatesWithOptions(DescribeDefenseResourceTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseResourceTemplates",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourceTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the protection templates that are associated with a protected object or protected object group.
         *
         * @param request DescribeDefenseResourceTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourceTemplatesResponse
         */
        public async Task<DescribeDefenseResourceTemplatesResponse> DescribeDefenseResourceTemplatesWithOptionsAsync(DescribeDefenseResourceTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseResourceTemplates",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourceTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the protection templates that are associated with a protected object or protected object group.
         *
         * @param request DescribeDefenseResourceTemplatesRequest
         * @return DescribeDefenseResourceTemplatesResponse
         */
        public DescribeDefenseResourceTemplatesResponse DescribeDefenseResourceTemplates(DescribeDefenseResourceTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseResourceTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the protection templates that are associated with a protected object or protected object group.
         *
         * @param request DescribeDefenseResourceTemplatesRequest
         * @return DescribeDefenseResourceTemplatesResponse
         */
        public async Task<DescribeDefenseResourceTemplatesResponse> DescribeDefenseResourceTemplatesAsync(DescribeDefenseResourceTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseResourceTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries protected objects by page.
         *
         * @param request DescribeDefenseResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourcesResponse
         */
        public DescribeDefenseResourcesResponse DescribeDefenseResourcesWithOptions(DescribeDefenseResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeDefenseResources",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries protected objects by page.
         *
         * @param request DescribeDefenseResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseResourcesResponse
         */
        public async Task<DescribeDefenseResourcesResponse> DescribeDefenseResourcesWithOptionsAsync(DescribeDefenseResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeDefenseResources",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries protected objects by page.
         *
         * @param request DescribeDefenseResourcesRequest
         * @return DescribeDefenseResourcesResponse
         */
        public DescribeDefenseResourcesResponse DescribeDefenseResources(DescribeDefenseResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Queries protected objects by page.
         *
         * @param request DescribeDefenseResourcesRequest
         * @return DescribeDefenseResourcesResponse
         */
        public async Task<DescribeDefenseResourcesResponse> DescribeDefenseResourcesAsync(DescribeDefenseResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a protection rule.
         *
         * @param request DescribeDefenseRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseRuleResponse
         */
        public DescribeDefenseRuleResponse DescribeDefenseRuleWithOptions(DescribeDefenseRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "DescribeDefenseRule",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a protection rule.
         *
         * @param request DescribeDefenseRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseRuleResponse
         */
        public async Task<DescribeDefenseRuleResponse> DescribeDefenseRuleWithOptionsAsync(DescribeDefenseRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "DescribeDefenseRule",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a protection rule.
         *
         * @param request DescribeDefenseRuleRequest
         * @return DescribeDefenseRuleResponse
         */
        public DescribeDefenseRuleResponse DescribeDefenseRule(DescribeDefenseRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseRuleWithOptions(request, runtime);
        }

        /**
         * @summary Queries a protection rule.
         *
         * @param request DescribeDefenseRuleRequest
         * @return DescribeDefenseRuleResponse
         */
        public async Task<DescribeDefenseRuleResponse> DescribeDefenseRuleAsync(DescribeDefenseRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries protection rules by page.
         *
         * @param request DescribeDefenseRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseRulesResponse
         */
        public DescribeDefenseRulesResponse DescribeDefenseRulesWithOptions(DescribeDefenseRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseRules",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries protection rules by page.
         *
         * @param request DescribeDefenseRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseRulesResponse
         */
        public async Task<DescribeDefenseRulesResponse> DescribeDefenseRulesWithOptionsAsync(DescribeDefenseRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDefenseRules",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries protection rules by page.
         *
         * @param request DescribeDefenseRulesRequest
         * @return DescribeDefenseRulesResponse
         */
        public DescribeDefenseRulesResponse DescribeDefenseRules(DescribeDefenseRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseRulesWithOptions(request, runtime);
        }

        /**
         * @summary Queries protection rules by page.
         *
         * @param request DescribeDefenseRulesRequest
         * @return DescribeDefenseRulesResponse
         */
        public async Task<DescribeDefenseRulesResponse> DescribeDefenseRulesAsync(DescribeDefenseRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a protection rule template.
         *
         * @param request DescribeDefenseTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseTemplateResponse
         */
        public DescribeDefenseTemplateResponse DescribeDefenseTemplateWithOptions(DescribeDefenseTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeDefenseTemplate",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a protection rule template.
         *
         * @param request DescribeDefenseTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseTemplateResponse
         */
        public async Task<DescribeDefenseTemplateResponse> DescribeDefenseTemplateWithOptionsAsync(DescribeDefenseTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeDefenseTemplate",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a protection rule template.
         *
         * @param request DescribeDefenseTemplateRequest
         * @return DescribeDefenseTemplateResponse
         */
        public DescribeDefenseTemplateResponse DescribeDefenseTemplate(DescribeDefenseTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseTemplateWithOptions(request, runtime);
        }

        /**
         * @summary Queries a protection rule template.
         *
         * @param request DescribeDefenseTemplateRequest
         * @return DescribeDefenseTemplateResponse
         */
        public async Task<DescribeDefenseTemplateResponse> DescribeDefenseTemplateAsync(DescribeDefenseTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the names of protected object groups for which a protection template can take effect.
         *
         * @param request DescribeDefenseTemplateValidGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseTemplateValidGroupsResponse
         */
        public DescribeDefenseTemplateValidGroupsResponse DescribeDefenseTemplateValidGroupsWithOptions(DescribeDefenseTemplateValidGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseScene))
            {
                query["DefenseScene"] = request.DefenseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeDefenseTemplateValidGroups",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseTemplateValidGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the names of protected object groups for which a protection template can take effect.
         *
         * @param request DescribeDefenseTemplateValidGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseTemplateValidGroupsResponse
         */
        public async Task<DescribeDefenseTemplateValidGroupsResponse> DescribeDefenseTemplateValidGroupsWithOptionsAsync(DescribeDefenseTemplateValidGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseScene))
            {
                query["DefenseScene"] = request.DefenseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeDefenseTemplateValidGroups",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseTemplateValidGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the names of protected object groups for which a protection template can take effect.
         *
         * @param request DescribeDefenseTemplateValidGroupsRequest
         * @return DescribeDefenseTemplateValidGroupsResponse
         */
        public DescribeDefenseTemplateValidGroupsResponse DescribeDefenseTemplateValidGroups(DescribeDefenseTemplateValidGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseTemplateValidGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the names of protected object groups for which a protection template can take effect.
         *
         * @param request DescribeDefenseTemplateValidGroupsRequest
         * @return DescribeDefenseTemplateValidGroupsResponse
         */
        public async Task<DescribeDefenseTemplateValidGroupsResponse> DescribeDefenseTemplateValidGroupsAsync(DescribeDefenseTemplateValidGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseTemplateValidGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Performs a paging query to retrieve protection templates.
         *
         * @param request DescribeDefenseTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseTemplatesResponse
         */
        public DescribeDefenseTemplatesResponse DescribeDefenseTemplatesWithOptions(DescribeDefenseTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseScene))
            {
                query["DefenseScene"] = request.DefenseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseSubScene))
            {
                query["DefenseSubScene"] = request.DefenseSubScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "DescribeDefenseTemplates",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Performs a paging query to retrieve protection templates.
         *
         * @param request DescribeDefenseTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDefenseTemplatesResponse
         */
        public async Task<DescribeDefenseTemplatesResponse> DescribeDefenseTemplatesWithOptionsAsync(DescribeDefenseTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseScene))
            {
                query["DefenseScene"] = request.DefenseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseSubScene))
            {
                query["DefenseSubScene"] = request.DefenseSubScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
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
                Action = "DescribeDefenseTemplates",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDefenseTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Performs a paging query to retrieve protection templates.
         *
         * @param request DescribeDefenseTemplatesRequest
         * @return DescribeDefenseTemplatesResponse
         */
        public DescribeDefenseTemplatesResponse DescribeDefenseTemplates(DescribeDefenseTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDefenseTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary Performs a paging query to retrieve protection templates.
         *
         * @param request DescribeDefenseTemplatesRequest
         * @return DescribeDefenseTemplatesResponse
         */
        public async Task<DescribeDefenseTemplatesResponse> DescribeDefenseTemplatesAsync(DescribeDefenseTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDefenseTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Checks whether the Domain Name System (DNS) settings of a domain name are properly configured.
         *
         * @param request DescribeDomainDNSRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainDNSRecordResponse
         */
        public DescribeDomainDNSRecordResponse DescribeDomainDNSRecordWithOptions(DescribeDomainDNSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainDNSRecord",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainDNSRecordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Checks whether the Domain Name System (DNS) settings of a domain name are properly configured.
         *
         * @param request DescribeDomainDNSRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainDNSRecordResponse
         */
        public async Task<DescribeDomainDNSRecordResponse> DescribeDomainDNSRecordWithOptionsAsync(DescribeDomainDNSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainDNSRecord",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainDNSRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Checks whether the Domain Name System (DNS) settings of a domain name are properly configured.
         *
         * @param request DescribeDomainDNSRecordRequest
         * @return DescribeDomainDNSRecordResponse
         */
        public DescribeDomainDNSRecordResponse DescribeDomainDNSRecord(DescribeDomainDNSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainDNSRecordWithOptions(request, runtime);
        }

        /**
         * @summary Checks whether the Domain Name System (DNS) settings of a domain name are properly configured.
         *
         * @param request DescribeDomainDNSRecordRequest
         * @return DescribeDomainDNSRecordResponse
         */
        public async Task<DescribeDomainDNSRecordResponse> DescribeDomainDNSRecordAsync(DescribeDomainDNSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainDNSRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a domain name that is added to Web Application Firewall (WAF).
         *
         * @param request DescribeDomainDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainDetailResponse
         */
        public DescribeDomainDetailResponse DescribeDomainDetailWithOptions(DescribeDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeDomainDetail",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a domain name that is added to Web Application Firewall (WAF).
         *
         * @param request DescribeDomainDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainDetailResponse
         */
        public async Task<DescribeDomainDetailResponse> DescribeDomainDetailWithOptionsAsync(DescribeDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeDomainDetail",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a domain name that is added to Web Application Firewall (WAF).
         *
         * @param request DescribeDomainDetailRequest
         * @return DescribeDomainDetailResponse
         */
        public DescribeDomainDetailResponse DescribeDomainDetail(DescribeDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a domain name that is added to Web Application Firewall (WAF).
         *
         * @param request DescribeDomainDetailRequest
         * @return DescribeDomainDetailResponse
         */
        public async Task<DescribeDomainDetailResponse> DescribeDomainDetailAsync(DescribeDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the domain names that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainsResponse
         */
        public DescribeDomainsResponse DescribeDomainsWithOptions(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backend))
            {
                query["Backend"] = request.Backend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeDomains",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the domain names that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainsResponse
         */
        public async Task<DescribeDomainsResponse> DescribeDomainsWithOptionsAsync(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backend))
            {
                query["Backend"] = request.Backend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "DescribeDomains",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the domain names that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeDomainsRequest
         * @return DescribeDomainsResponse
         */
        public DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the domain names that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeDomainsRequest
         * @return DescribeDomainsResponse
         */
        public async Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the traffic statistics of requests that are forwarded to Web Application Firewall (WAF).
         *
         * @param request DescribeFlowChartRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFlowChartResponse
         */
        public DescribeFlowChartResponse DescribeFlowChartWithOptions(DescribeFlowChartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowChart",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowChartResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the traffic statistics of requests that are forwarded to Web Application Firewall (WAF).
         *
         * @param request DescribeFlowChartRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFlowChartResponse
         */
        public async Task<DescribeFlowChartResponse> DescribeFlowChartWithOptionsAsync(DescribeFlowChartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowChart",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowChartResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the traffic statistics of requests that are forwarded to Web Application Firewall (WAF).
         *
         * @param request DescribeFlowChartRequest
         * @return DescribeFlowChartResponse
         */
        public DescribeFlowChartResponse DescribeFlowChart(DescribeFlowChartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowChartWithOptions(request, runtime);
        }

        /**
         * @summary Queries the traffic statistics of requests that are forwarded to Web Application Firewall (WAF).
         *
         * @param request DescribeFlowChartRequest
         * @return DescribeFlowChartResponse
         */
        public async Task<DescribeFlowChartResponse> DescribeFlowChartAsync(DescribeFlowChartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowChartWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the top 10 protected objects that receive requests.
         *
         * @param request DescribeFlowTopResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFlowTopResourceResponse
         */
        public DescribeFlowTopResourceResponse DescribeFlowTopResourceWithOptions(DescribeFlowTopResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowTopResource",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowTopResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 protected objects that receive requests.
         *
         * @param request DescribeFlowTopResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFlowTopResourceResponse
         */
        public async Task<DescribeFlowTopResourceResponse> DescribeFlowTopResourceWithOptionsAsync(DescribeFlowTopResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowTopResource",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowTopResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 protected objects that receive requests.
         *
         * @param request DescribeFlowTopResourceRequest
         * @return DescribeFlowTopResourceResponse
         */
        public DescribeFlowTopResourceResponse DescribeFlowTopResource(DescribeFlowTopResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowTopResourceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the top 10 protected objects that receive requests.
         *
         * @param request DescribeFlowTopResourceRequest
         * @return DescribeFlowTopResourceResponse
         */
        public async Task<DescribeFlowTopResourceResponse> DescribeFlowTopResourceAsync(DescribeFlowTopResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowTopResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the top 10 URLs that are used to initiate requests.
         *
         * @param request DescribeFlowTopUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFlowTopUrlResponse
         */
        public DescribeFlowTopUrlResponse DescribeFlowTopUrlWithOptions(DescribeFlowTopUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowTopUrl",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowTopUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 URLs that are used to initiate requests.
         *
         * @param request DescribeFlowTopUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFlowTopUrlResponse
         */
        public async Task<DescribeFlowTopUrlResponse> DescribeFlowTopUrlWithOptionsAsync(DescribeFlowTopUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowTopUrl",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowTopUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 URLs that are used to initiate requests.
         *
         * @param request DescribeFlowTopUrlRequest
         * @return DescribeFlowTopUrlResponse
         */
        public DescribeFlowTopUrlResponse DescribeFlowTopUrl(DescribeFlowTopUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowTopUrlWithOptions(request, runtime);
        }

        /**
         * @summary Queries the top 10 URLs that are used to initiate requests.
         *
         * @param request DescribeFlowTopUrlRequest
         * @return DescribeFlowTopUrlResponse
         */
        public async Task<DescribeFlowTopUrlResponse> DescribeFlowTopUrlAsync(DescribeFlowTopUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowTopUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the hybrid cloud node groups that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeHybridCloudGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHybridCloudGroupsResponse
         */
        public DescribeHybridCloudGroupsResponse DescribeHybridCloudGroupsWithOptions(DescribeHybridCloudGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterProxyType))
            {
                query["ClusterProxyType"] = request.ClusterProxyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridCloudGroups",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridCloudGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the hybrid cloud node groups that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeHybridCloudGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHybridCloudGroupsResponse
         */
        public async Task<DescribeHybridCloudGroupsResponse> DescribeHybridCloudGroupsWithOptionsAsync(DescribeHybridCloudGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterProxyType))
            {
                query["ClusterProxyType"] = request.ClusterProxyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridCloudGroups",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridCloudGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the hybrid cloud node groups that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeHybridCloudGroupsRequest
         * @return DescribeHybridCloudGroupsResponse
         */
        public DescribeHybridCloudGroupsResponse DescribeHybridCloudGroups(DescribeHybridCloudGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHybridCloudGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the hybrid cloud node groups that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeHybridCloudGroupsRequest
         * @return DescribeHybridCloudGroupsResponse
         */
        public async Task<DescribeHybridCloudGroupsResponse> DescribeHybridCloudGroupsAsync(DescribeHybridCloudGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHybridCloudGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the domain names that are added to a Web Application Firewall (WAF) instance in hybrid cloud mode.
         *
         * @param request DescribeHybridCloudResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHybridCloudResourcesResponse
         */
        public DescribeHybridCloudResourcesResponse DescribeHybridCloudResourcesWithOptions(DescribeHybridCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backend))
            {
                query["Backend"] = request.Backend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameEnabled))
            {
                query["CnameEnabled"] = request.CnameEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridCloudResources",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridCloudResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the domain names that are added to a Web Application Firewall (WAF) instance in hybrid cloud mode.
         *
         * @param request DescribeHybridCloudResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHybridCloudResourcesResponse
         */
        public async Task<DescribeHybridCloudResourcesResponse> DescribeHybridCloudResourcesWithOptionsAsync(DescribeHybridCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backend))
            {
                query["Backend"] = request.Backend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameEnabled))
            {
                query["CnameEnabled"] = request.CnameEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridCloudResources",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridCloudResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the domain names that are added to a Web Application Firewall (WAF) instance in hybrid cloud mode.
         *
         * @param request DescribeHybridCloudResourcesRequest
         * @return DescribeHybridCloudResourcesResponse
         */
        public DescribeHybridCloudResourcesResponse DescribeHybridCloudResources(DescribeHybridCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHybridCloudResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the domain names that are added to a Web Application Firewall (WAF) instance in hybrid cloud mode.
         *
         * @param request DescribeHybridCloudResourcesRequest
         * @return DescribeHybridCloudResourcesResponse
         */
        public async Task<DescribeHybridCloudResourcesResponse> DescribeHybridCloudResourcesAsync(DescribeHybridCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHybridCloudResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the HTTP and HTTPS ports that you can use when you add a domain name to Web Application Firewall (WAF) in hybrid cloud mode.
         *
         * @param request DescribeHybridCloudUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHybridCloudUserResponse
         */
        public DescribeHybridCloudUserResponse DescribeHybridCloudUserWithOptions(DescribeHybridCloudUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridCloudUser",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridCloudUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the HTTP and HTTPS ports that you can use when you add a domain name to Web Application Firewall (WAF) in hybrid cloud mode.
         *
         * @param request DescribeHybridCloudUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHybridCloudUserResponse
         */
        public async Task<DescribeHybridCloudUserResponse> DescribeHybridCloudUserWithOptionsAsync(DescribeHybridCloudUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHybridCloudUser",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHybridCloudUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the HTTP and HTTPS ports that you can use when you add a domain name to Web Application Firewall (WAF) in hybrid cloud mode.
         *
         * @param request DescribeHybridCloudUserRequest
         * @return DescribeHybridCloudUserResponse
         */
        public DescribeHybridCloudUserResponse DescribeHybridCloudUser(DescribeHybridCloudUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHybridCloudUserWithOptions(request, runtime);
        }

        /**
         * @summary Queries the HTTP and HTTPS ports that you can use when you add a domain name to Web Application Firewall (WAF) in hybrid cloud mode.
         *
         * @param request DescribeHybridCloudUserRequest
         * @return DescribeHybridCloudUserResponse
         */
        public async Task<DescribeHybridCloudUserResponse> DescribeHybridCloudUserAsync(DescribeHybridCloudUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHybridCloudUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a Web Application Firewall (WAF) instance within the current Alibaba Cloud account.
         *
         * @param request DescribeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceResponse
         */
        public DescribeInstanceResponse DescribeInstanceWithOptions(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a Web Application Firewall (WAF) instance within the current Alibaba Cloud account.
         *
         * @param request DescribeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceResponse
         */
        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a Web Application Firewall (WAF) instance within the current Alibaba Cloud account.
         *
         * @param request DescribeInstanceRequest
         * @return DescribeInstanceResponse
         */
        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a Web Application Firewall (WAF) instance within the current Alibaba Cloud account.
         *
         * @param request DescribeInstanceRequest
         * @return DescribeInstanceResponse
         */
        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries IP addresses in an IP address blacklist for major event protection by page.
         *
         * @param request DescribeMajorProtectionBlackIpsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMajorProtectionBlackIpsResponse
         */
        public DescribeMajorProtectionBlackIpsResponse DescribeMajorProtectionBlackIpsWithOptions(DescribeMajorProtectionBlackIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpLike))
            {
                query["IpLike"] = request.IpLike;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "DescribeMajorProtectionBlackIps",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMajorProtectionBlackIpsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries IP addresses in an IP address blacklist for major event protection by page.
         *
         * @param request DescribeMajorProtectionBlackIpsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMajorProtectionBlackIpsResponse
         */
        public async Task<DescribeMajorProtectionBlackIpsResponse> DescribeMajorProtectionBlackIpsWithOptionsAsync(DescribeMajorProtectionBlackIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpLike))
            {
                query["IpLike"] = request.IpLike;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "DescribeMajorProtectionBlackIps",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMajorProtectionBlackIpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries IP addresses in an IP address blacklist for major event protection by page.
         *
         * @param request DescribeMajorProtectionBlackIpsRequest
         * @return DescribeMajorProtectionBlackIpsResponse
         */
        public DescribeMajorProtectionBlackIpsResponse DescribeMajorProtectionBlackIps(DescribeMajorProtectionBlackIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMajorProtectionBlackIpsWithOptions(request, runtime);
        }

        /**
         * @summary Queries IP addresses in an IP address blacklist for major event protection by page.
         *
         * @param request DescribeMajorProtectionBlackIpsRequest
         * @return DescribeMajorProtectionBlackIpsResponse
         */
        public async Task<DescribeMajorProtectionBlackIpsResponse> DescribeMajorProtectionBlackIpsAsync(DescribeMajorProtectionBlackIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMajorProtectionBlackIpsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries information about members.
         *
         * @param request DescribeMemberAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMemberAccountsResponse
         */
        public DescribeMemberAccountsResponse DescribeMemberAccountsWithOptions(DescribeMemberAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountStatus))
            {
                query["AccountStatus"] = request.AccountStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMemberAccounts",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMemberAccountsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries information about members.
         *
         * @param request DescribeMemberAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMemberAccountsResponse
         */
        public async Task<DescribeMemberAccountsResponse> DescribeMemberAccountsWithOptionsAsync(DescribeMemberAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountStatus))
            {
                query["AccountStatus"] = request.AccountStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMemberAccounts",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMemberAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries information about members.
         *
         * @param request DescribeMemberAccountsRequest
         * @return DescribeMemberAccountsResponse
         */
        public DescribeMemberAccountsResponse DescribeMemberAccounts(DescribeMemberAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMemberAccountsWithOptions(request, runtime);
        }

        /**
         * @summary Queries information about members.
         *
         * @param request DescribeMemberAccountsRequest
         * @return DescribeMemberAccountsResponse
         */
        public async Task<DescribeMemberAccountsResponse> DescribeMemberAccountsAsync(DescribeMemberAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMemberAccountsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取用户暂停防护状态
         *
         * @param request DescribePauseProtectionStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePauseProtectionStatusResponse
         */
        public DescribePauseProtectionStatusResponse DescribePauseProtectionStatusWithOptions(DescribePauseProtectionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePauseProtectionStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePauseProtectionStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取用户暂停防护状态
         *
         * @param request DescribePauseProtectionStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePauseProtectionStatusResponse
         */
        public async Task<DescribePauseProtectionStatusResponse> DescribePauseProtectionStatusWithOptionsAsync(DescribePauseProtectionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePauseProtectionStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePauseProtectionStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户暂停防护状态
         *
         * @param request DescribePauseProtectionStatusRequest
         * @return DescribePauseProtectionStatusResponse
         */
        public DescribePauseProtectionStatusResponse DescribePauseProtectionStatus(DescribePauseProtectionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePauseProtectionStatusWithOptions(request, runtime);
        }

        /**
         * @summary 获取用户暂停防护状态
         *
         * @param request DescribePauseProtectionStatusRequest
         * @return DescribePauseProtectionStatusResponse
         */
        public async Task<DescribePauseProtectionStatusResponse> DescribePauseProtectionStatusAsync(DescribePauseProtectionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePauseProtectionStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the queries per second (QPS) statistics of a WAF instance.
         *
         * @param request DescribePeakTrendRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePeakTrendResponse
         */
        public DescribePeakTrendResponse DescribePeakTrendWithOptions(DescribePeakTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePeakTrend",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePeakTrendResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the queries per second (QPS) statistics of a WAF instance.
         *
         * @param request DescribePeakTrendRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePeakTrendResponse
         */
        public async Task<DescribePeakTrendResponse> DescribePeakTrendWithOptionsAsync(DescribePeakTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePeakTrend",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePeakTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the queries per second (QPS) statistics of a WAF instance.
         *
         * @param request DescribePeakTrendRequest
         * @return DescribePeakTrendResponse
         */
        public DescribePeakTrendResponse DescribePeakTrend(DescribePeakTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePeakTrendWithOptions(request, runtime);
        }

        /**
         * @summary Queries the queries per second (QPS) statistics of a WAF instance.
         *
         * @param request DescribePeakTrendRequest
         * @return DescribePeakTrendResponse
         */
        public async Task<DescribePeakTrendResponse> DescribePeakTrendAsync(DescribePeakTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePeakTrendWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the cloud service instances to be added to Web Application Firewall (WAF) in transparent proxy mode.
         *
         * @param request DescribeProductInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProductInstancesResponse
         */
        public DescribeProductInstancesResponse DescribeProductInstancesWithOptions(DescribeProductInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                query["OwnerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceId))
            {
                query["ResourceInstanceId"] = request.ResourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceIp))
            {
                query["ResourceInstanceIp"] = request.ResourceInstanceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceName))
            {
                query["ResourceInstanceName"] = request.ResourceInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIp))
            {
                query["ResourceIp"] = request.ResourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceProduct))
            {
                query["ResourceProduct"] = request.ResourceProduct;
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
                Action = "DescribeProductInstances",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the cloud service instances to be added to Web Application Firewall (WAF) in transparent proxy mode.
         *
         * @param request DescribeProductInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProductInstancesResponse
         */
        public async Task<DescribeProductInstancesResponse> DescribeProductInstancesWithOptionsAsync(DescribeProductInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                query["OwnerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceId))
            {
                query["ResourceInstanceId"] = request.ResourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceIp))
            {
                query["ResourceInstanceIp"] = request.ResourceInstanceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceName))
            {
                query["ResourceInstanceName"] = request.ResourceInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIp))
            {
                query["ResourceIp"] = request.ResourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceProduct))
            {
                query["ResourceProduct"] = request.ResourceProduct;
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
                Action = "DescribeProductInstances",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProductInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the cloud service instances to be added to Web Application Firewall (WAF) in transparent proxy mode.
         *
         * @param request DescribeProductInstancesRequest
         * @return DescribeProductInstancesResponse
         */
        public DescribeProductInstancesResponse DescribeProductInstances(DescribeProductInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProductInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the cloud service instances to be added to Web Application Firewall (WAF) in transparent proxy mode.
         *
         * @param request DescribeProductInstancesRequest
         * @return DescribeProductInstancesResponse
         */
        public async Task<DescribeProductInstancesResponse> DescribeProductInstancesAsync(DescribeProductInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProductInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of domain names that are added to Web Application Firewall (WAF) and penalized for failing to obtain an Internet Content Provider (ICP) filing.
         *
         * @param request DescribePunishedDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePunishedDomainsResponse
         */
        public DescribePunishedDomainsResponse DescribePunishedDomainsWithOptions(DescribePunishedDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domains))
            {
                query["Domains"] = request.Domains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePunishedDomains",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePunishedDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of domain names that are added to Web Application Firewall (WAF) and penalized for failing to obtain an Internet Content Provider (ICP) filing.
         *
         * @param request DescribePunishedDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePunishedDomainsResponse
         */
        public async Task<DescribePunishedDomainsResponse> DescribePunishedDomainsWithOptionsAsync(DescribePunishedDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domains))
            {
                query["Domains"] = request.Domains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePunishedDomains",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePunishedDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of domain names that are added to Web Application Firewall (WAF) and penalized for failing to obtain an Internet Content Provider (ICP) filing.
         *
         * @param request DescribePunishedDomainsRequest
         * @return DescribePunishedDomainsResponse
         */
        public DescribePunishedDomainsResponse DescribePunishedDomains(DescribePunishedDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePunishedDomainsWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of domain names that are added to Web Application Firewall (WAF) and penalized for failing to obtain an Internet Content Provider (ICP) filing.
         *
         * @param request DescribePunishedDomainsRequest
         * @return DescribePunishedDomainsResponse
         */
        public async Task<DescribePunishedDomainsResponse> DescribePunishedDomainsAsync(DescribePunishedDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePunishedDomainsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the certificates that are used in cloud service instances. The certificates returned include the certificates within the delegated administrator account and the certificates within members to which specific instances belong. For example, the delegated administrator account has certificate 1, instance lb-xx-1 belongs to member B, and member B has certificate 2. If you specify instance lb-xx-1 in the request, certificate 1 and certificate 2 are returned.
         *
         * @param request DescribeResourceInstanceCertsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceInstanceCertsResponse
         */
        public DescribeResourceInstanceCertsResponse DescribeResourceInstanceCertsWithOptions(DescribeResourceInstanceCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceId))
            {
                query["ResourceInstanceId"] = request.ResourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceInstanceCerts",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceInstanceCertsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the certificates that are used in cloud service instances. The certificates returned include the certificates within the delegated administrator account and the certificates within members to which specific instances belong. For example, the delegated administrator account has certificate 1, instance lb-xx-1 belongs to member B, and member B has certificate 2. If you specify instance lb-xx-1 in the request, certificate 1 and certificate 2 are returned.
         *
         * @param request DescribeResourceInstanceCertsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceInstanceCertsResponse
         */
        public async Task<DescribeResourceInstanceCertsResponse> DescribeResourceInstanceCertsWithOptionsAsync(DescribeResourceInstanceCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceId))
            {
                query["ResourceInstanceId"] = request.ResourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceInstanceCerts",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceInstanceCertsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the certificates that are used in cloud service instances. The certificates returned include the certificates within the delegated administrator account and the certificates within members to which specific instances belong. For example, the delegated administrator account has certificate 1, instance lb-xx-1 belongs to member B, and member B has certificate 2. If you specify instance lb-xx-1 in the request, certificate 1 and certificate 2 are returned.
         *
         * @param request DescribeResourceInstanceCertsRequest
         * @return DescribeResourceInstanceCertsResponse
         */
        public DescribeResourceInstanceCertsResponse DescribeResourceInstanceCerts(DescribeResourceInstanceCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceInstanceCertsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the certificates that are used in cloud service instances. The certificates returned include the certificates within the delegated administrator account and the certificates within members to which specific instances belong. For example, the delegated administrator account has certificate 1, instance lb-xx-1 belongs to member B, and member B has certificate 2. If you specify instance lb-xx-1 in the request, certificate 1 and certificate 2 are returned.
         *
         * @param request DescribeResourceInstanceCertsRequest
         * @return DescribeResourceInstanceCertsResponse
         */
        public async Task<DescribeResourceInstanceCertsResponse> DescribeResourceInstanceCertsAsync(DescribeResourceInstanceCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceInstanceCertsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether the log collection feature is enabled for a protected object.
         *
         * @param request DescribeResourceLogStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceLogStatusResponse
         */
        public DescribeResourceLogStatusResponse DescribeResourceLogStatusWithOptions(DescribeResourceLogStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceLogStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceLogStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether the log collection feature is enabled for a protected object.
         *
         * @param request DescribeResourceLogStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceLogStatusResponse
         */
        public async Task<DescribeResourceLogStatusResponse> DescribeResourceLogStatusWithOptionsAsync(DescribeResourceLogStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceLogStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceLogStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether the log collection feature is enabled for a protected object.
         *
         * @param request DescribeResourceLogStatusRequest
         * @return DescribeResourceLogStatusResponse
         */
        public DescribeResourceLogStatusResponse DescribeResourceLogStatus(DescribeResourceLogStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceLogStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether the log collection feature is enabled for a protected object.
         *
         * @param request DescribeResourceLogStatusRequest
         * @return DescribeResourceLogStatusResponse
         */
        public async Task<DescribeResourceLogStatusResponse> DescribeResourceLogStatusAsync(DescribeResourceLogStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceLogStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the ports of a cloud service instance that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeResourcePortRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourcePortResponse
         */
        public DescribeResourcePortResponse DescribeResourcePortWithOptions(DescribeResourcePortRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceId))
            {
                query["ResourceInstanceId"] = request.ResourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourcePort",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourcePortResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the ports of a cloud service instance that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeResourcePortRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourcePortResponse
         */
        public async Task<DescribeResourcePortResponse> DescribeResourcePortWithOptionsAsync(DescribeResourcePortRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceInstanceId))
            {
                query["ResourceInstanceId"] = request.ResourceInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourcePort",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourcePortResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the ports of a cloud service instance that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeResourcePortRequest
         * @return DescribeResourcePortResponse
         */
        public DescribeResourcePortResponse DescribeResourcePort(DescribeResourcePortRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourcePortWithOptions(request, runtime);
        }

        /**
         * @summary Queries the ports of a cloud service instance that are added to Web Application Firewall (WAF).
         *
         * @param request DescribeResourcePortRequest
         * @return DescribeResourcePortResponse
         */
        public async Task<DescribeResourcePortResponse> DescribeResourcePortAsync(DescribeResourcePortRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourcePortWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the region IDs of the resources that are added to Web Application Firewall (WAF) in cloud native mode. The resources include Application Load Balancer (ALB) instances, Microservices Engine (MSE) instances, and custom domain names bound to web applications in Function Compute.
         *
         * @param request DescribeResourceRegionIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceRegionIdResponse
         */
        public DescribeResourceRegionIdResponse DescribeResourceRegionIdWithOptions(DescribeResourceRegionIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceRegionId",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceRegionIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the region IDs of the resources that are added to Web Application Firewall (WAF) in cloud native mode. The resources include Application Load Balancer (ALB) instances, Microservices Engine (MSE) instances, and custom domain names bound to web applications in Function Compute.
         *
         * @param request DescribeResourceRegionIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceRegionIdResponse
         */
        public async Task<DescribeResourceRegionIdResponse> DescribeResourceRegionIdWithOptionsAsync(DescribeResourceRegionIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceRegionId",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceRegionIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the region IDs of the resources that are added to Web Application Firewall (WAF) in cloud native mode. The resources include Application Load Balancer (ALB) instances, Microservices Engine (MSE) instances, and custom domain names bound to web applications in Function Compute.
         *
         * @param request DescribeResourceRegionIdRequest
         * @return DescribeResourceRegionIdResponse
         */
        public DescribeResourceRegionIdResponse DescribeResourceRegionId(DescribeResourceRegionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceRegionIdWithOptions(request, runtime);
        }

        /**
         * @summary Queries the region IDs of the resources that are added to Web Application Firewall (WAF) in cloud native mode. The resources include Application Load Balancer (ALB) instances, Microservices Engine (MSE) instances, and custom domain names bound to web applications in Function Compute.
         *
         * @param request DescribeResourceRegionIdRequest
         * @return DescribeResourceRegionIdResponse
         */
        public async Task<DescribeResourceRegionIdResponse> DescribeResourceRegionIdAsync(DescribeResourceRegionIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceRegionIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the region IDs of Classic Load Balancer (CLB) and Elastic Compute Service (ECS) instances that can be added to Web Application Firewall (WAF) in transparent proxy mode.
         *
         * @param request DescribeResourceSupportRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceSupportRegionsResponse
         */
        public DescribeResourceSupportRegionsResponse DescribeResourceSupportRegionsWithOptions(DescribeResourceSupportRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceSupportRegions",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceSupportRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the region IDs of Classic Load Balancer (CLB) and Elastic Compute Service (ECS) instances that can be added to Web Application Firewall (WAF) in transparent proxy mode.
         *
         * @param request DescribeResourceSupportRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceSupportRegionsResponse
         */
        public async Task<DescribeResourceSupportRegionsResponse> DescribeResourceSupportRegionsWithOptionsAsync(DescribeResourceSupportRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceSupportRegions",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceSupportRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the region IDs of Classic Load Balancer (CLB) and Elastic Compute Service (ECS) instances that can be added to Web Application Firewall (WAF) in transparent proxy mode.
         *
         * @param request DescribeResourceSupportRegionsRequest
         * @return DescribeResourceSupportRegionsResponse
         */
        public DescribeResourceSupportRegionsResponse DescribeResourceSupportRegions(DescribeResourceSupportRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceSupportRegionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the region IDs of Classic Load Balancer (CLB) and Elastic Compute Service (ECS) instances that can be added to Web Application Firewall (WAF) in transparent proxy mode.
         *
         * @param request DescribeResourceSupportRegionsRequest
         * @return DescribeResourceSupportRegionsResponse
         */
        public async Task<DescribeResourceSupportRegionsResponse> DescribeResourceSupportRegionsAsync(DescribeResourceSupportRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceSupportRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the trend of the number of error codes that are returned to clients or Web Application Firewall (WAF). The error codes include 302, 405, 444, 499, and 5XX.
         *
         * @param request DescribeResponseCodeTrendGraphRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResponseCodeTrendGraphResponse
         */
        public DescribeResponseCodeTrendGraphResponse DescribeResponseCodeTrendGraphWithOptions(DescribeResponseCodeTrendGraphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
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
                Action = "DescribeResponseCodeTrendGraph",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResponseCodeTrendGraphResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the trend of the number of error codes that are returned to clients or Web Application Firewall (WAF). The error codes include 302, 405, 444, 499, and 5XX.
         *
         * @param request DescribeResponseCodeTrendGraphRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResponseCodeTrendGraphResponse
         */
        public async Task<DescribeResponseCodeTrendGraphResponse> DescribeResponseCodeTrendGraphWithOptionsAsync(DescribeResponseCodeTrendGraphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
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
                Action = "DescribeResponseCodeTrendGraph",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResponseCodeTrendGraphResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the trend of the number of error codes that are returned to clients or Web Application Firewall (WAF). The error codes include 302, 405, 444, 499, and 5XX.
         *
         * @param request DescribeResponseCodeTrendGraphRequest
         * @return DescribeResponseCodeTrendGraphResponse
         */
        public DescribeResponseCodeTrendGraphResponse DescribeResponseCodeTrendGraph(DescribeResponseCodeTrendGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResponseCodeTrendGraphWithOptions(request, runtime);
        }

        /**
         * @summary Queries the trend of the number of error codes that are returned to clients or Web Application Firewall (WAF). The error codes include 302, 405, 444, 499, and 5XX.
         *
         * @param request DescribeResponseCodeTrendGraphRequest
         * @return DescribeResponseCodeTrendGraphResponse
         */
        public async Task<DescribeResponseCodeTrendGraphResponse> DescribeResponseCodeTrendGraphAsync(DescribeResponseCodeTrendGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResponseCodeTrendGraphWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries regular expression rule groups by page.
         *
         * @param request DescribeRuleGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleGroupsResponse
         */
        public DescribeRuleGroupsResponse DescribeRuleGroupsWithOptions(DescribeRuleGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["SearchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                query["SearchValue"] = request.SearchValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleGroups",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries regular expression rule groups by page.
         *
         * @param request DescribeRuleGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleGroupsResponse
         */
        public async Task<DescribeRuleGroupsResponse> DescribeRuleGroupsWithOptionsAsync(DescribeRuleGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["SearchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                query["SearchValue"] = request.SearchValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleGroups",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries regular expression rule groups by page.
         *
         * @param request DescribeRuleGroupsRequest
         * @return DescribeRuleGroupsResponse
         */
        public DescribeRuleGroupsResponse DescribeRuleGroups(DescribeRuleGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRuleGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries regular expression rule groups by page.
         *
         * @param request DescribeRuleGroupsRequest
         * @return DescribeRuleGroupsResponse
         */
        public async Task<DescribeRuleGroupsResponse> DescribeRuleGroupsAsync(DescribeRuleGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRuleGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the top 10 IP addresses from which attacks are initiated.
         *
         * @param request DescribeRuleHitsTopClientIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleHitsTopClientIpResponse
         */
        public DescribeRuleHitsTopClientIpResponse DescribeRuleHitsTopClientIpWithOptions(DescribeRuleHitsTopClientIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleHitsTopClientIp",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleHitsTopClientIpResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 IP addresses from which attacks are initiated.
         *
         * @param request DescribeRuleHitsTopClientIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleHitsTopClientIpResponse
         */
        public async Task<DescribeRuleHitsTopClientIpResponse> DescribeRuleHitsTopClientIpWithOptionsAsync(DescribeRuleHitsTopClientIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleHitsTopClientIp",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleHitsTopClientIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 IP addresses from which attacks are initiated.
         *
         * @param request DescribeRuleHitsTopClientIpRequest
         * @return DescribeRuleHitsTopClientIpResponse
         */
        public DescribeRuleHitsTopClientIpResponse DescribeRuleHitsTopClientIp(DescribeRuleHitsTopClientIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRuleHitsTopClientIpWithOptions(request, runtime);
        }

        /**
         * @summary Queries the top 10 IP addresses from which attacks are initiated.
         *
         * @param request DescribeRuleHitsTopClientIpRequest
         * @return DescribeRuleHitsTopClientIpResponse
         */
        public async Task<DescribeRuleHitsTopClientIpResponse> DescribeRuleHitsTopClientIpAsync(DescribeRuleHitsTopClientIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRuleHitsTopClientIpWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the top 10 protected objects that trigger protection rules.
         *
         * @param request DescribeRuleHitsTopResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleHitsTopResourceResponse
         */
        public DescribeRuleHitsTopResourceResponse DescribeRuleHitsTopResourceWithOptions(DescribeRuleHitsTopResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleHitsTopResource",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleHitsTopResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 protected objects that trigger protection rules.
         *
         * @param request DescribeRuleHitsTopResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleHitsTopResourceResponse
         */
        public async Task<DescribeRuleHitsTopResourceResponse> DescribeRuleHitsTopResourceWithOptionsAsync(DescribeRuleHitsTopResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleHitsTopResource",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleHitsTopResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 protected objects that trigger protection rules.
         *
         * @param request DescribeRuleHitsTopResourceRequest
         * @return DescribeRuleHitsTopResourceResponse
         */
        public DescribeRuleHitsTopResourceResponse DescribeRuleHitsTopResource(DescribeRuleHitsTopResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRuleHitsTopResourceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the top 10 protected objects that trigger protection rules.
         *
         * @param request DescribeRuleHitsTopResourceRequest
         * @return DescribeRuleHitsTopResourceResponse
         */
        public async Task<DescribeRuleHitsTopResourceResponse> DescribeRuleHitsTopResourceAsync(DescribeRuleHitsTopResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRuleHitsTopResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the IDs of the top 10 protection rules that are matched by requests.
         *
         * @param request DescribeRuleHitsTopRuleIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleHitsTopRuleIdResponse
         */
        public DescribeRuleHitsTopRuleIdResponse DescribeRuleHitsTopRuleIdWithOptions(DescribeRuleHitsTopRuleIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGroupResource))
            {
                query["IsGroupResource"] = request.IsGroupResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleHitsTopRuleId",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleHitsTopRuleIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the IDs of the top 10 protection rules that are matched by requests.
         *
         * @param request DescribeRuleHitsTopRuleIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleHitsTopRuleIdResponse
         */
        public async Task<DescribeRuleHitsTopRuleIdResponse> DescribeRuleHitsTopRuleIdWithOptionsAsync(DescribeRuleHitsTopRuleIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGroupResource))
            {
                query["IsGroupResource"] = request.IsGroupResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleHitsTopRuleId",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleHitsTopRuleIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the IDs of the top 10 protection rules that are matched by requests.
         *
         * @param request DescribeRuleHitsTopRuleIdRequest
         * @return DescribeRuleHitsTopRuleIdResponse
         */
        public DescribeRuleHitsTopRuleIdResponse DescribeRuleHitsTopRuleId(DescribeRuleHitsTopRuleIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRuleHitsTopRuleIdWithOptions(request, runtime);
        }

        /**
         * @summary Queries the IDs of the top 10 protection rules that are matched by requests.
         *
         * @param request DescribeRuleHitsTopRuleIdRequest
         * @return DescribeRuleHitsTopRuleIdResponse
         */
        public async Task<DescribeRuleHitsTopRuleIdResponse> DescribeRuleHitsTopRuleIdAsync(DescribeRuleHitsTopRuleIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRuleHitsTopRuleIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the top 10 protection modules that are matched.
         *
         * @param request DescribeRuleHitsTopTuleTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleHitsTopTuleTypeResponse
         */
        public DescribeRuleHitsTopTuleTypeResponse DescribeRuleHitsTopTuleTypeWithOptions(DescribeRuleHitsTopTuleTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleHitsTopTuleType",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleHitsTopTuleTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 protection modules that are matched.
         *
         * @param request DescribeRuleHitsTopTuleTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleHitsTopTuleTypeResponse
         */
        public async Task<DescribeRuleHitsTopTuleTypeResponse> DescribeRuleHitsTopTuleTypeWithOptionsAsync(DescribeRuleHitsTopTuleTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleHitsTopTuleType",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleHitsTopTuleTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 protection modules that are matched.
         *
         * @param request DescribeRuleHitsTopTuleTypeRequest
         * @return DescribeRuleHitsTopTuleTypeResponse
         */
        public DescribeRuleHitsTopTuleTypeResponse DescribeRuleHitsTopTuleType(DescribeRuleHitsTopTuleTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRuleHitsTopTuleTypeWithOptions(request, runtime);
        }

        /**
         * @summary Queries the top 10 protection modules that are matched.
         *
         * @param request DescribeRuleHitsTopTuleTypeRequest
         * @return DescribeRuleHitsTopTuleTypeResponse
         */
        public async Task<DescribeRuleHitsTopTuleTypeResponse> DescribeRuleHitsTopTuleTypeAsync(DescribeRuleHitsTopTuleTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRuleHitsTopTuleTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the top 10 user agents that are used to initiate attacks.
         *
         * @param request DescribeRuleHitsTopUaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleHitsTopUaResponse
         */
        public DescribeRuleHitsTopUaResponse DescribeRuleHitsTopUaWithOptions(DescribeRuleHitsTopUaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleHitsTopUa",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleHitsTopUaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 user agents that are used to initiate attacks.
         *
         * @param request DescribeRuleHitsTopUaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleHitsTopUaResponse
         */
        public async Task<DescribeRuleHitsTopUaResponse> DescribeRuleHitsTopUaWithOptionsAsync(DescribeRuleHitsTopUaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleHitsTopUa",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleHitsTopUaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 user agents that are used to initiate attacks.
         *
         * @param request DescribeRuleHitsTopUaRequest
         * @return DescribeRuleHitsTopUaResponse
         */
        public DescribeRuleHitsTopUaResponse DescribeRuleHitsTopUa(DescribeRuleHitsTopUaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRuleHitsTopUaWithOptions(request, runtime);
        }

        /**
         * @summary Queries the top 10 user agents that are used to initiate attacks.
         *
         * @param request DescribeRuleHitsTopUaRequest
         * @return DescribeRuleHitsTopUaResponse
         */
        public async Task<DescribeRuleHitsTopUaResponse> DescribeRuleHitsTopUaAsync(DescribeRuleHitsTopUaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRuleHitsTopUaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the top 10 URLs that trigger protection rules.
         *
         * @param request DescribeRuleHitsTopUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleHitsTopUrlResponse
         */
        public DescribeRuleHitsTopUrlResponse DescribeRuleHitsTopUrlWithOptions(DescribeRuleHitsTopUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleHitsTopUrl",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleHitsTopUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 URLs that trigger protection rules.
         *
         * @param request DescribeRuleHitsTopUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRuleHitsTopUrlResponse
         */
        public async Task<DescribeRuleHitsTopUrlResponse> DescribeRuleHitsTopUrlWithOptionsAsync(DescribeRuleHitsTopUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRuleHitsTopUrl",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRuleHitsTopUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 URLs that trigger protection rules.
         *
         * @param request DescribeRuleHitsTopUrlRequest
         * @return DescribeRuleHitsTopUrlResponse
         */
        public DescribeRuleHitsTopUrlResponse DescribeRuleHitsTopUrl(DescribeRuleHitsTopUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRuleHitsTopUrlWithOptions(request, runtime);
        }

        /**
         * @summary Queries the top 10 URLs that trigger protection rules.
         *
         * @param request DescribeRuleHitsTopUrlRequest
         * @return DescribeRuleHitsTopUrlResponse
         */
        public async Task<DescribeRuleHitsTopUrlResponse> DescribeRuleHitsTopUrlAsync(DescribeRuleHitsTopUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRuleHitsTopUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries whether Web Application Firewall (WAF) is authorized to access Logstores.
         *
         * @param request DescribeSlsAuthStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSlsAuthStatusResponse
         */
        public DescribeSlsAuthStatusResponse DescribeSlsAuthStatusWithOptions(DescribeSlsAuthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsAuthStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlsAuthStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether Web Application Firewall (WAF) is authorized to access Logstores.
         *
         * @param request DescribeSlsAuthStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSlsAuthStatusResponse
         */
        public async Task<DescribeSlsAuthStatusResponse> DescribeSlsAuthStatusWithOptionsAsync(DescribeSlsAuthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsAuthStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlsAuthStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether Web Application Firewall (WAF) is authorized to access Logstores.
         *
         * @param request DescribeSlsAuthStatusRequest
         * @return DescribeSlsAuthStatusResponse
         */
        public DescribeSlsAuthStatusResponse DescribeSlsAuthStatus(DescribeSlsAuthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlsAuthStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries whether Web Application Firewall (WAF) is authorized to access Logstores.
         *
         * @param request DescribeSlsAuthStatusRequest
         * @return DescribeSlsAuthStatusResponse
         */
        public async Task<DescribeSlsAuthStatusResponse> DescribeSlsAuthStatusAsync(DescribeSlsAuthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlsAuthStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries information about a Logstore, such as the total capacity, storage duration, and used capacity.
         *
         * @param request DescribeSlsLogStoreRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSlsLogStoreResponse
         */
        public DescribeSlsLogStoreResponse DescribeSlsLogStoreWithOptions(DescribeSlsLogStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsLogStore",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlsLogStoreResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries information about a Logstore, such as the total capacity, storage duration, and used capacity.
         *
         * @param request DescribeSlsLogStoreRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSlsLogStoreResponse
         */
        public async Task<DescribeSlsLogStoreResponse> DescribeSlsLogStoreWithOptionsAsync(DescribeSlsLogStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsLogStore",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlsLogStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries information about a Logstore, such as the total capacity, storage duration, and used capacity.
         *
         * @param request DescribeSlsLogStoreRequest
         * @return DescribeSlsLogStoreResponse
         */
        public DescribeSlsLogStoreResponse DescribeSlsLogStore(DescribeSlsLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlsLogStoreWithOptions(request, runtime);
        }

        /**
         * @summary Queries information about a Logstore, such as the total capacity, storage duration, and used capacity.
         *
         * @param request DescribeSlsLogStoreRequest
         * @return DescribeSlsLogStoreResponse
         */
        public async Task<DescribeSlsLogStoreResponse> DescribeSlsLogStoreAsync(DescribeSlsLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlsLogStoreWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the status of a Simple Log Service Logstore.
         *
         * @param request DescribeSlsLogStoreStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSlsLogStoreStatusResponse
         */
        public DescribeSlsLogStoreStatusResponse DescribeSlsLogStoreStatusWithOptions(DescribeSlsLogStoreStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsLogStoreStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlsLogStoreStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the status of a Simple Log Service Logstore.
         *
         * @param request DescribeSlsLogStoreStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSlsLogStoreStatusResponse
         */
        public async Task<DescribeSlsLogStoreStatusResponse> DescribeSlsLogStoreStatusWithOptionsAsync(DescribeSlsLogStoreStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSlsLogStoreStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSlsLogStoreStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the status of a Simple Log Service Logstore.
         *
         * @param request DescribeSlsLogStoreStatusRequest
         * @return DescribeSlsLogStoreStatusResponse
         */
        public DescribeSlsLogStoreStatusResponse DescribeSlsLogStoreStatus(DescribeSlsLogStoreStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSlsLogStoreStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the status of a Simple Log Service Logstore.
         *
         * @param request DescribeSlsLogStoreStatusRequest
         * @return DescribeSlsLogStoreStatusResponse
         */
        public async Task<DescribeSlsLogStoreStatusResponse> DescribeSlsLogStoreStatusAsync(DescribeSlsLogStoreStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSlsLogStoreStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the number of protected resources for which a protection template takes effect.
         *
         * @param request DescribeTemplateResourceCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTemplateResourceCountResponse
         */
        public DescribeTemplateResourceCountResponse DescribeTemplateResourceCountWithOptions(DescribeTemplateResourceCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTemplateResourceCount",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTemplateResourceCountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the number of protected resources for which a protection template takes effect.
         *
         * @param request DescribeTemplateResourceCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTemplateResourceCountResponse
         */
        public async Task<DescribeTemplateResourceCountResponse> DescribeTemplateResourceCountWithOptionsAsync(DescribeTemplateResourceCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTemplateResourceCount",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTemplateResourceCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the number of protected resources for which a protection template takes effect.
         *
         * @param request DescribeTemplateResourceCountRequest
         * @return DescribeTemplateResourceCountResponse
         */
        public DescribeTemplateResourceCountResponse DescribeTemplateResourceCount(DescribeTemplateResourceCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTemplateResourceCountWithOptions(request, runtime);
        }

        /**
         * @summary Queries the number of protected resources for which a protection template takes effect.
         *
         * @param request DescribeTemplateResourceCountRequest
         * @return DescribeTemplateResourceCountResponse
         */
        public async Task<DescribeTemplateResourceCountResponse> DescribeTemplateResourceCountAsync(DescribeTemplateResourceCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTemplateResourceCountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the resources that are associated to a protection rule template.
         *
         * @param request DescribeTemplateResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTemplateResourcesResponse
         */
        public DescribeTemplateResourcesResponse DescribeTemplateResourcesWithOptions(DescribeTemplateResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
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
                Action = "DescribeTemplateResources",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTemplateResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the resources that are associated to a protection rule template.
         *
         * @param request DescribeTemplateResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTemplateResourcesResponse
         */
        public async Task<DescribeTemplateResourcesResponse> DescribeTemplateResourcesWithOptionsAsync(DescribeTemplateResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
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
                Action = "DescribeTemplateResources",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTemplateResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the resources that are associated to a protection rule template.
         *
         * @param request DescribeTemplateResourcesRequest
         * @return DescribeTemplateResourcesResponse
         */
        public DescribeTemplateResourcesResponse DescribeTemplateResources(DescribeTemplateResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTemplateResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the resources that are associated to a protection rule template.
         *
         * @param request DescribeTemplateResourcesRequest
         * @return DescribeTemplateResourcesResponse
         */
        public async Task<DescribeTemplateResourcesResponse> DescribeTemplateResourcesAsync(DescribeTemplateResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTemplateResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries available regions for log storage.
         *
         * @param request DescribeUserSlsLogRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserSlsLogRegionsResponse
         */
        public DescribeUserSlsLogRegionsResponse DescribeUserSlsLogRegionsWithOptions(DescribeUserSlsLogRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserSlsLogRegions",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserSlsLogRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries available regions for log storage.
         *
         * @param request DescribeUserSlsLogRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserSlsLogRegionsResponse
         */
        public async Task<DescribeUserSlsLogRegionsResponse> DescribeUserSlsLogRegionsWithOptionsAsync(DescribeUserSlsLogRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserSlsLogRegions",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserSlsLogRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries available regions for log storage.
         *
         * @param request DescribeUserSlsLogRegionsRequest
         * @return DescribeUserSlsLogRegionsResponse
         */
        public DescribeUserSlsLogRegionsResponse DescribeUserSlsLogRegions(DescribeUserSlsLogRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserSlsLogRegionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries available regions for log storage.
         *
         * @param request DescribeUserSlsLogRegionsRequest
         * @return DescribeUserSlsLogRegionsResponse
         */
        public async Task<DescribeUserSlsLogRegionsResponse> DescribeUserSlsLogRegionsAsync(DescribeUserSlsLogRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserSlsLogRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the status, region ID, and status modification time of Web Application Firewall (WAF) logs.
         *
         * @param request DescribeUserWafLogStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserWafLogStatusResponse
         */
        public DescribeUserWafLogStatusResponse DescribeUserWafLogStatusWithOptions(DescribeUserWafLogStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserWafLogStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserWafLogStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the status, region ID, and status modification time of Web Application Firewall (WAF) logs.
         *
         * @param request DescribeUserWafLogStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserWafLogStatusResponse
         */
        public async Task<DescribeUserWafLogStatusResponse> DescribeUserWafLogStatusWithOptionsAsync(DescribeUserWafLogStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserWafLogStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserWafLogStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the status, region ID, and status modification time of Web Application Firewall (WAF) logs.
         *
         * @param request DescribeUserWafLogStatusRequest
         * @return DescribeUserWafLogStatusResponse
         */
        public DescribeUserWafLogStatusResponse DescribeUserWafLogStatus(DescribeUserWafLogStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserWafLogStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the status, region ID, and status modification time of Web Application Firewall (WAF) logs.
         *
         * @param request DescribeUserWafLogStatusRequest
         * @return DescribeUserWafLogStatusResponse
         */
        public async Task<DescribeUserWafLogStatusResponse> DescribeUserWafLogStatusAsync(DescribeUserWafLogStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserWafLogStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the top 10 IP addresses from which requests are sent.
         *
         * @param request DescribeVisitTopIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVisitTopIpResponse
         */
        public DescribeVisitTopIpResponse DescribeVisitTopIpWithOptions(DescribeVisitTopIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVisitTopIp",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVisitTopIpResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 IP addresses from which requests are sent.
         *
         * @param request DescribeVisitTopIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVisitTopIpResponse
         */
        public async Task<DescribeVisitTopIpResponse> DescribeVisitTopIpWithOptionsAsync(DescribeVisitTopIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVisitTopIp",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVisitTopIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 IP addresses from which requests are sent.
         *
         * @param request DescribeVisitTopIpRequest
         * @return DescribeVisitTopIpResponse
         */
        public DescribeVisitTopIpResponse DescribeVisitTopIp(DescribeVisitTopIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVisitTopIpWithOptions(request, runtime);
        }

        /**
         * @summary Queries the top 10 IP addresses from which requests are sent.
         *
         * @param request DescribeVisitTopIpRequest
         * @return DescribeVisitTopIpResponse
         */
        public async Task<DescribeVisitTopIpResponse> DescribeVisitTopIpAsync(DescribeVisitTopIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVisitTopIpWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the top 10 user agents that are used to initiate requests.
         *
         * @param request DescribeVisitUasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVisitUasResponse
         */
        public DescribeVisitUasResponse DescribeVisitUasWithOptions(DescribeVisitUasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVisitUas",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVisitUasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 user agents that are used to initiate requests.
         *
         * @param request DescribeVisitUasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVisitUasResponse
         */
        public async Task<DescribeVisitUasResponse> DescribeVisitUasWithOptionsAsync(DescribeVisitUasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVisitUas",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVisitUasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the top 10 user agents that are used to initiate requests.
         *
         * @param request DescribeVisitUasRequest
         * @return DescribeVisitUasResponse
         */
        public DescribeVisitUasResponse DescribeVisitUas(DescribeVisitUasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVisitUasWithOptions(request, runtime);
        }

        /**
         * @summary Queries the top 10 user agents that are used to initiate requests.
         *
         * @param request DescribeVisitUasRequest
         * @return DescribeVisitUasResponse
         */
        public async Task<DescribeVisitUasResponse> DescribeVisitUasAsync(DescribeVisitUasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVisitUasWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the back-to-origin CIDR blocks of a Web Application Firewall (WAF) instance.
         *
         * @param request DescribeWafSourceIpSegmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWafSourceIpSegmentResponse
         */
        public DescribeWafSourceIpSegmentResponse DescribeWafSourceIpSegmentWithOptions(DescribeWafSourceIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWafSourceIpSegment",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWafSourceIpSegmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the back-to-origin CIDR blocks of a Web Application Firewall (WAF) instance.
         *
         * @param request DescribeWafSourceIpSegmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWafSourceIpSegmentResponse
         */
        public async Task<DescribeWafSourceIpSegmentResponse> DescribeWafSourceIpSegmentWithOptionsAsync(DescribeWafSourceIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWafSourceIpSegment",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWafSourceIpSegmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the back-to-origin CIDR blocks of a Web Application Firewall (WAF) instance.
         *
         * @param request DescribeWafSourceIpSegmentRequest
         * @return DescribeWafSourceIpSegmentResponse
         */
        public DescribeWafSourceIpSegmentResponse DescribeWafSourceIpSegment(DescribeWafSourceIpSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWafSourceIpSegmentWithOptions(request, runtime);
        }

        /**
         * @summary Queries the back-to-origin CIDR blocks of a Web Application Firewall (WAF) instance.
         *
         * @param request DescribeWafSourceIpSegmentRequest
         * @return DescribeWafSourceIpSegmentResponse
         */
        public async Task<DescribeWafSourceIpSegmentResponse> DescribeWafSourceIpSegmentAsync(DescribeWafSourceIpSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWafSourceIpSegmentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries tag keys.
         *
         * @param request ListTagKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagKeysResponse
         */
        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Version = "2021-10-01",
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

        /**
         * @summary Queries tag keys.
         *
         * @param request ListTagKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagKeysResponse
         */
        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Version = "2021-10-01",
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

        /**
         * @summary Queries tag keys.
         *
         * @param request ListTagKeysRequest
         * @return ListTagKeysResponse
         */
        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        /**
         * @summary Queries tag keys.
         *
         * @param request ListTagKeysRequest
         * @return ListTagKeysResponse
         */
        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the tags that are added to a resource.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
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
                Version = "2021-10-01",
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

        /**
         * @summary Queries the tags that are added to a resource.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
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
                Version = "2021-10-01",
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

        /**
         * @summary Queries the tags that are added to a resource.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the tags that are added to a resource.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the tag values of a tag key.
         *
         * @param request ListTagValuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagValuesResponse
         */
        public ListTagValuesResponse ListTagValuesWithOptions(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
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
                Version = "2021-10-01",
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

        /**
         * @summary Queries the tag values of a tag key.
         *
         * @param request ListTagValuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagValuesResponse
         */
        public async Task<ListTagValuesResponse> ListTagValuesWithOptionsAsync(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
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
                Version = "2021-10-01",
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

        /**
         * @summary Queries the tag values of a tag key.
         *
         * @param request ListTagValuesRequest
         * @return ListTagValuesResponse
         */
        public ListTagValuesResponse ListTagValues(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagValuesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the tag values of a tag key.
         *
         * @param request ListTagValuesRequest
         * @return ListTagValuesResponse
         */
        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagValuesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of API security log subscription.
         *
         * @param request ModifyApisecLogDeliveryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyApisecLogDeliveryResponse
         */
        public ModifyApisecLogDeliveryResponse ModifyApisecLogDeliveryWithOptions(ModifyApisecLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssertKey))
            {
                query["AssertKey"] = request.AssertKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                query["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                query["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyApisecLogDelivery",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyApisecLogDeliveryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of API security log subscription.
         *
         * @param request ModifyApisecLogDeliveryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyApisecLogDeliveryResponse
         */
        public async Task<ModifyApisecLogDeliveryResponse> ModifyApisecLogDeliveryWithOptionsAsync(ModifyApisecLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssertKey))
            {
                query["AssertKey"] = request.AssertKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRegionId))
            {
                query["LogRegionId"] = request.LogRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                query["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyApisecLogDelivery",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyApisecLogDeliveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of API security log subscription.
         *
         * @param request ModifyApisecLogDeliveryRequest
         * @return ModifyApisecLogDeliveryResponse
         */
        public ModifyApisecLogDeliveryResponse ModifyApisecLogDelivery(ModifyApisecLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyApisecLogDeliveryWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of API security log subscription.
         *
         * @param request ModifyApisecLogDeliveryRequest
         * @return ModifyApisecLogDeliveryResponse
         */
        public async Task<ModifyApisecLogDeliveryResponse> ModifyApisecLogDeliveryAsync(ModifyApisecLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyApisecLogDeliveryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the status of API security log subscription.
         *
         * @param request ModifyApisecLogDeliveryStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyApisecLogDeliveryStatusResponse
         */
        public ModifyApisecLogDeliveryStatusResponse ModifyApisecLogDeliveryStatusWithOptions(ModifyApisecLogDeliveryStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssertKey))
            {
                query["AssertKey"] = request.AssertKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "ModifyApisecLogDeliveryStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyApisecLogDeliveryStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the status of API security log subscription.
         *
         * @param request ModifyApisecLogDeliveryStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyApisecLogDeliveryStatusResponse
         */
        public async Task<ModifyApisecLogDeliveryStatusResponse> ModifyApisecLogDeliveryStatusWithOptionsAsync(ModifyApisecLogDeliveryStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssertKey))
            {
                query["AssertKey"] = request.AssertKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "ModifyApisecLogDeliveryStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyApisecLogDeliveryStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the status of API security log subscription.
         *
         * @param request ModifyApisecLogDeliveryStatusRequest
         * @return ModifyApisecLogDeliveryStatusResponse
         */
        public ModifyApisecLogDeliveryStatusResponse ModifyApisecLogDeliveryStatus(ModifyApisecLogDeliveryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyApisecLogDeliveryStatusWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the status of API security log subscription.
         *
         * @param request ModifyApisecLogDeliveryStatusRequest
         * @return ModifyApisecLogDeliveryStatusResponse
         */
        public async Task<ModifyApisecLogDeliveryStatusResponse> ModifyApisecLogDeliveryStatusAsync(ModifyApisecLogDeliveryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyApisecLogDeliveryStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a protected object group.
         *
         * @param request ModifyDefenseResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseResourceGroupResponse
         */
        public ModifyDefenseResourceGroupResponse ModifyDefenseResourceGroupWithOptions(ModifyDefenseResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddList))
            {
                query["AddList"] = request.AddList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteList))
            {
                query["DeleteList"] = request.DeleteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDefenseResourceGroup",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a protected object group.
         *
         * @param request ModifyDefenseResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseResourceGroupResponse
         */
        public async Task<ModifyDefenseResourceGroupResponse> ModifyDefenseResourceGroupWithOptionsAsync(ModifyDefenseResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddList))
            {
                query["AddList"] = request.AddList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteList))
            {
                query["DeleteList"] = request.DeleteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDefenseResourceGroup",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a protected object group.
         *
         * @param request ModifyDefenseResourceGroupRequest
         * @return ModifyDefenseResourceGroupResponse
         */
        public ModifyDefenseResourceGroupResponse ModifyDefenseResourceGroup(ModifyDefenseResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefenseResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a protected object group.
         *
         * @param request ModifyDefenseResourceGroupRequest
         * @return ModifyDefenseResourceGroupResponse
         */
        public async Task<ModifyDefenseResourceGroupResponse> ModifyDefenseResourceGroupAsync(ModifyDefenseResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefenseResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the cookie settings of a protected object and the method to identify the originating IP addresses of clients.
         *
         * @param request ModifyDefenseResourceXffRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseResourceXffResponse
         */
        public ModifyDefenseResourceXffResponse ModifyDefenseResourceXffWithOptions(ModifyDefenseResourceXffRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcwCookieStatus))
            {
                query["AcwCookieStatus"] = request.AcwCookieStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcwSecureStatus))
            {
                query["AcwSecureStatus"] = request.AcwSecureStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcwV3SecureStatus))
            {
                query["AcwV3SecureStatus"] = request.AcwV3SecureStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHeaders))
            {
                query["CustomHeaders"] = request.CustomHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XffStatus))
            {
                query["XffStatus"] = request.XffStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDefenseResourceXff",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseResourceXffResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the cookie settings of a protected object and the method to identify the originating IP addresses of clients.
         *
         * @param request ModifyDefenseResourceXffRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseResourceXffResponse
         */
        public async Task<ModifyDefenseResourceXffResponse> ModifyDefenseResourceXffWithOptionsAsync(ModifyDefenseResourceXffRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcwCookieStatus))
            {
                query["AcwCookieStatus"] = request.AcwCookieStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcwSecureStatus))
            {
                query["AcwSecureStatus"] = request.AcwSecureStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcwV3SecureStatus))
            {
                query["AcwV3SecureStatus"] = request.AcwV3SecureStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHeaders))
            {
                query["CustomHeaders"] = request.CustomHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XffStatus))
            {
                query["XffStatus"] = request.XffStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDefenseResourceXff",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseResourceXffResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the cookie settings of a protected object and the method to identify the originating IP addresses of clients.
         *
         * @param request ModifyDefenseResourceXffRequest
         * @return ModifyDefenseResourceXffResponse
         */
        public ModifyDefenseResourceXffResponse ModifyDefenseResourceXff(ModifyDefenseResourceXffRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefenseResourceXffWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the cookie settings of a protected object and the method to identify the originating IP addresses of clients.
         *
         * @param request ModifyDefenseResourceXffRequest
         * @return ModifyDefenseResourceXffResponse
         */
        public async Task<ModifyDefenseResourceXffResponse> ModifyDefenseResourceXffAsync(ModifyDefenseResourceXffRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefenseResourceXffWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a protection rule.
         *
         * @param request ModifyDefenseRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseRuleResponse
         */
        public ModifyDefenseRuleResponse ModifyDefenseRuleWithOptions(ModifyDefenseRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseScene))
            {
                query["DefenseScene"] = request.DefenseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
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
                Action = "ModifyDefenseRule",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a protection rule.
         *
         * @param request ModifyDefenseRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseRuleResponse
         */
        public async Task<ModifyDefenseRuleResponse> ModifyDefenseRuleWithOptionsAsync(ModifyDefenseRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefenseScene))
            {
                query["DefenseScene"] = request.DefenseScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
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
                Action = "ModifyDefenseRule",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a protection rule.
         *
         * @param request ModifyDefenseRuleRequest
         * @return ModifyDefenseRuleResponse
         */
        public ModifyDefenseRuleResponse ModifyDefenseRule(ModifyDefenseRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefenseRuleWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a protection rule.
         *
         * @param request ModifyDefenseRuleRequest
         * @return ModifyDefenseRuleResponse
         */
        public async Task<ModifyDefenseRuleResponse> ModifyDefenseRuleAsync(ModifyDefenseRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefenseRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the cached page of a website that is protected based on a website tamper-proofing rule.
         *
         * @param request ModifyDefenseRuleCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseRuleCacheResponse
         */
        public ModifyDefenseRuleCacheResponse ModifyDefenseRuleCacheWithOptions(ModifyDefenseRuleCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "ModifyDefenseRuleCache",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseRuleCacheResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the cached page of a website that is protected based on a website tamper-proofing rule.
         *
         * @param request ModifyDefenseRuleCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseRuleCacheResponse
         */
        public async Task<ModifyDefenseRuleCacheResponse> ModifyDefenseRuleCacheWithOptionsAsync(ModifyDefenseRuleCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "ModifyDefenseRuleCache",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseRuleCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the cached page of a website that is protected based on a website tamper-proofing rule.
         *
         * @param request ModifyDefenseRuleCacheRequest
         * @return ModifyDefenseRuleCacheResponse
         */
        public ModifyDefenseRuleCacheResponse ModifyDefenseRuleCache(ModifyDefenseRuleCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefenseRuleCacheWithOptions(request, runtime);
        }

        /**
         * @summary Updates the cached page of a website that is protected based on a website tamper-proofing rule.
         *
         * @param request ModifyDefenseRuleCacheRequest
         * @return ModifyDefenseRuleCacheResponse
         */
        public async Task<ModifyDefenseRuleCacheResponse> ModifyDefenseRuleCacheAsync(ModifyDefenseRuleCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefenseRuleCacheWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the status of a protection rule.
         *
         * @param request ModifyDefenseRuleStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseRuleStatusResponse
         */
        public ModifyDefenseRuleStatusResponse ModifyDefenseRuleStatusWithOptions(ModifyDefenseRuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleStatus))
            {
                query["RuleStatus"] = request.RuleStatus;
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
                Action = "ModifyDefenseRuleStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseRuleStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the status of a protection rule.
         *
         * @param request ModifyDefenseRuleStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseRuleStatusResponse
         */
        public async Task<ModifyDefenseRuleStatusResponse> ModifyDefenseRuleStatusWithOptionsAsync(ModifyDefenseRuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleStatus))
            {
                query["RuleStatus"] = request.RuleStatus;
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
                Action = "ModifyDefenseRuleStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseRuleStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the status of a protection rule.
         *
         * @param request ModifyDefenseRuleStatusRequest
         * @return ModifyDefenseRuleStatusResponse
         */
        public ModifyDefenseRuleStatusResponse ModifyDefenseRuleStatus(ModifyDefenseRuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefenseRuleStatusWithOptions(request, runtime);
        }

        /**
         * @summary Changes the status of a protection rule.
         *
         * @param request ModifyDefenseRuleStatusRequest
         * @return ModifyDefenseRuleStatusResponse
         */
        public async Task<ModifyDefenseRuleStatusResponse> ModifyDefenseRuleStatusAsync(ModifyDefenseRuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefenseRuleStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a protection rule template.
         *
         * @param request ModifyDefenseTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseTemplateResponse
         */
        public ModifyDefenseTemplateResponse ModifyDefenseTemplateWithOptions(ModifyDefenseTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "ModifyDefenseTemplate",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a protection rule template.
         *
         * @param request ModifyDefenseTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseTemplateResponse
         */
        public async Task<ModifyDefenseTemplateResponse> ModifyDefenseTemplateWithOptionsAsync(ModifyDefenseTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "ModifyDefenseTemplate",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a protection rule template.
         *
         * @param request ModifyDefenseTemplateRequest
         * @return ModifyDefenseTemplateResponse
         */
        public ModifyDefenseTemplateResponse ModifyDefenseTemplate(ModifyDefenseTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefenseTemplateWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a protection rule template.
         *
         * @param request ModifyDefenseTemplateRequest
         * @return ModifyDefenseTemplateResponse
         */
        public async Task<ModifyDefenseTemplateResponse> ModifyDefenseTemplateAsync(ModifyDefenseTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefenseTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the status of a protection rule template.
         *
         * @param request ModifyDefenseTemplateStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseTemplateStatusResponse
         */
        public ModifyDefenseTemplateStatusResponse ModifyDefenseTemplateStatusWithOptions(ModifyDefenseTemplateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateStatus))
            {
                query["TemplateStatus"] = request.TemplateStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDefenseTemplateStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseTemplateStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the status of a protection rule template.
         *
         * @param request ModifyDefenseTemplateStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseTemplateStatusResponse
         */
        public async Task<ModifyDefenseTemplateStatusResponse> ModifyDefenseTemplateStatusWithOptionsAsync(ModifyDefenseTemplateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateStatus))
            {
                query["TemplateStatus"] = request.TemplateStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDefenseTemplateStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseTemplateStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the status of a protection rule template.
         *
         * @param request ModifyDefenseTemplateStatusRequest
         * @return ModifyDefenseTemplateStatusResponse
         */
        public ModifyDefenseTemplateStatusResponse ModifyDefenseTemplateStatus(ModifyDefenseTemplateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefenseTemplateStatusWithOptions(request, runtime);
        }

        /**
         * @summary Changes the status of a protection rule template.
         *
         * @param request ModifyDefenseTemplateStatusRequest
         * @return ModifyDefenseTemplateStatusResponse
         */
        public async Task<ModifyDefenseTemplateStatusResponse> ModifyDefenseTemplateStatusAsync(ModifyDefenseTemplateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefenseTemplateStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a domain name that is added to Web Application Firewall (WAF) in CNAME record mode.
         *
         * @param tmpReq ModifyDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDomainResponse
         */
        public ModifyDomainResponse ModifyDomainWithOptions(ModifyDomainRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyDomainShrinkRequest request = new ModifyDomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Listen))
            {
                request.ListenShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Listen, "Listen", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Redirect))
            {
                request.RedirectShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Redirect, "Redirect", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenShrink))
            {
                query["Listen"] = request.ListenShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectShrink))
            {
                query["Redirect"] = request.RedirectShrink;
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
                Action = "ModifyDomain",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a domain name that is added to Web Application Firewall (WAF) in CNAME record mode.
         *
         * @param tmpReq ModifyDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDomainResponse
         */
        public async Task<ModifyDomainResponse> ModifyDomainWithOptionsAsync(ModifyDomainRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyDomainShrinkRequest request = new ModifyDomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Listen))
            {
                request.ListenShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Listen, "Listen", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Redirect))
            {
                request.RedirectShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Redirect, "Redirect", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessType))
            {
                query["AccessType"] = request.AccessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenShrink))
            {
                query["Listen"] = request.ListenShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectShrink))
            {
                query["Redirect"] = request.RedirectShrink;
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
                Action = "ModifyDomain",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a domain name that is added to Web Application Firewall (WAF) in CNAME record mode.
         *
         * @param request ModifyDomainRequest
         * @return ModifyDomainResponse
         */
        public ModifyDomainResponse ModifyDomain(ModifyDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDomainWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a domain name that is added to Web Application Firewall (WAF) in CNAME record mode.
         *
         * @param request ModifyDomainRequest
         * @return ModifyDomainResponse
         */
        public async Task<ModifyDomainResponse> ModifyDomainAsync(ModifyDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Re-adds a domain name that is penalized for failing to obtain an Internet Content Provider (ICP) filing to Web Application Firewall (WAF).
         *
         * @param request ModifyDomainPunishStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDomainPunishStatusResponse
         */
        public ModifyDomainPunishStatusResponse ModifyDomainPunishStatusWithOptions(ModifyDomainPunishStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDomainPunishStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDomainPunishStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Re-adds a domain name that is penalized for failing to obtain an Internet Content Provider (ICP) filing to Web Application Firewall (WAF).
         *
         * @param request ModifyDomainPunishStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDomainPunishStatusResponse
         */
        public async Task<ModifyDomainPunishStatusResponse> ModifyDomainPunishStatusWithOptionsAsync(ModifyDomainPunishStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDomainPunishStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDomainPunishStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Re-adds a domain name that is penalized for failing to obtain an Internet Content Provider (ICP) filing to Web Application Firewall (WAF).
         *
         * @param request ModifyDomainPunishStatusRequest
         * @return ModifyDomainPunishStatusResponse
         */
        public ModifyDomainPunishStatusResponse ModifyDomainPunishStatus(ModifyDomainPunishStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDomainPunishStatusWithOptions(request, runtime);
        }

        /**
         * @summary Re-adds a domain name that is penalized for failing to obtain an Internet Content Provider (ICP) filing to Web Application Firewall (WAF).
         *
         * @param request ModifyDomainPunishStatusRequest
         * @return ModifyDomainPunishStatusResponse
         */
        public async Task<ModifyDomainPunishStatusResponse> ModifyDomainPunishStatusAsync(ModifyDomainPunishStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDomainPunishStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables manual bypass for a hybrid cloud cluster of the SDK-based traffic mirroring mode.
         *
         * @param request ModifyHybridCloudClusterBypassStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyHybridCloudClusterBypassStatusResponse
         */
        public ModifyHybridCloudClusterBypassStatusResponse ModifyHybridCloudClusterBypassStatusWithOptions(ModifyHybridCloudClusterBypassStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterResourceId))
            {
                query["ClusterResourceId"] = request.ClusterResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleStatus))
            {
                query["RuleStatus"] = request.RuleStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHybridCloudClusterBypassStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHybridCloudClusterBypassStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or disables manual bypass for a hybrid cloud cluster of the SDK-based traffic mirroring mode.
         *
         * @param request ModifyHybridCloudClusterBypassStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyHybridCloudClusterBypassStatusResponse
         */
        public async Task<ModifyHybridCloudClusterBypassStatusResponse> ModifyHybridCloudClusterBypassStatusWithOptionsAsync(ModifyHybridCloudClusterBypassStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterResourceId))
            {
                query["ClusterResourceId"] = request.ClusterResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleStatus))
            {
                query["RuleStatus"] = request.RuleStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHybridCloudClusterBypassStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHybridCloudClusterBypassStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or disables manual bypass for a hybrid cloud cluster of the SDK-based traffic mirroring mode.
         *
         * @param request ModifyHybridCloudClusterBypassStatusRequest
         * @return ModifyHybridCloudClusterBypassStatusResponse
         */
        public ModifyHybridCloudClusterBypassStatusResponse ModifyHybridCloudClusterBypassStatus(ModifyHybridCloudClusterBypassStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHybridCloudClusterBypassStatusWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables manual bypass for a hybrid cloud cluster of the SDK-based traffic mirroring mode.
         *
         * @param request ModifyHybridCloudClusterBypassStatusRequest
         * @return ModifyHybridCloudClusterBypassStatusResponse
         */
        public async Task<ModifyHybridCloudClusterBypassStatusResponse> ModifyHybridCloudClusterBypassStatusAsync(ModifyHybridCloudClusterBypassStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHybridCloudClusterBypassStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies an IP address blacklist for major event protection.
         *
         * @param request ModifyMajorProtectionBlackIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyMajorProtectionBlackIpResponse
         */
        public ModifyMajorProtectionBlackIpResponse ModifyMajorProtectionBlackIpWithOptions(ModifyMajorProtectionBlackIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTime))
            {
                query["ExpiredTime"] = request.ExpiredTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpList))
            {
                query["IpList"] = request.IpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "ModifyMajorProtectionBlackIp",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMajorProtectionBlackIpResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies an IP address blacklist for major event protection.
         *
         * @param request ModifyMajorProtectionBlackIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyMajorProtectionBlackIpResponse
         */
        public async Task<ModifyMajorProtectionBlackIpResponse> ModifyMajorProtectionBlackIpWithOptionsAsync(ModifyMajorProtectionBlackIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTime))
            {
                query["ExpiredTime"] = request.ExpiredTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpList))
            {
                query["IpList"] = request.IpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
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
                Action = "ModifyMajorProtectionBlackIp",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMajorProtectionBlackIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies an IP address blacklist for major event protection.
         *
         * @param request ModifyMajorProtectionBlackIpRequest
         * @return ModifyMajorProtectionBlackIpResponse
         */
        public ModifyMajorProtectionBlackIpResponse ModifyMajorProtectionBlackIp(ModifyMajorProtectionBlackIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMajorProtectionBlackIpWithOptions(request, runtime);
        }

        /**
         * @summary Modifies an IP address blacklist for major event protection.
         *
         * @param request ModifyMajorProtectionBlackIpRequest
         * @return ModifyMajorProtectionBlackIpResponse
         */
        public async Task<ModifyMajorProtectionBlackIpResponse> ModifyMajorProtectionBlackIpAsync(ModifyMajorProtectionBlackIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMajorProtectionBlackIpWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the information about members that are added for multi-account management.
         *
         * @param request ModifyMemberAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyMemberAccountResponse
         */
        public ModifyMemberAccountResponse ModifyMemberAccountWithOptions(ModifyMemberAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccountId))
            {
                query["MemberAccountId"] = request.MemberAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMemberAccount",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMemberAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the information about members that are added for multi-account management.
         *
         * @param request ModifyMemberAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyMemberAccountResponse
         */
        public async Task<ModifyMemberAccountResponse> ModifyMemberAccountWithOptionsAsync(ModifyMemberAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccountId))
            {
                query["MemberAccountId"] = request.MemberAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMemberAccount",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMemberAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the information about members that are added for multi-account management.
         *
         * @param request ModifyMemberAccountRequest
         * @return ModifyMemberAccountResponse
         */
        public ModifyMemberAccountResponse ModifyMemberAccount(ModifyMemberAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMemberAccountWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the information about members that are added for multi-account management.
         *
         * @param request ModifyMemberAccountRequest
         * @return ModifyMemberAccountResponse
         */
        public async Task<ModifyMemberAccountResponse> ModifyMemberAccountAsync(ModifyMemberAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMemberAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改用户暂停防护状态
         *
         * @param request ModifyPauseProtectionStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPauseProtectionStatusResponse
         */
        public ModifyPauseProtectionStatusResponse ModifyPauseProtectionStatusWithOptions(ModifyPauseProtectionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseStatus))
            {
                query["PauseStatus"] = request.PauseStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPauseProtectionStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPauseProtectionStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改用户暂停防护状态
         *
         * @param request ModifyPauseProtectionStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPauseProtectionStatusResponse
         */
        public async Task<ModifyPauseProtectionStatusResponse> ModifyPauseProtectionStatusWithOptionsAsync(ModifyPauseProtectionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseStatus))
            {
                query["PauseStatus"] = request.PauseStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPauseProtectionStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPauseProtectionStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改用户暂停防护状态
         *
         * @param request ModifyPauseProtectionStatusRequest
         * @return ModifyPauseProtectionStatusResponse
         */
        public ModifyPauseProtectionStatusResponse ModifyPauseProtectionStatus(ModifyPauseProtectionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPauseProtectionStatusWithOptions(request, runtime);
        }

        /**
         * @summary 修改用户暂停防护状态
         *
         * @param request ModifyPauseProtectionStatusRequest
         * @return ModifyPauseProtectionStatusResponse
         */
        public async Task<ModifyPauseProtectionStatusResponse> ModifyPauseProtectionStatusAsync(ModifyPauseProtectionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPauseProtectionStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables the log collection feature for a protected object.
         *
         * @param request ModifyResourceLogStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyResourceLogStatusResponse
         */
        public ModifyResourceLogStatusResponse ModifyResourceLogStatusWithOptions(ModifyResourceLogStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "ModifyResourceLogStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyResourceLogStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or disables the log collection feature for a protected object.
         *
         * @param request ModifyResourceLogStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyResourceLogStatusResponse
         */
        public async Task<ModifyResourceLogStatusResponse> ModifyResourceLogStatusWithOptionsAsync(ModifyResourceLogStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
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
                Action = "ModifyResourceLogStatus",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyResourceLogStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or disables the log collection feature for a protected object.
         *
         * @param request ModifyResourceLogStatusRequest
         * @return ModifyResourceLogStatusResponse
         */
        public ModifyResourceLogStatusResponse ModifyResourceLogStatus(ModifyResourceLogStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyResourceLogStatusWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables the log collection feature for a protected object.
         *
         * @param request ModifyResourceLogStatusRequest
         * @return ModifyResourceLogStatusResponse
         */
        public async Task<ModifyResourceLogStatusResponse> ModifyResourceLogStatusAsync(ModifyResourceLogStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyResourceLogStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Associates or disassociates a protected object or protected object group with or from a protection rule template.
         *
         * @param request ModifyTemplateResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTemplateResourcesResponse
         */
        public ModifyTemplateResourcesResponse ModifyTemplateResourcesWithOptions(ModifyTemplateResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindResourceGroups))
            {
                query["BindResourceGroups"] = request.BindResourceGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindResources))
            {
                query["BindResources"] = request.BindResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindResourceGroups))
            {
                query["UnbindResourceGroups"] = request.UnbindResourceGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindResources))
            {
                query["UnbindResources"] = request.UnbindResources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTemplateResources",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTemplateResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Associates or disassociates a protected object or protected object group with or from a protection rule template.
         *
         * @param request ModifyTemplateResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTemplateResourcesResponse
         */
        public async Task<ModifyTemplateResourcesResponse> ModifyTemplateResourcesWithOptionsAsync(ModifyTemplateResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindResourceGroups))
            {
                query["BindResourceGroups"] = request.BindResourceGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindResources))
            {
                query["BindResources"] = request.BindResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindResourceGroups))
            {
                query["UnbindResourceGroups"] = request.UnbindResourceGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnbindResources))
            {
                query["UnbindResources"] = request.UnbindResources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTemplateResources",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTemplateResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Associates or disassociates a protected object or protected object group with or from a protection rule template.
         *
         * @param request ModifyTemplateResourcesRequest
         * @return ModifyTemplateResourcesResponse
         */
        public ModifyTemplateResourcesResponse ModifyTemplateResources(ModifyTemplateResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTemplateResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Associates or disassociates a protected object or protected object group with or from a protection rule template.
         *
         * @param request ModifyTemplateResourcesRequest
         * @return ModifyTemplateResourcesResponse
         */
        public async Task<ModifyTemplateResourcesResponse> ModifyTemplateResourcesAsync(ModifyTemplateResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTemplateResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Releases a Web Application Firewall (WAF) 3.0 instance.
         *
         * @param request ReleaseInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseInstanceResponse
         */
        public ReleaseInstanceResponse ReleaseInstanceWithOptions(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstance",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Releases a Web Application Firewall (WAF) 3.0 instance.
         *
         * @param request ReleaseInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseInstanceResponse
         */
        public async Task<ReleaseInstanceResponse> ReleaseInstanceWithOptionsAsync(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstance",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Releases a Web Application Firewall (WAF) 3.0 instance.
         *
         * @param request ReleaseInstanceRequest
         * @return ReleaseInstanceResponse
         */
        public ReleaseInstanceResponse ReleaseInstance(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Releases a Web Application Firewall (WAF) 3.0 instance.
         *
         * @param request ReleaseInstanceRequest
         * @return ReleaseInstanceResponse
         */
        public async Task<ReleaseInstanceResponse> ReleaseInstanceAsync(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Synchronizes Elastic Compute Service (ECS) instances and Classic Load Balancer (CLB) instances to Web Application Firewall (WAF).
         *
         * @description SyncProductInstance is an asynchronous operation. You can call the [DescribeProductInstances](https://help.aliyun.com/document_detail/2743168.html) operation to query the status of the task.
         *
         * @param request SyncProductInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncProductInstanceResponse
         */
        public SyncProductInstanceResponse SyncProductInstanceWithOptions(SyncProductInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncProductInstance",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncProductInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Synchronizes Elastic Compute Service (ECS) instances and Classic Load Balancer (CLB) instances to Web Application Firewall (WAF).
         *
         * @description SyncProductInstance is an asynchronous operation. You can call the [DescribeProductInstances](https://help.aliyun.com/document_detail/2743168.html) operation to query the status of the task.
         *
         * @param request SyncProductInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncProductInstanceResponse
         */
        public async Task<SyncProductInstanceResponse> SyncProductInstanceWithOptionsAsync(SyncProductInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceManagerResourceGroupId))
            {
                query["ResourceManagerResourceGroupId"] = request.ResourceManagerResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncProductInstance",
                Version = "2021-10-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncProductInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Synchronizes Elastic Compute Service (ECS) instances and Classic Load Balancer (CLB) instances to Web Application Firewall (WAF).
         *
         * @description SyncProductInstance is an asynchronous operation. You can call the [DescribeProductInstances](https://help.aliyun.com/document_detail/2743168.html) operation to query the status of the task.
         *
         * @param request SyncProductInstanceRequest
         * @return SyncProductInstanceResponse
         */
        public SyncProductInstanceResponse SyncProductInstance(SyncProductInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncProductInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Synchronizes Elastic Compute Service (ECS) instances and Classic Load Balancer (CLB) instances to Web Application Firewall (WAF).
         *
         * @description SyncProductInstance is an asynchronous operation. You can call the [DescribeProductInstances](https://help.aliyun.com/document_detail/2743168.html) operation to query the status of the task.
         *
         * @param request SyncProductInstanceRequest
         * @return SyncProductInstanceResponse
         */
        public async Task<SyncProductInstanceResponse> SyncProductInstanceAsync(SyncProductInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncProductInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds tags to resources.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
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
                Version = "2021-10-01",
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

        /**
         * @summary Adds tags to resources.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
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
                Version = "2021-10-01",
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

        /**
         * @summary Adds tags to resources.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Adds tags to resources.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes tags from resources and then deletes the tags.
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
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
                Version = "2021-10-01",
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

        /**
         * @summary Removes tags from resources and then deletes the tags.
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
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
                Version = "2021-10-01",
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

        /**
         * @summary Removes tags from resources and then deletes the tags.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Removes tags from resources and then deletes the tags.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

    }
}
