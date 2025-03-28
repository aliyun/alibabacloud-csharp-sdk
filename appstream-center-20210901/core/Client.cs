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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新访问管理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AccessPageSetAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AccessPageSetAclResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AccessPageSetAclResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AccessPageSetAclResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新访问管理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AccessPageSetAclRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AccessPageSetAclResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AccessPageSetAclResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AccessPageSetAclResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新访问管理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AccessPageSetAclRequest
        /// </param>
        /// 
        /// <returns>
        /// AccessPageSetAclResponse
        /// </returns>
        public AccessPageSetAclResponse AccessPageSetAcl(AccessPageSetAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AccessPageSetAclWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新访问管理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AccessPageSetAclRequest
        /// </param>
        /// 
        /// <returns>
        /// AccessPageSetAclResponse
        /// </returns>
        public async Task<AccessPageSetAclResponse> AccessPageSetAclAsync(AccessPageSetAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AccessPageSetAclWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the execution time of an over-the-air (OTA) update task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveOtaTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApproveOtaTaskResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ApproveOtaTaskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ApproveOtaTaskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the execution time of an over-the-air (OTA) update task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveOtaTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApproveOtaTaskResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ApproveOtaTaskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ApproveOtaTaskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the execution time of an over-the-air (OTA) update task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveOtaTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ApproveOtaTaskResponse
        /// </returns>
        public ApproveOtaTaskResponse ApproveOtaTask(ApproveOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApproveOtaTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the execution time of an over-the-air (OTA) update task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApproveOtaTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ApproveOtaTaskResponse
        /// </returns>
        public async Task<ApproveOtaTaskResponse> ApproveOtaTaskAsync(ApproveOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApproveOtaTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话包收费查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AskSessionPackagePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AskSessionPackagePriceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AskSessionPackagePriceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AskSessionPackagePriceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话包收费查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AskSessionPackagePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AskSessionPackagePriceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AskSessionPackagePriceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AskSessionPackagePriceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话包收费查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AskSessionPackagePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// AskSessionPackagePriceResponse
        /// </returns>
        public AskSessionPackagePriceResponse AskSessionPackagePrice(AskSessionPackagePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AskSessionPackagePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话包收费查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AskSessionPackagePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// AskSessionPackagePriceResponse
        /// </returns>
        public async Task<AskSessionPackagePriceResponse> AskSessionPackagePriceAsync(AskSessionPackagePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AskSessionPackagePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权用户</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AuthorizeInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeInstanceGroupResponse
        /// </returns>
        public AuthorizeInstanceGroupResponse AuthorizeInstanceGroupWithOptions(AuthorizeInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AuthorizeInstanceGroupShrinkRequest request = new AuthorizeInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserMeta))
            {
                request.UserMetaShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserMeta, "UserMeta", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMetaShrink))
            {
                body["UserMeta"] = request.UserMetaShrink;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AuthorizeInstanceGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AuthorizeInstanceGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权用户</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AuthorizeInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeInstanceGroupResponse
        /// </returns>
        public async Task<AuthorizeInstanceGroupResponse> AuthorizeInstanceGroupWithOptionsAsync(AuthorizeInstanceGroupRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AuthorizeInstanceGroupShrinkRequest request = new AuthorizeInstanceGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserMeta))
            {
                request.UserMetaShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserMeta, "UserMeta", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentId))
            {
                body["AppInstancePersistentId"] = request.AppInstancePersistentId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMetaShrink))
            {
                body["UserMeta"] = request.UserMetaShrink;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AuthorizeInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AuthorizeInstanceGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthorizeInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeInstanceGroupResponse
        /// </returns>
        public AuthorizeInstanceGroupResponse AuthorizeInstanceGroup(AuthorizeInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>授权用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AuthorizeInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AuthorizeInstanceGroupResponse
        /// </returns>
        public async Task<AuthorizeInstanceGroupResponse> AuthorizeInstanceGroupAsync(AuthorizeInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置会话包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BuySessionPackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BuySessionPackageResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BuySessionPackageResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BuySessionPackageResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置会话包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BuySessionPackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BuySessionPackageResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<BuySessionPackageResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<BuySessionPackageResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置会话包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BuySessionPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// BuySessionPackageResponse
        /// </returns>
        public BuySessionPackageResponse BuySessionPackage(BuySessionPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BuySessionPackageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>配置会话包</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BuySessionPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// BuySessionPackageResponse
        /// </returns>
        public async Task<BuySessionPackageResponse> BuySessionPackageAsync(BuySessionPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BuySessionPackageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建访问页面 </para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessPageResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateAccessPageResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateAccessPageResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建访问页面 </para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessPageResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateAccessPageResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateAccessPageResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建访问页面 </para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessPageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessPageResponse
        /// </returns>
        public CreateAccessPageResponse CreateAccessPage(CreateAccessPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建访问页面 </para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccessPageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccessPageResponse
        /// </returns>
        public async Task<CreateAccessPageResponse> CreateAccessPageAsync(CreateAccessPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云应用交付组</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppInstanceGroupResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPackageType))
            {
                body["AppPackageType"] = request.AppPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPolicyId))
            {
                body["AppPolicyId"] = request.AppPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthMode))
            {
                body["AuthMode"] = request.AuthMode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPayType))
            {
                body["SubPayType"] = request.SubPayType;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateAppInstanceGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateAppInstanceGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云应用交付组</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppInstanceGroupResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPackageType))
            {
                body["AppPackageType"] = request.AppPackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppPolicyId))
            {
                body["AppPolicyId"] = request.AppPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthMode))
            {
                body["AuthMode"] = request.AuthMode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubPayType))
            {
                body["SubPayType"] = request.SubPayType;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateAppInstanceGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云应用交付组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppInstanceGroupResponse
        /// </returns>
        public CreateAppInstanceGroupResponse CreateAppInstanceGroup(CreateAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建云应用交付组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppInstanceGroupResponse
        /// </returns>
        public async Task<CreateAppInstanceGroupResponse> CreateAppInstanceGroupAsync(CreateAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new image by debugging the delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageFromAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageFromAppInstanceGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateImageFromAppInstanceGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateImageFromAppInstanceGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new image by debugging the delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageFromAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageFromAppInstanceGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateImageFromAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateImageFromAppInstanceGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new image by debugging the delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageFromAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageFromAppInstanceGroupResponse
        /// </returns>
        public CreateImageFromAppInstanceGroupResponse CreateImageFromAppInstanceGroup(CreateImageFromAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageFromAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a new image by debugging the delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageFromAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageFromAppInstanceGroupResponse
        /// </returns>
        public async Task<CreateImageFromAppInstanceGroupResponse> CreateImageFromAppInstanceGroupAsync(CreateImageFromAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageFromAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除访问页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessPageResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteAccessPageResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteAccessPageResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除访问页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessPageResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteAccessPageResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteAccessPageResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除访问页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessPageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessPageResponse
        /// </returns>
        public DeleteAccessPageResponse DeleteAccessPage(DeleteAccessPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除访问页面</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccessPageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccessPageResponse
        /// </returns>
        public async Task<DeleteAccessPageResponse> DeleteAccessPageAsync(DeleteAccessPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a delivery group that uses the By Resource - Pay-as-you-go billing method.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You cannot call this operation to delete a subscription delivery group.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstanceGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteAppInstanceGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteAppInstanceGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a delivery group that uses the By Resource - Pay-as-you-go billing method.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You cannot call this operation to delete a subscription delivery group.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstanceGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteAppInstanceGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a delivery group that uses the By Resource - Pay-as-you-go billing method.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You cannot call this operation to delete a subscription delivery group.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstanceGroupResponse
        /// </returns>
        public DeleteAppInstanceGroupResponse DeleteAppInstanceGroup(DeleteAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a delivery group that uses the By Resource - Pay-as-you-go billing method.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You cannot call this operation to delete a subscription delivery group.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstanceGroupResponse
        /// </returns>
        public async Task<DeleteAppInstanceGroupResponse> DeleteAppInstanceGroupAsync(DeleteAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only application instances that are in the Initializing or Idle state can be deleted. The operation can be called only by specific customers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstancesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteAppInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteAppInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only application instances that are in the Initializing or Idle state can be deleted. The operation can be called only by specific customers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstancesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteAppInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteAppInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only application instances that are in the Initializing or Idle state can be deleted. The operation can be called only by specific customers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstancesResponse
        /// </returns>
        public DeleteAppInstancesResponse DeleteAppInstances(DeleteAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only application instances that are in the Initializing or Idle state can be deleted. The operation can be called only by specific customers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstancesResponse
        /// </returns>
        public async Task<DeleteAppInstancesResponse> DeleteAppInstancesAsync(DeleteAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>访客进入访问页面的匿名api</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessPageSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessPageSessionResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetAccessPageSessionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetAccessPageSessionResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>访客进入访问页面的匿名api</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessPageSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessPageSessionResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetAccessPageSessionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetAccessPageSessionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>访客进入访问页面的匿名api</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessPageSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessPageSessionResponse
        /// </returns>
        public GetAccessPageSessionResponse GetAccessPageSession(GetAccessPageSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessPageSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>访客进入访问页面的匿名api</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessPageSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessPageSessionResponse
        /// </returns>
        public async Task<GetAccessPageSessionResponse> GetAccessPageSessionAsync(GetAccessPageSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessPageSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取交付组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppInstanceGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetAppInstanceGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetAppInstanceGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取交付组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAppInstanceGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetAppInstanceGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取交付组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppInstanceGroupResponse
        /// </returns>
        public GetAppInstanceGroupResponse GetAppInstanceGroup(GetAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取交付组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAppInstanceGroupResponse
        /// </returns>
        public async Task<GetAppInstanceGroupResponse> GetAppInstanceGroupAsync(GetAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the credential that is used to connect to App Streaming.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must call this operation at least twice to obtain a connection credential.
        /// The first time you call this operation, the system assigns an application instance to the specified convenience account and then starts the application. In this case, the ID of the started task, which is indicated by <c>TaskID</c>, is returned.
        /// In subsequent calls, you must configure <c>TaskID</c> to query whether the task is completed. If the value of <c>TaskStatus</c> in the response is <c>Finished</c>, the connection credential, which is indicated by <c>Ticket</c>, is returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectionTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionTicketResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetConnectionTicketResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetConnectionTicketResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the credential that is used to connect to App Streaming.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must call this operation at least twice to obtain a connection credential.
        /// The first time you call this operation, the system assigns an application instance to the specified convenience account and then starts the application. In this case, the ID of the started task, which is indicated by <c>TaskID</c>, is returned.
        /// In subsequent calls, you must configure <c>TaskID</c> to query whether the task is completed. If the value of <c>TaskStatus</c> in the response is <c>Finished</c>, the connection credential, which is indicated by <c>Ticket</c>, is returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectionTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionTicketResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetConnectionTicketResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetConnectionTicketResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the credential that is used to connect to App Streaming.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must call this operation at least twice to obtain a connection credential.
        /// The first time you call this operation, the system assigns an application instance to the specified convenience account and then starts the application. In this case, the ID of the started task, which is indicated by <c>TaskID</c>, is returned.
        /// In subsequent calls, you must configure <c>TaskID</c> to query whether the task is completed. If the value of <c>TaskStatus</c> in the response is <c>Finished</c>, the connection credential, which is indicated by <c>Ticket</c>, is returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectionTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionTicketResponse
        /// </returns>
        public GetConnectionTicketResponse GetConnectionTicket(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectionTicketWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the credential that is used to connect to App Streaming.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must call this operation at least twice to obtain a connection credential.
        /// The first time you call this operation, the system assigns an application instance to the specified convenience account and then starts the application. In this case, the ID of the started task, which is indicated by <c>TaskID</c>, is returned.
        /// In subsequent calls, you must configure <c>TaskID</c> to query whether the task is completed. If the value of <c>TaskStatus</c> in the response is <c>Finished</c>, the connection credential, which is indicated by <c>Ticket</c>, is returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetConnectionTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConnectionTicketResponse
        /// </returns>
        public async Task<GetConnectionTicketResponse> GetConnectionTicketAsync(GetConnectionTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectionTicketWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information that is used to debug an application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDebugAppInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDebugAppInstanceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetDebugAppInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetDebugAppInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information that is used to debug an application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDebugAppInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDebugAppInstanceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetDebugAppInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetDebugAppInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information that is used to debug an application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDebugAppInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDebugAppInstanceResponse
        /// </returns>
        public GetDebugAppInstanceResponse GetDebugAppInstance(GetDebugAppInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDebugAppInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information that is used to debug an application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDebugAppInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDebugAppInstanceResponse
        /// </returns>
        public async Task<GetDebugAppInstanceResponse> GetDebugAppInstanceAsync(GetDebugAppInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDebugAppInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an over-the-air (OTA) update task, including the available versions and version description.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOtaTaskByTaskIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOtaTaskByTaskIdResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetOtaTaskByTaskIdResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetOtaTaskByTaskIdResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an over-the-air (OTA) update task, including the available versions and version description.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOtaTaskByTaskIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOtaTaskByTaskIdResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetOtaTaskByTaskIdResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetOtaTaskByTaskIdResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an over-the-air (OTA) update task, including the available versions and version description.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOtaTaskByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOtaTaskByTaskIdResponse
        /// </returns>
        public GetOtaTaskByTaskIdResponse GetOtaTaskByTaskId(GetOtaTaskByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOtaTaskByTaskIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an over-the-air (OTA) update task, including the available versions and version description.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOtaTaskByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOtaTaskByTaskIdResponse
        /// </returns>
        public async Task<GetOtaTaskByTaskIdResponse> GetOtaTaskByTaskIdAsync(GetOtaTaskByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOtaTaskByTaskIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource prices.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourcePriceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetResourcePriceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetResourcePriceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource prices.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourcePriceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetResourcePriceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetResourcePriceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource prices.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourcePriceResponse
        /// </returns>
        public GetResourcePriceResponse GetResourcePrice(GetResourcePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourcePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource prices.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourcePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourcePriceResponse
        /// </returns>
        public async Task<GetResourcePriceResponse> GetResourcePriceAsync(GetResourcePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourcePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal prices of App Streaming resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceRenewPriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceRenewPriceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetResourceRenewPriceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetResourceRenewPriceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal prices of App Streaming resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceRenewPriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceRenewPriceResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetResourceRenewPriceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetResourceRenewPriceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal prices of App Streaming resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceRenewPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceRenewPriceResponse
        /// </returns>
        public GetResourceRenewPriceResponse GetResourceRenewPrice(GetResourceRenewPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceRenewPriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal prices of App Streaming resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceRenewPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceRenewPriceResponse
        /// </returns>
        public async Task<GetResourceRenewPriceResponse> GetResourceRenewPriceAsync(GetResourceRenewPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceRenewPriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>访问页面分页查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccessPagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessPagesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListAccessPagesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAccessPagesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>访问页面分页查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccessPagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccessPagesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListAccessPagesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAccessPagesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>访问页面分页查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccessPagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessPagesResponse
        /// </returns>
        public ListAccessPagesResponse ListAccessPages(ListAccessPagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessPagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>访问页面分页查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccessPagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccessPagesResponse
        /// </returns>
        public async Task<ListAccessPagesResponse> ListAccessPagesAsync(ListAccessPagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessPagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of multiple delivery groups that meet the query conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstanceGroupResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListAppInstanceGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAppInstanceGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of multiple delivery groups that meet the query conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstanceGroupResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeSiteId))
            {
                query["OfficeSiteId"] = request.OfficeSiteId;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAppInstanceGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of multiple delivery groups that meet the query conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstanceGroupResponse
        /// </returns>
        public ListAppInstanceGroupResponse ListAppInstanceGroup(ListAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of multiple delivery groups that meet the query conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstanceGroupResponse
        /// </returns>
        public async Task<ListAppInstanceGroupResponse> ListAppInstanceGroupAsync(ListAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of application instances in a delivery group, including the IDs, status, creation time, update time, session status, and public IP addresses associated with the primary NICs of the instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstancesResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListAppInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAppInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of application instances in a delivery group, including the IDs, status, creation time, update time, session status, and public IP addresses associated with the primary NICs of the instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstancesResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListAppInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAppInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of application instances in a delivery group, including the IDs, status, creation time, update time, session status, and public IP addresses associated with the primary NICs of the instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstancesResponse
        /// </returns>
        public ListAppInstancesResponse ListAppInstances(ListAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of application instances in a delivery group, including the IDs, status, creation time, update time, session status, and public IP addresses associated with the primary NICs of the instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstancesResponse
        /// </returns>
        public async Task<ListAppInstancesResponse> ListAppInstancesAsync(ListAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询绑定信息，支持分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBindInfoResponse
        /// </returns>
        public ListBindInfoResponse ListBindInfoWithOptions(ListBindInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                body["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupIdList))
            {
                body["AppInstanceGroupIdList"] = request.AppInstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceIdList))
            {
                body["AppInstanceIdList"] = request.AppInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["UserIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyIdList))
            {
                body["WyIdList"] = request.WyIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindInfo",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListBindInfoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListBindInfoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询绑定信息，支持分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBindInfoResponse
        /// </returns>
        public async Task<ListBindInfoResponse> ListBindInfoWithOptionsAsync(ListBindInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdList))
            {
                body["AppIdList"] = request.AppIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupIdList))
            {
                body["AppInstanceGroupIdList"] = request.AppInstanceGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceIdList))
            {
                body["AppInstanceIdList"] = request.AppInstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["UserIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyIdList))
            {
                body["WyIdList"] = request.WyIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindInfo",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListBindInfoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListBindInfoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询绑定信息，支持分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBindInfoResponse
        /// </returns>
        public ListBindInfoResponse ListBindInfo(ListBindInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBindInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询绑定信息，支持分页</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBindInfoResponse
        /// </returns>
        public async Task<ListBindInfoResponse> ListBindInfoAsync(ListBindInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBindInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource types that are available for purchase when you create a delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeInstanceTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodeInstanceTypeResponse
        /// </returns>
        public ListNodeInstanceTypeResponse ListNodeInstanceTypeWithOptions(ListNodeInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gpu))
            {
                query["Gpu"] = request.Gpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuMemory))
            {
                query["GpuMemory"] = request.GpuMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceTypeFamily))
            {
                query["NodeInstanceTypeFamily"] = request.NodeInstanceTypeFamily;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListNodeInstanceTypeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListNodeInstanceTypeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource types that are available for purchase when you create a delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeInstanceTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodeInstanceTypeResponse
        /// </returns>
        public async Task<ListNodeInstanceTypeResponse> ListNodeInstanceTypeWithOptionsAsync(ListNodeInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRegionId))
            {
                query["BizRegionId"] = request.BizRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gpu))
            {
                query["Gpu"] = request.Gpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuMemory))
            {
                query["GpuMemory"] = request.GpuMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceType))
            {
                query["NodeInstanceType"] = request.NodeInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeInstanceTypeFamily))
            {
                query["NodeInstanceTypeFamily"] = request.NodeInstanceTypeFamily;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListNodeInstanceTypeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListNodeInstanceTypeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource types that are available for purchase when you create a delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeInstanceTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodeInstanceTypeResponse
        /// </returns>
        public ListNodeInstanceTypeResponse ListNodeInstanceType(ListNodeInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodeInstanceTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource types that are available for purchase when you create a delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodeInstanceTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodeInstanceTypeResponse
        /// </returns>
        public async Task<ListNodeInstanceTypeResponse> ListNodeInstanceTypeAsync(ListNodeInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodeInstanceTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public ListNodesResponse ListNodesWithOptions(ListNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListNodes",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListNodesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListNodesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public async Task<ListNodesResponse> ListNodesWithOptionsAsync(ListNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListNodes",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListNodesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListNodesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public ListNodesResponse ListNodes(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about over-the-air (OTA) update tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOtaTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOtaTaskResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListOtaTaskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListOtaTaskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about over-the-air (OTA) update tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOtaTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOtaTaskResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListOtaTaskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListOtaTaskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about over-the-air (OTA) update tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOtaTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOtaTaskResponse
        /// </returns>
        public ListOtaTaskResponse ListOtaTask(ListOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOtaTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about over-the-air (OTA) update tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOtaTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOtaTaskResponse
        /// </returns>
        public async Task<ListOtaTaskResponse> ListOtaTaskAsync(ListOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOtaTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询交付组内持久会话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPersistentAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPersistentAppInstancesResponse
        /// </returns>
        public ListPersistentAppInstancesResponse ListPersistentAppInstancesWithOptions(ListPersistentAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentIds))
            {
                query["AppInstancePersistentIds"] = request.AppInstancePersistentIds;
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
                Action = "ListPersistentAppInstances",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListPersistentAppInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListPersistentAppInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询交付组内持久会话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPersistentAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPersistentAppInstancesResponse
        /// </returns>
        public async Task<ListPersistentAppInstancesResponse> ListPersistentAppInstancesWithOptionsAsync(ListPersistentAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                query["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstancePersistentIds))
            {
                query["AppInstancePersistentIds"] = request.AppInstancePersistentIds;
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
                Action = "ListPersistentAppInstances",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListPersistentAppInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListPersistentAppInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询交付组内持久会话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPersistentAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPersistentAppInstancesResponse
        /// </returns>
        public ListPersistentAppInstancesResponse ListPersistentAppInstances(ListPersistentAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPersistentAppInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询交付组内持久会话列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPersistentAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPersistentAppInstancesResponse
        /// </returns>
        public async Task<ListPersistentAppInstancesResponse> ListPersistentAppInstancesAsync(ListPersistentAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPersistentAppInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions that are supported by App Streaming.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> All supported regions instead of available regions are returned by this operation. For more information, see <a href="https://help.aliyun.com/document_detail/426036.html">Supported regions</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListRegionsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions that are supported by App Streaming.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> All supported regions instead of available regions are returned by this operation. For more information, see <a href="https://help.aliyun.com/document_detail/426036.html">Supported regions</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListRegionsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions that are supported by App Streaming.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> All supported regions instead of available regions are returned by this operation. For more information, see <a href="https://help.aliyun.com/document_detail/426036.html">Supported regions</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegions(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions that are supported by App Streaming.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> All supported regions instead of available regions are returned by this operation. For more information, see <a href="https://help.aliyun.com/document_detail/426036.html">Supported regions</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>项目的会话包列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSessionPackagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSessionPackagesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSessionPackagesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSessionPackagesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>项目的会话包列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSessionPackagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSessionPackagesResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSessionPackagesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSessionPackagesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>项目的会话包列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSessionPackagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSessionPackagesResponse
        /// </returns>
        public ListSessionPackagesResponse ListSessionPackages(ListSessionPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSessionPackagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>项目的会话包列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSessionPackagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSessionPackagesResponse
        /// </returns>
        public async Task<ListSessionPackagesResponse> ListSessionPackagesAsync(ListSessionPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSessionPackagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags added to one or more cloud resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagCloudResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagCloudResourcesResponse
        /// </returns>
        public ListTagCloudResourcesResponse ListTagCloudResourcesWithOptions(ListTagCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagCloudResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTagCloudResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagCloudResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags added to one or more cloud resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagCloudResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagCloudResourcesResponse
        /// </returns>
        public async Task<ListTagCloudResourcesResponse> ListTagCloudResourcesWithOptionsAsync(ListTagCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagCloudResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTagCloudResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagCloudResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags added to one or more cloud resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagCloudResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagCloudResourcesResponse
        /// </returns>
        public ListTagCloudResourcesResponse ListTagCloudResources(ListTagCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagCloudResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags added to one or more cloud resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagCloudResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagCloudResourcesResponse
        /// </returns>
        public async Task<ListTagCloudResourcesResponse> ListTagCloudResourcesAsync(ListTagCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagCloudResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of the administrator account, such as whether the resource expiration reminder feature is enabled.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTenantConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTenantConfigResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTenantConfigResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTenantConfigResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of the administrator account, such as whether the resource expiration reminder feature is enabled.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTenantConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTenantConfigResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTenantConfigResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTenantConfigResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of the administrator account, such as whether the resource expiration reminder feature is enabled.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListTenantConfigResponse
        /// </returns>
        public ListTenantConfigResponse ListTenantConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTenantConfigWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of the administrator account, such as whether the resource expiration reminder feature is enabled.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListTenantConfigResponse
        /// </returns>
        public async Task<ListTenantConfigResponse> ListTenantConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTenantConfigWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Closes all sessions in a pay-as-you-go delivery group for which a scheduled scaling policy is used.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> This operation can be called only if you use a pay-as-you-go delivery group for which a scheduled scaling policy is used and if you call the operation at a time other than the scheduled time.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// LogOffAllSessionsInAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LogOffAllSessionsInAppInstanceGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<LogOffAllSessionsInAppInstanceGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<LogOffAllSessionsInAppInstanceGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Closes all sessions in a pay-as-you-go delivery group for which a scheduled scaling policy is used.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> This operation can be called only if you use a pay-as-you-go delivery group for which a scheduled scaling policy is used and if you call the operation at a time other than the scheduled time.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// LogOffAllSessionsInAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LogOffAllSessionsInAppInstanceGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<LogOffAllSessionsInAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<LogOffAllSessionsInAppInstanceGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Closes all sessions in a pay-as-you-go delivery group for which a scheduled scaling policy is used.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> This operation can be called only if you use a pay-as-you-go delivery group for which a scheduled scaling policy is used and if you call the operation at a time other than the scheduled time.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// LogOffAllSessionsInAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// LogOffAllSessionsInAppInstanceGroupResponse
        /// </returns>
        public LogOffAllSessionsInAppInstanceGroupResponse LogOffAllSessionsInAppInstanceGroup(LogOffAllSessionsInAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LogOffAllSessionsInAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Closes all sessions in a pay-as-you-go delivery group for which a scheduled scaling policy is used.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> This operation can be called only if you use a pay-as-you-go delivery group for which a scheduled scaling policy is used and if you call the operation at a time other than the scheduled time.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// LogOffAllSessionsInAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// LogOffAllSessionsInAppInstanceGroupResponse
        /// </returns>
        public async Task<LogOffAllSessionsInAppInstanceGroupResponse> LogOffAllSessionsInAppInstanceGroupAsync(LogOffAllSessionsInAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LogOffAllSessionsInAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the general policies of a delivery group, including the number of concurrent sessions and the retention period of disconnected sessions.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppInstanceGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppInstanceGroupAttributeResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerSessionPerApp))
            {
                body["PerSessionPerApp"] = request.PerSessionPerApp;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyAppInstanceGroupAttributeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyAppInstanceGroupAttributeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the general policies of a delivery group, including the number of concurrent sessions and the retention period of disconnected sessions.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppInstanceGroupAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppInstanceGroupAttributeResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerSessionPerApp))
            {
                body["PerSessionPerApp"] = request.PerSessionPerApp;
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyAppInstanceGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyAppInstanceGroupAttributeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the general policies of a delivery group, including the number of concurrent sessions and the retention period of disconnected sessions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppInstanceGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppInstanceGroupAttributeResponse
        /// </returns>
        public ModifyAppInstanceGroupAttributeResponse ModifyAppInstanceGroupAttribute(ModifyAppInstanceGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppInstanceGroupAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the general policies of a delivery group, including the number of concurrent sessions and the retention period of disconnected sessions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppInstanceGroupAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppInstanceGroupAttributeResponse
        /// </returns>
        public async Task<ModifyAppInstanceGroupAttributeResponse> ModifyAppInstanceGroupAttributeAsync(ModifyAppInstanceGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppInstanceGroupAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改策略信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppPolicyResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyAppPolicyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyAppPolicyResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改策略信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppPolicyResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyAppPolicyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyAppPolicyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改策略信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppPolicyResponse
        /// </returns>
        public ModifyAppPolicyResponse ModifyAppPolicy(ModifyAppPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改策略信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyAppPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppPolicyResponse
        /// </returns>
        public async Task<ModifyAppPolicyResponse> ModifyAppPolicyAsync(ModifyAppPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the number of nodes in a subscription delivery group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyNodePoolAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAmountResponse
        /// </returns>
        public ModifyNodePoolAmountResponse ModifyNodePoolAmountWithOptions(ModifyNodePoolAmountRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyNodePoolAmountShrinkRequest request = new ModifyNodePoolAmountShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                body["NodePool"] = request.NodePoolShrink;
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
                Action = "ModifyNodePoolAmount",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyNodePoolAmountResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyNodePoolAmountResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the number of nodes in a subscription delivery group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyNodePoolAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAmountResponse
        /// </returns>
        public async Task<ModifyNodePoolAmountResponse> ModifyNodePoolAmountWithOptionsAsync(ModifyNodePoolAmountRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyNodePoolAmountShrinkRequest request = new ModifyNodePoolAmountShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NodePool))
            {
                request.NodePoolShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NodePool, "NodePool", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceGroupId))
            {
                body["AppInstanceGroupId"] = request.AppInstanceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePoolShrink))
            {
                body["NodePool"] = request.NodePoolShrink;
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
                Action = "ModifyNodePoolAmount",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyNodePoolAmountResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyNodePoolAmountResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the number of nodes in a subscription delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyNodePoolAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAmountResponse
        /// </returns>
        public ModifyNodePoolAmountResponse ModifyNodePoolAmount(ModifyNodePoolAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNodePoolAmountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the number of nodes in a subscription delivery group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyNodePoolAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAmountResponse
        /// </returns>
        public async Task<ModifyNodePoolAmountResponse> ModifyNodePoolAmountAsync(ModifyNodePoolAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNodePoolAmountWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// ModifyNodePoolAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAttributeResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyNodePoolAttributeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyNodePoolAttributeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <param name="tmpReq">
        /// ModifyNodePoolAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAttributeResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyNodePoolAttributeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyNodePoolAttributeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <param name="request">
        /// ModifyNodePoolAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAttributeResponse
        /// </returns>
        public ModifyNodePoolAttributeResponse ModifyNodePoolAttribute(ModifyNodePoolAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNodePoolAttributeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ModifyNodePoolAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyNodePoolAttributeResponse
        /// </returns>
        public async Task<ModifyNodePoolAttributeResponse> ModifyNodePoolAttributeAsync(ModifyNodePoolAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNodePoolAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of the administrator account, such as whether to enable the resource expiration reminder feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTenantConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTenantConfigResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyTenantConfigResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyTenantConfigResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of the administrator account, such as whether to enable the resource expiration reminder feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTenantConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyTenantConfigResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyTenantConfigResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyTenantConfigResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of the administrator account, such as whether to enable the resource expiration reminder feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTenantConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTenantConfigResponse
        /// </returns>
        public ModifyTenantConfigResponse ModifyTenantConfig(ModifyTenantConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTenantConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of the administrator account, such as whether to enable the resource expiration reminder feature.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyTenantConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyTenantConfigResponse
        /// </returns>
        public async Task<ModifyTenantConfigResponse> ModifyTenantConfigAsync(ModifyTenantConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTenantConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the assigned users that are added to a delivery group by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListAppInstanceGroupUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageListAppInstanceGroupUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PageListAppInstanceGroupUserResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PageListAppInstanceGroupUserResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the assigned users that are added to a delivery group by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListAppInstanceGroupUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PageListAppInstanceGroupUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PageListAppInstanceGroupUserResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PageListAppInstanceGroupUserResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the assigned users that are added to a delivery group by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListAppInstanceGroupUserRequest
        /// </param>
        /// 
        /// <returns>
        /// PageListAppInstanceGroupUserResponse
        /// </returns>
        public PageListAppInstanceGroupUserResponse PageListAppInstanceGroupUser(PageListAppInstanceGroupUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PageListAppInstanceGroupUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the assigned users that are added to a delivery group by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PageListAppInstanceGroupUserRequest
        /// </param>
        /// 
        /// <returns>
        /// PageListAppInstanceGroupUserResponse
        /// </returns>
        public async Task<PageListAppInstanceGroupUserResponse> PageListAppInstanceGroupUserAsync(PageListAppInstanceGroupUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PageListAppInstanceGroupUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing methods and prices</a> of App Streaming.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewAppInstanceGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RenewAppInstanceGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RenewAppInstanceGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing methods and prices</a> of App Streaming.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewAppInstanceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenewAppInstanceGroupResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RenewAppInstanceGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RenewAppInstanceGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing methods and prices</a> of App Streaming.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewAppInstanceGroupResponse
        /// </returns>
        public RenewAppInstanceGroupResponse RenewAppInstanceGroup(RenewAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewAppInstanceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the <a href="https://help.aliyun.com/document_detail/426039.html">billing methods and prices</a> of App Streaming.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RenewAppInstanceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RenewAppInstanceGroupResponse
        /// </returns>
        public async Task<RenewAppInstanceGroupResponse> RenewAppInstanceGroupAsync(RenewAppInstanceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewAppInstanceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为云资源创建并绑定标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagCloudResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagCloudResourcesResponse
        /// </returns>
        public TagCloudResourcesResponse TagCloudResourcesWithOptions(TagCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagCloudResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<TagCloudResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<TagCloudResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为云资源创建并绑定标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagCloudResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagCloudResourcesResponse
        /// </returns>
        public async Task<TagCloudResourcesResponse> TagCloudResourcesWithOptionsAsync(TagCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagCloudResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<TagCloudResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<TagCloudResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为云资源创建并绑定标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagCloudResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagCloudResourcesResponse
        /// </returns>
        public TagCloudResourcesResponse TagCloudResources(TagCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagCloudResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为云资源创建并绑定标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagCloudResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagCloudResourcesResponse
        /// </returns>
        public async Task<TagCloudResourcesResponse> TagCloudResourcesAsync(TagCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagCloudResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a user and a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UnbindResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UnbindResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a user and a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UnbindResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UnbindResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a user and a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindResponse
        /// </returns>
        public UnbindResponse Unbind(UnbindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a user and a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindResponse
        /// </returns>
        public async Task<UnbindResponse> UnbindAsync(UnbindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from cloud resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagCloudResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagCloudResourcesResponse
        /// </returns>
        public UntagCloudResourcesResponse UntagCloudResourcesWithOptions(UntagCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                body["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagCloudResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UntagCloudResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UntagCloudResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from cloud resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagCloudResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagCloudResourcesResponse
        /// </returns>
        public async Task<UntagCloudResourcesResponse> UntagCloudResourcesWithOptionsAsync(UntagCloudResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                body["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagCloudResources",
                Version = "2021-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UntagCloudResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UntagCloudResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from cloud resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagCloudResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagCloudResourcesResponse
        /// </returns>
        public UntagCloudResourcesResponse UntagCloudResources(UntagCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagCloudResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from cloud resources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagCloudResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagCloudResourcesResponse
        /// </returns>
        public async Task<UntagCloudResourcesResponse> UntagCloudResourcesAsync(UntagCloudResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagCloudResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the image of a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Warning</b> After the image is updated, the end user session accessing the cloud application will be disconnected. Exercise caution to avoid end user data loss.<remarks>
        /// <para> After the image of the delivery group is updated, the change takes effect on the terminal in approximately 2 minutes.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAppInstanceGroupImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppInstanceGroupImageResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateAppInstanceGroupImageResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateAppInstanceGroupImageResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the image of a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Warning</b> After the image is updated, the end user session accessing the cloud application will be disconnected. Exercise caution to avoid end user data loss.<remarks>
        /// <para> After the image of the delivery group is updated, the change takes effect on the terminal in approximately 2 minutes.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAppInstanceGroupImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppInstanceGroupImageResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateAppInstanceGroupImageResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateAppInstanceGroupImageResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the image of a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Warning</b> After the image is updated, the end user session accessing the cloud application will be disconnected. Exercise caution to avoid end user data loss.<remarks>
        /// <para> After the image of the delivery group is updated, the change takes effect on the terminal in approximately 2 minutes.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAppInstanceGroupImageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppInstanceGroupImageResponse
        /// </returns>
        public UpdateAppInstanceGroupImageResponse UpdateAppInstanceGroupImage(UpdateAppInstanceGroupImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppInstanceGroupImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the image of a delivery group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description><b>Warning</b> After the image is updated, the end user session accessing the cloud application will be disconnected. Exercise caution to avoid end user data loss.<remarks>
        /// <para> After the image of the delivery group is updated, the change takes effect on the terminal in approximately 2 minutes.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateAppInstanceGroupImageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppInstanceGroupImageResponse
        /// </returns>
        public async Task<UpdateAppInstanceGroupImageResponse> UpdateAppInstanceGroupImageAsync(UpdateAppInstanceGroupImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppInstanceGroupImageWithOptionsAsync(request, runtime);
        }

    }
}
