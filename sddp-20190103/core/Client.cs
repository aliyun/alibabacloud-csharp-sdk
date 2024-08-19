// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sddp20190103.Models;

namespace AlibabaCloud.SDK.Sddp20190103
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hongkong", "sddp-api.cn-hongkong.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("sddp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Modifies the configurations of a common configuration item for alerts.
         *
         * @description You can call this operation to create or restore configurations based on the codes of common configuration items. This allows you to manage the configurations of common configuration items.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConfigResponse
         */
        public CreateConfigResponse CreateConfigWithOptions(CreateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
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
                Action = "CreateConfig",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a common configuration item for alerts.
         *
         * @description You can call this operation to create or restore configurations based on the codes of common configuration items. This allows you to manage the configurations of common configuration items.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConfigResponse
         */
        public async Task<CreateConfigResponse> CreateConfigWithOptionsAsync(CreateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
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
                Action = "CreateConfig",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a common configuration item for alerts.
         *
         * @description You can call this operation to create or restore configurations based on the codes of common configuration items. This allows you to manage the configurations of common configuration items.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateConfigRequest
         * @return CreateConfigResponse
         */
        public CreateConfigResponse CreateConfig(CreateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConfigWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a common configuration item for alerts.
         *
         * @description You can call this operation to create or restore configurations based on the codes of common configuration items. This allows you to manage the configurations of common configuration items.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateConfigRequest
         * @return CreateConfigResponse
         */
        public async Task<CreateConfigResponse> CreateConfigAsync(CreateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Authorizes Data Security Center (DSC) to scan data assets. The data assets can be a database, a project, or a bucket.
         *
         * @description You can call this operation to authorize DSC to scan data assets to ensure the security of the data assets.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateDataLimitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDataLimitResponse
         */
        public CreateDataLimitResponse CreateDataLimitWithOptions(CreateDataLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScan))
            {
                query["AutoScan"] = request.AutoScan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificatePermission))
            {
                query["CertificatePermission"] = request.CertificatePermission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStatus))
            {
                query["EventStatus"] = request.EventStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstantlyScan))
            {
                query["InstantlyScan"] = request.InstantlyScan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreDay))
            {
                query["LogStoreDay"] = request.LogStoreDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OcrStatus))
            {
                query["OcrStatus"] = request.OcrStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingSize))
            {
                query["SamplingSize"] = request.SamplingSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataLimit",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataLimitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Authorizes Data Security Center (DSC) to scan data assets. The data assets can be a database, a project, or a bucket.
         *
         * @description You can call this operation to authorize DSC to scan data assets to ensure the security of the data assets.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateDataLimitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDataLimitResponse
         */
        public async Task<CreateDataLimitResponse> CreateDataLimitWithOptionsAsync(CreateDataLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScan))
            {
                query["AutoScan"] = request.AutoScan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificatePermission))
            {
                query["CertificatePermission"] = request.CertificatePermission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStatus))
            {
                query["EventStatus"] = request.EventStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstantlyScan))
            {
                query["InstantlyScan"] = request.InstantlyScan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreDay))
            {
                query["LogStoreDay"] = request.LogStoreDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OcrStatus))
            {
                query["OcrStatus"] = request.OcrStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingSize))
            {
                query["SamplingSize"] = request.SamplingSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataLimit",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataLimitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Authorizes Data Security Center (DSC) to scan data assets. The data assets can be a database, a project, or a bucket.
         *
         * @description You can call this operation to authorize DSC to scan data assets to ensure the security of the data assets.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateDataLimitRequest
         * @return CreateDataLimitResponse
         */
        public CreateDataLimitResponse CreateDataLimit(CreateDataLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataLimitWithOptions(request, runtime);
        }

        /**
         * @summary Authorizes Data Security Center (DSC) to scan data assets. The data assets can be a database, a project, or a bucket.
         *
         * @description You can call this operation to authorize DSC to scan data assets to ensure the security of the data assets.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateDataLimitRequest
         * @return CreateDataLimitResponse
         */
        public async Task<CreateDataLimitResponse> CreateDataLimitAsync(CreateDataLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataLimitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a custom sensitive data detection rule.
         *
         * @param request CreateRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRuleResponse
         */
        public CreateRuleResponse CreateRuleWithOptions(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentCategory))
            {
                query["ContentCategory"] = request.ContentCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatExpress))
            {
                query["StatExpress"] = request.StatExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportForm))
            {
                query["SupportForm"] = request.SupportForm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarnLevel))
            {
                query["WarnLevel"] = request.WarnLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRule",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a custom sensitive data detection rule.
         *
         * @param request CreateRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRuleResponse
         */
        public async Task<CreateRuleResponse> CreateRuleWithOptionsAsync(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentCategory))
            {
                query["ContentCategory"] = request.ContentCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatExpress))
            {
                query["StatExpress"] = request.StatExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportForm))
            {
                query["SupportForm"] = request.SupportForm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarnLevel))
            {
                query["WarnLevel"] = request.WarnLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRule",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a custom sensitive data detection rule.
         *
         * @param request CreateRuleRequest
         * @return CreateRuleResponse
         */
        public CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRuleWithOptions(request, runtime);
        }

        /**
         * @summary Creates a custom sensitive data detection rule.
         *
         * @param request CreateRuleRequest
         * @return CreateRuleResponse
         */
        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a custom scan task. The custom scan task is used to scan data assets on which Data Security Center (DSC) is granted the scan permissions for sensitive data.
         *
         * @description You can call this operation to create a custom scan task for authorized data assets. You can customize the interval between two consecutive scan tasks and the time when the scan task is executed next time.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateScanTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScanTaskResponse
         */
        public CreateScanTaskResponse CreateScanTaskWithOptions(CreateScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataLimitId))
            {
                query["DataLimitId"] = request.DataLimitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntervalDay))
            {
                query["IntervalDay"] = request.IntervalDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssScanPath))
            {
                query["OssScanPath"] = request.OssScanPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunHour))
            {
                query["RunHour"] = request.RunHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMinute))
            {
                query["RunMinute"] = request.RunMinute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanRange))
            {
                query["ScanRange"] = request.ScanRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanRangeContent))
            {
                query["ScanRangeContent"] = request.ScanRangeContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUserName))
            {
                query["TaskUserName"] = request.TaskUserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScanTask",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScanTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a custom scan task. The custom scan task is used to scan data assets on which Data Security Center (DSC) is granted the scan permissions for sensitive data.
         *
         * @description You can call this operation to create a custom scan task for authorized data assets. You can customize the interval between two consecutive scan tasks and the time when the scan task is executed next time.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateScanTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScanTaskResponse
         */
        public async Task<CreateScanTaskResponse> CreateScanTaskWithOptionsAsync(CreateScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataLimitId))
            {
                query["DataLimitId"] = request.DataLimitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntervalDay))
            {
                query["IntervalDay"] = request.IntervalDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssScanPath))
            {
                query["OssScanPath"] = request.OssScanPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunHour))
            {
                query["RunHour"] = request.RunHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMinute))
            {
                query["RunMinute"] = request.RunMinute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanRange))
            {
                query["ScanRange"] = request.ScanRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanRangeContent))
            {
                query["ScanRangeContent"] = request.ScanRangeContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUserName))
            {
                query["TaskUserName"] = request.TaskUserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScanTask",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScanTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a custom scan task. The custom scan task is used to scan data assets on which Data Security Center (DSC) is granted the scan permissions for sensitive data.
         *
         * @description You can call this operation to create a custom scan task for authorized data assets. You can customize the interval between two consecutive scan tasks and the time when the scan task is executed next time.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateScanTaskRequest
         * @return CreateScanTaskResponse
         */
        public CreateScanTaskResponse CreateScanTask(CreateScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScanTaskWithOptions(request, runtime);
        }

        /**
         * @summary Creates a custom scan task. The custom scan task is used to scan data assets on which Data Security Center (DSC) is granted the scan permissions for sensitive data.
         *
         * @description You can call this operation to create a custom scan task for authorized data assets. You can customize the interval between two consecutive scan tasks and the time when the scan task is executed next time.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateScanTaskRequest
         * @return CreateScanTaskResponse
         */
        public async Task<CreateScanTaskResponse> CreateScanTaskAsync(CreateScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScanTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a service-linked role for Data Security Center (DSC) to grant DSC the permissions to access data assets in other services.
         *
         * @description You can call this operation to allow DSC to access the data assets in services such as Object Storage Service (OSS), ApsaraDB RDS, and MaxCompute. After you call this operation, the system automatically creates a service-linked role named AliyunServiceRoleForSDDP and attaches the AliyunServiceRolePolicyForSDDP policy to the role.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateSlrRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSlrRoleResponse
         */
        public CreateSlrRoleResponse CreateSlrRoleWithOptions(CreateSlrRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "CreateSlrRole",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSlrRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a service-linked role for Data Security Center (DSC) to grant DSC the permissions to access data assets in other services.
         *
         * @description You can call this operation to allow DSC to access the data assets in services such as Object Storage Service (OSS), ApsaraDB RDS, and MaxCompute. After you call this operation, the system automatically creates a service-linked role named AliyunServiceRoleForSDDP and attaches the AliyunServiceRolePolicyForSDDP policy to the role.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateSlrRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSlrRoleResponse
         */
        public async Task<CreateSlrRoleResponse> CreateSlrRoleWithOptionsAsync(CreateSlrRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "CreateSlrRole",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSlrRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a service-linked role for Data Security Center (DSC) to grant DSC the permissions to access data assets in other services.
         *
         * @description You can call this operation to allow DSC to access the data assets in services such as Object Storage Service (OSS), ApsaraDB RDS, and MaxCompute. After you call this operation, the system automatically creates a service-linked role named AliyunServiceRoleForSDDP and attaches the AliyunServiceRolePolicyForSDDP policy to the role.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateSlrRoleRequest
         * @return CreateSlrRoleResponse
         */
        public CreateSlrRoleResponse CreateSlrRole(CreateSlrRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSlrRoleWithOptions(request, runtime);
        }

        /**
         * @summary Creates a service-linked role for Data Security Center (DSC) to grant DSC the permissions to access data assets in other services.
         *
         * @description You can call this operation to allow DSC to access the data assets in services such as Object Storage Service (OSS), ApsaraDB RDS, and MaxCompute. After you call this operation, the system automatically creates a service-linked role named AliyunServiceRoleForSDDP and attaches the AliyunServiceRolePolicyForSDDP policy to the role.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request CreateSlrRoleRequest
         * @return CreateSlrRoleResponse
         */
        public async Task<CreateSlrRoleResponse> CreateSlrRoleAsync(CreateSlrRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSlrRoleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Revokes the scan permissions on a data asset. The data asset can be a database, an instance, or a bucket.
         *
         * @description You can call this operation to revoke the permissions on a data asset from Data Security Center (DSC).
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteDataLimitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataLimitResponse
         */
        public DeleteDataLimitResponse DeleteDataLimitWithOptions(DeleteDataLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DeleteDataLimit",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLimitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Revokes the scan permissions on a data asset. The data asset can be a database, an instance, or a bucket.
         *
         * @description You can call this operation to revoke the permissions on a data asset from Data Security Center (DSC).
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteDataLimitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataLimitResponse
         */
        public async Task<DeleteDataLimitResponse> DeleteDataLimitWithOptionsAsync(DeleteDataLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DeleteDataLimit",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataLimitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Revokes the scan permissions on a data asset. The data asset can be a database, an instance, or a bucket.
         *
         * @description You can call this operation to revoke the permissions on a data asset from Data Security Center (DSC).
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteDataLimitRequest
         * @return DeleteDataLimitResponse
         */
        public DeleteDataLimitResponse DeleteDataLimit(DeleteDataLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataLimitWithOptions(request, runtime);
        }

        /**
         * @summary Revokes the scan permissions on a data asset. The data asset can be a database, an instance, or a bucket.
         *
         * @description You can call this operation to revoke the permissions on a data asset from Data Security Center (DSC).
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DeleteDataLimitRequest
         * @return DeleteDataLimitResponse
         */
        public async Task<DeleteDataLimitResponse> DeleteDataLimitAsync(DeleteDataLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataLimitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a custom sensitive data detection rule from Data Security Center (DSC).
         *
         * @param request DeleteRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRuleResponse
         */
        public DeleteRuleResponse DeleteRuleWithOptions(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DeleteRule",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a custom sensitive data detection rule from Data Security Center (DSC).
         *
         * @param request DeleteRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRuleResponse
         */
        public async Task<DeleteRuleResponse> DeleteRuleWithOptionsAsync(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DeleteRule",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a custom sensitive data detection rule from Data Security Center (DSC).
         *
         * @param request DeleteRuleRequest
         * @return DeleteRuleResponse
         */
        public DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a custom sensitive data detection rule from Data Security Center (DSC).
         *
         * @param request DeleteRuleRequest
         * @return DeleteRuleResponse
         */
        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeCategoryTemplateListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCategoryTemplateListResponse
         */
        public DescribeCategoryTemplateListResponse DescribeCategoryTemplateListWithOptions(DescribeCategoryTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageScenario))
            {
                query["UsageScenario"] = request.UsageScenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCategoryTemplateList",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCategoryTemplateListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeCategoryTemplateListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCategoryTemplateListResponse
         */
        public async Task<DescribeCategoryTemplateListResponse> DescribeCategoryTemplateListWithOptionsAsync(DescribeCategoryTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageScenario))
            {
                query["UsageScenario"] = request.UsageScenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCategoryTemplateList",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCategoryTemplateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeCategoryTemplateListRequest
         * @return DescribeCategoryTemplateListResponse
         */
        public DescribeCategoryTemplateListResponse DescribeCategoryTemplateList(DescribeCategoryTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCategoryTemplateListWithOptions(request, runtime);
        }

        /**
         * @param request DescribeCategoryTemplateListRequest
         * @return DescribeCategoryTemplateListResponse
         */
        public async Task<DescribeCategoryTemplateListResponse> DescribeCategoryTemplateListAsync(DescribeCategoryTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCategoryTemplateListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries rules in a classification template by page.
         *
         * @description You can call this operation to query rules in a classification template.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeCategoryTemplateRuleListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCategoryTemplateRuleListResponse
         */
        public DescribeCategoryTemplateRuleListResponse DescribeCategoryTemplateRuleListWithOptions(DescribeCategoryTemplateRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
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
                Action = "DescribeCategoryTemplateRuleList",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCategoryTemplateRuleListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries rules in a classification template by page.
         *
         * @description You can call this operation to query rules in a classification template.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeCategoryTemplateRuleListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCategoryTemplateRuleListResponse
         */
        public async Task<DescribeCategoryTemplateRuleListResponse> DescribeCategoryTemplateRuleListWithOptionsAsync(DescribeCategoryTemplateRuleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
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
                Action = "DescribeCategoryTemplateRuleList",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCategoryTemplateRuleListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries rules in a classification template by page.
         *
         * @description You can call this operation to query rules in a classification template.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeCategoryTemplateRuleListRequest
         * @return DescribeCategoryTemplateRuleListResponse
         */
        public DescribeCategoryTemplateRuleListResponse DescribeCategoryTemplateRuleList(DescribeCategoryTemplateRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCategoryTemplateRuleListWithOptions(request, runtime);
        }

        /**
         * @summary Queries rules in a classification template by page.
         *
         * @description You can call this operation to query rules in a classification template.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeCategoryTemplateRuleListRequest
         * @return DescribeCategoryTemplateRuleListResponse
         */
        public async Task<DescribeCategoryTemplateRuleListResponse> DescribeCategoryTemplateRuleListAsync(DescribeCategoryTemplateRuleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCategoryTemplateRuleListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries data in the columns of the tables that Data Security Center (DSC) is authorized to access. The tables include the tables of MaxCompute and ApsaraDB RDS.
         *
         * @description You can call this operation to query the data in columns of a table that may contain sensitive data. This helps you analyze sensitive data.
         * ## [](#)Precautions
         * The DescribeColumns operation is changed to DescribeColumnsV2. We recommend that you call the DescribeColumnsV2 operation when you develop your applications.
         * ## [](#qps)Limits
         * Each Alibaba Cloud account can call this operation up to 10 times per second. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeColumnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeColumnsResponse
         */
        public DescribeColumnsResponse DescribeColumnsWithOptions(DescribeColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTagId))
            {
                query["ModelTagId"] = request.ModelTagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensLevelName))
            {
                query["SensLevelName"] = request.SensLevelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableId))
            {
                query["TableId"] = request.TableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateRuleId))
            {
                query["TemplateRuleId"] = request.TemplateRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeColumns",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeColumnsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries data in the columns of the tables that Data Security Center (DSC) is authorized to access. The tables include the tables of MaxCompute and ApsaraDB RDS.
         *
         * @description You can call this operation to query the data in columns of a table that may contain sensitive data. This helps you analyze sensitive data.
         * ## [](#)Precautions
         * The DescribeColumns operation is changed to DescribeColumnsV2. We recommend that you call the DescribeColumnsV2 operation when you develop your applications.
         * ## [](#qps)Limits
         * Each Alibaba Cloud account can call this operation up to 10 times per second. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeColumnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeColumnsResponse
         */
        public async Task<DescribeColumnsResponse> DescribeColumnsWithOptionsAsync(DescribeColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTagId))
            {
                query["ModelTagId"] = request.ModelTagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensLevelName))
            {
                query["SensLevelName"] = request.SensLevelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableId))
            {
                query["TableId"] = request.TableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateRuleId))
            {
                query["TemplateRuleId"] = request.TemplateRuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeColumns",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeColumnsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries data in the columns of the tables that Data Security Center (DSC) is authorized to access. The tables include the tables of MaxCompute and ApsaraDB RDS.
         *
         * @description You can call this operation to query the data in columns of a table that may contain sensitive data. This helps you analyze sensitive data.
         * ## [](#)Precautions
         * The DescribeColumns operation is changed to DescribeColumnsV2. We recommend that you call the DescribeColumnsV2 operation when you develop your applications.
         * ## [](#qps)Limits
         * Each Alibaba Cloud account can call this operation up to 10 times per second. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeColumnsRequest
         * @return DescribeColumnsResponse
         */
        public DescribeColumnsResponse DescribeColumns(DescribeColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeColumnsWithOptions(request, runtime);
        }

        /**
         * @summary Queries data in the columns of the tables that Data Security Center (DSC) is authorized to access. The tables include the tables of MaxCompute and ApsaraDB RDS.
         *
         * @description You can call this operation to query the data in columns of a table that may contain sensitive data. This helps you analyze sensitive data.
         * ## [](#)Precautions
         * The DescribeColumns operation is changed to DescribeColumnsV2. We recommend that you call the DescribeColumnsV2 operation when you develop your applications.
         * ## [](#qps)Limits
         * Each Alibaba Cloud account can call this operation up to 10 times per second. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeColumnsRequest
         * @return DescribeColumnsResponse
         */
        public async Task<DescribeColumnsResponse> DescribeColumnsAsync(DescribeColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeColumnsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the columns of tables in instances, such as MaxCompute projects and ApsaraDB RDS instances, that you authorize Data Security Center (DSC) to access.
         *
         * @param request DescribeColumnsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeColumnsV2Response
         */
        public DescribeColumnsV2Response DescribeColumnsV2WithOptions(DescribeColumnsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensLevelName))
            {
                query["SensLevelName"] = request.SensLevelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableId))
            {
                query["TableId"] = request.TableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeColumnsV2",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeColumnsV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the columns of tables in instances, such as MaxCompute projects and ApsaraDB RDS instances, that you authorize Data Security Center (DSC) to access.
         *
         * @param request DescribeColumnsV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeColumnsV2Response
         */
        public async Task<DescribeColumnsV2Response> DescribeColumnsV2WithOptionsAsync(DescribeColumnsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensLevelName))
            {
                query["SensLevelName"] = request.SensLevelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableId))
            {
                query["TableId"] = request.TableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeColumnsV2",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeColumnsV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the columns of tables in instances, such as MaxCompute projects and ApsaraDB RDS instances, that you authorize Data Security Center (DSC) to access.
         *
         * @param request DescribeColumnsV2Request
         * @return DescribeColumnsV2Response
         */
        public DescribeColumnsV2Response DescribeColumnsV2(DescribeColumnsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeColumnsV2WithOptions(request, runtime);
        }

        /**
         * @summary Queries the columns of tables in instances, such as MaxCompute projects and ApsaraDB RDS instances, that you authorize Data Security Center (DSC) to access.
         *
         * @param request DescribeColumnsV2Request
         * @return DescribeColumnsV2Response
         */
        public async Task<DescribeColumnsV2Response> DescribeColumnsV2Async(DescribeColumnsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeColumnsV2WithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries common configuration items for alerts.
         *
         * @param request DescribeConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeConfigsResponse
         */
        public DescribeConfigsResponse DescribeConfigsWithOptions(DescribeConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeConfigs",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries common configuration items for alerts.
         *
         * @param request DescribeConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeConfigsResponse
         */
        public async Task<DescribeConfigsResponse> DescribeConfigsWithOptionsAsync(DescribeConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeConfigs",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries common configuration items for alerts.
         *
         * @param request DescribeConfigsRequest
         * @return DescribeConfigsResponse
         */
        public DescribeConfigsResponse DescribeConfigs(DescribeConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConfigsWithOptions(request, runtime);
        }

        /**
         * @summary Queries common configuration items for alerts.
         *
         * @param request DescribeConfigsRequest
         * @return DescribeConfigsResponse
         */
        public async Task<DescribeConfigsResponse> DescribeConfigsAsync(DescribeConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConfigsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the sensitive data detection results of data assets that Data Security Center (DSC) is authorized to access.
         *
         * @param request DescribeDataAssetsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataAssetsResponse
         */
        public DescribeDataAssetsResponse DescribeDataAssetsWithOptions(DescribeDataAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeId))
            {
                query["RangeId"] = request.RangeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevels))
            {
                query["RiskLevels"] = request.RiskLevels;
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
                Action = "DescribeDataAssets",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataAssetsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the sensitive data detection results of data assets that Data Security Center (DSC) is authorized to access.
         *
         * @param request DescribeDataAssetsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataAssetsResponse
         */
        public async Task<DescribeDataAssetsResponse> DescribeDataAssetsWithOptionsAsync(DescribeDataAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeId))
            {
                query["RangeId"] = request.RangeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevels))
            {
                query["RiskLevels"] = request.RiskLevels;
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
                Action = "DescribeDataAssets",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataAssetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the sensitive data detection results of data assets that Data Security Center (DSC) is authorized to access.
         *
         * @param request DescribeDataAssetsRequest
         * @return DescribeDataAssetsResponse
         */
        public DescribeDataAssetsResponse DescribeDataAssets(DescribeDataAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataAssetsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the sensitive data detection results of data assets that Data Security Center (DSC) is authorized to access.
         *
         * @param request DescribeDataAssetsRequest
         * @return DescribeDataAssetsResponse
         */
        public async Task<DescribeDataAssetsResponse> DescribeDataAssetsAsync(DescribeDataAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataAssetsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a data asset, such as a MaxCompute project, an ApsaraDB RDS database, or an Object Storage Service (OSS) bucket, that you authorize Data Security Center (DSC) to access.
         *
         * @param request DescribeDataLimitDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataLimitDetailResponse
         */
        public DescribeDataLimitDetailResponse DescribeDataLimitDetailWithOptions(DescribeDataLimitDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataLimitDetail",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataLimitDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a data asset, such as a MaxCompute project, an ApsaraDB RDS database, or an Object Storage Service (OSS) bucket, that you authorize Data Security Center (DSC) to access.
         *
         * @param request DescribeDataLimitDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataLimitDetailResponse
         */
        public async Task<DescribeDataLimitDetailResponse> DescribeDataLimitDetailWithOptionsAsync(DescribeDataLimitDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataLimitDetail",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataLimitDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a data asset, such as a MaxCompute project, an ApsaraDB RDS database, or an Object Storage Service (OSS) bucket, that you authorize Data Security Center (DSC) to access.
         *
         * @param request DescribeDataLimitDetailRequest
         * @return DescribeDataLimitDetailResponse
         */
        public DescribeDataLimitDetailResponse DescribeDataLimitDetail(DescribeDataLimitDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataLimitDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a data asset, such as a MaxCompute project, an ApsaraDB RDS database, or an Object Storage Service (OSS) bucket, that you authorize Data Security Center (DSC) to access.
         *
         * @param request DescribeDataLimitDetailRequest
         * @return DescribeDataLimitDetailResponse
         */
        public async Task<DescribeDataLimitDetailResponse> DescribeDataLimitDetailAsync(DescribeDataLimitDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataLimitDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries data assets, such as instances, databases, and Object Storage Service (OSS) buckets, that you authorize Data Security Center (DSC) to scan in a service.
         *
         * @description You can call this operation to query the data assets that are authorized to be scanned. This facilitates resource search and aggregation.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDataLimitSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataLimitSetResponse
         */
        public DescribeDataLimitSetResponse DescribeDataLimitSetWithOptions(DescribeDataLimitSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
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
                Action = "DescribeDataLimitSet",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataLimitSetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries data assets, such as instances, databases, and Object Storage Service (OSS) buckets, that you authorize Data Security Center (DSC) to scan in a service.
         *
         * @description You can call this operation to query the data assets that are authorized to be scanned. This facilitates resource search and aggregation.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDataLimitSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataLimitSetResponse
         */
        public async Task<DescribeDataLimitSetResponse> DescribeDataLimitSetWithOptionsAsync(DescribeDataLimitSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
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
                Action = "DescribeDataLimitSet",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataLimitSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries data assets, such as instances, databases, and Object Storage Service (OSS) buckets, that you authorize Data Security Center (DSC) to scan in a service.
         *
         * @description You can call this operation to query the data assets that are authorized to be scanned. This facilitates resource search and aggregation.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDataLimitSetRequest
         * @return DescribeDataLimitSetResponse
         */
        public DescribeDataLimitSetResponse DescribeDataLimitSet(DescribeDataLimitSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataLimitSetWithOptions(request, runtime);
        }

        /**
         * @summary Queries data assets, such as instances, databases, and Object Storage Service (OSS) buckets, that you authorize Data Security Center (DSC) to scan in a service.
         *
         * @description You can call this operation to query the data assets that are authorized to be scanned. This facilitates resource search and aggregation.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDataLimitSetRequest
         * @return DescribeDataLimitSetResponse
         */
        public async Task<DescribeDataLimitSetResponse> DescribeDataLimitSetAsync(DescribeDataLimitSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataLimitSetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the data assets such as instances, databases, or buckets that Data Security Center (DSC) is authorized to access.
         *
         * @param request DescribeDataLimitsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataLimitsResponse
         */
        public DescribeDataLimitsResponse DescribeDataLimitsWithOptions(DescribeDataLimitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStatus))
            {
                query["CheckStatus"] = request.CheckStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatamaskStatus))
            {
                query["DatamaskStatus"] = request.DatamaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccount))
            {
                query["MemberAccount"] = request.MemberAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
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
                Action = "DescribeDataLimits",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataLimitsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the data assets such as instances, databases, or buckets that Data Security Center (DSC) is authorized to access.
         *
         * @param request DescribeDataLimitsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataLimitsResponse
         */
        public async Task<DescribeDataLimitsResponse> DescribeDataLimitsWithOptionsAsync(DescribeDataLimitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStatus))
            {
                query["CheckStatus"] = request.CheckStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatamaskStatus))
            {
                query["DatamaskStatus"] = request.DatamaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccount))
            {
                query["MemberAccount"] = request.MemberAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
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
                Action = "DescribeDataLimits",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataLimitsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the data assets such as instances, databases, or buckets that Data Security Center (DSC) is authorized to access.
         *
         * @param request DescribeDataLimitsRequest
         * @return DescribeDataLimitsResponse
         */
        public DescribeDataLimitsResponse DescribeDataLimits(DescribeDataLimitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataLimitsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the data assets such as instances, databases, or buckets that Data Security Center (DSC) is authorized to access.
         *
         * @param request DescribeDataLimitsRequest
         * @return DescribeDataLimitsResponse
         */
        public async Task<DescribeDataLimitsResponse> DescribeDataLimitsAsync(DescribeDataLimitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataLimitsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the execution information about a de-identification task.
         *
         * @description You can call this operation to query the execution information of a static de-identification task, including the status and progress.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDataMaskingRunHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataMaskingRunHistoryResponse
         */
        public DescribeDataMaskingRunHistoryResponse DescribeDataMaskingRunHistoryWithOptions(DescribeDataMaskingRunHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstType))
            {
                query["DstType"] = request.DstType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainProcessId))
            {
                query["MainProcessId"] = request.MainProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcTableName))
            {
                query["SrcTableName"] = request.SrcTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcType))
            {
                query["SrcType"] = request.SrcType;
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
                Action = "DescribeDataMaskingRunHistory",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataMaskingRunHistoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the execution information about a de-identification task.
         *
         * @description You can call this operation to query the execution information of a static de-identification task, including the status and progress.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDataMaskingRunHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataMaskingRunHistoryResponse
         */
        public async Task<DescribeDataMaskingRunHistoryResponse> DescribeDataMaskingRunHistoryWithOptionsAsync(DescribeDataMaskingRunHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstType))
            {
                query["DstType"] = request.DstType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MainProcessId))
            {
                query["MainProcessId"] = request.MainProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcTableName))
            {
                query["SrcTableName"] = request.SrcTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcType))
            {
                query["SrcType"] = request.SrcType;
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
                Action = "DescribeDataMaskingRunHistory",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataMaskingRunHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the execution information about a de-identification task.
         *
         * @description You can call this operation to query the execution information of a static de-identification task, including the status and progress.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDataMaskingRunHistoryRequest
         * @return DescribeDataMaskingRunHistoryResponse
         */
        public DescribeDataMaskingRunHistoryResponse DescribeDataMaskingRunHistory(DescribeDataMaskingRunHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataMaskingRunHistoryWithOptions(request, runtime);
        }

        /**
         * @summary Queries the execution information about a de-identification task.
         *
         * @description You can call this operation to query the execution information of a static de-identification task, including the status and progress.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDataMaskingRunHistoryRequest
         * @return DescribeDataMaskingRunHistoryResponse
         */
        public async Task<DescribeDataMaskingRunHistoryResponse> DescribeDataMaskingRunHistoryAsync(DescribeDataMaskingRunHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataMaskingRunHistoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries de-identification tasks.
         *
         * @description You can call this operation to query static de-identification tasks. This facilitates task queries and management.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDataMaskingTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataMaskingTasksResponse
         */
        public DescribeDataMaskingTasksResponse DescribeDataMaskingTasksWithOptions(DescribeDataMaskingTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstType))
            {
                query["DstType"] = request.DstType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
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
                Action = "DescribeDataMaskingTasks",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataMaskingTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries de-identification tasks.
         *
         * @description You can call this operation to query static de-identification tasks. This facilitates task queries and management.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDataMaskingTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataMaskingTasksResponse
         */
        public async Task<DescribeDataMaskingTasksResponse> DescribeDataMaskingTasksWithOptionsAsync(DescribeDataMaskingTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstType))
            {
                query["DstType"] = request.DstType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
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
                Action = "DescribeDataMaskingTasks",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataMaskingTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries de-identification tasks.
         *
         * @description You can call this operation to query static de-identification tasks. This facilitates task queries and management.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDataMaskingTasksRequest
         * @return DescribeDataMaskingTasksResponse
         */
        public DescribeDataMaskingTasksResponse DescribeDataMaskingTasks(DescribeDataMaskingTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataMaskingTasksWithOptions(request, runtime);
        }

        /**
         * @summary Queries de-identification tasks.
         *
         * @description You can call this operation to query static de-identification tasks. This facilitates task queries and management.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDataMaskingTasksRequest
         * @return DescribeDataMaskingTasksResponse
         */
        public async Task<DescribeDataMaskingTasksResponse> DescribeDataMaskingTasksAsync(DescribeDataMaskingTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataMaskingTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看数据对象列详情
         *
         * @param request DescribeDataObjectColumnDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataObjectColumnDetailResponse
         */
        public DescribeDataObjectColumnDetailResponse DescribeDataObjectColumnDetailWithOptions(DescribeDataObjectColumnDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
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
                Action = "DescribeDataObjectColumnDetail",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataObjectColumnDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看数据对象列详情
         *
         * @param request DescribeDataObjectColumnDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataObjectColumnDetailResponse
         */
        public async Task<DescribeDataObjectColumnDetailResponse> DescribeDataObjectColumnDetailWithOptionsAsync(DescribeDataObjectColumnDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
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
                Action = "DescribeDataObjectColumnDetail",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataObjectColumnDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看数据对象列详情
         *
         * @param request DescribeDataObjectColumnDetailRequest
         * @return DescribeDataObjectColumnDetailResponse
         */
        public DescribeDataObjectColumnDetailResponse DescribeDataObjectColumnDetail(DescribeDataObjectColumnDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataObjectColumnDetailWithOptions(request, runtime);
        }

        /**
         * @summary 查看数据对象列详情
         *
         * @param request DescribeDataObjectColumnDetailRequest
         * @return DescribeDataObjectColumnDetailResponse
         */
        public async Task<DescribeDataObjectColumnDetailResponse> DescribeDataObjectColumnDetailAsync(DescribeDataObjectColumnDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataObjectColumnDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看数据对象列详情V2
         *
         * @param request DescribeDataObjectColumnDetailV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataObjectColumnDetailV2Response
         */
        public DescribeDataObjectColumnDetailV2Response DescribeDataObjectColumnDetailV2WithOptions(DescribeDataObjectColumnDetailV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
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
                Action = "DescribeDataObjectColumnDetailV2",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataObjectColumnDetailV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看数据对象列详情V2
         *
         * @param request DescribeDataObjectColumnDetailV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataObjectColumnDetailV2Response
         */
        public async Task<DescribeDataObjectColumnDetailV2Response> DescribeDataObjectColumnDetailV2WithOptionsAsync(DescribeDataObjectColumnDetailV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
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
                Action = "DescribeDataObjectColumnDetailV2",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataObjectColumnDetailV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看数据对象列详情V2
         *
         * @param request DescribeDataObjectColumnDetailV2Request
         * @return DescribeDataObjectColumnDetailV2Response
         */
        public DescribeDataObjectColumnDetailV2Response DescribeDataObjectColumnDetailV2(DescribeDataObjectColumnDetailV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataObjectColumnDetailV2WithOptions(request, runtime);
        }

        /**
         * @summary 查看数据对象列详情V2
         *
         * @param request DescribeDataObjectColumnDetailV2Request
         * @return DescribeDataObjectColumnDetailV2Response
         */
        public async Task<DescribeDataObjectColumnDetailV2Response> DescribeDataObjectColumnDetailV2Async(DescribeDataObjectColumnDetailV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataObjectColumnDetailV2WithOptionsAsync(request, runtime);
        }

        /**
         * @summary 分页查询数据目录对象
         *
         * @param request DescribeDataObjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataObjectsResponse
         */
        public DescribeDataObjectsResponse DescribeDataObjectsWithOptions(DescribeDataObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileCategoryCode))
            {
                query["FileCategoryCode"] = request.FileCategoryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccount))
            {
                query["MemberAccount"] = request.MemberAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelIds))
            {
                query["ModelIds"] = request.ModelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTagIds))
            {
                query["ModelTagIds"] = request.ModelTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCategoryIds))
            {
                query["ParentCategoryIds"] = request.ParentCategoryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                query["ProductIds"] = request.ProductIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryName))
            {
                query["QueryName"] = request.QueryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevels))
            {
                query["RiskLevels"] = request.RiskLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
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
                Action = "DescribeDataObjects",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataObjectsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 分页查询数据目录对象
         *
         * @param request DescribeDataObjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataObjectsResponse
         */
        public async Task<DescribeDataObjectsResponse> DescribeDataObjectsWithOptionsAsync(DescribeDataObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainId))
            {
                query["DomainId"] = request.DomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileCategoryCode))
            {
                query["FileCategoryCode"] = request.FileCategoryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccount))
            {
                query["MemberAccount"] = request.MemberAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelIds))
            {
                query["ModelIds"] = request.ModelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTagIds))
            {
                query["ModelTagIds"] = request.ModelTagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCategoryIds))
            {
                query["ParentCategoryIds"] = request.ParentCategoryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                query["ProductIds"] = request.ProductIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryName))
            {
                query["QueryName"] = request.QueryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevels))
            {
                query["RiskLevels"] = request.RiskLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
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
                Action = "DescribeDataObjects",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataObjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 分页查询数据目录对象
         *
         * @param request DescribeDataObjectsRequest
         * @return DescribeDataObjectsResponse
         */
        public DescribeDataObjectsResponse DescribeDataObjects(DescribeDataObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataObjectsWithOptions(request, runtime);
        }

        /**
         * @summary 分页查询数据目录对象
         *
         * @param request DescribeDataObjectsRequest
         * @return DescribeDataObjectsResponse
         */
        public async Task<DescribeDataObjectsResponse> DescribeDataObjectsAsync(DescribeDataObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataObjectsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDocTypesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDocTypesResponse
         */
        public DescribeDocTypesResponse DescribeDocTypesWithOptions(DescribeDocTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDocTypes",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDocTypesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDocTypesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDocTypesResponse
         */
        public async Task<DescribeDocTypesResponse> DescribeDocTypesWithOptionsAsync(DescribeDocTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DescribeDocTypes",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDocTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDocTypesRequest
         * @return DescribeDocTypesResponse
         */
        public DescribeDocTypesResponse DescribeDocTypes(DescribeDocTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDocTypesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDocTypesRequest
         * @return DescribeDocTypesResponse
         */
        public async Task<DescribeDocTypesResponse> DescribeDocTypesAsync(DescribeDocTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDocTypesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of an anomalous event. The details include the time when the anomalous event occurred, and the description and handling status of the anomalous event.
         *
         * @param request DescribeEventDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEventDetailResponse
         */
        public DescribeEventDetailResponse DescribeEventDetailWithOptions(DescribeEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
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
                Action = "DescribeEventDetail",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an anomalous event. The details include the time when the anomalous event occurred, and the description and handling status of the anomalous event.
         *
         * @param request DescribeEventDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEventDetailResponse
         */
        public async Task<DescribeEventDetailResponse> DescribeEventDetailWithOptionsAsync(DescribeEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
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
                Action = "DescribeEventDetail",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an anomalous event. The details include the time when the anomalous event occurred, and the description and handling status of the anomalous event.
         *
         * @param request DescribeEventDetailRequest
         * @return DescribeEventDetailResponse
         */
        public DescribeEventDetailResponse DescribeEventDetail(DescribeEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of an anomalous event. The details include the time when the anomalous event occurred, and the description and handling status of the anomalous event.
         *
         * @param request DescribeEventDetailRequest
         * @return DescribeEventDetailResponse
         */
        public async Task<DescribeEventDetailResponse> DescribeEventDetailAsync(DescribeEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the types of anomalous events.
         *
         * @param request DescribeEventTypesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEventTypesResponse
         */
        public DescribeEventTypesResponse DescribeEventTypesWithOptions(DescribeEventTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentTypeId))
            {
                query["ParentTypeId"] = request.ParentTypeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Action = "DescribeEventTypes",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventTypesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the types of anomalous events.
         *
         * @param request DescribeEventTypesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEventTypesResponse
         */
        public async Task<DescribeEventTypesResponse> DescribeEventTypesWithOptionsAsync(DescribeEventTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentTypeId))
            {
                query["ParentTypeId"] = request.ParentTypeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Action = "DescribeEventTypes",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the types of anomalous events.
         *
         * @param request DescribeEventTypesRequest
         * @return DescribeEventTypesResponse
         */
        public DescribeEventTypesResponse DescribeEventTypes(DescribeEventTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventTypesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the types of anomalous events.
         *
         * @param request DescribeEventTypesRequest
         * @return DescribeEventTypesResponse
         */
        public async Task<DescribeEventTypesResponse> DescribeEventTypesAsync(DescribeEventTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventTypesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries anomalous events.
         *
         * @description You can call this operation to query anomalous events that may involve data leaks. This helps you search for and handle anomalous events.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeEventsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEventsResponse
         */
        public DescribeEventsResponse DescribeEventsWithOptions(DescribeEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DealUserId))
            {
                query["DealUserId"] = request.DealUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubTypeCode))
            {
                query["SubTypeCode"] = request.SubTypeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetProductCode))
            {
                query["TargetProductCode"] = request.TargetProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeCode))
            {
                query["TypeCode"] = request.TypeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarnLevel))
            {
                query["WarnLevel"] = request.WarnLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEvents",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries anomalous events.
         *
         * @description You can call this operation to query anomalous events that may involve data leaks. This helps you search for and handle anomalous events.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeEventsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEventsResponse
         */
        public async Task<DescribeEventsResponse> DescribeEventsWithOptionsAsync(DescribeEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DealUserId))
            {
                query["DealUserId"] = request.DealUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubTypeCode))
            {
                query["SubTypeCode"] = request.SubTypeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetProductCode))
            {
                query["TargetProductCode"] = request.TargetProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeCode))
            {
                query["TypeCode"] = request.TypeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarnLevel))
            {
                query["WarnLevel"] = request.WarnLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEvents",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries anomalous events.
         *
         * @description You can call this operation to query anomalous events that may involve data leaks. This helps you search for and handle anomalous events.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeEventsRequest
         * @return DescribeEventsResponse
         */
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventsWithOptions(request, runtime);
        }

        /**
         * @summary Queries anomalous events.
         *
         * @description You can call this operation to query anomalous events that may involve data leaks. This helps you search for and handle anomalous events.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeEventsRequest
         * @return DescribeEventsResponse
         */
        public async Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of data assets.
         *
         * @description You can query a list of unauthorized or authorized data assets based on the value of AuthStatus.
         * This operation is no longer used for the KMS console of the new version.
         * # [](#qps-)QPS limits
         * This operation can be called up to 10 times per second for each Alibaba Cloud account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceSourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceSourcesResponse
         */
        public DescribeInstanceSourcesResponse DescribeInstanceSourcesWithOptions(DescribeInstanceSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthStatus))
            {
                query["AuthStatus"] = request.AuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["SearchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceSources",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of data assets.
         *
         * @description You can query a list of unauthorized or authorized data assets based on the value of AuthStatus.
         * This operation is no longer used for the KMS console of the new version.
         * # [](#qps-)QPS limits
         * This operation can be called up to 10 times per second for each Alibaba Cloud account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceSourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceSourcesResponse
         */
        public async Task<DescribeInstanceSourcesResponse> DescribeInstanceSourcesWithOptionsAsync(DescribeInstanceSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthStatus))
            {
                query["AuthStatus"] = request.AuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                query["SearchKey"] = request.SearchKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["SearchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceSources",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of data assets.
         *
         * @description You can query a list of unauthorized or authorized data assets based on the value of AuthStatus.
         * This operation is no longer used for the KMS console of the new version.
         * # [](#qps-)QPS limits
         * This operation can be called up to 10 times per second for each Alibaba Cloud account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceSourcesRequest
         * @return DescribeInstanceSourcesResponse
         */
        public DescribeInstanceSourcesResponse DescribeInstanceSources(DescribeInstanceSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSourcesWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of data assets.
         *
         * @description You can query a list of unauthorized or authorized data assets based on the value of AuthStatus.
         * This operation is no longer used for the KMS console of the new version.
         * # [](#qps-)QPS limits
         * This operation can be called up to 10 times per second for each Alibaba Cloud account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceSourcesRequest
         * @return DescribeInstanceSourcesResponse
         */
        public async Task<DescribeInstanceSourcesResponse> DescribeInstanceSourcesAsync(DescribeInstanceSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries data assets such as MaxCompute, ApsaraDB RDS, and Object Storage Service (OSS) that you authorize Data Security Center (DSC) to access.
         *
         * @description When you call the DescribeInstances operation, you can specify parameters such as Name and RiskLevelId to query data assets that meet filter conditions.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstancesResponse
         */
        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries data assets such as MaxCompute, ApsaraDB RDS, and Object Storage Service (OSS) that you authorize Data Security Center (DSC) to access.
         *
         * @description When you call the DescribeInstances operation, you can specify parameters such as Name and RiskLevelId to query data assets that meet filter conditions.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstancesResponse
         */
        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries data assets such as MaxCompute, ApsaraDB RDS, and Object Storage Service (OSS) that you authorize Data Security Center (DSC) to access.
         *
         * @description When you call the DescribeInstances operation, you can specify parameters such as Name and RiskLevelId to query data assets that meet filter conditions.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstancesRequest
         * @return DescribeInstancesResponse
         */
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Queries data assets such as MaxCompute, ApsaraDB RDS, and Object Storage Service (OSS) that you authorize Data Security Center (DSC) to access.
         *
         * @description When you call the DescribeInstances operation, you can specify parameters such as Name and RiskLevelId to query data assets that meet filter conditions.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstancesRequest
         * @return DescribeInstancesResponse
         */
        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of an Object Storage Service (OSS) object that Data Security Center (DSC) is authorized to access.
         *
         * @description You can call this operation to query the details of an Object Storage Service (OSS) object. This helps you locate sensitive data detected in OSS.
         * ## [](#)Precautions
         * The DescribeOssObjectDetail operation is chagned to DescribeOssObjectDetailV2. We recommend that you call the DescribeOssObjectDetailV2 operation when you develop your applications.
         * ## [](#qps)Limits
         * Each Alibaba Cloud account can call this operation up to 10 times per second. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeOssObjectDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOssObjectDetailResponse
         */
        public DescribeOssObjectDetailResponse DescribeOssObjectDetailWithOptions(DescribeOssObjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
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
                Action = "DescribeOssObjectDetail",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssObjectDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an Object Storage Service (OSS) object that Data Security Center (DSC) is authorized to access.
         *
         * @description You can call this operation to query the details of an Object Storage Service (OSS) object. This helps you locate sensitive data detected in OSS.
         * ## [](#)Precautions
         * The DescribeOssObjectDetail operation is chagned to DescribeOssObjectDetailV2. We recommend that you call the DescribeOssObjectDetailV2 operation when you develop your applications.
         * ## [](#qps)Limits
         * Each Alibaba Cloud account can call this operation up to 10 times per second. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeOssObjectDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOssObjectDetailResponse
         */
        public async Task<DescribeOssObjectDetailResponse> DescribeOssObjectDetailWithOptionsAsync(DescribeOssObjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
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
                Action = "DescribeOssObjectDetail",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssObjectDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of an Object Storage Service (OSS) object that Data Security Center (DSC) is authorized to access.
         *
         * @description You can call this operation to query the details of an Object Storage Service (OSS) object. This helps you locate sensitive data detected in OSS.
         * ## [](#)Precautions
         * The DescribeOssObjectDetail operation is chagned to DescribeOssObjectDetailV2. We recommend that you call the DescribeOssObjectDetailV2 operation when you develop your applications.
         * ## [](#qps)Limits
         * Each Alibaba Cloud account can call this operation up to 10 times per second. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeOssObjectDetailRequest
         * @return DescribeOssObjectDetailResponse
         */
        public DescribeOssObjectDetailResponse DescribeOssObjectDetail(DescribeOssObjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssObjectDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of an Object Storage Service (OSS) object that Data Security Center (DSC) is authorized to access.
         *
         * @description You can call this operation to query the details of an Object Storage Service (OSS) object. This helps you locate sensitive data detected in OSS.
         * ## [](#)Precautions
         * The DescribeOssObjectDetail operation is chagned to DescribeOssObjectDetailV2. We recommend that you call the DescribeOssObjectDetailV2 operation when you develop your applications.
         * ## [](#qps)Limits
         * Each Alibaba Cloud account can call this operation up to 10 times per second. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeOssObjectDetailRequest
         * @return DescribeOssObjectDetailResponse
         */
        public async Task<DescribeOssObjectDetailResponse> DescribeOssObjectDetailAsync(DescribeOssObjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssObjectDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用本接口查询数据安全中心连接授权的OSS的单个存储对象的详细信息
         *
         * @param request DescribeOssObjectDetailV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOssObjectDetailV2Response
         */
        public DescribeOssObjectDetailV2Response DescribeOssObjectDetailV2WithOptions(DescribeOssObjectDetailV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
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
                Action = "DescribeOssObjectDetailV2",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssObjectDetailV2Response>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 调用本接口查询数据安全中心连接授权的OSS的单个存储对象的详细信息
         *
         * @param request DescribeOssObjectDetailV2Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOssObjectDetailV2Response
         */
        public async Task<DescribeOssObjectDetailV2Response> DescribeOssObjectDetailV2WithOptionsAsync(DescribeOssObjectDetailV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKey))
            {
                query["ObjectKey"] = request.ObjectKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
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
                Action = "DescribeOssObjectDetailV2",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssObjectDetailV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 调用本接口查询数据安全中心连接授权的OSS的单个存储对象的详细信息
         *
         * @param request DescribeOssObjectDetailV2Request
         * @return DescribeOssObjectDetailV2Response
         */
        public DescribeOssObjectDetailV2Response DescribeOssObjectDetailV2(DescribeOssObjectDetailV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssObjectDetailV2WithOptions(request, runtime);
        }

        /**
         * @summary 调用本接口查询数据安全中心连接授权的OSS的单个存储对象的详细信息
         *
         * @param request DescribeOssObjectDetailV2Request
         * @return DescribeOssObjectDetailV2Response
         */
        public async Task<DescribeOssObjectDetailV2Response> DescribeOssObjectDetailV2Async(DescribeOssObjectDetailV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssObjectDetailV2WithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries Object Storage Service (OSS) objects that you authorize Data Security Center (DSC) to access.
         *
         * @param request DescribeOssObjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOssObjectsResponse
         */
        public DescribeOssObjectsResponse DescribeOssObjectsWithOptions(DescribeOssObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileCategoryCode))
            {
                query["FileCategoryCode"] = request.FileCategoryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastScanTimeEnd))
            {
                query["LastScanTimeEnd"] = request.LastScanTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastScanTimeStart))
            {
                query["LastScanTimeStart"] = request.LastScanTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
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
                Action = "DescribeOssObjects",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssObjectsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries Object Storage Service (OSS) objects that you authorize Data Security Center (DSC) to access.
         *
         * @param request DescribeOssObjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeOssObjectsResponse
         */
        public async Task<DescribeOssObjectsResponse> DescribeOssObjectsWithOptionsAsync(DescribeOssObjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileCategoryCode))
            {
                query["FileCategoryCode"] = request.FileCategoryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastScanTimeEnd))
            {
                query["LastScanTimeEnd"] = request.LastScanTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastScanTimeStart))
            {
                query["LastScanTimeStart"] = request.LastScanTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
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
                Action = "DescribeOssObjects",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssObjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries Object Storage Service (OSS) objects that you authorize Data Security Center (DSC) to access.
         *
         * @param request DescribeOssObjectsRequest
         * @return DescribeOssObjectsResponse
         */
        public DescribeOssObjectsResponse DescribeOssObjects(DescribeOssObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssObjectsWithOptions(request, runtime);
        }

        /**
         * @summary Queries Object Storage Service (OSS) objects that you authorize Data Security Center (DSC) to access.
         *
         * @param request DescribeOssObjectsRequest
         * @return DescribeOssObjectsResponse
         */
        public async Task<DescribeOssObjectsResponse> DescribeOssObjectsAsync(DescribeOssObjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssObjectsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries information about the MaxCompute packages that Data Security Center (DSC) is authorized to access. The information includes the names of MaxCompute packages, the accounts of MaxCompute package owners, and the sensitivity levels of MaxCompute packages.
         *
         * @description You can call this operation to query MaxCompute packages that are scanned by DSC. This helps you search for MaxCompute packages and view the summary of MaxCompute packages.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribePackagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePackagesResponse
         */
        public DescribePackagesResponse DescribePackagesWithOptions(DescribePackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
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
                Action = "DescribePackages",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePackagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries information about the MaxCompute packages that Data Security Center (DSC) is authorized to access. The information includes the names of MaxCompute packages, the accounts of MaxCompute package owners, and the sensitivity levels of MaxCompute packages.
         *
         * @description You can call this operation to query MaxCompute packages that are scanned by DSC. This helps you search for MaxCompute packages and view the summary of MaxCompute packages.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribePackagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePackagesResponse
         */
        public async Task<DescribePackagesResponse> DescribePackagesWithOptionsAsync(DescribePackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
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
                Action = "DescribePackages",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePackagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries information about the MaxCompute packages that Data Security Center (DSC) is authorized to access. The information includes the names of MaxCompute packages, the accounts of MaxCompute package owners, and the sensitivity levels of MaxCompute packages.
         *
         * @description You can call this operation to query MaxCompute packages that are scanned by DSC. This helps you search for MaxCompute packages and view the summary of MaxCompute packages.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribePackagesRequest
         * @return DescribePackagesResponse
         */
        public DescribePackagesResponse DescribePackages(DescribePackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePackagesWithOptions(request, runtime);
        }

        /**
         * @summary Queries information about the MaxCompute packages that Data Security Center (DSC) is authorized to access. The information includes the names of MaxCompute packages, the accounts of MaxCompute package owners, and the sensitivity levels of MaxCompute packages.
         *
         * @description You can call this operation to query MaxCompute packages that are scanned by DSC. This helps you search for MaxCompute packages and view the summary of MaxCompute packages.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribePackagesRequest
         * @return DescribePackagesResponse
         */
        public async Task<DescribePackagesResponse> DescribePackagesAsync(DescribePackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePackagesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取一级授权列表
         *
         * @param request DescribeParentInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeParentInstanceResponse
         */
        public DescribeParentInstanceResponse DescribeParentInstanceWithOptions(DescribeParentInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthStatus))
            {
                query["AuthStatus"] = request.AuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStatus))
            {
                query["CheckStatus"] = request.CheckStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterStatus))
            {
                query["ClusterStatus"] = request.ClusterStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccount))
            {
                query["MemberAccount"] = request.MemberAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParentInstance",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParentInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取一级授权列表
         *
         * @param request DescribeParentInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeParentInstanceResponse
         */
        public async Task<DescribeParentInstanceResponse> DescribeParentInstanceWithOptionsAsync(DescribeParentInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthStatus))
            {
                query["AuthStatus"] = request.AuthStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckStatus))
            {
                query["CheckStatus"] = request.CheckStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterStatus))
            {
                query["ClusterStatus"] = request.ClusterStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberAccount))
            {
                query["MemberAccount"] = request.MemberAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeParentInstance",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeParentInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取一级授权列表
         *
         * @param request DescribeParentInstanceRequest
         * @return DescribeParentInstanceResponse
         */
        public DescribeParentInstanceResponse DescribeParentInstance(DescribeParentInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeParentInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 获取一级授权列表
         *
         * @param request DescribeParentInstanceRequest
         * @return DescribeParentInstanceResponse
         */
        public async Task<DescribeParentInstanceResponse> DescribeParentInstanceAsync(DescribeParentInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeParentInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the sensitivity levels that are defined in a rule template provided by Data Security Center (DSC).
         *
         * @description You can call this operation to query the sensitivity levels that are defined in the current rule template provided by DSC. This helps you learn about the number of times that each sensitivity level is referenced in the rule template and the highest sensitivity level.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeRiskLevelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRiskLevelsResponse
         */
        public DescribeRiskLevelsResponse DescribeRiskLevelsWithOptions(DescribeRiskLevelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeRiskLevels",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRiskLevelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the sensitivity levels that are defined in a rule template provided by Data Security Center (DSC).
         *
         * @description You can call this operation to query the sensitivity levels that are defined in the current rule template provided by DSC. This helps you learn about the number of times that each sensitivity level is referenced in the rule template and the highest sensitivity level.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeRiskLevelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRiskLevelsResponse
         */
        public async Task<DescribeRiskLevelsResponse> DescribeRiskLevelsWithOptionsAsync(DescribeRiskLevelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeRiskLevels",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRiskLevelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the sensitivity levels that are defined in a rule template provided by Data Security Center (DSC).
         *
         * @description You can call this operation to query the sensitivity levels that are defined in the current rule template provided by DSC. This helps you learn about the number of times that each sensitivity level is referenced in the rule template and the highest sensitivity level.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeRiskLevelsRequest
         * @return DescribeRiskLevelsResponse
         */
        public DescribeRiskLevelsResponse DescribeRiskLevels(DescribeRiskLevelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRiskLevelsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the sensitivity levels that are defined in a rule template provided by Data Security Center (DSC).
         *
         * @description You can call this operation to query the sensitivity levels that are defined in the current rule template provided by DSC. This helps you learn about the number of times that each sensitivity level is referenced in the rule template and the highest sensitivity level.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeRiskLevelsRequest
         * @return DescribeRiskLevelsResponse
         */
        public async Task<DescribeRiskLevelsResponse> DescribeRiskLevelsAsync(DescribeRiskLevelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRiskLevelsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries sensitive data detection rules.
         *
         * @param request DescribeRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRulesResponse
         */
        public DescribeRulesResponse DescribeRulesWithOptions(DescribeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentCategory))
            {
                query["ContentCategory"] = request.ContentCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomType))
            {
                query["CustomType"] = request.CustomType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordCompatible))
            {
                query["KeywordCompatible"] = request.KeywordCompatible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportForm))
            {
                query["SupportForm"] = request.SupportForm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarnLevel))
            {
                query["WarnLevel"] = request.WarnLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRules",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries sensitive data detection rules.
         *
         * @param request DescribeRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRulesResponse
         */
        public async Task<DescribeRulesResponse> DescribeRulesWithOptionsAsync(DescribeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentCategory))
            {
                query["ContentCategory"] = request.ContentCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomType))
            {
                query["CustomType"] = request.CustomType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeywordCompatible))
            {
                query["KeywordCompatible"] = request.KeywordCompatible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportForm))
            {
                query["SupportForm"] = request.SupportForm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarnLevel))
            {
                query["WarnLevel"] = request.WarnLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRules",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries sensitive data detection rules.
         *
         * @param request DescribeRulesRequest
         * @return DescribeRulesResponse
         */
        public DescribeRulesResponse DescribeRules(DescribeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRulesWithOptions(request, runtime);
        }

        /**
         * @summary Queries sensitive data detection rules.
         *
         * @param request DescribeRulesRequest
         * @return DescribeRulesResponse
         */
        public async Task<DescribeRulesResponse> DescribeRulesAsync(DescribeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries tables in data assets, such as MaxCompute projects and ApsaraDB RDS instances, that you authorize Data Security Center (DSC) to access.
         *
         * @description When you call the DescribeTables operation to query tables, you can specify parameters such as Name and RiskLevelId to filter tables.
         * # Limits
         * You can send up to 10 requests per second to call this operation by using your Alibaba Cloud account. If you send excessive requests, throttling is implemented, and your business may be affected.
         *
         * @param request DescribeTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTablesResponse
         */
        public DescribeTablesResponse DescribeTablesWithOptions(DescribeTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                query["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
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
                Action = "DescribeTables",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries tables in data assets, such as MaxCompute projects and ApsaraDB RDS instances, that you authorize Data Security Center (DSC) to access.
         *
         * @description When you call the DescribeTables operation to query tables, you can specify parameters such as Name and RiskLevelId to filter tables.
         * # Limits
         * You can send up to 10 requests per second to call this operation by using your Alibaba Cloud account. If you send excessive requests, throttling is implemented, and your business may be affected.
         *
         * @param request DescribeTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTablesResponse
         */
        public async Task<DescribeTablesResponse> DescribeTablesWithOptionsAsync(DescribeTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageId))
            {
                query["PackageId"] = request.PackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
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
                Action = "DescribeTables",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries tables in data assets, such as MaxCompute projects and ApsaraDB RDS instances, that you authorize Data Security Center (DSC) to access.
         *
         * @description When you call the DescribeTables operation to query tables, you can specify parameters such as Name and RiskLevelId to filter tables.
         * # Limits
         * You can send up to 10 requests per second to call this operation by using your Alibaba Cloud account. If you send excessive requests, throttling is implemented, and your business may be affected.
         *
         * @param request DescribeTablesRequest
         * @return DescribeTablesResponse
         */
        public DescribeTablesResponse DescribeTables(DescribeTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTablesWithOptions(request, runtime);
        }

        /**
         * @summary Queries tables in data assets, such as MaxCompute projects and ApsaraDB RDS instances, that you authorize Data Security Center (DSC) to access.
         *
         * @description When you call the DescribeTables operation to query tables, you can specify parameters such as Name and RiskLevelId to filter tables.
         * # Limits
         * You can send up to 10 requests per second to call this operation by using your Alibaba Cloud account. If you send excessive requests, throttling is implemented, and your business may be affected.
         *
         * @param request DescribeTablesRequest
         * @return DescribeTablesResponse
         */
        public async Task<DescribeTablesResponse> DescribeTablesAsync(DescribeTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTablesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeTemplateAllRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTemplateAllRulesResponse
         */
        public DescribeTemplateAllRulesResponse DescribeTemplateAllRulesWithOptions(DescribeTemplateAllRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeTemplateAllRules",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTemplateAllRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeTemplateAllRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTemplateAllRulesResponse
         */
        public async Task<DescribeTemplateAllRulesResponse> DescribeTemplateAllRulesWithOptionsAsync(DescribeTemplateAllRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeTemplateAllRules",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTemplateAllRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeTemplateAllRulesRequest
         * @return DescribeTemplateAllRulesResponse
         */
        public DescribeTemplateAllRulesResponse DescribeTemplateAllRules(DescribeTemplateAllRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTemplateAllRulesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeTemplateAllRulesRequest
         * @return DescribeTemplateAllRulesResponse
         */
        public async Task<DescribeTemplateAllRulesResponse> DescribeTemplateAllRulesAsync(DescribeTemplateAllRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTemplateAllRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about an account.
         *
         * @description You can call this operation to query the information about the current account. This helps you get familiar with your account that accesses Data Security Center (DSC).
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeUserStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserStatusResponse
         */
        public DescribeUserStatusResponse DescribeUserStatusWithOptions(DescribeUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
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
                Action = "DescribeUserStatus",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an account.
         *
         * @description You can call this operation to query the information about the current account. This helps you get familiar with your account that accesses Data Security Center (DSC).
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeUserStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserStatusResponse
         */
        public async Task<DescribeUserStatusResponse> DescribeUserStatusWithOptionsAsync(DescribeUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
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
                Action = "DescribeUserStatus",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about an account.
         *
         * @description You can call this operation to query the information about the current account. This helps you get familiar with your account that accesses Data Security Center (DSC).
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeUserStatusRequest
         * @return DescribeUserStatusResponse
         */
        public DescribeUserStatusResponse DescribeUserStatus(DescribeUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about an account.
         *
         * @description You can call this operation to query the information about the current account. This helps you get familiar with your account that accesses Data Security Center (DSC).
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeUserStatusRequest
         * @return DescribeUserStatusResponse
         */
        public async Task<DescribeUserStatusResponse> DescribeUserStatusAsync(DescribeUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Disables a configuration item. After you disable a configuration item, you can call the CreateConfig operation to enable the configuration item by specifying the code of the configuration item for the Code parameter in the request.
         *
         * @description You can call this operation to disable a configuration item based on the code of the configuration item. This helps you modify configurations at the earliest opportunity.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DisableUserConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableUserConfigResponse
         */
        public DisableUserConfigResponse DisableUserConfigWithOptions(DisableUserConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
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
                Action = "DisableUserConfig",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableUserConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Disables a configuration item. After you disable a configuration item, you can call the CreateConfig operation to enable the configuration item by specifying the code of the configuration item for the Code parameter in the request.
         *
         * @description You can call this operation to disable a configuration item based on the code of the configuration item. This helps you modify configurations at the earliest opportunity.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DisableUserConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableUserConfigResponse
         */
        public async Task<DisableUserConfigResponse> DisableUserConfigWithOptionsAsync(DisableUserConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
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
                Action = "DisableUserConfig",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableUserConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Disables a configuration item. After you disable a configuration item, you can call the CreateConfig operation to enable the configuration item by specifying the code of the configuration item for the Code parameter in the request.
         *
         * @description You can call this operation to disable a configuration item based on the code of the configuration item. This helps you modify configurations at the earliest opportunity.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DisableUserConfigRequest
         * @return DisableUserConfigResponse
         */
        public DisableUserConfigResponse DisableUserConfig(DisableUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableUserConfigWithOptions(request, runtime);
        }

        /**
         * @summary Disables a configuration item. After you disable a configuration item, you can call the CreateConfig operation to enable the configuration item by specifying the code of the configuration item for the Code parameter in the request.
         *
         * @description You can call this operation to disable a configuration item based on the code of the configuration item. This helps you modify configurations at the earliest opportunity.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DisableUserConfigRequest
         * @return DisableUserConfigResponse
         */
        public async Task<DisableUserConfigResponse> DisableUserConfigAsync(DisableUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableUserConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Dynamically de-identifies sensitive data.
         *
         * @param request ExecDatamaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecDatamaskResponse
         */
        public ExecDatamaskResponse ExecDatamaskWithOptions(ExecDatamaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "ExecDatamask",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDatamaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Dynamically de-identifies sensitive data.
         *
         * @param request ExecDatamaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecDatamaskResponse
         */
        public async Task<ExecDatamaskResponse> ExecDatamaskWithOptionsAsync(ExecDatamaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "ExecDatamask",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecDatamaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Dynamically de-identifies sensitive data.
         *
         * @param request ExecDatamaskRequest
         * @return ExecDatamaskResponse
         */
        public ExecDatamaskResponse ExecDatamask(ExecDatamaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecDatamaskWithOptions(request, runtime);
        }

        /**
         * @summary Dynamically de-identifies sensitive data.
         *
         * @param request ExecDatamaskRequest
         * @return ExecDatamaskResponse
         */
        public async Task<ExecDatamaskResponse> ExecDatamaskAsync(ExecDatamaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecDatamaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Triggers a de-identification task.
         *
         * @param request ManualTriggerMaskingProcessRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManualTriggerMaskingProcessResponse
         */
        public ManualTriggerMaskingProcessResponse ManualTriggerMaskingProcessWithOptions(ManualTriggerMaskingProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
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
                Action = "ManualTriggerMaskingProcess",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManualTriggerMaskingProcessResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Triggers a de-identification task.
         *
         * @param request ManualTriggerMaskingProcessRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ManualTriggerMaskingProcessResponse
         */
        public async Task<ManualTriggerMaskingProcessResponse> ManualTriggerMaskingProcessWithOptionsAsync(ManualTriggerMaskingProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
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
                Action = "ManualTriggerMaskingProcess",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManualTriggerMaskingProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Triggers a de-identification task.
         *
         * @param request ManualTriggerMaskingProcessRequest
         * @return ManualTriggerMaskingProcessResponse
         */
        public ManualTriggerMaskingProcessResponse ManualTriggerMaskingProcess(ManualTriggerMaskingProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ManualTriggerMaskingProcessWithOptions(request, runtime);
        }

        /**
         * @summary Triggers a de-identification task.
         *
         * @param request ManualTriggerMaskingProcessRequest
         * @return ManualTriggerMaskingProcessResponse
         */
        public async Task<ManualTriggerMaskingProcessResponse> ManualTriggerMaskingProcessAsync(ManualTriggerMaskingProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ManualTriggerMaskingProcessWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies configuration items for a data asset that you authorize Data Security Center (DSC) to access.
         *
         * @param request ModifyDataLimitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDataLimitResponse
         */
        public ModifyDataLimitResponse ModifyDataLimitWithOptions(ModifyDataLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScan))
            {
                query["AutoScan"] = request.AutoScan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreDay))
            {
                query["LogStoreDay"] = request.LogStoreDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyPassword))
            {
                query["ModifyPassword"] = request.ModifyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingSize))
            {
                query["SamplingSize"] = request.SamplingSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupIdList))
            {
                query["SecurityGroupIdList"] = request.SecurityGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdList))
            {
                query["VSwitchIdList"] = request.VSwitchIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataLimit",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataLimitResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies configuration items for a data asset that you authorize Data Security Center (DSC) to access.
         *
         * @param request ModifyDataLimitRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDataLimitResponse
         */
        public async Task<ModifyDataLimitResponse> ModifyDataLimitWithOptionsAsync(ModifyDataLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScan))
            {
                query["AutoScan"] = request.AutoScan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreDay))
            {
                query["LogStoreDay"] = request.LogStoreDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyPassword))
            {
                query["ModifyPassword"] = request.ModifyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingSize))
            {
                query["SamplingSize"] = request.SamplingSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupIdList))
            {
                query["SecurityGroupIdList"] = request.SecurityGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdList))
            {
                query["VSwitchIdList"] = request.VSwitchIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDataLimit",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDataLimitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies configuration items for a data asset that you authorize Data Security Center (DSC) to access.
         *
         * @param request ModifyDataLimitRequest
         * @return ModifyDataLimitResponse
         */
        public ModifyDataLimitResponse ModifyDataLimit(ModifyDataLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDataLimitWithOptions(request, runtime);
        }

        /**
         * @summary Modifies configuration items for a data asset that you authorize Data Security Center (DSC) to access.
         *
         * @param request ModifyDataLimitRequest
         * @return ModifyDataLimitResponse
         */
        public async Task<ModifyDataLimitResponse> ModifyDataLimitAsync(ModifyDataLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDataLimitWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the sensitivity levels of sensitive data. You can change the default sensitivity levels of data that cannot be classified as sensitive or insensitive, and the sensitivity levels of data that can be classified as sensitive.
         *
         * @description You can call this operation to modify the sensitivity levels of data. This helps you manage the sensitivity levels.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyDefaultLevelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefaultLevelResponse
         */
        public ModifyDefaultLevelResponse ModifyDefaultLevelWithOptions(ModifyDefaultLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultId))
            {
                query["DefaultId"] = request.DefaultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveIds))
            {
                query["SensitiveIds"] = request.SensitiveIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDefaultLevel",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefaultLevelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the sensitivity levels of sensitive data. You can change the default sensitivity levels of data that cannot be classified as sensitive or insensitive, and the sensitivity levels of data that can be classified as sensitive.
         *
         * @description You can call this operation to modify the sensitivity levels of data. This helps you manage the sensitivity levels.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyDefaultLevelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefaultLevelResponse
         */
        public async Task<ModifyDefaultLevelResponse> ModifyDefaultLevelWithOptionsAsync(ModifyDefaultLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultId))
            {
                query["DefaultId"] = request.DefaultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SensitiveIds))
            {
                query["SensitiveIds"] = request.SensitiveIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDefaultLevel",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefaultLevelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the sensitivity levels of sensitive data. You can change the default sensitivity levels of data that cannot be classified as sensitive or insensitive, and the sensitivity levels of data that can be classified as sensitive.
         *
         * @description You can call this operation to modify the sensitivity levels of data. This helps you manage the sensitivity levels.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyDefaultLevelRequest
         * @return ModifyDefaultLevelResponse
         */
        public ModifyDefaultLevelResponse ModifyDefaultLevel(ModifyDefaultLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefaultLevelWithOptions(request, runtime);
        }

        /**
         * @summary Changes the sensitivity levels of sensitive data. You can change the default sensitivity levels of data that cannot be classified as sensitive or insensitive, and the sensitivity levels of data that can be classified as sensitive.
         *
         * @description You can call this operation to modify the sensitivity levels of data. This helps you manage the sensitivity levels.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyDefaultLevelRequest
         * @return ModifyDefaultLevelResponse
         */
        public async Task<ModifyDefaultLevelResponse> ModifyDefaultLevelAsync(ModifyDefaultLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefaultLevelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Handles an anomalous event.
         *
         * @description You can call this operation to handle anomalous events that involve data leaks. This helps protect your data assets at the earliest opportunity.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyEventStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyEventStatusResponse
         */
        public ModifyEventStatusResponse ModifyEventStatusWithOptions(ModifyEventStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backed))
            {
                query["Backed"] = request.Backed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DealReason))
            {
                query["DealReason"] = request.DealReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "ModifyEventStatus",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyEventStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Handles an anomalous event.
         *
         * @description You can call this operation to handle anomalous events that involve data leaks. This helps protect your data assets at the earliest opportunity.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyEventStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyEventStatusResponse
         */
        public async Task<ModifyEventStatusResponse> ModifyEventStatusWithOptionsAsync(ModifyEventStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Backed))
            {
                query["Backed"] = request.Backed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DealReason))
            {
                query["DealReason"] = request.DealReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "ModifyEventStatus",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyEventStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Handles an anomalous event.
         *
         * @description You can call this operation to handle anomalous events that involve data leaks. This helps protect your data assets at the earliest opportunity.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyEventStatusRequest
         * @return ModifyEventStatusResponse
         */
        public ModifyEventStatusResponse ModifyEventStatus(ModifyEventStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEventStatusWithOptions(request, runtime);
        }

        /**
         * @summary Handles an anomalous event.
         *
         * @description You can call this operation to handle anomalous events that involve data leaks. This helps protect your data assets at the earliest opportunity.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyEventStatusRequest
         * @return ModifyEventStatusResponse
         */
        public async Task<ModifyEventStatusResponse> ModifyEventStatusAsync(ModifyEventStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEventStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables the detection of anomalous events of subtypes.
         *
         * @param request ModifyEventTypeStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyEventTypeStatusResponse
         */
        public ModifyEventTypeStatusResponse ModifyEventTypeStatusWithOptions(ModifyEventTypeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubTypeIds))
            {
                query["SubTypeIds"] = request.SubTypeIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyEventTypeStatus",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyEventTypeStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables the detection of anomalous events of subtypes.
         *
         * @param request ModifyEventTypeStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyEventTypeStatusResponse
         */
        public async Task<ModifyEventTypeStatusResponse> ModifyEventTypeStatusWithOptionsAsync(ModifyEventTypeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubTypeIds))
            {
                query["SubTypeIds"] = request.SubTypeIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyEventTypeStatus",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyEventTypeStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables the detection of anomalous events of subtypes.
         *
         * @param request ModifyEventTypeStatusRequest
         * @return ModifyEventTypeStatusResponse
         */
        public ModifyEventTypeStatusResponse ModifyEventTypeStatus(ModifyEventTypeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEventTypeStatusWithOptions(request, runtime);
        }

        /**
         * @summary Enables the detection of anomalous events of subtypes.
         *
         * @param request ModifyEventTypeStatusRequest
         * @return ModifyEventTypeStatusResponse
         */
        public async Task<ModifyEventTypeStatusResponse> ModifyEventTypeStatusAsync(ModifyEventTypeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEventTypeStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables the report task.
         *
         * @description You can call this operation to enable or disable the report task. After you activate Data Security Center (DSC), the report task is enabled by default. After you disable the report task, you cannot view statistics that are newly generated in the Report Center module, on the Overview page of the Cloud Native Data Audit module, and in the Data security lab module. Existing statistics are not affected.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyReportTaskStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyReportTaskStatusResponse
         */
        public ModifyReportTaskStatusResponse ModifyReportTaskStatusWithOptions(ModifyReportTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportTaskStatus))
            {
                query["ReportTaskStatus"] = request.ReportTaskStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyReportTaskStatus",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyReportTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or disables the report task.
         *
         * @description You can call this operation to enable or disable the report task. After you activate Data Security Center (DSC), the report task is enabled by default. After you disable the report task, you cannot view statistics that are newly generated in the Report Center module, on the Overview page of the Cloud Native Data Audit module, and in the Data security lab module. Existing statistics are not affected.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyReportTaskStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyReportTaskStatusResponse
         */
        public async Task<ModifyReportTaskStatusResponse> ModifyReportTaskStatusWithOptionsAsync(ModifyReportTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportTaskStatus))
            {
                query["ReportTaskStatus"] = request.ReportTaskStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyReportTaskStatus",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyReportTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or disables the report task.
         *
         * @description You can call this operation to enable or disable the report task. After you activate Data Security Center (DSC), the report task is enabled by default. After you disable the report task, you cannot view statistics that are newly generated in the Report Center module, on the Overview page of the Cloud Native Data Audit module, and in the Data security lab module. Existing statistics are not affected.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyReportTaskStatusRequest
         * @return ModifyReportTaskStatusResponse
         */
        public ModifyReportTaskStatusResponse ModifyReportTaskStatus(ModifyReportTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyReportTaskStatusWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables the report task.
         *
         * @description You can call this operation to enable or disable the report task. After you activate Data Security Center (DSC), the report task is enabled by default. After you disable the report task, you cannot view statistics that are newly generated in the Report Center module, on the Overview page of the Cloud Native Data Audit module, and in the Data security lab module. Existing statistics are not affected.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyReportTaskStatusRequest
         * @return ModifyReportTaskStatusResponse
         */
        public async Task<ModifyReportTaskStatusResponse> ModifyReportTaskStatusAsync(ModifyReportTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyReportTaskStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a custom sensitive data detection rule in Data Security Center (DSC).
         *
         * @description When you call this operation, you must configure request parameters to specify the rule name, rule ID, and rule content.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyRuleResponse
         */
        public ModifyRuleResponse ModifyRuleWithOptions(ModifyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportForm))
            {
                query["SupportForm"] = request.SupportForm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarnLevel))
            {
                query["WarnLevel"] = request.WarnLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRule",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a custom sensitive data detection rule in Data Security Center (DSC).
         *
         * @description When you call this operation, you must configure request parameters to specify the rule name, rule ID, and rule content.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyRuleResponse
         */
        public async Task<ModifyRuleResponse> ModifyRuleWithOptionsAsync(ModifyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportForm))
            {
                query["SupportForm"] = request.SupportForm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarnLevel))
            {
                query["WarnLevel"] = request.WarnLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyRule",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a custom sensitive data detection rule in Data Security Center (DSC).
         *
         * @description When you call this operation, you must configure request parameters to specify the rule name, rule ID, and rule content.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyRuleRequest
         * @return ModifyRuleResponse
         */
        public ModifyRuleResponse ModifyRule(ModifyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRuleWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a custom sensitive data detection rule in Data Security Center (DSC).
         *
         * @description When you call this operation, you must configure request parameters to specify the rule name, rule ID, and rule content.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyRuleRequest
         * @return ModifyRuleResponse
         */
        public async Task<ModifyRuleResponse> ModifyRuleAsync(ModifyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables a sensitive data detection rule.
         *
         * @param request ModifyRuleStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyRuleStatusResponse
         */
        public ModifyRuleStatusResponse ModifyRuleStatusWithOptions(ModifyRuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "ModifyRuleStatus",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRuleStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or disables a sensitive data detection rule.
         *
         * @param request ModifyRuleStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyRuleStatusResponse
         */
        public async Task<ModifyRuleStatusResponse> ModifyRuleStatusWithOptionsAsync(ModifyRuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "ModifyRuleStatus",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyRuleStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or disables a sensitive data detection rule.
         *
         * @param request ModifyRuleStatusRequest
         * @return ModifyRuleStatusResponse
         */
        public ModifyRuleStatusResponse ModifyRuleStatus(ModifyRuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRuleStatusWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables a sensitive data detection rule.
         *
         * @param request ModifyRuleStatusRequest
         * @return ModifyRuleStatusResponse
         */
        public async Task<ModifyRuleStatusResponse> ModifyRuleStatusAsync(ModifyRuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRuleStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建文件扫描任务
         *
         * @param tmpReq ScanOssObjectV1Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScanOssObjectV1Response
         */
        public ScanOssObjectV1Response ScanOssObjectV1WithOptions(ScanOssObjectV1Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ScanOssObjectV1ShrinkRequest request = new ScanOssObjectV1ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectKeyList))
            {
                request.ObjectKeyListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectKeyList, "ObjectKeyList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKeyListShrink))
            {
                query["ObjectKeyList"] = request.ObjectKeyListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
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
                Action = "ScanOssObjectV1",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScanOssObjectV1Response>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建文件扫描任务
         *
         * @param tmpReq ScanOssObjectV1Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScanOssObjectV1Response
         */
        public async Task<ScanOssObjectV1Response> ScanOssObjectV1WithOptionsAsync(ScanOssObjectV1Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ScanOssObjectV1ShrinkRequest request = new ScanOssObjectV1ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectKeyList))
            {
                request.ObjectKeyListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectKeyList, "ObjectKeyList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["BucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKeyListShrink))
            {
                query["ObjectKeyList"] = request.ObjectKeyListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRegionId))
            {
                query["ServiceRegionId"] = request.ServiceRegionId;
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
                Action = "ScanOssObjectV1",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScanOssObjectV1Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建文件扫描任务
         *
         * @param request ScanOssObjectV1Request
         * @return ScanOssObjectV1Response
         */
        public ScanOssObjectV1Response ScanOssObjectV1(ScanOssObjectV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScanOssObjectV1WithOptions(request, runtime);
        }

        /**
         * @summary 创建文件扫描任务
         *
         * @param request ScanOssObjectV1Request
         * @return ScanOssObjectV1Response
         */
        public async Task<ScanOssObjectV1Response> ScanOssObjectV1Async(ScanOssObjectV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScanOssObjectV1WithOptionsAsync(request, runtime);
        }

        /**
         * @summary Stops a de-identification task. After you stop a de-identification task, you can resume the task by calling the ManualTriggerMaskingProcess operation.
         *
         * @description You can call this operation to stop a de-identification task that is running. For example, you can stop a de-identification task that is used to de-identify specific data.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request StopMaskingProcessRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopMaskingProcessResponse
         */
        public StopMaskingProcessResponse StopMaskingProcessWithOptions(StopMaskingProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
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
                Action = "StopMaskingProcess",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMaskingProcessResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Stops a de-identification task. After you stop a de-identification task, you can resume the task by calling the ManualTriggerMaskingProcess operation.
         *
         * @description You can call this operation to stop a de-identification task that is running. For example, you can stop a de-identification task that is used to de-identify specific data.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request StopMaskingProcessRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopMaskingProcessResponse
         */
        public async Task<StopMaskingProcessResponse> StopMaskingProcessWithOptionsAsync(StopMaskingProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
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
                Action = "StopMaskingProcess",
                Version = "2019-01-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMaskingProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Stops a de-identification task. After you stop a de-identification task, you can resume the task by calling the ManualTriggerMaskingProcess operation.
         *
         * @description You can call this operation to stop a de-identification task that is running. For example, you can stop a de-identification task that is used to de-identify specific data.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request StopMaskingProcessRequest
         * @return StopMaskingProcessResponse
         */
        public StopMaskingProcessResponse StopMaskingProcess(StopMaskingProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopMaskingProcessWithOptions(request, runtime);
        }

        /**
         * @summary Stops a de-identification task. After you stop a de-identification task, you can resume the task by calling the ManualTriggerMaskingProcess operation.
         *
         * @description You can call this operation to stop a de-identification task that is running. For example, you can stop a de-identification task that is used to de-identify specific data.
         * # Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request StopMaskingProcessRequest
         * @return StopMaskingProcessResponse
         */
        public async Task<StopMaskingProcessResponse> StopMaskingProcessAsync(StopMaskingProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopMaskingProcessWithOptionsAsync(request, runtime);
        }

    }
}
