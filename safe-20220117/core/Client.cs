// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Safe20220117.Models;

namespace AlibabaCloud.SDK.Safe20220117
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("safe", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>取消封网接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelBlockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelBlockResponse
        /// </returns>
        public CancelBlockResponse CancelBlockWithOptions(CancelBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockId))
            {
                body["BlockId"] = request.BlockId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelBLockDesc))
            {
                body["CancelBLockDesc"] = request.CancelBLockDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEmpId))
            {
                body["CreateEmpId"] = request.CreateEmpId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelBlock",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelBlockResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消封网接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelBlockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelBlockResponse
        /// </returns>
        public async Task<CancelBlockResponse> CancelBlockWithOptionsAsync(CancelBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockId))
            {
                body["BlockId"] = request.BlockId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CancelBLockDesc))
            {
                body["CancelBLockDesc"] = request.CancelBLockDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEmpId))
            {
                body["CreateEmpId"] = request.CreateEmpId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelBlock",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelBlockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消封网接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelBlockResponse
        /// </returns>
        public CancelBlockResponse CancelBlock(CancelBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelBlockWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消封网接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelBlockResponse
        /// </returns>
        public async Task<CancelBlockResponse> CancelBlockAsync(CancelBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelBlockWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更取消</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCancelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeCancelResponse
        /// </returns>
        public ChangeCancelResponse ChangeCancelWithOptions(ChangeCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                query["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                query["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                query["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeCancel",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeCancelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更取消</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCancelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeCancelResponse
        /// </returns>
        public async Task<ChangeCancelResponse> ChangeCancelWithOptionsAsync(ChangeCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                query["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                query["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                query["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeCancel",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeCancelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更取消</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCancelRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeCancelResponse
        /// </returns>
        public ChangeCancelResponse ChangeCancel(ChangeCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeCancelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更取消</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCancelRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeCancelResponse
        /// </returns>
        public async Task<ChangeCancelResponse> ChangeCancelAsync(ChangeCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeCancelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安全变更check</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ChangeCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeCheckResponse
        /// </returns>
        public ChangeCheckResponse ChangeCheckWithOptions(ChangeCheckRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ChangeCheckShrinkRequest request = new ChangeCheckShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DamagedChangeNotices))
            {
                request.DamagedChangeNoticesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DamagedChangeNotices, "DamagedChangeNotices", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AffectCustomer))
            {
                body["AffectCustomer"] = request.AffectCustomer;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveFlowParam))
            {
                bodyFlat["ApproveFlowParam"] = request.ApproveFlowParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgCustomTemplateExtraDTO))
            {
                bodyFlat["BgCustomTemplateExtraDTO"] = request.BgCustomTemplateExtraDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgVid))
            {
                body["BgVid"] = request.BgVid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockInfos))
            {
                body["BlockInfos"] = request.BlockInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallBackInfo))
            {
                bodyFlat["CallBackInfo"] = request.CallBackInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeDataType))
            {
                body["ChangeDataType"] = request.ChangeDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeDesc))
            {
                body["ChangeDesc"] = request.ChangeDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                body["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEnv))
            {
                body["ChangeEnv"] = request.ChangeEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeItems))
            {
                body["ChangeItems"] = request.ChangeItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeObject))
            {
                body["ChangeObject"] = request.ChangeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOptSubType))
            {
                body["ChangeOptSubType"] = request.ChangeOptSubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOptType))
            {
                body["ChangeOptType"] = request.ChangeOptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeReason))
            {
                body["ChangeReason"] = request.ChangeReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeRmarks))
            {
                body["ChangeRmarks"] = request.ChangeRmarks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSchemes))
            {
                body["ChangeSchemes"] = request.ChangeSchemes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeStartTime))
            {
                body["ChangeStartTime"] = request.ChangeStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSubTypeDesc))
            {
                body["ChangeSubTypeDesc"] = request.ChangeSubTypeDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSystem))
            {
                body["ChangeSystem"] = request.ChangeSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeTimes))
            {
                body["ChangeTimes"] = request.ChangeTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeTitle))
            {
                body["ChangeTitle"] = request.ChangeTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeValidation))
            {
                body["ChangeValidation"] = request.ChangeValidation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                body["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DamagedChangeNoticesShrink))
            {
                body["DamagedChangeNotices"] = request.DamagedChangeNoticesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorEmpId))
            {
                body["ExecutorEmpId"] = request.ExecutorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Follower))
            {
                body["Follower"] = request.Follower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayStatus))
            {
                body["GrayStatus"] = request.GrayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmChangeNoticeEnum))
            {
                body["HarmChangeNoticeEnum"] = request.HarmChangeNoticeEnum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Incidence))
            {
                body["Incidence"] = request.Incidence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfluenceInfo))
            {
                bodyFlat["InfluenceInfo"] = request.InfluenceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                bodyFlat["Instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedModifyDoc))
            {
                body["NeedModifyDoc"] = request.NeedModifyDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleasePackageInfos))
            {
                body["ReleasePackageInfos"] = request.ReleasePackageInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReuseSourceOrderId))
            {
                body["ReuseSourceOrderId"] = request.ReuseSourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rollback))
            {
                body["Rollback"] = request.Rollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceName))
            {
                body["SourceName"] = request.SourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUrl))
            {
                body["SourceUrl"] = request.SourceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteType))
            {
                body["WhiteType"] = request.WhiteType;
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
                Action = "ChangeCheck",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeCheckResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安全变更check</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ChangeCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeCheckResponse
        /// </returns>
        public async Task<ChangeCheckResponse> ChangeCheckWithOptionsAsync(ChangeCheckRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ChangeCheckShrinkRequest request = new ChangeCheckShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DamagedChangeNotices))
            {
                request.DamagedChangeNoticesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DamagedChangeNotices, "DamagedChangeNotices", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AffectCustomer))
            {
                body["AffectCustomer"] = request.AffectCustomer;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveFlowParam))
            {
                bodyFlat["ApproveFlowParam"] = request.ApproveFlowParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgCustomTemplateExtraDTO))
            {
                bodyFlat["BgCustomTemplateExtraDTO"] = request.BgCustomTemplateExtraDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgVid))
            {
                body["BgVid"] = request.BgVid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockInfos))
            {
                body["BlockInfos"] = request.BlockInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallBackInfo))
            {
                bodyFlat["CallBackInfo"] = request.CallBackInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeDataType))
            {
                body["ChangeDataType"] = request.ChangeDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeDesc))
            {
                body["ChangeDesc"] = request.ChangeDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                body["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEnv))
            {
                body["ChangeEnv"] = request.ChangeEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeItems))
            {
                body["ChangeItems"] = request.ChangeItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeObject))
            {
                body["ChangeObject"] = request.ChangeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOptSubType))
            {
                body["ChangeOptSubType"] = request.ChangeOptSubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOptType))
            {
                body["ChangeOptType"] = request.ChangeOptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeReason))
            {
                body["ChangeReason"] = request.ChangeReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeRmarks))
            {
                body["ChangeRmarks"] = request.ChangeRmarks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSchemes))
            {
                body["ChangeSchemes"] = request.ChangeSchemes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeStartTime))
            {
                body["ChangeStartTime"] = request.ChangeStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSubTypeDesc))
            {
                body["ChangeSubTypeDesc"] = request.ChangeSubTypeDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSystem))
            {
                body["ChangeSystem"] = request.ChangeSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeTimes))
            {
                body["ChangeTimes"] = request.ChangeTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeTitle))
            {
                body["ChangeTitle"] = request.ChangeTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeValidation))
            {
                body["ChangeValidation"] = request.ChangeValidation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                body["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DamagedChangeNoticesShrink))
            {
                body["DamagedChangeNotices"] = request.DamagedChangeNoticesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorEmpId))
            {
                body["ExecutorEmpId"] = request.ExecutorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Follower))
            {
                body["Follower"] = request.Follower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayStatus))
            {
                body["GrayStatus"] = request.GrayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmChangeNoticeEnum))
            {
                body["HarmChangeNoticeEnum"] = request.HarmChangeNoticeEnum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Incidence))
            {
                body["Incidence"] = request.Incidence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfluenceInfo))
            {
                bodyFlat["InfluenceInfo"] = request.InfluenceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                bodyFlat["Instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedModifyDoc))
            {
                body["NeedModifyDoc"] = request.NeedModifyDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleasePackageInfos))
            {
                body["ReleasePackageInfos"] = request.ReleasePackageInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReuseSourceOrderId))
            {
                body["ReuseSourceOrderId"] = request.ReuseSourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rollback))
            {
                body["Rollback"] = request.Rollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceName))
            {
                body["SourceName"] = request.SourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUrl))
            {
                body["SourceUrl"] = request.SourceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteType))
            {
                body["WhiteType"] = request.WhiteType;
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
                Action = "ChangeCheck",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安全变更check</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeCheckResponse
        /// </returns>
        public ChangeCheckResponse ChangeCheck(ChangeCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeCheckWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安全变更check</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeCheckResponse
        /// </returns>
        public async Task<ChangeCheckResponse> ChangeCheckAsync(ChangeCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeCheckWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更执行end</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeEndRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeEndResponse
        /// </returns>
        public ChangeEndResponse ChangeEndWithOptions(ChangeEndRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                query["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                query["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeResult))
            {
                query["ChangeResult"] = request.ChangeResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurBatchNo))
            {
                query["CurBatchNo"] = request.CurBatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorEmpId))
            {
                query["ExecutorEmpId"] = request.ExecutorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                query["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                query["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalBatchNo))
            {
                query["TotalBatchNo"] = request.TotalBatchNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeEnd",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeEndResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更执行end</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeEndRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeEndResponse
        /// </returns>
        public async Task<ChangeEndResponse> ChangeEndWithOptionsAsync(ChangeEndRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                query["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                query["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeResult))
            {
                query["ChangeResult"] = request.ChangeResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurBatchNo))
            {
                query["CurBatchNo"] = request.CurBatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorEmpId))
            {
                query["ExecutorEmpId"] = request.ExecutorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                query["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                query["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalBatchNo))
            {
                query["TotalBatchNo"] = request.TotalBatchNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeEnd",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeEndResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更执行end</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeEndRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeEndResponse
        /// </returns>
        public ChangeEndResponse ChangeEnd(ChangeEndRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeEndWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更执行end</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeEndRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeEndResponse
        /// </returns>
        public async Task<ChangeEndResponse> ChangeEndAsync(ChangeEndRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeEndWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更执行start</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeStartRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeStartResponse
        /// </returns>
        public ChangeStartResponse ChangeStartWithOptions(ChangeStartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                query["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                query["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeObject))
            {
                query["ChangeObject"] = request.ChangeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOptType))
            {
                query["ChangeOptType"] = request.ChangeOptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeStartTime))
            {
                query["ChangeStartTime"] = request.ChangeStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeTitle))
            {
                query["ChangeTitle"] = request.ChangeTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                query["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurBatchNo))
            {
                query["CurBatchNo"] = request.CurBatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorEmpId))
            {
                query["ExecutorEmpId"] = request.ExecutorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                query["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                query["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalBatchNo))
            {
                query["TotalBatchNo"] = request.TotalBatchNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeStart",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeStartResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更执行start</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeStartRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeStartResponse
        /// </returns>
        public async Task<ChangeStartResponse> ChangeStartWithOptionsAsync(ChangeStartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                query["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                query["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeObject))
            {
                query["ChangeObject"] = request.ChangeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOptType))
            {
                query["ChangeOptType"] = request.ChangeOptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeStartTime))
            {
                query["ChangeStartTime"] = request.ChangeStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeTitle))
            {
                query["ChangeTitle"] = request.ChangeTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                query["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurBatchNo))
            {
                query["CurBatchNo"] = request.CurBatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorEmpId))
            {
                query["ExecutorEmpId"] = request.ExecutorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                query["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                query["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalBatchNo))
            {
                query["TotalBatchNo"] = request.TotalBatchNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeStart",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeStartResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更执行start</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeStartRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeStartResponse
        /// </returns>
        public ChangeStartResponse ChangeStart(ChangeStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeStartWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更执行start</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeStartRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeStartResponse
        /// </returns>
        public async Task<ChangeStartResponse> ChangeStartAsync(ChangeStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeStartWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方创建封网接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBlockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBlockResponse
        /// </returns>
        public CreateBlockResponse CreateBlockWithOptions(CreateBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveStrategyNodes))
            {
                bodyFlat["ApproveStrategyNodes"] = request.ApproveStrategyNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockId))
            {
                body["BlockId"] = request.BlockId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Director))
            {
                body["Director"] = request.Director;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsNeedApprove))
            {
                body["IsNeedApprove"] = request.IsNeedApprove;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecall))
            {
                body["IsRecall"] = request.IsRecall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsTemplate))
            {
                body["IsTemplate"] = request.IsTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelName))
            {
                body["LabelName"] = request.LabelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeDesc))
            {
                body["NoticeDesc"] = request.NoticeDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeEnclosureInfos))
            {
                bodyFlat["NoticeEnclosureInfos"] = request.NoticeEnclosureInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeRequestLink))
            {
                body["NoticeRequestLink"] = request.NoticeRequestLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeType))
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scopes))
            {
                bodyFlat["Scopes"] = request.Scopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["VersionId"] = request.VersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                body["creatorEmpId"] = request.CreatorEmpId;
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
                Action = "CreateBlock",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBlockResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方创建封网接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBlockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBlockResponse
        /// </returns>
        public async Task<CreateBlockResponse> CreateBlockWithOptionsAsync(CreateBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveStrategyNodes))
            {
                bodyFlat["ApproveStrategyNodes"] = request.ApproveStrategyNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockId))
            {
                body["BlockId"] = request.BlockId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Director))
            {
                body["Director"] = request.Director;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsNeedApprove))
            {
                body["IsNeedApprove"] = request.IsNeedApprove;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecall))
            {
                body["IsRecall"] = request.IsRecall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsTemplate))
            {
                body["IsTemplate"] = request.IsTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelName))
            {
                body["LabelName"] = request.LabelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeDesc))
            {
                body["NoticeDesc"] = request.NoticeDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeEnclosureInfos))
            {
                bodyFlat["NoticeEnclosureInfos"] = request.NoticeEnclosureInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeRequestLink))
            {
                body["NoticeRequestLink"] = request.NoticeRequestLink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeType))
            {
                body["NoticeType"] = request.NoticeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scopes))
            {
                bodyFlat["Scopes"] = request.Scopes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                body["VersionId"] = request.VersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                body["creatorEmpId"] = request.CreatorEmpId;
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
                Action = "CreateBlock",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBlockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方创建封网接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBlockResponse
        /// </returns>
        public CreateBlockResponse CreateBlock(CreateBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBlockWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>三方创建封网接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBlockResponse
        /// </returns>
        public async Task<CreateBlockResponse> CreateBlockAsync(CreateBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBlockWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建蚂蚁封网接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateMaYiBlockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMaYiBlockResponse
        /// </returns>
        public CreateMaYiBlockResponse CreateMaYiBlockWithOptions(CreateMaYiBlockRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMaYiBlockShrinkRequest request = new CreateMaYiBlockShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scope))
            {
                request.ScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scope, "Scope", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockId))
            {
                body["BlockId"] = request.BlockId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockTimes))
            {
                body["BlockTimes"] = request.BlockTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockType))
            {
                body["BlockType"] = request.BlockType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                body["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Director))
            {
                body["Director"] = request.Director;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultVersion))
            {
                body["FaultVersion"] = request.FaultVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Information))
            {
                body["Information"] = request.Information;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeShrink))
            {
                body["Scope"] = request.ScopeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMaYiBlock",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMaYiBlockResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建蚂蚁封网接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateMaYiBlockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMaYiBlockResponse
        /// </returns>
        public async Task<CreateMaYiBlockResponse> CreateMaYiBlockWithOptionsAsync(CreateMaYiBlockRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMaYiBlockShrinkRequest request = new CreateMaYiBlockShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scope))
            {
                request.ScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scope, "Scope", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockId))
            {
                body["BlockId"] = request.BlockId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockTimes))
            {
                body["BlockTimes"] = request.BlockTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockType))
            {
                body["BlockType"] = request.BlockType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                body["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Director))
            {
                body["Director"] = request.Director;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultVersion))
            {
                body["FaultVersion"] = request.FaultVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Information))
            {
                body["Information"] = request.Information;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScopeShrink))
            {
                body["Scope"] = request.ScopeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMaYiBlock",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMaYiBlockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建蚂蚁封网接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMaYiBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMaYiBlockResponse
        /// </returns>
        public CreateMaYiBlockResponse CreateMaYiBlock(CreateMaYiBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMaYiBlockWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建蚂蚁封网接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMaYiBlockRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMaYiBlockResponse
        /// </returns>
        public async Task<CreateMaYiBlockResponse> CreateMaYiBlockAsync(CreateMaYiBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMaYiBlockWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建操作类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOperatorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOperatorResponse
        /// </returns>
        public CreateOperatorResponse CreateOperatorWithOptions(CreateOperatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgObject))
            {
                body["BgObject"] = request.BgObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgSystem))
            {
                body["BgSystem"] = request.BgSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurEmpId))
            {
                body["CurEmpId"] = request.CurEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoCheck))
            {
                body["NoCheck"] = request.NoCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoRisk))
            {
                body["NoRisk"] = request.NoRisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOperator",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOperatorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建操作类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOperatorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOperatorResponse
        /// </returns>
        public async Task<CreateOperatorResponse> CreateOperatorWithOptionsAsync(CreateOperatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgObject))
            {
                body["BgObject"] = request.BgObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgSystem))
            {
                body["BgSystem"] = request.BgSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurEmpId))
            {
                body["CurEmpId"] = request.CurEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoCheck))
            {
                body["NoCheck"] = request.NoCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoRisk))
            {
                body["NoRisk"] = request.NoRisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOperator",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOperatorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建操作类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOperatorRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOperatorResponse
        /// </returns>
        public CreateOperatorResponse CreateOperator(CreateOperatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOperatorWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建操作类型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOperatorRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOperatorResponse
        /// </returns>
        public async Task<CreateOperatorResponse> CreateOperatorAsync(CreateOperatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOperatorWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResponse
        /// </returns>
        public QueryResponse QueryWithOptions(QueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                query["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedValidate))
            {
                query["NeedValidate"] = request.NeedValidate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                query["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                query["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Query",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResponse
        /// </returns>
        public async Task<QueryResponse> QueryWithOptionsAsync(QueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                query["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedValidate))
            {
                query["NeedValidate"] = request.NeedValidate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                query["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                query["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Query",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryResponse
        /// </returns>
        public QueryResponse Query(QueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryResponse
        /// </returns>
        public async Task<QueryResponse> QueryAsync(QueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryApproveFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryApproveFlowResponse
        /// </returns>
        public QueryApproveFlowResponse QueryApproveFlowWithOptions(QueryApproveFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                query["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                query["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                query["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stage))
            {
                query["Stage"] = request.Stage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryApproveFlow",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryApproveFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryApproveFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryApproveFlowResponse
        /// </returns>
        public async Task<QueryApproveFlowResponse> QueryApproveFlowWithOptionsAsync(QueryApproveFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                query["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                query["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                query["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stage))
            {
                query["Stage"] = request.Stage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryApproveFlow",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryApproveFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryApproveFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryApproveFlowResponse
        /// </returns>
        public QueryApproveFlowResponse QueryApproveFlow(QueryApproveFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryApproveFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryApproveFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryApproveFlowResponse
        /// </returns>
        public async Task<QueryApproveFlowResponse> QueryApproveFlowAsync(QueryApproveFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryApproveFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查封网事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlockEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBlockEventResponse
        /// </returns>
        public QueryBlockEventResponse QueryBlockEventWithOptions(QueryBlockEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgSystemName))
            {
                body["BgSystemName"] = request.BgSystemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockHarm))
            {
                body["BlockHarm"] = request.BlockHarm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptNo))
            {
                body["DeptNo"] = request.DeptNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRule))
            {
                body["NeedRule"] = request.NeedRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCodes))
            {
                body["ProductCodes"] = request.ProductCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionReqs))
            {
                body["RegionReqs"] = request.RegionReqs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBlockEvent",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBlockEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查封网事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlockEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBlockEventResponse
        /// </returns>
        public async Task<QueryBlockEventResponse> QueryBlockEventWithOptionsAsync(QueryBlockEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgSystemName))
            {
                body["BgSystemName"] = request.BgSystemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockHarm))
            {
                body["BlockHarm"] = request.BlockHarm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptNo))
            {
                body["DeptNo"] = request.DeptNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedRule))
            {
                body["NeedRule"] = request.NeedRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCodes))
            {
                body["ProductCodes"] = request.ProductCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionReqs))
            {
                body["RegionReqs"] = request.RegionReqs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBlockEvent",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBlockEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查封网事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlockEventRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBlockEventResponse
        /// </returns>
        public QueryBlockEventResponse QueryBlockEvent(QueryBlockEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBlockEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查封网事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBlockEventRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBlockEventResponse
        /// </returns>
        public async Task<QueryBlockEventResponse> QueryBlockEventAsync(QueryBlockEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBlockEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChangeInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChangeInfoResponse
        /// </returns>
        public QueryChangeInfoResponse QueryChangeInfoWithOptions(QueryChangeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Az))
            {
                body["Az"] = request.Az;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgVid))
            {
                body["BgVid"] = request.BgVid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuId))
            {
                body["BuId"] = request.BuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSystem))
            {
                body["ChangeSystem"] = request.ChangeSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LevelTree))
            {
                bodyFlat["LevelTree"] = request.LevelTree;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChangeInfo",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChangeInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChangeInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChangeInfoResponse
        /// </returns>
        public async Task<QueryChangeInfoResponse> QueryChangeInfoWithOptionsAsync(QueryChangeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Az))
            {
                body["Az"] = request.Az;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgVid))
            {
                body["BgVid"] = request.BgVid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuId))
            {
                body["BuId"] = request.BuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSystem))
            {
                body["ChangeSystem"] = request.ChangeSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LevelTree))
            {
                bodyFlat["LevelTree"] = request.LevelTree;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChangeInfo",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChangeInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChangeInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChangeInfoResponse
        /// </returns>
        public QueryChangeInfoResponse QueryChangeInfo(QueryChangeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryChangeInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChangeInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChangeInfoResponse
        /// </returns>
        public async Task<QueryChangeInfoResponse> QueryChangeInfoAsync(QueryChangeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryChangeInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询检测详情接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCheckInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCheckInfoResponse
        /// </returns>
        public QueryCheckInfoResponse QueryCheckInfoWithOptions(QueryCheckInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCheckInfo",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCheckInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询检测详情接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCheckInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCheckInfoResponse
        /// </returns>
        public async Task<QueryCheckInfoResponse> QueryCheckInfoWithOptionsAsync(QueryCheckInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCheckInfo",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCheckInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询检测详情接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCheckInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCheckInfoResponse
        /// </returns>
        public QueryCheckInfoResponse QueryCheckInfo(QueryCheckInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCheckInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询检测详情接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCheckInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCheckInfoResponse
        /// </returns>
        public async Task<QueryCheckInfoResponse> QueryCheckInfoAsync(QueryCheckInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCheckInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询敏感客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerResponse
        /// </returns>
        public QueryCustomerResponse QueryCustomerWithOptions(QueryCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomer",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询敏感客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerResponse
        /// </returns>
        public async Task<QueryCustomerResponse> QueryCustomerWithOptionsAsync(QueryCustomerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomer",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询敏感客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerResponse
        /// </returns>
        public QueryCustomerResponse QueryCustomer(QueryCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询敏感客户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerResponse
        /// </returns>
        public async Task<QueryCustomerResponse> QueryCustomerAsync(QueryCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExecuteInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExecuteInfoResponse
        /// </returns>
        public QueryExecuteInfoResponse QueryExecuteInfoWithOptions(QueryExecuteInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Az))
            {
                body["Az"] = request.Az;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgVid))
            {
                body["BgVid"] = request.BgVid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuId))
            {
                body["BuId"] = request.BuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExVid))
            {
                body["ExVid"] = request.ExVid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LevelTree))
            {
                bodyFlat["LevelTree"] = request.LevelTree;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
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
                Action = "QueryExecuteInfo",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExecuteInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExecuteInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExecuteInfoResponse
        /// </returns>
        public async Task<QueryExecuteInfoResponse> QueryExecuteInfoWithOptionsAsync(QueryExecuteInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Az))
            {
                body["Az"] = request.Az;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgVid))
            {
                body["BgVid"] = request.BgVid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuId))
            {
                body["BuId"] = request.BuId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExVid))
            {
                body["ExVid"] = request.ExVid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["Keyword"] = request.Keyword;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LevelTree))
            {
                bodyFlat["LevelTree"] = request.LevelTree;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
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
                Action = "QueryExecuteInfo",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExecuteInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExecuteInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExecuteInfoResponse
        /// </returns>
        public QueryExecuteInfoResponse QueryExecuteInfo(QueryExecuteInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryExecuteInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExecuteInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExecuteInfoResponse
        /// </returns>
        public async Task<QueryExecuteInfoResponse> QueryExecuteInfoAsync(QueryExecuteInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryExecuteInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询内部产品接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInnerProductInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInnerProductInfoResponse
        /// </returns>
        public QueryInnerProductInfoResponse QueryInnerProductInfoWithOptions(QueryInnerProductInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInnerProductInfo",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInnerProductInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询内部产品接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInnerProductInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInnerProductInfoResponse
        /// </returns>
        public async Task<QueryInnerProductInfoResponse> QueryInnerProductInfoWithOptionsAsync(QueryInnerProductInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryInnerProductInfo",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInnerProductInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询内部产品接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInnerProductInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInnerProductInfoResponse
        /// </returns>
        public QueryInnerProductInfoResponse QueryInnerProductInfo(QueryInnerProductInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInnerProductInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询内部产品接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInnerProductInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInnerProductInfoResponse
        /// </returns>
        public async Task<QueryInnerProductInfoResponse> QueryInnerProductInfoAsync(QueryInnerProductInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInnerProductInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryRegionAzRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRegionAzResponse
        /// </returns>
        public QueryRegionAzResponse QueryRegionAzWithOptions(QueryRegionAzRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRegionAz",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRegionAzResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryRegionAzRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRegionAzResponse
        /// </returns>
        public async Task<QueryRegionAzResponse> QueryRegionAzWithOptionsAsync(QueryRegionAzRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRegionAz",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRegionAzResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryRegionAzRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRegionAzResponse
        /// </returns>
        public QueryRegionAzResponse QueryRegionAz(QueryRegionAzRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRegionAzWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryRegionAzRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRegionAzResponse
        /// </returns>
        public async Task<QueryRegionAzResponse> QueryRegionAzAsync(QueryRegionAzRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRegionAzWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更取消接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeCancelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeCancelResponse
        /// </returns>
        public SafeChangeCancelResponse SafeChangeCancelWithOptions(SafeChangeCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgVid))
            {
                body["BgVid"] = request.BgVid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateEmpNo))
            {
                body["OperateEmpNo"] = request.OperateEmpNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeCancel",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeCancelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更取消接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeCancelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeCancelResponse
        /// </returns>
        public async Task<SafeChangeCancelResponse> SafeChangeCancelWithOptionsAsync(SafeChangeCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgVid))
            {
                body["BgVid"] = request.BgVid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateEmpNo))
            {
                body["OperateEmpNo"] = request.OperateEmpNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeCancel",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeCancelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更取消接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeCancelRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeCancelResponse
        /// </returns>
        public SafeChangeCancelResponse SafeChangeCancel(SafeChangeCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SafeChangeCancelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更取消接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeCancelRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeCancelResponse
        /// </returns>
        public async Task<SafeChangeCancelResponse> SafeChangeCancelAsync(SafeChangeCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SafeChangeCancelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更check接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SafeChangeCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeCheckResponse
        /// </returns>
        public SafeChangeCheckResponse SafeChangeCheckWithOptions(SafeChangeCheckRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SafeChangeCheckShrinkRequest request = new SafeChangeCheckShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HarmNoticeCombineParam))
            {
                request.HarmNoticeCombineParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HarmNoticeCombineParam, "HarmNoticeCombineParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checker))
            {
                query["Checker"] = request.Checker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmChangeNoticeEnum))
            {
                query["HarmChangeNoticeEnum"] = request.HarmChangeNoticeEnum;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AffectCustomer))
            {
                body["AffectCustomer"] = request.AffectCustomer;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveFlowParam))
            {
                bodyFlat["ApproveFlowParam"] = request.ApproveFlowParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgCustomTemplateExtraDTO))
            {
                bodyFlat["BgCustomTemplateExtraDTO"] = request.BgCustomTemplateExtraDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockInfos))
            {
                body["BlockInfos"] = request.BlockInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallBackInfo))
            {
                bodyFlat["CallBackInfo"] = request.CallBackInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeDataType))
            {
                body["ChangeDataType"] = request.ChangeDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeDesc))
            {
                body["ChangeDesc"] = request.ChangeDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                body["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEnv))
            {
                body["ChangeEnv"] = request.ChangeEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeItems))
            {
                body["ChangeItems"] = request.ChangeItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeObject))
            {
                body["ChangeObject"] = request.ChangeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOptSubType))
            {
                body["ChangeOptSubType"] = request.ChangeOptSubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOptType))
            {
                body["ChangeOptType"] = request.ChangeOptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeReason))
            {
                body["ChangeReason"] = request.ChangeReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeRmarks))
            {
                body["ChangeRmarks"] = request.ChangeRmarks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSchemes))
            {
                body["ChangeSchemes"] = request.ChangeSchemes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeStartTime))
            {
                body["ChangeStartTime"] = request.ChangeStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSubTypeDesc))
            {
                body["ChangeSubTypeDesc"] = request.ChangeSubTypeDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSystem))
            {
                body["ChangeSystem"] = request.ChangeSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeTimes))
            {
                body["ChangeTimes"] = request.ChangeTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeTitle))
            {
                body["ChangeTitle"] = request.ChangeTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeValidation))
            {
                body["ChangeValidation"] = request.ChangeValidation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                body["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DamagedChangeNotices))
            {
                bodyFlat["DamagedChangeNotices"] = request.DamagedChangeNotices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorEmpId))
            {
                body["ExecutorEmpId"] = request.ExecutorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Follower))
            {
                body["Follower"] = request.Follower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayStatus))
            {
                body["GrayStatus"] = request.GrayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmNoticeCombineParamShrink))
            {
                body["HarmNoticeCombineParam"] = request.HarmNoticeCombineParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Incidence))
            {
                body["Incidence"] = request.Incidence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfluenceInfo))
            {
                bodyFlat["InfluenceInfo"] = request.InfluenceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                bodyFlat["Instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedModifyDoc))
            {
                body["NeedModifyDoc"] = request.NeedModifyDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateEmpNo))
            {
                body["OperateEmpNo"] = request.OperateEmpNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleasePackageInfos))
            {
                body["ReleasePackageInfos"] = request.ReleasePackageInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReuseSourceOrderId))
            {
                body["ReuseSourceOrderId"] = request.ReuseSourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rollback))
            {
                body["Rollback"] = request.Rollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceName))
            {
                body["SourceName"] = request.SourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUrl))
            {
                body["SourceUrl"] = request.SourceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteType))
            {
                body["whiteType"] = request.WhiteType;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeCheck",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeCheckResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更check接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SafeChangeCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeCheckResponse
        /// </returns>
        public async Task<SafeChangeCheckResponse> SafeChangeCheckWithOptionsAsync(SafeChangeCheckRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SafeChangeCheckShrinkRequest request = new SafeChangeCheckShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HarmNoticeCombineParam))
            {
                request.HarmNoticeCombineParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HarmNoticeCombineParam, "HarmNoticeCombineParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checker))
            {
                query["Checker"] = request.Checker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmChangeNoticeEnum))
            {
                query["HarmChangeNoticeEnum"] = request.HarmChangeNoticeEnum;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AffectCustomer))
            {
                body["AffectCustomer"] = request.AffectCustomer;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveFlowParam))
            {
                bodyFlat["ApproveFlowParam"] = request.ApproveFlowParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgCustomTemplateExtraDTO))
            {
                bodyFlat["BgCustomTemplateExtraDTO"] = request.BgCustomTemplateExtraDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockInfos))
            {
                body["BlockInfos"] = request.BlockInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallBackInfo))
            {
                bodyFlat["CallBackInfo"] = request.CallBackInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeDataType))
            {
                body["ChangeDataType"] = request.ChangeDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeDesc))
            {
                body["ChangeDesc"] = request.ChangeDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                body["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEnv))
            {
                body["ChangeEnv"] = request.ChangeEnv;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeItems))
            {
                body["ChangeItems"] = request.ChangeItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeObject))
            {
                body["ChangeObject"] = request.ChangeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOptSubType))
            {
                body["ChangeOptSubType"] = request.ChangeOptSubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOptType))
            {
                body["ChangeOptType"] = request.ChangeOptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeReason))
            {
                body["ChangeReason"] = request.ChangeReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeRmarks))
            {
                body["ChangeRmarks"] = request.ChangeRmarks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSchemes))
            {
                body["ChangeSchemes"] = request.ChangeSchemes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeStartTime))
            {
                body["ChangeStartTime"] = request.ChangeStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSubTypeDesc))
            {
                body["ChangeSubTypeDesc"] = request.ChangeSubTypeDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeSystem))
            {
                body["ChangeSystem"] = request.ChangeSystem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeTimes))
            {
                body["ChangeTimes"] = request.ChangeTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeTitle))
            {
                body["ChangeTitle"] = request.ChangeTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeValidation))
            {
                body["ChangeValidation"] = request.ChangeValidation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                body["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DamagedChangeNotices))
            {
                bodyFlat["DamagedChangeNotices"] = request.DamagedChangeNotices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorEmpId))
            {
                body["ExecutorEmpId"] = request.ExecutorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Follower))
            {
                body["Follower"] = request.Follower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayStatus))
            {
                body["GrayStatus"] = request.GrayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HarmNoticeCombineParamShrink))
            {
                body["HarmNoticeCombineParam"] = request.HarmNoticeCombineParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Incidence))
            {
                body["Incidence"] = request.Incidence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfluenceInfo))
            {
                bodyFlat["InfluenceInfo"] = request.InfluenceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instance))
            {
                bodyFlat["Instance"] = request.Instance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedModifyDoc))
            {
                body["NeedModifyDoc"] = request.NeedModifyDoc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateEmpNo))
            {
                body["OperateEmpNo"] = request.OperateEmpNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Product))
            {
                body["Product"] = request.Product;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleasePackageInfos))
            {
                body["ReleasePackageInfos"] = request.ReleasePackageInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReuseSourceOrderId))
            {
                body["ReuseSourceOrderId"] = request.ReuseSourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rollback))
            {
                body["Rollback"] = request.Rollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceName))
            {
                body["SourceName"] = request.SourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUrl))
            {
                body["SourceUrl"] = request.SourceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteType))
            {
                body["whiteType"] = request.WhiteType;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeCheck",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更check接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeCheckResponse
        /// </returns>
        public SafeChangeCheckResponse SafeChangeCheck(SafeChangeCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SafeChangeCheckWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更check接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeCheckResponse
        /// </returns>
        public async Task<SafeChangeCheckResponse> SafeChangeCheckAsync(SafeChangeCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SafeChangeCheckWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更End接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeEndRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeEndResponse
        /// </returns>
        public SafeChangeEndResponse SafeChangeEndWithOptions(SafeChangeEndRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                body["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeResult))
            {
                body["ChangeResult"] = request.ChangeResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurBatchNo))
            {
                body["CurBatchNo"] = request.CurBatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorEmpId))
            {
                body["ExecutorEmpId"] = request.ExecutorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalBatchNo))
            {
                body["TotalBatchNo"] = request.TotalBatchNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeEnd",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeEndResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更End接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeEndRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeEndResponse
        /// </returns>
        public async Task<SafeChangeEndResponse> SafeChangeEndWithOptionsAsync(SafeChangeEndRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                body["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeResult))
            {
                body["ChangeResult"] = request.ChangeResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurBatchNo))
            {
                body["CurBatchNo"] = request.CurBatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorEmpId))
            {
                body["ExecutorEmpId"] = request.ExecutorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalBatchNo))
            {
                body["TotalBatchNo"] = request.TotalBatchNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeEnd",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeEndResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更End接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeEndRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeEndResponse
        /// </returns>
        public SafeChangeEndResponse SafeChangeEnd(SafeChangeEndRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SafeChangeEndWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更End接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeEndRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeEndResponse
        /// </returns>
        public async Task<SafeChangeEndResponse> SafeChangeEndAsync(SafeChangeEndRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SafeChangeEndWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更单查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeQueryResponse
        /// </returns>
        public SafeChangeQueryResponse SafeChangeQueryWithOptions(SafeChangeQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnType))
            {
                query["ReturnType"] = request.ReturnType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedValidate))
            {
                body["NeedValidate"] = request.NeedValidate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeQuery",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeQueryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更单查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeQueryResponse
        /// </returns>
        public async Task<SafeChangeQueryResponse> SafeChangeQueryWithOptionsAsync(SafeChangeQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnType))
            {
                query["ReturnType"] = request.ReturnType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedValidate))
            {
                body["NeedValidate"] = request.NeedValidate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                body["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeQuery",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更单查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeQueryResponse
        /// </returns>
        public SafeChangeQueryResponse SafeChangeQuery(SafeChangeQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SafeChangeQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更单查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeQueryResponse
        /// </returns>
        public async Task<SafeChangeQueryResponse> SafeChangeQueryAsync(SafeChangeQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SafeChangeQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeQueryApproveFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeQueryApproveFlowResponse
        /// </returns>
        public SafeChangeQueryApproveFlowResponse SafeChangeQueryApproveFlowWithOptions(SafeChangeQueryApproveFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stage))
            {
                body["Stage"] = request.Stage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeQueryApproveFlow",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeQueryApproveFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeQueryApproveFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeQueryApproveFlowResponse
        /// </returns>
        public async Task<SafeChangeQueryApproveFlowResponse> SafeChangeQueryApproveFlowWithOptionsAsync(SafeChangeQueryApproveFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stage))
            {
                body["Stage"] = request.Stage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeQueryApproveFlow",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeQueryApproveFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeQueryApproveFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeQueryApproveFlowResponse
        /// </returns>
        public SafeChangeQueryApproveFlowResponse SafeChangeQueryApproveFlow(SafeChangeQueryApproveFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SafeChangeQueryApproveFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批实例信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeQueryApproveFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeQueryApproveFlowResponse
        /// </returns>
        public async Task<SafeChangeQueryApproveFlowResponse> SafeChangeQueryApproveFlowAsync(SafeChangeQueryApproveFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SafeChangeQueryApproveFlowWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更Start接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeStartRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeStartResponse
        /// </returns>
        public SafeChangeStartResponse SafeChangeStartWithOptions(SafeChangeStartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                body["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeObject))
            {
                body["ChangeObject"] = request.ChangeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOptType))
            {
                body["ChangeOptType"] = request.ChangeOptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeStartTime))
            {
                body["ChangeStartTime"] = request.ChangeStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeTitle))
            {
                body["ChangeTitle"] = request.ChangeTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                body["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurBatchNo))
            {
                body["CurBatchNo"] = request.CurBatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorEmpId))
            {
                body["ExecutorEmpId"] = request.ExecutorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalBatchNo))
            {
                body["TotalBatchNo"] = request.TotalBatchNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeStart",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeStartResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更Start接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeStartRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeStartResponse
        /// </returns>
        public async Task<SafeChangeStartResponse> SafeChangeStartWithOptionsAsync(SafeChangeStartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeEndTime))
            {
                body["ChangeEndTime"] = request.ChangeEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeObject))
            {
                body["ChangeObject"] = request.ChangeObject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOptType))
            {
                body["ChangeOptType"] = request.ChangeOptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeStartTime))
            {
                body["ChangeStartTime"] = request.ChangeStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeTitle))
            {
                body["ChangeTitle"] = request.ChangeTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                body["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurBatchNo))
            {
                body["CurBatchNo"] = request.CurBatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorEmpId))
            {
                body["ExecutorEmpId"] = request.ExecutorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalBatchNo))
            {
                body["TotalBatchNo"] = request.TotalBatchNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeStart",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeStartResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更Start接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeStartRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeStartResponse
        /// </returns>
        public SafeChangeStartResponse SafeChangeStart(SafeChangeStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SafeChangeStartWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>变更Start接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeStartRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeStartResponse
        /// </returns>
        public async Task<SafeChangeStartResponse> SafeChangeStartAsync(SafeChangeStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SafeChangeStartWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeStartApproveRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeStartApproveResponse
        /// </returns>
        public SafeChangeStartApproveResponse SafeChangeStartApproveWithOptions(SafeChangeStartApproveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                body["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeStartApprove",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeStartApproveResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeStartApproveRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeStartApproveResponse
        /// </returns>
        public async Task<SafeChangeStartApproveResponse> SafeChangeStartApproveWithOptionsAsync(SafeChangeStartApproveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                body["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                body["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                body["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeChangeStartApprove",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeChangeStartApproveResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeStartApproveRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeStartApproveResponse
        /// </returns>
        public SafeChangeStartApproveResponse SafeChangeStartApprove(SafeChangeStartApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SafeChangeStartApproveWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeChangeStartApproveRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeChangeStartApproveResponse
        /// </returns>
        public async Task<SafeChangeStartApproveResponse> SafeChangeStartApproveAsync(SafeChangeStartApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SafeChangeStartApproveWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>封网范围数据查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeScopeDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeScopeDataResponse
        /// </returns>
        public SafeScopeDataResponse SafeScopeDataWithOptions(SafeScopeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeList))
            {
                body["CodeList"] = request.CodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Factor))
            {
                body["Factor"] = request.Factor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                body["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdList))
            {
                body["IdList"] = request.IdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Item))
            {
                body["Item"] = request.Item;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                body["NeedTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["OrderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCode))
            {
                body["ParentCode"] = request.ParentCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNameEn))
            {
                body["RegionNameEn"] = request.RegionNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeScopeData",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeScopeDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>封网范围数据查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeScopeDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SafeScopeDataResponse
        /// </returns>
        public async Task<SafeScopeDataResponse> SafeScopeDataWithOptionsAsync(SafeScopeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeList))
            {
                body["CodeList"] = request.CodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Factor))
            {
                body["Factor"] = request.Factor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                body["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdList))
            {
                body["IdList"] = request.IdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Item))
            {
                body["Item"] = request.Item;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTotalCount))
            {
                body["NeedTotalCount"] = request.NeedTotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["OrderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentCode))
            {
                body["ParentCode"] = request.ParentCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["ParentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNameEn))
            {
                body["RegionNameEn"] = request.RegionNameEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchValue))
            {
                body["SearchValue"] = request.SearchValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["Uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SafeScopeData",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SafeScopeDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>封网范围数据查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeScopeDataRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeScopeDataResponse
        /// </returns>
        public SafeScopeDataResponse SafeScopeData(SafeScopeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SafeScopeDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>封网范围数据查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SafeScopeDataRequest
        /// </param>
        /// 
        /// <returns>
        /// SafeScopeDataResponse
        /// </returns>
        public async Task<SafeScopeDataResponse> SafeScopeDataAsync(SafeScopeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SafeScopeDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartApproveRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartApproveResponse
        /// </returns>
        public StartApproveResponse StartApproveWithOptions(StartApproveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                query["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                query["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                query["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                query["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                query["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartApprove",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartApproveResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartApproveRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartApproveResponse
        /// </returns>
        public async Task<StartApproveResponse> StartApproveWithOptionsAsync(StartApproveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                query["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                query["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorEmpId))
            {
                query["CreatorEmpId"] = request.CreatorEmpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraInfo))
            {
                query["ExtraInfo"] = request.ExtraInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                query["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceOrderId))
            {
                query["SourceOrderId"] = request.SourceOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartApprove",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartApproveResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartApproveRequest
        /// </param>
        /// 
        /// <returns>
        /// StartApproveResponse
        /// </returns>
        public StartApproveResponse StartApprove(StartApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartApproveWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartApproveRequest
        /// </param>
        /// 
        /// <returns>
        /// StartApproveResponse
        /// </returns>
        public async Task<StartApproveResponse> StartApproveAsync(StartApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartApproveWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步产品接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncProductResponse
        /// </returns>
        public SyncProductResponse SyncProductWithOptions(SyncProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncProductList))
            {
                body["SyncProductList"] = request.SyncProductList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncProduct",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncProductResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步产品接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncProductRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncProductResponse
        /// </returns>
        public async Task<SyncProductResponse> SyncProductWithOptionsAsync(SyncProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKey))
            {
                body["AuthKey"] = request.AuthKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthSign))
            {
                body["AuthSign"] = request.AuthSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqTimestamp))
            {
                body["ReqTimestamp"] = request.ReqTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncProductList))
            {
                body["SyncProductList"] = request.SyncProductList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncProduct",
                Version = "2022-01-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步产品接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncProductRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncProductResponse
        /// </returns>
        public SyncProductResponse SyncProduct(SyncProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncProductWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步产品接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncProductRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncProductResponse
        /// </returns>
        public async Task<SyncProductResponse> SyncProductAsync(SyncProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncProductWithOptionsAsync(request, runtime);
        }

    }
}
