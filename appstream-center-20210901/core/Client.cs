// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Appstream_center20210901.Models;

namespace AlibabaCloud.SDK.Appstream_center20210901
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("appstream-center", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 获取访问管理页配置
         *
         * @param request AccessPageGetAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AccessPageGetAclResponse
         */
        public AccessPageGetAclResponse AccessPageGetAclWithOptions(AccessPageGetAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AccessPageGetAcl",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AccessPageGetAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取访问管理页配置
         *
         * @param request AccessPageGetAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AccessPageGetAclResponse
         */
        public async Task<AccessPageGetAclResponse> AccessPageGetAclWithOptionsAsync(AccessPageGetAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AccessPageGetAcl",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AccessPageGetAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取访问管理页配置
         *
         * @param request AccessPageGetAclRequest
         * @return AccessPageGetAclResponse
         */
        public AccessPageGetAclResponse AccessPageGetAcl(AccessPageGetAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AccessPageGetAclWithOptions(request, runtime);
        }

        /**
         * @summary 获取访问管理页配置
         *
         * @param request AccessPageGetAclRequest
         * @return AccessPageGetAclResponse
         */
        public async Task<AccessPageGetAclResponse> AccessPageGetAclAsync(AccessPageGetAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AccessPageGetAclWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新访问管理
         *
         * @param request AccessPageSetAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AccessPageSetAclResponse
         */
        public AccessPageSetAclResponse AccessPageSetAclWithOptions(AccessPageSetAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessMode))
            {
                query["AccessMode"] = request.AccessMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageName))
            {
                query["AccessPageName"] = request.AccessPageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTime))
            {
                query["EffectTime"] = request.EffectTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                query["Unit"] = request.Unit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AccessPageSetAcl",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AccessPageSetAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新访问管理
         *
         * @param request AccessPageSetAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AccessPageSetAclResponse
         */
        public async Task<AccessPageSetAclResponse> AccessPageSetAclWithOptionsAsync(AccessPageSetAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessMode))
            {
                query["AccessMode"] = request.AccessMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageName))
            {
                query["AccessPageName"] = request.AccessPageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTime))
            {
                query["EffectTime"] = request.EffectTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                query["Unit"] = request.Unit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AccessPageSetAcl",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AccessPageSetAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新访问管理
         *
         * @param request AccessPageSetAclRequest
         * @return AccessPageSetAclResponse
         */
        public AccessPageSetAclResponse AccessPageSetAcl(AccessPageSetAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AccessPageSetAclWithOptions(request, runtime);
        }

        /**
         * @summary 更新访问管理
         *
         * @param request AccessPageSetAclRequest
         * @return AccessPageSetAclResponse
         */
        public async Task<AccessPageSetAclResponse> AccessPageSetAclAsync(AccessPageSetAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AccessPageSetAclWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 同意Ota升级
         *
         * @param request ApproveOtaTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApproveOtaTaskResponse
         */
        public ApproveOtaTaskResponse ApproveOtaTaskWithOptions(ApproveOtaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaType))
            {
                body["OtaType"] = request.OtaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApproveOtaTask",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApproveOtaTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 同意Ota升级
         *
         * @param request ApproveOtaTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApproveOtaTaskResponse
         */
        public async Task<ApproveOtaTaskResponse> ApproveOtaTaskWithOptionsAsync(ApproveOtaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaType))
            {
                body["OtaType"] = request.OtaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApproveOtaTask",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApproveOtaTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 同意Ota升级
         *
         * @param request ApproveOtaTaskRequest
         * @return ApproveOtaTaskResponse
         */
        public ApproveOtaTaskResponse ApproveOtaTask(ApproveOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApproveOtaTaskWithOptions(request, runtime);
        }

        /**
         * @summary 同意Ota升级
         *
         * @param request ApproveOtaTaskRequest
         * @return ApproveOtaTaskResponse
         */
        public async Task<ApproveOtaTaskResponse> ApproveOtaTaskAsync(ApproveOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApproveOtaTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 会话包收费查询
         *
         * @param request AskSessionPackagePriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AskSessionPackagePriceResponse
         */
        public AskSessionPackagePriceResponse AskSessionPackagePriceWithOptions(AskSessionPackagePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSessions))
            {
                query["MaxSessions"] = request.MaxSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageType))
            {
                query["SessionPackageType"] = request.SessionPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionSpec))
            {
                query["SessionSpec"] = request.SessionSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionType))
            {
                query["SessionType"] = request.SessionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AskSessionPackagePrice",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AskSessionPackagePriceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 会话包收费查询
         *
         * @param request AskSessionPackagePriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AskSessionPackagePriceResponse
         */
        public async Task<AskSessionPackagePriceResponse> AskSessionPackagePriceWithOptionsAsync(AskSessionPackagePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSessions))
            {
                query["MaxSessions"] = request.MaxSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageType))
            {
                query["SessionPackageType"] = request.SessionPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionSpec))
            {
                query["SessionSpec"] = request.SessionSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionType))
            {
                query["SessionType"] = request.SessionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AskSessionPackagePrice",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AskSessionPackagePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 会话包收费查询
         *
         * @param request AskSessionPackagePriceRequest
         * @return AskSessionPackagePriceResponse
         */
        public AskSessionPackagePriceResponse AskSessionPackagePrice(AskSessionPackagePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AskSessionPackagePriceWithOptions(request, runtime);
        }

        /**
         * @summary 会话包收费查询
         *
         * @param request AskSessionPackagePriceRequest
         * @return AskSessionPackagePriceResponse
         */
        public async Task<AskSessionPackagePriceResponse> AskSessionPackagePriceAsync(AskSessionPackagePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AskSessionPackagePriceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 会话包续费询价
         *
         * @param request AskSessionPackageRenewPriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AskSessionPackageRenewPriceResponse
         */
        public AskSessionPackageRenewPriceResponse AskSessionPackageRenewPriceWithOptions(AskSessionPackageRenewPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageId))
            {
                query["SessionPackageId"] = request.SessionPackageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AskSessionPackageRenewPrice",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AskSessionPackageRenewPriceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 会话包续费询价
         *
         * @param request AskSessionPackageRenewPriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AskSessionPackageRenewPriceResponse
         */
        public async Task<AskSessionPackageRenewPriceResponse> AskSessionPackageRenewPriceWithOptionsAsync(AskSessionPackageRenewPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageId))
            {
                query["SessionPackageId"] = request.SessionPackageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AskSessionPackageRenewPrice",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AskSessionPackageRenewPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 会话包续费询价
         *
         * @param request AskSessionPackageRenewPriceRequest
         * @return AskSessionPackageRenewPriceResponse
         */
        public AskSessionPackageRenewPriceResponse AskSessionPackageRenewPrice(AskSessionPackageRenewPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AskSessionPackageRenewPriceWithOptions(request, runtime);
        }

        /**
         * @summary 会话包续费询价
         *
         * @param request AskSessionPackageRenewPriceRequest
         * @return AskSessionPackageRenewPriceResponse
         */
        public async Task<AskSessionPackageRenewPriceResponse> AskSessionPackageRenewPriceAsync(AskSessionPackageRenewPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AskSessionPackageRenewPriceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 授权用户
         *
         * @param request AuthorizeInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeInstanceGroupResponse
         */
        public AuthorizeInstanceGroupResponse AuthorizeInstanceGroupWithOptions(AuthorizeInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserIds))
            {
                bodyFlat["AuthorizeUserIds"] = request.AuthorizeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnAuthorizeUserIds))
            {
                bodyFlat["UnAuthorizeUserIds"] = request.UnAuthorizeUserIds;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 授权用户
         *
         * @param request AuthorizeInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthorizeInstanceGroupResponse
         */
        public async Task<AuthorizeInstanceGroupResponse> AuthorizeInstanceGroupWithOptionsAsync(AuthorizeInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserIds))
            {
                bodyFlat["AuthorizeUserIds"] = request.AuthorizeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnAuthorizeUserIds))
            {
                bodyFlat["UnAuthorizeUserIds"] = request.UnAuthorizeUserIds;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthorizeInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthorizeInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 授权用户
         *
         * @param request AuthorizeInstanceGroupRequest
         * @return AuthorizeInstanceGroupResponse
         */
        public AuthorizeInstanceGroupResponse AuthorizeInstanceGroup(AuthorizeInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeInstanceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 授权用户
         *
         * @param request AuthorizeInstanceGroupRequest
         * @return AuthorizeInstanceGroupResponse
         */
        public async Task<AuthorizeInstanceGroupResponse> AuthorizeInstanceGroupAsync(AuthorizeInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeInstanceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 配置会话包
         *
         * @param request BuySessionPackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BuySessionPackageResponse
         */
        public BuySessionPackageResponse BuySessionPackageWithOptions(BuySessionPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSessions))
            {
                query["MaxSessions"] = request.MaxSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageName))
            {
                query["SessionPackageName"] = request.SessionPackageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageType))
            {
                query["SessionPackageType"] = request.SessionPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionSpec))
            {
                query["SessionSpec"] = request.SessionSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionType))
            {
                query["SessionType"] = request.SessionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BuySessionPackage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BuySessionPackageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 配置会话包
         *
         * @param request BuySessionPackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BuySessionPackageResponse
         */
        public async Task<BuySessionPackageResponse> BuySessionPackageWithOptionsAsync(BuySessionPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSessions))
            {
                query["MaxSessions"] = request.MaxSessions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageName))
            {
                query["SessionPackageName"] = request.SessionPackageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageType))
            {
                query["SessionPackageType"] = request.SessionPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionSpec))
            {
                query["SessionSpec"] = request.SessionSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionType))
            {
                query["SessionType"] = request.SessionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BuySessionPackage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BuySessionPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 配置会话包
         *
         * @param request BuySessionPackageRequest
         * @return BuySessionPackageResponse
         */
        public BuySessionPackageResponse BuySessionPackage(BuySessionPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BuySessionPackageWithOptions(request, runtime);
        }

        /**
         * @summary 配置会话包
         *
         * @param request BuySessionPackageRequest
         * @return BuySessionPackageResponse
         */
        public async Task<BuySessionPackageResponse> BuySessionPackageAsync(BuySessionPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BuySessionPackageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 取消Ota升级
         *
         * @param request CancelOtaTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelOtaTaskResponse
         */
        public CancelOtaTaskResponse CancelOtaTaskWithOptions(CancelOtaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOtaTask",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOtaTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 取消Ota升级
         *
         * @param request CancelOtaTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelOtaTaskResponse
         */
        public async Task<CancelOtaTaskResponse> CancelOtaTaskWithOptionsAsync(CancelOtaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOtaTask",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOtaTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 取消Ota升级
         *
         * @param request CancelOtaTaskRequest
         * @return CancelOtaTaskResponse
         */
        public CancelOtaTaskResponse CancelOtaTask(CancelOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOtaTaskWithOptions(request, runtime);
        }

        /**
         * @summary 取消Ota升级
         *
         * @param request CancelOtaTaskRequest
         * @return CancelOtaTaskResponse
         */
        public async Task<CancelOtaTaskResponse> CancelOtaTaskAsync(CancelOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOtaTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建访问页面 
         *
         * @param request CreateAccessPageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccessPageResponse
         */
        public CreateAccessPageResponse CreateAccessPageWithOptions(CreateAccessPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageName))
            {
                query["AccessPageName"] = request.AccessPageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudEnvId))
            {
                query["CloudEnvId"] = request.CloudEnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTime))
            {
                query["EffectTime"] = request.EffectTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                query["Unit"] = request.Unit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessPage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessPageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建访问页面 
         *
         * @param request CreateAccessPageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccessPageResponse
         */
        public async Task<CreateAccessPageResponse> CreateAccessPageWithOptionsAsync(CreateAccessPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageName))
            {
                query["AccessPageName"] = request.AccessPageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudEnvId))
            {
                query["CloudEnvId"] = request.CloudEnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTime))
            {
                query["EffectTime"] = request.EffectTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                query["Unit"] = request.Unit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessPage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建访问页面 
         *
         * @param request CreateAccessPageRequest
         * @return CreateAccessPageResponse
         */
        public CreateAccessPageResponse CreateAccessPage(CreateAccessPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessPageWithOptions(request, runtime);
        }

        /**
         * @summary 创建访问页面 
         *
         * @param request CreateAccessPageRequest
         * @return CreateAccessPageResponse
         */
        public async Task<CreateAccessPageResponse> CreateAccessPageAsync(CreateAccessPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessPageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建云应用交付组
         *
         * @param tmpReq CreateAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppInstanceGroupResponse
         */
        public CreateAppInstanceGroupResponse CreateAppInstanceGroupWithOptions(CreateAppInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppInstanceGroupShrinkRequest request = new CreateAppInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Network))
            {
                request.NetworkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Network, "Network", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RuntimePolicy))
            {
                request.RuntimePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RuntimePolicy, "RuntimePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecurityPolicy))
            {
                request.SecurityPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecurityPolicy, "SecurityPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoragePolicy))
            {
                request.StoragePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoragePolicy, "StoragePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserDefinePolicy))
            {
                request.UserDefinePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserDefinePolicy, "UserDefinePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoPolicy))
            {
                request.VideoPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoPolicy, "VideoPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDefinePolicyShrink))
            {
                query["UserDefinePolicy"] = request.UserDefinePolicyShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageId))
            {
                body["AppCenterImageId"] = request.AppCenterImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                body["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeResourceMode))
            {
                body["ChargeResourceMode"] = request.ChargeResourceMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkShrink))
            {
                body["Network"] = request.NetworkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                body["NodePool"] = request.NodePoolShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOpenAppId))
            {
                body["PreOpenAppId"] = request.PreOpenAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                body["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimePolicyShrink))
            {
                body["RuntimePolicy"] = request.RuntimePolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyShrink))
            {
                body["SecurityPolicy"] = request.SecurityPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                body["SessionTimeout"] = request.SessionTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePolicyShrink))
            {
                body["StoragePolicy"] = request.StoragePolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoPolicyShrink))
            {
                body["VideoPolicy"] = request.VideoPolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建云应用交付组
         *
         * @param tmpReq CreateAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppInstanceGroupResponse
         */
        public async Task<CreateAppInstanceGroupResponse> CreateAppInstanceGroupWithOptionsAsync(CreateAppInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppInstanceGroupShrinkRequest request = new CreateAppInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Network))
            {
                request.NetworkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Network, "Network", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RuntimePolicy))
            {
                request.RuntimePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RuntimePolicy, "RuntimePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecurityPolicy))
            {
                request.SecurityPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecurityPolicy, "SecurityPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoragePolicy))
            {
                request.StoragePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoragePolicy, "StoragePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserDefinePolicy))
            {
                request.UserDefinePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserDefinePolicy, "UserDefinePolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoPolicy))
            {
                request.VideoPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoPolicy, "VideoPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDefinePolicyShrink))
            {
                query["UserDefinePolicy"] = request.UserDefinePolicyShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageId))
            {
                body["AppCenterImageId"] = request.AppCenterImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                body["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                body["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeResourceMode))
            {
                body["ChargeResourceMode"] = request.ChargeResourceMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkShrink))
            {
                body["Network"] = request.NetworkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                body["NodePool"] = request.NodePoolShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOpenAppId))
            {
                body["PreOpenAppId"] = request.PreOpenAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                body["PromotionId"] = request.PromotionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimePolicyShrink))
            {
                body["RuntimePolicy"] = request.RuntimePolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyShrink))
            {
                body["SecurityPolicy"] = request.SecurityPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                body["SessionTimeout"] = request.SessionTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePolicyShrink))
            {
                body["StoragePolicy"] = request.StoragePolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoPolicyShrink))
            {
                body["VideoPolicy"] = request.VideoPolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建云应用交付组
         *
         * @param request CreateAppInstanceGroupRequest
         * @return CreateAppInstanceGroupResponse
         */
        public CreateAppInstanceGroupResponse CreateAppInstanceGroup(CreateAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppInstanceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 创建云应用交付组
         *
         * @param request CreateAppInstanceGroupRequest
         * @return CreateAppInstanceGroupResponse
         */
        public async Task<CreateAppInstanceGroupResponse> CreateAppInstanceGroupAsync(CreateAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary CreateImageFromAppInstanceGroup
         *
         * @param request CreateImageFromAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateImageFromAppInstanceGroupResponse
         */
        public CreateImageFromAppInstanceGroupResponse CreateImageFromAppInstanceGroupWithOptions(CreateImageFromAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageName))
            {
                body["AppCenterImageName"] = request.AppCenterImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageFromAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageFromAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary CreateImageFromAppInstanceGroup
         *
         * @param request CreateImageFromAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateImageFromAppInstanceGroupResponse
         */
        public async Task<CreateImageFromAppInstanceGroupResponse> CreateImageFromAppInstanceGroupWithOptionsAsync(CreateImageFromAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageName))
            {
                body["AppCenterImageName"] = request.AppCenterImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageFromAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageFromAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary CreateImageFromAppInstanceGroup
         *
         * @param request CreateImageFromAppInstanceGroupRequest
         * @return CreateImageFromAppInstanceGroupResponse
         */
        public CreateImageFromAppInstanceGroupResponse CreateImageFromAppInstanceGroup(CreateImageFromAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageFromAppInstanceGroupWithOptions(request, runtime);
        }

        /**
         * @summary CreateImageFromAppInstanceGroup
         *
         * @param request CreateImageFromAppInstanceGroupRequest
         * @return CreateImageFromAppInstanceGroupResponse
         */
        public async Task<CreateImageFromAppInstanceGroupResponse> CreateImageFromAppInstanceGroupAsync(CreateImageFromAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageFromAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clipboard))
            {
                query["Clipboard"] = request.Clipboard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudEnvId))
            {
                query["CloudEnvId"] = request.CloudEnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentId))
            {
                query["ContentId"] = request.ContentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileTransfer))
            {
                query["FileTransfer"] = request.FileTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameRate))
            {
                query["FrameRate"] = request.FrameRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAliveDuration))
            {
                query["KeepAliveDuration"] = request.KeepAliveDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionResolutionHeight))
            {
                query["SessionResolutionHeight"] = request.SessionResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionResolutionWidth))
            {
                query["SessionResolutionWidth"] = request.SessionResolutionWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionSpec))
            {
                query["SessionSpec"] = request.SessionSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingMode))
            {
                query["StreamingMode"] = request.StreamingMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalResolutionAdaptation))
            {
                query["TerminalResolutionAdaptation"] = request.TerminalResolutionAdaptation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2021-09-01",
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

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clipboard))
            {
                query["Clipboard"] = request.Clipboard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudEnvId))
            {
                query["CloudEnvId"] = request.CloudEnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentId))
            {
                query["ContentId"] = request.ContentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileTransfer))
            {
                query["FileTransfer"] = request.FileTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameRate))
            {
                query["FrameRate"] = request.FrameRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAliveDuration))
            {
                query["KeepAliveDuration"] = request.KeepAliveDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionResolutionHeight))
            {
                query["SessionResolutionHeight"] = request.SessionResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionResolutionWidth))
            {
                query["SessionResolutionWidth"] = request.SessionResolutionWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionSpec))
            {
                query["SessionSpec"] = request.SessionSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingMode))
            {
                query["StreamingMode"] = request.StreamingMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalResolutionAdaptation))
            {
                query["TerminalResolutionAdaptation"] = request.TerminalResolutionAdaptation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2021-09-01",
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

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectWithOptions(request, runtime);
        }

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除访问页面
         *
         * @param request DeleteAccessPageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessPageResponse
         */
        public DeleteAccessPageResponse DeleteAccessPageWithOptions(DeleteAccessPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessPage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessPageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除访问页面
         *
         * @param request DeleteAccessPageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessPageResponse
         */
        public async Task<DeleteAccessPageResponse> DeleteAccessPageWithOptionsAsync(DeleteAccessPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessPage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除访问页面
         *
         * @param request DeleteAccessPageRequest
         * @return DeleteAccessPageResponse
         */
        public DeleteAccessPageResponse DeleteAccessPage(DeleteAccessPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessPageWithOptions(request, runtime);
        }

        /**
         * @summary 删除访问页面
         *
         * @param request DeleteAccessPageRequest
         * @return DeleteAccessPageResponse
         */
        public async Task<DeleteAccessPageResponse> DeleteAccessPageAsync(DeleteAccessPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessPageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 实例组释放接口
         *
         * @param request DeleteAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppInstanceGroupResponse
         */
        public DeleteAppInstanceGroupResponse DeleteAppInstanceGroupWithOptions(DeleteAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 实例组释放接口
         *
         * @param request DeleteAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppInstanceGroupResponse
         */
        public async Task<DeleteAppInstanceGroupResponse> DeleteAppInstanceGroupWithOptionsAsync(DeleteAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 实例组释放接口
         *
         * @param request DeleteAppInstanceGroupRequest
         * @return DeleteAppInstanceGroupResponse
         */
        public DeleteAppInstanceGroupResponse DeleteAppInstanceGroup(DeleteAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppInstanceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 实例组释放接口
         *
         * @param request DeleteAppInstanceGroupRequest
         * @return DeleteAppInstanceGroupResponse
         */
        public async Task<DeleteAppInstanceGroupResponse> DeleteAppInstanceGroupAsync(DeleteAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除实例
         *
         * @param request DeleteAppInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppInstancesResponse
         */
        public DeleteAppInstancesResponse DeleteAppInstancesWithOptions(DeleteAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceIds))
            {
                body["AppInstanceIds"] = request.AppInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppInstances",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除实例
         *
         * @param request DeleteAppInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppInstancesResponse
         */
        public async Task<DeleteAppInstancesResponse> DeleteAppInstancesWithOptionsAsync(DeleteAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceIds))
            {
                body["AppInstanceIds"] = request.AppInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppInstances",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除实例
         *
         * @param request DeleteAppInstancesRequest
         * @return DeleteAppInstancesResponse
         */
        public DeleteAppInstancesResponse DeleteAppInstances(DeleteAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppInstancesWithOptions(request, runtime);
        }

        /**
         * @summary 删除实例
         *
         * @param request DeleteAppInstancesRequest
         * @return DeleteAppInstancesResponse
         */
        public async Task<DeleteAppInstancesResponse> DeleteAppInstancesAsync(DeleteAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
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
                Version = "2021-09-01",
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

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
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
                Version = "2021-09-01",
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

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @return DeleteProjectResponse
         */
        public DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectWithOptions(request, runtime);
        }

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @return DeleteProjectResponse
         */
        public async Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 访客进入访问页面的匿名api
         *
         * @param request GetAccessPageSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccessPageSessionResponse
         */
        public GetAccessPageSessionResponse GetAccessPageSessionWithOptions(GetAccessPageSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageToken))
            {
                query["AccessPageToken"] = request.AccessPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalUserId))
            {
                query["ExternalUserId"] = request.ExternalUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessPageSession",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessPageSessionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 访客进入访问页面的匿名api
         *
         * @param request GetAccessPageSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccessPageSessionResponse
         */
        public async Task<GetAccessPageSessionResponse> GetAccessPageSessionWithOptionsAsync(GetAccessPageSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageToken))
            {
                query["AccessPageToken"] = request.AccessPageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalUserId))
            {
                query["ExternalUserId"] = request.ExternalUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessPageSession",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessPageSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 访客进入访问页面的匿名api
         *
         * @param request GetAccessPageSessionRequest
         * @return GetAccessPageSessionResponse
         */
        public GetAccessPageSessionResponse GetAccessPageSession(GetAccessPageSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessPageSessionWithOptions(request, runtime);
        }

        /**
         * @summary 访客进入访问页面的匿名api
         *
         * @param request GetAccessPageSessionRequest
         * @return GetAccessPageSessionResponse
         */
        public async Task<GetAccessPageSessionResponse> GetAccessPageSessionAsync(GetAccessPageSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessPageSessionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取交付组详情
         *
         * @param request GetAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppInstanceGroupResponse
         */
        public GetAppInstanceGroupResponse GetAppInstanceGroupWithOptions(GetAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取交付组详情
         *
         * @param request GetAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppInstanceGroupResponse
         */
        public async Task<GetAppInstanceGroupResponse> GetAppInstanceGroupWithOptionsAsync(GetAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取交付组详情
         *
         * @param request GetAppInstanceGroupRequest
         * @return GetAppInstanceGroupResponse
         */
        public GetAppInstanceGroupResponse GetAppInstanceGroup(GetAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppInstanceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 获取交付组详情
         *
         * @param request GetAppInstanceGroupRequest
         * @return GetAppInstanceGroupResponse
         */
        public async Task<GetAppInstanceGroupResponse> GetAppInstanceGroupAsync(GetAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取连接ticket，Open API
         *
         * @param request GetConnectionTicketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConnectionTicketResponse
         */
        public GetConnectionTicketResponse GetConnectionTicketWithOptions(GetConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupIdList))
            {
                body["AppInstanceGroupIdList"] = request.AppInstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                body["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppStartParam))
            {
                body["AppStartParam"] = request.AppStartParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnectionTicket",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionTicketResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取连接ticket，Open API
         *
         * @param request GetConnectionTicketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConnectionTicketResponse
         */
        public async Task<GetConnectionTicketResponse> GetConnectionTicketWithOptionsAsync(GetConnectionTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupIdList))
            {
                body["AppInstanceGroupIdList"] = request.AppInstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                body["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppStartParam))
            {
                body["AppStartParam"] = request.AppStartParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnectionTicket",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取连接ticket，Open API
         *
         * @param request GetConnectionTicketRequest
         * @return GetConnectionTicketResponse
         */
        public GetConnectionTicketResponse GetConnectionTicket(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectionTicketWithOptions(request, runtime);
        }

        /**
         * @summary 获取连接ticket，Open API
         *
         * @param request GetConnectionTicketRequest
         * @return GetConnectionTicketResponse
         */
        public async Task<GetConnectionTicketResponse> GetConnectionTicketAsync(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectionTicketWithOptionsAsync(request, runtime);
        }

        /**
         * @summary GetDebugAppInstance
         *
         * @param request GetDebugAppInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDebugAppInstanceResponse
         */
        public GetDebugAppInstanceResponse GetDebugAppInstanceWithOptions(GetDebugAppInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDebugAppInstance",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDebugAppInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary GetDebugAppInstance
         *
         * @param request GetDebugAppInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDebugAppInstanceResponse
         */
        public async Task<GetDebugAppInstanceResponse> GetDebugAppInstanceWithOptionsAsync(GetDebugAppInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDebugAppInstance",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDebugAppInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary GetDebugAppInstance
         *
         * @param request GetDebugAppInstanceRequest
         * @return GetDebugAppInstanceResponse
         */
        public GetDebugAppInstanceResponse GetDebugAppInstance(GetDebugAppInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDebugAppInstanceWithOptions(request, runtime);
        }

        /**
         * @summary GetDebugAppInstance
         *
         * @param request GetDebugAppInstanceRequest
         * @return GetDebugAppInstanceResponse
         */
        public async Task<GetDebugAppInstanceResponse> GetDebugAppInstanceAsync(GetDebugAppInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDebugAppInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取ota任务明细
         *
         * @param request GetOtaTaskByTaskIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOtaTaskByTaskIdResponse
         */
        public GetOtaTaskByTaskIdResponse GetOtaTaskByTaskIdWithOptions(GetOtaTaskByTaskIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOtaTaskByTaskId",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOtaTaskByTaskIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取ota任务明细
         *
         * @param request GetOtaTaskByTaskIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOtaTaskByTaskIdResponse
         */
        public async Task<GetOtaTaskByTaskIdResponse> GetOtaTaskByTaskIdWithOptionsAsync(GetOtaTaskByTaskIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOtaTaskByTaskId",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOtaTaskByTaskIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取ota任务明细
         *
         * @param request GetOtaTaskByTaskIdRequest
         * @return GetOtaTaskByTaskIdResponse
         */
        public GetOtaTaskByTaskIdResponse GetOtaTaskByTaskId(GetOtaTaskByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOtaTaskByTaskIdWithOptions(request, runtime);
        }

        /**
         * @summary 获取ota任务明细
         *
         * @param request GetOtaTaskByTaskIdRequest
         * @return GetOtaTaskByTaskIdResponse
         */
        public async Task<GetOtaTaskByTaskIdResponse> GetOtaTaskByTaskIdAsync(GetOtaTaskByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOtaTaskByTaskIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取策略配置
         *
         * @param request GetProjectPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectPoliciesResponse
         */
        public GetProjectPoliciesResponse GetProjectPoliciesWithOptions(GetProjectPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetProjectPolicies",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取策略配置
         *
         * @param request GetProjectPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectPoliciesResponse
         */
        public async Task<GetProjectPoliciesResponse> GetProjectPoliciesWithOptionsAsync(GetProjectPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetProjectPolicies",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取策略配置
         *
         * @param request GetProjectPoliciesRequest
         * @return GetProjectPoliciesResponse
         */
        public GetProjectPoliciesResponse GetProjectPolicies(GetProjectPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectPoliciesWithOptions(request, runtime);
        }

        /**
         * @summary 获取策略配置
         *
         * @param request GetProjectPoliciesRequest
         * @return GetProjectPoliciesResponse
         */
        public async Task<GetProjectPoliciesResponse> GetProjectPoliciesAsync(GetProjectPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectPoliciesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 云应用资源询价接口
         *
         * @param request GetResourcePriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourcePriceResponse
         */
        public GetResourcePriceResponse GetResourcePriceWithOptions(GetResourcePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceType))
            {
                query["AppInstanceType"] = request.AppInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourcePrice",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourcePriceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 云应用资源询价接口
         *
         * @param request GetResourcePriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourcePriceResponse
         */
        public async Task<GetResourcePriceResponse> GetResourcePriceWithOptionsAsync(GetResourcePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceType))
            {
                query["AppInstanceType"] = request.AppInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourcePrice",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourcePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 云应用资源询价接口
         *
         * @param request GetResourcePriceRequest
         * @return GetResourcePriceResponse
         */
        public GetResourcePriceResponse GetResourcePrice(GetResourcePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourcePriceWithOptions(request, runtime);
        }

        /**
         * @summary 云应用资源询价接口
         *
         * @param request GetResourcePriceRequest
         * @return GetResourcePriceResponse
         */
        public async Task<GetResourcePriceResponse> GetResourcePriceAsync(GetResourcePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourcePriceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 云应用资源询价接口
         *
         * @param request GetResourceRenewPriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceRenewPriceResponse
         */
        public GetResourceRenewPriceResponse GetResourceRenewPriceWithOptions(GetResourceRenewPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceRenewPrice",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceRenewPriceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 云应用资源询价接口
         *
         * @param request GetResourceRenewPriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceRenewPriceResponse
         */
        public async Task<GetResourceRenewPriceResponse> GetResourceRenewPriceWithOptionsAsync(GetResourceRenewPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceRenewPrice",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceRenewPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 云应用资源询价接口
         *
         * @param request GetResourceRenewPriceRequest
         * @return GetResourceRenewPriceResponse
         */
        public GetResourceRenewPriceResponse GetResourceRenewPrice(GetResourceRenewPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceRenewPriceWithOptions(request, runtime);
        }

        /**
         * @summary 云应用资源询价接口
         *
         * @param request GetResourceRenewPriceRequest
         * @return GetResourceRenewPriceResponse
         */
        public async Task<GetResourceRenewPriceResponse> GetResourceRenewPriceAsync(GetResourceRenewPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceRenewPriceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 访问页面分页查询
         *
         * @param request ListAccessPagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccessPagesResponse
         */
        public ListAccessPagesResponse ListAccessPagesWithOptions(ListAccessPagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageName))
            {
                query["AccessPageName"] = request.AccessPageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessPages",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessPagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 访问页面分页查询
         *
         * @param request ListAccessPagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccessPagesResponse
         */
        public async Task<ListAccessPagesResponse> ListAccessPagesWithOptionsAsync(ListAccessPagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageName))
            {
                query["AccessPageName"] = request.AccessPageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessPages",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessPagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 访问页面分页查询
         *
         * @param request ListAccessPagesRequest
         * @return ListAccessPagesResponse
         */
        public ListAccessPagesResponse ListAccessPages(ListAccessPagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessPagesWithOptions(request, runtime);
        }

        /**
         * @summary 访问页面分页查询
         *
         * @param request ListAccessPagesRequest
         * @return ListAccessPagesResponse
         */
        public async Task<ListAccessPagesResponse> ListAccessPagesAsync(ListAccessPagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessPagesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列表展示云应用交付组
         *
         * @param request ListAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppInstanceGroupResponse
         */
        public ListAppInstanceGroupResponse ListAppInstanceGroupWithOptions(ListAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageId))
            {
                query["AppCenterImageId"] = request.AppCenterImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列表展示云应用交付组
         *
         * @param request ListAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppInstanceGroupResponse
         */
        public async Task<ListAppInstanceGroupResponse> ListAppInstanceGroupWithOptionsAsync(ListAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageId))
            {
                query["AppCenterImageId"] = request.AppCenterImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列表展示云应用交付组
         *
         * @param request ListAppInstanceGroupRequest
         * @return ListAppInstanceGroupResponse
         */
        public ListAppInstanceGroupResponse ListAppInstanceGroup(ListAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppInstanceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 列表展示云应用交付组
         *
         * @param request ListAppInstanceGroupRequest
         * @return ListAppInstanceGroupResponse
         */
        public async Task<ListAppInstanceGroupResponse> ListAppInstanceGroupAsync(ListAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询交付组内实例列表
         *
         * @param request ListAppInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppInstancesResponse
         */
        public ListAppInstancesResponse ListAppInstancesWithOptions(ListAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDeleted))
            {
                query["IncludeDeleted"] = request.IncludeDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceIdList))
            {
                body["AppInstanceIdList"] = request.AppInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppInstances",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询交付组内实例列表
         *
         * @param request ListAppInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppInstancesResponse
         */
        public async Task<ListAppInstancesResponse> ListAppInstancesWithOptionsAsync(ListAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                query["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDeleted))
            {
                query["IncludeDeleted"] = request.IncludeDeleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceIdList))
            {
                body["AppInstanceIdList"] = request.AppInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppInstances",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询交付组内实例列表
         *
         * @param request ListAppInstancesRequest
         * @return ListAppInstancesResponse
         */
        public ListAppInstancesResponse ListAppInstances(ListAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppInstancesWithOptions(request, runtime);
        }

        /**
         * @summary 查询交付组内实例列表
         *
         * @param request ListAppInstancesRequest
         * @return ListAppInstancesResponse
         */
        public async Task<ListAppInstancesResponse> ListAppInstancesAsync(ListAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取资源规格
         *
         * @param request ListNodeInstanceTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNodeInstanceTypeResponse
         */
        public ListNodeInstanceTypeResponse ListNodeInstanceTypeWithOptions(ListNodeInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodeInstanceType",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodeInstanceTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取资源规格
         *
         * @param request ListNodeInstanceTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNodeInstanceTypeResponse
         */
        public async Task<ListNodeInstanceTypeResponse> ListNodeInstanceTypeWithOptionsAsync(ListNodeInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodeInstanceType",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodeInstanceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取资源规格
         *
         * @param request ListNodeInstanceTypeRequest
         * @return ListNodeInstanceTypeResponse
         */
        public ListNodeInstanceTypeResponse ListNodeInstanceType(ListNodeInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodeInstanceTypeWithOptions(request, runtime);
        }

        /**
         * @summary 获取资源规格
         *
         * @param request ListNodeInstanceTypeRequest
         * @return ListNodeInstanceTypeResponse
         */
        public async Task<ListNodeInstanceTypeResponse> ListNodeInstanceTypeAsync(ListNodeInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodeInstanceTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 升级历史记录
         *
         * @param request ListOtaTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOtaTaskResponse
         */
        public ListOtaTaskResponse ListOtaTaskWithOptions(ListOtaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaType))
            {
                body["OtaType"] = request.OtaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOtaTask",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOtaTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 升级历史记录
         *
         * @param request ListOtaTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOtaTaskResponse
         */
        public async Task<ListOtaTaskResponse> ListOtaTaskWithOptionsAsync(ListOtaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaType))
            {
                body["OtaType"] = request.OtaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOtaTask",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOtaTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 升级历史记录
         *
         * @param request ListOtaTaskRequest
         * @return ListOtaTaskResponse
         */
        public ListOtaTaskResponse ListOtaTask(ListOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOtaTaskWithOptions(request, runtime);
        }

        /**
         * @summary 升级历史记录
         *
         * @param request ListOtaTaskRequest
         * @return ListOtaTaskResponse
         */
        public async Task<ListOtaTaskResponse> ListOtaTaskAsync(ListOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOtaTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取项目列表
         *
         * @param request ListProjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectsResponse
         */
        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateList))
            {
                query["StateList"] = request.StateList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2021-09-01",
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

        /**
         * @summary 获取项目列表
         *
         * @param request ListProjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectsResponse
         */
        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateList))
            {
                query["StateList"] = request.StateList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2021-09-01",
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

        /**
         * @summary 获取项目列表
         *
         * @param request ListProjectsRequest
         * @return ListProjectsResponse
         */
        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectsWithOptions(request, runtime);
        }

        /**
         * @summary 获取项目列表
         *
         * @param request ListProjectsRequest
         * @return ListProjectsResponse
         */
        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 云应用支持的地域列表
         *
         * @param request ListRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegionsResponse
         */
        public ListRegionsResponse ListRegionsWithOptions(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizSource))
            {
                query["BizSource"] = request.BizSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 云应用支持的地域列表
         *
         * @param request ListRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegionsResponse
         */
        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizSource))
            {
                query["BizSource"] = request.BizSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 云应用支持的地域列表
         *
         * @param request ListRegionsRequest
         * @return ListRegionsResponse
         */
        public ListRegionsResponse ListRegions(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(request, runtime);
        }

        /**
         * @summary 云应用支持的地域列表
         *
         * @param request ListRegionsRequest
         * @return ListRegionsResponse
         */
        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 项目的会话包列表
         *
         * @param request ListSessionPackagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSessionPackagesResponse
         */
        public ListSessionPackagesResponse ListSessionPackagesWithOptions(ListSessionPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageId))
            {
                query["SessionPackageId"] = request.SessionPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageName))
            {
                query["SessionPackageName"] = request.SessionPackageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateList))
            {
                query["StateList"] = request.StateList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSessionPackages",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSessionPackagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 项目的会话包列表
         *
         * @param request ListSessionPackagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSessionPackagesResponse
         */
        public async Task<ListSessionPackagesResponse> ListSessionPackagesWithOptionsAsync(ListSessionPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageId))
            {
                query["SessionPackageId"] = request.SessionPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageName))
            {
                query["SessionPackageName"] = request.SessionPackageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                query["SortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateList))
            {
                query["StateList"] = request.StateList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSessionPackages",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSessionPackagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 项目的会话包列表
         *
         * @param request ListSessionPackagesRequest
         * @return ListSessionPackagesResponse
         */
        public ListSessionPackagesResponse ListSessionPackages(ListSessionPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSessionPackagesWithOptions(request, runtime);
        }

        /**
         * @summary 项目的会话包列表
         *
         * @param request ListSessionPackagesRequest
         * @return ListSessionPackagesResponse
         */
        public async Task<ListSessionPackagesResponse> ListSessionPackagesAsync(ListSessionPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSessionPackagesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListTenantConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTenantConfigResponse
         */
        public ListTenantConfigResponse ListTenantConfigWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantConfig",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListTenantConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTenantConfigResponse
         */
        public async Task<ListTenantConfigResponse> ListTenantConfigWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantConfig",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return ListTenantConfigResponse
         */
        public ListTenantConfigResponse ListTenantConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTenantConfigWithOptions(runtime);
        }

        /**
         * @return ListTenantConfigResponse
         */
        public async Task<ListTenantConfigResponse> ListTenantConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTenantConfigWithOptionsAsync(runtime);
        }

        /**
         * @summary 注销交付下所有会话
         *
         * @param request LogOffAllSessionsInAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LogOffAllSessionsInAppInstanceGroupResponse
         */
        public LogOffAllSessionsInAppInstanceGroupResponse LogOffAllSessionsInAppInstanceGroupWithOptions(LogOffAllSessionsInAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogOffAllSessionsInAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogOffAllSessionsInAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 注销交付下所有会话
         *
         * @param request LogOffAllSessionsInAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LogOffAllSessionsInAppInstanceGroupResponse
         */
        public async Task<LogOffAllSessionsInAppInstanceGroupResponse> LogOffAllSessionsInAppInstanceGroupWithOptionsAsync(LogOffAllSessionsInAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogOffAllSessionsInAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogOffAllSessionsInAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 注销交付下所有会话
         *
         * @param request LogOffAllSessionsInAppInstanceGroupRequest
         * @return LogOffAllSessionsInAppInstanceGroupResponse
         */
        public LogOffAllSessionsInAppInstanceGroupResponse LogOffAllSessionsInAppInstanceGroup(LogOffAllSessionsInAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LogOffAllSessionsInAppInstanceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 注销交付下所有会话
         *
         * @param request LogOffAllSessionsInAppInstanceGroupRequest
         * @return LogOffAllSessionsInAppInstanceGroupResponse
         */
        public async Task<LogOffAllSessionsInAppInstanceGroupResponse> LogOffAllSessionsInAppInstanceGroupAsync(LogOffAllSessionsInAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LogOffAllSessionsInAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 会话包 迁移/分配
         *
         * @param request MigrateSessionPackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MigrateSessionPackageResponse
         */
        public MigrateSessionPackageResponse MigrateSessionPackageWithOptions(MigrateSessionPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestProjectId))
            {
                body["DestProjectId"] = request.DestProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageId))
            {
                body["SessionPackageId"] = request.SessionPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProjectId))
            {
                body["SourceProjectId"] = request.SourceProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateSessionPackage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateSessionPackageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 会话包 迁移/分配
         *
         * @param request MigrateSessionPackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MigrateSessionPackageResponse
         */
        public async Task<MigrateSessionPackageResponse> MigrateSessionPackageWithOptionsAsync(MigrateSessionPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestProjectId))
            {
                body["DestProjectId"] = request.DestProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageId))
            {
                body["SessionPackageId"] = request.SessionPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProjectId))
            {
                body["SourceProjectId"] = request.SourceProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateSessionPackage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateSessionPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 会话包 迁移/分配
         *
         * @param request MigrateSessionPackageRequest
         * @return MigrateSessionPackageResponse
         */
        public MigrateSessionPackageResponse MigrateSessionPackage(MigrateSessionPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MigrateSessionPackageWithOptions(request, runtime);
        }

        /**
         * @summary 会话包 迁移/分配
         *
         * @param request MigrateSessionPackageRequest
         * @return MigrateSessionPackageResponse
         */
        public async Task<MigrateSessionPackageResponse> MigrateSessionPackageAsync(MigrateSessionPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MigrateSessionPackageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改云应用交付组
         *
         * @param tmpReq ModifyAppInstanceGroupAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppInstanceGroupAttributeResponse
         */
        public ModifyAppInstanceGroupAttributeResponse ModifyAppInstanceGroupAttributeWithOptions(ModifyAppInstanceGroupAttributeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppInstanceGroupAttributeShrinkRequest request = new ModifyAppInstanceGroupAttributeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Network))
            {
                request.NetworkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Network, "Network", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecurityPolicy))
            {
                request.SecurityPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecurityPolicy, "SecurityPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoragePolicy))
            {
                request.StoragePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoragePolicy, "StoragePolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                query["NodePool"] = request.NodePoolShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                query["SessionTimeout"] = request.SessionTimeout;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkShrink))
            {
                body["Network"] = request.NetworkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOpenAppId))
            {
                body["PreOpenAppId"] = request.PreOpenAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOpenMode))
            {
                body["PreOpenMode"] = request.PreOpenMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyShrink))
            {
                body["SecurityPolicy"] = request.SecurityPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePolicyShrink))
            {
                body["StoragePolicy"] = request.StoragePolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppInstanceGroupAttribute",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppInstanceGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改云应用交付组
         *
         * @param tmpReq ModifyAppInstanceGroupAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppInstanceGroupAttributeResponse
         */
        public async Task<ModifyAppInstanceGroupAttributeResponse> ModifyAppInstanceGroupAttributeWithOptionsAsync(ModifyAppInstanceGroupAttributeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppInstanceGroupAttributeShrinkRequest request = new ModifyAppInstanceGroupAttributeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Network))
            {
                request.NetworkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Network, "Network", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecurityPolicy))
            {
                request.SecurityPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecurityPolicy, "SecurityPolicy", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoragePolicy))
            {
                request.StoragePolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoragePolicy, "StoragePolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupName))
            {
                query["AppInstanceGroupName"] = request.AppInstanceGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                query["NodePool"] = request.NodePoolShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                query["SessionTimeout"] = request.SessionTimeout;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkShrink))
            {
                body["Network"] = request.NetworkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOpenAppId))
            {
                body["PreOpenAppId"] = request.PreOpenAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreOpenMode))
            {
                body["PreOpenMode"] = request.PreOpenMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyShrink))
            {
                body["SecurityPolicy"] = request.SecurityPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoragePolicyShrink))
            {
                body["StoragePolicy"] = request.StoragePolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppInstanceGroupAttribute",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppInstanceGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改云应用交付组
         *
         * @param request ModifyAppInstanceGroupAttributeRequest
         * @return ModifyAppInstanceGroupAttributeResponse
         */
        public ModifyAppInstanceGroupAttributeResponse ModifyAppInstanceGroupAttribute(ModifyAppInstanceGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppInstanceGroupAttributeWithOptions(request, runtime);
        }

        /**
         * @summary 修改云应用交付组
         *
         * @param request ModifyAppInstanceGroupAttributeRequest
         * @return ModifyAppInstanceGroupAttributeResponse
         */
        public async Task<ModifyAppInstanceGroupAttributeResponse> ModifyAppInstanceGroupAttributeAsync(ModifyAppInstanceGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppInstanceGroupAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改策略信息
         *
         * @param tmpReq ModifyAppPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppPolicyResponse
         */
        public ModifyAppPolicyResponse ModifyAppPolicyWithOptions(ModifyAppPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppPolicyShrinkRequest request = new ModifyAppPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoPolicy))
            {
                request.VideoPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoPolicy, "VideoPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPolicyId))
            {
                query["AppPolicyId"] = request.AppPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoPolicyShrink))
            {
                query["VideoPolicy"] = request.VideoPolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppPolicy",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改策略信息
         *
         * @param tmpReq ModifyAppPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppPolicyResponse
         */
        public async Task<ModifyAppPolicyResponse> ModifyAppPolicyWithOptionsAsync(ModifyAppPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppPolicyShrinkRequest request = new ModifyAppPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VideoPolicy))
            {
                request.VideoPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VideoPolicy, "VideoPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPolicyId))
            {
                query["AppPolicyId"] = request.AppPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoPolicyShrink))
            {
                query["VideoPolicy"] = request.VideoPolicyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppPolicy",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改策略信息
         *
         * @param request ModifyAppPolicyRequest
         * @return ModifyAppPolicyResponse
         */
        public ModifyAppPolicyResponse ModifyAppPolicy(ModifyAppPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 修改策略信息
         *
         * @param request ModifyAppPolicyRequest
         * @return ModifyAppPolicyResponse
         */
        public async Task<ModifyAppPolicyResponse> ModifyAppPolicyAsync(ModifyAppPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @param tmpReq ModifyNodePoolAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNodePoolAttributeResponse
         */
        public ModifyNodePoolAttributeResponse ModifyNodePoolAttributeWithOptions(ModifyNodePoolAttributeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyNodePoolAttributeShrinkRequest request = new ModifyNodePoolAttributeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePoolStrategy))
            {
                request.NodePoolStrategyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePoolStrategy, "NodePoolStrategy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCapacity))
            {
                body["NodeCapacity"] = request.NodeCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolStrategyShrink))
            {
                body["NodePoolStrategy"] = request.NodePoolStrategyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolId))
            {
                body["PoolId"] = request.PoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodePoolAttribute",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodePoolAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param tmpReq ModifyNodePoolAttributeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNodePoolAttributeResponse
         */
        public async Task<ModifyNodePoolAttributeResponse> ModifyNodePoolAttributeWithOptionsAsync(ModifyNodePoolAttributeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyNodePoolAttributeShrinkRequest request = new ModifyNodePoolAttributeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePoolStrategy))
            {
                request.NodePoolStrategyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePoolStrategy, "NodePoolStrategy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                body["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCapacity))
            {
                body["NodeCapacity"] = request.NodeCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolStrategyShrink))
            {
                body["NodePoolStrategy"] = request.NodePoolStrategyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PoolId))
            {
                body["PoolId"] = request.PoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodePoolAttribute",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodePoolAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyNodePoolAttributeRequest
         * @return ModifyNodePoolAttributeResponse
         */
        public ModifyNodePoolAttributeResponse ModifyNodePoolAttribute(ModifyNodePoolAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNodePoolAttributeWithOptions(request, runtime);
        }

        /**
         * @param request ModifyNodePoolAttributeRequest
         * @return ModifyNodePoolAttributeResponse
         */
        public async Task<ModifyNodePoolAttributeResponse> ModifyNodePoolAttributeAsync(ModifyNodePoolAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNodePoolAttributeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改项目策略
         *
         * @param request ModifyProjectPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProjectPolicyResponse
         */
        public ModifyProjectPolicyResponse ModifyProjectPolicyWithOptions(ModifyProjectPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clipboard))
            {
                query["Clipboard"] = request.Clipboard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileTransfer))
            {
                query["FileTransfer"] = request.FileTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameRate))
            {
                query["FrameRate"] = request.FrameRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAliveDuration))
            {
                query["KeepAliveDuration"] = request.KeepAliveDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionResolutionHeight))
            {
                query["SessionResolutionHeight"] = request.SessionResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionResolutionWidth))
            {
                query["SessionResolutionWidth"] = request.SessionResolutionWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingMode))
            {
                query["StreamingMode"] = request.StreamingMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalResolutionAdaptation))
            {
                query["TerminalResolutionAdaptation"] = request.TerminalResolutionAdaptation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProjectPolicy",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProjectPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改项目策略
         *
         * @param request ModifyProjectPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyProjectPolicyResponse
         */
        public async Task<ModifyProjectPolicyResponse> ModifyProjectPolicyWithOptionsAsync(ModifyProjectPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clipboard))
            {
                query["Clipboard"] = request.Clipboard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileTransfer))
            {
                query["FileTransfer"] = request.FileTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FrameRate))
            {
                query["FrameRate"] = request.FrameRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAliveDuration))
            {
                query["KeepAliveDuration"] = request.KeepAliveDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionResolutionHeight))
            {
                query["SessionResolutionHeight"] = request.SessionResolutionHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionResolutionWidth))
            {
                query["SessionResolutionWidth"] = request.SessionResolutionWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingMode))
            {
                query["StreamingMode"] = request.StreamingMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalResolutionAdaptation))
            {
                query["TerminalResolutionAdaptation"] = request.TerminalResolutionAdaptation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyProjectPolicy",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyProjectPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改项目策略
         *
         * @param request ModifyProjectPolicyRequest
         * @return ModifyProjectPolicyResponse
         */
        public ModifyProjectPolicyResponse ModifyProjectPolicy(ModifyProjectPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyProjectPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 修改项目策略
         *
         * @param request ModifyProjectPolicyRequest
         * @return ModifyProjectPolicyResponse
         */
        public async Task<ModifyProjectPolicyResponse> ModifyProjectPolicyAsync(ModifyProjectPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyProjectPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyTenantConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantConfigResponse
         */
        public ModifyTenantConfigResponse ModifyTenantConfigWithOptions(ModifyTenantConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupExpireRemind))
            {
                body["AppInstanceGroupExpireRemind"] = request.AppInstanceGroupExpireRemind;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantConfig",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyTenantConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTenantConfigResponse
         */
        public async Task<ModifyTenantConfigResponse> ModifyTenantConfigWithOptionsAsync(ModifyTenantConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupExpireRemind))
            {
                body["AppInstanceGroupExpireRemind"] = request.AppInstanceGroupExpireRemind;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTenantConfig",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTenantConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyTenantConfigRequest
         * @return ModifyTenantConfigResponse
         */
        public ModifyTenantConfigResponse ModifyTenantConfig(ModifyTenantConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTenantConfigWithOptions(request, runtime);
        }

        /**
         * @param request ModifyTenantConfigRequest
         * @return ModifyTenantConfigResponse
         */
        public async Task<ModifyTenantConfigResponse> ModifyTenantConfigAsync(ModifyTenantConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTenantConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取授权用户列表
         *
         * @param request PageListAppInstanceGroupUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListAppInstanceGroupUserResponse
         */
        public PageListAppInstanceGroupUserResponse PageListAppInstanceGroupUserWithOptions(PageListAppInstanceGroupUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageListAppInstanceGroupUser",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListAppInstanceGroupUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取授权用户列表
         *
         * @param request PageListAppInstanceGroupUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListAppInstanceGroupUserResponse
         */
        public async Task<PageListAppInstanceGroupUserResponse> PageListAppInstanceGroupUserWithOptionsAsync(PageListAppInstanceGroupUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageListAppInstanceGroupUser",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListAppInstanceGroupUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取授权用户列表
         *
         * @param request PageListAppInstanceGroupUserRequest
         * @return PageListAppInstanceGroupUserResponse
         */
        public PageListAppInstanceGroupUserResponse PageListAppInstanceGroupUser(PageListAppInstanceGroupUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PageListAppInstanceGroupUserWithOptions(request, runtime);
        }

        /**
         * @summary 获取授权用户列表
         *
         * @param request PageListAppInstanceGroupUserRequest
         * @return PageListAppInstanceGroupUserResponse
         */
        public async Task<PageListAppInstanceGroupUserResponse> PageListAppInstanceGroupUserAsync(PageListAppInstanceGroupUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PageListAppInstanceGroupUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 刷新访问url
         *
         * @param request RefreshAccessUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshAccessUrlResponse
         */
        public RefreshAccessUrlResponse RefreshAccessUrlWithOptions(RefreshAccessUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshAccessUrl",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshAccessUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 刷新访问url
         *
         * @param request RefreshAccessUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshAccessUrlResponse
         */
        public async Task<RefreshAccessUrlResponse> RefreshAccessUrlWithOptionsAsync(RefreshAccessUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshAccessUrl",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshAccessUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 刷新访问url
         *
         * @param request RefreshAccessUrlRequest
         * @return RefreshAccessUrlResponse
         */
        public RefreshAccessUrlResponse RefreshAccessUrl(RefreshAccessUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshAccessUrlWithOptions(request, runtime);
        }

        /**
         * @summary 刷新访问url
         *
         * @param request RefreshAccessUrlRequest
         * @return RefreshAccessUrlResponse
         */
        public async Task<RefreshAccessUrlResponse> RefreshAccessUrlAsync(RefreshAccessUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshAccessUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 资源续费接口
         *
         * @param request RenewAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewAppInstanceGroupResponse
         */
        public RenewAppInstanceGroupResponse RenewAppInstanceGroupWithOptions(RenewAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                query["PromotionId"] = request.PromotionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewAppInstanceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 资源续费接口
         *
         * @param request RenewAppInstanceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewAppInstanceGroupResponse
         */
        public async Task<RenewAppInstanceGroupResponse> RenewAppInstanceGroupWithOptionsAsync(RenewAppInstanceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionId))
            {
                query["PromotionId"] = request.PromotionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewAppInstanceGroup",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 资源续费接口
         *
         * @param request RenewAppInstanceGroupRequest
         * @return RenewAppInstanceGroupResponse
         */
        public RenewAppInstanceGroupResponse RenewAppInstanceGroup(RenewAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewAppInstanceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 资源续费接口
         *
         * @param request RenewAppInstanceGroupRequest
         * @return RenewAppInstanceGroupResponse
         */
        public async Task<RenewAppInstanceGroupResponse> RenewAppInstanceGroupAsync(RenewAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 会话包续费
         *
         * @param request RenewSessionPackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewSessionPackageResponse
         */
        public RenewSessionPackageResponse RenewSessionPackageWithOptions(RenewSessionPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageId))
            {
                query["SessionPackageId"] = request.SessionPackageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewSessionPackage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewSessionPackageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 会话包续费
         *
         * @param request RenewSessionPackageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenewSessionPackageResponse
         */
        public async Task<RenewSessionPackageResponse> RenewSessionPackageWithOptionsAsync(RenewSessionPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                query["PeriodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionPackageId))
            {
                query["SessionPackageId"] = request.SessionPackageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenewSessionPackage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenewSessionPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 会话包续费
         *
         * @param request RenewSessionPackageRequest
         * @return RenewSessionPackageResponse
         */
        public RenewSessionPackageResponse RenewSessionPackage(RenewSessionPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewSessionPackageWithOptions(request, runtime);
        }

        /**
         * @summary 会话包续费
         *
         * @param request RenewSessionPackageRequest
         * @return RenewSessionPackageResponse
         */
        public async Task<RenewSessionPackageResponse> RenewSessionPackageAsync(RenewSessionPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewSessionPackageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 解除用户绑定
         *
         * @param request UnbindRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindResponse
         */
        public UnbindResponse UnbindWithOptions(UnbindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                body["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Unbind",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 解除用户绑定
         *
         * @param request UnbindRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindResponse
         */
        public async Task<UnbindResponse> UnbindWithOptionsAsync(UnbindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceId))
            {
                body["AppInstanceId"] = request.AppInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Unbind",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 解除用户绑定
         *
         * @param request UnbindRequest
         * @return UnbindResponse
         */
        public UnbindResponse Unbind(UnbindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindWithOptions(request, runtime);
        }

        /**
         * @summary 解除用户绑定
         *
         * @param request UnbindRequest
         * @return UnbindResponse
         */
        public async Task<UnbindResponse> UnbindAsync(UnbindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新访问页面状态
         *
         * @param request UpdateAccessPageStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAccessPageStateResponse
         */
        public UpdateAccessPageStateResponse UpdateAccessPageStateWithOptions(UpdateAccessPageStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageState))
            {
                query["AccessPageState"] = request.AccessPageState;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccessPageState",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccessPageStateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新访问页面状态
         *
         * @param request UpdateAccessPageStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAccessPageStateResponse
         */
        public async Task<UpdateAccessPageStateResponse> UpdateAccessPageStateWithOptionsAsync(UpdateAccessPageStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageId))
            {
                query["AccessPageId"] = request.AccessPageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessPageState))
            {
                query["AccessPageState"] = request.AccessPageState;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccessPageState",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccessPageStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新访问页面状态
         *
         * @param request UpdateAccessPageStateRequest
         * @return UpdateAccessPageStateResponse
         */
        public UpdateAccessPageStateResponse UpdateAccessPageState(UpdateAccessPageStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAccessPageStateWithOptions(request, runtime);
        }

        /**
         * @summary 更新访问页面状态
         *
         * @param request UpdateAccessPageStateRequest
         * @return UpdateAccessPageStateResponse
         */
        public async Task<UpdateAccessPageStateResponse> UpdateAccessPageStateAsync(UpdateAccessPageStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAccessPageStateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新镜像
         *
         * @param request UpdateAppInstanceGroupImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppInstanceGroupImageResponse
         */
        public UpdateAppInstanceGroupImageResponse UpdateAppInstanceGroupImageWithOptions(UpdateAppInstanceGroupImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageId))
            {
                query["AppCenterImageId"] = request.AppCenterImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppInstanceGroupImage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppInstanceGroupImageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新镜像
         *
         * @param request UpdateAppInstanceGroupImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppInstanceGroupImageResponse
         */
        public async Task<UpdateAppInstanceGroupImageResponse> UpdateAppInstanceGroupImageWithOptionsAsync(UpdateAppInstanceGroupImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppCenterImageId))
            {
                query["AppCenterImageId"] = request.AppCenterImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppInstanceGroupImage",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppInstanceGroupImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新镜像
         *
         * @param request UpdateAppInstanceGroupImageRequest
         * @return UpdateAppInstanceGroupImageResponse
         */
        public UpdateAppInstanceGroupImageResponse UpdateAppInstanceGroupImage(UpdateAppInstanceGroupImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppInstanceGroupImageWithOptions(request, runtime);
        }

        /**
         * @summary 更新镜像
         *
         * @param request UpdateAppInstanceGroupImageRequest
         * @return UpdateAppInstanceGroupImageResponse
         */
        public async Task<UpdateAppInstanceGroupImageResponse> UpdateAppInstanceGroupImageAsync(UpdateAppInstanceGroupImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppInstanceGroupImageWithOptionsAsync(request, runtime);
        }

    }
}
